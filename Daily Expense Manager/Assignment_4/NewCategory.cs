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
    public partial class NewCategory : Form
    {
        DEMDataContext _dc = new DEMDataContext();
        public NewCategory()
        {
            InitializeComponent();
        }

        private void btn_NewCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_category_name.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Category Name to add a new category.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Query is used to identify if the same name of category already exists or not.
                    var q_check = (from chk in _dc.Categories
                                   where chk.Name == txt_category_name.Text
                                   select chk).FirstOrDefault();

                    //If Query returns NULL then it means it doesn't contain anysuch category name.
                    if (q_check == null)
                    {
                        Category cat = new Category();
                        cat.Name = txt_category_name.Text;
                        _dc.Categories.InsertOnSubmit(cat);
                        _dc.SubmitChanges();

                        //After Submission Clears the field
                        txt_category_name.Text = string.Empty;
                        MessageBox.Show("Successfully Category Name added in the database.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Category Name already exist in the database.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("System was unable to add your category to the database. Please try again later.", "Daily Expense Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
