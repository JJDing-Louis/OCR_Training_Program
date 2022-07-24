﻿using System;
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

        /// <summary>
        /// 建立字元陣列用
        /// 0~9 : 0-9
        /// 10-35 :a-z
        /// 36-61:A-Z
        /// </summary>
        private List<string> Char_Array = new List<string>();

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
            //訓練內插值_設定初始化
            cBx_Interpolate.SelectedIndex = 0;
            //進階特徵_設定初始化
            cLB_Advance_Setting.SetItemChecked(1, true);
            //比對條件_設定初始化
            cbo_Comparison_Condition.SelectedIndex = 0;
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

            #region 偷懶寫字串用

            //using (StreamWriter sw = new StreamWriter(@"char_data.txt"))
            //{
            //    foreach (var item in char_list)
            //    {
            //        sw.Write($"'{item}',");
            //    }
            //}

            #endregion 偷懶寫字串用

            //產生字元陣列，給Halcon Library使用
            foreach (var item in char_list)
                Char_Array.Add($"\"{item}\"");
            ///初始化資料夾
            ///訓練檔的
            if (!Directory.Exists(Par.OCR_Traing_FilePath))
                Directory.CreateDirectory(Par.OCR_Traing_FilePath);
            ///輸出的訓練檔
            if (!Directory.Exists(Par.OCR_OMC_FilePath))
                Directory.CreateDirectory(Par.OCR_OMC_FilePath);
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

        #region Halcon欄位

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

        #endregion Halcon欄位

        #endregion 欄位

        #region 控鍵

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

        /// <summary>
        /// 分類功能的背景程序處裡結果 (待整理)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 開始批次辨識
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion 控鍵

        #region 方法

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

        #region 分析Blob數目(可能用不到)

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

        #endregion 分析Blob數目(可能用不到)

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

        #region 字元訓練

        #region 欄位

        private List<string> Advance_Region_Feature = new List<string>();
        private List<string> Basic_Region_Feature = new List<string>();
        private string OCR_Training_FileName = string.Empty;
        private string OCR_Training_Interpolate = string.Empty;

        /// <summary>
        /// 紀錄訓練狀態的階段
        /// </summary>
        private string Traing_State = string.Empty;

        private enum Training_Interpolate_Option : int
        { constant, nearest_neighbor, bilinear, weighted }

        #endregion 欄位

        #region Halcon欄位

        private HObject Characters_Images = new HObject();
        private HTuple Characters_Names = new HTuple();
        private HTuple hv_OCRHandle = new HTuple();
        private HTuple OCR_Handle = new HTuple();
        private HTuple OCR_Training_Feature = new HTuple();
        private HTuple OCR_Training_Words = new HTuple();
        private HTuple Training_Error = new HTuple();
        private HTuple Training_Error_Log = new HTuple();

        #endregion Halcon欄位

        #region 控鍵

        /// <summary>
        /// 讀取已存在的OCR訓練檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Traing_File_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "*.trf|";
                openFileDialog.InitialDirectory = Par.OCR_Traing_FilePath;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OCR_Training_FileName = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\") + 1);
                    txt_Train_OCR_Filename.Text = OCR_Training_FileName;
                }
            }
        }

        /// <summary>
        /// 開始字元訓練
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Train_OCR_Click(object sender, EventArgs e)
        {
            if (!bgW_TraingOCR.IsBusy)
            {
                bgW_TraingOCR.RunWorkerAsync();
            }
        }

        /// <summary>
        /// 測試用按鈕 => Append_OCR_Image()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Append_OCR_Image();
        }

        /// <summary>
        /// 測試用按鈕 => Read_Training_Condition()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            Set_Training_Condition();
        }

        /// <summary>
        /// 開啟進階特徵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cB_Advance_Setting_Enable_CheckedChanged(object sender, EventArgs e)
        {
            gBx_Advance_Setting.Enabled = cB_Advance_Setting_Enable.Checked ? true : false;
        }

        private void cB_Basic_Feature_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checked_item = (CheckBox)sender;
            switch (checked_item.Name)
            {
                case "cB_ratio":
                    cLB_Advance_Setting.SetItemChecked(8, checked_item.Checked ? true : false);
                    break;

                case "cB_anisometry":
                    cLB_Advance_Setting.SetItemChecked(9, checked_item.Checked ? true : false);
                    break;

                case "cB_convexity":
                    cLB_Advance_Setting.SetItemChecked(17, checked_item.Checked ? true : false);
                    break;
            }
        }

        private void cLB_Advance_Setting_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cLB_Advance_Setting.Items[cLB_Advance_Setting.SelectedIndex].ToString())
            {
                case "ratio":
                    cB_ratio.Checked = cLB_Advance_Setting.GetItemChecked(cLB_Advance_Setting.SelectedIndex) ? true : false;
                    break;

                case "anisometry":
                    cB_anisometry.Checked = cLB_Advance_Setting.GetItemChecked(cLB_Advance_Setting.SelectedIndex) ? true : false;
                    break;

                case "convexity":
                    cB_convexity.Checked = cLB_Advance_Setting.GetItemChecked(cLB_Advance_Setting.SelectedIndex) ? true : false;
                    break;
            }
        }

        /// <summary>
        /// 控見控制設定(基礎區域)
        /// Bug: 一開始選灰階值時，進階設定的選項不會同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_region_feature_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checked_item = (RadioButton)sender;
            switch (checked_item.Name)
            {
                case "rdo_pixel_invar":
                    rdo_pixel_invar.Checked = true;
                    rdo_pixel_binary.Checked = false;
                    rdo_gradient_8dir.Checked = false;
                    //CheckListBox設定同步
                    cLB_Advance_Setting.SetItemChecked(1, true);
                    cLB_Advance_Setting.SetItemChecked(2, false);
                    cLB_Advance_Setting.SetItemChecked(3, false);

                    break;

                case "rdo_pixel_binary":
                    rdo_pixel_invar.Checked = false;
                    rdo_pixel_binary.Checked = true;
                    rdo_gradient_8dir.Checked = false;
                    //CheckListBox設定同步
                    cLB_Advance_Setting.SetItemChecked(1, false);
                    cLB_Advance_Setting.SetItemChecked(2, true);
                    cLB_Advance_Setting.SetItemChecked(3, false);
                    break;

                case "rdo_gradient_8dir":
                    rdo_pixel_invar.Checked = false;
                    rdo_pixel_binary.Checked = false;
                    rdo_gradient_8dir.Checked = true;
                    //CheckListBox設定同步
                    cLB_Advance_Setting.SetItemChecked(1, false);
                    cLB_Advance_Setting.SetItemChecked(2, false);
                    cLB_Advance_Setting.SetItemChecked(3, true);
                    break;
            }
        }

        #endregion 控鍵

        #region Method

        /// <summary>
        /// 將OCR圖檔加入OCR訓練檔
        /// </summary>
        private void Append_OCR_Image()
        {
            //Log
            Traing_State = $"Append_OCR_Image()";
            bgW_TraingOCR.ReportProgress(1);

            //遍歷圖檔
            ///Step 1.取得所有檔案的資料夾
            ///數字
            List<string> Number_Char_dir = Directory.GetDirectories(Par.Char_Image_Folder + Par.Number_Image_Folder).ToList();
            ///大寫
            List<string> Upper_Case_Char_dir = Directory.GetDirectories(Par.Char_Image_Folder + Par.Uppercase_Char_Image_Folder).ToList();
            ///小寫
            List<string> Lower_Case_Char_dir = Directory.GetDirectories(Par.Char_Image_Folder + Par.Lowercase_Char_Image_Folder).ToList();
            //加入訓練檔
            ///Step 1
            ///先判定訓練檔是否存在
            //if (File.Exists())
            //{
            //}
            ///Step 2: 將所有檔加入訓練檔
            ///數字
            for (int i = 0; i < Number_Char_dir.Count; i++)
            {
                string[] image_files = Directory.GetFiles(Number_Char_dir[i], "*.tiff|*.tif");
                for (int j = 0; j < image_files.Length; j++)
                {
                    HOperatorSet.ReadImage(out HObject current_image, image_files[j]);
                    HOperatorSet.BinaryThreshold(current_image, out HObject current_region, "max_separability", "dark", out HTuple current_Threshold);
                    HOperatorSet.AppendOcrTrainf(current_region, current_image, Number_Char_dir[i].Substring(Number_Char_dir[i].LastIndexOf('\\') + 1), Par.OCR_Traing_FilePath + OCR_Training_FileName);
                }
            }
            ///大寫字母
            for (int i = 0; i < Upper_Case_Char_dir.Count; i++)
            {
                string[] image_files = Directory.GetFiles(Upper_Case_Char_dir[i], "*.tiff|*.tif");
                for (int j = 0; j < image_files.Length; j++)
                {
                    HOperatorSet.ReadImage(out HObject current_image, image_files[j]);
                    HOperatorSet.BinaryThreshold(current_image, out HObject current_region, "max_separability", "dark", out HTuple current_Threshold);
                    HOperatorSet.AppendOcrTrainf(current_region, current_image, Upper_Case_Char_dir[i].Substring(Upper_Case_Char_dir[i].LastIndexOf('\\') + 1), Par.OCR_Traing_FilePath + OCR_Training_FileName);
                }
            }
            ///小寫字母
            for (int i = 0; i < Lower_Case_Char_dir.Count; i++)
            {
                string[] image_files = Directory.GetFiles(Lower_Case_Char_dir[i], "*.tiff|*.tif");
                for (int j = 0; j < image_files.Length; j++)
                {
                    HOperatorSet.ReadImage(out HObject current_image, image_files[j]);
                    HOperatorSet.BinaryThreshold(current_image, out HObject current_region, "max_separability", "dark", out HTuple current_Threshold);
                    HOperatorSet.AppendOcrTrainf(current_region, current_image, Lower_Case_Char_dir[i].Substring(Lower_Case_Char_dir[i].LastIndexOf('\\') + 1), Par.OCR_Traing_FilePath + OCR_Training_FileName);
                }
            }
        }

        /// <summary>
        /// 開始訓練OCR背景程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgW_TraingOCR_DoWork(object sender, DoWorkEventArgs e)
        {
            ///步驟草稿
            ///1. 讀取命名檔名(需有訓練檔命名規則)
            ///2. 讀取已有的訓練檔或者建立新檔
            Load_or_Create_OCR_Traing_File();
            ///3. 遍歷圖檔並加入訓練檔
            Append_OCR_Image();
            ///4. 讀取設定條件
            Set_Training_Condition();
            /// 4.1建立OCR_handle
            Create_OCR_Handle();
            ///5. 開始訓練
            Train_OCR_Handle();
            ///6. 輸出訓練檔
            Output_OCR_OMC();
            ///更新狀態(訓練完成)
            ///Log
            Traing_State = $"Finish Training";
            bgW_TraingOCR.ReportProgress(1);
        }

        private void bgW_TraingOCR_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1: //紀錄Log
                    logger.Info($"{Traing_State}");
                    break;

                case 2: //更新訓練狀態的UI(尚未建立)

                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 建立OCR Handle
        /// </summary>
        private void Create_OCR_Handle()
        {
            //Log
            Traing_State = $"Create_OCR_Handle()";
            bgW_TraingOCR.ReportProgress(1);

            HOperatorSet.CreateOcrClassMlp(8, 10, OCR_Training_Interpolate, OCR_Training_Feature, OCR_Training_Words, 215, "none", 100, 42, out OCR_Handle);
        }

        /// <summary>
        /// 建立，或者讀取已存在的OCR_File
        /// </summary>
        private void Load_or_Create_OCR_Traing_File()
        {
            //Log
            Traing_State = $"Load_or_Create_OCR_Traing_File()";
            bgW_TraingOCR.ReportProgress(1);

            //開始流程
            if (txt_Train_OCR_Filename.Text != string.Empty)
            {
                OCR_Training_FileName = txt_Train_OCR_Filename.Text;
            }
            else
            {
                MessageBox.Show("尚未建立OCR訓練檔的名稱");
            }
            //OCR訓練檔路徑
            string file_path = Par.OCR_Traing_FilePath + OCR_Training_FileName;
            if (File.Exists(file_path))
            {
                //讀取OCR訓練檔
                HOperatorSet.ReadOcrTrainf(out Characters_Images, file_path, out Characters_Names);
            }
            else
            {
                //建立OCR訓練檔 (待思考如何建立)
                ///備註: Halcon似乎無法建立空白的 trf檔案
                //只讀檔，不做任何動作
            }
        }

        /// <summary>
        /// 輸出OCR以訓練好的訓練檔
        /// </summary>
        private void Output_OCR_OMC()
        {
            //Log
            Traing_State = $"Output_OCR_OMC()";
            bgW_TraingOCR.ReportProgress(1);
            HOperatorSet.WriteOcrClassMlp(OCR_Handle, "C:/Users/LouisDing/Desktop/測試訓練檔.omc");
        }

        /// <summary>
        /// 讀取設定條件
        /// </summary>
        private void Set_Training_Condition()
        {
            //Log
            Traing_State = $"Set_Training_Condition()";
            bgW_TraingOCR.ReportProgress(1);
            ///讀取訓練模式
            switch (cBx_Interpolate.SelectedIndex)
            {
                case (int)Training_Interpolate_Option.constant:
                    OCR_Training_Interpolate = "constant";
                    break;

                case (int)Training_Interpolate_Option.nearest_neighbor:
                    OCR_Training_Interpolate = "nearest_neighbor";
                    break;

                case (int)Training_Interpolate_Option.bilinear:
                    OCR_Training_Interpolate = "bilinear";
                    break;

                case (int)Training_Interpolate_Option.weighted:
                    OCR_Training_Interpolate = "weighted";
                    break;
            }
            ///讀取基礎特徵
            ///Step 1:讀取區域設定
            ///gBx_Basic_Setting.Controls
            ///Step 2: 讀取基礎特徵設定
            ///在想一下如何優化
            //radiobutton
            Basic_Region_Feature.Add(rdo_pixel_invar.Checked ? "pixel_invar" : null);
            Basic_Region_Feature.Add(rdo_pixel_binary.Checked ? "pixel_binary" : null);
            Basic_Region_Feature.Add(rdo_gradient_8dir.Checked ? "gradient_8dir" : null);
            //checkbox
            Basic_Region_Feature.Add(cB_ratio.Checked ? "ratio" : null);
            Basic_Region_Feature.Add(cB_anisometry.Checked ? "anisometry" : null);
            Basic_Region_Feature.Add(cB_convexity.Checked ? "convexity" : null);
            Basic_Region_Feature.RemoveAll(x => x == null);
            ///讀取進階特徵
            //先確認是否有開啟進階特徵，有才要讀取
            if (cB_Advance_Setting_Enable.Checked)
            {
                for (int i = 0; i < cLB_Advance_Setting.CheckedItems.Count; i++)
                {
                    Advance_Region_Feature.Add(cLB_Advance_Setting.CheckedItems[i].ToString());
                }
            }
            List<string> Total_Region_Feature = new List<string>();
            Total_Region_Feature.AddRange(Basic_Region_Feature);
            Total_Region_Feature.AddRange(Advance_Region_Feature);
            Total_Region_Feature = Total_Region_Feature.Distinct().ToList();//刪除重複值
            //將訓練特徵，寫入Halcon Library
            for (int i = 0; i < Total_Region_Feature.Count; i++)
            {
                OCR_Training_Feature[i] = Total_Region_Feature[i].ToString();
            }
            //將要訓練的字，寫入Halcon Library
            for (int i = 0; i < Char_Array.Count; i++)
            {
                OCR_Training_Words[i] = Char_Array[i];
            }
        }

        /// <summary>
        /// 訓練OCR
        /// </summary>
        private void Train_OCR_Handle()
        {
            //Log
            Traing_State = $"Train_OCR_Handle()";
            bgW_TraingOCR.ReportProgress(1);

            HOperatorSet.TrainfOcrClassMlp(OCR_Handle, Par.OCR_Traing_FilePath + OCR_Training_FileName, 200, 1, 0.01, out Training_Error, out Training_Error_Log);
        }

        #endregion Method

        #endregion 字元訓練

        #region 辨識測試

        #region 欄位

        private int Test_Folder_File_Count;
        private string Test_Folder_Path = string.Empty;

        #endregion 欄位

        #region Halcon欄位

        private HTuple hv_OCRTest_AcqHandle = new HTuple();

        #endregion Halcon欄位

        #region 控鍵

        /// <summary>
        /// 載入測試資料夾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_TestFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fBD = new FolderBrowserDialog())
            {
                if ((fBD.ShowDialog() == DialogResult.OK) && (fBD.SelectedPath != txt_Test_Folder_Path.Text))
                {
                    txt_Test_Folder_Path.Text = fBD.SelectedPath;
                }
            }
        }

        /// <summary>
        /// 開始執行OCR測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Run_Image_Test_Click(object sender, EventArgs e)
        {
            bgW_RunTestOCR.RunWorkerAsync();
        }

        /// <summary>
        /// 單次觸發測試
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SingleTest_Trigger_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 測試資料夾連線
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TestFolder_Connect_Click(object sender, EventArgs e)
        {
            Test_Folder_Path = txt_Test_Folder_Path.Text;
            if (Directory.Exists(Test_Folder_Path))
            {
                hv_OCRTest_AcqHandle.Dispose();
                HOperatorSet.OpenFramegrabber("File", 1, 1, 0, 0, 0, 0, "default", -1, "default", -1, "false", Folder_Path, "default", 1, -1, out hv_OCRTest_AcqHandle);
            }
            Test_Folder_File_Count = new DirectoryInfo(Test_Folder_Path).GetFiles("*.tiff").Length; //計算測試資料夾的圖檔資料
        }

        #endregion 控鍵

        #endregion 辨識測試
    }
}