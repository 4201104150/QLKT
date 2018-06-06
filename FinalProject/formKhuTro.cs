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
    public partial class formKhuTro : Form
    {
        public formKhuTro()
        {
            InitializeComponent();
        }

        DataQLNKTDataContext db = new DataQLNKTDataContext();

        private void formKhuTro_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            dataGridView1.DataSource = db.KHUTROs.Select(p => new { p.IDKHUTRO, p.TENKHUTRO, p.DIACHI }).OrderBy(p => p.IDKHUTRO);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.Lavender;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.MediumPurple;
            }

        }
    }
}
