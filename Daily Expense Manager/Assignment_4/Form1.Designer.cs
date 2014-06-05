namespace Assignment_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_expense = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 32F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright © 2014 Daily Expense Manager. All Rights Reserved.";
            // 
            // btn_expense
            // 
            this.btn_expense.Font = new System.Drawing.Font("Calibri", 18F);
            this.btn_expense.Location = new System.Drawing.Point(89, 107);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(275, 76);
            this.btn_expense.TabIndex = 1;
            this.btn_expense.Text = "&Expense Management";
            this.btn_expense.UseVisualStyleBackColor = true;
            this.btn_expense.Click += new System.EventHandler(this.btn_view_expense_Click);
            // 
            // btn_category
            // 
            this.btn_category.Font = new System.Drawing.Font("Calibri", 18F);
            this.btn_category.Location = new System.Drawing.Point(89, 202);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(275, 76);
            this.btn_category.TabIndex = 2;
            this.btn_category.Text = "&Category Management";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(341, 409);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 30);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 18F);
            this.button1.Location = new System.Drawing.Point(89, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Quiz Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_expense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Expense Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}

