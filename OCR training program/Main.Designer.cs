
namespace OCR_training_program
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCon_Char_Classifier = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Classify_State = new System.Windows.Forms.Label();
            this.proBar_Classify_Process = new System.Windows.Forms.ProgressBar();
            this.txt_Identify_result = new System.Windows.Forms.TextBox();
            this.lbl_Identify_result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CB_OCR_type = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Btn_build_OCR = new System.Windows.Forms.Button();
            this.Tb_max_word_high = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Tb_min_word_width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_min_width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_min_word_high = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Tb_max_width = new System.Windows.Forms.MaskedTextBox();
            this.cb_max_word_high_auto = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Tb_max_word_width = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_max_word_width_auto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_min_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_max_width_auto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_min_word_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_min_word_high_auto = new System.Windows.Forms.CheckBox();
            this.HSWC = new HalconDotNet.HSmartWindowControl();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Trigger = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.txt_Compare_text = new System.Windows.Forms.TextBox();
            this.lbl_Compare_text = new System.Windows.Forms.Label();
            this.btn_load_image_folder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cB_Advance_Setting_Enable = new System.Windows.Forms.CheckBox();
            this.btn_Load_Traing_File = new System.Windows.Forms.Button();
            this.lbl_Interpolate = new System.Windows.Forms.Label();
            this.cBx_Interpolate = new System.Windows.Forms.ComboBox();
            this.gBx_Basic_Setting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdo_pixel_binary = new System.Windows.Forms.RadioButton();
            this.rdo_pixel_invar = new System.Windows.Forms.RadioButton();
            this.rdo_gradient_8dir = new System.Windows.Forms.RadioButton();
            this.cB_ratio = new System.Windows.Forms.CheckBox();
            this.cB_anisometry = new System.Windows.Forms.CheckBox();
            this.cB_convexity = new System.Windows.Forms.CheckBox();
            this.gBx_Advance_Setting = new System.Windows.Forms.GroupBox();
            this.cLB_Advance_Setting = new System.Windows.Forms.CheckedListBox();
            this.txt_Train_OCR_Filename = new System.Windows.Forms.TextBox();
            this.lbl_Train_OCR_Filename = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Start_Train_OCR = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_Exclude_Chars = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbo_Identification_Restrictions = new System.Windows.Forms.ComboBox();
            this.lbl_Identification_Restrictions = new System.Windows.Forms.Label();
            this.lbl_plan_A_Yield = new System.Windows.Forms.Label();
            this.lbl_plan_A_NG = new System.Windows.Forms.Label();
            this.lbl_plan_A_OK = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Run_Image_Test = new System.Windows.Forms.Button();
            this.btn_SingleTest_Trigger = new System.Windows.Forms.Button();
            this.btn_TestFolder_Connect = new System.Windows.Forms.Button();
            this.txt_Comparison_Words = new System.Windows.Forms.TextBox();
            this.lbl_Comparison_Words = new System.Windows.Forms.Label();
            this.HSWC_Test = new HalconDotNet.HSmartWindowControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Test_min_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_Test_min_word_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_Test_min_word_high_auto = new System.Windows.Forms.CheckBox();
            this.cb_Test_max_width_auto = new System.Windows.Forms.CheckBox();
            this.cb_Test_max_word_width_auto = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_Test_max_word_high_auto = new System.Windows.Forms.CheckBox();
            this.Tb_Test_Min_Word_Height = new System.Windows.Forms.MaskedTextBox();
            this.Tb_Test_Min_Width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_Test_Min_Word_Width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_Test_Max_Word_Height = new System.Windows.Forms.MaskedTextBox();
            this.Tb_Test_Max_Width = new System.Windows.Forms.MaskedTextBox();
            this.Tb_Test_Max_Word_Width = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Create_Test_OCR_Model = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Test_Folder_Path = new System.Windows.Forms.TextBox();
            this.btn_Load_TestFolder = new System.Windows.Forms.Button();
            this.bgW_Classify = new System.ComponentModel.BackgroundWorker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bgW_TraingOCR = new System.ComponentModel.BackgroundWorker();
            this.bgW_RunTestOCR = new System.ComponentModel.BackgroundWorker();
            this.btn_Show_Training_File_Browser = new System.Windows.Forms.Button();
            this.tabCon_Char_Classifier.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gBx_Basic_Setting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gBx_Advance_Setting.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCon_Char_Classifier
            // 
            this.tabCon_Char_Classifier.Controls.Add(this.tabPage1);
            this.tabCon_Char_Classifier.Controls.Add(this.tabPage2);
            this.tabCon_Char_Classifier.Controls.Add(this.tabPage3);
            this.tabCon_Char_Classifier.Font = new System.Drawing.Font("Arial", 13.8F);
            this.tabCon_Char_Classifier.Location = new System.Drawing.Point(13, 12);
            this.tabCon_Char_Classifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCon_Char_Classifier.Name = "tabCon_Char_Classifier";
            this.tabCon_Char_Classifier.SelectedIndex = 0;
            this.tabCon_Char_Classifier.Size = new System.Drawing.Size(1031, 538);
            this.tabCon_Char_Classifier.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Classify_State);
            this.tabPage1.Controls.Add(this.proBar_Classify_Process);
            this.tabPage1.Controls.Add(this.txt_Identify_result);
            this.tabPage1.Controls.Add(this.lbl_Identify_result);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.HSWC);
            this.tabPage1.Controls.Add(this.btn_Run);
            this.tabPage1.Controls.Add(this.btn_Trigger);
            this.tabPage1.Controls.Add(this.btn_Connect);
            this.tabPage1.Controls.Add(this.txt_file_path);
            this.tabPage1.Controls.Add(this.txt_Compare_text);
            this.tabPage1.Controls.Add(this.lbl_Compare_text);
            this.tabPage1.Controls.Add(this.btn_load_image_folder);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1023, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "字元分類";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Classify_State
            // 
            this.lbl_Classify_State.AutoSize = true;
            this.lbl_Classify_State.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Classify_State.Location = new System.Drawing.Point(827, 435);
            this.lbl_Classify_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Classify_State.Name = "lbl_Classify_State";
            this.lbl_Classify_State.Size = new System.Drawing.Size(107, 42);
            this.lbl_Classify_State.TabIndex = 43;
            this.lbl_Classify_State.Text = "None";
            // 
            // proBar_Classify_Process
            // 
            this.proBar_Classify_Process.Location = new System.Drawing.Point(21, 428);
            this.proBar_Classify_Process.Margin = new System.Windows.Forms.Padding(4);
            this.proBar_Classify_Process.Name = "proBar_Classify_Process";
            this.proBar_Classify_Process.Size = new System.Drawing.Size(788, 55);
            this.proBar_Classify_Process.Step = 1;
            this.proBar_Classify_Process.TabIndex = 42;
            // 
            // txt_Identify_result
            // 
            this.txt_Identify_result.Location = new System.Drawing.Point(520, 99);
            this.txt_Identify_result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Identify_result.Name = "txt_Identify_result";
            this.txt_Identify_result.ReadOnly = true;
            this.txt_Identify_result.Size = new System.Drawing.Size(483, 34);
            this.txt_Identify_result.TabIndex = 41;
            // 
            // lbl_Identify_result
            // 
            this.lbl_Identify_result.AutoSize = true;
            this.lbl_Identify_result.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identify_result.Location = new System.Drawing.Point(387, 101);
            this.lbl_Identify_result.Name = "lbl_Identify_result";
            this.lbl_Identify_result.Size = new System.Drawing.Size(122, 27);
            this.lbl_Identify_result.TabIndex = 40;
            this.lbl_Identify_result.Text = "辨識結果 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.CB_OCR_type);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.Btn_build_OCR);
            this.groupBox1.Controls.Add(this.Tb_max_word_high);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.Tb_min_word_width);
            this.groupBox1.Controls.Add(this.Tb_min_width);
            this.groupBox1.Controls.Add(this.Tb_min_word_high);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.Tb_max_width);
            this.groupBox1.Controls.Add(this.cb_max_word_high_auto);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.Tb_max_word_width);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cb_max_word_width_auto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_min_width_auto);
            this.groupBox1.Controls.Add(this.cb_max_width_auto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_min_word_width_auto);
            this.groupBox1.Controls.Add(this.cb_min_word_high_auto);
            this.groupBox1.Location = new System.Drawing.Point(391, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(613, 252);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OCR設定";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(367, 205);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 27);
            this.label26.TabIndex = 55;
            this.label26.Text = "Min";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(131, 40);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 27);
            this.label17.TabIndex = 50;
            this.label17.Text = "字元擋 : ";
            // 
            // CB_OCR_type
            // 
            this.CB_OCR_type.FormattingEnabled = true;
            this.CB_OCR_type.Items.AddRange(new object[] {
            "Universal_0-9A-Z_NoRej.occ",
            "Industrial_0-9A-Z_NoRej.omc",
            "SFCompactText-RegularG2_0-9A-Z.omc"});
            this.CB_OCR_type.Location = new System.Drawing.Point(244, 36);
            this.CB_OCR_type.Margin = new System.Windows.Forms.Padding(4);
            this.CB_OCR_type.Name = "CB_OCR_type";
            this.CB_OCR_type.Size = new System.Drawing.Size(228, 34);
            this.CB_OCR_type.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(367, 156);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 27);
            this.label25.TabIndex = 54;
            this.label25.Text = "Min";
            // 
            // Btn_build_OCR
            // 
            this.Btn_build_OCR.Location = new System.Drawing.Point(8, 35);
            this.Btn_build_OCR.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_build_OCR.Name = "Btn_build_OCR";
            this.Btn_build_OCR.Size = new System.Drawing.Size(115, 38);
            this.Btn_build_OCR.TabIndex = 25;
            this.Btn_build_OCR.Text = "建立OCR";
            this.Btn_build_OCR.UseVisualStyleBackColor = true;
            this.Btn_build_OCR.Click += new System.EventHandler(this.Btn_build_OCR_Click);
            // 
            // Tb_max_word_high
            // 
            this.Tb_max_word_high.Enabled = false;
            this.Tb_max_word_high.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_word_high.Location = new System.Drawing.Point(205, 108);
            this.Tb_max_word_high.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_word_high.Mask = "999";
            this.Tb_max_word_high.Name = "Tb_max_word_high";
            this.Tb_max_word_high.PromptChar = ' ';
            this.Tb_max_word_high.Size = new System.Drawing.Size(48, 34);
            this.Tb_max_word_high.TabIndex = 14;
            this.Tb_max_word_high.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(367, 111);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 27);
            this.label24.TabIndex = 53;
            this.label24.Text = "Min";
            // 
            // Tb_min_word_width
            // 
            this.Tb_min_word_width.Enabled = false;
            this.Tb_min_word_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_word_width.Location = new System.Drawing.Point(436, 152);
            this.Tb_min_word_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_word_width.Mask = "999";
            this.Tb_min_word_width.Name = "Tb_min_word_width";
            this.Tb_min_word_width.PromptChar = ' ';
            this.Tb_min_word_width.Size = new System.Drawing.Size(48, 34);
            this.Tb_min_word_width.TabIndex = 16;
            this.Tb_min_word_width.Text = "0";
            // 
            // Tb_min_width
            // 
            this.Tb_min_width.Enabled = false;
            this.Tb_min_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_width.Location = new System.Drawing.Point(436, 200);
            this.Tb_min_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_width.Mask = "999";
            this.Tb_min_width.Name = "Tb_min_width";
            this.Tb_min_width.PromptChar = ' ';
            this.Tb_min_width.Size = new System.Drawing.Size(48, 34);
            this.Tb_min_width.TabIndex = 18;
            this.Tb_min_width.Text = "0";
            // 
            // Tb_min_word_high
            // 
            this.Tb_min_word_high.Enabled = false;
            this.Tb_min_word_high.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_min_word_high.Location = new System.Drawing.Point(436, 108);
            this.Tb_min_word_high.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_min_word_high.Mask = "999";
            this.Tb_min_word_high.Name = "Tb_min_word_high";
            this.Tb_min_word_high.PromptChar = ' ';
            this.Tb_min_word_high.Size = new System.Drawing.Size(48, 34);
            this.Tb_min_word_high.TabIndex = 17;
            this.Tb_min_word_high.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(137, 200);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 27);
            this.label23.TabIndex = 52;
            this.label23.Text = "Max";
            // 
            // Tb_max_width
            // 
            this.Tb_max_width.Enabled = false;
            this.Tb_max_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_width.Location = new System.Drawing.Point(205, 200);
            this.Tb_max_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_width.Mask = "999";
            this.Tb_max_width.Name = "Tb_max_width";
            this.Tb_max_width.PromptChar = ' ';
            this.Tb_max_width.Size = new System.Drawing.Size(48, 34);
            this.Tb_max_width.TabIndex = 15;
            this.Tb_max_width.Text = "0";
            // 
            // cb_max_word_high_auto
            // 
            this.cb_max_word_high_auto.AutoSize = true;
            this.cb_max_word_high_auto.Checked = true;
            this.cb_max_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_word_high_auto.Location = new System.Drawing.Point(273, 110);
            this.cb_max_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_word_high_auto.Name = "cb_max_word_high_auto";
            this.cb_max_word_high_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_max_word_high_auto.TabIndex = 44;
            this.cb_max_word_high_auto.Text = "Auto";
            this.cb_max_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_max_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(137, 155);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 27);
            this.label22.TabIndex = 51;
            this.label22.Text = "Max";
            // 
            // Tb_max_word_width
            // 
            this.Tb_max_word_width.Enabled = false;
            this.Tb_max_word_width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_max_word_width.Location = new System.Drawing.Point(205, 152);
            this.Tb_max_word_width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_max_word_width.Mask = "999";
            this.Tb_max_word_width.Name = "Tb_max_word_width";
            this.Tb_max_word_width.PromptChar = ' ';
            this.Tb_max_word_width.Size = new System.Drawing.Size(48, 34);
            this.Tb_max_word_width.TabIndex = 13;
            this.Tb_max_word_width.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "筆畫寬度：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(137, 111);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 27);
            this.label21.TabIndex = 50;
            this.label21.Text = "Max";
            // 
            // cb_max_word_width_auto
            // 
            this.cb_max_word_width_auto.AutoSize = true;
            this.cb_max_word_width_auto.Checked = true;
            this.cb_max_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_word_width_auto.Location = new System.Drawing.Point(273, 155);
            this.cb_max_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_word_width_auto.Name = "cb_max_word_width_auto";
            this.cb_max_word_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_max_word_width_auto.TabIndex = 45;
            this.cb_max_word_width_auto.Text = "Auto";
            this.cb_max_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_max_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "字寬：　";
            // 
            // cb_min_width_auto
            // 
            this.cb_min_width_auto.AutoSize = true;
            this.cb_min_width_auto.Checked = true;
            this.cb_min_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_width_auto.Location = new System.Drawing.Point(507, 202);
            this.cb_min_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_width_auto.Name = "cb_min_width_auto";
            this.cb_min_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_min_width_auto.TabIndex = 49;
            this.cb_min_width_auto.Text = "Auto";
            this.cb_min_width_auto.UseVisualStyleBackColor = true;
            this.cb_min_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_max_width_auto
            // 
            this.cb_max_width_auto.AutoSize = true;
            this.cb_max_width_auto.Checked = true;
            this.cb_max_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_max_width_auto.Location = new System.Drawing.Point(273, 202);
            this.cb_max_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_max_width_auto.Name = "cb_max_width_auto";
            this.cb_max_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_max_width_auto.TabIndex = 46;
            this.cb_max_width_auto.Text = "Auto";
            this.cb_max_width_auto.UseVisualStyleBackColor = true;
            this.cb_max_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "字高 ：";
            // 
            // cb_min_word_width_auto
            // 
            this.cb_min_word_width_auto.AutoSize = true;
            this.cb_min_word_width_auto.Checked = true;
            this.cb_min_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_word_width_auto.Location = new System.Drawing.Point(507, 155);
            this.cb_min_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_word_width_auto.Name = "cb_min_word_width_auto";
            this.cb_min_word_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_min_word_width_auto.TabIndex = 48;
            this.cb_min_word_width_auto.Text = "Auto";
            this.cb_min_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_min_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // cb_min_word_high_auto
            // 
            this.cb_min_word_high_auto.AutoSize = true;
            this.cb_min_word_high_auto.Checked = true;
            this.cb_min_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_min_word_high_auto.Location = new System.Drawing.Point(507, 110);
            this.cb_min_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_min_word_high_auto.Name = "cb_min_word_high_auto";
            this.cb_min_word_high_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_min_word_high_auto.TabIndex = 47;
            this.cb_min_word_high_auto.Text = "Auto";
            this.cb_min_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_min_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Setting_CheckedChanged);
            // 
            // HSWC
            // 
            this.HSWC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HSWC.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.HSWC.HDoubleClickToFitContent = true;
            this.HSWC.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.HSWC.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HSWC.HKeepAspectRatio = true;
            this.HSWC.HMoveContent = true;
            this.HSWC.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.HSWC.Location = new System.Drawing.Point(5, 52);
            this.HSWC.Margin = new System.Windows.Forms.Padding(0);
            this.HSWC.Name = "HSWC";
            this.HSWC.Size = new System.Drawing.Size(353, 191);
            this.HSWC.TabIndex = 38;
            this.HSWC.WindowSize = new System.Drawing.Size(353, 191);
            // 
            // btn_Run
            // 
            this.btn_Run.Enabled = false;
            this.btn_Run.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(627, 6);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(81, 44);
            this.btn_Run.TabIndex = 37;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Trigger
            // 
            this.btn_Trigger.Enabled = false;
            this.btn_Trigger.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trigger.Location = new System.Drawing.Point(713, 6);
            this.btn_Trigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Trigger.Name = "btn_Trigger";
            this.btn_Trigger.Size = new System.Drawing.Size(81, 44);
            this.btn_Trigger.TabIndex = 36;
            this.btn_Trigger.Text = "Trig";
            this.btn_Trigger.UseVisualStyleBackColor = true;
            this.btn_Trigger.Click += new System.EventHandler(this.btn_Trigger_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(495, 6);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(125, 44);
            this.btn_Connect.TabIndex = 34;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_file_path
            // 
            this.txt_file_path.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file_path.Location = new System.Drawing.Point(123, 10);
            this.txt_file_path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(353, 34);
            this.txt_file_path.TabIndex = 3;
            this.txt_file_path.Text = "C:\\Users\\LouisDing\\Desktop\\Test_Folder\\2223";
            // 
            // txt_Compare_text
            // 
            this.txt_Compare_text.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Compare_text.Location = new System.Drawing.Point(520, 56);
            this.txt_Compare_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Compare_text.Name = "txt_Compare_text";
            this.txt_Compare_text.Size = new System.Drawing.Size(483, 34);
            this.txt_Compare_text.TabIndex = 2;
            this.txt_Compare_text.Text = "2211";
            // 
            // lbl_Compare_text
            // 
            this.lbl_Compare_text.AutoSize = true;
            this.lbl_Compare_text.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compare_text.Location = new System.Drawing.Point(384, 59);
            this.lbl_Compare_text.Name = "lbl_Compare_text";
            this.lbl_Compare_text.Size = new System.Drawing.Size(129, 27);
            this.lbl_Compare_text.TabIndex = 1;
            this.lbl_Compare_text.Text = "比對字元 : ";
            // 
            // btn_load_image_folder
            // 
            this.btn_load_image_folder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_image_folder.Location = new System.Drawing.Point(5, 6);
            this.btn_load_image_folder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_image_folder.Name = "btn_load_image_folder";
            this.btn_load_image_folder.Size = new System.Drawing.Size(111, 44);
            this.btn_load_image_folder.TabIndex = 0;
            this.btn_load_image_folder.Text = "Folder";
            this.btn_load_image_folder.UseVisualStyleBackColor = true;
            this.btn_load_image_folder.Click += new System.EventHandler(this.btn_load_image_folder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Show_Training_File_Browser);
            this.tabPage2.Controls.Add(this.cB_Advance_Setting_Enable);
            this.tabPage2.Controls.Add(this.btn_Load_Traing_File);
            this.tabPage2.Controls.Add(this.lbl_Interpolate);
            this.tabPage2.Controls.Add(this.cBx_Interpolate);
            this.tabPage2.Controls.Add(this.gBx_Basic_Setting);
            this.tabPage2.Controls.Add(this.gBx_Advance_Setting);
            this.tabPage2.Controls.Add(this.txt_Train_OCR_Filename);
            this.tabPage2.Controls.Add(this.lbl_Train_OCR_Filename);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.btn_Start_Train_OCR);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1023, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "訓練";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cB_Advance_Setting_Enable
            // 
            this.cB_Advance_Setting_Enable.AutoSize = true;
            this.cB_Advance_Setting_Enable.Location = new System.Drawing.Point(333, 146);
            this.cB_Advance_Setting_Enable.Name = "cB_Advance_Setting_Enable";
            this.cB_Advance_Setting_Enable.Size = new System.Drawing.Size(178, 31);
            this.cB_Advance_Setting_Enable.TabIndex = 9;
            this.cB_Advance_Setting_Enable.Text = "開啟進階特徵";
            this.cB_Advance_Setting_Enable.UseVisualStyleBackColor = true;
            this.cB_Advance_Setting_Enable.CheckedChanged += new System.EventHandler(this.cB_Advance_Setting_Enable_CheckedChanged);
            // 
            // btn_Load_Traing_File
            // 
            this.btn_Load_Traing_File.Location = new System.Drawing.Point(8, 10);
            this.btn_Load_Traing_File.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Load_Traing_File.Name = "btn_Load_Traing_File";
            this.btn_Load_Traing_File.Size = new System.Drawing.Size(113, 46);
            this.btn_Load_Traing_File.TabIndex = 8;
            this.btn_Load_Traing_File.Text = "Load";
            this.btn_Load_Traing_File.UseVisualStyleBackColor = true;
            this.btn_Load_Traing_File.Click += new System.EventHandler(this.btn_Load_Traing_File_Click);
            // 
            // lbl_Interpolate
            // 
            this.lbl_Interpolate.AutoSize = true;
            this.lbl_Interpolate.Location = new System.Drawing.Point(22, 136);
            this.lbl_Interpolate.Name = "lbl_Interpolate";
            this.lbl_Interpolate.Size = new System.Drawing.Size(60, 27);
            this.lbl_Interpolate.TabIndex = 7;
            this.lbl_Interpolate.Text = "內插";
            // 
            // cBx_Interpolate
            // 
            this.cBx_Interpolate.FormattingEnabled = true;
            this.cBx_Interpolate.Items.AddRange(new object[] {
            "常數",
            "近鄰",
            "雙線性",
            "權重"});
            this.cBx_Interpolate.Location = new System.Drawing.Point(88, 132);
            this.cBx_Interpolate.Name = "cBx_Interpolate";
            this.cBx_Interpolate.Size = new System.Drawing.Size(121, 34);
            this.cBx_Interpolate.TabIndex = 6;
            // 
            // gBx_Basic_Setting
            // 
            this.gBx_Basic_Setting.Controls.Add(this.tableLayoutPanel1);
            this.gBx_Basic_Setting.Location = new System.Drawing.Point(24, 183);
            this.gBx_Basic_Setting.Name = "gBx_Basic_Setting";
            this.gBx_Basic_Setting.Size = new System.Drawing.Size(276, 163);
            this.gBx_Basic_Setting.TabIndex = 5;
            this.gBx_Basic_Setting.TabStop = false;
            this.gBx_Basic_Setting.Text = "基礎特徵";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rdo_pixel_binary, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdo_pixel_invar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdo_gradient_8dir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cB_ratio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cB_anisometry, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cB_convexity, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdo_pixel_binary
            // 
            this.rdo_pixel_binary.AutoSize = true;
            this.rdo_pixel_binary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdo_pixel_binary.Location = new System.Drawing.Point(3, 46);
            this.rdo_pixel_binary.Name = "rdo_pixel_binary";
            this.rdo_pixel_binary.Size = new System.Drawing.Size(129, 37);
            this.rdo_pixel_binary.TabIndex = 1;
            this.rdo_pixel_binary.Tag = "";
            this.rdo_pixel_binary.Text = "字符區域";
            this.rdo_pixel_binary.UseVisualStyleBackColor = true;
            this.rdo_pixel_binary.Click += new System.EventHandler(this.rdo_region_feature_CheckedChanged);
            // 
            // rdo_pixel_invar
            // 
            this.rdo_pixel_invar.AutoSize = true;
            this.rdo_pixel_invar.Checked = true;
            this.rdo_pixel_invar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdo_pixel_invar.Location = new System.Drawing.Point(3, 3);
            this.rdo_pixel_invar.Name = "rdo_pixel_invar";
            this.rdo_pixel_invar.Size = new System.Drawing.Size(129, 37);
            this.rdo_pixel_invar.TabIndex = 0;
            this.rdo_pixel_invar.TabStop = true;
            this.rdo_pixel_invar.Tag = "";
            this.rdo_pixel_invar.Text = "灰階值";
            this.rdo_pixel_invar.UseVisualStyleBackColor = true;
            this.rdo_pixel_invar.Click += new System.EventHandler(this.rdo_region_feature_CheckedChanged);
            // 
            // rdo_gradient_8dir
            // 
            this.rdo_gradient_8dir.AutoSize = true;
            this.rdo_gradient_8dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdo_gradient_8dir.Location = new System.Drawing.Point(3, 89);
            this.rdo_gradient_8dir.Name = "rdo_gradient_8dir";
            this.rdo_gradient_8dir.Size = new System.Drawing.Size(129, 38);
            this.rdo_gradient_8dir.TabIndex = 2;
            this.rdo_gradient_8dir.Tag = "";
            this.rdo_gradient_8dir.Text = "梯度";
            this.rdo_gradient_8dir.UseVisualStyleBackColor = true;
            this.rdo_gradient_8dir.Click += new System.EventHandler(this.rdo_region_feature_CheckedChanged);
            // 
            // cB_ratio
            // 
            this.cB_ratio.AutoSize = true;
            this.cB_ratio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cB_ratio.Location = new System.Drawing.Point(138, 3);
            this.cB_ratio.Name = "cB_ratio";
            this.cB_ratio.Size = new System.Drawing.Size(129, 37);
            this.cB_ratio.TabIndex = 3;
            this.cB_ratio.Text = "比例";
            this.cB_ratio.UseVisualStyleBackColor = true;
            this.cB_ratio.CheckedChanged += new System.EventHandler(this.cB_Basic_Feature_CheckedChanged);
            // 
            // cB_anisometry
            // 
            this.cB_anisometry.AutoSize = true;
            this.cB_anisometry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cB_anisometry.Location = new System.Drawing.Point(138, 46);
            this.cB_anisometry.Name = "cB_anisometry";
            this.cB_anisometry.Size = new System.Drawing.Size(129, 37);
            this.cB_anisometry.TabIndex = 4;
            this.cB_anisometry.Text = "異向性";
            this.cB_anisometry.UseVisualStyleBackColor = true;
            this.cB_anisometry.CheckedChanged += new System.EventHandler(this.cB_Basic_Feature_CheckedChanged);
            // 
            // cB_convexity
            // 
            this.cB_convexity.AutoSize = true;
            this.cB_convexity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cB_convexity.Location = new System.Drawing.Point(138, 89);
            this.cB_convexity.Name = "cB_convexity";
            this.cB_convexity.Size = new System.Drawing.Size(129, 38);
            this.cB_convexity.TabIndex = 5;
            this.cB_convexity.Text = "凸面";
            this.cB_convexity.UseVisualStyleBackColor = true;
            this.cB_convexity.CheckedChanged += new System.EventHandler(this.cB_Basic_Feature_CheckedChanged);
            // 
            // gBx_Advance_Setting
            // 
            this.gBx_Advance_Setting.Controls.Add(this.cLB_Advance_Setting);
            this.gBx_Advance_Setting.Enabled = false;
            this.gBx_Advance_Setting.Location = new System.Drawing.Point(330, 183);
            this.gBx_Advance_Setting.Name = "gBx_Advance_Setting";
            this.gBx_Advance_Setting.Size = new System.Drawing.Size(228, 257);
            this.gBx_Advance_Setting.TabIndex = 4;
            this.gBx_Advance_Setting.TabStop = false;
            this.gBx_Advance_Setting.Text = "進階特徵";
            // 
            // cLB_Advance_Setting
            // 
            this.cLB_Advance_Setting.CheckOnClick = true;
            this.cLB_Advance_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLB_Advance_Setting.FormattingEnabled = true;
            this.cLB_Advance_Setting.Items.AddRange(new object[] {
            "pixel",
            "pixel_invar",
            "pixel_binary",
            "gradient_8dir",
            "projection_horizontal",
            "projection_horizontal_invar",
            "projection_vertical",
            "projection_vertical_invar",
            "ratio",
            "anisometry",
            "width",
            "height",
            "zoom_factor",
            "foreground",
            "foreground_grid_9",
            "foreground_grid_16",
            "compactness",
            "convexity",
            "moments_region_2nd_invar",
            "moments_region_2nd_rel_invar",
            "moments_region_3rd_invar",
            "moments_central",
            "moments_gray_plane",
            "phi",
            "num_connect",
            "num_holes",
            "cooc",
            "num_runs",
            "chord_histo"});
            this.cLB_Advance_Setting.Location = new System.Drawing.Point(3, 30);
            this.cLB_Advance_Setting.Name = "cLB_Advance_Setting";
            this.cLB_Advance_Setting.Size = new System.Drawing.Size(222, 224);
            this.cLB_Advance_Setting.TabIndex = 0;
            this.cLB_Advance_Setting.SelectedIndexChanged += new System.EventHandler(this.cLB_Advance_Setting_SelectedIndexChanged);
            // 
            // txt_Train_OCR_Filename
            // 
            this.txt_Train_OCR_Filename.Location = new System.Drawing.Point(235, 14);
            this.txt_Train_OCR_Filename.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Train_OCR_Filename.Name = "txt_Train_OCR_Filename";
            this.txt_Train_OCR_Filename.Size = new System.Drawing.Size(600, 34);
            this.txt_Train_OCR_Filename.TabIndex = 3;
            // 
            // lbl_Train_OCR_Filename
            // 
            this.lbl_Train_OCR_Filename.AutoSize = true;
            this.lbl_Train_OCR_Filename.Location = new System.Drawing.Point(129, 18);
            this.lbl_Train_OCR_Filename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Train_OCR_Filename.Name = "lbl_Train_OCR_Filename";
            this.lbl_Train_OCR_Filename.Size = new System.Drawing.Size(105, 27);
            this.lbl_Train_OCR_Filename.TabIndex = 2;
            this.lbl_Train_OCR_Filename.Text = "字元檔 : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 447);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(815, 46);
            this.progressBar1.TabIndex = 1;
            // 
            // btn_Start_Train_OCR
            // 
            this.btn_Start_Train_OCR.Location = new System.Drawing.Point(7, 64);
            this.btn_Start_Train_OCR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start_Train_OCR.Name = "btn_Start_Train_OCR";
            this.btn_Start_Train_OCR.Size = new System.Drawing.Size(113, 46);
            this.btn_Start_Train_OCR.TabIndex = 0;
            this.btn_Start_Train_OCR.Text = "Train";
            this.btn_Start_Train_OCR.UseVisualStyleBackColor = true;
            this.btn_Start_Train_OCR.Click += new System.EventHandler(this.btn_Start_Train_OCR_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.txt_Exclude_Chars);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.cbo_Identification_Restrictions);
            this.tabPage3.Controls.Add(this.lbl_Identification_Restrictions);
            this.tabPage3.Controls.Add(this.lbl_plan_A_Yield);
            this.tabPage3.Controls.Add(this.lbl_plan_A_NG);
            this.tabPage3.Controls.Add(this.lbl_plan_A_OK);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btn_Reset);
            this.tabPage3.Controls.Add(this.btn_Run_Image_Test);
            this.tabPage3.Controls.Add(this.btn_SingleTest_Trigger);
            this.tabPage3.Controls.Add(this.btn_TestFolder_Connect);
            this.tabPage3.Controls.Add(this.txt_Comparison_Words);
            this.tabPage3.Controls.Add(this.lbl_Comparison_Words);
            this.tabPage3.Controls.Add(this.HSWC_Test);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.txt_Test_Folder_Path);
            this.tabPage3.Controls.Add(this.btn_Load_TestFolder);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1023, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "測試";
            // 
            // txt_Exclude_Chars
            // 
            this.txt_Exclude_Chars.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Exclude_Chars.Location = new System.Drawing.Point(140, 131);
            this.txt_Exclude_Chars.Name = "txt_Exclude_Chars";
            this.txt_Exclude_Chars.Size = new System.Drawing.Size(253, 34);
            this.txt_Exclude_Chars.TabIndex = 56;
            this.txt_Exclude_Chars.TextChanged += new System.EventHandler(this.txt_Exclude_Chars_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 27);
            this.label18.TabIndex = 55;
            this.label18.Text = "排除字元 :";
            // 
            // cbo_Identification_Restrictions
            // 
            this.cbo_Identification_Restrictions.FormattingEnabled = true;
            this.cbo_Identification_Restrictions.Items.AddRange(new object[] {
            "數字與英文字母",
            "數字與大寫英文",
            "數字與小寫英文",
            "只有英文(含大小寫)",
            "只有大寫英文",
            "只有小寫英文",
            "只有數字",
            "排除特定字元"});
            this.cbo_Identification_Restrictions.Location = new System.Drawing.Point(140, 94);
            this.cbo_Identification_Restrictions.Name = "cbo_Identification_Restrictions";
            this.cbo_Identification_Restrictions.Size = new System.Drawing.Size(253, 34);
            this.cbo_Identification_Restrictions.TabIndex = 54;
            this.cbo_Identification_Restrictions.SelectedIndexChanged += new System.EventHandler(this.cbo_Comparison_Condition_SelectedIndexChanged);
            // 
            // lbl_Identification_Restrictions
            // 
            this.lbl_Identification_Restrictions.AutoSize = true;
            this.lbl_Identification_Restrictions.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identification_Restrictions.Location = new System.Drawing.Point(20, 97);
            this.lbl_Identification_Restrictions.Name = "lbl_Identification_Restrictions";
            this.lbl_Identification_Restrictions.Size = new System.Drawing.Size(122, 27);
            this.lbl_Identification_Restrictions.TabIndex = 53;
            this.lbl_Identification_Restrictions.Text = "辨識限制 :";
            // 
            // lbl_plan_A_Yield
            // 
            this.lbl_plan_A_Yield.AutoSize = true;
            this.lbl_plan_A_Yield.Location = new System.Drawing.Point(489, 385);
            this.lbl_plan_A_Yield.Name = "lbl_plan_A_Yield";
            this.lbl_plan_A_Yield.Size = new System.Drawing.Size(25, 27);
            this.lbl_plan_A_Yield.TabIndex = 52;
            this.lbl_plan_A_Yield.Text = "0";
            // 
            // lbl_plan_A_NG
            // 
            this.lbl_plan_A_NG.AutoSize = true;
            this.lbl_plan_A_NG.Location = new System.Drawing.Point(303, 385);
            this.lbl_plan_A_NG.Name = "lbl_plan_A_NG";
            this.lbl_plan_A_NG.Size = new System.Drawing.Size(25, 27);
            this.lbl_plan_A_NG.TabIndex = 51;
            this.lbl_plan_A_NG.Text = "0";
            // 
            // lbl_plan_A_OK
            // 
            this.lbl_plan_A_OK.AutoSize = true;
            this.lbl_plan_A_OK.Location = new System.Drawing.Point(141, 385);
            this.lbl_plan_A_OK.Name = "lbl_plan_A_OK";
            this.lbl_plan_A_OK.Size = new System.Drawing.Size(25, 27);
            this.lbl_plan_A_OK.TabIndex = 50;
            this.lbl_plan_A_OK.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 27);
            this.label14.TabIndex = 49;
            this.label14.Text = "Ratio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 27);
            this.label15.TabIndex = 48;
            this.label15.Text = "NG";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 27);
            this.label16.TabIndex = 47;
            this.label16.Text = "OK";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_Reset.Location = new System.Drawing.Point(788, 12);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 40);
            this.btn_Reset.TabIndex = 46;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Run_Image_Test
            // 
            this.btn_Run_Image_Test.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_Run_Image_Test.Location = new System.Drawing.Point(614, 12);
            this.btn_Run_Image_Test.Name = "btn_Run_Image_Test";
            this.btn_Run_Image_Test.Size = new System.Drawing.Size(81, 40);
            this.btn_Run_Image_Test.TabIndex = 45;
            this.btn_Run_Image_Test.Text = "Run";
            this.btn_Run_Image_Test.UseVisualStyleBackColor = true;
            this.btn_Run_Image_Test.Click += new System.EventHandler(this.btn_Run_Image_Test_Click);
            // 
            // btn_SingleTest_Trigger
            // 
            this.btn_SingleTest_Trigger.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_SingleTest_Trigger.Location = new System.Drawing.Point(701, 12);
            this.btn_SingleTest_Trigger.Name = "btn_SingleTest_Trigger";
            this.btn_SingleTest_Trigger.Size = new System.Drawing.Size(81, 40);
            this.btn_SingleTest_Trigger.TabIndex = 44;
            this.btn_SingleTest_Trigger.Text = "Trig";
            this.btn_SingleTest_Trigger.UseVisualStyleBackColor = true;
            this.btn_SingleTest_Trigger.Click += new System.EventHandler(this.btn_SingleTest_Trigger_Click);
            // 
            // btn_TestFolder_Connect
            // 
            this.btn_TestFolder_Connect.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_TestFolder_Connect.Location = new System.Drawing.Point(482, 12);
            this.btn_TestFolder_Connect.Name = "btn_TestFolder_Connect";
            this.btn_TestFolder_Connect.Size = new System.Drawing.Size(125, 40);
            this.btn_TestFolder_Connect.TabIndex = 43;
            this.btn_TestFolder_Connect.Text = "Connect";
            this.btn_TestFolder_Connect.UseVisualStyleBackColor = true;
            this.btn_TestFolder_Connect.Click += new System.EventHandler(this.btn_TestFolder_Connect_Click);
            // 
            // txt_Comparison_Words
            // 
            this.txt_Comparison_Words.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comparison_Words.Location = new System.Drawing.Point(140, 57);
            this.txt_Comparison_Words.Name = "txt_Comparison_Words";
            this.txt_Comparison_Words.Size = new System.Drawing.Size(253, 34);
            this.txt_Comparison_Words.TabIndex = 42;
            this.txt_Comparison_Words.Text = "L4V1B8.L6";
            // 
            // lbl_Comparison_Words
            // 
            this.lbl_Comparison_Words.AutoSize = true;
            this.lbl_Comparison_Words.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comparison_Words.Location = new System.Drawing.Point(20, 61);
            this.lbl_Comparison_Words.Name = "lbl_Comparison_Words";
            this.lbl_Comparison_Words.Size = new System.Drawing.Size(122, 27);
            this.lbl_Comparison_Words.TabIndex = 41;
            this.lbl_Comparison_Words.Text = "比對字串 :";
            // 
            // HSWC_Test
            // 
            this.HSWC_Test.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HSWC_Test.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.HSWC_Test.HDoubleClickToFitContent = true;
            this.HSWC_Test.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.HSWC_Test.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HSWC_Test.HKeepAspectRatio = true;
            this.HSWC_Test.HMoveContent = true;
            this.HSWC_Test.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.HSWC_Test.Location = new System.Drawing.Point(567, 64);
            this.HSWC_Test.Margin = new System.Windows.Forms.Padding(0);
            this.HSWC_Test.Name = "HSWC_Test";
            this.HSWC_Test.Size = new System.Drawing.Size(445, 159);
            this.HSWC_Test.TabIndex = 40;
            this.HSWC_Test.WindowSize = new System.Drawing.Size(445, 159);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_Test_min_width_auto);
            this.groupBox2.Controls.Add(this.cb_Test_min_word_width_auto);
            this.groupBox2.Controls.Add(this.cb_Test_min_word_high_auto);
            this.groupBox2.Controls.Add(this.cb_Test_max_width_auto);
            this.groupBox2.Controls.Add(this.cb_Test_max_word_width_auto);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.cb_Test_max_word_high_auto);
            this.groupBox2.Controls.Add(this.Tb_Test_Min_Word_Height);
            this.groupBox2.Controls.Add(this.Tb_Test_Min_Width);
            this.groupBox2.Controls.Add(this.Tb_Test_Min_Word_Width);
            this.groupBox2.Controls.Add(this.Tb_Test_Max_Word_Height);
            this.groupBox2.Controls.Add(this.Tb_Test_Max_Width);
            this.groupBox2.Controls.Add(this.Tb_Test_Max_Word_Width);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_Create_Test_OCR_Model);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(548, 190);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OCR設定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 55;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 50;
            this.label7.Text = "字元擋 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 27);
            this.label8.TabIndex = 52;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 27);
            this.label9.TabIndex = 51;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 27);
            this.label10.TabIndex = 50;
            this.label10.Text = "Max";
            // 
            // cb_Test_min_width_auto
            // 
            this.cb_Test_min_width_auto.AutoSize = true;
            this.cb_Test_min_width_auto.Checked = true;
            this.cb_Test_min_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_min_width_auto.Location = new System.Drawing.Point(454, 139);
            this.cb_Test_min_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_min_width_auto.Name = "cb_Test_min_width_auto";
            this.cb_Test_min_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_min_width_auto.TabIndex = 49;
            this.cb_Test_min_width_auto.Text = "Auto";
            this.cb_Test_min_width_auto.UseVisualStyleBackColor = true;
            this.cb_Test_min_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // cb_Test_min_word_width_auto
            // 
            this.cb_Test_min_word_width_auto.AutoSize = true;
            this.cb_Test_min_word_width_auto.Checked = true;
            this.cb_Test_min_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_min_word_width_auto.Location = new System.Drawing.Point(454, 99);
            this.cb_Test_min_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_min_word_width_auto.Name = "cb_Test_min_word_width_auto";
            this.cb_Test_min_word_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_min_word_width_auto.TabIndex = 48;
            this.cb_Test_min_word_width_auto.Text = "Auto";
            this.cb_Test_min_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_Test_min_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // cb_Test_min_word_high_auto
            // 
            this.cb_Test_min_word_high_auto.AutoSize = true;
            this.cb_Test_min_word_high_auto.Checked = true;
            this.cb_Test_min_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_min_word_high_auto.Location = new System.Drawing.Point(454, 62);
            this.cb_Test_min_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_min_word_high_auto.Name = "cb_Test_min_word_high_auto";
            this.cb_Test_min_word_high_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_min_word_high_auto.TabIndex = 47;
            this.cb_Test_min_word_high_auto.Text = "Auto";
            this.cb_Test_min_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_Test_min_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // cb_Test_max_width_auto
            // 
            this.cb_Test_max_width_auto.AutoSize = true;
            this.cb_Test_max_width_auto.Checked = true;
            this.cb_Test_max_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_max_width_auto.Location = new System.Drawing.Point(252, 139);
            this.cb_Test_max_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_max_width_auto.Name = "cb_Test_max_width_auto";
            this.cb_Test_max_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_max_width_auto.TabIndex = 46;
            this.cb_Test_max_width_auto.Text = "Auto";
            this.cb_Test_max_width_auto.UseVisualStyleBackColor = true;
            this.cb_Test_max_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // cb_Test_max_word_width_auto
            // 
            this.cb_Test_max_word_width_auto.AutoSize = true;
            this.cb_Test_max_word_width_auto.Checked = true;
            this.cb_Test_max_word_width_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_max_word_width_auto.Location = new System.Drawing.Point(252, 99);
            this.cb_Test_max_word_width_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_max_word_width_auto.Name = "cb_Test_max_word_width_auto";
            this.cb_Test_max_word_width_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_max_word_width_auto.TabIndex = 45;
            this.cb_Test_max_word_width_auto.Text = "Auto";
            this.cb_Test_max_word_width_auto.UseVisualStyleBackColor = true;
            this.cb_Test_max_word_width_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Universal_0-9A-Z_NoRej.occ",
            "Industrial_0-9A-Z_NoRej.omc",
            "SFCompactText-RegularG2_0-9A-Z.omc"});
            this.comboBox1.Location = new System.Drawing.Point(227, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 34);
            this.comboBox1.TabIndex = 35;
            // 
            // cb_Test_max_word_high_auto
            // 
            this.cb_Test_max_word_high_auto.AutoSize = true;
            this.cb_Test_max_word_high_auto.Checked = true;
            this.cb_Test_max_word_high_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Test_max_word_high_auto.Location = new System.Drawing.Point(252, 62);
            this.cb_Test_max_word_high_auto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Test_max_word_high_auto.Name = "cb_Test_max_word_high_auto";
            this.cb_Test_max_word_high_auto.Size = new System.Drawing.Size(83, 31);
            this.cb_Test_max_word_high_auto.TabIndex = 44;
            this.cb_Test_max_word_high_auto.Text = "Auto";
            this.cb_Test_max_word_high_auto.UseVisualStyleBackColor = true;
            this.cb_Test_max_word_high_auto.CheckedChanged += new System.EventHandler(this.cb_OCR_Test_Setting_CheckedChanged);
            // 
            // Tb_Test_Min_Word_Height
            // 
            this.Tb_Test_Min_Word_Height.Enabled = false;
            this.Tb_Test_Min_Word_Height.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Min_Word_Height.Location = new System.Drawing.Point(391, 60);
            this.Tb_Test_Min_Word_Height.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Min_Word_Height.Mask = "999";
            this.Tb_Test_Min_Word_Height.Name = "Tb_Test_Min_Word_Height";
            this.Tb_Test_Min_Word_Height.PromptChar = ' ';
            this.Tb_Test_Min_Word_Height.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Min_Word_Height.TabIndex = 17;
            this.Tb_Test_Min_Word_Height.Text = "0";
            // 
            // Tb_Test_Min_Width
            // 
            this.Tb_Test_Min_Width.Enabled = false;
            this.Tb_Test_Min_Width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Min_Width.Location = new System.Drawing.Point(391, 137);
            this.Tb_Test_Min_Width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Min_Width.Mask = "999";
            this.Tb_Test_Min_Width.Name = "Tb_Test_Min_Width";
            this.Tb_Test_Min_Width.PromptChar = ' ';
            this.Tb_Test_Min_Width.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Min_Width.TabIndex = 18;
            this.Tb_Test_Min_Width.Text = "0";
            // 
            // Tb_Test_Min_Word_Width
            // 
            this.Tb_Test_Min_Word_Width.Enabled = false;
            this.Tb_Test_Min_Word_Width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Min_Word_Width.Location = new System.Drawing.Point(391, 97);
            this.Tb_Test_Min_Word_Width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Min_Word_Width.Mask = "999";
            this.Tb_Test_Min_Word_Width.Name = "Tb_Test_Min_Word_Width";
            this.Tb_Test_Min_Word_Width.PromptChar = ' ';
            this.Tb_Test_Min_Word_Width.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Min_Word_Width.TabIndex = 16;
            this.Tb_Test_Min_Word_Width.Text = "0";
            // 
            // Tb_Test_Max_Word_Height
            // 
            this.Tb_Test_Max_Word_Height.Enabled = false;
            this.Tb_Test_Max_Word_Height.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Max_Word_Height.Location = new System.Drawing.Point(193, 60);
            this.Tb_Test_Max_Word_Height.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Max_Word_Height.Mask = "999";
            this.Tb_Test_Max_Word_Height.Name = "Tb_Test_Max_Word_Height";
            this.Tb_Test_Max_Word_Height.PromptChar = ' ';
            this.Tb_Test_Max_Word_Height.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Max_Word_Height.TabIndex = 14;
            this.Tb_Test_Max_Word_Height.Text = "0";
            // 
            // Tb_Test_Max_Width
            // 
            this.Tb_Test_Max_Width.Enabled = false;
            this.Tb_Test_Max_Width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Max_Width.Location = new System.Drawing.Point(193, 137);
            this.Tb_Test_Max_Width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Max_Width.Mask = "999";
            this.Tb_Test_Max_Width.Name = "Tb_Test_Max_Width";
            this.Tb_Test_Max_Width.PromptChar = ' ';
            this.Tb_Test_Max_Width.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Max_Width.TabIndex = 15;
            this.Tb_Test_Max_Width.Text = "0";
            // 
            // Tb_Test_Max_Word_Width
            // 
            this.Tb_Test_Max_Word_Width.Enabled = false;
            this.Tb_Test_Max_Word_Width.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Tb_Test_Max_Word_Width.Location = new System.Drawing.Point(193, 97);
            this.Tb_Test_Max_Word_Width.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Test_Max_Word_Width.Mask = "999";
            this.Tb_Test_Max_Word_Width.Name = "Tb_Test_Max_Word_Width";
            this.Tb_Test_Max_Word_Width.PromptChar = ' ';
            this.Tb_Test_Max_Word_Width.Size = new System.Drawing.Size(48, 34);
            this.Tb_Test_Max_Word_Width.TabIndex = 13;
            this.Tb_Test_Max_Word_Width.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 27);
            this.label11.TabIndex = 6;
            this.label11.Text = "字高 ：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 141);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "筆畫寬度：";
            // 
            // btn_Create_Test_OCR_Model
            // 
            this.btn_Create_Test_OCR_Model.Location = new System.Drawing.Point(8, 26);
            this.btn_Create_Test_OCR_Model.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create_Test_OCR_Model.Name = "btn_Create_Test_OCR_Model";
            this.btn_Create_Test_OCR_Model.Size = new System.Drawing.Size(100, 36);
            this.btn_Create_Test_OCR_Model.TabIndex = 25;
            this.btn_Create_Test_OCR_Model.Text = "建立OCR";
            this.btn_Create_Test_OCR_Model.UseVisualStyleBackColor = true;
            this.btn_Create_Test_OCR_Model.Click += new System.EventHandler(this.btn_Create_Test_OCR_Model_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 101);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 27);
            this.label13.TabIndex = 7;
            this.label13.Text = "字寬 :";
            // 
            // txt_Test_Folder_Path
            // 
            this.txt_Test_Folder_Path.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Test_Folder_Path.Location = new System.Drawing.Point(110, 15);
            this.txt_Test_Folder_Path.Name = "txt_Test_Folder_Path";
            this.txt_Test_Folder_Path.Size = new System.Drawing.Size(354, 34);
            this.txt_Test_Folder_Path.TabIndex = 38;
            this.txt_Test_Folder_Path.Text = "C:\\Users\\LouisDing\\Desktop\\Work\\TSMC\\20220629_修改過的訓練檔 _字母B\\L4V1B8.L6_2228\\Station" +
    "A\\Lot6";
            // 
            // btn_Load_TestFolder
            // 
            this.btn_Load_TestFolder.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_Load_TestFolder.Location = new System.Drawing.Point(10, 12);
            this.btn_Load_TestFolder.Name = "btn_Load_TestFolder";
            this.btn_Load_TestFolder.Size = new System.Drawing.Size(92, 40);
            this.btn_Load_TestFolder.TabIndex = 37;
            this.btn_Load_TestFolder.Text = "Load";
            this.btn_Load_TestFolder.UseVisualStyleBackColor = true;
            this.btn_Load_TestFolder.Click += new System.EventHandler(this.btn_Load_TestFolder_Click);
            // 
            // bgW_Classify
            // 
            this.bgW_Classify.WorkerReportsProgress = true;
            this.bgW_Classify.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_Classify_DoWork);
            this.bgW_Classify.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_Classify_ProgressChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1050, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1050, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bgW_TraingOCR
            // 
            this.bgW_TraingOCR.WorkerReportsProgress = true;
            this.bgW_TraingOCR.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_TraingOCR_DoWork);
            this.bgW_TraingOCR.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_TraingOCR_ProgressChanged);
            // 
            // bgW_RunTestOCR
            // 
            this.bgW_RunTestOCR.WorkerReportsProgress = true;
            this.bgW_RunTestOCR.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgW_RunTestOCR_DoWork);
            this.bgW_RunTestOCR.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgW_RunTestOCR_ProgressChanged);
            // 
            // btn_Show_Training_File_Browser
            // 
            this.btn_Show_Training_File_Browser.Location = new System.Drawing.Point(851, 14);
            this.btn_Show_Training_File_Browser.Name = "btn_Show_Training_File_Browser";
            this.btn_Show_Training_File_Browser.Size = new System.Drawing.Size(117, 34);
            this.btn_Show_Training_File_Browser.TabIndex = 10;
            this.btn_Show_Training_File_Browser.Text = "Browser";
            this.btn_Show_Training_File_Browser.UseVisualStyleBackColor = true;
            this.btn_Show_Training_File_Browser.Click += new System.EventHandler(this.btn_Show_Training_File_Browser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 560);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabCon_Char_Classifier);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "OCR 訓練程式";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabCon_Char_Classifier.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gBx_Basic_Setting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gBx_Advance_Setting.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCon_Char_Classifier;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Compare_text;
        private System.Windows.Forms.Label lbl_Compare_text;
        private System.Windows.Forms.Button btn_load_image_folder;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Trigger;
        private System.Windows.Forms.Button btn_Connect;
        private HalconDotNet.HSmartWindowControl HSWC;
        private System.ComponentModel.BackgroundWorker bgW_Classify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cb_min_width_auto;
        private System.Windows.Forms.CheckBox cb_min_word_width_auto;
        private System.Windows.Forms.CheckBox cb_min_word_high_auto;
        private System.Windows.Forms.CheckBox cb_max_width_auto;
        private System.Windows.Forms.CheckBox cb_max_word_width_auto;
        private System.Windows.Forms.ComboBox CB_OCR_type;
        private System.Windows.Forms.CheckBox cb_max_word_high_auto;
        private System.Windows.Forms.MaskedTextBox Tb_min_word_high;
        private System.Windows.Forms.MaskedTextBox Tb_min_width;
        private System.Windows.Forms.MaskedTextBox Tb_min_word_width;
        private System.Windows.Forms.MaskedTextBox Tb_max_word_high;
        private System.Windows.Forms.MaskedTextBox Tb_max_width;
        private System.Windows.Forms.MaskedTextBox Tb_max_word_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_build_OCR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Identify_result;
        private System.Windows.Forms.TextBox txt_Identify_result;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Start_Train_OCR;
        private System.Windows.Forms.Label lbl_Classify_State;
        private System.Windows.Forms.ProgressBar proBar_Classify_Process;
        private System.Windows.Forms.Label lbl_Train_OCR_Filename;
        private System.Windows.Forms.TextBox txt_Train_OCR_Filename;
        private System.Windows.Forms.GroupBox gBx_Advance_Setting;
        private System.Windows.Forms.CheckedListBox cLB_Advance_Setting;
        private System.Windows.Forms.Label lbl_Interpolate;
        private System.Windows.Forms.ComboBox cBx_Interpolate;
        private System.Windows.Forms.GroupBox gBx_Basic_Setting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdo_pixel_binary;
        private System.Windows.Forms.RadioButton rdo_pixel_invar;
        private System.Windows.Forms.RadioButton rdo_gradient_8dir;
        private System.Windows.Forms.CheckBox cB_ratio;
        private System.Windows.Forms.CheckBox cB_anisometry;
        private System.Windows.Forms.CheckBox cB_convexity;
        private System.Windows.Forms.Button btn_Load_Traing_File;
        private System.Windows.Forms.Label lbl_plan_A_Yield;
        private System.Windows.Forms.Label lbl_plan_A_NG;
        private System.Windows.Forms.Label lbl_plan_A_OK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Run_Image_Test;
        private System.Windows.Forms.Button btn_SingleTest_Trigger;
        private System.Windows.Forms.Button btn_TestFolder_Connect;
        private System.Windows.Forms.TextBox txt_Comparison_Words;
        private System.Windows.Forms.Label lbl_Comparison_Words;
        private HalconDotNet.HSmartWindowControl HSWC_Test;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_Test_min_width_auto;
        private System.Windows.Forms.CheckBox cb_Test_min_word_width_auto;
        private System.Windows.Forms.CheckBox cb_Test_min_word_high_auto;
        private System.Windows.Forms.CheckBox cb_Test_max_width_auto;
        private System.Windows.Forms.CheckBox cb_Test_max_word_width_auto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cb_Test_max_word_high_auto;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Min_Word_Height;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Min_Width;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Min_Word_Width;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Max_Word_Height;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Max_Width;
        private System.Windows.Forms.MaskedTextBox Tb_Test_Max_Word_Width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Create_Test_OCR_Model;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Test_Folder_Path;
        private System.Windows.Forms.Button btn_Load_TestFolder;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cB_Advance_Setting_Enable;
        private System.Windows.Forms.ComboBox cbo_Identification_Restrictions;
        private System.Windows.Forms.Label lbl_Identification_Restrictions;
        private System.ComponentModel.BackgroundWorker bgW_TraingOCR;
        private System.ComponentModel.BackgroundWorker bgW_RunTestOCR;
        private System.Windows.Forms.TextBox txt_Exclude_Chars;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_Show_Training_File_Browser;
    }
}

