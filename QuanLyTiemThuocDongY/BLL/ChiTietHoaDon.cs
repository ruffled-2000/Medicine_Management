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
    class ChiTietHoaDon
    {
        Data da = new Data();
        public DataTable ShowChiTietHoaDon(int MaKH)
        {
            string sql = "select HoaDon.MaHD, Thuoc.MaThuoc, TenThuoc, GiaThuoc, TenLT, SoLuong, SoLuong*GiaThuoc as 'Thành tiền' from ChiTietHD inner join HoaDon on ChiTietHD.MaHD = HoaDon.MaHD inner join Thuoc on ChiTietHD.MaThuoc = Thuoc.MaThuoc, KhachHang, LoaiThuoc where HoaDon.MaKH = KhachHang.MaKH and Thuoc.MaLT = LoaiThuoc.MaLT and KhachHang.MaKH ="+MaKH+"";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public DataTable ShowHoaDon(int MaKH)
        {
            string sql = "select Thuoc.MaThuoc, TenThuoc, GiaThuoc, TenLT, SoLuong, SoLuong*GiaThuoc as 'Thành tiền' from ChiTietHD inner join HoaDon on ChiTietHD.MaHD = HoaDon.MaHD inner join Thuoc on ChiTietHD.MaThuoc = Thuoc.MaThuoc, KhachHang, LoaiThuoc where HoaDon.MaKH = KhachHang.MaKH and Thuoc.MaLT = LoaiThuoc.MaLT and KhachHang.MaKH =" + MaKH + "";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public void InsertChiTietHoaDon(string MaThuoc, int MaHD, int SoLuong)
        {
            string sql = "insert into ChiTietHD values('" + MaThuoc + "', " + MaHD + ", " + SoLuong + ")";
            da.ExecuteNonQuery(sql);
        }
        public void DeleteChiTietHoaDon(int MaHD)
        {
            string sql = "delete from ChiTietHD where MaHD =" + MaHD + "";
            da.ExecuteNonQuery(sql);
        }
        public float TongTienHD(int MaKH)
        {
            string sql = "select dbo.TinhTien("+MaKH+")";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            float TongTien = float.Parse(table.Rows[0][0].ToString());
            return TongTien;
        }
        public DataTable ThongKeHD(string NgayX, string NgayY)
        {
            string sql = "select * from DBO.ThongKe('" + NgayX + "', '" + NgayY + "')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public float TongTienTK(string NgayX, string NgayY)
        {
            string sql = "select dbo.TongTienThongKe('"+NgayX+"', '"+NgayY+"')";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            float TongTien = float.Parse(table.Rows[0][0].ToString());
            return TongTien;
        }
    }
}
