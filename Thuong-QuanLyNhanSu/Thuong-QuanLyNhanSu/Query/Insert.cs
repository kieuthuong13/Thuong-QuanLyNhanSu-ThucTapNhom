using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Insert
    {
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();
        public static class DUAN
        {
            public static int GetNextIndex()
            {
                SqlConnection t = SQLServer.GetMySQL();
                SqlCommand cm = new SqlCommand(
                    @"select top 1 MAX(MADA) as STTCAONHAT from DUAN order by STTCAONHAT desc");

                cm.Connection = t;
                t.Open();

                int tam = (int)cm.ExecuteScalar() + 1;
                t.Close();

                return tam;
            }
            public static bool CreateNewRecord(MyStruct.DUAN _new)
            {
                try
                {
                    string tam1 = @"insert into DUAN (MADA", tam2 = "";
                    if (_new.MAPB != null)
                    {
                        tam1 += @", MAPB";
                        tam2 += @", " + _new.MAPB;
                    }
                    if (!string.IsNullOrEmpty(_new.TENDA))
                    {
                        tam1 += @", TENDA";
                        tam2 += @", N'" + _new.TENDA + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.DIADIEM))
                    {
                        tam1 += @", DIADIEM";
                        tam2 += @", N'" + _new.DIADIEM + "'";
                    }
                    if (_new.TONGSOGIO != null)
                    {
                        tam1 += @", TONGSOGIO";
                        tam2 += @", " + _new.TONGSOGIO;
                    }
                    tam1 += @") values (" + _new.MADA + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
                
            }
        }
        public static class LUONG
        {
            public static int GetNextIndex()
            {
                SqlConnection t = SQLServer.GetMySQL();
                SqlCommand cm = new SqlCommand(
                    @"select top 1 MAX(BACLUONG) as STTCAONHAT from LUONG order by STTCAONHAT desc");

                cm.Connection = t;
                t.Open();

                int tam = (int)cm.ExecuteScalar() + 1;
                t.Close();

                return tam;
            }
            public static bool CreateNewRecord(MyStruct.LUONG _new)
            {
                try
                {
                    string tam1 = @"insert into LUONG (BACLUONG";
                    string tam2 = "";
                    if (_new.LUONGCOBAN != null)
                    {
                        tam1 += @", LUONGCOBAN";
                        tam2 += @", " + _new.LUONGCOBAN;
                    }
                    if (_new.HESOLUONG != null)
                    {
                        tam1 += @", HESOLUONG";
                        tam2 += @", " + _new.HESOLUONG + "";
                    }
                    if (_new.HESOPHUCAP != null)
                    {
                        tam1 += @", HESOPHUCAP";
                        tam2 += @", " + _new.HESOPHUCAP + "";
                    }
                    tam1 += @") values (" + _new.BACLUONG + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class NHANVIEN
        {
            public static int GetNextIndex()
            {
                SqlConnection t = SQLServer.GetMySQL();
                SqlCommand cm = new SqlCommand(
                    @"select top 1 MAX(MANV) as STTCAONHAT from NHANVIEN order by STTCAONHAT desc");

                cm.Connection = t;
                t.Open();

                int tam = (int)cm.ExecuteScalar() + 1;
                t.Close();

                return tam;
            }
            public static bool CreateNewRecord(MyStruct.NHANVIEN _new)
            {
                try
                {
                    _new.MANV = GetNextIndex();
                    string tam1 = @"insert into NHANVIEN (MANV", tam2 = "";
                    if (_new.MAPB != null)
                    {
                        tam1 += @", MAPB";
                        tam2 += @", " + _new.MAPB;
                    }
                    if (!string.IsNullOrEmpty(_new.TENNV))
                    {
                        tam1 += @", TENNV";
                        tam2 += @", N'" + _new.TENNV + "'";
                    }
                    if (_new.NGAYSINH != null)
                    {
                        tam1 += @", NGAYSINH";
                        tam2 += @", N'" + (DateTime.Parse(_new.NGAYSINH.ToString())).ToShortDateString() + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.GIOITINH))
                    {
                        tam1 += @", GIOITINH";
                        tam2 += @", N'" + _new.GIOITINH + "'";
                    }
                    if (_new.MA_NGS != null)
                    {
                        tam1 += @", MA_NGS";
                        tam2 += @", " + _new.MA_NGS;
                    }
                    if (_new.BACLUONG != null)
                    {
                        tam1 += @", BACLUONG";
                        tam2 += @", " + _new.BACLUONG;
                    }
                    if (!string.IsNullOrEmpty(_new.DIACHI))
                    {
                        tam1 += @", DIACHI";
                        tam2 += @", N'" + _new.DIACHI + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.ACCOUNT))
                    {
                        tam1 += @", ACCOUNT";
                        tam2 += @", N'" + _new.ACCOUNT + "'";
                    }

                    tam1 += ") values (" + _new.MANV + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
    }
        }
        public static class PHANCONG
        {
            public static bool CreateNewRecord(MyStruct.PHANCONG _new)
            {
                try
                {
                    string tam1 = @"insert into PHANCONG (MANV, MADA", tam2 = "";
                    if (_new.SOGIO != null)
                    {
                        tam1 += @", SOGIO";
                        tam2 += @", " + _new.SOGIO;
                    }
                    tam1 += ") values (" + _new.MANV + "," + _new.MADA + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static int GetNextIndex()
            {
                SqlConnection t = SQLServer.GetMySQL();
                SqlCommand cm = new SqlCommand(
                    @"select top 1 MAX(MAPB) as STTCAONHAT from PHONGBAN order by STTCAONHAT desc");

                cm.Connection = t;
                t.Open();

                int tam = (int)cm.ExecuteScalar() + 1;
                t.Close();

                return tam;
            }
            public static bool CreateNewRecord(MyStruct.PHONGBAN _new)
            {
                try
                {
                    string tam1 = @"insert into PHONGBAN (MAPB", tam2 = "";
                    if (!string.IsNullOrEmpty(_new.TENPB))
                    {
                        tam1 += @", TENPB";
                        tam2 += @", N'" + _new.TENPB + "'";
                    }
                    if (_new.MATP != null)
                    {
                        tam1 += @", MATP";
                        tam2 += @", " + _new.MATP;
                    }
                    if (!string.IsNullOrEmpty(_new.DIADIEM))
                    {
                        tam1 += @", DIADIEM";
                        tam2 += @", N'" + _new.DIADIEM + "'";
                    }
                    if (_new.NGAYNC != null)
                    {
                        tam1 += @", NGAYNC";
                        tam2 += @", N'" + (DateTime.Parse(_new.NGAYNC.ToString())).ToShortDateString() + "'";
                    }
                    tam1 += ") values (" + _new.MAPB + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool CreateNewRecord(MyStruct.TAIKHOAN _new)
            {
                try
                {
                    string tam1 = @"insert into TAIKHOAN (ACCOUNT", tam2 = "";
                    if (!string.IsNullOrEmpty(_new.PASSWORD))
                    {
                        tam1 += @", PASSWORD";
                        tam2 += @", N'" + _new.PASSWORD + "'";
                    }
                    if (!string.IsNullOrEmpty(_new.ACCESS))
                    {
                        tam1 += @", ACCESS";
                        tam2 += @", N'" + _new.ACCESS + "'";
                    }
                    tam1 += ") values (" + _new.ACCOUNT + tam2 + ")";

                    cmd.CommandText = tam1;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant create new record!");
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
