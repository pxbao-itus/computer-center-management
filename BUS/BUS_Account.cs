using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Account
    {
        public static string _username = "";
        public static string _password = "";
        public static string _role = "";
        public static int _maHV = 0;


        public static bool DangNhap(string username, string password)
        {
            DTO_Account account = new DTO_Account(username, password);
            if (DAO_Account.DangNhap(account))
            {
                DAO_DataProvider.connectionString = DAO_DataProvider.getConnectionString(account);
                _username = username;
                _password = password;
                BUS_Config.SetThoiGian();
                BUS_Config.SetNoiDungQuyDinh();  
                _role = DAO_Account.LayVaiTro(account).Rows[0]["VAITRO"].ToString();
                if(_role != "admin")
                {
                    _maHV = Int32.Parse(DAO_Account.LayMaHV(account).Rows[0]["MAHV"].ToString());
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DoiMatKhau(string oldPassword, string newPassword)
        {
            if(oldPassword != _password)
            {
                return 1;
            }
            if(DAO_Account.DoiMatKhau(new DTO_Account(_username, _password), newPassword)){
                _password = newPassword;
                return 2;
            }
            else
            {
                return 0;
            }
        }


    }
}
