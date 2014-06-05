using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor___FA11_BCS_069
{
    public partial class Form1 : Form
    {
        bool customDimensions, selectImageFormat = false, selectDimensions = false;
        public Form1()
        {
            InitializeComponent();
            customDimensions = false;
            checkBox_Check();
            lbl_h_px.Enabled = lbl_w_px.Enabled = lbl_Width.Enabled = label_Height.Enabled = txt_Height.Enabled = txt_Width.Enabled = false;
        }

        private void ddl_DimensionsImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            customDimensions = false;
            lbl_h_px.Enabled = lbl_w_px.Enabled = lbl_Width.Enabled = label_Height.Enabled = txt_Height.Enabled = txt_Width.Enabled = false;

            if (ddl_DimensionsImage.SelectedIndex == 0)
            {
                txt_Width.Text = "640";
               txt_Height.Text = "480";
            }
            else if (ddl_DimensionsImage.SelectedIndex == 1)
            {
                txt_Width.Text = "800";
                txt_Height.Text = "600";
            }
            else if (ddl_DimensionsImage.SelectedIndex == 2)
            {
                txt_Width.Text = "1024";
                txt_Height.Text = "768";
            }
            else if (ddl_DimensionsImage.SelectedIndex == 3)
            {
                txt_Width.Text = "1280";
                txt_Height.Text = "960";
            }
            if (ddl_DimensionsImage.SelectedIndex == 4)
            {
                //Custom Dimensions
                customDimensions = true;
                lbl_h_px.Enabled = lbl_w_px.Enabled = lbl_Width.Enabled = label_Height.Enabled = txt_Height.Enabled = txt_Width.Enabled = true;
            }
        }

        private void btn_ImageSelection_Click(object sender, EventArgs e)
        {
            ofd_Image.ShowDialog();
            txt_GetImagePath.Text = ofd_Image.FileName;
        }

        private void ofd_Image_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string fileName_ in ofd_Image.FileNames)
            {
                addFile(new FileInfo(fileName_));
            }
        }

        private void addFile(FileInfo fileInfo_)
        {
            if (listView1.Items.Find(fileInfo_.FullName, false).Length != 0) return;
            Image image_ = Image.FromFile(fileInfo_.FullName);
            imageList1.Images.Add(fileInfo_.FullName, image_);
            listView1.Items.Add(fileInfo_.FullName, fileInfo_.Name, fileInfo_.FullName);
        }

        int width, height;
        private void btn_startConversion_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count <= 0)
                {
                    MessageBox.Show("Upload Image before Processing.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool allOK = true;

                    if ((txt_Height.Text == "") || (txt_Width.Text == ""))
                    {
                        MessageBox.Show("Select Dimensions for the Image.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allOK = false;
                    }


                    if ((ddl_ImageFormats.Text == ".JPEG") || (ddl_ImageFormats.Text == ".PNG")
                        || (ddl_ImageFormats.Text == ".GIF") || (ddl_ImageFormats.Text == ".BMP")
                    || (ddl_ImageFormats.Text == ".TIFF"))
                    {
                        #region FileFormat foreachLoops
                        if (allOK == true)
                        {
                            width = int.Parse(txt_Width.Text);
                            height = int.Parse(txt_Height.Text);
                            bool converted = false;

                            if (ddl_ImageFormats.SelectedIndex == 0)
                            {
                                foreach (ListViewItem lst in listView1.Items)
                                {
                                    FileInfo f = new FileInfo(lst.Name);
                                    Image img = Image.FromFile(lst.Name);
                                    Bitmap bitmap = new Bitmap(img, width, height);
                                    bitmap.Save(f.FullName + "-Resize(" + width + "," + height + ").jpeg", ImageFormat.Jpeg);
                                    converted = true;
                                }
                            }
                            if (ddl_ImageFormats.SelectedIndex == 1)
                            {
                                foreach (ListViewItem lst in listView1.Items)
                                {
                                    FileInfo f = new FileInfo(lst.Name);
                                    Image img = Image.FromFile(lst.Name);
                                    Bitmap bitmap = new Bitmap(img, width, height);
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").png", ImageFormat.Png);
                                    converted = true;
                                }
                            }
                            if (ddl_ImageFormats.SelectedIndex == 2)
                            {
                                foreach (ListViewItem lst in listView1.Items)
                                {
                                    FileInfo f = new FileInfo(lst.Name);
                                    Image img = Image.FromFile(lst.Name);
                                    Bitmap bitmap = new Bitmap(img, width, height);
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").gif", ImageFormat.Gif);
                                    converted = true;
                                }
                            }
                            if (ddl_ImageFormats.SelectedIndex == 3)
                            {
                                foreach (ListViewItem lst in listView1.Items)
                                {
                                    FileInfo f = new FileInfo(lst.Name);
                                    Image img = Image.FromFile(lst.Name);
                                    Bitmap bitmap = new Bitmap(img, width, height);
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").bmp", ImageFormat.Bmp);
                                    converted = true;
                                }
                            }
                            if (ddl_ImageFormats.SelectedIndex == 4)
                            {
                                foreach (ListViewItem lst in listView1.Items)
                                {
                                    FileInfo f = new FileInfo(lst.Name);
                                    Image img = Image.FromFile(lst.Name);
                                    Bitmap bitmap = new Bitmap(img, width, height);
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").tiff", ImageFormat.Tiff);
                                    converted = true;
                                }
                            }
                        #endregion
                            if (converted == true)
                            {
                                MessageBox.Show("Image has been successfully converted!", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Image Format", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allOK = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the settings in Step 2.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckAllFields()
        {
            if ((txt_GetImagePath.Text == "") || (txt_Height.Text == "") || (txt_Width.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void checkBox_Resize_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Check();
        }

        private void checkBox_Check()
        {
            if (checkBox_Resize.Checked == true)
            {
                panel_Size.Enabled = true;
            }
            else
            {
                panel_Size.Enabled = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lst in listView1.SelectedItems)
            {
                FileInfo f = new FileInfo(lst.Name);
                Image img = Image.FromFile(lst.Name);
                txt_Height.Text = img.Height.ToString();
                txt_Width.Text = img.Width.ToString();
            }
        }
    }
}