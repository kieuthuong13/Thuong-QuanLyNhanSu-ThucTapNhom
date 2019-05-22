using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class Update
    {
        private static List<string> list = new List<string>();
        private static SqlConnection conn = SQLServer.GetMySQL();
        private static SqlCommand cmd = new SqlCommand();

        /// <summary>
        /// 
        /// Do nothing without Add string to string
        /// exaple:
        ///     _root = "update DUAN set "
        ///     list[0] = "MADA = value"
        ///     list[1] = "MAPB = value"
        ///     ...
        ///     _where = "where MANV = value"
        ///     return -> "update DUAN set MADA = value, MAPB = value where MANV = value"
        /// 
        /// </summary>
        /// <param name="_root"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        private static string Query_AddString(string _root, string _where, ref List<string> list)
        {
            int index = list.Count;
            int i = 0;
            while ( i < index )
            {
                _root += @" " + list[i];
                if (i < index - 1 && list[i] != null)
                {
                    _root += @",";
                }
                ++i;
            }
            _root += @" " + _where;
            return _root;
        }
        public static class DUAN
        {
            public static bool UpdateAllRecord_HaveTable(MyStruct.DUAN.enumStruct _NameTable, string _Value)
            {
                try
                {
                    switch (_NameTable)
                    {
                        case MyStruct.DUAN.enumStruct.MADA:
                        case MyStruct.DUAN.enumStruct.MAPB:
                        case MyStruct.DUAN.enumStruct.TONGSOGIO:
                            cmd.CommandText = @"update DUAN set " + _NameTable + " = " + _Value;

                            break;

                        case MyStruct.DUAN.enumStruct.TENDA:
                        case MyStruct.DUAN.enumStruct.DIADIEM:
                            cmd.CommandText = @"update NHANVIEN set " + _NameTable + " = N'" + _Value + "'";
                            break;

                        default:
                            return false;
                    }
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
            public static bool UpdateOneRecord(MyStruct.DUAN _newValue)
            {
                try
                {
                    list.Clear();
                    list.Add(_newValue.MAPB != null ? "MAPB = " + _newValue.MAPB.ToString() : null);
                    list.Add(_newValue.TENDA != null ? "TENDA = N'"+_newValue.TENDA.ToString() + "'" : null);
                    list.Add(_newValue.DIADIEM != null ? "DIADIEM = N'" + _newValue.DIADIEM.ToString() + "'" : null);
                    list.Add(_newValue.TONGSOGIO != null ? "TONGSOGIO = " + _newValue.TONGSOGIO.ToString() : null);
                    
                    cmd.CommandText = Query_AddString(
                        @"update DUAN set",
                        @"where MADA = " + _newValue.MADA,
                        ref list);

                    //cmd.CommandText
                    //    = @"update DUAN set MAPB = " + _newValue.MAPB
                    //    + ", TENDA = N'" + _newValue.TENDA + "'"
                    //    + ", DIADIEM = N'" + _newValue.DIADIEM + "'"
                    //    + ", TONGSOGIO = " + _newValue.TONGSOGIO
                    //    + " where MADA = " + _newValue.MADA;
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class LUONG
        {
            public static bool UpdateOneRecord(MyStruct.LUONG _newValue)
            {
                try
                {
                    //cmd.CommandText
                    //    = @"update LUONG set LUONGCOBAN = " + _newValue.LUONGCOBAN
                    //    + ", HESOLUONG = " + _newValue.HESOLUONG
                    //    + ", HESOPHUCAP = " + _newValue.HESOPHUCAP
                    //    + " where BACLUONG = " + _newValue.BACLUONG;

                    list.Clear();
                    list.Add(_newValue.LUONGCOBAN != null ? "LUONGCOBAN = " + _newValue.LUONGCOBAN.ToString() : null);
                    list.Add(_newValue.HESOLUONG != null ? "HESOLUONG = " + _newValue.HESOLUONG.ToString() : null);
                    list.Add(_newValue.HESOPHUCAP != null ? "HESOPHUCAP = " + _newValue.HESOPHUCAP.ToString() : null);

                    cmd.CommandText = Query_AddString(
                        @"update LUONG set",
                        @"where BACLUONG = " + _newValue.BACLUONG,
                        ref list);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class NHANVIEN
        {
            public static bool UpdateAllRecord_HaveTableX(MyStruct.NHANVIEN.enumStruct _NameTable, string _Value)
            {
                try
                {
                    switch (_NameTable)
                    {
                        case MyStruct.NHANVIEN.enumStruct.MANV:
                        case MyStruct.NHANVIEN.enumStruct.MAPB:
                        case MyStruct.NHANVIEN.enumStruct.MA_NGS:
                        case MyStruct.NHANVIEN.enumStruct.BACLUONG:
                            cmd.CommandText = @"update NHANVIEN set " + _NameTable + " = " + _Value;
                            break;

                        case MyStruct.NHANVIEN.enumStruct.TENNV:
                        case MyStruct.NHANVIEN.enumStruct.GIOITINH:
                        case MyStruct.NHANVIEN.enumStruct.DIACHI:
                        case MyStruct.NHANVIEN.enumStruct.ACCOUNT:
                        case MyStruct.NHANVIEN.enumStruct.NGAYSINH:
                            cmd.CommandText = @"update NHANVIEN set " + _NameTable + " = N'" + _Value + "'";
                            break;

                        default:
                            return false;
                    }
                    

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
            public static bool UpdateOneRecord(MyStruct.NHANVIEN _newValue)
            {
                try
                {
                    //cmd.CommandText
                    //    = @"update NHANVIEN set MAPB = " + _newValue.MAPB
                    //    + ", TENNV = N'" + _newValue.TENNV + "'"
                    //    + ", NGAYSINH = N'" + (DateTime.Parse(_newValue.NGAYSINH.ToString())).ToShortDateString().ToString() + "'"
                    //    + ", GIOITINH = N'" + _newValue.GIOITINH + "'"
                    //    + ", MA_NGS = " + _newValue.MA_NGS
                    //    + ", BACLUONG = " + _newValue.BACLUONG
                    //    + ", DIACHI = N'" + _newValue.DIACHI + "'"
                    //    + ", ACCOUNT = N'" + _newValue.ACCOUNT + "'"
                    //    + " where MANV = " + _newValue.MANV;

                    list.Clear();

                    list.Add(_newValue.MAPB != null ? "MAPB = " + _newValue.MAPB.ToString() : null);
                    list.Add(_newValue.TENNV != null ? "TENNV = N'" + _newValue.TENNV.ToString() + "'": null);
                    list.Add(_newValue.NGAYSINH != null ? "NGAYSINH = N'" + _newValue.ToString(MyStruct.NHANVIEN.enumStruct.NGAYSINH) + "'" : null);
                    list.Add(_newValue.GIOITINH != null ? "GIOITINH = N'" + _newValue.GIOITINH.ToString() +"'" : null);
                    list.Add(_newValue.MA_NGS != null ? "MA_NGS = " + _newValue.MA_NGS.ToString() : null);
                    list.Add(_newValue.BACLUONG != null ? "BACLUONG = " + _newValue.BACLUONG.ToString() : null);
                    list.Add(_newValue.DIACHI != null ? "DIACHI = N'" + _newValue.DIACHI.ToString() + "'": null);
                    list.Add(_newValue.ACCOUNT != null ? "ACCOUNT = N'" + _newValue.ACCOUNT.ToString() + "'": null);

                    cmd.CommandText = Query_AddString(
                        @"update NHANVIEN set",
                        @"where MANV = " + _newValue.MANV,
                        ref list);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;

                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHANCONG
        {
            public static bool UpdateOneRecord(MyStruct.PHANCONG _newValue)
            {
                try
                {
                    list.Clear();

                    list.Add(_newValue.SOGIO != null ? "SOGIO = " + _newValue.SOGIO.ToString() : null);

                    //cmd.CommandText
                    //    = @"update PHANCONG set SOGIO = " + _newValue.SOGIO
                    //    + " where MANV = " + _newValue.MANV
                    //    + " and MADA = " + _newValue.MADA;

                    cmd.CommandText = Query_AddString(
                        @"update PHANCONG set",
                        @"where MANV = " + _newValue.MANV + "and MADA = " + _newValue.MADA,
                        ref list);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class PHONGBAN
        {
            public static bool UpdateOneRecord(MyStruct.PHONGBAN _newValue)
            {
                try
                {
                    //cmd.CommandText
                    //    = @"update PHONGBAN set TENPB = N'" + _newValue.TENPB + "'"
                    //    + ", MATP = " + _newValue.MATP
                    //    + ", DIADIEM = N'" + _newValue.DIADIEM + "'"
                    //    + ", NGAYNC = N'" + (DateTime.Parse(_newValue.NGAYNC.ToString())).ToShortDateString().ToString() + "'"
                    //    + " where MAPB = " + _newValue.MAPB;

                    list.Clear();

                    list.Add(_newValue.TENPB != null ? "TENPB = N'" + _newValue.TENPB.ToString() + "'": null);
                    list.Add(_newValue.MATP != null ? "MATP = " + _newValue.MATP.ToString() : null);
                    list.Add(_newValue.DIADIEM != null ? "DIADIEM = N'" + _newValue.DIADIEM.ToString() + "'": null);
                    list.Add(_newValue.NGAYNC != null ? "NGAYNC = N'" + _newValue.ToString(MyStruct.PHONGBAN.enumStruct.NGAYNC) + "'" : null);

                    cmd.CommandText = Query_AddString(
                        @"update PHONGBAN set",
                        @"where MAPB = " + _newValue.MAPB,
                        ref list);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
        public static class TAIKHOAN
        {
            public static bool UpdateOneRecord(MyStruct.TAIKHOAN _newValue)
            {
                try
                {
                    //cmd.CommandText
                    //    = @"update TAIKHOAN set ACCESS = N'" + _newValue.ACCESS + "'"
                    //    + ", PASSWORD = N'" + _newValue.PASSWORD + "'"
                    //    + " where ACCOUNT = N'" + _newValue.ACCOUNT + "'";

                    list.Clear();

                    list.Add(_newValue.ACCESS != null ? "ACCESS = N'" + _newValue.ACCESS.ToString() + "'": null);
                    list.Add(_newValue.PASSWORD != null ? "PASSWORD = N'" + _newValue.PASSWORD.ToString() + "'": null);

                    cmd.CommandText = Query_AddString(
                        @"update TAIKHOAN set",
                        @" where ACCOUNT = N'" + _newValue.ACCOUNT + "'",
                        ref list);

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Cant update!");
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
