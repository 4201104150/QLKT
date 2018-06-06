using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel.Application;

namespace FinalProject
{
    public partial class formNQL_QLTro : Form
    {
        public formNQL_QLTro()
        {
            InitializeComponent();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();
        
        private void LoadData()
        {
            if(formNQL_DSPhongTro.idKhuTroNGQLorBoss=="ADMIN")
            {
                var resutl = db.NGUOITHUEs.OrderBy(p => p.IDNGUOITHUE).Select(p => new { p.IDNGUOITHUE, p.HOTEN, p.NGAYSINH, p.CMND, p.DIACHI, p.SDT, p.IDPHONG });
                dtgvDSNguoiThue.DataSource = resutl;
            }
            else
            {
                var resutl = db.NGUOITHUEs.OrderBy(p => p.IDNGUOITHUE).Where(p=>p.PHONGTRO.IDKHUTRO==formNQL_DSPhongTro.idKhuTroNGQLorBoss).Select(p => new { p.IDNGUOITHUE, p.HOTEN, p.NGAYSINH, p.CMND, p.DIACHI, p.SDT, p.IDPHONG });
                dtgvDSNguoiThue.DataSource = resutl;
            }
        }

        private void LoadDataToControl(int iRow)
        {
            string maNgThue = dtgvDSNguoiThue.Rows[iRow].Cells[0].Value.ToString();

            NGUOITHUE nt = db.NGUOITHUEs.Where(p => p.IDNGUOITHUE == maNgThue).FirstOrDefault();
            try
            {
                txtHoTen.Text = nt.HOTEN;
                txtCMND.Text = nt.CMND;
                txtDiaChi.Text = nt.DIACHI;
                txtIDNguoiThue.Text = nt.IDNGUOITHUE;
                txtSDT.Text = nt.SDT;
                txtIDPhong.Text = nt.IDPHONG;
                dtpNgaySinh.Value = DateTime.Parse(nt.NGAYSINH.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi :'(", "[Thông Báo]");
            }
        }

        private void XuatExcel(DataGridView dt, string Luu, string tenfile)
        {
            excel obj = new excel();//tao moi doi tuong;
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;
            for (int i = 1; i <= dt.Columns.Count; i++)
            {
                obj.Cells[1, i] = dt.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dt.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(Luu + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void formNQL_QLTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            btnLuu.Enabled = false;
            txtIDNguoiThue.Enabled = false;
            for (int i = 0; i < dtgvDSNguoiThue.Rows.Count; i++)
            {
                dtgvDSNguoiThue.RowsDefaultCellStyle.BackColor = Color.BurlyWood;
                dtgvDSNguoiThue.AlternatingRowsDefaultCellStyle.BackColor = Color.Gold;
            }
            LoadData();
        }

        private void dtgvDSNguoiThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if(id>=0)
            LoadDataToControl(id);
        }

        int flag = -1;//-1: null 0:Thêm 1:Sửa

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            flag = 0;
            txtIDNguoiThue.Enabled = true;
            txtIDNguoiThue.Text = "";

            //txtIDPhong.Text = "";
            //txtCMND.Text = "";
            //txtDiaChi.Text = "";
            //txtHoTen.Text = "";
            //txtSDT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = -1;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;

            NGUOITHUE nt = db.NGUOITHUEs.SingleOrDefault(p => p.IDNGUOITHUE == txtIDNguoiThue.Text);
            //DialogResult result = new DialogResult();
            if (nt!=null)
            {
                if(MessageBox.Show("Bạn có muốn xóa ???", "[Thông báo]",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    db.NGUOITHUEs.DeleteOnSubmit(nt);
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Xóa Thành Công :D");
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
            txtIDNguoiThue.Enabled = false;

            //sửa dữ liệu

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            if (flag == 0)//thêm
            {
                //try
                {
                    NGUOITHUE nt = new NGUOITHUE();
                    nt.HOTEN = txtHoTen.Text;
                    nt.NGAYSINH = dtpNgaySinh.Value;
                    nt.DIACHI = txtDiaChi.Text;
                    try
                    {
                        nt.IDNGUOITHUE = txtIDNguoiThue.Text;
                        nt.CMND = txtCMND.Text;
                        
                        nt.SDT = txtSDT.Text;
                        nt.IDPHONG = txtIDPhong.Text;

                        db.NGUOITHUEs.InsertOnSubmit(nt);
                        db.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Thêm Thành Công !!!", "[Thông Báo]");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi Rồi :(", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (flag ==1)//sửa
            {                
                NGUOITHUE nt = db.NGUOITHUEs.Where(p => p.IDNGUOITHUE == txtIDNguoiThue.Text).FirstOrDefault();
                //try
                {
                    if (nt != null)//nếu có
                    {
                        nt.SDT = txtSDT.Text;
                        nt.DIACHI = txtDiaChi.Text;
                        nt.CMND = txtCMND.Text;
                        nt.NGAYSINH = dtpNgaySinh.Value;
                        nt.HOTEN = txtHoTen.Text;
                        try
                        {
                            nt.IDPHONG = txtIDPhong.Text;                            
                            //cập nhật lại
                            db.SubmitChanges();
                            LoadData();
                            MessageBox.Show("Sửa thành công !!!", "[Thông báo]");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lỗi Rồi :(", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
            flag = -1;
            txtIDNguoiThue.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int h = 0;
        private void btnIn_Click(object sender, EventArgs e)
        {
            h += 1;
            XuatExcel(dtgvDSNguoiThue, @"C:\Users\Escanor\source\repos\FinalProject\XuatBaoCaoExcel\", "DSNguoiThue" + h.ToString());
            MessageBox.Show("In thành công!!!");
        }
    }
}
