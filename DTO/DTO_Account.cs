using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        public string username;
        public string password;

        public DTO_Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
