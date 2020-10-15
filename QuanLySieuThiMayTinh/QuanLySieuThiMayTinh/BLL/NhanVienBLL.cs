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
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        // HIen thi danh sach Nhan Vien
        public List<NhanVien> GetAllLISTEmployee()
        {
            return nhanVienDAL.GetAllLISTEmployee();
        }

        // Them Nhan Vien
        public bool InserNhanVien(NhanVien nv)
        {
            return nhanVienDAL.ThemNhanVien(nv);
        }

        // Sua Nhan Vien
        public bool UpdateNhanVien(NhanVien nv)
        {
            return nhanVienDAL.EditNhanVien(nv);
        }

        //Delete Nhan Vien
        public bool DeleteNhanVien(NhanVien nv)
        {
            return nhanVienDAL.DeleteNhanVien(nv);
        }

        public List<NhanVien> LocDSNhanVien(NhanVien nv)
        {
            return nhanVienDAL.LocDSNhanVien(nv);
        }

        // Tim Kiem Nhan Vien
        public List<NhanVien> TimKiemNhanVien(NhanVien nv)
        {
            return nhanVienDAL.TimKiemNhanVien(nv);
        }
    }
}
