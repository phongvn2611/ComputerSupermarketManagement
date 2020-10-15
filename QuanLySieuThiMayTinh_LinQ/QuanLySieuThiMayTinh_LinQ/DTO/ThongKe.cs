using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class ThongKe
    {
        public int MaDh { get; set; }
        public int MaPn { get; set; }
        public int MaPx { get; set; }

        public int MaCc { get; set; }
        public int MaSx { get; set; }
        public int MaLoai { get; set; }
        public int MaSp { get; set; }
        public static int MasP { get; set; }

        public string TenCc { get; set; }
        public string TenSx { get; set; }
        public string TenSp { get; set; }
        public string TenLoai { get; set; }
        public string TenKh { get; set; }

        public int? Sld { get; set; }
        public int? Sln { get; set; }
        public int? Slx { get; set; }
        public int? Slcl { get; set; }

        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? TongTien { get; set; }
        public float? PhanTram { get; set; }

        public DateTime DateOne { get; set; }
        public DateTime DateTwo { get; set; }
        public DateTime NgayDh { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayXuat { get; set; }
        public DateTime DateTonKho { get; set; }
    }
}
