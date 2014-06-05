namespace Assignment_4
{
    partial class ViewExpenses
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
            this.grdvw_expenses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butto_del = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_expense_name_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_total_expense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_expenses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdvw_expenses
            // 
            this.grdvw_expenses.AllowUserToAddRows = false;
            this.grdvw_expenses.AllowUserToDeleteRows = false;
            this.grdvw_expenses.AllowUserToOrderColumns = true;
            this.grdvw_expenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvw_expenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdvw_expenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw_expenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvw_expenses.Location = new System.Drawing.Point(0, 0);
            this.grdvw_expenses.Name = "grdvw_expenses";
            this.grdvw_expenses.ReadOnly = true;
            this.grdvw_expenses.Size = new System.Drawing.Size(799, 442);
            this.grdvw_expenses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butto_del);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.lbl_total_expense);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_expense_name_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 35);
            this.panel1.TabIndex = 1;
            // 
            // butto_del
            // 
            this.butto_del.Location = new System.Drawing.Point(154, 3);
            this.butto_del.Name = "butto_del";
            this.butto_del.Size = new System.Drawing.Size(71, 29);
            this.butto_del.TabIndex = 2;
            this.butto_del.Text = "&Delete";
            this.butto_del.UseVisualStyleBackColor = true;
            this.butto_del.Click += new System.EventHandler(this.butto_del_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(88, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(60, 29);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "&Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(3, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(79, 29);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "&Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // txt_expense_name_search
            // 
            this.txt_expense_name_search.Location = new System.Drawing.Point(610, 5);
            this.txt_expense_name_search.Name = "txt_expense_name_search";
            this.txt_expense_name_search.Size = new System.Drawing.Size(184, 27);
            this.txt_expense_name_search.TabIndex = 0;
            this.txt_expense_name_search.TextChanged += new System.EventHandler(this.txt_expense_name_search_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdvw_expenses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 442);
            this.panel2.TabIndex = 2;
            // 
            // lbl_total_expense
            // 
            this.lbl_total_expense.AutoSize = true;
            this.lbl_total_expense.Location = new System.Drawing.Point(231, 9);
            this.lbl_total_expense.Name = "lbl_total_expense";
            this.lbl_total_expense.Size = new System.Drawing.Size(107, 19);
            this.lbl_total_expense.TabIndex = 1;
            this.lbl_total_expense.Text = "Total Expense: ";
            // 
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExpenses";
            this.Load += new System.EventHandler(this.ViewExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_expenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdvw_expenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_expense_name_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butto_del;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label lbl_total_expense;
    }
}