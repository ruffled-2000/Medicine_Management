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
    public partial class DoiMatKhau : Form
    {
        public string TenDangNhap = "";
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            if(taiKhoan.KiemTraMatKhau(TenDangNhap, tbMatKhau.Text) == true)
            {
                if (String.Compare(tbMatKhauMoi.Text, tbXacNhanMatKhau.Text, false) == 0)
                {
                    taiKhoan.UpdateTaiKhoan(TenDangNhap, tbMatKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }    
                else
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu phải trùng với nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Sai mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
