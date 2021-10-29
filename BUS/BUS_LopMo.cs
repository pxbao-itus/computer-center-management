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
    public class BUS_LopMo
    {
        public static DataTable DanhSachLopMo(string HocKy, string NamHoc, string LoaiLop)
        {
            return DAO_LopMo.DanhSachLopMo(Int32.Parse(HocKy), Int32.Parse(NamHoc), LoaiLop);
        }

        public static bool MoHuyLop(int MaLop, int TrangThai)
        {
            return DAO_LopMo.MoHuyLop(MaLop, TrangThai);
        }

        public static bool ThemLop(DTO_LopMo_TKB lop)
        {
            return DAO_LopMo.ThemLopMo(lop);
        }

        public static List<string> LayDanhSachTenMonHoc(string LoaiLop)
        {
            DataTable dt = DAO_LopMo.LayTenCacMonHoc(LoaiLop);
            List<string> monhoc = new List<string>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                monhoc.Add(dt.Rows[i]["TENMH"].ToString());
            }
            return monhoc;
        }

        public static int LayMaMonHocTuTen(string TenMH)
        {
            return DAO_LopMo.LayMaMonHocTuTen(TenMH);
        }
    }
}
