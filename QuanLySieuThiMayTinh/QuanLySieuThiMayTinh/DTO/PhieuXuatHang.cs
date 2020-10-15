using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class PhieuXuatHang
    {
        public int Stt { get; set; }
        public int MaPx { get; set; }
        public int MaNv { get; set; }
        public int MaKh { get; set; }
        public string TenKh { get; set; }
        public DateTime NgayXuat { get; set; }
        public int MaSp { get; set; }
        public int Slx { get; set; }
        public float DonGia { get; set; }
        public float PhanTram { get; set; }
        public int MaDh { get; set; }
        public float ThanhTien { get; set; }
        public double ThanhTiens { get; set; }
        public double TienKhachDua { get; set; }
        public string Search { get; set; }
        public static int MaPxKh { get; set; }
        public static DateTime NgayXuatKh { get; set; }

        public static double Money { get; set; }
    }
}
