using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class SanPham
    {
        public int Stt { get; set; }
        public int MaSp { get; set; }
        public string TenSp { get; set; }
        public int? MaSx { get; set; }
        public int? MaLoai { get; set; }
        public float GiaThanh { get; set; }
        public decimal? GiaThanhs { get; set; }

        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Ocung { get; set; }
        public string ManHinh { get; set; }
        public string CardManHinh { get; set; }
        public string CongKetNoi { get; set; }
        public string Hdt { get; set; }
        public string AmThanh { get; set; }
        public string DiaQuang { get; set; }
        public string GiaoTiepMang { get; set; }
        public string WebCam { get; set; }
        public string Pin { get; set; }
        public string TrongLuong { get; set; }
        public string BaoHanh { get; set; }
        public string Search { get; set; }

        public DateTime NgayNhap { get; set; }

        public string TenSx { get; set; }
        public string TenLoai { get; set; }
    }
}
