namespace Assignment_4
{
    partial class ViewExpense
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
            this.btn_total_sum_category_expense = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.lbl_total_expense = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdvw_expenses = new System.Windows.Forms.DataGridView();
            this.grdvw_categories = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_total_sum_category_expense);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.lbl_total_expense);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 35);
            this.panel1.TabIndex = 3;
            // 
            // btn_total_sum_category_expense
            // 
            this.btn_total_sum_category_expense.Location = new System.Drawing.Point(88, 3);
            this.btn_total_sum_category_expense.Name = "btn_total_sum_category_expense";
            this.btn_total_sum_category_expense.Size = new System.Drawing.Size(142, 29);
            this.btn_total_sum_category_expense.TabIndex = 2;
            this.btn_total_sum_category_expense.Text = "&Total Category Expense";
            this.btn_total_sum_category_expense.UseVisualStyleBackColor = true;
            this.btn_total_sum_category_expense.Click += new System.EventHandler(this.btn_total_sum_category_expense_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(3, 3);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(79, 29);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "&Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // lbl_total_expense
            // 
            this.lbl_total_expense.AutoSize = true;
            this.lbl_total_expense.Location = new System.Drawing.Point(454, 11);
            this.lbl_total_expense.Name = "lbl_total_expense";
            this.lbl_total_expense.Size = new System.Drawing.Size(81, 13);
            this.lbl_total_expense.TabIndex = 1;
            this.lbl_total_expense.Text = "Total Expense: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdvw_categories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdvw_expenses);
            this.splitContainer1.Size = new System.Drawing.Size(720, 441);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 5;
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
            this.grdvw_expenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvw_expenses.Size = new System.Drawing.Size(720, 343);
            this.grdvw_expenses.TabIndex = 1;
            // 
            // grdvw_categories
            // 
            this.grdvw_categories.AllowUserToAddRows = false;
            this.grdvw_categories.AllowUserToDeleteRows = false;
            this.grdvw_categories.AllowUserToOrderColumns = true;
            this.grdvw_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvw_categories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdvw_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvw_categories.Location = new System.Drawing.Point(0, 0);
            this.grdvw_categories.Name = "grdvw_categories";
            this.grdvw_categories.ReadOnly = true;
            this.grdvw_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvw_categories.Size = new System.Drawing.Size(720, 94);
            this.grdvw_categories.TabIndex = 0;
            this.grdvw_categories.SelectionChanged += new System.EventHandler(this.grdvw_categories_SelectionChanged);
            // 
            // ViewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 476);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewExpense";
            this.Text = "ViewExpense";
            this.Load += new System.EventHandler(this.ViewExpense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_expenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_total_sum_category_expense;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label lbl_total_expense;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grdvw_expenses;
        private System.Windows.Forms.DataGridView grdvw_categories;
    }
}