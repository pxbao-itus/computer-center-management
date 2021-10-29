using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_HocTap
    {
        public static DataTable KetQuaHocTapHocPhan()
        {
            return DAO_HocTap.KetQuaHocTapHocPhan(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static DataTable KetQuaHocTapHocPhan(string HocKy, string NamHoc)
        {
            return DAO_HocTap.KetQuaHocTapHocPhan(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static DataTable XemTatCaHocTapHocPhan()
        {
            return DAO_HocTap.XemTatCaHocTapHocPhan(BUS_Account._maHV);
        }

        public static DataTable KetQuaHocTapChungChi()
        {
            return DAO_HocTap.KetQuaHocTapChungChi(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static DataTable KetQuaHocTapChungChi(string HocKy, string NamHoc)
        {
            return DAO_HocTap.KetQuaHocTapChungChi(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static DataTable XemTatCaHocTapChungChi()
        {
            return DAO_HocTap.XemTatCaHocTapChungChi(BUS_Account._maHV);
        }

        public static DataTable KetQuaHocTap(string HocKy, string NamHoc)
        {
            return DAO_HocTap.KetQuaHocTap(Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static bool CapNhatDiem(string MaHV, string MaLop, string Diem, string TrangThai)
        {
            return DAO_HocTap.CapNhatDiem(Int32.Parse(MaHV), Int32.Parse(MaLop), float.Parse(Diem), Int32.Parse(TrangThai));
          
        }

        public static DataTable KetQuaHocTapChungChiAdmin(string HocKy, string NamHoc)
        {
            return DAO_HocTap.KetQuaHocTapChungChi(Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static bool CapNhatDiemChungChi(string MaHV, string MaLop, string Diem, string TrangThai)
        {
            return DAO_HocTap.CapNhatDiemChungChi(Int32.Parse(MaHV), Int32.Parse(MaLop), float.Parse(Diem), Int32.Parse(TrangThai));

        }
    }
}
