using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class Login
    {
        public int username { get; set; }
        public int password { get; set; }
        public string permission { get; set; }
        public string namepermision { get; set; }
        public string fullname { get; set; }
    }
}
