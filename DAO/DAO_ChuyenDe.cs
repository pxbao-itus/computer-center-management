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
    public class DAO_ChuyenDe
    {
        public static DataTable LayTrangThaiDKChuyenDe()
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.TrangThaiDangKy("Chuyen De"), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachChuyenDe(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachChuyenDe(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachChuyenDeDaDangKy(int MaHV,int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachChuyenDeDaDangKy(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool DangKyChuyenDe(int MaHV, int MaLop)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DangKyChuyenDe(MaHV, MaLop), conn);
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

        public static bool HuyDangKyChuyenDe(int MaHV, int MaLop)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.HuyDangKyChuyenDe(MaHV, MaLop), conn);
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
