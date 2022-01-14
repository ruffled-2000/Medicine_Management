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
    class HoaDon
    {
        Data da = new Data();
        public void InsertHoaDon(int maKH, string ngayTao)
        {
            string sql = "insert into HoaDon values(" + maKH + ", '" + ngayTao + "')";
            da.ExecuteNonQuery(sql);
        }
        public int LayMaHD()
        {
            string sql = "select DBO.LayMaHDVuaNhap()";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            int MaHD = int.Parse(table.Rows[0][0].ToString());
            return MaHD;
        }
        public void DeleteHoaDon(string MaHD)
        {
            string sql = "delete from HoaDon where MaHD='" + MaHD + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
