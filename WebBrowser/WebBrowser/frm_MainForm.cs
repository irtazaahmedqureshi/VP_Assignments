using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_
{
    public partial class frm_MainForm : Form
    {
        WebBrowser wb;

        public frm_MainForm()
        {
            InitializeComponent();
        }

        private void frm_MainForm_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        public void NewTab()
        {
            Form1 frm_MDI = new Form1();
            frm_MDI.Text = "New Tab " + MdiChildren.Length;
            frm_MDI.MdiParent = this;
            frm_MDI.WindowState = FormWindowState.Maximized;
            frm_MDI.Show();
        }

        private void toolStrip_NewTab_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void tile_Horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tile_Vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tile_cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tile_arrange_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assignment # 2: Web Browser\nBuilt by: FA11-BCS-069", "About - WebBrowser", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}