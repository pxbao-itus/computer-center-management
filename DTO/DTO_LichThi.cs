using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LichThi
    {
        public int MaLop;
        public int MaMH;
        public string TenMH;
        public DateTime ThoiGian;

        public DTO_LichThi(int malop, int mamh, string tenmh, DateTime tg)
        {
            this.MaLop = malop;
            this.MaMH = mamh;
            this.TenMH = tenmh;
            this.ThoiGian = tg;
        }
    }
}
