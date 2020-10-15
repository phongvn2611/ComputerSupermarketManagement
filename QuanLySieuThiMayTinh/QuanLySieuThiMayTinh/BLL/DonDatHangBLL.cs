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
    public class DonDatHangBLL
    {
        DonDatHangDAL donDatHangDAL = new DonDatHangDAL();

        // Hiển thị danh sách Đơn Đặt Hàng
        public List<DonDatHang> GetAllDataDonDh()
        {
            return donDatHangDAL.GetAllListDonDatHang();
        }

        // Thêm Đơn Đặt Hàng
        public bool InsertDonDatHang(DonDatHang dh)
        {
            return donDatHangDAL.ThemDonHang(dh);
        }

        // Sửa Đơn Đặt Hàng
        public bool EditDonDatHang(DonDatHang dh)
        {
            return donDatHangDAL.EditDonDathang(dh);
        }

        // Xóa Đơn Đặt Hàng
        public bool DeleteDonDatHang(DonDatHang dh)
        {
            return donDatHangDAL.DeleteDonDatHang(dh);
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboBoxMacc()
        {
            return donDatHangDAL.LoadDataComboBoxMaCC();
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable ShowDataMaSp()
        {
            return donDatHangDAL.HienThiMaSp();
        }

        // Hien Thi Ten San Pham Theo Ma San Pham
        public DataTable HienThiTenSpTheoMaSp(DonDatHang dh)
        {
            return donDatHangDAL.HienThiTenSpTheoMaSp(dh);
        }

        // Hiển Thị Tên Nhà Cung Theo Mã Cung Câp
        public DataTable ShowTenCCFlowMaCC(DonDatHang dh)
        {
            return donDatHangDAL.HienThiTenNhaCCTheoMacc(dh);
        }

        // Tìm Kiếm Đơn Đặt Hàng
        public List<DonDatHang> TimKiemDonDatHang(DonDatHang dh)
        {
            return donDatHangDAL.TimKiemDonDatHang(dh);
        }

        // Loc Đơn Đặt Hàng
        public List<DonDatHang> LocDanhSanhSachDonDatHang(DonDatHang dh)
        {
            return donDatHangDAL.LocDanhSachDonHang(dh);
        }
    }
}
