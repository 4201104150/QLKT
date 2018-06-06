using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void button1_Click(object sender, EventArgs e)
        {

            formUpdatePassword.taikhoan = txtTaiKhoan.Text;
            formUpdatePassword.matkhau = txtMatKhau.Text;
            string tk = db.CHUQUANLies.Select(p => p.IDCHUQUANLY).FirstOrDefault().ToString();
            string mk = db.CHUQUANLies.Select(p => p.PASSBOSS).FirstOrDefault().ToString();
            if (rdbNQL.Checked == true)
            {
                for (int i = 0; i < db.NGUOIQUANLies.ToList().Count; i++)
                {
                    string tknql = db.NGUOIQUANLies.Select(p => p.IDNGUOIQUANLY).ToList()[i].ToString().Trim();
                    string s = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == txtTaiKhoan.Text).Select(p => p.IDKHUTRO).FirstOrDefault();
                    string mknql = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == txtTaiKhoan.Text).Select(p => p.PASSNGQL).FirstOrDefault();
                    string ten = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == txtTaiKhoan.Text).Select(p => p.HOTEN).FirstOrDefault();
                    if (tknql == txtTaiKhoan.Text &&  mknql== txtMatKhau.Text)
                    {
                        formNQL_DSPhongTro.idKhuTroNGQLorBoss = s;
                        this.Close();
                        formMainNQL fm = new formMainNQL();
                        fm.Show();
                        MessageBox.Show("Chào bạn " + ten);
                    }
                }
                formUpdatePassword.flag = false;

            }
            if (rdbBoss.Checked == true)
            {                
                if (txtTaiKhoan.Text == tk && txtMatKhau.Text == mk)
                {                    
                    this.Close();
                    TheBoss fm = new TheBoss();
                    fm.Show();
                    MessageBox.Show("Chào Cậu Chủ", "[Thông Báo]");
                    formUpdatePassword.flag = true;
                    //DangKyTaiKhoan.flagDangKy = true;
                    formNQL_DSPhongTro.idKhuTroNGQLorBoss = "ADMIN";
                }
                else
                {
                    MessageBox.Show("Bạn là ai mình không biết bạn đi ra đi");
                }
            }
 //           MessageBox.Show(formNQL_DSPhongTro.idKhuTroNGQLorBoss);
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
