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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_expense_Click(object sender, EventArgs e)
        {
            NewExpense nef = new NewExpense();
            nef.ShowDialog();
        }

        private void btn_view_expense_Click(object sender, EventArgs e)
        {
            ExpenseManagement vef = new ExpenseManagement();
            vef.Show();
            this.Hide();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            CategoryManagement cmf = new CategoryManagement();
            cmf.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewExpense emang = new ViewExpense();
            emang.Show();
            this.Hide();
        }
    }
}
