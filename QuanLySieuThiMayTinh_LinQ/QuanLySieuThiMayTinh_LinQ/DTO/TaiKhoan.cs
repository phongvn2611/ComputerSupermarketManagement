using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class TaiKhoan
    {
        public int Stt { get; set; }
        public int Id { get; set; }
        public int? Password { get; set; }
        public string Fullname { get; set; }
        public string Permission { get; set; }
        public string Namepermission { get; set; }
    }
}
