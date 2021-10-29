using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
namespace BUS
{
    public class BUS_LichThi
    {
        public static DataTable LichThi(string HocKy, string NamHoc)
        {
            return DAO_LichThi.LichThi(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static DataTable LichThiLai(string HocKy, string NamHoc)
        {
            return DAO_LichThi.LichThiLai(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }
    }
}
