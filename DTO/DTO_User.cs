using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {
        public int MaHV;
        public string TenHV;
        public string Email;
        public string NgayBatDau;
        public string NgaySinh;
        public string PhoneNumber;


        public DTO_User(int maHV, string tenHV, string email, string bd, string ngaySinh, string phoneNumber)
        {
            this.MaHV = maHV;
            this.TenHV = tenHV;
            this.Email = email;
            this.NgayBatDau = bd;
            this.NgaySinh = ngaySinh;
            this.PhoneNumber = phoneNumber;
        }
    }
}
