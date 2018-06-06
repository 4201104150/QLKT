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
    public partial class DangKyTaiKhoan : Form
    {
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }
        public static bool flagtk=false;
        public static bool flagDangKy=false;
//        public static bool check = false;
        DataQLNKTDataContext db = new DataQLNKTDataContext();
        private void DangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cbbKhuTro.DataSource = db.KHUTROs;
            cbbKhuTro.DisplayMember = "TENKHUTRO";
            cbbKhuTro.ValueMember = "IDKHUTRO";
            cbbKhuTro.SelectedIndex = 0;

            //if(flagDangKy==true&&check==true)
            //{
            //    label8.Hide();
            //    cbbKhuTro.Hide();
            //}
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (flagDangKy == false)//&&check==false)
            {
                //try
                {
                    NGUOIQUANLY nql = new NGUOIQUANLY
                    {
                        HOTEN = txtHoTen.Text,
                        DIACHI = txtDiaChi.Text,
                        IDNGUOIQUANLY = txtID.Text,
                        SDT = txtSDT.Text,
                        PASSNGQL = txtPass.Text,
                        CMND = txtCMND.Text,
                        NGAYSINH = dtNgaySinh.Value,
                        IDKHUTRO = cbbKhuTro.SelectedValue.ToString()
                    };
                    if (txtID.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtPass.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
                    {
                        MessageBox.Show("Thiếu dữ liệu");
                    }
                    else
                    {
                        db.NGUOIQUANLies.InsertOnSubmit(nql);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm Thành công!!!");
                        flagtk = true;
                    }
                }
                //catch (Exception)
                //{
                //    MessageBox.Show("Lỗi!!! Thêm không Thành Công");
                //}
            }
            //else if (flagDangKy == true && check == true)
            //{                
            //    //try
            //    {
            //        CHUQUANLY cql = new CHUQUANLY
            //        {
            //            HOTEN = txtHoTen.Text,
            //            IDCHUQUANLY = txtID.Text,
            //            DIACHI = txtDiaChi.Text,
            //            PASSBOSS = txtPass.Text,
            //            NGAYSINH = dtNgaySinh.Value,
            //            CMND = txtCMND.Text,
            //            SDT = txtSDT.Text
            //        };
            //        if(txtID.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || txtPass.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
            //        {
            //            MessageBox.Show("Thiếu Thông Tin Đăng Nhập!!!");
            //        }
            //        else
            //        {
            //            db.CHUQUANLies.InsertOnSubmit(cql);
            //            db.SubmitChanges();
            //            MessageBox.Show("Thêm Thành Công!!!");
            //        }
            //    }
            //    //catch(Exception)
            //    //{
            //    //    MessageBox.Show("Lỗi!!!");
            //    //}
            //}
        }
        private void DangKyTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}


