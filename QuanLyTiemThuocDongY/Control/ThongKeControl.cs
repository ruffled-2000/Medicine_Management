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
    public partial class ThongKeControl : UserControl
    {
        public ThongKeControl()
        {
            InitializeComponent();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            try { 
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                DataTable table = new DataTable();
                table = chiTietHoaDon.ThongKeHD(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString());
                dgvThongKe.DataSource = table;
                tbTongTien.Text = chiTietHoaDon.TongTienTK(dtpTuNgay.Value.ToString(), dtpDenNgay.Value.ToString()).ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Không có hóa đơn nào được xuất ra!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
