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
    public partial class formMainNQL : Form
    {
        public formMainNQL()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        
        private void đăngThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhSáchNQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNQL_QLTro fm = new formNQL_QLTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formNQL_QLTro fm = new formNQL_QLTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void danhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNQL_DSPhongTro fm = new formNQL_DSPhongTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void mậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdatePassword fm = new formUpdatePassword();
            fm.ShowDialog();
        }

        private void formMainNQL_Load(object sender, EventArgs e)
        {

        }
    }
}
