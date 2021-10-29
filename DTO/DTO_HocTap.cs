using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_HocTap
    {
        public int MaLop;
        public int MaMH;
        public string TenMH;
        public string Loai;
        public bool TrangThai;
        public float Diem;

        public DTO_HocTap(int malop, int mamh, string tenmh, string loai, bool stt, float diem)
        {
            this.MaMH = mamh;
            this.MaLop = malop;
            this.TenMH = tenmh;
            this.Loai = loai;
            this.TrangThai = stt;
            this.Diem = diem;
        }
    }
}
