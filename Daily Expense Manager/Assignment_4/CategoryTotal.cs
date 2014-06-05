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
    public partial class CategoryTotal : Form
    {
        public CategoryTotal()
        {
            InitializeComponent();
        }

        DEMDataContext _dc = new DEMDataContext();
        private void CategoryTotal_Load(object sender, EventArgs e)
        {
            var q_calculate_total_expense = (from exp in _dc.Expenses
                                             group exp.Amount by exp.CategoryID into grpCat
                                             select new
                                             {
                                                 Category = (from cat in _dc.Categories
                                                             where cat.CategoryID == grpCat.Key
                                                             select cat.Name).FirstOrDefault(),
                                                 Total = grpCat.Sum()
                                             }).ToList();

            grd_total_expense_catgories.DataSource = q_calculate_total_expense;
        }
    }
}