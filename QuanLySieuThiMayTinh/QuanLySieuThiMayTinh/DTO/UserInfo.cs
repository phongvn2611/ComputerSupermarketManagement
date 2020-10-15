using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class UserInfo
    {
        public static int Id { get; set; }
        public static string FullName { get; set; }
        public static string permission { get; set; }
        public static byte[] Images { get; set; }
        public static string GioiTinh { get; set; }
    }
}
