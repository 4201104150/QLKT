namespace FinalProject
{
    partial class BaoCaoNQL_QLNGThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoNQL_QLNGThue));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quanLyNhieuDayTroDataSet = new FinalProject.QuanLyNhieuDayTroDataSet();
            this.vBaoCaoPhongTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vBaoCaoPhongTroTableAdapter = new FinalProject.QuanLyNhieuDayTroDataSetTableAdapters.vBaoCaoPhongTroTableAdapter();
            this.tableAdapterManager = new FinalProject.QuanLyNhieuDayTroDataSetTableAdapters.TableAdapterManager();
            this.vBaoCaoPhongTroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vBaoCaoPhongTroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HoTenNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhieuDayTroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBaoCaoPhongTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBaoCaoPhongTroBindingNavigator)).BeginInit();
            this.vBaoCaoPhongTroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Số người ở";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Diện Tích";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(478, 410);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // quanLyNhieuDayTroDataSet
            // 
            this.quanLyNhieuDayTroDataSet.DataSetName = "QuanLyNhieuDayTroDataSet";
            this.quanLyNhieuDayTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vBaoCaoPhongTroBindingSource
            // 
            this.vBaoCaoPhongTroBindingSource.DataMember = "vBaoCaoPhongTro";
            this.vBaoCaoPhongTroBindingSource.DataSource = this.quanLyNhieuDayTroDataSet;
            // 
            // vBaoCaoPhongTroTableAdapter
            // 
            this.vBaoCaoPhongTroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHUQUANLYTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KHUTROTableAdapter = null;
            this.tableAdapterManager.NGUOIQUANLYTableAdapter = null;
            this.tableAdapterManager.NGUOITHUETableAdapter = null;
            this.tableAdapterManager.PHONGTROTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.QuanLyNhieuDayTroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vBaoCaoPhongTroBindingNavigator
            // 
            this.vBaoCaoPhongTroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vBaoCaoPhongTroBindingNavigator.BindingSource = this.vBaoCaoPhongTroBindingSource;
            this.vBaoCaoPhongTroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vBaoCaoPhongTroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vBaoCaoPhongTroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vBaoCaoPhongTroBindingNavigatorSaveItem});
            this.vBaoCaoPhongTroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vBaoCaoPhongTroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vBaoCaoPhongTroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vBaoCaoPhongTroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vBaoCaoPhongTroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vBaoCaoPhongTroBindingNavigator.Name = "vBaoCaoPhongTroBindingNavigator";
            this.vBaoCaoPhongTroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vBaoCaoPhongTroBindingNavigator.Size = new System.Drawing.Size(1109, 25);
            this.vBaoCaoPhongTroBindingNavigator.TabIndex = 1;
            this.vBaoCaoPhongTroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vBaoCaoPhongTroBindingNavigatorSaveItem
            // 
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.Enabled = false;
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vBaoCaoPhongTroBindingNavigatorSaveItem.Image")));
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.Name = "vBaoCaoPhongTroBindingNavigatorSaveItem";
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vBaoCaoPhongTroBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTenNguoiThue,
            this.IDPhong,
            this.CMND,
            this.TenKhuTro,
            this.GiaTien});
            this.dataGridView1.Location = new System.Drawing.Point(484, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 418);
            this.dataGridView1.TabIndex = 2;
            // 
            // HoTenNguoiThue
            // 
            this.HoTenNguoiThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTenNguoiThue.DataPropertyName = "HOTEN";
            this.HoTenNguoiThue.HeaderText = "Họ Tên";
            this.HoTenNguoiThue.Name = "HoTenNguoiThue";
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPHONG";
            this.IDPhong.HeaderText = "ID Phòng";
            this.IDPhong.Name = "IDPhong";
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // TenKhuTro
            // 
            this.TenKhuTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhuTro.DataPropertyName = "TENKHUTRO";
            this.TenKhuTro.HeaderText = "Tên Khu Tro";
            this.TenKhuTro.Name = "TenKhuTro";
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTien.DataPropertyName = "GIATIEN";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            // 
            // BaoCaoNQL_QLNGThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vBaoCaoPhongTroBindingNavigator);
            this.Controls.Add(this.chart1);
            this.Name = "BaoCaoNQL_QLNGThue";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCaoNQL_QLNGThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhieuDayTroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBaoCaoPhongTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBaoCaoPhongTroBindingNavigator)).EndInit();
            this.vBaoCaoPhongTroBindingNavigator.ResumeLayout(false);
            this.vBaoCaoPhongTroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private QuanLyNhieuDayTroDataSet quanLyNhieuDayTroDataSet;
        private System.Windows.Forms.BindingSource vBaoCaoPhongTroBindingSource;
        private QuanLyNhieuDayTroDataSetTableAdapters.vBaoCaoPhongTroTableAdapter vBaoCaoPhongTroTableAdapter;
        private QuanLyNhieuDayTroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vBaoCaoPhongTroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vBaoCaoPhongTroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}