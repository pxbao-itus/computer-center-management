using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    class DAO_Query
    {
        // Danh sach hoc phan
        public static string DanhSachHocPhanTongQuan(int MaHV)
        {
            string query = "select NMH.MaNhom MaHocPhan, NMH.TenNhom TenHocPhan,count(MH.MaNhom) SoMonPhaiHoc from QLHocTap.NhomMonHoc NMH " + "join CTDT on CTDT.MaCTDT = NMH.MaCTDT " +
                "join QLHocTap.MonHoc MH on MH.MaNhom = NMH.MaNhom where TenCTDT = 'Ky Thuat Vien' " +
                "group by NMH.MaNhom,NMH.TenNhom " +
                "order by NMH.MaNhom asc";
            return query;
        }
        public static string LayDanhSachTenHP()
        {
            string query = "select distinct(NMH.TenNhom) TenHocPhan from QLHocTap.NhomMonHoc NMH  where NMH.MaCTDT = 1";
            return query;
        }
        public static string LayDiemMH(int MaHV, string TenHocPhan)
        {
            if (TenHocPhan == "Tat Ca")
            {
                string query = "select NMH.MaNhom,NMH.TenNhom,MH.MaMH,KQHP.Diem from MonHoc MH join LopMo LM on MH.MaMH = LM.MaMH " +
                "left join KQDK_HocPhan KQHP on LM.MaLop = KQHP.MaLopMo " +
                "join NhomMonHoc NMH on NMH.MaNhom = MH.MaNhom " +
                "join MonHoc MH on MH.MaMH = LM.MaMH " +
                "where KQHP.MaHV = " + MaHV + " and KQHP.Diem is not null";
                return query;
            }
            else
            {
                string query = "select NMH.MaNhom,NMH.TenNhom,MH.MaMH,KQHP.Diem from MonHoc MH join LopMo LM on MH.MaMH = LM.MaMH " +
                    "left join KQDK_HocPhan KQHP on LM.MaLop = KQHP.MaLopMo " +
                    "join NhomMonHoc NMH on NMH.MaNhom = MH.MaNhom " +
                    "join MonHoc MH on MH.MaMH = LM.MaMH " +
                    "where KQHP.MaHV = " + MaHV + " and KQHP.Diem is not null and NMH.TenNhom = '" + TenHocPhan + "'";
                return query;
            }
        }
        public static string DanhSachHocPhanChiTiet(int MaHV, string TenHocPhan)
        {
            if (TenHocPhan == "Tat Ca")
            {
                string query = "select NMH.MaNhom MaHocPhan,NMH.TenNhom TenHocPhan,MH.MaMH,MH.TenMH from QLHocTap.NhomMonHoc NMH " +
                    "join QLHocTap.MonHoc MH on MH.MaNhom = NMH.MaNhom " +
                    "join QLHocTap.LopMo LM on LM.MaMH = MH.MaMH " +
                    "where LM.LoaiLopMo = 'Hoc Phan' " +
                    "group by NMH.MaNHom,NMH.TenNhom,MH.MaMH,MH.TenMH " +
                    "order by NMH.MaNhom asc";
                return query;
            }
            else
            {
                string query = "select NMH.MaNhom MaHocPhan,NMH.TenNhom TenHocPhan,MH.MaMH,MH.TenMH from QLHocTap.NhomMonHoc NMH " +
                    "join QLHocTap.MonHoc MH on MH.MaNhom = NMH.MaNhom " +
                    "join QLHocTap.LopMo LM on LM.MaMH = MH.MaMH " +
                    "where LM.LoaiLopMo = 'Hoc Phan' and TenNhom = '" + TenHocPhan + "' " +
                    "group by NMH.MaNHom,NMH.TenNhom,MH.MaMH,MH.TenMH " +
                    "order by NMH.MaNhom asc";
                return query;
            }
        }


        public static string alterSession()
        {
            string query = "alter session set \"_ORACLE_SCRIPT\" = TRUE";
            return query;
        }
        public static string NoiDungQuyDinh(int HocKy, int NamHoc)
        {
            string query = "SELECT SOTINCHITOIDA, SOMONTOIDA, SOCHUYENDETOIDA, SOTIENTRENTINCHI FROM QUYDINH WHERE HocKy = " + HocKy + " AND NamHoc = " + NamHoc;
            return query;
        }
        public static string TrangThaiDangKy(string Loai)
        {
            string query = "SELECT TrangThaiDangKy FROM QLHocTap.TrangThaiDangKy WHERE TenLoaiDangKy = '" + Loai + "'";
            return query;
        }
        // Dang nhap
        public static string DangNhap(DTO_Account account)
        {
            string query = DAO_DataProvider.getConnectionString(account);

            return query;
        }
        public static string LayVaiTro(DTO_Account account)
        {
            string query = "SELECT VAITRO from QLHocTap.TAIKHOAN WHERE upper(TenTaiKhoan) = '" + account.username.ToUpper() + "'";
            return query;
        }
        public static string LayMaHV(DTO_Account account)
        {
            string query = "SELECT MaHV from QLHocTap.HOCVIEN WHERE upper(TenTaiKhoan) = sys_context('userenv','session_user')";
            return query;
        }

        // Xem thong tin ca nhan va doi mat khau
        public static string LayThongTinCaNhan(int MaHV)
        {
            string query = "SELECT MaHV,TenHV,Email,NgaySinh,SDT,NgayBatDau FROM QLHocTap.HOCVIEN WHERE MaHV = '" + MaHV + "'";
            return query;
        }
        public static string CapNhapThongTinCaNhan(DTO_User User)
        {
            string query = "UPDATE QLHocTap.HocVien SET EMAIL = '" + User.Email + "',SDT = '" + User.PhoneNumber + "' WHERE MAHV = " + User.MaHV;
            return query;
        }
        public static string DoiMatKhau(DTO_Account account,string newPassword)
        {
            string query = "ALTER USER " + account.username + " IDENTIFIED BY " + newPassword;
            return query;
        }



        // Dang ky hoc phan
        public static string DanhSachHocPhan(int MaHV, int HocKy, int NamHoc)
        {

            //string query = "select LM.MaLop,LM.MaMH,MH.TenMH,MH.SoTinChi,LM.SLHVThamGia,LM.SLHVToiDa,TKB.Thu, TKB.TietBatDau,TKB.TietKetThuc, TKB.NgayBatDau from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LM.MaMH not in(select LM2.MaMH from QLHocTap.KQDK_HocPhan KQDKHP join QLHocTap.LopMo LM2 on KQDKHP.MaLopMo = LM2.MaLop where KQDKHP.MaHV = '" + MaHV + "' and KQDKHP.TrangThai = 0 or TrangThai IS NULL) and LM.LoaiLopMo = 'Hoc Phan' and HocKy = '" + HocKy + "' and NamHoc = '" + NamHoc + "'";
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,MH.SoTinChi,LM.SLHVThamGia,LM.SLHVToiDa,TKB.Thu, TKB.TietBatDau,TKB.TietKetThuc, TKB.NgayBatDau from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LM.MaMH not in(select LM2.MaMH from QLHocTap.KQDK_HocPhan KQDKHP join QLHocTap.LopMo LM2 on KQDKHP.MaLopMo = LM2.MaLop where KQDKHP.MaHV = '" + MaHV + "' and KQDKHP.TrangThai = 0 or TrangThai IS NULL ) and LM.TrangThaiLop = 0  and LM.LoaiLopMo = 'Hoc Phan' and HocKy = '" + HocKy + "' and NamHoc = '" + NamHoc + "'";
            return query;
        }
        public static string DangKyHocPhan(int MaHV, int MaLop, int MaDKHocPhan)
        {
            string query = "Insert into KQDK_HocPhan(MaDKHocPhan,MaLopMo,MaHV,TrangThai,TrangThaiLop) values (" + MaDKHocPhan + ", " + MaLop + ", " + MaHV + ", NULL, 0)";
            return query;
        }
        public static string LayMaDKHPLonNhat()
        {
            string query = "select Max(MaDKHocPhan) MaDKHocPhan from QLHocTap.KQDK_HocPhan";
            return query;
        }
        public static string HuyDangKyHocPhan(int MaHV, int MaLop)
        {
            string query = "delete from KQDK_HocPhan where TrangThai is null and MaLopMo = " + MaLop + " and MaHV = " + MaHV ;
            return query;
        }

        // Ket qua Dang Ky hoc Phan
        public static string KetQuaDangKyHP(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,MH.SoTinChi,LM.SLHVThamGia,LM.SLHVToiDa,TKB.Thu, TKB.TietBatDau,TKB.TietKetThuc, TKB.NgayBatDau from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop join QLHocTap.KQDK_HocPhan DKHP on DKHP.MaLopMo = LM.MaLop where LM.LOAILOPMO = 'Hoc Phan' and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc + " and LM.TrangThaiLop = 0 and DKHP.MaHV = " + MaHV;
            return query;
        }
        public static string LayDanhSachNamHoc()
        {
            string query = "SELECT DISTINCT NAMHOC FROM QLHocTap.LopMo";
            return query;
        }

        // Danh sach lop mo
        public static string DanhSachLopMo(int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,MH.SoTinChi,LM.SLHVThamGia,LM.SLHVToiDa,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LOAILOPMO = 'Hoc Phan' and HocKy = '" + HocKy + "' and NamHoc = '" + NamHoc + "' and TrangThaiLop = 0";
            return query;
        }

        // Dang ky thi lai
        public static string LayMaDKHocPhanTuongUng(int MaHV, int MaMH)
        {
            string query = "select distinct(KQHP.MaDKHocPhan) from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM " +
                "on LM.MaLop = KQHP.MaLopMo where KQHP.MaHV = " + MaHV + " and LM.MaMH = " + MaMH;
            return query;
        }
        public static string LaySTTLonNhat(int MaDKHocPhan)
        {
            string query = "select Max(STT) from QLHocTap.ThiLai where MaDKHocPhan = " + MaDKHocPhan;
            return query;
        }
        public static string DanhSachHocPhanThiLai(int MaHV)
        {
            string query = "select KQHP.MaDKHocPhan,MH.MaMH,MH.TenMH " +
            "from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo " +
            "join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH " +
            "where KQHP.TrangThai = 1 and MaHV = " + MaHV + " and MaDKHocPhan not in (select MaDKHocPhan from QLHocTap.ThiLai where Diem is null or Diem >= 5 or STT = 3)";
            return query;
        }
        public static string DanhSachHocPhanThiLaiDaDK(int MaHV)
        {
            string query = "select TL.MaDKHocPhan,TL.STT from QLHocTap.ThiLai TL join KQDK_HocPhan KQHP on KQHP.MaDKHocPhan = TL.MaDKHocPhan " +
                "where KQHP.MaHV = " + MaHV;
            return query;
        }
        public static string DangKyThiLai(int MaDKHocPhan, int STT)
        {
            string query = "Insert into ThiLai(MaDKHocPhan,STT) Values(" + MaDKHocPhan + "," + STT + ")";
            return query;
        }
        public static string HuyDangKyThiLai(int MaHV, int MaDKHocPhan, int STT)
        {
            string query = "delete from QLHocTap.ThiLai where MaDKHocPHan = " + MaDKHocPhan + " and STT = " + STT;
            return query;
        }


        // Dang ky chuyen de
        public static string DanhSachChuyenDe(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,LM.SLHVThamGia,LM.SLHVToiDa, TKB.Thu, TKB.NgayBatDau,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LM.MaMH not in(select LM2.MaMH from QLHocTap.KQDK_ChuyenDe KQDKHP join QLHocTap.LopMo LM2 on KQDKHP.MaLopMo = LM2.MaLop where KQDKHP.MaHV = " + MaHV + ")  and LM.LoaiLopMo = 'Chuyen De' and HocKy = " + HocKy + " and NamHoc = " + NamHoc + "";
            return query;
        }
        public static string DanhSachChuyenDeDaDangKy(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,LM.SLHVThamGia,LM.SLHVToiDa, TKB.Thu, TKB.NgayBatDau,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop join QLHocTap.KQDK_ChuyenDe DKCD on DKCD.MaLopMo = LM.MaLop where LM.LOAILOPMO = 'Chuyen De' and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc + " and LM.TrangThaiLop = 0 and DKCD.MaHV = " + MaHV ;
            return query;
        }

        public static string DangKyChuyenDe(int MaHV, int MaLop)
        {
            string query = "Insert into KQDK_ChuyenDe(MaLopMo,MaHV,TrangThaiLop) values (" + MaLop + "," + MaHV + ",0)";
            return query;
        }
        public static string HuyDangKyChuyenDe(int MaHV, int MaLop)
        {
            string query = "delete from KQDK_ChuyenDe where MaLopMo = " + MaLop + " and MaHV = " + MaHV ;
            return query;
        }
        
        // Dang ky chung chi
        public static string DanhSachMonChungChi(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,NCC.TenNhanh,LM.SLHVThamGia,LM.SLHVToiDa,MH.HocPhiChungChi,TKB.Thu,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop left join NhanhChungChi NCC on NCC.MaNhanh = MH.MaNhanhTC where LM.MaMH not in(select LM2.MaMH from QLHocTap.KQDK_ChungChi KQCC join QLHocTap.LopMo LM2 on KQCC.MaLopMo = LM2.MaLop where KQCC.MaHV = " + MaHV + " and (KQCC.TrangThai = 0 or KQCC.TrangThai is null)) and LM.LoaiLopMo = 'Chung Chi' and HocKy = " + HocKy + " and NamHoc = " + NamHoc;
            return query;
        }
        public static string DanhSachMonChungChiDaDangKy(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.MaLop,LM.MaMH,MH.TenMH,NCC.TenNhanh,LM.SLHVThamGia,LM.SLHVToiDa,MH.HocPhiChungChi,TKB.Thu,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop join QLHocTap.KQDK_ChungChi DKCC on DKCC.MaLopMo = LM.MaLop left join QLHocTap.NhanhChungChi NCC on NCC.MaNhanh = MH.MaNhanhTC where LM.LOAILOPMO = 'Chung Chi' and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc + " and LM.TrangThaiLop = 0 and DKCC.MaHV = " + MaHV ;
            return query;
        }
        public static string DangKyChungChi(int MaHV, int MaLop)
        {
            string query = "Insert into KQDK_ChungChi(MaLopMo,MaHV,TrangThai,TrangThaiLop) values (" + MaLop+ "," + MaHV + ",NULL,0)";
            return query;
        }
        public static string HuyDangKyChungChi(int MaHV, int MaLop)
        {
            string query = "delete from KQDK_ChungChi where TrangThai is null and MaLopMo = " + MaLop + " and MaHV = " + MaHV ;
            return query;
        }

        // Ket qua hoc tap
        public static string KetQuaHocTapHocPhan(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.NamHoc,LM.HocKy,LM.MaLop,MH.MaMH,MH.TenMH,MH.SoTinChi,KQHP.Diem from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQHP.MaHV = " + MaHV + " and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc;
            return query;
        }
        public static string XemTatCaHocTapHocPhan(int MaHV)
        {
            string query = "select LM.NamHoc,LM.HocKy,LM.MaLop,MH.MaMH,MH.TenMH,MH.SoTinChi,KQHP.Diem from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQHP.MaHV = " + MaHV ;
            return query;
        }
        public static string KetQuaHocTapChungChi(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select LM.NamHoc,LM.HocKy,LM.MaLop,MH.MaMH,MH.TenMH,KQHP.Diem from QLHocTap.KQDK_ChungChi KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQHP.MaHV = " + MaHV + " and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc;
            return query;
        }
        public static string XemTatCaHocTapChungChi(int MaHV)
        {
            string query = "select LM.NamHoc,LM.HocKy,LM.MaLop,MH.MaMH,MH.TenMH,MH.SoTinChi,KQHP.Diem from QLHocTap.KQDK_ChungChi KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQHP.MaHV = " + MaHV;
            return query;
        }

        // Hoc phi
        public static string HocPhi(int MaHV, int HocKy, int NamHoc, int SoTienTrenTinChi)
        {
            string query = " select MH.MaMH,LM.MaLop,MH.TenMH,MH.SoTinChi,QLHocTap.f_TinhTienHocPhi(MH.SoTinChi," + SoTienTrenTinChi + ") SoTienDong from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM on KQHP.MaLopMo = LM.MaLop join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQHP.MaHV = " + MaHV + " and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc ;
            return query;
        }
        public static string HocPhiChungChi(int MaHV, int HocKy, int NamHoc)
        {
            string query = " select MH.MaMH,LM.MaLop,MH.TenMH,MH.HocPhiChungChi from QLHocTap.KQDK_ChungChi KQCC join QLHocTap.LopMo LM on KQCC.MaLopMo = LM.MaLop join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH where KQCC.MaHV = " + MaHV + " and LM.HocKy = " + HocKy + " and LM.NamHoc = " + NamHoc ;
            return query;
        }
        // Xem lich thi
        public static string XemLichThi(int MaHV, int HocKy, int NamHoc)
        {
            string query = "select MH.MaMH,MH.TenMH,LM.MaLop,LT.NgayThiChinhThuc,LT.GioThi,LT.PhongThi from TKB_LichThi LT join QLHocTap.LopMo LM on LT.MaLop = LM.MaLop join QLHocTap.MonHoc MH on LM.MaMH = MH.MaMH join KQDK_HocPhan KQHP on KQHP.MaLopMo = LM.MaLop where MaHV = " + MaHV + " and NamHoc = " + NamHoc + " and HocKy = " + HocKy;
            return query;
        }
        public static string XemLichThiLai(int MaHV, int HocKy, int NamHoc)
        {
            string query = "";
            return query;
        }




        // Phan he admin
        public static string DanhSachHocVien()
        {
            string query = "SELECT MaHV,TenHV,Email,NgaySinh,SDT,NgayBatDau FROM QLHocTap.HOCVIEN";
            return query;
        }

        public static string KetQuaHocTap(int HocKy, int NamHoc)
        {
            string query = "select KQHP.MaHV,HV.TenHV,LM.MaLop,MH.MaMH,MH.TenMH,KQHP.Diem,MH.SoTinChi,KQHP.TrangThai from QLHocTap.KQDK_HocPhan KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH  join QLHocTap.HocVien HV on HV.MaHV = KQHP.MaHV where NamHoc = " + NamHoc + " and HocKy = " + HocKy;
            return query;
        }

        public static string KetQuaHocTapChungChi(int HocKy, int NamHoc)
        {
            string query = "select KQHP.MaHV,HV.TenHV,LM.MaLop,MH.MaMH,MH.TenMH,KQHP.Diem,KQHP.TrangThai from QLHocTap.KQDK_ChungChi KQHP join QLHocTap.LopMo LM on LM.MaLop = KQHP.MaLopMo join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH  join QLHocTap.HocVien HV on HV.MaHV = KQHP.MaHV where NamHoc = " + NamHoc + " and HocKy = " + HocKy;
            return query;
        }

        public static string CapNhatDiem(int MaHV, int MaLop, float Diem)
        {
            string query = "update QLHocTap.KQDK_HocPhan set Diem = " + Diem + " where MaHV = " + MaHV + " and MaLopMo = " + MaLop;
            return query;
        }

        public static string CapNhatDiemChungChi(int MaHV, int MaLop, float Diem)
        {
            string query = "update QLHocTap.KQDK_ChungChi set Diem = " + Diem + " where MaHV = " + MaHV + " and MaLopMo = " + MaLop;
            return query;
        }

        public static string CapNhatTrangThai(int MaHV, int MaLop, int TrangThai)
        {
            string query = "update QLHocTap.KQDK_HocPhan set TrangThai = " + TrangThai + " where MaHV = " + MaHV + " and MaLopMo = " + MaLop;
            return query;
        }

        public static string CapNhatTrangThaiChungChi(int MaHV, int MaLop, int TrangThai)
        {
            string query = "update QLHocTap.KQDK_ChungChi set TrangThai = " + TrangThai + " where MaHV = " + MaHV + " and MaLopMo = " + MaLop;
            return query;
        }

        public static string DanhSachLopMo(int HocKy, int NamHoc, string LoaiLop)
        {
            string query;
            if (LoaiLop == "Chuyen De" || LoaiLop == "Chung Chi")
            {
                query = "select LM.MaLop,LM.MaMH,MH.TenMH,LM.TrangThaiLop,LM.SLHVThamGia,LM.SLHVToiDa,TKB.Thu,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LOAILOPMO = '" + LoaiLop + "' and HocKy = " + HocKy + " and NamHoc = " + NamHoc;
            }
            else
            {
                query = "select LM.MaLop,LM.MaMH,MH.TenMH,LM.TrangThaiLop,MH.SoTinChi,LM.SLHVThamGia,LM.SLHVToiDa,TKB.Thu,TKB.TietBatDau,TKB.TietKetThuc from QLHocTap.LopMo LM join QLHocTap.MonHoc MH on MH.MaMH = LM.MaMH join QLHocTap.TKB_LichThi TKB on TKB.MaLop = LM.MaLop where LOAILOPMO = '" + LoaiLop + "' and HocKy = " + HocKy + " and NamHoc = " + NamHoc;
            }
            
            return query;
        }

        public static string MoHuyLop(int MaLop, int TrangThai)
        {
            string query = "update LopMo set TrangThaiLop = " + TrangThai + " where MaLop = " + MaLop;
            return query;
        }

        public static string CapNhatQuyDinh(int HocKy, int NamHoc, int SoTinChiToiDa, int SoChuyenDeToiDa, int SoMonChungChiToiDa, int SoTienTrenTinChi)
        {
            string query = "update QuyDinh set SoTinChiToiDa = " + SoTinChiToiDa + ", SoChuyenDeToiDa = " + SoChuyenDeToiDa + ", SoTienTrenTinChi = " + SoTienTrenTinChi + ", SoMonToiDa = " + SoMonChungChiToiDa + " where HocKy = " + HocKy + " and NamHoc = " + NamHoc;
            return query;
        }

        public static string ThemQuyDinh(int HocKy, int NamHoc, int SoTinChiToiDa, int SoChuyenDeToiDa, int SoMonChungChiToiDa, int SoTienTrenTinChi)
        {
            string query = "insert into QuyDinh(NamHoc,HocKy,SoTinChiToiDa,SoChuyenDeToiDa,SoMonToiDa,SoTienTrenTinChi) values (" + NamHoc + "," + HocKy + "," + SoTinChiToiDa + "," + SoChuyenDeToiDa + ","+ SoMonChungChiToiDa +"," + SoTienTrenTinChi + ")";
            return query;
        }

        public static string DongMoDangKy(string LoaiDangKy, int TrangThaiDangKy)
        {
            string query = "update TrangThaiDangKy set TrangThaiDangKy = " + TrangThaiDangKy + " where TenLoaiDangKy = '" + LoaiDangKy + "'";
            return query;
        }

        public static string ThemLopMo(DTO_LopMo_TKB Lop)
        {
            string query = "insert into LopMo(MaLop,MaMH,HocKy,NamHoc,LoaiLopMo,SLHVThamGia,SLHVToiDa,TrangThaiLop) Values (" + Lop.MaLop + "," + Lop.MaMH + "," + Lop.HocKy + "," + Lop.NamHoc + ",'" + Lop.LoaiLopMo + "'," + Lop.SLHVThamGia + "," + Lop.SLHVToiDa + "," + Lop.TrangThaiLop + ")";
            return query;
        }

        public static string ThemTKB(DTO_LopMo_TKB tkb)
        {
            string query = "insert into TKB_LichThi(MaLop,Thu,NgayBatDau,TietBatDau,TietKetThuc) values (" + tkb.MaLop + "," + tkb.Thu + ",'" + tkb.NgayBatDau + "'," + tkb.TietBatDau + "," + tkb.TietKetThuc + ")";
            return query;
        }

        public static string LayMaLopLonNhat()
        {
            string query = "select max(MaLop) MaLop from QLHocTap.LopMo";
            return query;
        }

        public static string LayDanhSachTenMonHoc(string loaiLopHoc)
        {
            string query = "select tenmh from monhoc where mamh in (select distinct mamh from lopmo where loailopmo = '" + loaiLopHoc + "')";
            return query;
        }

        public static string LayMaMonHocTuTen(string TenMH)
        {
            string query = "select mamh from monhoc where tenmh = '" + TenMH + "'";
            return query;
        }
    }
}
