namespace Assignment_4
{
    partial class CategoryManagement
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
            this.btn_AddNewCategory = new System.Windows.Forms.Button();
            this.btn_view_categories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mian_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddNewCategory
            // 
            this.btn_AddNewCategory.Location = new System.Drawing.Point(85, 78);
            this.btn_AddNewCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewCategory.Name = "btn_AddNewCategory";
            this.btn_AddNewCategory.Size = new System.Drawing.Size(166, 45);
            this.btn_AddNewCategory.TabIndex = 2;
            this.btn_AddNewCategory.Text = "&Add New Category";
            this.btn_AddNewCategory.UseVisualStyleBackColor = true;
            this.btn_AddNewCategory.Click += new System.EventHandler(this.btn_AddNewCategory_Click);
            // 
            // btn_view_categories
            // 
            this.btn_view_categories.Location = new System.Drawing.Point(43, 141);
            this.btn_view_categories.Margin = new System.Windows.Forms.Padding(4);
            this.btn_view_categories.Name = "btn_view_categories";
            this.btn_view_categories.Size = new System.Drawing.Size(245, 45);
            this.btn_view_categories.TabIndex = 4;
            this.btn_view_categories.Text = "&View, Edit, Delete Categories";
            this.btn_view_categories.UseVisualStyleBackColor = true;
            this.btn_view_categories.Click += new System.EventHandler(this.btn_view_categories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category Management";
            // 
            // btn_mian_menu
            // 
            this.btn_mian_menu.Location = new System.Drawing.Point(217, 219);
            this.btn_mian_menu.Name = "btn_mian_menu";
            this.btn_mian_menu.Size = new System.Drawing.Size(111, 30);
            this.btn_mian_menu.TabIndex = 7;
            this.btn_mian_menu.Text = "&Main Menu";
            this.btn_mian_menu.UseVisualStyleBackColor = true;
            this.btn_mian_menu.Click += new System.EventHandler(this.btn_mian_menu_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.btn_mian_menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_view_categories);
            this.Controls.Add(this.btn_AddNewCategory);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewCategory;
        private System.Windows.Forms.Button btn_view_categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mian_menu;
    }
}