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
    public partial class EditExpense : Form
    {
        DEMDataContext _dc = new DEMDataContext();
        long _id;

        public EditExpense(long id)
        {
            _id = id;
            InitializeComponent();
        }

        private void EditExpense_Load(object sender, EventArgs e)
        {
            var GetAllCategories = (from a in _dc.Categories
                                    select a).ToList();

            cmb_expense_category.DataSource = GetAllCategories;
            cmb_expense_category.DisplayMember = "Name";
            cmb_expense_category.ValueMember = "CategoryID";

            var q = (from ex in _dc.Expenses
                     join cat in _dc.Categories on ex.CategoryID equals cat.CategoryID
                     where ex.ExpenseID == _id
                     select new
                     {
                         ex.Amount,
                         ex.Title,
                         ex.TransactionTimeStamp,
                         cat.Name,
                         cat.CategoryID
                     }).FirstOrDefault();

            textbox_amount_expense.Text = q.Amount.ToString();
            textbox_Expense_Name.Text = q.Title;
            cmb_expense_category.Text = q.Name;
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Expense ex = new Expense();
                ex = _dc.Expenses.First(exp => exp.ExpenseID == _id);

                ex.Amount = double.Parse(textbox_amount_expense.Text);
                ex.Title = textbox_Expense_Name.Text;
                ex.CategoryID = long.Parse(cmb_expense_category.SelectedValue.ToString());

                _dc.SubmitChanges();

                MessageBox.Show("Successfully Edited!", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch
            { }
        }
    }
}