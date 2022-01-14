namespace QuanLyTiemThuocDongY
{
    partial class QuanLyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuoc));
            this.btReset = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.cbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.dgvThongTinThuoc = new System.Windows.Forms.DataGridView();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.tbMaThuoc = new System.Windows.Forms.TextBox();
            this.lblGiaMuon = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbQuayLai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).BeginInit();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(267, 282);
            this.btReset.Margin = new System.Windows.Forms.Padding(4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(112, 34);
            this.btReset.TabIndex = 26;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(565, 290);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(331, 27);
            this.tbTimKiem.TabIndex = 25;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(907, 286);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btTimKiem.TabIndex = 24;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // cbTimKiemTheo
            // 
            this.cbTimKiemTheo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTimKiemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTheo.FormattingEnabled = true;
            this.cbTimKiemTheo.Items.AddRange(new object[] {
            "Mã thuốc",
            "Tên thuốc",
            "Loại thuốc"});
            this.cbTimKiemTheo.Location = new System.Drawing.Point(692, 234);
            this.cbTimKiemTheo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimKiemTheo.Name = "cbTimKiemTheo";
            this.cbTimKiemTheo.Size = new System.Drawing.Size(204, 28);
            this.cbTimKiemTheo.TabIndex = 23;
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemTheo.Location = new System.Drawing.Point(559, 238);
            this.lblTimKiemTheo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(114, 20);
            this.lblTimKiemTheo.TabIndex = 22;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo";
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(267, 230);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(112, 34);
            this.btSua.TabIndex = 21;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(109, 282);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(112, 34);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(109, 230);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 34);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbLoaiThuoc
            // 
            this.cbLoaiThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiThuoc.FormattingEnabled = true;
            this.cbLoaiThuoc.Location = new System.Drawing.Point(692, 127);
            this.cbLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiThuoc.Name = "cbLoaiThuoc";
            this.cbLoaiThuoc.Size = new System.Drawing.Size(204, 28);
            this.cbLoaiThuoc.TabIndex = 18;
            // 
            // tbGia
            // 
            this.tbGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(692, 81);
            this.tbGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(204, 27);
            this.tbGia.TabIndex = 17;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(561, 130);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(87, 20);
            this.lblTheLoai.TabIndex = 16;
            this.lblTheLoai.Text = "Loại thuốc";
            // 
            // dgvThongTinThuoc
            // 
            this.dgvThongTinThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvThongTinThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinThuoc.Location = new System.Drawing.Point(13, 348);
            this.dgvThongTinThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinThuoc.Name = "dgvThongTinThuoc";
            this.dgvThongTinThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinThuoc.Size = new System.Drawing.Size(1041, 193);
            this.dgvThongTinThuoc.TabIndex = 15;
            this.dgvThongTinThuoc.DoubleClick += new System.EventHandler(this.dgvThongTinThuoc_DoubleClick);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(188, 174);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(204, 27);
            this.tbSoLuong.TabIndex = 14;
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThuoc.Location = new System.Drawing.Point(188, 127);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(204, 27);
            this.tbTenThuoc.TabIndex = 13;
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThuoc.Location = new System.Drawing.Point(188, 84);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(204, 27);
            this.tbMaThuoc.TabIndex = 12;
            // 
            // lblGiaMuon
            // 
            this.lblGiaMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGiaMuon.AutoSize = true;
            this.lblGiaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaMuon.Location = new System.Drawing.Point(561, 87);
            this.lblGiaMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaMuon.Name = "lblGiaMuon";
            this.lblGiaMuon.Size = new System.Drawing.Size(35, 20);
            this.lblGiaMuon.TabIndex = 10;
            this.lblGiaMuon.Text = "Giá";
            // 
            // lblTacGia
            // 
            this.lblTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(69, 177);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(74, 20);
            this.lblTacGia.TabIndex = 9;
            this.lblTacGia.Text = "Số lượng";
            // 
            // lblTenSach
            // 
            this.lblTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(69, 130);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(83, 20);
            this.lblTenSach.TabIndex = 8;
            this.lblTenSach.Text = "Tên thuốc";
            // 
            // lblMaSach
            // 
            this.lblMaSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(69, 84);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(78, 20);
            this.lblMaSach.TabIndex = 7;
            this.lblMaSach.Text = "Mã thuốc";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1041, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.pbQuayLai);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.cbTimKiemTheo);
            this.panel1.Controls.Add(this.lblTimKiemTheo);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.cbLoaiThuoc);
            this.panel1.Controls.Add(this.tbGia);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.dgvThongTinThuoc);
            this.panel1.Controls.Add(this.tbSoLuong);
            this.panel1.Controls.Add(this.tbTenThuoc);
            this.panel1.Controls.Add(this.tbMaThuoc);
            this.panel1.Controls.Add(this.lblGiaMuon);
            this.panel1.Controls.Add(this.lblTacGia);
            this.panel1.Controls.Add(this.lblTenSach);
            this.panel1.Controls.Add(this.lblMaSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 4;
            // 
            // pbQuayLai
            // 
            this.pbQuayLai.ErrorImage = null;
            this.pbQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("pbQuayLai.Image")));
            this.pbQuayLai.InitialImage = null;
            this.pbQuayLai.Location = new System.Drawing.Point(13, 10);
            this.pbQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.pbQuayLai.Name = "pbQuayLai";
            this.pbQuayLai.Size = new System.Drawing.Size(40, 40);
            this.pbQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuayLai.TabIndex = 38;
            this.pbQuayLai.TabStop = false;
            this.pbQuayLai.Click += new System.EventHandler(this.pbQuayLai_Click);
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THUỐC";
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiemTheo;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbLoaiThuoc;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.DataGridView dgvThongTinThuoc;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.TextBox tbMaThuoc;
        private System.Windows.Forms.Label lblGiaMuon;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbQuayLai;
    }
}