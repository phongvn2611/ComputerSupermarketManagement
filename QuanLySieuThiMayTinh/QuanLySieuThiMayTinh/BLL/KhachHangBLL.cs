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
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();

        // Hien Thi Khach Hang
        public List<KhachHang> ShowAllListKhachHang()
        {
            return khachHangDAL.GetAllListCustomer();
        }

        // Them Khach Hang
        public bool InsertKhachHang(KhachHang kh)
        {
            return khachHangDAL.ThemKhachHang(kh);
        }

        // Sua Khach Hang
        public bool UpdateKhachHang(KhachHang kh)
        {
            return khachHangDAL.EditKhachHang(kh);
        }

        // Xoa Khang Hang
        public bool DeleteKhachHang(KhachHang kh)
        {
            return khachHangDAL.DeleteKhachHang(kh);
        }

        // Loc Danh Sach Khang Hang
        public List<KhachHang> LocDanhSachKhachHang(KhachHang nv)
        {
            return khachHangDAL.LocDanhSachKhachHang(nv);
        }

        // Tim Kiem Khach Hang
        public List<KhachHang> TimKiemKhachHang(KhachHang kh)
        {
            return khachHangDAL.TimKiemKhachHang(kh);
        }
    }
}
