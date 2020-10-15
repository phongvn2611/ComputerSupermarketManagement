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
    public class PhieuXuatBLL
    {
        PhieuXuatDAL phieuXuatDAL = new PhieuXuatDAL();

        // Hiển thi danh sách PHIEUXUATHANG
        #region Hiển thi danh sách PHIEUXUATHANG
        public List<PhieuXuatHang> GetAllListPhieuXuat()
        {
            return phieuXuatDAL.GetAllListPhieuNhap();
        }
        #endregion

        // Hiển thị Mã Khách Hàng
        #region Hiển thị Mã Khách Hàng
        public DataTable ShowMaKhachHang()
        {
            return phieuXuatDAL.HienThiMaKhachHang();
        }
        #endregion

        // Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        #region Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        public DataTable ShowTenKhTheoMaKn(PhieuXuatHang px)
        {
            return phieuXuatDAL.HienThiTenKhTheoMaKh(px);
        }
        #endregion

        // HienThiTenSpTheoMaSp
        #region HienThiTenSpTheoMaSp
        public DataTable HienThiTenSpTheoMaSp(PhieuXuatHang px)
        {
            return phieuXuatDAL.HienThiTenSpTheoMaSp(px);
        }
        #endregion

        // Hiển thị Mã Sản Phẩm
        #region Hiển thị Mã Sản Phẩm
        public DataTable ShowMaSanPham()
        {
            return phieuXuatDAL.HienThiMaSanPham();
        }
        #endregion

        // Hiển thị Số Lượng Đặt Hàng
        #region Hiển thị Số Lượng Đặt Hàng
        public DataTable ShowSoLuongDatHang()
        {
            return phieuXuatDAL.HienThiSoLuongXuấtHang();
        }
        #endregion

        // Thêm PHIẾU XUẤT HÀNG
        #region Thêm PHIẾU XUẤT HÀNG
        public bool InsertPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatDAL.ThemPhieuXuatHang(px);
        }
        #endregion

        // Hiển Thi Thông Tin Phiếu Xuất Theo Mã Đơn Hàng
        #region
        public List<PhieuXuatHang> HienThiThongTinPhieuXuatTheoMaDh(PhieuXuatHang px)
        {
            return phieuXuatDAL.HienThiThongTinPhieuXuatTheoMaDh(px);
        }
        #endregion

        // Edit Phieu Xuat hang
        #region Edit Phieu Xuat
        public bool EditPhieuXuat(PhieuXuatHang px)
        {
            return phieuXuatDAL.EditPhieuXuat(px);
        }
        #endregion

        // Delete Phieu Xuat Hang
        #region Delte Phieu Xuat
        public bool DeletePhieuXuat(PhieuXuatHang px)
        {
            return phieuXuatDAL.DeletePhieuXuat(px);
        }
        #endregion

        // Select Gia Thanh San Pham
        public DataTable SelectGiaThanhSanPham(PhieuXuatHang px)
        {
            return phieuXuatDAL.SelectGiaThanhSanPham(px);
        }

        // Tim Kiem Phieu Xuat 
        public List<PhieuXuatHang> TimKiemPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatDAL.TimKiemPhieuXuatHang(px);
        }

        // Loc Danh Sach Phieu Xuat
        public List<PhieuXuatHang> LocDanhSachPhieuXuatHang(PhieuXuatHang px)
        {
            return phieuXuatDAL.LocDanhSachPhieuXuatHang(px);
        }

        public DataTable TongSoLuongTonTheoMaSp(PhieuXuatHang px)
        {
            return phieuXuatDAL.TongSoLuongTonTheoMaSp(px);
        }
    }
}
