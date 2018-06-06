namespace FinalProject
{
    partial class formNQL_DSPhongTro
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
            this.dtgvDSP = new System.Windows.Forms.DataGridView();
            this.IDPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbTenKhuTro = new System.Windows.Forms.ComboBox();
            this.cbbChatLuong = new System.Windows.Forms.ComboBox();
            this.cbbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtSoNgToiDa = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDSP
            // 
            this.dtgvDSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhongTro,
            this.ChatLuong,
            this.GiaTien,
            this.DienTich,
            this.TinhTrangPhong,
            this.SoNguoiToiDa,
            this.TenKhuTro});
            this.dtgvDSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgvDSP.Location = new System.Drawing.Point(12, 200);
            this.dtgvDSP.Name = "dtgvDSP";
            this.dtgvDSP.Size = new System.Drawing.Size(776, 238);
            this.dtgvDSP.TabIndex = 0;
            this.dtgvDSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSP_CellClick);
            // 
            // IDPhongTro
            // 
            this.IDPhongTro.DataPropertyName = "IDPHONGTRO";
            this.IDPhongTro.HeaderText = "ID Phòng Trọ";
            this.IDPhongTro.Name = "IDPhongTro";
            // 
            // ChatLuong
            // 
            this.ChatLuong.DataPropertyName = "CHATLUONGPHONG";
            this.ChatLuong.HeaderText = "Chất Lượng Phòng";
            this.ChatLuong.Name = "ChatLuong";
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Location = new System.Drawing.Point(534, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(31, 76);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(147, 76);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(147, 44);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(31, 44);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbTenKhuTro);
            this.groupBox2.Controls.Add(this.cbbChatLuong);
            this.groupBox2.Controls.Add(this.cbbTinhTrangPhong);
            this.groupBox2.Controls.Add(this.txtDienTich);
            this.groupBox2.Controls.Add(this.txtSoNgToiDa);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIDPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thuộc Tính";
            // 
            // cbbTenKhuTro
            // 
            this.cbbTenKhuTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbbTenKhuTro.Enabled = false;
            this.cbbTenKhuTro.FormattingEnabled = true;
            this.cbbTenKhuTro.Location = new System.Drawing.Point(377, 73);
            this.cbbTenKhuTro.Name = "cbbTenKhuTro";
            this.cbbTenKhuTro.Size = new System.Drawing.Size(127, 21);
            this.cbbTenKhuTro.TabIndex = 13;
            // 
            // cbbChatLuong
            // 
            this.cbbChatLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChatLuong.FormattingEnabled = true;
            this.cbbChatLuong.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "TB"});
            this.cbbChatLuong.Location = new System.Drawing.Point(129, 46);
            this.cbbChatLuong.Name = "cbbChatLuong";
            this.cbbChatLuong.Size = new System.Drawing.Size(127, 21);
            this.cbbChatLuong.TabIndex = 12;
            // 
            // cbbTinhTrangPhong
            // 
            this.cbbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrangPhong.FormattingEnabled = true;
            this.cbbTinhTrangPhong.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTinhTrangPhong.Location = new System.Drawing.Point(377, 46);
            this.cbbTinhTrangPhong.Name = "cbbTinhTrangPhong";
            this.cbbTinhTrangPhong.Size = new System.Drawing.Size(127, 21);
            this.cbbTinhTrangPhong.TabIndex = 11;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(377, 20);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(127, 20);
            this.txtDienTich.TabIndex = 10;
            // 
            // txtSoNgToiDa
            // 
            this.txtSoNgToiDa.Location = new System.Drawing.Point(129, 99);
            this.txtSoNgToiDa.Name = "txtSoNgToiDa";
            this.txtSoNgToiDa.Size = new System.Drawing.Size(127, 20);
            this.txtSoNgToiDa.TabIndex = 9;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(129, 73);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(127, 20);
            this.txtGiaTien.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên Khu Trọ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Người Tối Đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tình Trạng Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diện Tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chất Lượng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(129, 20);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.ReadOnly = true;
            this.txtIDPhong.Size = new System.Drawing.Size(127, 20);
            this.txtIDPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(227, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "Danh Sách Phòng Trọ";
            // 
            // formNQL_DSPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDSP);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formNQL_DSPhongTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Phòng Trọ";
            this.Load += new System.EventHandler(this.formNQL_DSPhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtSoNgToiDa;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cbbTinhTrangPhong;
        private System.Windows.Forms.ComboBox cbbTenKhuTro;
        private System.Windows.Forms.ComboBox cbbChatLuong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuTro;
        private System.Windows.Forms.Label label8;
    }
}