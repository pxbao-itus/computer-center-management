using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using DTO;
namespace DAO
{
    public class DAO_LopMo
    {
        public static DataTable DanhSachLopMo(int HocKy, int NamHoc, string LoaiLop)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachLopMo(HocKy, NamHoc, LoaiLop), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool MoHuyLop(int MaLop, int TrangThai)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.MoHuyLop(MaLop, TrangThai), conn);
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

        public static bool ThemLopMo(DTO_LopMo_TKB lop)
        {
            try
            {
                int MaLop = 0;
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.LayMaLopLonNhat(), conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    MaLop = Int32.Parse(dt.Rows[0]["MALOP"].ToString());
                }
                MaLop++;
                lop.MaLop = MaLop;
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.ThemLopMo(lop), conn);
                    cmd.ExecuteReader();
                    cmd = new OracleCommand("ALTER SESSION SET NLS_DATE_FORMAT = 'DD-MM-YYYY'", conn);
                    cmd.ExecuteReader();
                    cmd = new OracleCommand(DAO_Query.ThemTKB(lop), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static DataTable LayTenCacMonHoc(string loaiLop)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayDanhSachTenMonHoc(loaiLop), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static int LayMaMonHocTuTen(string TenMH)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayMaMonHocTuTen(TenMH), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return Int32.Parse(dt.Rows[0]["MAMH"].ToString());
            }
        }
    }
}
