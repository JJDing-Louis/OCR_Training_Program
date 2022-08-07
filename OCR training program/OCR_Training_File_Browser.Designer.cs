
namespace OCR_training_program
{
    partial class OCR_Training_File_Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCR_Training_File_Browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tV_CharList = new System.Windows.Forms.TreeView();
            this.HSWC_Char_Image = new HalconDotNet.HSmartWindowControl();
            this.dgV_CharList = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_CharList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgV_CharList);
            this.splitContainer1.Size = new System.Drawing.Size(1036, 595);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tV_CharList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.HSWC_Char_Image);
            this.splitContainer2.Size = new System.Drawing.Size(345, 595);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // tV_CharList
            // 
            this.tV_CharList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_CharList.Location = new System.Drawing.Point(0, 0);
            this.tV_CharList.Name = "tV_CharList";
            this.tV_CharList.Size = new System.Drawing.Size(345, 268);
            this.tV_CharList.TabIndex = 0;
            this.tV_CharList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_CharList_AfterSelect);
            // 
            // HSWC_Char_Image
            // 
            this.HSWC_Char_Image.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HSWC_Char_Image.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.HSWC_Char_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSWC_Char_Image.HDoubleClickToFitContent = true;
            this.HSWC_Char_Image.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            this.HSWC_Char_Image.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HSWC_Char_Image.HKeepAspectRatio = true;
            this.HSWC_Char_Image.HMoveContent = true;
            this.HSWC_Char_Image.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            this.HSWC_Char_Image.Location = new System.Drawing.Point(0, 0);
            this.HSWC_Char_Image.Margin = new System.Windows.Forms.Padding(0);
            this.HSWC_Char_Image.Name = "HSWC_Char_Image";
            this.HSWC_Char_Image.Size = new System.Drawing.Size(345, 317);
            this.HSWC_Char_Image.TabIndex = 0;
            this.HSWC_Char_Image.WindowSize = new System.Drawing.Size(345, 317);
            // 
            // dgV_CharList
            // 
            this.dgV_CharList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_CharList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_CharList.Location = new System.Drawing.Point(0, 0);
            this.dgV_CharList.Name = "dgV_CharList";
            this.dgV_CharList.RowHeadersWidth = 51;
            this.dgV_CharList.RowTemplate.Height = 27;
            this.dgV_CharList.Size = new System.Drawing.Size(681, 595);
            this.dgV_CharList.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(66, 24);
            this.btn_Save.Text = "Save";
            this.btn_Save.ToolTipText = "Save";
            // 
            // OCR_Training_File_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 622);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OCR_Training_File_Browser";
            this.Text = "Training File Browser";
            this.Load += new System.EventHandler(this.OCR_Training_File_Browser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV_CharList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tV_CharList;
        private HalconDotNet.HSmartWindowControl HSWC_Char_Image;
        private System.Windows.Forms.DataGridView dgV_CharList;
        private System.Windows.Forms.ToolStripButton btn_Save;
    }
}