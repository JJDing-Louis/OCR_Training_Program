using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace OCR_training_program
{
    public partial class OCR_Training_File_Browser : Form
    {

        #region 欄位
        /// <summary>
        ///  字元檔的路徑
        /// </summary>
        private string trf_file_path;

        /// <summary>
        /// 被選取的字元分類
        /// </summary>
        private string target_char;

        /// <summary>
        /// 訓練檔的字元清單
        /// </summary>
        private List<string> chars_category = new List<string>();
        #endregion 欄位

        #region Halcon欄位
        /// <summary>
        /// 字元清單
        /// </summary>
        private HTuple chars_list;
        /// <summary>
        /// 字元圖像
        /// </summary>
        private HObject chars_image;
        #endregion Halcon欄位

        #region 建構子
        /// <summary>
        /// 建構子
        /// </summary>
        public OCR_Training_File_Browser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 建構子多載，內容 (Option1_待測試)
        /// 1. OCR_Char_Image
        /// 2. OCR_Char_List
        /// </summary>
        public OCR_Training_File_Browser(string trf_file_path)
        {
            InitializeComponent();
            this.trf_file_path = trf_file_path;
        }

        /// <summary>
        /// 建構子多載，內容 (Option2_待測試)
        /// 1. OCR_Char_Image
        /// 2. OCR_Char_List
        /// </summary>
        public OCR_Training_File_Browser(HObject Chars_Image, HTuple Chars_List)
        {
            InitializeComponent();
            this.chars_image = Chars_Image;
            this.chars_list = Chars_List;
        }
        #endregion 建構子

        #region 控鍵
        /// <summary>
        /// 表單載入時的執行動作
        /// 1.讀取字元檔的內容，建立字元分類表，顯示在TreeView
        /// 2. 讀取字元檔的內容，並顯示在dgv上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OCR_Training_File_Browser_Load(object sender, EventArgs e)
        {
            Establish_Chars_Category();
            Update_Chars_Category_of_TreeView();
        }
        /// <summary>
        /// OCR_Category選取時，的觸發事件
        /// 步驟
        /// 1. 取得被選的對象
        /// 2. 進行字元檔的搜尋
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tV_CharList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Get_OCR_Category_Select_Item();
            Query_OCR_trf_file();
        }





        #endregion 控鍵

        #region 方法
        /// <summary>
        /// 建立字元分類表
        /// </summary>
        private void Establish_Chars_Category()
        {
            List<string> chars_temp_list = chars_list.SArr.ToList();
            chars_category = chars_temp_list.Distinct().ToList();
            chars_category.Sort();
        }

        /// <summary>
        /// TreeView更新
        /// </summary>
        private void Update_Chars_Category_of_TreeView()
        {
            //清空一次
            tV_CharList.Update(); 
            //重建樹狀結構
            tV_CharList.Nodes.Add("temp"); //暫時寫Temp，之後改檔名
            foreach (var item in chars_category) { tV_CharList.Nodes[0].Nodes.Add(item);}
            //刷新
            tV_CharList.EndUpdate();
            //清單展開
            tV_CharList.ExpandAll();
        }
        /// <summary>
        /// 取得被選的對象
        /// </summary>
        private void Get_OCR_Category_Select_Item()
        {
            target_char = tV_CharList.SelectedNode.Text;
        }
        /// <summary>
        /// 對trf檔進行搜尋(尚未完成)
        /// </summary>
        private void Query_OCR_trf_file()
        {

        }


        #endregion 方法


    }
}
