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
    public class NhaSanXuatBLL
    {
        NhaSanXuatDAL nhaSanXuatDAL = new NhaSanXuatDAL();

        public List<NhaSanXuat> GetAllListNhaSx()
        {
            return nhaSanXuatDAL.GetAllListNhaSx();
        }

        public bool InserNhaSx(NhaSanXuat nsx)
        {
            return nhaSanXuatDAL.ThemNhaSanXuat(nsx);
        }

        public bool EditNhaSx(NhaSanXuat nsx)
        {
            return nhaSanXuatDAL.SuaNhaNhaSanXuat(nsx);
        }

        public bool DeleteNhaSx(NhaSanXuat nsx)
        {
            return nhaSanXuatDAL.DeleteNhaSanXuat(nsx);
        }

        // Tim kiem Nha San Xuat
        public List<NhaSanXuat> TimKiemNhaSx(NhaSanXuat nsx)
        {
            return nhaSanXuatDAL.TimKiemNhaSx(nsx);
        }

        // Loc Danh sAch Nha San Xuat
        public List<NhaSanXuat> LocDanhSachNhaSanXuat(NhaSanXuat nsx)
        {
            return nhaSanXuatDAL.LocDanhSachNhaSx(nsx);
        }
    }
}
