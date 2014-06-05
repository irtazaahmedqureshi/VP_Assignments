namespace ImageProcessor___FA11_BCS_069
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_GetImagePath = new System.Windows.Forms.TextBox();
            this.btn_ImageSelection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ofd_Image = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Size = new System.Windows.Forms.Panel();
            this.lbl_h_px = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.ddl_DimensionsImage = new System.Windows.Forms.ComboBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.lbl_w_px = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.checkBox_Resize = new System.Windows.Forms.CheckBox();
            this.ddl_ImageFormats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ImagesCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sfd_Image = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_startConversion = new System.Windows.Forms.Button();
            this.fBd = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar_ImageProcessor = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Size.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Strung", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Processor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_GetImagePath);
            this.groupBox1.Controls.Add(this.btn_ImageSelection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 208);
            this.panel1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(835, 208);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_GetImagePath
            // 
            this.txt_GetImagePath.Location = new System.Drawing.Point(90, 16);
            this.txt_GetImagePath.Name = "txt_GetImagePath";
            this.txt_GetImagePath.ReadOnly = true;
            this.txt_GetImagePath.Size = new System.Drawing.Size(665, 23);
            this.txt_GetImagePath.TabIndex = 6;
            // 
            // btn_ImageSelection
            // 
            this.btn_ImageSelection.Location = new System.Drawing.Point(766, 15);
            this.btn_ImageSelection.Name = "btn_ImageSelection";
            this.btn_ImageSelection.Size = new System.Drawing.Size(63, 23);
            this.btn_ImageSelection.TabIndex = 0;
            this.btn_ImageSelection.Text = "Browse";
            this.btn_ImageSelection.UseVisualStyleBackColor = true;
            this.btn_ImageSelection.Click += new System.EventHandler(this.btn_ImageSelection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Image:";
            // 
            // ofd_Image
            // 
            this.ofd_Image.Filter = "Image Files (.JPG, .JPEG, .PNG, .BMP, .GIF, .TIFF)|*.jpg;*.jpeg;*.png;*.bmp;*.gif" +
    ";*.tiff|All Files|*.*";
            this.ofd_Image.Multiselect = true;
            this.ofd_Image.Title = "Select Image For ImageProcessing";
            this.ofd_Image.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Image_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ClearList);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.panel_Size);
            this.groupBox2.Controls.Add(this.checkBox_Resize);
            this.groupBox2.Controls.Add(this.ddl_ImageFormats);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 179);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2:";
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.Location = new System.Drawing.Point(132, 144);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearList.TabIndex = 17;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = true;
            this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clear List:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Size:";
            // 
            // panel_Size
            // 
            this.panel_Size.Controls.Add(this.lbl_h_px);
            this.panel_Size.Controls.Add(this.lbl_Width);
            this.panel_Size.Controls.Add(this.ddl_DimensionsImage);
            this.panel_Size.Controls.Add(this.txt_Width);
            this.panel_Size.Controls.Add(this.txt_Height);
            this.panel_Size.Controls.Add(this.lbl_w_px);
            this.panel_Size.Controls.Add(this.label_Height);
            this.panel_Size.Location = new System.Drawing.Point(112, 65);
            this.panel_Size.Name = "panel_Size";
            this.panel_Size.Size = new System.Drawing.Size(305, 62);
            this.panel_Size.TabIndex = 16;
            // 
            // lbl_h_px
            // 
            this.lbl_h_px.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_h_px.AutoSize = true;
            this.lbl_h_px.Location = new System.Drawing.Point(136, 35);
            this.lbl_h_px.Name = "lbl_h_px";
            this.lbl_h_px.Size = new System.Drawing.Size(20, 15);
            this.lbl_h_px.TabIndex = 11;
            this.lbl_h_px.Text = "px";
            // 
            // lbl_Width
            // 
            this.lbl_Width.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(23, 35);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(44, 15);
            this.lbl_Width.TabIndex = 13;
            this.lbl_Width.Text = "Width:";
            // 
            // ddl_DimensionsImage
            // 
            this.ddl_DimensionsImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddl_DimensionsImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_DimensionsImage.FormattingEnabled = true;
            this.ddl_DimensionsImage.Items.AddRange(new object[] {
            "Smaller: 640 x 480",
            "Small: 800 x 600",
            "Medium: 1024 x 768",
            "Large: 1280 x 960",
            "Custom Size"});
            this.ddl_DimensionsImage.Location = new System.Drawing.Point(20, 3);
            this.ddl_DimensionsImage.Name = "ddl_DimensionsImage";
            this.ddl_DimensionsImage.Size = new System.Drawing.Size(273, 23);
            this.ddl_DimensionsImage.TabIndex = 7;
            this.ddl_DimensionsImage.SelectedIndexChanged += new System.EventHandler(this.ddl_DimensionsImage_SelectedIndexChanged);
            // 
            // txt_Width
            // 
            this.txt_Width.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Width.Location = new System.Drawing.Point(67, 32);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(63, 23);
            this.txt_Width.TabIndex = 12;
            // 
            // txt_Height
            // 
            this.txt_Height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Height.Location = new System.Drawing.Point(204, 32);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(61, 23);
            this.txt_Height.TabIndex = 8;
            // 
            // lbl_w_px
            // 
            this.lbl_w_px.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_w_px.AutoSize = true;
            this.lbl_w_px.Location = new System.Drawing.Point(271, 35);
            this.lbl_w_px.Name = "lbl_w_px";
            this.lbl_w_px.Size = new System.Drawing.Size(20, 15);
            this.lbl_w_px.TabIndex = 14;
            this.lbl_w_px.Text = "px";
            // 
            // label_Height
            // 
            this.label_Height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(157, 35);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(45, 15);
            this.label_Height.TabIndex = 10;
            this.label_Height.Text = "Height:";
            // 
            // checkBox_Resize
            // 
            this.checkBox_Resize.AutoSize = true;
            this.checkBox_Resize.Location = new System.Drawing.Point(132, 45);
            this.checkBox_Resize.Name = "checkBox_Resize";
            this.checkBox_Resize.Size = new System.Drawing.Size(60, 19);
            this.checkBox_Resize.TabIndex = 15;
            this.checkBox_Resize.Text = "Resize";
            this.checkBox_Resize.UseVisualStyleBackColor = true;
            this.checkBox_Resize.CheckedChanged += new System.EventHandler(this.checkBox_Resize_CheckedChanged);
            // 
            // ddl_ImageFormats
            // 
            this.ddl_ImageFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_ImageFormats.FormattingEnabled = true;
            this.ddl_ImageFormats.Items.AddRange(new object[] {
            ".JPEG",
            ".PNG",
            ".GIF",
            ".BMP",
            ".TIFF"});
            this.ddl_ImageFormats.Location = new System.Drawing.Point(132, 16);
            this.ddl_ImageFormats.Name = "ddl_ImageFormats";
            this.ddl_ImageFormats.Size = new System.Drawing.Size(273, 23);
            this.ddl_ImageFormats.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select Image Format:";
            // 
            // lbl_ImagesCounter
            // 
            this.lbl_ImagesCounter.Location = new System.Drawing.Point(148, 24);
            this.lbl_ImagesCounter.Name = "lbl_ImagesCounter";
            this.lbl_ImagesCounter.Size = new System.Drawing.Size(252, 32);
            this.lbl_ImagesCounter.TabIndex = 6;
            this.lbl_ImagesCounter.Text = "0 / 0 Converted.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Images Converted:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_startConversion);
            this.groupBox3.Controls.Add(this.lbl_ImagesCounter);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(435, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 179);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3:";
            // 
            // btn_startConversion
            // 
            this.btn_startConversion.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_startConversion.Location = new System.Drawing.Point(28, 62);
            this.btn_startConversion.Name = "btn_startConversion";
            this.btn_startConversion.Size = new System.Drawing.Size(358, 91);
            this.btn_startConversion.TabIndex = 0;
            this.btn_startConversion.Text = "Start &Conversion  ";
            this.btn_startConversion.UseVisualStyleBackColor = true;
            this.btn_startConversion.Click += new System.EventHandler(this.btn_startConversion_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar_ImageProcessor
            // 
            this.progressBar_ImageProcessor.Location = new System.Drawing.Point(6, 531);
            this.progressBar_ImageProcessor.Name = "progressBar_ImageProcessor";
            this.progressBar_ImageProcessor.Size = new System.Drawing.Size(835, 35);
            this.progressBar_ImageProcessor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(853, 570);
            this.Controls.Add(this.progressBar_ImageProcessor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processor - FA11-BCS-069";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Size.ResumeLayout(false);
            this.panel_Size.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ImageSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofd_Image;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddl_ImageFormats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog sfd_Image;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_startConversion;
        private System.Windows.Forms.TextBox txt_GetImagePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddl_DimensionsImage;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label lbl_w_px;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Label lbl_h_px;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkBox_Resize;
        private System.Windows.Forms.Panel panel_Size;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FolderBrowserDialog fBd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar_ImageProcessor;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ImagesCounter;
        private System.Windows.Forms.Label label5;
    }
}

