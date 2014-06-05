namespace WebBrowser_
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb_url_Load = new System.Windows.Forms.ToolStripProgressBar();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_GO = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.webrwsr = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb_url_Load});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb_url_Load
            // 
            this.pb_url_Load.Name = "pb_url_Load";
            this.pb_url_Load.Size = new System.Drawing.Size(100, 16);
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(102, 2);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(597, 27);
            this.txt_url.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.btn_GO);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.txt_url);
            this.panel1.Controls.Add(this.btn_forward);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 32);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "G",
            "B",
            "DDG"});
            this.comboBox1.Location = new System.Drawing.Point(977, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Image = global::WebBrowser_.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(1034, -1);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 33);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(778, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 27);
            this.txt_search.TabIndex = 7;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::WebBrowser_.Properties.Resources.refresh;
            this.btn_Refresh.Location = new System.Drawing.Point(64, 0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(32, 32);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_GO
            // 
            this.btn_GO.Image = global::WebBrowser_.Properties.Resources.go;
            this.btn_GO.Location = new System.Drawing.Point(705, 0);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(32, 32);
            this.btn_GO.TabIndex = 5;
            this.btn_GO.UseVisualStyleBackColor = true;
            this.btn_GO.Click += new System.EventHandler(this.btn_GO_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::WebBrowser_.Properties.Resources.back;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(32, 32);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::WebBrowser_.Properties.Resources.foward;
            this.btn_forward.Location = new System.Drawing.Point(32, 0);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(32, 32);
            this.btn_forward.TabIndex = 3;
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // webrwsr
            // 
            this.webrwsr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webrwsr.Location = new System.Drawing.Point(0, 32);
            this.webrwsr.MinimumSize = new System.Drawing.Size(20, 20);
            this.webrwsr.Name = "webrwsr";
            this.webrwsr.ScriptErrorsSuppressed = true;
            this.webrwsr.Size = new System.Drawing.Size(1066, 387);
            this.webrwsr.TabIndex = 6;
            this.webrwsr.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webrwsr_DocumentCompleted);
            this.webrwsr.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webrwsr_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 441);
            this.Controls.Add(this.webrwsr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pb_url_Load;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GO;
        private System.Windows.Forms.WebBrowser webrwsr;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

