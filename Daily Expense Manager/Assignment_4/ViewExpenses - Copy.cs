﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class ViewExpenses : Form
    {
        DEMDataContext _dc = new DEMDataContext();
        public ViewExpenses()
        {
            InitializeComponent();
        }

        private void ViewExpenses_Load(object sender, EventArgs e)
        {
            GetAllExpense(grdvw_expenses);
        }

        private void GetAllExpense(DataGridView grd)
        {
            var GetAllExpense = (from exp in _dc.Expenses
                                 join cat in _dc.Categories on exp.CategoryID equals cat.CategoryID
                                 select new
                                 {
                                     exp.ExpenseID,
                                     exp.Title,
                                     exp.Amount,
                                     cat.Name,
                                     exp.TransactionTimeStamp.Value.Date,
                                     exp.TransactionTimeStamp.Value.TimeOfDay
                                 }).ToList();

            grd.DataSource = GetAllExpense;
            grd.Columns[0].Visible = false;

            lbl_total_expense.Text = "Total Expense: " + (from texp in _dc.Expenses select texp.Amount).Sum().ToString();
        }

        private void txt_expense_name_search_TextChanged(object sender, EventArgs e)
        {
            grdvw_expenses.DataSource = (from exp in _dc.Expenses
                                         join cat in _dc.Categories on exp.CategoryID equals cat.CategoryID
                                         where exp.Title.Contains(txt_expense_name_search.Text)
                                         select new
                                         {
                                             exp.Title,
                                             exp.Amount,
                                             cat.Name,
                                             exp.TransactionTimeStamp.Value.Date,
                                             exp.TransactionTimeStamp.Value.TimeOfDay
                                         }).ToList();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            txt_expense_name_search.Text = string.Empty;
            GetAllExpense(grdvw_expenses);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                long grd_id = Convert.ToInt64(grdvw_expenses.SelectedRows[0].Cells[0].Value);
                EditExpense edit = new EditExpense(grd_id);
                edit.ShowDialog();
            }
            catch { }
        }

        private void butto_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdvw_expenses.SelectedRows.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Are You Sure to Delete The Selected Row(s)?", "Daily Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (r == DialogResult.Yes)
                    {
                        for (int i = 0; i < grdvw_expenses.SelectedRows.Count; i++)
                        {
                            long id = Convert.ToInt64(grdvw_expenses.SelectedRows[i].Cells[0].Value);

                            Expense ex = (from ex1 in _dc.Expenses
                                          where ex1.ExpenseID == id
                                          select ex1).Single();

                            _dc.Expenses.DeleteOnSubmit(ex);
                        }
                        _dc.SubmitChanges();
                        MessageBox.Show("Record(s) have been successfully been deleted.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Select records from the list to delete.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }
    }
}