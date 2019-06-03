using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhanSu.GUI
{
    public partial class SQLServer
    {
        /// Data Source=DESKTOP-L2250;Initial Catalog=ThucTapNhom;Integrated Security=True
        public static SqlConnection GetMySQL()
        {
            return new SqlConnection(@"Data Source=DESKTOP-L2250;Initial Catalog=QuanLyNhanVien;Integrated Security=True");
        }
        public static SqlConnection GetSQL(string _source, string _nameDatabase)
        {
            return new SqlConnection(@"Data Source=" + _source + ";Initial Catalog=" + _nameDatabase + ";Integrated Security=True");
        }
    }
}
