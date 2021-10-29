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
    public class DAO_User
    {
        public static DataTable LayThongTinCaNhan(int MaHV)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayThongTinCaNhan(MaHV), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                return dt;
            }
        }

        public static bool CapNhatThongTinCaNhan(DTO_User user)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(DAO_DataProvider.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.CapNhapThongTinCaNhan(user), conn);
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

        public static DataTable DanhSachHocVien()
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocVien(), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }


    }
}
