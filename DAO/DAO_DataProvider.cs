using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using DTO;
namespace DAO
{
    public class DAO_DataProvider
    {
        public static string connectionString = "";

        public static string adminConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVICE_NAME=QLTTTH)));User Id= QLHocTap ;Password= 123456;";

        public static string getConnectionString(DTO_Account account)
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVICE_NAME=QLTTTH)));User Id=" + account.username + ";Password=" + account.password + ";";
            return connectionString;
        }

        public static DataTable LayThongTinQuyDinh(int HocKy, int NamHoc)
        {
            using(OracleConnection conn = new OracleConnection(adminConnectionString))
            {
                OracleCommand cmd = new OracleCommand(DAO_Query.NoiDungQuyDinh(HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt; 
            }
        }

        public static bool CapNhatQuyDinh(int HocKy, int NamHoc, int SoTinChiToiDa, int SoChuyenDeToiDa, int SoMonChungChiToiDa, int SoTienTrenTinChi)
        {
            using(OracleConnection conn = new OracleConnection(adminConnectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.CapNhatQuyDinh(HocKy, NamHoc, SoTinChiToiDa, SoChuyenDeToiDa, SoMonChungChiToiDa, SoTienTrenTinChi), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
        }

        public static bool ThemQuyDinh(int HocKy, int NamHoc, int SoTinChiToiDa, int SoChuyenDeToiDa, int SoMonChungChiToiDa, int SoTienTrenTinChi)
        {
            using (OracleConnection conn = new OracleConnection(adminConnectionString))
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.ThemQuyDinh(HocKy, NamHoc, SoTinChiToiDa, SoChuyenDeToiDa, SoMonChungChiToiDa, SoTienTrenTinChi), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public static bool DongMoDangKy(string LoaiDangKy, int TrangThai)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DongMoDangKy(LoaiDangKy, TrangThai), conn);
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
