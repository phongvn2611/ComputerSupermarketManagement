using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiMayTinh.DTO
{
    public class DonDatHang
    {
        public int Stt { get; set; }
        public int MaDh { get; set; }
        public int MaNv { get; set; }
        public int MaCc { get; set; }
        public DateTime NgayDh { get; set; }
        public int MaSp { get; set; }
        public int SlDh { get; set; }
        public string Search { get; set; }
    }
}
