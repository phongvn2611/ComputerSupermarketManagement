using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class KhachHang
    {
        public int Stt { get; set; }
        public int MaKh { get; set; }
        public string Hoten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string Mail { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayDk { get; set; }
        public string Search { get; set; }
    }
}
