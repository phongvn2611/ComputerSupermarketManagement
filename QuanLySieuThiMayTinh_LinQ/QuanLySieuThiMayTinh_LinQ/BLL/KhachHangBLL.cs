using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using QuanLySieuThiMayTinh_LinQ;

namespace QuanLySieuThiMayTinh.BLL
{
    public class KhachHangBLL
    {
        QuanLySieuThiMayTinhDataContext khachHangDAL = new QuanLySieuThiMayTinhDataContext();

        // Hien Thi Khach Hang
        public List<KhachHang> ShowAllListKhachHang()
        {
            var result = khachHangDAL.sp_HienThiDanhSachKhachHang();
            List<KhachHang> list = new List<KhachHang>();
            foreach (sp_HienThiDanhSachKhachHangResult kh in result)
                list.Add(new KhachHang { MaKh = kh.MAKH, Hoten = kh.TENKH, NgaySinh = kh.NGAYSINH, 
                    GioiTinh = kh.GT, Sdt = kh.SDT, Mail = kh.MAIL, DiaChi = kh.DIACHI, NgayDk = kh.NGAYDK });
            return list;
        }

        // Them Khach Hang
        public bool InsertKhachHang(KhachHang kh)
        {
            khachHangDAL.sp_Insert_KHACHHANG(kh.Hoten, kh.NgaySinh, kh.GioiTinh, kh.Sdt, kh.Mail, kh.DiaChi, kh.NgayDk);
            khachHangDAL.SubmitChanges();
            return true;
        }

        // Sua Khach Hang
        public bool UpdateKhachHang(KhachHang kh)
        {
            var result = khachHangDAL.sp_UPDATE_KHACHHANG(kh.Hoten, kh.NgaySinh, kh.GioiTinh, kh.Sdt, kh.Mail, kh.DiaChi, kh.NgayDk, kh.MaKh);
            khachHangDAL.SubmitChanges();
            return true;
        }

        // Xoa Khang Hang
        public bool DeleteKhachHang(KhachHang kh)
        {
            var result = khachHangDAL.sp_DELETE_KHACHHANG(kh.MaKh);
            khachHangDAL.SubmitChanges();
            return true;
        }

        // Loc Danh Sach Khang Hang
        public List<KhachHang> LocDanhSachKhachHang(KhachHang nv)
        {
            List<KhachHang> list = new List<KhachHang>();
            if (nv.Search=="Mã Khách Hàng")
            {
                var result = khachHangDAL.sp_LocDanhSachKhachHangTheoMaKH();
                foreach (sp_LocDanhSachKhachHangTheoMaKHResult kh in result)
                    list.Add(new KhachHang { MaKh = kh.MAKH });
            }
            else if (nv.Search=="Họ Tên")
            {
                var result = khachHangDAL.sp_LocDanhSachKhachHangTheoHoTen();
                foreach (sp_LocDanhSachKhachHangTheoHoTenResult kh in result)
                    list.Add(new KhachHang { Hoten = kh.TENKH });
            }   
            else if (nv.Search=="Số Điện Thoại")
            {
                var result = khachHangDAL.sp_LocDanhSachKhachHangTheoSDT();
                foreach (sp_LocDanhSachKhachHangTheoSDTResult kh in result)
                    list.Add(new KhachHang { Sdt = kh.SDT });
            }   
            else if (nv.Search=="Mail")
            {
                var result = khachHangDAL.sp_LocDanhSachKhachHangTheoMail();
                foreach (sp_LocDanhSachKhachHangTheoMailResult kh in result)
                    list.Add(new KhachHang { Mail = kh.MAIL });
            }   
            else if (nv.Search=="Giới Tính")
            {
                var result = khachHangDAL.sp_LocDanhSachKhachHangTheoGioiTinh();
                foreach (sp_LocDanhSachKhachHangTheoGioiTinhResult kh in result)
                    list.Add(new KhachHang { GioiTinh = kh.GT });
            }    
            return list;
        }

        // Tim Kiem Khach Hang
        public List<KhachHang> TimKiemKhachHang(KhachHang kh)
        {
            var result = khachHangDAL.sp_TimKiemKhachHang(kh.Search);
            List<KhachHang> list = new List<KhachHang>();
            foreach (sp_TimKiemKhachHangResult khs in result)
                list.Add(new KhachHang { MaKh = khs.MAKH, Hoten = khs.TENKH, NgaySinh = khs.NGAYSINH, GioiTinh = khs.GT, 
                    Sdt = khs.SDT, Mail = khs.MAIL, DiaChi = khs.DIACHI, NgayDk = khs.NGAYDK });
            return list;
        }
    }
}
