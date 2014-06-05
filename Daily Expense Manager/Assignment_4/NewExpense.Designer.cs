namespace Assignment_4
{
    partial class NewExpense
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
            this.btn_NewExpense = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_expense_category = new System.Windows.Forms.ComboBox();
            this.dateTime_Expense = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_amount_expense = new System.Windows.Forms.TextBox();
            this.textbox_Expense_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_NewExpense
            // 
            this.btn_NewExpense.Location = new System.Drawing.Point(334, 183);
            this.btn_NewExpense.Name = "btn_NewExpense";
            this.btn_NewExpense.Size = new System.Drawing.Size(88, 33);
            this.btn_NewExpense.TabIndex = 7;
            this.btn_NewExpense.Text = "&Add";
            this.btn_NewExpense.UseVisualStyleBackColor = true;
            this.btn_NewExpense.Click += new System.EventHandler(this.btn_NewExpense_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 50);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F);
            this.label3.Location = new System.Drawing.Point(95, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add New Expense";
            // 
            // cmb_expense_category
            // 
            this.cmb_expense_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_expense_category.FormattingEnabled = true;
            this.cmb_expense_category.Location = new System.Drawing.Point(164, 51);
            this.cmb_expense_category.Name = "cmb_expense_category";
            this.cmb_expense_category.Size = new System.Drawing.Size(258, 27);
            this.cmb_expense_category.TabIndex = 20;
            // 
            // dateTime_Expense
            // 
            this.dateTime_Expense.Location = new System.Drawing.Point(164, 117);
            this.dateTime_Expense.Name = "dateTime_Expense";
            this.dateTime_Expense.Size = new System.Drawing.Size(258, 27);
            this.dateTime_Expense.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Expense Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Expense Date Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Expense Name:";
            // 
            // textbox_amount_expense
            // 
            this.textbox_amount_expense.Location = new System.Drawing.Point(164, 150);
            this.textbox_amount_expense.Name = "textbox_amount_expense";
            this.textbox_amount_expense.Size = new System.Drawing.Size(258, 27);
            this.textbox_amount_expense.TabIndex = 14;
            // 
            // textbox_Expense_Name
            // 
            this.textbox_Expense_Name.Location = new System.Drawing.Point(164, 84);
            this.textbox_Expense_Name.Name = "textbox_Expense_Name";
            this.textbox_Expense_Name.Size = new System.Drawing.Size(258, 27);
            this.textbox_Expense_Name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Expense Category:";
            // 
            // NewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_expense_category);
            this.Controls.Add(this.dateTime_Expense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_amount_expense);
            this.Controls.Add(this.textbox_Expense_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NewExpense);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Expense";
            this.Load += new System.EventHandler(this.AddNewExpense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_expense_category;
        private System.Windows.Forms.DateTimePicker dateTime_Expense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_amount_expense;
        private System.Windows.Forms.TextBox textbox_Expense_Name;
        private System.Windows.Forms.Label label1;


    }
}