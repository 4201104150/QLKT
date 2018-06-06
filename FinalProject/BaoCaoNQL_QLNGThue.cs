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
    public partial class BaoCaoNQL_QLNGThue : Form
    {
        public BaoCaoNQL_QLNGThue()
        {
            InitializeComponent();
        }
        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void LoadData()
        {
            var resutl = db.NGUOITHUEs.OrderBy(p => p.IDNGUOITHUE).Select(p => new { p.HOTEN, p.IDPHONG, p.CMND,p.PHONGTRO.KHUTRO.TENKHUTRO, p.PHONGTRO.GIATIEN });
            dataGridView1.DataSource = resutl;
        }

        private void BaoCaoNQL_QLNGThue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhieuDayTroDataSet.vBaoCaoPhongTro' table. You can move, or remove it, as needed.
            this.vBaoCaoPhongTroTableAdapter.Fill(this.quanLyNhieuDayTroDataSet.vBaoCaoPhongTro);
            LoadData();
            chart1.DataSource = db.PHONGTROs;

            chart1.Series["Số người ở"].XValueMember = "IDPHONGTRO";
            chart1.Series["Số người ở"].YValueMembers = "SONGUOITOIDA";

            chart1.Series["Diện Tích"].XValueMember = "IDPHONGTRO";
            chart1.Series["Diện Tích"].YValueMembers = "DIENTICH";

            //chart1.Series["Tien"].IsValueShownAsLabel = true;
        }
    }
}
