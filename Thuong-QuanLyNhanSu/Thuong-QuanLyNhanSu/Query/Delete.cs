using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Delete
    {
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();
        private static List<string> list = new List<string>();
        public static class NHANVIEN
        {
            public static bool DeleteRecord_Primary(int _MANV)
            {
                try
                {
                    cmd.CommandText = @"delete from NHANVIEN where MANV = " + _MANV;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // Không thể xoá bản ghi do có kết nối khác đến bản ghi
                    // MessageBox.Show("Cant delete record!\nCause the record has connected to another record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool DeleteRecord_Primary(string _ACCOUNT)
            {
                try
                {
                    cmd.CommandText = @"delete from TAIKHOAN where ACCOUNT = N'" + _ACCOUNT + "'";
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHANCONG
        {
            public static bool DeleteRecord_Primary(int _MANV, int _MADA)
            {
                try
                {
                    cmd.CommandText = @"delete from PHANCONG where MANV = " + _MANV + " and MADA = " + _MADA;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }

            public static bool DeleteAllRecord_HaveTableX(MyStruct.PHANCONG.enumStruct e, string _value)
            {
                try
                {
                    cmd.CommandText = @"delete from PHANCONG where ";
                    switch (e)
                    {
                        case MyStruct.PHANCONG.enumStruct.MANV:
                            cmd.CommandText += @"MANV = " + int.Parse(_value);
                            break;
                        case MyStruct.PHANCONG.enumStruct.MADA:
                            cmd.CommandText += @"MADA = " + int.Parse(_value);
                            break;
                        case MyStruct.PHANCONG.enumStruct.SOGIO:
                            cmd.CommandText += @"SOGIO = " + float.Parse(_value);
                            break;
                        default:
                            return false;
                    }


                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static bool DeleteRecord_Primary(int _MAPB)
            {
                try
                {
                    cmd.CommandText = @"delete from PHONGBAN where MAPB = " + _MAPB;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class DUAN
        {
            public static bool DeleteRecord_Primary(int _MADA)
            {
                try
                {
                    cmd.CommandText = @"delete from DUAN where MADA = " + _MADA;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class LUONG
        {
            public static bool DeleteRecord_Primary(int _BACLUONG)
            {
                try
                {
                    cmd.CommandText = @"delete from LUONG where BACLUONG = " + _BACLUONG;
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch
                {
                    // MessageBox.Show("Cant delete record!");
                    conn.Close();
                    return false;
                }
            }
        }

    }
}
