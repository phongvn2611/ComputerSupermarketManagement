using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class PhieuNhapHang
    {
        public int Stt { get; set; }
        public int MaPn { get; set; }
        public int? MaNv { get; set; }
        public int? MaDh { get; set; }
        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public DateTime? NgayNhap { get; set; }
        public DateTime NgayDat { get; set; }
        public int? Sln { get; set; }
        public int Sld { get; set; }
        public float Dongia { get; set; }
        public decimal? DonGias { get; set; }
        public string Search { get; set; }
    }
}
