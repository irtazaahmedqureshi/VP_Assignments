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
    public partial class NewExpense : Form
    {
        DEMDataContext _dc = new DEMDataContext();
        public NewExpense()
        {
            InitializeComponent();
        }

        private void AddNewExpense_Load(object sender, EventArgs e)
        {
            var GetAllCategories = (from a in _dc.Categories
                                    select a).ToList();

            cmb_expense_category.DataSource = GetAllCategories;
            cmb_expense_category.DisplayMember = "Name";
            cmb_expense_category.ValueMember = "CategoryID";
        }

        private void btn_NewExpense_Click(object sender, EventArgs e)
        {
            try
            {
                Expense exp = new Expense();

                exp.Title = textbox_Expense_Name.Text;
                exp.TransactionTimeStamp = Convert.ToDateTime(dateTime_Expense.Value);
                exp.Amount = Convert.ToDouble(textbox_amount_expense.Text);
                exp.CategoryID = Convert.ToInt64(cmb_expense_category.SelectedValue);

                _dc.Expenses.InsertOnSubmit(exp);
                _dc.SubmitChanges();

                MessageBox.Show("Successfully Expense was added in the database.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
