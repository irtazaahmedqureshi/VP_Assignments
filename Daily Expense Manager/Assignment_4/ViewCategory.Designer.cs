namespace Assignment_4
{
    partial class ViewCategory
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
            this.grdview_Categories = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdview_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // grdview_Categories
            // 
            this.grdview_Categories.AllowUserToAddRows = false;
            this.grdview_Categories.AllowUserToDeleteRows = false;
            this.grdview_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdview_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name});
            this.grdview_Categories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdview_Categories.Location = new System.Drawing.Point(0, 42);
            this.grdview_Categories.Margin = new System.Windows.Forms.Padding(4);
            this.grdview_Categories.Name = "grdview_Categories";
            this.grdview_Categories.ReadOnly = true;
            this.grdview_Categories.Size = new System.Drawing.Size(450, 362);
            this.grdview_Categories.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Category Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(5, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 31);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(91, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 31);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 404);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.grdview_Categories);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "ViewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Category";
            this.Load += new System.EventHandler(this.ViewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdview_Categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdview_Categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_delete;
    }
}