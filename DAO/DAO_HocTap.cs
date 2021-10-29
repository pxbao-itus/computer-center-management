using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAO
{
    public class DAO_HocTap
    {
        public static DataTable KetQuaHocTapHocPhan(int MaHV, int HocKy, int NamHoc)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.KetQuaHocTapHocPhan(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;                
            }
        }

        public static DataTable XemTatCaHocTapHocPhan(int MaHV)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.XemTatCaHocTapHocPhan(MaHV), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable KetQuaHocTapChungChi(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.KetQuaHocTapChungChi(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable XemTatCaHocTapChungChi(int MaHV)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.XemTatCaHocTapChungChi(MaHV), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable KetQuaHocTap(int HocKy, int NamHoc)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                OracleCommand cmd = new OracleCommand(DAO_Query.KetQuaHocTap(HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable KetQuaHocTapChungChi(int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                OracleCommand cmd = new OracleCommand(DAO_Query.KetQuaHocTapChungChi(HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool CapNhatDiem(int MaHV, int MaLop, float Diem, int TrangThai)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.CapNhatDiem(MaHV, MaLop, Diem), conn);
                    cmd.ExecuteReader();
                    cmd = new OracleCommand(DAO_Query.CapNhatTrangThai(MaHV, MaLop, TrangThai), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static bool CapNhatDiemChungChi(int MaHV, int MaLop, float Diem, int TrangThai)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.CapNhatDiemChungChi(MaHV, MaLop, Diem), conn);
                    cmd.ExecuteReader();
                    cmd = new OracleCommand(DAO_Query.CapNhatTrangThaiChungChi(MaHV, MaLop, TrangThai), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

    }
}
