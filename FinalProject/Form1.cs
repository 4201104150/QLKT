using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void dSNgườiQuảnLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSNguoiQuanLy fm = new formDSNguoiQuanLy();
            fm.MdiParent = this;
            //fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void phòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromDSNTro fm = new fromDSNTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDangNhap fm = new formDangNhap();
            fm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void khuTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKhuTro fm = new formKhuTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStar fm = new formStar();
            fm.MdiParent = this;
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
