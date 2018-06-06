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
    public partial class formBossDanhSachPhongTro : Form
    {
        public formBossDanhSachPhongTro()
        {
            InitializeComponent();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

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

        private void LoadData()
        {
            var resutl = db.PHONGTROs.OrderBy(p => p.IDPHONGTRO).Select(p => new { p.IDPHONGTRO, p.CHATLUONGPHONG, p.GIATIEN, p.DIENTICH, p.TINHTRANGPHONG, p.SONGUOITOIDA, p.KHUTRO.TENKHUTRO });
            dtgvDSPT.DataSource = resutl;
        }

        private void LoadDataToControl(int index)
        {
            string maphong = dtgvDSPT.Rows[index].Cells[0].Value.ToString();
            PHONGTRO phg = db.PHONGTROs.Where(p => p.IDPHONGTRO == maphong).FirstOrDefault();
            try
            {
                txtDienTich.Text = phg.DIENTICH.ToString();
                txtGiaTien.Text = phg.GIATIEN.ToString();
                txtIDPhong.Text = phg.IDPHONGTRO;
                txtNguoiToiDa.Text = phg.SONGUOITOIDA.ToString();
                cbbChatLuong.Text = phg.CHATLUONGPHONG;
                cbbTenKhuTro.Text = phg.KHUTRO.TENKHUTRO;
                cbbTinhTrangPhong.Text = phg.TINHTRANGPHONG.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi !!!", "[Thông Báo]");
            }
        }

        private void formBossDanhSachPhongTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            
            cbbTenKhuTro.DataSource = db.KHUTROs;
            cbbTenKhuTro.DisplayMember = "TENKHUTRO";
            cbbTenKhuTro.ValueMember = "IDKHUTRO";

            cbbTenKhuTro.SelectedIndex = 0;
            cbbTinhTrangPhong.SelectedIndex = 0;
            cbbChatLuong.SelectedIndex = 0;

            txtIDPhong.Enabled = false;
            btnLuu.Enabled = false;
            
            LoadData();
        }

        private void dtgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                LoadDataToControl(index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int flag = -1;//0:thêm 1:sửa

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            flag = 0;
            txtIDPhong.Enabled = true;

            txtIDPhong.Text = "";
            //txtNguoiToiDa.Text = "";
            //txtGiaTien.Text = "";
            //txtDienTich.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = -1;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            PHONGTRO pt = db.PHONGTROs.SingleOrDefault(p => p.IDPHONGTRO == txtIDPhong.Text);
            if (pt != null)
            {
                if(MessageBox.Show("Bạn có chắc là xóa ???", "[Thông Báo]",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    btnXoa.Enabled = false;

                    db.PHONGTROs.DeleteOnSubmit(pt);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Thành Công", "[Thông Báo]");
                    LoadData();
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
            txtIDPhong.Enabled = false;
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
                    PHONGTRO phg = new PHONGTRO();

                    phg.IDPHONGTRO = txtIDPhong.Text;
                    phg.CHATLUONGPHONG = cbbChatLuong.SelectedItem.ToString();
                    phg.SONGUOITOIDA = int.Parse(txtNguoiToiDa.Text);
                    phg.GIATIEN = int.Parse(txtGiaTien.Text);
                    phg.DIENTICH = int.Parse(txtDienTich.Text);
                    phg.TINHTRANGPHONG = int.Parse(cbbTinhTrangPhong.SelectedItem.ToString());
                    phg.IDKHUTRO = cbbTenKhuTro.SelectedValue.ToString();

                    db.PHONGTROs.InsertOnSubmit(phg);
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Thêm Thành Công !!!", "[Thông Báo]");
                }
                //catch (Exception)
                //{
                //    MessageBox.Show("Lỗi !!!", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            if (flag == 1)//sửa
            {
                
                PHONGTRO kt = db.PHONGTROs.Where(p => p.IDPHONGTRO == txtIDPhong.Text).FirstOrDefault();
                //try
                {
                    if (kt != null)//nếu có
                    {
                        kt.CHATLUONGPHONG = cbbChatLuong.SelectedItem.ToString();
                        kt.GIATIEN = int.Parse(txtGiaTien.Text);
                        kt.DIENTICH = int.Parse(txtDienTich.Text);
                        kt.TINHTRANGPHONG = int.Parse(cbbTinhTrangPhong.SelectedItem.ToString());
                        kt.SONGUOITOIDA = int.Parse(txtNguoiToiDa.Text);
                        kt.IDKHUTRO = cbbTenKhuTro.SelectedValue.ToString();
                        //cập nhật lại
                        db.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Sửa thành công !!!", "[Thông báo]");
                    }
                }
                //catch (Exception)
                //{
                //    MessageBox.Show("Lỗi !!!", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            flag = -1;
            txtIDPhong.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoNQL_QLNGThue fm = new BaoCaoNQL_QLNGThue();
            fm.ShowDialog();
        }
        int h = 0;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            h += 1;
            XuatExcel(dtgvDSPT, @"C:\Users\Escanor\source\repos\FinalProject\XuatBaoCaoExcel\", "DSPhongTro" + h.ToString());
            MessageBox.Show("In thành công!!!");
        }
    }
}
