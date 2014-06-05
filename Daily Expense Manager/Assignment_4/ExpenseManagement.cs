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
    public partial class ExpenseManagement : Form
    {
        public ExpenseManagement()
        {
            InitializeComponent();
        }

        private void btn_view_categories_Click(object sender, EventArgs e)
        {
            ViewExpense vef = new ViewExpense();
            vef.ShowDialog();
        }

        private void btn_AddNewCategory_Click(object sender, EventArgs e)
        {
            NewExpense anef = new NewExpense();
            anef.ShowDialog();
        }

        private void btn_mian_menu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
