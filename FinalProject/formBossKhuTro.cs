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
    public partial class formBossKhuTro : Form
    {
        public formBossKhuTro()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void LoadData()
        {
            var resutl = db.KHUTROs.OrderBy(p => p.IDKHUTRO).Select(p => new { p.IDKHUTRO, p.TENKHUTRO, p.DIACHI });
            dtgvDS.DataSource = resutl;
        }

        private void LoadDataToConTrol( int index)
        {
            string id = dtgvDS.Rows[index].Cells[0].Value.ToString();

            KHUTRO kt = db.KHUTROs.Where(p => p.IDKHUTRO == id).FirstOrDefault();
            try
            {
                txtIDKhuTro.Text = kt.IDKHUTRO;
                txtTenKhuTro.Text = kt.TENKHUTRO;
                txtDiaChi.Text = kt.DIACHI;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !!!", "[Thông Báo]");
            }
        }

        private void formBossKhuTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            txtIDKhuTro.Enabled = false;
            btnLuu.Enabled = false;
            LoadData();
        }

        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                LoadDataToConTrol(index);
            }
        }

        int flag = -1;//0:thêm 1:sửa

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

            flag = 0;
            txtIDKhuTro.Enabled = true;
            txtDiaChi.Text = "";
            txtIDKhuTro.Text = "";
            txtTenKhuTro.Text = "";
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;

            flag = 1;
            txtIDKhuTro.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KHUTRO kt = db.KHUTROs.SingleOrDefault(p => p.IDKHUTRO == txtIDKhuTro.Text.Trim());
            if(kt!=null)
            {
                if(MessageBox.Show("Bạn có chắc là xóa ???", "[Thông Báo]", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    db.KHUTROs.DeleteOnSubmit(kt);
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Xóa Thành Công!!!", "[Thông Báo]");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            if (flag == 0)//thêm
            {
                try
                {
                    KHUTRO kt = new KHUTRO
                    {
                        IDKHUTRO = txtIDKhuTro.Text,
                        DIACHI = txtDiaChi.Text,
                        TENKHUTRO=txtTenKhuTro.Text
                    };
                    db.KHUTROs.InsertOnSubmit(kt);
                    db.SubmitChanges();
                    LoadData();
                    MessageBox.Show("Thêm Thành Công !!!", "[Thông Báo]");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !!!", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (flag == 1)//sửa
            {
                try
                {
                    KHUTRO kt = db.KHUTROs.Where(p => p.IDKHUTRO == txtIDKhuTro.Text).FirstOrDefault();
                    if (kt != null)//nếu có
                    {
                        kt.TENKHUTRO = txtTenKhuTro.Text;
                        kt.DIACHI = txtDiaChi.Text;
                        //cập nhật lại
                        db.SubmitChanges();
                        LoadData();
                        MessageBox.Show("Sửa thành công !!!", "[Thông báo]");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !!!", "[Thông Báo]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            flag = -1;
            txtIDKhuTro.Enabled = false;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
