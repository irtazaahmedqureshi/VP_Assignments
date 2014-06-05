using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            lbl_ImagesCounter.Text = "0 of " + listView1.Items.Count + " Converted.";
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
                if (btn_startConversion.Text == "Stop Conversion")
                {
                    btn_startConversion.Text = "Start Conversion";
                    backgroundWorker1.CancelAsync();
                    return;
                }

                lbl_ImagesCounter.Text = "0 of " + listView1.Items.Count + " Converted.";
                btn_startConversion.Text = "Stop Conversion";
                groupBox1.Enabled = groupBox2.Enabled = false;
                Thread.Sleep(1);
                List<string> items = new List<string>();
                foreach (ListViewItem item in listView1.Items)
                {
                    items.Add(item.Name);
                    totalSelectedImagesConversion = listView1.Items.Count;
                }
                backgroundWorker1.RunWorkerAsync(items);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find any Background Worker Running.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            foreach (ListViewItem lst in listView1.Items)
            {
                FileInfo f = new FileInfo(lst.Name);
                Image img = Image.FromFile(lst.Name);
                txt_Height.Text = img.Height.ToString();
                txt_Width.Text = img.Width.ToString();
            }
        }

        //Counting Complete Image File(s)
        int counterFilesCompleted = 1;
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_ImageProcessor.Increment(e.ProgressPercentage);
            lbl_ImagesCounter.Text = ((counterFilesCompleted++) + " of " + listView1.Items.Count + " Converted.");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_startConversion.Text = "Start Conversion";
            groupBox1.Enabled = groupBox2.Enabled = true;
            progressBar_ImageProcessor.Value = 0;

            if (e.Cancelled)
            {
                int t = counterFilesCompleted - 1;
                MessageBox.Show("Operation has been Cancelled! " + t.ToString() + " of " + listView1.Items.Count.ToString() + " were completed.", "ImageProcessor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (Task_IsNotCompleted == true)
            {
                MessageBox.Show(listView1.Items.Count.ToString() + " images computed successfully.", "ImageProcessor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                counterFilesCompleted = 1;
                lbl_ImagesCounter.Text = "0 of " + listView1.Items.Count + " Converted.";
            }
            else
            {
                MessageBox.Show("Converion failed. Please Check Your Settings.", "ImageProcessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Global Variables Used for Invoking Purposes and Other
        string imageFormats, imageFormatsIndex;
        int totalSelectedImagesConversion, counterTotal;
        bool Task_IsNotCompleted = false;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // Invoke Delegate for Getting ImageFormats and ImageFormats' Index.
                this.Invoke((MethodInvoker)delegate()
                {
                    imageFormats = ddl_ImageFormats.Text;
                    imageFormatsIndex = ddl_ImageFormats.SelectedIndex.ToString();
                    counterTotal = totalSelectedImagesConversion;
                });

                if (listView1.Items.Count <= 0)
                {
                    MessageBox.Show("Upload Image before Processing.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool allOK = true;

                    if ((txt_Height.Text == "") || (txt_Width.Text == ""))
                    {
                        MessageBox.Show("Select Dimensions from enabling Resize checkbox. Or Select Any Image to select the size.", "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allOK = false;
                    }

                    if (((imageFormats == ".JPEG") || (imageFormats == ".PNG") || (imageFormats == ".GIF") || (imageFormats == ".BMP") || (imageFormats == ".TIFF")))
                    {
                        #region FileFormat foreachLoops

                        if (allOK == true)
                        {
                            width = int.Parse(txt_Width.Text);
                            height = int.Parse(txt_Height.Text);
                            int counter = 1;

                            foreach (string lst in (List<string>)e.Argument)
                            {
                                if (backgroundWorker1.CancellationPending)
                                {
                                    e.Cancel = true;
                                    return;
                                }

                                FileInfo f = new FileInfo(lst);
                                Image img = Image.FromFile(lst);
                                Bitmap bitmap = new Bitmap(img, width, height);

                                if (imageFormatsIndex == "0")
                                {
                                    bitmap.Save(f.FullName + "-Resize(" + width + "," + height + ").jpeg", ImageFormat.Jpeg);
                                }
                                else if (imageFormatsIndex == "1")
                                {
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").png", ImageFormat.Png);
                                }
                                else if (imageFormatsIndex == "2")
                                {
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").gif", ImageFormat.Gif);
                                }
                                else if (imageFormatsIndex == "3")
                                {
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").bmp", ImageFormat.Bmp);
                                }
                                else if (imageFormatsIndex == "4")
                                {
                                    bitmap.Save(f.FullName + "-Resize(" + width + "x" + height + ").tiff", ImageFormat.Tiff);
                                }
                                counter++;
                                backgroundWorker1.ReportProgress(100 / counterTotal);
                                Thread.Sleep(150);
                            }
                            if (counterTotal != counter-1)
                            {
                                Task_IsNotCompleted = false;
                            }
                            else
                            {
                                Task_IsNotCompleted = true;
                            }
                        }
                        #endregion
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
                MessageBox.Show(ex.Message, "ImageProsessor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clears The ListItem
        private void btn_ClearList_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to ClearList?", "ImageProcessor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                listView1.Items.Clear();
                checkBox_Resize.Checked = false;
                lbl_ImagesCounter.Text = "0 of 0 Converted.";
            }
        }
    }
}