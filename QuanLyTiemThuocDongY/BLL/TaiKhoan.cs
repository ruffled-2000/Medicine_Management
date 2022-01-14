using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace QuanLyTiemThuocDongY
{
    class TaiKhoan
    {
        Data da = new Data();
        public bool DangNhap(string TenDN, string MatKhau)
        {
            string sql = "select DBO.DangNhap('" + TenDN + "', '" + MatKhau + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
        public bool KiemTraTK(string TenDN)
        {
            string sql = "select DBO.KiemTraTaiKhoan('" + TenDN + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
        public DataTable ShowTaiKhoan(int LoaiTK)
        {
            string sql = "select TenDangNhap, Ten from TaiKhoan where Loai="+ LoaiTK;
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public void DeleteTaiKhoan(string TenDN)
        {
            string sql = "delete from TaiKhoan where TenDangNhap = '" + TenDN + "'";
            da.ExecuteNonQuery(sql);
        }
        public void InsertTaiKhoan(string TenDN, string MK, string Ten, int Loai)
        {
            string sql = "insert into TaiKhoan values('" + TenDN + "', '" + MK + "', N'" + Ten + "', " + Loai+")";
            da.ExecuteNonQuery(sql);
        }
        public bool KiemTraMatKhau(string TenDN, string MatKhau)
        {
            string sql = "select dbo.KiemTraMK('" + TenDN + "', '" + MatKhau + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
        public void UpdateTaiKhoan(string TenDN, string MatKhau)
        {
            string sql = "update TaiKhoan set MatKhau ='" + MatKhau + "' where TenDangNhap ='" + TenDN + "'";
            da.ExecuteNonQuery(sql);
        }
        public bool LoaiTaiKhoan(string TenDangNhap)
        {
            string sql = "select Loai from TaiKhoan where TenDangNhap='"+TenDangNhap+"'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
    }
}
