using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
namespace DAO
{
    public class DAO_LichThi
    {
        public static DataTable LichThi(int MaHV, int HocKy, int NamHoc)
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.XemLichThi(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable LichThiLai(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.XemLichThiLai(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}
