using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyTiemThuocDongY
{
    public partial class GiaoDienControl : UserControl
    {
        public int MaKH;
        public GiaoDienControl()
        {
            InitializeComponent();
        }
        private void btKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                if(tbTen.Text == "")
                {
                    throw new Exception("Hãy điền thông tin!!");
                }
                string gt = "Nam";
                if (rbNu.Checked)
                    gt = "Nữ";
                int tuoi = int.Parse(tbTuoi.Text);
                khachHang.CheckSDT(tbSoDT.Text);
                khachHang.InsertKhachHang(tbTen.Text, tuoi, gt, tbSoDT.Text, tbDiaChi.Text);
                tbTen.Enabled = false;
                tbTuoi.Enabled = false;
                tbSoDT.Enabled = false;
                tbDiaChi.Enabled = false;
                rbNam.Enabled = false;
                rbNu.Enabled = false;
                btThem.Enabled = true;
                btKiemTra.Enabled = false;
                btXemHD.Enabled = false;
                MaKH = khachHang.LayMaKH();
                MessageBox.Show("Đã thêm thông tin khách hàng! \nHãy chọn thuốc", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Tuổi phải là số nguyên!!\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            GiaoDienControl_Load(sender, e);
            tbTen.Enabled = true;
            tbTen.Clear();
            tbTuoi.Enabled = true;
            tbTuoi.Clear();
            tbSoDT.Enabled = true;
            tbSoDT.Clear();
            tbDiaChi.Enabled = true;
            tbDiaChi.Clear();
            rbNam.Enabled = true;
            rbNam.Checked = true;
            rbNu.Enabled = true;
            btThem.Enabled = false;
            btKiemTra.Enabled = true;
        }

        public static void CheckChonLT(string LT)
        {
            if (LT == "Chọn thuốc")
            {
                throw new Exception();
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                CheckChonLT(cbLoaiThuoc.Text);
                DataTable table = new DataTable();
                HoaDon hoaDon = new HoaDon();
                hoaDon.InsertHoaDon(MaKH, dtpNgayTao.Value.ToString());
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.InsertChiTietHoaDon(cbThuoc.SelectedValue.ToString(), hoaDon.LayMaHD(), int.Parse(nudSoLuong.Value.ToString()));
                ShowChiTietHD();
                tbTongTien.Text = chiTietHoaDon.TongTienHD(MaKH).ToString();
                btBo.Enabled = true;
                btXemHD.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Hãy chọn loại thuốc và thuốc", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowChiTietHD()
        {
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            DataTable table = new DataTable();
            table = chiTietHoaDon.ShowChiTietHoaDon(MaKH);
            dgvChiTietHoaDon.DataSource = table;
        }

        private void GiaoDienControl_Load(object sender, EventArgs e)
        {
            rbNam.Checked = true;
            string[] s = { "0", "Chọn loại thuốc" };
            LoaiThuoc loaiThuoc = new LoaiThuoc();
            DataTable table = loaiThuoc.ShowLoaiThuoc();
            cbLoaiThuoc.DataSource = table;
            cbLoaiThuoc.DisplayMember = "TenLT";
            cbLoaiThuoc.ValueMember = "MaLT";

            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            DataTable table1 = new DataTable();
            table1 = chiTietHoaDon.ShowChiTietHoaDon(MaKH);
            dgvChiTietHoaDon.DataSource = table1;

            btThem.Enabled = false;
            btBo.Enabled = false;
            btXemHD.Enabled = false;
        }

        private void btBo_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                int i = dgvChiTietHoaDon.CurrentCell.RowIndex;
                int MaHD = int.Parse(dgvChiTietHoaDon.Rows[i].Cells[0].Value.ToString());
                chiTietHoaDon.DeleteChiTietHoaDon(MaHD);
                ShowChiTietHD();
                btThem.Enabled = true;
                if (dgvChiTietHoaDon.Rows.Count > 1)
                {
                    btBo.Enabled = true;
                    btXemHD.Enabled = true; 
                    tbTongTien.Text = chiTietHoaDon.TongTienHD(MaKH).ToString();
                }
                else
                {
                    btBo.Enabled = false;
                    btXemHD.Enabled = false;
                    tbTongTien.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLoaiThuoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            DataTable table = thuoc.ShowThuocTheoLoaiThuoc(cbLoaiThuoc.SelectedValue.ToString());
            cbThuoc.DataSource = table;
            cbThuoc.DisplayMember = "TenThuoc";
            cbThuoc.ValueMember = "MaThuoc";
            int SL = thuoc.LaySoLuongThuoc(cbThuoc.SelectedValue.ToString());
            nudSoLuong.Maximum = SL;
        }

        private void cbLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoaiThuoc.Text = "Chọn loại thuốc";
        }

        private void cbThuoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            int SL = thuoc.LaySoLuongThuoc(cbThuoc.SelectedValue.ToString());
            nudSoLuong.Maximum = SL;
        }

        private void btXemHD_Click(object sender, EventArgs e)
        {
            XemHoaDon xemHoaDon = new XemHoaDon();
            xemHoaDon.MaKH = MaKH;
            xemHoaDon.ShowDialog();
            this.Show();
        }
    }
}
