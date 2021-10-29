using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ChuyenDe
    {
        public static bool KiemTraTrangThaiDKChuyenDe()
        {
            if (DAO_ChuyenDe.LayTrangThaiDKChuyenDe().Rows[0]["TRANGTHAIDANGKY"].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable DanhSachChuyenDe()
        {
            return DAO_ChuyenDe.DanhSachChuyenDe(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static DataTable DanhSachChuyenDeDaDangKy()
        {
            return DAO_ChuyenDe.DanhSachChuyenDeDaDangKy(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static bool DangKyChuyenDe(string MaLop)
        {
            if (DAO_ChuyenDe.DangKyChuyenDe(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HuyDangKyChuyenDe(string MaLop)
        {
            if (DAO_ChuyenDe.HuyDangKyChuyenDe(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SoChuyenDeDaDangKy()
        {
            DataTable dt = DanhSachChuyenDeDaDangKy();
            return dt.Rows.Count;

        }

        public static DataTable DanhSachChuyenDeDaDangKy(string HocKy, string NamHoc)
        {
            return DAO_ChuyenDe.DanhSachChuyenDeDaDangKy(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }
    }
}
