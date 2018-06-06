namespace FinalProject
{
    partial class formBossDanhSachPhongTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBossDanhSachPhongTro));
            this.dtgvDSPT = new System.Windows.Forms.DataGridView();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNguoiToiDa = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.cbbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.cbbChatLuong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.cbbTenKhuTro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPT)).BeginInit();
            this.btnLoad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSPT
            // 
            this.dtgvDSPT.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhong,
            this.ChatLuongPhong,
            this.GiaTien,
            this.DienTich,
            this.TinhTrangPhong,
            this.SoNguoiToiDa,
            this.TenKhuTro});
            this.dtgvDSPT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvDSPT.Location = new System.Drawing.Point(12, 248);
            this.dtgvDSPT.Name = "dtgvDSPT";
            this.dtgvDSPT.Size = new System.Drawing.Size(776, 190);
            this.dtgvDSPT.TabIndex = 0;
            this.dtgvDSPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPT_CellClick);
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPHONGTRO";
            this.IDPhong.HeaderText = "ID Phòng";
            this.IDPhong.Name = "IDPhong";
            // 
            // ChatLuongPhong
            // 
            this.ChatLuongPhong.DataPropertyName = "CHATLUONGPHONG";
            this.ChatLuongPhong.HeaderText = "Chất Lượng Phòng";
            this.ChatLuongPhong.Name = "ChatLuongPhong";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GIATIEN";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            // 
            // DienTich
            // 
            this.DienTich.DataPropertyName = "DIENTICH";
            this.DienTich.HeaderText = "Diện Tích";
            this.DienTich.Name = "DienTich";
            // 
            // TinhTrangPhong
            // 
            this.TinhTrangPhong.DataPropertyName = "TINHTRANGPHONG";
            this.TinhTrangPhong.HeaderText = "Tình Trạng Phòng";
            this.TinhTrangPhong.Name = "TinhTrangPhong";
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.DataPropertyName = "SONGUOITOIDA";
            this.SoNguoiToiDa.HeaderText = "Số Người Tối Đa";
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            // 
            // TenKhuTro
            // 
            this.TenKhuTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhuTro.DataPropertyName = "TENKHUTRO";
            this.TenKhuTro.HeaderText = "Tên Khu Trọ";
            this.TenKhuTro.Name = "TenKhuTro";
            // 
            // btnLoad
            // 
            this.btnLoad.Controls.Add(this.btnExcel);
            this.btnLoad.Controls.Add(this.button1);
            this.btnLoad.Controls.Add(this.btnThoat);
            this.btnLoad.Controls.Add(this.button5);
            this.btnLoad.Controls.Add(this.btnLuu);
            this.btnLoad.Controls.Add(this.btnSua);
            this.btnLoad.Controls.Add(this.btnXoa);
            this.btnLoad.Controls.Add(this.btnThem);
            this.btnLoad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(588, 86);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 154);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Chức Năng";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(107, 121);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.Text = "In Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "In BC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(107, 91);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tải Lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(107, 58);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(17, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(107, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNguoiToiDa);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.txtDienTich);
            this.groupBox2.Controls.Add(this.cbbTinhTrangPhong);
            this.groupBox2.Controls.Add(this.cbbChatLuong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIDPhong);
            this.groupBox2.Controls.Add(this.cbbTenKhuTro);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thuộc Tính";
            // 
            // txtNguoiToiDa
            // 
            this.txtNguoiToiDa.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiToiDa.Location = new System.Drawing.Point(128, 117);
            this.txtNguoiToiDa.Name = "txtNguoiToiDa";
            this.txtNguoiToiDa.Size = new System.Drawing.Size(147, 23);
            this.txtNguoiToiDa.TabIndex = 15;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(128, 90);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(147, 23);
            this.txtGiaTien.TabIndex = 14;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(422, 62);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(142, 23);
            this.txtDienTich.TabIndex = 13;
            // 
            // cbbTinhTrangPhong
            // 
            this.cbbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrangPhong.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrangPhong.FormattingEnabled = true;
            this.cbbTinhTrangPhong.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTinhTrangPhong.Location = new System.Drawing.Point(422, 31);
            this.cbbTinhTrangPhong.Name = "cbbTinhTrangPhong";
            this.cbbTinhTrangPhong.Size = new System.Drawing.Size(142, 23);
            this.cbbTinhTrangPhong.TabIndex = 12;
            // 
            // cbbChatLuong
            // 
            this.cbbChatLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChatLuong.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChatLuong.FormattingEnabled = true;
            this.cbbChatLuong.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "TB"});
            this.cbbChatLuong.Location = new System.Drawing.Point(128, 61);
            this.cbbChatLuong.Name = "cbbChatLuong";
            this.cbbChatLuong.Size = new System.Drawing.Size(147, 23);
            this.cbbChatLuong.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên Khu Trọ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Người Tối Đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tình Trạng Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diện Tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chất Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Phòng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhong.Location = new System.Drawing.Point(128, 31);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(147, 23);
            this.txtIDPhong.TabIndex = 4;
            // 
            // cbbTenKhuTro
            // 
            this.cbbTenKhuTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhuTro.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKhuTro.FormattingEnabled = true;
            this.cbbTenKhuTro.Location = new System.Drawing.Point(422, 91);
            this.cbbTenKhuTro.Name = "cbbTenKhuTro";
            this.cbbTenKhuTro.Size = new System.Drawing.Size(142, 23);
            this.cbbTenKhuTro.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(246, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 42);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quản Lý Phòng Trọ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formBossDanhSachPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtgvDSPT);
            this.MaximizeBox = false;
            this.Name = "formBossDanhSachPhongTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phòng Trọ";
            this.Load += new System.EventHandler(this.formBossDanhSachPhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPT)).EndInit();
            this.btnLoad.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuongPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuTro;
        private System.Windows.Forms.GroupBox btnLoad;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.ComboBox cbbTenKhuTro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguoiToiDa;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.ComboBox cbbTinhTrangPhong;
        private System.Windows.Forms.ComboBox cbbChatLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcel;
    }
}