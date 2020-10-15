using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.DAL;
using System.Data;

namespace QuanLySieuThiMayTinh.BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();

        public List<NhaCungCap> GetAllListNhaCungCap()
        {
            return nhaCungCapDAL.GetAllListNhaCungCap();
        }

        public bool InsertNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapDAL.ThemNhaCungCap(ncc);
        }

        public bool EditNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapDAL.SuNhaCungCap(ncc);
        }

        public bool DeleteNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapDAL.DeleteNhaCungCap(ncc);
        }

        public List<NhaCungCap> TimKiemNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapDAL.TimKiemNhaCungCap(ncc);
        }

        public List<NhaCungCap> LocDanhSachNhaCungCap(NhaCungCap ncc)
        {
            return nhaCungCapDAL.LocDanhSachNhaCungCap(ncc);
        }
    }
}
