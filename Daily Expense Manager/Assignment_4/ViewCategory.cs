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
    public partial class ViewCategory : Form
    {
        DEMDataContext _dc = new DEMDataContext();
        public ViewCategory()
        {
            InitializeComponent();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            CategoryBind();
        }

        internal void CategoryBind()
        {
            var q = (from cat in _dc.Categories
                     select new
                     {
                         cat.CategoryID,
                         cat.Name
                     }).ToList();

            grdview_Categories.DataSource = q;
            grdview_Categories.Columns[0].Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                long grd_id = Convert.ToInt64(grdview_Categories.SelectedRows[0].Cells[0].Value);
                EditCategory edit = new EditCategory(grd_id);
                edit.ShowDialog();
            }
            catch { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdview_Categories.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Are You Sure to Delete The Selected Row(s)?", "Daily Expense Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < grdview_Categories.SelectedRows.Count; i++)
                        {
                            long id = Convert.ToInt64(grdview_Categories.SelectedRows[i].Cells[0].Value);

                            Category cat_query = (from c in _dc.Categories
                                                  where c.CategoryID == id
                                                  select c).FirstOrDefault();

                            _dc.Categories.DeleteOnSubmit(cat_query);
                        }
                        _dc.SubmitChanges();
                        MessageBox.Show("Record(s) have been successfully been deleted.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CategoryBind();
                    }
                }
                else
                {
                    MessageBox.Show("Select records from the list to delete.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Your selected record has entries in Expense. Delete the expense record to delete this category.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}