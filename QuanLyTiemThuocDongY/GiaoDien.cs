using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocDongY
{
    public partial class GiaoDien : Form
    {
        public string TenDangNhap = "";
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void btTrangChu_Click(object sender, EventArgs e)
        {
            giaoDienControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btQuanLyLoaiThuoc_Click(object sender, EventArgs e)
        {
        }

        private void btQuanLyKhachHang_Click(object sender, EventArgs e)
        {
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            if (taiKhoan.LoaiTaiKhoan(TenDangNhap) == false)
            {
                pbThongKe.Hide();
                pbQuanLyTaiKhoan.Hide();
            }
            giaoDienControl1.BringToFront();
        }

        private void pbThongKe_Click(object sender, EventArgs e)
        {
            thongKeControl1.BringToFront();
        }

        private void pbQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            taiKhoanControl1.BringToFront();
        }

        private void pbTrangChu_Click(object sender, EventArgs e)
        {
            giaoDienControl1.BringToFront();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            this.Hide();
            quanLyKhachHang.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.TenDangNhap = TenDangNhap;
            doiMatKhau.Show();
            GiaoDien_Load(sender, e);
        }

        private void khachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            this.Hide();
            quanLyKhachHang.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }

        private void khachHangToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            this.Hide();
            quanLyKhachHang.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }

        private void khachHangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            this.Hide();
            quanLyKhachHang.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }

        private void thuôcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            this.Hide();
            quanLyThuoc.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }

        private void loaiThuôcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLoaiThuoc quanLyLoaiThuoc = new QuanLyLoaiThuoc();
            this.Hide();
            quanLyLoaiThuoc.ShowDialog();
            this.Show();
            GiaoDien_Load(sender, e);
        }
    }
}