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
    public partial class EditCategory : Form
    {
        DEMDataContext _dc = new DEMDataContext();

        long idtoedit;
        public EditCategory(long id)
        {
            idtoedit = id;
            InitializeComponent();
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            if (textBox_newCatName.Text != string.Empty)
            {
                Category c = new Category();
                c = _dc.Categories.First(cc => cc.CategoryID == idtoedit);
                c.Name = textBox_newCatName.Text;
                _dc.SubmitChanges();
                
                MessageBox.Show("Successfully Edited the Category Name: "+textBox_old_catname.Text + " to: " + textBox_newCatName.Text, "Daily Expense Manager", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No Updates were made to the Category Name: " + textBox_old_catname.Text, "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
                
        private void EditCategory_Load(object sender, EventArgs e)
        {
            var q = (from cat in _dc.Categories
                     where cat.CategoryID == idtoedit
                     select cat).FirstOrDefault();

            textBox_old_catname.Text = q.Name;
        }
    }
}
