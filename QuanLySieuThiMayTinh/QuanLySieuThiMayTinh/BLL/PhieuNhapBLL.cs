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
    public class PhieuNhapBLL
    {
        PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();

        // Hiển thị Phiếu Nhập
        public List<PhieuNhapHang> GetAllListPhieuNhap()
        {
            return phieuNhapDAL.GetAllListPhieuNhap();
        }

        // Thêm Phiếu Nhập
        public bool InsertPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.ThemPhieuNhap(pn);
        }

        // Sửa Phiếu Nhập
        public bool EditPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.EditPhieuNhap(pn);
        }


        // Xóa Phiếu Nhập
        public bool DeletePhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.DeletePhieuNhap(pn);
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboxBoxMaDh()
        {
            return phieuNhapDAL.HienThiMaDonDatHang();
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable LoadComboBoxMaSanPham()
        {
            return phieuNhapDAL.HienThiMaSanPham();
        }

        // Hiển Thị Giá Thành
        public DataTable HienThiGiaThanhMaSp(PhieuNhapHang pn)
        {
            return phieuNhapDAL.HienThiGiaThanhMaSp(pn);
        }

        // Tim Kiem Phieu Nhap Hang
        public List<PhieuNhapHang> TimKiemPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.TimKiemPhieuNhap(pn);
        }

        // Loc Danh Sach Phieu Nhap Hang
        public List<PhieuNhapHang> LocDanhSachPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.LocDanhSachPhieuNhap(pn);
        }

        // Hiển Thị Thông Chi Cho Phiếu Nhập
        public List<PhieuNhapHang> HienThiThongTinChoPhieuNhap(PhieuNhapHang pn)
        {
            return phieuNhapDAL.HienThiThongTinChoPhieuNhap(pn);
        }
    }
}
