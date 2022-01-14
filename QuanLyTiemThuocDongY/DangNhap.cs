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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            if(taiKhoan.DangNhap(tbTenDangNhap.Text, tbMatKhau.Text) == true)
            {
                GiaoDien giaoDien = new GiaoDien();
                giaoDien.TenDangNhap = tbTenDangNhap.Text;
                giaoDien.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
