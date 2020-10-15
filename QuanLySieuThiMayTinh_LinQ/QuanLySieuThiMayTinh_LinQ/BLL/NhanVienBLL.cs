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
    public class NhanVienBLL
    {
        QuanLySieuThiMayTinhDataContext nhanVienDAL = new QuanLySieuThiMayTinhDataContext();

        // HIen thi danh sach Nhan Vien
        public List<NhanVien> GetAllLISTEmployee()
        {
            var result = nhanVienDAL.sp_HienThiDanhSachNhanVien();
            List<NhanVien> list = new List<NhanVien>();
            foreach (sp_HienThiDanhSachNhanVienResult nv in result)
                list.Add(new NhanVien { MaNv = nv.MANV, Hoten = nv.HOTEN, NgaySinh = nv.NGAYSINH, GioTinh = nv.GT, 
                    Sdt = nv.SDT, Mail = nv.MAIL, DiaChi = nv.DIACHI, NgayLam = nv.NGAYLAM });
            return list;
        }

        // Them Nhan Vien
        public bool InserNhanVien(NhanVien nv)
        {
            var result = nhanVienDAL.sp_Insert_NhanVien(nv.Hoten, nv.NgaySinh, nv.GioTinh, 
                nv.Sdt, nv.Mail, nv.DiaChi, nv.NgayLam);
            nhanVienDAL.SubmitChanges();
            return true;
        }

        // Sua Nhan Vien
        public bool UpdateNhanVien(NhanVien nv)
        {
            var result = nhanVienDAL.sp_UPDATE_NHANVIEN(nv.Hoten, nv.NgaySinh, nv.GioTinh,
                nv.Sdt, nv.Mail, nv.DiaChi, nv.NgayLam, nv.MaNv);
            nhanVienDAL.SubmitChanges();
            return true;
        }

        //Delete Nhan Vien
        public bool DeleteNhanVien(NhanVien nv)
        {
            var result = nhanVienDAL.sp_DELETE_NHANVIEN(nv.MaNv);
            nhanVienDAL.SubmitChanges();
            return true;
        }

        // Loc Nhan Vien
        public List<NhanVien> LocDSNhanVien(NhanVien nv)
        {
            List<NhanVien> list = new List<NhanVien>();
            if (nv.Search == "Mã Nhân Viên")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoMaNV();
                foreach (sp_LocDanhSachNhanVienTheoMaNVResult nvs in result)
                    list.Add(new NhanVien { MaNv = nvs.MANV });
            }
            else if (nv.Search == "Họ Tên")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoHoTen();
                foreach (sp_LocDanhSachNhanVienTheoHoTenResult nvs in result)
                    list.Add(new NhanVien { Hoten = nvs.HOTEN });
            }
            else if (nv.Search == "Ngày Sinh")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoNgaySinh();
                foreach (sp_LocDanhSachNhanVienTheoNgaySinhResult nvs in result)
                    list.Add(new NhanVien { NgaySinh = nv.NgaySinh });
            }
            else if (nv.Search == "Điện Thoại")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoSDT();
                foreach (sp_LocDanhSachNhanVienTheoSDTResult nvs in result)
                    list.Add(new NhanVien { Sdt = nv.Sdt });
            }
            else if (nv.Search == "Mail")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoMail();
                foreach (sp_LocDanhSachNhanVienTheoMailResult nvs in result)
                    list.Add(new NhanVien { Mail = nv.Mail });
            }
            else if (nv.Search == "Giới Tính")
            {
                var result = nhanVienDAL.sp_LocDanhSachNhanVienTheoGioiTinh();
                foreach (sp_LocDanhSachNhanVienTheoGioiTinhResult nvs in result)
                    list.Add(new NhanVien { GioTinh = nvs.GT });
            }
            return list;
        }

        // Tim Kiem Nhan Vien
        public List<NhanVien> TimKiemNhanVien(NhanVien nv)
        {
            var result = nhanVienDAL.sp_TimKiemNhanVien(nv.Search);
            List<NhanVien> list = new List<NhanVien>();
            foreach (sp_TimKiemNhanVienResult nvs in result)
                list.Add(new NhanVien { MaNv = nvs.MANV, Hoten = nvs.HOTEN, NgaySinh = nvs.NGAYSINH, GioTinh = nvs.GT, 
                    Sdt = nvs.SDT, Mail = nvs.MAIL, DiaChi = nvs.DIACHI, NgayLam = nvs.NGAYLAM });
            return list;
        }
    }
}
