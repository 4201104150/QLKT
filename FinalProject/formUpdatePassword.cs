using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FinalProject
{
    public partial class formUpdatePassword : Form
    {
        public formUpdatePassword()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public static string taikhoan="", matkhau="";

        public static bool flag;

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string s = "";
            List<int> list = new List<int>();
            for(int i=0;i<=9;i++)
            {
                list.Add(i);
            }
            //random
            for(int i=0;i<=4;i++)
            {
                int tmp = random.Next(list.Count);
                s += list[tmp];
            }


            if (flag == true)
            {
                CHUQUANLY chumk = db.CHUQUANLies.Where(p => p.IDCHUQUANLY == taikhoan).FirstOrDefault();

                if (chumk != null)
                {
                    chumk.PASSBOSS = s;
                }
                db.SubmitChanges();
                MessageBox.Show("Mật khẩu mới của bạn là : "+s);
            }
            else
            {                
                NGUOIQUANLY nql = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == taikhoan).FirstOrDefault();
                if (nql != null)
                {
                    nql.PASSNGQL = s;
                }
                db.SubmitChanges();
                MessageBox.Show("Mật khẩu mới của bạn là : " + s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (txtMKM2.Text!=txtMM1.Text)
            {
                MessageBox.Show("Mật Khẩu Mới Không Khớp!!!");
            }
            else
            {
                if (txtMKC.Text!=matkhau)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng !!!");
                }
                else
                {
                    if (flag==true)
                    {
                        CHUQUANLY chumk = db.CHUQUANLies.Where(p => p.IDCHUQUANLY == taikhoan).FirstOrDefault();

                        if (chumk != null)
                        {
                            //MD5 mh = MD5.Create();
                            ////Chuyển kiểu chuổi thành kiểu byte
                            //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtMKM2.Text);
                            ////mã hóa chuỗi đã chuyển
                            //byte[] hash = mh.ComputeHash(inputBytes);
                            ////tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
                            //StringBuilder sb = new StringBuilder();
                            //for (int i = 0; i < hash.Length; i++)
                            //{
                            //    sb.Append(hash[i].ToString("X2"));
                            //}

                            chumk.PASSBOSS = txtMKM2.Text;
                        }
                        db.SubmitChanges();
                        MessageBox.Show("Update!!!");
                        this.Close();
                    }
                    else
                    {
                        //for (int i = 0; i < db.NGUOIQUANLies.ToList().Count; i++)
                        //{
                        //    string tknql = db.NGUOIQUANLies.Select(p => p.IDNGUOIQUANLY).ToList()[i].ToString().Trim();
                        //    string mknql = db.NGUOIQUANLies.Select(p => p.PASSNGQL).ToList()[i].ToString().Trim();
                        NGUOIQUANLY nql = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == taikhoan).FirstOrDefault();
                        if (nql!=null)
                        {
                            nql.PASSNGQL = txtMKM2.Text;
                        }
                        db.SubmitChanges();
                        MessageBox.Show("Update!!!");
                        //}
                        this.Close();
                    }
                }
            }
        }
    }
}
