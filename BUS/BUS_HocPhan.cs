using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_HocPhan
    {
        // Hoc phan tong quan
        public static DataTable DanhSachHocPhanTongQuan()
        {
            return DAO_HocPhan.DanhSachHocPhanTongQuan(BUS_Account._maHV);
        }
        public static List<string> LayDanhSachTenHP()
        {
            List<string> listTenHP = new List<string>();
            DataTable dt = DAO_HocPhan.LayDanhSachTenHP();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listTenHP.Add(dt.Rows[i]["TENHOCPHAN"].ToString());
            }
            return listTenHP;
        }
        public static DataTable DanhSachHocPhanChiTiet(string TenHocPhan)
        {
            return DAO_HocPhan.DanhSachHocPhanChiTiet(BUS_Account._maHV, TenHocPhan);

        }
        public static string TinhDTBXetTotNghiep()
        {
            DataTable ds = DAO_HocPhan.DanhSachHocPhanTongQuan(BUS_Account._maHV);
            float DTBXetTotNghiem = 0;
            float soMon = 0;
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                if (ds.Rows[i]["DTBHOCPHAN"].ToString() != "")
                {
                    DTBXetTotNghiem += float.Parse(ds.Rows[i]["DTBHOCPHAN"].ToString())*float.Parse(ds.Rows[i]["SOMONDAHOC"].ToString());
                    soMon += float.Parse(ds.Rows[i]["SOMONDAHOC"].ToString());
                }
            }
            return (DTBXetTotNghiem/soMon).ToString();
        }


        //// Dang ky hoc phan
        public static bool KiemTraTrangThaiDKHocPhan()
        {
            if(DAO_HocPhan.LayTrangThaiDKHocPhan().Rows[0]["TRANGTHAIDANGKY"].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable DanhSachHocPhan()
        {
            return DAO_HocPhan.DanhSachHocPhan(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);

        }

        public static DataTable KetQuaDangKyHP()
        {
           return DAO_HocPhan.KetQuaDangKyHP(BUS_Account._maHV, BUS_Config.HocKy, BUS_Config.NamHoc);
            
        }

        public static bool DangKyHocPhan(string MaLop)
        {

            if(DAO_HocPhan.DangKyHocPhan(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HuyDangKyHocPhan(string MaLop)
        {
            if (DAO_HocPhan.HuyDangKyHocPhan(BUS_Account._maHV, Int32.Parse(MaLop)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SoTinChiDangKy()
        {
            DataTable dt = KetQuaDangKyHP();
            int soTinChi = 0;
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                soTinChi += Int32.Parse(dt.Rows[i]["SOTINCHI"].ToString());
            }
            return soTinChi;
        }

        // Xem lop mo, ket qua dki hoc phan
        public static List<string> LayDanhSachNamHoc()
        {
            List<string> listNamHoc = new List<string>();
            DataTable dt = DAO_HocPhan.LayDanhSachNamHoc();
            for (int i = 0; i< dt.Rows.Count; i++)
            {
                listNamHoc.Add(dt.Rows[i]["NAMHOC"].ToString());
            }
            return listNamHoc;
        }

        public static DataTable KetQuaDangKyHP(string HocKy, string NamHoc)
        {
            return DAO_HocPhan.KetQuaDangKyHP(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
            
        }

        public static DataTable DanhSachLopMo()
        {
            return DAO_HocPhan.DanhSachLopMo(BUS_Config.HocKy, BUS_Config.NamHoc);
        }

        public static DataTable DanhSachLopMo(string HocKy, string NamHoc)
        {
            return DAO_HocPhan.DanhSachLopMo(Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static DataTable DanhSachHocPhanThiLai()
        {
            return DAO_HocPhan.DanhSachHocPhanThiLai(BUS_Account._maHV);
        }

        public static DataTable KetQuaDangKyThiLai()
        {
            return DAO_HocPhan.KetQuaDangKyThiLai(BUS_Account._maHV);
        }

        public static bool DangKyThiLai(string MaMH)
        {
            if (DAO_HocPhan.DangKyThiLai(BUS_Account._maHV, Int32.Parse(MaMH)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HuyDangKyThiLai(string MaDKHocPhan, string STT)
        {
            if (DAO_HocPhan.HuyDangKyThiLai(BUS_Account._maHV, Int32.Parse(MaDKHocPhan), Int32.Parse(STT)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
