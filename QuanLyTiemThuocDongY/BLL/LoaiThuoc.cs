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
    class LoaiThuoc
    {
        Data da = new Data();
        public DataTable ShowLoaiThuoc()
        {
            string sql = "select * from LoaiThuoc";
            DataTable table = new DataTable();
            table = da.getTable(sql);
            return table;
        }
        public void InsertLoaiThuoc(string maLT, string tenLT)
        {
            string sql = "insert into LoaiThuoc values(N'" + maLT + "', N'" + tenLT + "')";
            da.ExecuteNonQuery(sql);
        }
        public void DeleteLoaiThuoc(string maLT)
        {
            string sql = "delete from LoaiThuoc where MaLT = '" + maLT + "'";
            da.ExecuteNonQuery(sql);
        }
        public void UpdateLoaiThuoc(string maLT, string tenLT)
        {
            string sql = "update LoaiThuoc set TenLT=N'" + tenLT + "' where MaLT = '" + maLT + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
