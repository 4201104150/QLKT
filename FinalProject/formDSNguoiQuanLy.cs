using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{    
    public partial class formDSNguoiQuanLy : Form
    {
        public formDSNguoiQuanLy()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        DataQLNKTDataContext db = new DataQLNKTDataContext();
        //private string chuoi = "Data Source=.;Initial Catalog=QuanLyNhieuDayTro;Integrated Security=True";
        private void loaddata()
        {
            lvNQL.Clear();
            var resutl = db.NGUOIQUANLies;
            
            List<NGUOIQUANLY> ns = new List<NGUOIQUANLY>();
            ns = (from NGUOIQUANLY in db.NGUOIQUANLies
                  orderby NGUOIQUANLY.IDNGUOIQUANLY
                  select NGUOIQUANLY).ToList();
            foreach(NGUOIQUANLY s in ns)
            {
                lvNQL.Items.Add(new ListViewItem(new string[] { s.IDNGUOIQUANLY }));
            }
        }

        /*private void Loaddata( string ma="")
        {
            if (ma == "")
            {
                var resutl = db.NGUOIQUANLies.OrderBy(p => p.IDNGUOIQUANLY).Select(p => new
                {
                    p.IDNGUOIQUANLY,
                    p.HOTEN,
                    p.NGAYSINH,
                    p.CMND,
                    p.DIACHI,
                    p.KHUTRO.TENKHUTRO,
                    p.SDT
                });
                dtgvDSNQL.DataSource = resutl;
            }
            else
            {
                var resutl = db.NGUOIQUANLies.OrderBy(p => p.IDNGUOIQUANLY).Where(p=>p.IDKHUTRO==ma).Select(p => new
                {
                    p.IDNGUOIQUANLY,
                    p.HOTEN,
                    p.NGAYSINH,
                    p.CMND,
                    p.DIACHI,
                    p.KHUTRO.TENKHUTRO,
                    p.SDT
                });
                dtgvDSNQL.DataSource = resutl;
            }
        }

        private void formDSNguoiQuanLy_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //load data vào combobox
            //    cbbKhuTro.DataSource = db.KHUTROs;
            //    cbbKhuTro.DisplayMember = "TENKHUTRO";
            //    cbbKhuTro.ValueMember = "IDKHUTRO";
            //    cbbKhuTro.SelectedIndex = 0;
            //    cbbKhuTro_SelectedIndexChanged(sender, e);
            //    //load data từ database
               
            //    for (int i = 0; i < dtgvDSNQL.Rows.Count; i++)
            //    {
            //        dtgvDSNQL.RowsDefaultCellStyle.BackColor = Color.Yellow;
            //        dtgvDSNQL.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
            //    }
            //    Loaddata();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Lỗi","[Thông Báo]",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }*/

        private void loaddddd(string khu="")
        {
            lvNQL.Clear();
            if(khu!="")
            {
               // var resutl = db.NGUOIQUANLies;

                List<NGUOIQUANLY> ns = new List<NGUOIQUANLY>();
                ns = (from NGUOIQUANLY in db.NGUOIQUANLies
                      orderby NGUOIQUANLY.IDNGUOIQUANLY
                      where NGUOIQUANLY.IDKHUTRO==khu
                      select NGUOIQUANLY).ToList();
                foreach (NGUOIQUANLY s in ns)
                {
                    lvNQL.Items.Add(new ListViewItem(new string[] { s.IDNGUOIQUANLY }));
                }
            }
        }

        private void cbbKhuTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tt = cbbKhuTro.SelectedValue.ToString();
            loaddddd(tt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void lvNQL_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            var selectnql = db.NGUOIQUANLies.FirstOrDefault(p => p.IDNGUOIQUANLY == item.Text);
            if (item.Index >= 0)
            {
                if(selectnql!=null)
                {
                    txtCMND.Text = selectnql.CMND;
                    txtDiaChi.Text = selectnql.DIACHI;
                    txtHoTen.Text = selectnql.HOTEN;
                    txtIDNQL.Text = selectnql.IDNGUOIQUANLY;
                    txtSDT.Text = selectnql.SDT;
                    dtNgaySinh.Value = selectnql.NGAYSINH;
                    cbbKhuTro.Text = selectnql.KHUTRO.TENKHUTRO;
                }
            }
        }

        private void formDSNguoiQuanLy_Load(object sender, EventArgs e)
        {
            cbbKhuTro.DataSource = db.KHUTROs;
            cbbKhuTro.DisplayMember = "TENKHUTRO";
            cbbKhuTro.ValueMember = "IDKHUTRO";
            cbbKhuTro.SelectedIndex = 0;

            //loaddata();
            cbbKhuTro_SelectedIndexChanged(sender, e);
        }
    }
}
