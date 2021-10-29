using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_ChungChi
    {
        public static bool KiemTraTrangThaiDKChungChi()
        {
            if (DAO_ChungChi.LayTrangThaiDKChungChi().Rows[0]["TRANGTHAIDANGKY"].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable DanhSachMonChungChi()
        {
            return DAO_ChungChi.DanhSachMonChungChi(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static DataTable DanhSachMonChungChiDaDangKy()
        {
            return DAO_ChungChi.DanhSachMonChungChiDaDangKy(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static bool DangKyChungChi(string MaLop)
        {
            if (DAO_ChungChi.DangKyChungChi(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HuyDangKyChungChi(string MaLop)
        {
            if (DAO_ChungChi.HuyDangKyChungChi(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SoMonChungChiDaDangKy()
        {
            DataTable dt = DanhSachMonChungChiDaDangKy();
            return dt.Rows.Count;
        }

        public static DataTable DanhSachMonChungChiDaDangKy(string HocKy, string NamHoc)
        {
            return DAO_ChungChi.DanhSachMonChungChiDaDangKy(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }
    }
}
