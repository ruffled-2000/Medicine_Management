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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTenDangNhap.Text == "" || tbMatKhau.Text == "" || tbHoTen.Text == "")
                MessageBox.Show("Không được để trống các thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                if (taiKhoan.KiemTraTK(tbTenDangNhap.Text))
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int i = 1;
                    if (rbNhanVien.Checked)
                        i = 0;
                    taiKhoan.InsertTaiKhoan(tbTenDangNhap.Text, tbMatKhau.Text, tbHoTen.Text, i);
                    this.Close();
                }
            }
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            rbNhanVien.Checked = true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
