using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class BUS_Config
    {
        public static int HocKy = 1;
        public static int NamHoc = 2021;
        public static int SoTinChiToiDa = 24;
        public static int SoChuyenDeToiDa = 5;
        public static int SoMonToiDa = 6;
        public static int SoTienTrenTinChi = 500000;

        public static void SetThoiGian()
        {
            try
            {
                string currentMonth = DateTime.Now.Month.ToString();
                string currentYear = DateTime.Now.Year.ToString();
                if (Int32.Parse(currentMonth) > 0 && Int32.Parse(currentMonth) < 9)
                {
                    HocKy = 1;
                }
                else
                {
                    HocKy = 2;
                }
                NamHoc = Int32.Parse(currentYear);
            }
            catch
            {

            }

        }
        public static void SetNoiDungQuyDinh()
        {
            try
            {
                DataTable dt = DAO_DataProvider.LayThongTinQuyDinh(HocKy, NamHoc);
                SoTinChiToiDa = Int32.Parse(dt.Rows[0]["SOTINCHITOIDA"].ToString());
                SoChuyenDeToiDa = Int32.Parse(dt.Rows[0]["SOCHUYENDETOIDA"].ToString());
                SoMonToiDa = Int32.Parse(dt.Rows[0]["SOMONTOIDA"].ToString());
                SoTienTrenTinChi = Int32.Parse(dt.Rows[0]["SOTIENTRENTINCHI"].ToString());
            }
            catch
            {

            }

        }

        public static DataTable LayThongTinQuyDinh()
        {
            return DAO_DataProvider.LayThongTinQuyDinh(HocKy, NamHoc);
        }

        public static bool CapQuyDinh(string SoTinChiToiDa, string SoChuyenDeToiDa, string SoMonToiDa, string SoTienTrenTinChi)
        {
            return DAO_DataProvider.CapNhatQuyDinh(HocKy, NamHoc, Int32.Parse(SoTinChiToiDa), Int32.Parse(SoChuyenDeToiDa), Int32.Parse(SoMonToiDa), Int32.Parse(SoTienTrenTinChi));
        }

        public static bool ThemQuyDinh(string SoTinChiToiDa, string SoChuyenDeToiDa, string SoMonToiDa, string SoTienTrenTinChi)
        {
            return DAO_DataProvider.ThemQuyDinh(HocKy, NamHoc, Int32.Parse(SoTinChiToiDa), Int32.Parse(SoChuyenDeToiDa), Int32.Parse(SoMonToiDa), Int32.Parse(SoTienTrenTinChi));
        }

        public static bool DongMoDangKy(string LoaiDangKy,int TrangThai)
        {
            return DAO_DataProvider.DongMoDangKy(LoaiDangKy, TrangThai);
        }
    }
}
