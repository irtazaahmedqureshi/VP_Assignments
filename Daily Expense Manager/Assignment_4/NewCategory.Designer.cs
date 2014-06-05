namespace Assignment_4
{
    partial class NewCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.btn_NewCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F);
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name:";
            // 
            // txt_category_name
            // 
            this.txt_category_name.Location = new System.Drawing.Point(152, 74);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(240, 31);
            this.txt_category_name.TabIndex = 1;
            // 
            // btn_NewCategory
            // 
            this.btn_NewCategory.Location = new System.Drawing.Point(293, 121);
            this.btn_NewCategory.Name = "btn_NewCategory";
            this.btn_NewCategory.Size = new System.Drawing.Size(99, 38);
            this.btn_NewCategory.TabIndex = 2;
            this.btn_NewCategory.Text = "&Add";
            this.btn_NewCategory.UseVisualStyleBackColor = true;
            this.btn_NewCategory.Click += new System.EventHandler(this.btn_NewCategory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_NewCategory);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "NewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.Button btn_NewCategory;
        private System.Windows.Forms.Button button1;
    }
}