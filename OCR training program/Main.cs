using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using NLog;

namespace OCR_training_program
{
    public partial class Main : Form
    {
        //Log記錄用的
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public int save_image_delay = 0;

        public Main()
        {
            InitializeComponent();
        }

        #region 初始化流程

        /// <summary>
        /// 初始化UI設定檔
        /// </summary>
        private void Init_Config()
        {
            //建立字元檔的資料繫結
            string[] ocr_omc_files = Directory.GetFiles(Par.OCR_File_Folder).Select(x => x.Substring(x.LastIndexOf('\\') + 1)).ToArray();
            CB_OCR_type.DataSource = ocr_omc_files;
            CB_OCR_type.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化字元資料夾 (將數字，大小寫英文字母個別分類到其他資料夾)
        /// </summary>
        private void Init_Folder()
        {
            List<char> char_list = new List<char>();
            //產生0-9的資料夾
            for (int i = 0; i < 10; i++)
            {
                char_list.Add(Convert.ToChar($"{i}"));
                string folder_path = Par.Char_Image_Folder + Par.Number_Image_Folder + char_list[i];
                if (!Directory.Exists(folder_path))
                    Directory.CreateDirectory(folder_path);
            }

            //產生a-z
            for (int i = 0; i < 26; i++)
            {
                char_list.Add((char)(i + 97));
                string folder_path = Par.Char_Image_Folder + Par.Lowercase_Char_Image_Folder + char_list[i + 10];
                if (!Directory.Exists(folder_path))
                    Directory.CreateDirectory(folder_path);
            }
            //產生A - Z
            for (int i = 0; i < 26; i++)
            {
                char_list.Add((char)(i + 65));
                string folder_path = Par.Char_Image_Folder + Par.Uppercase_Char_Image_Folder + char_list[i + 36];
                if (!Directory.Exists(folder_path))
                    Directory.CreateDirectory(folder_path);
            }
        }

        /// <summary>
        /// 程式初始化步驟
        /// 1. 初始化影像存放資料夾 =>  Init_Folder()
        /// 2. 初始化UI設定檔 => Init_Config()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Init_Folder();
            Init_Config();
        }

        #endregion 初始化流程

        #region 字元分類

        #region 欄位

        private string Compare_text;
        private int file_count;
        private string Folder_Path;
        private string Identify_result;
        private string Lowercase_Char_Saving_Path = Par.Char_Image_Folder + Par.Lowercase_Char_Image_Folder;
        private string Number_Char_Saving_Path = Par.Char_Image_Folder + Par.Number_Image_Folder;
        private string Other_Char_Saving_Path = Par.Char_Image_Folder + Par.Other_Char_Image_Folder;
        private string Uppercase_Char_Saving_Path = Par.Char_Image_Folder + Par.Uppercase_Char_Image_Folder;

        #region Halcon建構子

        private int Classify_Progress;
        private HObject ho_OriImage = new HObject();
        private HObject ho_Symbols_OCR_01_0 = new HObject();
        private HTuple hv_AcqHandle = new HTuple();
        private HTuple hv_Confidences_OCR_01_0 = new HTuple();
        private HTuple hv_Scores_OCR_01_0 = new HTuple();
        private HTuple hv_TmpCtrl_LineIndex = new HTuple(), hv_SymbolNames_OCR_01_0 = new HTuple();
        private HTuple hv_TmpCtrl_NumLines = new HTuple();
        private HTuple OCR_handel = new HTuple();
        private HTuple OCR_model = new HTuple();

        #endregion Halcon建構子

        #endregion 欄位

        #region 方法

        /// <summary>
        /// 開始批次圖像分類
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgW_Classify_DoWork(object sender, DoWorkEventArgs e)
        {
            ///步驟草稿
            ///讀取圖片
            ///辨識
            ///比對結果
            ///區域切割
            ///正確分類與不正確分類
            //lbl_Classify_State.Text = "Start";
            //更新進度條
            Classify_Progress = 0;
            bgW_Classify.ReportProgress(2);
            bgW_Classify.ReportProgress(3);
            for (int i = 0; i < file_count; i++)
            {
                Grab_Image();
                Show_Current_Image();
                Identify_Text(out Identify_result, out double Identify_confidence, out double Identify_score);
                bgW_Classify.ReportProgress(1);
                Compare_text = txt_Compare_text.Text;
                Classify_Char(Compare_text, Identify_result);
                //更新進度條
                Classify_Progress = Convert.ToInt32((i + 1) * 100 / file_count);
                bgW_Classify.ReportProgress(2);
                //延遲
                Thread.Sleep(50);
            }
            bgW_Classify.ReportProgress(4);
        }

        private void bgW_Classify_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    Show_Result(Identify_result);
                    break;

                case 2:
                    proBar_Classify_Process.Value = Classify_Progress;
                    break;

                case 3:
                    lbl_Classify_State.Text = "Working";
                    break;

                case 4:
                    lbl_Classify_State.Text = "Complete";
                    break;
            }
        }

        /// <summary>
        /// 建立OCR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_build_OCR_Click(object sender, EventArgs e)
        {
            int Word_max_Width, Word_max_High, Stroke_max_Width;
            int Word_min_Width, Word_min_High, Stroke_min_Width;
            bool Word_max_Width_auto, Word_max_High_auto, Stroke_max_Width_auto;
            bool Word_min_Width_auto, Word_min_High_auto, Stroke_min_Width_auto;
            try
            {
                //輸入OCR建立參數
                Word_min_Width = Convert.ToInt32(Tb_min_word_width.Text);
                Word_min_High = Convert.ToInt32(Tb_min_word_high.Text);
                Stroke_min_Width = Convert.ToInt32(Tb_min_width.Text);
                Word_max_Width = Convert.ToInt32(Tb_max_word_width.Text);
                Word_max_High = Convert.ToInt32(Tb_max_word_high.Text);
                Stroke_max_Width = Convert.ToInt32(Tb_max_width.Text);

                //auto 功能確認
                Word_min_Width_auto = cb_min_width_auto.Checked;
                Word_min_High_auto = cb_min_word_high_auto.Checked;
                Stroke_min_Width_auto = cb_min_width_auto.Checked;
                Word_max_High_auto = cb_max_word_high_auto.Checked;
                Word_max_Width_auto = cb_max_word_width_auto.Checked;
                Stroke_max_Width_auto = cb_max_width_auto.Checked;
            }
            catch
            {
                MessageBox.Show("OCR參數有誤!!");
                return;
            }

            OCR_handel.Dispose();
            string selected_OCR_file = CB_OCR_type.SelectedItem.ToString();
            HOperatorSet.ReadOcrClassMlp(selected_OCR_file, out OCR_handel);
            HOperatorSet.CreateTextModelReader("auto", OCR_handel, out OCR_model);
            HOperatorSet.SetTextModelParam(OCR_model, "dot_print", "true");
            HOperatorSet.SetTextModelParam(OCR_model, "min_contrast", 4);
            HOperatorSet.SetTextModelParam(OCR_model, "polarity", "dark_on_light");
            HOperatorSet.SetTextModelParam(OCR_model, "eliminate_border_blobs", "false");
            HOperatorSet.SetTextModelParam(OCR_model, "add_fragments", "false");
            if (Word_min_Width_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "min_char_width", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "min_char_width", Word_min_Width);
            if (Word_min_High_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "min_char_height", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "min_char_height", Word_min_High);
            if (Word_max_Width_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "max_char_width", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "max_char_width", Word_max_Width);
            if (Word_max_High_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "max_char_height", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "max_char_height", Word_max_High);
            if (Stroke_min_Width_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "min_stroke_width", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "min_stroke_width", Stroke_min_Width);
            if (Stroke_max_Width_auto)
                HOperatorSet.SetTextModelParam(OCR_model, "max_stroke_width", "auto");
            else
                HOperatorSet.SetTextModelParam(OCR_model, "max_stroke_width", Stroke_max_Width);
            HOperatorSet.SetTextModelParam(OCR_model, "return_punctuation", "false");
            HOperatorSet.SetTextModelParam(OCR_model, "num_classes", 3);
        }

        /// <summary>
        /// 影像連線
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Folder_Path = txt_file_path.Text;
            if (Directory.Exists(Folder_Path))
            {
                hv_AcqHandle.Dispose();
                HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default", -1, "false", Folder_Path, "default", 1, -1, out hv_AcqHandle);
            }

            DirectoryInfo di = new DirectoryInfo(Folder_Path);
            FileInfo[] files = di.GetFiles("*.tiff"); //篩選副檔名為xls的 //取得所有的excel檔 會存入陣列裡面
            file_count = files.Length; //取得個數
            //啟動按鈕
            btn_Run.Enabled = true;
            btn_Trigger.Enabled = true;
        }

        /// <summary>
        /// 讀取影像資料夾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_image_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != txt_file_path.Text)
                {
                    txt_file_path.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //防比對字串未輸入
            if (txt_Compare_text.Text.Equals(string.Empty))
            {
                MessageBox.Show("比對資料未輸入!");
                return;
            }

            //防尚未建立OCR_handle
            if (OCR_model.Length.Equals(0))
            {
                MessageBox.Show("OCR未建立");
                return;
            }
            lbl_Classify_State.Text = "Start";
            bgW_Classify.RunWorkerAsync();
        }

        /// <summary>
        /// 觸發檢測
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Trigger_Click(object sender, EventArgs e)
        {
            //防比對字串未輸入
            if (txt_Compare_text.Text.Equals(string.Empty))
            {
                MessageBox.Show("比對資料未輸入!");
                return;
            }

            //防尚未建立OCR_handle
            if (OCR_model.Length.Equals(0))
            {
                MessageBox.Show("OCR未建立");
                return;
            }

            Grab_Image();
            Show_Current_Image();
            Identify_Text(out Identify_result, out double Identify_confidence, out double Identify_score);
            Show_Result(Identify_result);
            Compare_text = txt_Compare_text.Text;
            Classify_Char(Compare_text, Identify_result);
        }

        /// <summary>
        /// 開啟字元設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_OCR_Setting_CheckedChanged(object sender, EventArgs e)
        {
            string cb_name = ((CheckBox)sender).Name;
            bool cb_state = ((CheckBox)sender).Checked;
            switch (cb_name)
            {
                case "cb_max_word_high_auto":
                    if (cb_state)
                    {
                        Tb_max_word_high.Enabled = false;
                        Tb_max_word_high.Text = "0";
                    }
                    else
                    {
                        Tb_max_word_high.Enabled = true;
                    }
                    break;

                case "cb_min_word_high_auto":
                    if (cb_state)
                    {
                        Tb_min_word_high.Enabled = false;
                        Tb_min_word_high.Text = "0";
                    }
                    else
                    {
                        Tb_min_word_high.Enabled = true;
                    }
                    break;

                case "cb_max_word_width_auto":
                    if (cb_state)
                    {
                        Tb_max_word_width.Enabled = false;
                        Tb_max_word_width.Text = "0";
                    }
                    else
                    {
                        Tb_max_word_width.Enabled = true;
                    }
                    break;

                case "cb_min_word_width_auto":
                    if (cb_state)
                    {
                        Tb_min_word_width.Enabled = false;
                        Tb_min_word_width.Text = "0";
                    }
                    else
                    {
                        Tb_min_word_width.Enabled = true;
                    }
                    break;

                case "cb_max_width_auto":
                    if (cb_state)
                    {
                        Tb_max_width.Enabled = false;
                        Tb_max_width.Text = "0";
                    }
                    else
                    {
                        Tb_max_width.Enabled = true;
                    }
                    break;

                case "cb_min_width_auto":
                    if (cb_state)
                    {
                        Tb_min_width.Enabled = false;
                        Tb_min_width.Text = "0";
                    }
                    else
                    {
                        Tb_min_width.Enabled = true;
                    }
                    break;
            }
        }

        /// <summary>
        /// 字元分類與存檔 (存檔資料夾需要在命名) (待測試)
        /// </summary>
        private void Classify_Char(string compare_text, string idenify_result)
        {
            ///步驟草稿
            ///1. 分析影像Blob的數目
            ///2. 判定
            ///2.1 字數與Blob是否一致(比對字數與Blob的數目)，不一致則全存檔
            ///2.2 判定內容與比對結果是否相同
            ///如果部分不相同，辨識錯誤的文字，分配到例外資料夾
            ///如果相同，則存檔到辨識正確的資料夾內
            HOperatorSet.BinaryThreshold(ho_OriImage, out HObject ho_Region, "max_separability", "dark", out HTuple hv_UsedThreshold);
            HOperatorSet.Connection(ho_Region, out HObject ho_ConnectedRegions);
            HOperatorSet.SelectShape(ho_ConnectedRegions, out HObject ho_SelectedRegions, "area", "and", 997.36, 1745.05);
            HOperatorSet.CountObj(ho_SelectedRegions, out HTuple ho_Blob_Number);
            HOperatorSet.SortRegion(ho_SelectedRegions, out HObject ho_SortedRegions, "first_point", "true", "column");
            HOperatorSet.RegionFeatures(ho_SortedRegions, "row1", out HTuple row1);
            HOperatorSet.RegionFeatures(ho_SortedRegions, "column1", out HTuple column1);
            HOperatorSet.RegionFeatures(ho_SortedRegions, "row2", out HTuple row2);
            HOperatorSet.RegionFeatures(ho_SortedRegions, "column2", out HTuple column2);
            HOperatorSet.RegionFeatures(ho_SortedRegions, "width", out HTuple width);
            HOperatorSet.RegionFeatures(ho_SortedRegions, "height", out HTuple height);
            HOperatorSet.GenRectangle1(out HObject ho_Char_Rectangle, row1, column1, row2, column2);
            //框選區域顯示用
            HOperatorSet.GenContourRegionXld(ho_Char_Rectangle, out HObject ho_Char_Contours, "border");
            //Analysis_Blob(out int blob_num, out HObject char_contours);
            bool condition1 = compare_text.Length.Equals(ho_Blob_Number.I);
            bool condition2 = compare_text.Length == idenify_result.Length;
            bool condition3 = compare_text == idenify_result;
            if (condition1)//先判斷影像比對字數
            {
                if (condition2)//判斷辨識後的比對字數
                {
                    if (condition3) //判斷辨識內容
                    {
                        //顯示畫面
                        HOperatorSet.SetDraw(HSWC.HalconWindow, "margin");
                        HOperatorSet.SetColor(HSWC.HalconWindow, "blue");
                        HOperatorSet.DispObj(ho_Char_Contours, HSWC.HalconWindow);
                        ////正確，不存擋
                        //HOperatorSet.SelectObj(ho_Char_Rectangle, out HObject ho_Selected_Region, i);
                        //HOperatorSet.ReduceDomain(ho_OriImage, ho_Selected_Region, out HObject Image_Reduce);
                        //HOperatorSet.CropDomain(Image_Reduce, out HObject Image_Crop);
                        //HOperatorSet.WriteImage(Image_Crop, "tiff", 0, "檔名暫定");
                    }
                    else
                    {
                        //找出錯字
                        char[] compare_chars = compare_text.ToCharArray();
                        char[] idenify_chars = idenify_result.ToCharArray();
                        for (int i = 0; i < compare_chars.Length; i++)
                        {
                            if (compare_chars[i] != idenify_chars[i]) //不正確
                            {
                                //顯示畫面
                                HOperatorSet.SelectObj(ho_Char_Contours, out HObject ho_Selected_Contours, i + 1);
                                HOperatorSet.SetDraw(HSWC.HalconWindow, "margin");
                                HOperatorSet.SetColor(HSWC.HalconWindow, "red");
                                HOperatorSet.DispObj(ho_Selected_Contours, HSWC.HalconWindow);
                                //存圖
                                HOperatorSet.SelectObj(ho_Char_Rectangle, out HObject ho_Selected_Region, i + 1);
                                HOperatorSet.ReduceDomain(ho_OriImage, ho_Selected_Region, out HObject Image_Reduce);
                                HOperatorSet.CropDomain(Image_Reduce, out HObject Image_Crop);
                                HOperatorSet.WriteImage(Image_Crop, "tiff", 0, GetFileName(GetFilePath(compare_chars[i]), "Other"));
                                Thread.Sleep(save_image_delay);
                            }
                            else //正確
                            {
                                //顯示畫面
                                HOperatorSet.SelectObj(ho_Char_Contours, out HObject ho_Selected_Contours, i + 1);
                                HOperatorSet.SetDraw(HSWC.HalconWindow, "margin");
                                HOperatorSet.SetColor(HSWC.HalconWindow, "blue");
                                HOperatorSet.DispObj(ho_Selected_Contours, HSWC.HalconWindow);
                                //正確，存擋
                                HOperatorSet.SelectObj(ho_Char_Rectangle, out HObject ho_Selected_Region, i + 1);
                                HOperatorSet.ReduceDomain(ho_OriImage, ho_Selected_Region, out HObject Image_Reduce);
                                HOperatorSet.CropDomain(Image_Reduce, out HObject Image_Crop);

                                //存圖動作

                                HOperatorSet.WriteImage(Image_Crop, "tiff", 0, GetFileName(GetFilePath(compare_chars[i]), compare_chars[i].ToString()));
                                Thread.Sleep(save_image_delay);
                            }
                        }
                    }
                }
                else
                {
                    //全截圖存擋
                    for (int i = 0; i < ho_Blob_Number.I; i++)
                    {
                        //顯示畫面
                        HOperatorSet.SelectObj(ho_Char_Contours, out HObject ho_Selected_Contours, i + 1);
                        HOperatorSet.SetDraw(HSWC.HalconWindow, "margin");
                        HOperatorSet.SetColor(HSWC.HalconWindow, "red");
                        HOperatorSet.DispObj(ho_Char_Contours, HSWC.HalconWindow);
                        //
                        HOperatorSet.SelectObj(ho_Char_Rectangle, out HObject ho_Selected_Region, i);
                        HOperatorSet.ReduceDomain(ho_OriImage, ho_Selected_Region, out HObject Image_Reduce);
                        HOperatorSet.CropDomain(Image_Reduce, out HObject Image_Crop);
                        //存圖動作
                        HOperatorSet.WriteImage(Image_Crop, "tiff", 0, GetFileName(Other_Char_Saving_Path, "Other"));
                        Thread.Sleep(save_image_delay);
                    }
                }
            }
            else
            {
                //顯示畫面
                HOperatorSet.SetDraw(HSWC.HalconWindow, "margin");
                HOperatorSet.SetColor(HSWC.HalconWindow, "red");
                HOperatorSet.DispObj(ho_Char_Contours, HSWC.HalconWindow);
                //全截圖存擋
                for (int i = 0; i < ho_Blob_Number.I; i++)
                {
                    HOperatorSet.SelectObj(ho_Char_Rectangle, out HObject ho_Selected_Region, i);
                    HOperatorSet.ReduceDomain(ho_OriImage, ho_Selected_Region, out HObject Image_Reduce);
                    HOperatorSet.CropDomain(Image_Reduce, out HObject Image_Crop);
                    //存圖動作
                    HOperatorSet.WriteImage(Image_Crop, "tiff", 0, GetFileName(Other_Char_Saving_Path, "Other"));
                    Thread.Sleep(save_image_delay);
                }
            }
        }

        #region 分析Blob數目

        ///// <summary>
        ///// 分析Blob數目
        ///// </summary>
        //private void Analysis_Blob(out int char_number, out HObject Char_Contours)
        //{
        //    HOperatorSet.BinaryThreshold(ho_OriImage, out HObject ho_Region, "max_separability", "dark", out HTuple hv_UsedThreshold);
        //    HOperatorSet.Connection(ho_Region, out HObject ho_ConnectedRegions);
        //    HOperatorSet.SelectShape(ho_ConnectedRegions, out HObject ho_SelectedRegions, "area", "and", 997.36, 1745.05);
        //    HOperatorSet.CountObj(ho_SelectedRegions, out HTuple ho_Blob_Number);
        //    char_number = ho_Blob_Number.I;
        //    HOperatorSet.SortRegion(ho_SelectedRegions, out HObject ho_SortedRegions, "first_point", "true", "column");
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "row1", out HTuple row1);
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "column1", out HTuple column1);
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "row2", out HTuple row2);
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "column2", out HTuple column2);
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "width", out HTuple width);
        //    HOperatorSet.RegionFeatures(ho_SortedRegions, "height", out HTuple height);
        //    HOperatorSet.GenRectangle1(out HObject ho_Char_Rectangle, row1, column1, row2, column2);
        //    //框選區域顯示用
        //    HOperatorSet.GenContourRegionXld(ho_Char_Rectangle, out HObject ho_Char_Contours, "border");
        //    Char_Contours = ho_Char_Contours;
        //}

        #endregion 分析Blob數目

        /// <summary>
        /// 取得存檔名稱
        /// </summary>
        /// <param name="Save_Path"></param>
        /// <returns></returns>
        private string GetFileName(string Save_Path, string Char_Name)
        {
            ///步驟草稿
            ///1. 取得當前資料夾的狀態(檔案數)
            ///2. 檔名命名定義(yyyy_MM_dd_HH_mm_字母_第幾個擋名)
            ///3. 回傳檔名
            //DirectoryInfo directoryInfo = new DirectoryInfo(Save_Path);
            //int file_count = directoryInfo.GetFiles().Length; //取得檔案數量
            string file_name = string.Empty;
            do
            {
                file_name = Save_Path + $"{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}_{Char_Name}" + Random_Code();
            } while (File.Exists(file_name));
            return file_name;
        }

        /// <summary>
        /// 根據輸入的字元，回傳應該要存的檔案路徑
        /// </summary>
        /// <param name="char_name"></param>
        /// <returns></returns>
        private string GetFilePath(char char_name)
        {
            switch (Char.GetUnicodeCategory(char_name))
            {
                case System.Globalization.UnicodeCategory.UppercaseLetter:
                    return Uppercase_Char_Saving_Path;
                    break;

                case System.Globalization.UnicodeCategory.LowercaseLetter:
                    return Lowercase_Char_Saving_Path;
                    break;

                case System.Globalization.UnicodeCategory.DecimalDigitNumber:
                    return Number_Char_Saving_Path;
                    break;

                default:
                    return string.Empty;
                    break;
            }
        }

        /// <summary>
        /// 取得影像
        /// </summary>
        private void Grab_Image()
        {
            HOperatorSet.GrabImage(out ho_OriImage, hv_AcqHandle);
        }

        /// <summary>
        /// 辨識文字
        /// </summary>
        private void Identify_Text(out string identify_result, out double identify_Confidence, out double idenify_Score)
        {
            //這邊要擋，尚未建立OCR時，按下Trigger
            HOperatorSet.FindText(ho_OriImage, OCR_model, out HTuple textResultID);
            hv_TmpCtrl_NumLines.Dispose();
            HOperatorSet.GetTextResult(textResultID, "num_lines", out hv_TmpCtrl_NumLines);
            HTuple end_val90 = hv_TmpCtrl_NumLines - 1;
            HTuple step_val90 = 1;
            HTuple Words = new HTuple();
            HTuple Confidence = new HTuple();
            HTuple Score = new HTuple();
            for (hv_TmpCtrl_LineIndex = 0; hv_TmpCtrl_LineIndex.Continue(end_val90, step_val90); hv_TmpCtrl_LineIndex = hv_TmpCtrl_LineIndex.TupleAdd(step_val90))
            {
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    ho_Symbols_OCR_01_0.Dispose();
                    HOperatorSet.GetTextObject(out ho_Symbols_OCR_01_0, textResultID, (new HTuple("line")).TupleConcat(hv_TmpCtrl_LineIndex));
                }
                HOperatorSet.DoOcrWordMlp(ho_Symbols_OCR_01_0, ho_OriImage, OCR_handel, "^[0-9A-Za-z]*$", 5, 5, out hv_SymbolNames_OCR_01_0, out Confidence, out Words, out Score);
            }
            identify_result = Words.S;
            identify_Confidence = Confidence.D;
            idenify_Score = Score.D;
            Words.Dispose(); Confidence.Dispose(); Score.Dispose();
        }

        /// <summary>
        /// 亂碼產生器
        /// </summary>
        /// <returns></returns>
        private string Random_Code()
        {
            //亂碼產生器
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            int passwordLength = 25;//密碼長度
            char[] chars = new char[passwordLength];
            Random rd = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                //allowedChars -> 這個String ，隨機取得一個字，丟給chars[i]
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }
            return new string(chars);
        }

        /// <summary>
        /// 顯示當下的影像
        /// </summary>
        private void Show_Current_Image()
        {
            HSWC.HalconWindow.ClearWindow();
            HOperatorSet.GetImageSize(ho_OriImage, out HTuple W, out HTuple H);
            HOperatorSet.SetPart(HSWC.HalconWindow, 0, 0, H - 1, W - 1);

            HOperatorSet.DispObj(ho_OriImage, HSWC.HalconWindow);
            HOperatorSet.GetImageSize(ho_OriImage, out HTuple w, out HTuple h);
        }

        /// <summary>
        /// 顯示辨識結果
        /// </summary>
        private void Show_Result(string text)
        {
            txt_Identify_result.Text = text;
        }

        #endregion 方法

        #endregion 字元分類
    }
}