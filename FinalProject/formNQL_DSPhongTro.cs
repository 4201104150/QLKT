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
    public partial class formNQL_DSPhongTro : Form
    {
        public formNQL_DSPhongTro()
        {
            InitializeComponent();
        }

        public static string idKhuTroNGQLorBoss="";

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void LoadData()
        {
            if (idKhuTroNGQLorBoss == "ADMIN")
            {
                var resutl = db.PHONGTROs.OrderBy(p => p.IDPHONGTRO).Select(p => new
                {
                    p.IDPHONGTRO,
                    p.CHATLUONGPHONG,
                    p.GIATIEN,
                    p.DIENTICH,
                    p.TINHTRANGPHONG,
                    p.SONGUOITOIDA,
                    p.KHUTRO.TENKHUTRO
                });
                dtgvDSP.DataSource = resutl;
            }
            else
            {
                var resutl = db.PHONGTROs.OrderBy(p => p.IDPHONGTRO).Where(p => p.IDKHUTRO == idKhuTroNGQLorBoss).Select(p => new
                {
                    p.IDPHONGTRO,
                    p.CHATLUONGPHONG,
                    p.GIATIEN,
                    p.DIENTICH,
                    p.TINHTRANGPHONG,
                    p.SONGUOITOIDA,
                    p.KHUTRO.TENKHUTRO
                });
                dtgvDSP.DataSource = resutl;
            }
        }

        private void LoadDataToConTrol(int index)
        {
            string idphong = dtgvDSP.Rows[index].Cells[0].Value.ToString();
            PHONGTRO phg = db.PHONGTROs.Where(p => p.IDPHONGTRO == idphong).FirstOrDefault();
            try
            {
                txtDienTich.Text = phg.DIENTICH.ToString();
                txtGiaTien.Text = phg.GIATIEN.ToString();
                txtIDPhong.Text = phg.IDPHONGTRO;
                txtSoNgToiDa.Text = phg.SONGUOITOIDA.ToString();
                cbbChatLuong.Text = phg.CHATLUONGPHONG;
                cbbTenKhuTro.Text = phg.KHUTRO.TENKHUTRO;
                cbbTinhTrangPhong.Text = phg.TINHTRANGPHONG.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "[Thông Báo]");
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

        private void formNQL_DSPhongTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            cbbTenKhuTro.DataSource = db.KHUTROs;
            cbbTenKhuTro.DisplayMember = "TENKHUTRO";
            cbbTenKhuTro.ValueMember = "IDKHUTRO";

            cbbTinhTrangPhong.SelectedIndex = 0;
            cbbTenKhuTro.SelectedIndex = 0;
            cbbChatLuong.SelectedIndex = 0;

            btnLuu.Enabled = false;

            LoadData();
        }

        private void dtgvDSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            if (irow >= 0)
            {
                LoadDataToConTrol(irow);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            
            PHONGTRO kt = db.PHONGTROs.Where(p => p.IDPHONGTRO == txtIDPhong.Text).FirstOrDefault();
//            try
            {
                if (kt != null)//nếu có
                {
                    kt.CHATLUONGPHONG = cbbChatLuong.SelectedItem.ToString();
                    kt.GIATIEN = int.Parse(txtGiaTien.Text);
                    kt.DIENTICH = int.Parse(txtDienTich.Text);
                    kt.TINHTRANGPHONG = int.Parse(cbbTinhTrangPhong.SelectedItem.ToString());
                    kt.SONGUOITOIDA = int.Parse(txtSoNgToiDa.Text);
                    kt.IDKHUTRO = cbbTenKhuTro.SelectedValue.ToString();
                    //cập nhật lại
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Sửa thành công !!!", "[Thông báo]");
                }
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi", "[Thông Báo]");
            //}
        }

        int h = 0;

        private void btnIn_Click(object sender, EventArgs e)
        {
            h += 1;
            XuatExcel(dtgvDSP, @"C:\Users\Escanor\source\repos\FinalProject\XuatBaoCaoExcel\", "DSPhongTro" + h.ToString());
            MessageBox.Show("In thành công!!!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
