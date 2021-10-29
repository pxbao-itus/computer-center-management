using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_HocPhi
    {
        public static DataTable HocPhi(string HocKy, string NamHoc)
        {
            return DAO_HocPhi.HocPhi(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc), BUS_Config.SoTienTrenTinChi);
        }

        public static int TinhHocPhi(string HocKy, string NamHoc)
        {
            DataTable dt = HocPhi(HocKy, NamHoc);
            int hocPhi = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                hocPhi += Int32.Parse(dt.Rows[i]["SOTIENDONG"].ToString());
            }
            return hocPhi;
        }

        public static DataTable HocPhiChungChi(string HocKy, string NamHoc)
        {
            return DAO_HocPhi.HocPhiChungChi(BUS_Account._maHV, Int32.Parse(HocKy), Int32.Parse(NamHoc));
        }

        public static int TinhHocPhiChungChi(string HocKy, string NamHoc)
        {
            DataTable dt = HocPhiChungChi(HocKy, NamHoc);
            int hocPhi = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hocPhi += Int32.Parse(dt.Rows[i]["HOCPHICHUNGCHI"].ToString());
            }
            return hocPhi;
        }
    }
}
