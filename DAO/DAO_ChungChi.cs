using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
namespace DAO
{
    public class DAO_ChungChi
    {
        public static DataTable LayTrangThaiDKChungChi()
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.TrangThaiDangKy("Chung Chi"), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachMonChungChi(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachMonChungChi(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachMonChungChiDaDangKy(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachMonChungChiDaDangKy(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool DangKyChungChi(int MaHV, int MaLop)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DangKyChungChi(MaHV, MaLop), conn);
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

        public static bool HuyDangKyChungChi(int MaHV, int MaLop)
        {
            //try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.HuyDangKyChungChi(MaHV, MaLop), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
            }
            //catch
            //{
            //    return false;
            //}
        }
    }
}
