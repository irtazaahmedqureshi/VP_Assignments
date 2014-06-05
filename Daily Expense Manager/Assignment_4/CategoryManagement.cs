using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            NewCategory ncf = new NewCategory();
            ncf.ShowDialog();
        }
        
        private void btn_view_categories_Click(object sender, EventArgs e)
        {
            ViewCategory vcf = new ViewCategory();
            vcf.ShowDialog();
        }

        private void btn_mian_menu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
