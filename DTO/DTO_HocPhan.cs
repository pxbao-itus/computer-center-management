using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocPhan
    {
        public int MaLop;
        public int MaMH;
        public string TenMH;
        public string Thu;
        public int TietBatDau;
        public int TietKetThuc;
        public int SoTinChi;
        public string TenGV;

        public DTO_HocPhan(int malop, int mamh, string tenmh, string thu, int bd, int kt, int sotc, string tengv)
        {
            this.MaLop = malop;
            this.MaMH = mamh;
            this.TenMH = tenmh;
            this.Thu = thu;
            this.TietBatDau = bd;
            this.TietKetThuc = kt;
            this.SoTinChi = sotc;
            this.TenGV = tengv;
        }
    }
}
