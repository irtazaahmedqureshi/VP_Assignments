namespace Assignment_4
{
    partial class CategoryTotal
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
            this.grd_total_expense_catgories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_total_expense_catgories)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_total_expense_catgories
            // 
            this.grd_total_expense_catgories.AllowUserToAddRows = false;
            this.grd_total_expense_catgories.AllowUserToDeleteRows = false;
            this.grd_total_expense_catgories.AllowUserToOrderColumns = true;
            this.grd_total_expense_catgories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_total_expense_catgories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_total_expense_catgories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_total_expense_catgories.Location = new System.Drawing.Point(0, 0);
            this.grd_total_expense_catgories.Name = "grd_total_expense_catgories";
            this.grd_total_expense_catgories.ReadOnly = true;
            this.grd_total_expense_catgories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_total_expense_catgories.Size = new System.Drawing.Size(358, 208);
            this.grd_total_expense_catgories.TabIndex = 0;
            // 
            // CategoryTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 208);
            this.Controls.Add(this.grd_total_expense_catgories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoryTotal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Total";
            this.Load += new System.EventHandler(this.CategoryTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_total_expense_catgories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_total_expense_catgories;
    }
}