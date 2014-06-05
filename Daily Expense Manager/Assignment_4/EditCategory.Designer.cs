namespace Assignment_4
{
    partial class EditCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_old_catname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_newCatName = new System.Windows.Forms.TextBox();
            this.button_SaveChanges = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 50);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F);
            this.label3.Location = new System.Drawing.Point(105, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edit Category";
            // 
            // textBox_old_catname
            // 
            this.textBox_old_catname.Location = new System.Drawing.Point(161, 71);
            this.textBox_old_catname.Name = "textBox_old_catname";
            this.textBox_old_catname.ReadOnly = true;
            this.textBox_old_catname.Size = new System.Drawing.Size(225, 27);
            this.textBox_old_catname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Category Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Category Name:";
            // 
            // textBox_newCatName
            // 
            this.textBox_newCatName.Location = new System.Drawing.Point(161, 104);
            this.textBox_newCatName.Name = "textBox_newCatName";
            this.textBox_newCatName.Size = new System.Drawing.Size(225, 27);
            this.textBox_newCatName.TabIndex = 1;
            // 
            // button_SaveChanges
            // 
            this.button_SaveChanges.Location = new System.Drawing.Point(136, 147);
            this.button_SaveChanges.Name = "button_SaveChanges";
            this.button_SaveChanges.Size = new System.Drawing.Size(112, 27);
            this.button_SaveChanges.TabIndex = 3;
            this.button_SaveChanges.Text = "&Save Changes";
            this.button_SaveChanges.UseVisualStyleBackColor = true;
            this.button_SaveChanges.Click += new System.EventHandler(this.button_SaveChanges_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 186);
            this.Controls.Add(this.button_SaveChanges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_newCatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_old_catname);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Category";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_old_catname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newCatName;
        private System.Windows.Forms.Button button_SaveChanges;
        private System.Windows.Forms.Label label3;
    }
}