namespace FinalProject
{
    partial class fromDSNTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromDSNTro));
            this.dtgvDSPTro = new System.Windows.Forms.DataGridView();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTTP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSPTro
            // 
            this.dtgvDSPTro.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDSPTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhong,
            this.KhuTro,
            this.ChatLuong,
            this.DienTich,
            this.SoNgToiDa,
            this.TinhTrang,
            this.GiaTien});
            this.dtgvDSPTro.GridColor = System.Drawing.Color.Fuchsia;
            this.dtgvDSPTro.Location = new System.Drawing.Point(12, 153);
            this.dtgvDSPTro.Name = "dtgvDSPTro";
            this.dtgvDSPTro.Size = new System.Drawing.Size(847, 258);
            this.dtgvDSPTro.TabIndex = 0;
            // 
            // IDPhong
            // 
            this.IDPhong.DataPropertyName = "IDPHONGTRO";
            this.IDPhong.HeaderText = "ID Phòng Trọ";
            this.IDPhong.Name = "IDPhong";
            // 
            // KhuTro
            // 
            this.KhuTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhuTro.DataPropertyName = "TENKHUTRO";
            this.KhuTro.HeaderText = "Tên Khu Trọ";
            this.KhuTro.Name = "KhuTro";
            // 
            // ChatLuong
            // 
            this.ChatLuong.DataPropertyName = "CHATLUONGPHONG";
            this.ChatLuong.HeaderText = "Chất Lượng";
            this.ChatLuong.Name = "ChatLuong";
            this.ChatLuong.Width = 112;
            // 
            // DienTich
            // 
            this.DienTich.DataPropertyName = "DIENTICH";
            this.DienTich.HeaderText = "Diện Tích(m2)";
            this.DienTich.Name = "DienTich";
            this.DienTich.Width = 113;
            // 
            // SoNgToiDa
            // 
            this.SoNgToiDa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoNgToiDa.DataPropertyName = "SONGUOITOIDA";
            this.SoNgToiDa.HeaderText = "Số Người Tối Đa";
            this.SoNgToiDa.Name = "SoNgToiDa";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TINHTRANGPHONG";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 113;
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTien.DataPropertyName = "GIATIEN";
            this.GiaTien.HeaderText = "Giá Tiền (VND)";
            this.GiaTien.Name = "GiaTien";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tải Lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tình Trạng Phòng";
            // 
            // cbbTTP
            // 
            this.cbbTTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTTP.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTTP.Location = new System.Drawing.Point(364, 84);
            this.cbbTTP.Name = "cbbTTP";
            this.cbbTTP.Size = new System.Drawing.Size(163, 21);
            this.cbbTTP.TabIndex = 0;
            this.cbbTTP.SelectedIndexChanged += new System.EventHandler(this.cbbTTP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(229, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Phòng Trọ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "0: Phòng Trống\r\n1:Phòng Đã Được Thuê\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fromDSNTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(871, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvDSPTro);
            this.MaximizeBox = false;
            this.Name = "fromDSNTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Phòng Trọ";
            this.Load += new System.EventHandler(this.fromDSNTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSPTro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}