using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Account
    {
        // Dang nhap
        public static bool DangNhap(DTO_Account account)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_Query.DangNhap(account)))
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable LayVaiTro(DTO_Account account)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayVaiTro(account), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                return dt;
            }                    
        }

        public static DataTable LayMaHV(DTO_Account account)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayMaHV(account), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        // Doi mat khau
        public static bool DoiMatKhau(DTO_Account account, string newPassword)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.alterSession(), conn);
                    cmd.ExecuteReader();
                    cmd = new OracleCommand(DAO_Query.DoiMatKhau(account, newPassword), conn);
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
