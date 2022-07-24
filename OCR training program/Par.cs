using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR_training_program
{
    internal class Par
    {
        /// <summary>
        /// 字元影像存放路徑
        /// </summary>
        public static string Char_Image_Folder = @"Image\Char\";

        /// <summary>
        /// 小寫字原存放路徑
        /// </summary>
        public static string Lowercase_Char_Image_Folder = @"Lowercase_Char\";

        /// <summary>
        /// 數字字源存放路徑
        /// </summary>
        public static string Number_Image_Folder = @"Number\";

        /// <summary>
        /// Halcon內建字源檔的存放路徑
        /// </summary>
        public static string OCR_File_Folder = @"OCR";

        /// <summary>
        /// OCR以訓練的字元訓練檔，輸出的資料夾
        /// </summary>
        public static string OCR_OMC_FilePath = @"OCR_OMC_File\";

        /// <summary>
        /// OCR字元訓練檔的資料夾
        /// </summary>
        public static string OCR_Traing_FilePath = @"OCR_Traing_File\";

        /// <summary>
        /// 未知字元存放路徑
        /// </summary>
        public static string Other_Char_Image_Folder = @"Other_Char\";

        /// <summary>
        /// 大寫字元存放路徑
        /// </summary>
        public static string Uppercase_Char_Image_Folder = @"Uppercase_Char\";
    }
}