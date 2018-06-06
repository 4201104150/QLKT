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
    public partial class TheBoss : Form
    {
        public TheBoss()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void ngườiThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNQL_QLTro fm = new formNQL_QLTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
            MessageBox.Show("Bạn Đã Đăng Xuất", "[Thông Báo]");
        }

        private void khuTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBossKhuTro fm = new formBossKhuTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void ngườiQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBossQLNQL fm = new formBossQLNQL();
            fm.MdiParent = this;
            fm.Show();
        }

        private void phòngTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBossDanhSachPhongTro fm = new formBossDanhSachPhongTro();
            fm.MdiParent = this;
            fm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formUpdatePassword fm = new formUpdatePassword();
            fm.ShowDialog();
        }

        private void TheBoss_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
