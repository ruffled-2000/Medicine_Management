using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Text.RegularExpressions;

namespace QuanLyTiemThuocDongY
{
    class KhachHang
    {
        Data da = new Data();
        public DataTable ShowKhachHang()
        {
            string sql = "select * from KhachHang";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public int LayMaKH()
        {
            string sql = "select DBO.LayMaKHVuaNhap()";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            int MaKH = int.Parse(table.Rows[0][0].ToString());
            return MaKH;
        }
        public void InsertKhachHang(string tenKH, int tuoi, string gioiTinh, string soDT, string diaChi)
        {
            string sql = "insert into KhachHang values(N'" + tenKH + "', " + tuoi + ", N'" + gioiTinh + "', '" + soDT + "', N'"+diaChi+"')";
            da.ExecuteNonQuery(sql);
        }
        public void DeleteKhachHang(string MaKH)
        {
            string sql = "delete from KhachHang where MaKH = '" + MaKH+"'";
            da.ExecuteNonQuery(sql);
        }
        public bool CheckKH(string MaKH)
        {
            string sql = "select dbo.KiemTraMaKH('" + MaKH + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
        public DataTable TimKiemKhachHang(string strTimKiem, string TimKiemTheo)
        {
            string sql = "select * from KhachHang where "+ TimKiemTheo + " like N'%"+ strTimKiem + "%'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public DataTable TimKiemMaKhachHang(string strTimKiem)
        {
            string sql = "select * from KhachHang where MaKH='" + strTimKiem + "'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public void UpdateKhachHang(string MaKH, string TenKH, int Tuoi, string gt, string soDT, string DiaChi)
        {
            string sql = "update KhachHang set TenKH=N'" + TenKH + "', Tuoi='" + Tuoi + "', GioiTinh=N'" + gt + "', SoDT='" + soDT + "', DiaChi=N'" + DiaChi + "' where MaKH='" + MaKH + "'";
            da.ExecuteNonQuery(sql);
        }
        public void CheckSDT(string SoDT)
        {
            if (Regex.Match(SoDT, @"^+\d{9,11}").Success == false)
            {
                Exception myEx = new Exception("Số điện thoại phải là số và có độ dài 9-11 số");
                throw myEx;
            }
        }
        public string ShowTenKH(int MaKH)
        {
            string sql = "select TenKH from KhachHang where MaKH = " + MaKH;
            DataTable table = new DataTable();
            table = da.getTable(sql);
            String TenKH = table.Rows[0][0].ToString();
            return TenKH;
        }
        public string ShowDiaChi(int MaKH)
        {
            string sql = "select DiaChi from KhachHang where MaKH = " + MaKH;
            DataTable table = new DataTable();
            table = da.getTable(sql);
            String DiaChi = table.Rows[0][0].ToString();
            return DiaChi;
        }
    }
}
