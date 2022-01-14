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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            rbNam.Checked = true;
            KhachHang khach = new KhachHang();
            DataTable table = new DataTable();
            table = khach.ShowKhachHang();
            dgvThongTinKhachHang.DataSource = table;
            cbTimKiemTheo.SelectedIndex = 0;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            

            int i = dgvThongTinKhachHang.CurrentCell.RowIndex;
            String MaKH = dgvThongTinKhachHang.Rows[i].Cells[0].Value.ToString();

            /*for (int i = 0; i < dgvThongTinKhachHang.RowCount; i++)
            {
                if (dgvThongTinKhachHang.Rows[i].Selected)
                {
                    string MaKH = dgvThongTinKhachHang.Rows[i].Cells[0].Value.ToString();
                    khachHang.DeleteKhachHang(MaKH);
                }
            }*/
            khachHang.DeleteKhachHang(MaKH);
            QuanLyKhachHang_Load(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập chuỗi tìm kiếm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTimKiemTheo.SelectedItem.ToString() == "Mã khách hàng")
            {
                KhachHang khachHang = new KhachHang();
                DataTable table = new DataTable();
                table = khachHang.TimKiemMaKhachHang(tbTimKiem.Text);
                dgvThongTinKhachHang.DataSource = table;
            }
            if (cbTimKiemTheo.SelectedItem.ToString() == "Tên khách hàng")
            {
                KhachHang khachHang = new KhachHang();
                DataTable table = new DataTable();
                table = khachHang.TimKiemKhachHang(tbTimKiem.Text, "TenKH");
                dgvThongTinKhachHang.DataSource = table;
            }
        }


        private void dgvThongTinKhachHang_DoubleClick(object sender, EventArgs e)
        {
            int i = dgvThongTinKhachHang.CurrentCell.RowIndex;
            tbMaKhachHang.Text = dgvThongTinKhachHang.Rows[i].Cells[0].Value.ToString();
            tbTenKhachHang.Text = dgvThongTinKhachHang.Rows[i].Cells[1].Value.ToString();
            tbTuoi.Text = dgvThongTinKhachHang.Rows[i].Cells[2].Value.ToString();
            string gt = dgvThongTinKhachHang.Rows[i].Cells[3].Value.ToString();
            if (gt == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            tbSoDT.Text = dgvThongTinKhachHang.Rows[i].Cells[4].Value.ToString();
            tbDiaChi.Text= dgvThongTinKhachHang.Rows[i].Cells[5].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang();
                if (tbTenKhachHang.Text == "")
                {
                    throw new Exception("Hãy điền thông tin!!");
                }
                string gt = "Nam";
                if (rbNu.Checked)
                    gt = "Nữ";
                int tuoi = int.Parse(tbTuoi.Text);
                khachHang.CheckSDT(tbSoDT.Text);
                khachHang.UpdateKhachHang(tbMaKhachHang.Text, tbTenKhachHang.Text, tuoi, gt, tbSoDT.Text, tbDiaChi.Text);
                QuanLyKhachHang_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin khách hàng muốn sửa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
