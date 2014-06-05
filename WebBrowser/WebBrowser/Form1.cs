using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_
{
    public partial class Form1 : Form
    {
        //Bytes
        public static int totalBytesReceived = 0;
        public Form1()
        {
            InitializeComponent();
            pb_url_Load.Visible = false;
        }

        private void btn_GO_Click(object sender, EventArgs e)
        {
            if (txt_url.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid URL", "WebBrowser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalBytesReceived = 0;

                pb_url_Load.Visible = true;

                string url_check = txt_url.Text;

                if ((url_check.StartsWith("https://www.")) || (url_check.StartsWith("http://www.")))
                {
                    url_check = txt_url.Text;
                    Uri url = new Uri(url_check);
                    webrwsr.Navigate(url);
                    txt_url.Text = url.ToString();
                }
                if (!(url_check.StartsWith("http")))
                {
                    url_check = "http://www." + url_check;
                    webrwsr.Navigate(url_check);
                    txt_url.Text = url_check.ToString();
                }
                if (!(Regex.IsMatch(txt_url.Text, ".com", RegexOptions.IgnoreCase)))
                {
                    url_check = url_check + ".com";
                    webrwsr.Navigate(url_check);
                    txt_url.Text = url_check.ToString();
                }
            }
        }

        private void webrwsr_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            totalBytesReceived++;
            if (totalBytesReceived > 75)
            {
                totalBytesReceived = totalBytesReceived - 80;
            }
        }

        private void webrwsr_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            int Count = 100 - pb_url_Load.Value;
            pb_url_Load.Value += Count;

            pb_url_Load.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webrwsr.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            webrwsr.GoForward();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            webrwsr.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
            {
                MessageBox.Show("Enter Text to Search", "WebBrowser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pb_url_Load.Visible = true;

                string g = "https://encrypted.google.com/search?hl=en&q=";
                string b = "http://www.bing.com/search?q=";
                string ddgg = "https://duckduckgo.com/?q=";

                if (comboBox1.SelectedIndex == 0)
                {
                    string searchQuery = g + txt_search.Text.Replace(" ", "+");
                    Uri url = new Uri(searchQuery);
                    webrwsr.Url = url;
                    txt_url.Text = url.ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    string searchQuery = b + txt_search.Text.Replace(" ", "+");
                    Uri url = new Uri(searchQuery);
                    webrwsr.Url = url;
                    txt_url.Text = url.ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    string searchQuery = ddgg + txt_search.Text.Replace(" ", "+");
                    Uri url = new Uri(searchQuery);
                    txt_url.Text = url.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}