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
    public partial class ViewExpense : Form
    {
        public ViewExpense()
        {
            InitializeComponent();
        }
        DEMDataContext _dc = new DEMDataContext();
        private void ViewExpense_Load(object sender, EventArgs e)
        {
            GetAllExpenses();
            GetAllCateogries();
        }

        private void GetAllCateogries()
        {
            var q_get_category = from cat in _dc.Categories
                                      select cat;

            grdvw_categories.DataSource = q_get_category;
            grdvw_categories.Columns[0].Visible = false;
        }

        private void GetAllExpenses()
        {
            var q_get_expense = (from exp in _dc.Expenses
                                 join cat in _dc.Categories on exp.CategoryID equals cat.CategoryID
                                 select new
                                 {
                                     exp.ExpenseID,
                                     exp.Title,
                                     cat.Name,
                                     exp.TransactionTimeStamp.Value.Date,
                                     exp.TransactionTimeStamp.Value.TimeOfDay
                                 });

            grdvw_expenses.DataSource = q_get_expense;
            grdvw_expenses.Columns[0].Visible = false;
        }

        private void grdvw_categories_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                List<long> _collectionCateogiresID = new List<long>();
                for (int i = 0; i < grdvw_categories.SelectedRows.Count; i++)
                {
                    _collectionCateogiresID.Add(Convert.ToInt64(grdvw_categories.SelectedRows[i].Cells[0].Value));
                }

                var q = (from exp in _dc.Expenses
                         join cat in _dc.Categories on exp.CategoryID equals cat.CategoryID
                         where _collectionCateogiresID.Contains((long)exp.CategoryID)
                         select new
                         {
                             exp.ExpenseID,
                             cat.Name,
                             exp.Title,
                             exp.TransactionTimeStamp.Value.Date,
                             exp.TransactionTimeStamp.Value.TimeOfDay
                         });

                if (q != null)
                    grdvw_expenses.DataSource = q;
                else
                    MessageBox.Show("No Record Were Found!", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdvw_expenses.Columns[0].Visible = false;
            }
            catch { }
        }

        private void btn_total_sum_category_expense_Click(object sender, EventArgs e)
        {
            CategoryTotal cfv = new CategoryTotal();
            cfv.ShowDialog();
        }
    }
}
