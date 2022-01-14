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
    public partial class QuanLyLoaiThuoc : Form
    {
        public QuanLyLoaiThuoc()
        {
            InitializeComponent();
        }


        private void QuanLyLoaiThuoc_Load(object sender, EventArgs e)
        {
            LoaiThuoc loaiThuoc = new LoaiThuoc();
            DataTable table = new DataTable();
            table = loaiThuoc.ShowLoaiThuoc();
            dgvLoaiThuoc.DataSource = table;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaTL.Text == "" || tbTenTL.Text == "")
                {
                    throw new Exception("Hãy nhập đầy đủ thông tin!");
                }
                LoaiThuoc loaiThuoc = new LoaiThuoc();
                loaiThuoc.InsertLoaiThuoc(tbMaTL.Text, tbTenTL.Text);
                QuanLyLoaiThuoc_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            LoaiThuoc loaiThuoc = new LoaiThuoc();
            int i = dgvLoaiThuoc.CurrentCell.RowIndex;
            String MaLT = dgvLoaiThuoc.Rows[i].Cells[0].Value.ToString();
            loaiThuoc.DeleteLoaiThuoc(MaLT);
            QuanLyLoaiThuoc_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaTL.Text == "" || tbTenTL.Text == "")
                {
                    throw new Exception("Hãy nhập đầy đủ thông tin!");
                }
                LoaiThuoc loaiThuoc = new LoaiThuoc();
                loaiThuoc.InsertLoaiThuoc(tbMaTL.Text, tbTenTL.Text);
                QuanLyLoaiThuoc_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoaiThuoc_DoubleClick(object sender, EventArgs e)
        {
            int i = dgvLoaiThuoc.CurrentCell.RowIndex;
            tbMaTL.Text = dgvLoaiThuoc.Rows[i].Cells[0].Value.ToString();
            tbTenTL.Text = dgvLoaiThuoc.Rows[i].Cells[1].Value.ToString();
        }

        private void pbQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
