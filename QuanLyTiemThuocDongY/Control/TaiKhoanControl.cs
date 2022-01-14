using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocDongY
{
    public partial class TaiKhoanControl : UserControl
    {
        public TaiKhoanControl()
        {
            InitializeComponent();
        }

        private void TaiKhoanControl_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            DataTable table = new DataTable();
            table = taiKhoan.ShowTaiKhoan(1);
            dgvAdmin.DataSource = table;
            table = taiKhoan.ShowTaiKhoan(0);
            dgvNhanVien.DataSource = table;
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themTaiKhoan = new ThemTaiKhoan();
            themTaiKhoan.ShowDialog();
            TaiKhoanControl_Load(sender, e);
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            int i = dgvNhanVien.CurrentCell.RowIndex;
            String TenDN = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            taiKhoan.DeleteTaiKhoan(TenDN);
            TaiKhoanControl_Load(sender, e);
        }
    }
}
