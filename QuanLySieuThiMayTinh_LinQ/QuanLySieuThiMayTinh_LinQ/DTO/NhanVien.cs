using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class NhanVien
    {
        public int Stt { get; set; }
        public int MaNv { get; set; }
        public string Hoten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioTinh { get; set; }
        public string Sdt { get; set; }
        public string Mail { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayLam { get; set; }
        public byte[] Images { get; set; }
        public string Image_01 { get; set; }
        public string imagesLocation { get; set; }
        public string Search { get; set; }
    }
}
