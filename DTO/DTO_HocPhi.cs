using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocPhi
    {
        public int MaLop;
        public int MaMH;
        public string TenMH;
        public string Loai;
        public int SoTien;

        public DTO_HocPhi(int malop, int mamh, string tenmh, string loai, int sotien)
        {
            this.MaLop = malop;
            this.MaMH = mamh;
            this.TenMH = tenmh;
            this.Loai = loai;
            this.SoTien = sotien;
        }
    }
}
