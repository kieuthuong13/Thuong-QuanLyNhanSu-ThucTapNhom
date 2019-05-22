using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.GUI
{
    public partial class MyStruct
    {
        public enum MyTableName
        {
            DUAN,
            LUONG,
            NHANVIEN,
            PHANCONG,
            PHONGBAN,
            TAIKHOAN,

        }
        public class DUAN
        {
            //[MADA] [int] NOT NULL,
	        //[MAPB] [int] NULL,
	        //[TENDA] [nvarchar](50) NULL,
	        //[DIADIEM] [nvarchar](50) NULL,
	        //[TONGSOGIO] [float] NULL,
            public int MADA { get; set; }
            public int? MAPB { get; set; }
            public string TENDA { get; set; }
            public string DIADIEM { get; set; }
            public float? TONGSOGIO { get; set; }
            public enum enumStruct
            {
                MADA,
                MAPB,
                TENDA,
                DIADIEM,
                TONGSOGIO,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.MADA:
                        return MADA.ToString();
                    case enumStruct.MAPB:
                        return MAPB.ToString();
                    case enumStruct.TENDA:
                        return TENDA.ToString();
                    case enumStruct.DIADIEM:
                        return DIADIEM.ToString();
                    case enumStruct.TONGSOGIO:
                        return TONGSOGIO.ToString();
                    default:
                        return "";
                }     
            }
        }
        public class LUONG
        {
            //[BACLUONG] [int] NOT NULL,
            //[LUONGCOBAN] [int] NULL,
            //[HESOLUONG] [float] NULL,
            //[HESOPHUCAP] [float] NULL,
            public int BACLUONG { get; set; }
            public int? LUONGCOBAN { get; set; }
            public float? HESOLUONG { get; set; }
            public float? HESOPHUCAP { get; set; }
            public enum enumStruct
            {
                BACLUONG,
                LUONGCOBAN,
                HESOLUONG,
                HESOPHUCAP,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.BACLUONG:
                        return BACLUONG.ToString();
                    case enumStruct.LUONGCOBAN:
                        return LUONGCOBAN.ToString();
                    case enumStruct.HESOLUONG:
                        return HESOLUONG.ToString();
                    case enumStruct.HESOPHUCAP:
                        return HESOPHUCAP.ToString();
                    default:
                        return "";
                }
            }
        }
        public class NHANVIEN
        {
            //   [MANV] [int] NOT NULL,
            //[MAPB] [int] NULL,
            //[TENNV] [nvarchar](50) NULL,
            //[NGAYSINH] [date] NULL,
            //[GIOITINH] [nvarchar](50) NULL,
            //[MA_NGS] [int] NULL,
            //[BACLUONG] [int] NULL,
            //[DIACHI] [nvarchar](50) NULL,
            //[ACCOUNT] [varchar](50) NULL,
            public int MANV { get; set; }
            public int? MAPB { get; set; }
            public string TENNV { get; set; }
            public DateTime? NGAYSINH { get; set; }
            public string GIOITINH { get; set; }
            public int? MA_NGS { get; set; }
            public int? BACLUONG { get; set; }
            public string DIACHI { get; set; }
            public string ACCOUNT { get; set; }
            public enum enumStruct
            {
                MANV,
                MAPB,
                TENNV,
                NGAYSINH,
                GIOITINH,
                MA_NGS,
                BACLUONG,
                DIACHI,
                ACCOUNT,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.MANV:
                        return MANV.ToString();
                    case enumStruct.MAPB:
                        return MAPB.ToString();
                    case enumStruct.TENNV:
                        return TENNV.ToString();
                    case enumStruct.NGAYSINH:
                        return DateTime.Parse(NGAYSINH.ToString()).ToShortDateString();
                    case enumStruct.GIOITINH:
                        return GIOITINH.ToString();
                    case enumStruct.MA_NGS:
                        return MA_NGS.ToString();
                    case enumStruct.BACLUONG:
                        return BACLUONG.ToString();
                    case enumStruct.DIACHI:
                        return DIACHI.ToString();
                    case enumStruct.ACCOUNT:
                        return ACCOUNT.ToString();
                    default:
                        return "";
                }
            }
        }
        public class PHANCONG
        {
            //[MANV] [int] NOT NULL,
            //	[MADA] [int] NOT NULL,
            //	[SOGIO] [float] NULL,
            public int MANV { get; set; }
            public int MADA { get; set; }
            public float? SOGIO { get; set; }
            public enum enumStruct
            {
                MANV,
                MADA,
                SOGIO,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.MANV:
                        return MANV.ToString();
                    case enumStruct.MADA:
                        return MADA.ToString();
                    case enumStruct.SOGIO:
                        return SOGIO.ToString();
                    default:
                        return "";
                }
            }
        }
        public class PHONGBAN
        {
            //[MAPB] [int] NOT NULL,
            //[TENPB] [nvarchar](50) NULL,
            //[MATP] [int] NULL,
            //[DIADIEM] [nvarchar](50) NULL,
            //[NGAYNC] [date] NULL,
            public int MAPB { get; set; }
            public string TENPB { get; set; }
            public int? MATP { get; set; }
            public string DIADIEM { get; set; }
            public DateTime? NGAYNC { get; set; }
            public enum enumStruct
            {
                MAPB,
                TENPB,
                MATP,
                DIADIEM,
                NGAYNC,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.MAPB:
                        return MAPB.ToString();
                    case enumStruct.TENPB:
                        return TENPB.ToString();
                    case enumStruct.MATP:
                        return MATP.ToString();
                    case enumStruct.DIADIEM:
                        return DIADIEM.ToString();
                    case enumStruct.NGAYNC:
                        return DateTime.Parse(NGAYNC.ToString()).ToShortDateString();
                    default:
                        return "";
                }
            }
        }
        public class TAIKHOAN
        {
            //   [ACCOUNT] [varchar](50) NOT NULL,
            //[PASSWORD] [varchar](50) NULL,
            //[ACCESS] [nchar](3) NULL,
            public string ACCOUNT { get; set; }
            public string PASSWORD { get; set; }
            public string ACCESS { get; set; }
            public enum enumStruct
            {
                ACCOUNT,
                PASSWORD,
                ACCESS,
            }
            public string ToString(enumStruct e)
            {
                switch (e)
                {
                    case enumStruct.ACCOUNT:
                        return ACCOUNT.ToString();
                    case enumStruct.PASSWORD:
                        return PASSWORD.ToString();
                    case enumStruct.ACCESS:
                        return ACCESS.ToString();
                    default:
                        return "";
                }
            }
        }
    }
}
