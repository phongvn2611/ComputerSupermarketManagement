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
    public class SanPhamBLL
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();

        // Hiển Thị Sản Phẩm
        public List<SanPham> GetAllListSanPham()
        {
            return sanPhamDAL.GetAllListSanPham();
        }

        // Hiển Thị Mã Nhà Sản Xuất
        public DataTable ShowAllMaSx()
        {
            return sanPhamDAL.HienThiMaNhaSanXuat();
        }

        // Hiển Thị Mã Loại Sản Phẩm
        public DataTable ShowAllMaLoaiSp()
        {
            return sanPhamDAL.HienThiMaLoaiSP();
        }

        // Hiển Thị Tên Nhà Sản Xuất
        public DataTable ShowAllTenNhaSx()
        {
            return sanPhamDAL.HienThiTenNhaSanXuat();
        }

        // Hiển Thị Tên Loại Sản Phẩm
        public DataTable ShowAllTenLoaiSp()
        {
            return sanPhamDAL.HienThiTenLoaiSanPham();
        }

        // Hiển Thị Mã Sản Xuất Theo Tên Sản Xuất
        public DataTable ShowIdNhaSxFlow(SanPham sp)
        {
            return sanPhamDAL.LayThongTinMaSxTheoTenNhaSx(sp);
        }

        // Hiển Thị Mã Loại Theo Tên Loại Sản Phẩm
        public DataTable ShowIdLoaiSanPhamFlow(SanPham sp)
        {
            return sanPhamDAL.LayThongTinMaLoaiTheoTenLoaiSanPham(sp);
        }

        // Thêm Sản Phẩm
        public bool InserSanPham(SanPham sp)
        {
            return sanPhamDAL.ThemSanPham(sp);
        }

        // Sửa Sản Phẩm
        public bool EditSanPham(SanPham sp)
        {
            return sanPhamDAL.EditSanPham(sp);
        }

        // Xóa Sản Phẩm
        public bool DeleteSanPham(SanPham sp)
        {
            return sanPhamDAL.DeleteSanPham(sp);
        }

        // Tim Kiem San Pham
        public List<SanPham> TimKiemSanPham(SanPham sp)
        {
            return sanPhamDAL.TimKiemSanPham(sp);
        }

        // Loc San Pham
        public List<SanPham> LocDanhSachSanPham(SanPham sp)
        {
            return sanPhamDAL.LocDanhSachSanhPham(sp);
        }
    }
}
