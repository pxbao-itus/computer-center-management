using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChungChi
    {
        public int MaLop;
        public int MaMH;
        public int Thu;
        public int TietBatDau;
        public int TietKetThuc;
        public string LoaiChungChi;
        public string TenGV;

        public DTO_ChungChi(int malop,int mamh, int thu, int bd, int kt, string loai, string gv)
        {
            this.MaLop = malop;
            this.MaMH = mamh;
            this.Thu = thu;
            this.TietBatDau = bd;
            this.TietKetThuc = kt;
            this.LoaiChungChi = loai;
            this.TenGV = gv;
        }
    }
}
