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
    public partial class XemHoaDon : Form
    {
        public int MaKH;
        public XemHoaDon()
        {
            InitializeComponent();
        }

        private void XemHoaDon_Load(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            lblTenKH.Text = khachHang.ShowTenKH(MaKH);
            lblDiaChi.Text = khachHang.ShowDiaChi(MaKH);
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            DataTable table = new DataTable();
            table = chiTietHoaDon.ShowHoaDon(MaKH);
            dgvThongTin.DataSource = table;
            tbTongTien.Text = chiTietHoaDon.TongTienHD(MaKH).ToString();
        }
    }
}
