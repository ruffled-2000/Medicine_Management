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
    class Thuoc
    {
        Data da = new Data();
        public DataTable ShowThuoc()
        {
            string sql = "select MaThuoc, TenThuoc, GiaThuoc, SoLuongT, TenLT from Thuoc inner join LoaiThuoc on Thuoc.MaLT=LoaiThuoc.MaLT";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public DataTable ShowThuocTheoLoaiThuoc(string MaLT)
        {
            string sql = "select MaThuoc, TenThuoc from Thuoc inner join LoaiThuoc on Thuoc.MaLT=LoaiThuoc.MaLT where Thuoc.MaLT = "+MaLT;
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public DataTable TimKiemThuoc(string strTimKiem, string TimKiemTheo)
        {
            string sql = "select Thuoc.MaThuoc, TenThuoc, GiaThuoc, SoLuongT, TenLT from Thuoc inner join LoaiThuoc on Thuoc.MaLT = LoaiThuoc.MaLT where "+ TimKiemTheo + " like N'%"+ strTimKiem + "%'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public DataTable TimKiemTheoMaThuoc(string MaT)
        {
            string sql = "select Thuoc.MaThuoc, TenThuoc, GiaThuoc, SoLuongT, TenLT from Thuoc inner join LoaiThuoc on Thuoc.MaLT = LoaiThuoc.MaLT where MaThuoc= '" + MaT + "'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public void InsertThuoc(string maThuoc , string tenThuoc, float giaThuoc, int SoLuongT, string maLT)
        {
            string sql = "insert into Thuoc values('"+maThuoc+"', N'"+tenThuoc+"','"+giaThuoc+"','"+SoLuongT+"','"+maLT+"')";
            da.ExecuteNonQuery(sql);
        }
        public void DeleteThuoc(string maThuoc)
        {
            string sql = "delete from Thuoc where MaThuoc ='" + maThuoc + "'";
            da.ExecuteNonQuery(sql);
        }
        public void UpdateThuoc(string maThuoc, string tenThuoc, float giaThuoc, int SoLuongT, string maLT)
        {
            string sql = "update Thuoc set TenThuoc=N'" + tenThuoc + "', GiaThuoc='" + giaThuoc + "',SoLuongT='" + SoLuongT + "', MaLT='" + maLT + "' where MaThuoc='" + maThuoc + "'";
            da.ExecuteNonQuery(sql);
        }
        public int LaySoLuongThuoc(string MaThuoc)
        {
            string sql = "select SoLuongT from Thuoc where MaThuoc ='" + MaThuoc+"'";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            int SoLuong = int.Parse(table.Rows[0][0].ToString());
            return SoLuong;
        }
        public bool CheckKH(string MaKH)
        {
            string sql = "select dbo.KiemTraMaKH('" + MaKH + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
        public bool CheckMaThuoc(string MaThuoc)
        {
            string sql = "select dbo.KiemTraMaThuoc('" + MaThuoc + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            bool check = bool.Parse(table.Rows[0][0].ToString());
            return check;
        }
    }
}
