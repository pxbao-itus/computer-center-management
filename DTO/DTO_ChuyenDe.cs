using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenDe
    {
        public int MaLop;
        public string TenNhom;
        public string Thu;
        public int TietBatDau;
        public int TietKetThuc;
        public string TenGV;

        public DTO_ChuyenDe(int malop,string nhom, string thu, int bd, int kt, string gv)
        {
            this.MaLop = malop;
            this.TenNhom = nhom;
            this.Thu = thu;
            this.TietBatDau = bd;
            this.TietKetThuc = kt;
            this.TenGV = gv;
        }
    }
}
