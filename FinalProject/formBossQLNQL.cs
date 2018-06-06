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
using excel = Microsoft.Office.Interop.Excel.Application;

namespace FinalProject
{
    public partial class formBossQLNQL : Form
    {
        public formBossQLNQL()
        {
            InitializeComponent();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        void LoadData()
        {
            var resutl = db.NGUOIQUANLies.OrderBy(p => p.IDNGUOIQUANLY).Select(p => new
            {
                p.IDNGUOIQUANLY,
                p.HOTEN,
                p.NGAYSINH,
                p.CMND,
                p.DIACHI,
                p.SDT,
                p.KHUTRO.TENKHUTRO
            });
            dtgvDSNQL.DataSource = resutl;
        }

        private void LoadDataToControl(int iRow)
        {
            string maNQL = dtgvDSNQL.Rows[iRow].Cells[0].Value.ToString();
            MD5 mh = MD5.Create();

            NGUOIQUANLY nql = db.NGUOIQUANLies.OrderBy(p=>p.IDNGUOIQUANLY).Where(p => p.IDNGUOIQUANLY == maNQL).FirstOrDefault();
            try
            {

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(nql.PASSNGQL);
                //mã hóa chuỗi đã chuyển
                byte[] hash = mh.ComputeHash(inputBytes);
                //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                txtHoTen.Text = nql.HOTEN;
                txtDiaChi.Text = nql.DIACHI;
                txtCMND.Text = nql.CMND;
                txtSDT.Text = nql.SDT;
                txtIDNQL.Text = nql.IDNGUOIQUANLY;
                txtPass.Text = sb.ToString();
                dtpNgaySinh.Value = nql.NGAYSINH;
                cbbTenKhuTro.Text = nql.KHUTRO.TENKHUTRO;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi !!!", "[Thông Báo]");
            }
        }

        private void XuatExcel(DataGridView dt,string Luu,string tenfile)
        {
            excel obj = new excel();//tao moi doi tuong;
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;
            for(int i=1;i<=dt.Columns.Count;i++)
            {
                obj.Cells[1, i] = dt.Columns[i - 1].HeaderText;
            }
            for(int i=0;i<dt.Rows.Count;i++)
            {
                for(int j=0;j<dt.Columns.Count;j++)
                {
                    if(dt.Rows[i].Cells[j].Value!=null)
                    {
                        obj.Cells[i + 2, j + 1] = dt.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(Luu + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void formBossQLNQL_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            cbbTenKhuTro.DataSource = db.KHUTROs.OrderBy(p=>p.IDKHUTRO);
            cbbTenKhuTro.DisplayMember = "TENKHUTRO";
            cbbTenKhuTro.ValueMember = "IDKHUTRO";
            cbbTenKhuTro.SelectedIndex = 0;
            txtIDNQL.Enabled = false;
            btnLuu.Enabled = false;
            LoadData();
        }

        private void dtgvDSNQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            if(irow>=0)
            {
                LoadDataToControl(irow);
            }
        }

        /// <summary>
        /// sử lý sự kiện của các nút 
        /// </summary>
        int flag = -1;//-1: null 0:Thêm 1:Sửa

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan fm = new DangKyTaiKhoan();
            fm.ShowDialog();
            if(DangKyTaiKhoan.flagtk==true)
            {
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NGUOIQUANLY tt = db.NGUOIQUANLies.SingleOrDefault(p => p.IDNGUOIQUANLY == txtIDNQL.Text);
            if(tt!=null)
            {
                if(MessageBox.Show("Bạn Có Chắc Chắn Xóa", "[Thông Báo]", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    db.NGUOIQUANLies.DeleteOnSubmit(tt);
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Xóa Thành Công", "[Thông Báo]");
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;

            flag = 1;
            txtIDNQL.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            if (flag == 1)
            {
                NGUOIQUANLY ngql = db.NGUOIQUANLies.Where(p => p.IDNGUOIQUANLY == txtIDNQL.Text).FirstOrDefault();
                try
                {
                    if (ngql != null)
                    {
                        ngql.HOTEN = txtHoTen.Text;
                        ngql.IDKHUTRO = cbbTenKhuTro.SelectedValue.ToString();
                        ngql.SDT = txtSDT.Text;
                        ngql.CMND = txtCMND.Text;
                        ngql.NGAYSINH = dtpNgaySinh.Value;
                        ngql.DIACHI = txtDiaChi.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa đổi hoàn tất !!!");
                        LoadData();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Lỗi Rồi!!!", "[Thông Báo]");
                }
            }

            flag = -1;
            txtIDNQL.Enabled = false;
        }
        int h = 0;
        private void btnIn_Click(object sender, EventArgs e)
        {
            h += 1;
            XuatExcel(dtgvDSNQL,@"C:\Users\Escanor\source\repos\FinalProject\XuatBaoCaoExcel\", "DSNQL" + h.ToString());
            MessageBox.Show("In thành công!!!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
