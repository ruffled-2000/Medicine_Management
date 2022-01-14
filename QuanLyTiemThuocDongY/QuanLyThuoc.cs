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
    public partial class QuanLyThuoc : Form
    {
        public QuanLyThuoc()
        {
            InitializeComponent();
        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            DataTable table = new DataTable();
            table = thuoc.ShowThuoc();
            dgvThongTinThuoc.DataSource = table;
            LoaiThuoc loaiThuoc = new LoaiThuoc();
            DataTable tableLT = loaiThuoc.ShowLoaiThuoc();
            cbLoaiThuoc.DataSource = tableLT;
            cbLoaiThuoc.DisplayMember = "TenLT";
            cbLoaiThuoc.ValueMember = "MaLT";
            cbTimKiemTheo.SelectedIndex = 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc thuoc = new Thuoc();
                if (thuoc.CheckMaThuoc(tbMaThuoc.Text) == true)
                {
                    MessageBox.Show("Mã thuốc đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbMaThuoc.Text == "")
                        throw new Exception("Hãy nhập thông tin thuốc cần sửa");
                    thuoc.InsertThuoc(tbMaThuoc.Text, tbTenThuoc.Text, float.Parse(tbGia.Text), int.Parse(tbSoLuong.Text), cbLoaiThuoc.SelectedValue.ToString());
                    QuanLyThuoc_Load(sender, e);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là nguyên và giá phải là thực!!" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                Thuoc thuoc = new Thuoc();
                if (tbMaThuoc.Text == "")
                    throw new Exception("Hãy nhập thông tin thuốc cần sửa");
                thuoc.UpdateThuoc(tbMaThuoc.Text, tbTenThuoc.Text, float.Parse(tbGia.Text), int.Parse(tbSoLuong.Text), cbLoaiThuoc.SelectedValue.ToString());
                QuanLyThuoc_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là nguyên và giá phải là thực!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc();
            int i = dgvThongTinThuoc.CurrentCell.RowIndex;
            String MaT = dgvThongTinThuoc.Rows[i].Cells[0].Value.ToString();
            thuoc.DeleteThuoc(MaT);
            QuanLyThuoc_Load(sender, e);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbMaThuoc.Clear();
            tbTenThuoc.Clear();
            tbSoLuong.Clear();
            tbGia.Clear(); ;
            tbTimKiem.Clear();
            QuanLyThuoc_Load(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Hãy nhập chuỗi tìm kiếm!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbTimKiemTheo.SelectedItem.ToString() == "Mã thuốc")
            {
                Thuoc thuoc = new Thuoc();
                DataTable table = new DataTable();
                table = thuoc.TimKiemTheoMaThuoc(tbTimKiem.Text);
                dgvThongTinThuoc.DataSource = table;
            }
            if (cbTimKiemTheo.SelectedItem.ToString() == "Tên thuốc")
            {
                Thuoc thuoc = new Thuoc();
                DataTable table = new DataTable();
                table = thuoc.TimKiemThuoc(tbTimKiem.Text, "TenThuoc");
                dgvThongTinThuoc.DataSource = table;
            }
            if (cbTimKiemTheo.SelectedItem.ToString() == "Loại thuốc")
            {
                Thuoc thuoc = new Thuoc();
                DataTable table = new DataTable();
                table = thuoc.TimKiemThuoc(tbTimKiem.Text, "TenLT");
                dgvThongTinThuoc.DataSource = table;
            }
        }

        private void dgvThongTinThuoc_DoubleClick(object sender, EventArgs e)
        {
            int i = dgvThongTinThuoc.CurrentCell.RowIndex;
            tbMaThuoc.Text = dgvThongTinThuoc.Rows[i].Cells[0].Value.ToString();
            tbTenThuoc.Text = dgvThongTinThuoc.Rows[i].Cells[1].Value.ToString();
            tbGia.Text = dgvThongTinThuoc.Rows[i].Cells[2].Value.ToString();
            tbSoLuong.Text = dgvThongTinThuoc.Rows[i].Cells[3].Value.ToString();
        }

        private void pbQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
