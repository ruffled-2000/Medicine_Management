namespace QuanLyTiemThuocDongY
{
    partial class QuanLyLoaiThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyLoaiThuoc));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaLT = new System.Windows.Forms.Label();
            this.lblTenLT = new System.Windows.Forms.Label();
            this.dgvLoaiThuoc = new System.Windows.Forms.DataGridView();
            this.tbMaTL = new System.Windows.Forms.TextBox();
            this.tbTenTL = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbQuayLai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ LOẠI THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaLT
            // 
            this.lblMaLT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaLT.AutoSize = true;
            this.lblMaLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLT.Location = new System.Drawing.Point(63, 98);
            this.lblMaLT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLT.Name = "lblMaLT";
            this.lblMaLT.Size = new System.Drawing.Size(109, 20);
            this.lblMaLT.TabIndex = 9;
            this.lblMaLT.Text = "Mã loại thuốc";
            // 
            // lblTenLT
            // 
            this.lblTenLT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenLT.AutoSize = true;
            this.lblTenLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLT.Location = new System.Drawing.Point(517, 98);
            this.lblTenLT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenLT.Name = "lblTenLT";
            this.lblTenLT.Size = new System.Drawing.Size(114, 20);
            this.lblTenLT.TabIndex = 10;
            this.lblTenLT.Text = "Tên loại thuốc";
            // 
            // dgvLoaiThuoc
            // 
            this.dgvLoaiThuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThuoc.Location = new System.Drawing.Point(19, 219);
            this.dgvLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoaiThuoc.Name = "dgvLoaiThuoc";
            this.dgvLoaiThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiThuoc.Size = new System.Drawing.Size(857, 113);
            this.dgvLoaiThuoc.TabIndex = 11;
            this.dgvLoaiThuoc.DoubleClick += new System.EventHandler(this.dgvLoaiThuoc_DoubleClick);
            // 
            // tbMaTL
            // 
            this.tbMaTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTL.Location = new System.Drawing.Point(195, 95);
            this.tbMaTL.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaTL.Name = "tbMaTL";
            this.tbMaTL.Size = new System.Drawing.Size(176, 27);
            this.tbMaTL.TabIndex = 12;
            // 
            // tbTenTL
            // 
            this.tbTenTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTL.Location = new System.Drawing.Point(651, 95);
            this.tbTenTL.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenTL.Name = "tbTenTL";
            this.tbTenTL.Size = new System.Drawing.Size(175, 27);
            this.tbTenTL.TabIndex = 13;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(261, 161);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 38);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(392, 161);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 38);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(523, 161);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 38);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pbQuayLai);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.tbTenTL);
            this.panel1.Controls.Add(this.tbMaTL);
            this.panel1.Controls.Add(this.dgvLoaiThuoc);
            this.panel1.Controls.Add(this.lblTenLT);
            this.panel1.Controls.Add(this.lblMaLT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 350);
            this.panel1.TabIndex = 1;
            // 
            // pbQuayLai
            // 
            this.pbQuayLai.ErrorImage = null;
            this.pbQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("pbQuayLai.Image")));
            this.pbQuayLai.InitialImage = null;
            this.pbQuayLai.Location = new System.Drawing.Point(19, 13);
            this.pbQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.pbQuayLai.Name = "pbQuayLai";
            this.pbQuayLai.Size = new System.Drawing.Size(40, 40);
            this.pbQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuayLai.TabIndex = 38;
            this.pbQuayLai.TabStop = false;
            this.pbQuayLai.Click += new System.EventHandler(this.pbQuayLai_Click);
            // 
            // QuanLyLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(889, 350);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuanLyLoaiThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ LOẠI THUỐC";
            this.Load += new System.EventHandler(this.QuanLyLoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuayLai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaLT;
        private System.Windows.Forms.Label lblTenLT;
        private System.Windows.Forms.DataGridView dgvLoaiThuoc;
        private System.Windows.Forms.TextBox tbMaTL;
        private System.Windows.Forms.TextBox tbTenTL;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbQuayLai;
    }
}