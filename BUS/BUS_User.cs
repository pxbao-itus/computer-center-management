using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_User
    {
        
        public static DTO_User LayThongTinCaNhan()
        {
            DataTable dt = DAO_User.LayThongTinCaNhan(BUS_Account._maHV);
            int mahv = Int32.Parse(dt.Rows[0]["MAHV"].ToString());
            string hoten = dt.Rows[0]["TENHV"].ToString();
            string email = dt.Rows[0]["EMAIL"].ToString();
            string ngaybd = dt.Rows[0]["NGAYBATDAU"].ToString();
            string ngaysinh = dt.Rows[0]["NGAYSINH"].ToString();
            string sdt = dt.Rows[0]["SDT"].ToString();
            DTO_User user = new DTO_User(mahv, hoten, email, ngaybd, ngaysinh, sdt);
            return user;
        }

        public static bool CapNhatThongTinCaNhan(DTO_User user)
        {
            
            if (DAO_User.CapNhatThongTinCaNhan(user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable DanhSachHocVien()
        {
            return DAO_User.DanhSachHocVien();
        }
    }
}
