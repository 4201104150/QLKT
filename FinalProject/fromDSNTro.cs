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
    public partial class fromDSNTro : Form
    {
        public fromDSNTro()
        {
            InitializeComponent();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void loadData(string tinhtrang="",string khu="")
        {            
            
            if (tinhtrang == "")
            {
                var result = db.PHONGTROs.OrderBy(p => p.IDPHONGTRO).Select(p => new
                { p.IDPHONGTRO, p.KHUTRO.TENKHUTRO, p.CHATLUONGPHONG, p.DIENTICH, p.SONGUOITOIDA, p.TINHTRANGPHONG, p.GIATIEN });
                dtgvDSPTro.DataSource = result;
            }
            else
            {
                var result = db.PHONGTROs.OrderBy(p => p.IDPHONGTRO).Where(p=>p.TINHTRANGPHONG.ToString()==tinhtrang).Select(p => new
                { p.IDPHONGTRO, p.KHUTRO.TENKHUTRO, p.CHATLUONGPHONG, p.DIENTICH, p.SONGUOITOIDA, p.TINHTRANGPHONG, p.GIATIEN });
                dtgvDSPTro.DataSource = result;
            }
        }

        private void fromDSNTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            cbbTTP.SelectedIndex = 0;
            for (int i = 0; i < dtgvDSPTro.Rows.Count; i++)
            {
                dtgvDSPTro.RowsDefaultCellStyle.BackColor = Color.Lavender;
                dtgvDSPTro.AlternatingRowsDefaultCellStyle.BackColor = Color.MediumPurple;
            }
            loadData();
        }

        private void cbbTTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tt = cbbTTP.SelectedItem.ToString();
            loadData(tt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
