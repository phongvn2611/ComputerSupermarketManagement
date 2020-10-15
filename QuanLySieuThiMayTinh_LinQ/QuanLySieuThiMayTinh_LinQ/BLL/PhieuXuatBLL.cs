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
using System.Windows.Forms;

namespace QuanLySieuThiMayTinh.BLL
{
    public class PhieuXuatBLL
    {
        QuanLySieuThiMayTinhDataContext phieuXuatDAL = new QuanLySieuThiMayTinhDataContext();

        // Hiển thi danh sách PHIEUXUATHANG
        #region Hiển thi danh sách PHIEUXUATHANG
        public List<PhieuXuatHang> GetAllListPhieuXuat()
        {
            var result = phieuXuatDAL.sp_HienThiDanhSachPhieuXuat();
            List<PhieuXuatHang> list = new List<PhieuXuatHang>();
            foreach (sp_HienThiDanhSachPhieuXuatResult px in result)
            {
                PhieuXuatHang pxh = new PhieuXuatHang();
                pxh.MaPx = px.MAPX;
                pxh.MaNv = px.MANV;
                pxh.MaSp = px.MASP;
                pxh.MaKh = px.MAKH;
                pxh.Slx = px.SLX;
                pxh.NgayXuat = px.NGAYXUAT;
                pxh.PhanTram = px.PHANTRAM;
                pxh.ThanhTiens = px.THANHTIEN;
                list.Add(pxh);
            }    
            return list;
        }
        #endregion

        // Hiển thị Mã Khách Hàng
        #region Hiển thị Mã Khách Hàng
        public DataTable ShowMaKhachHang()
        {
            var result = phieuXuatDAL.sp_HienThiDanhSachPhieuXuatTheoMaKH();
            DataTable table = new DataTable();
            table.Columns.Add("MAKH", typeof(Int32));
            foreach (sp_HienThiDanhSachPhieuXuatTheoMaKHResult px in result)
            {
                PhieuXuatHang pxh = new PhieuXuatHang();
                pxh.MaKh = px.MAKH;
                table.Rows.Add(pxh.MaKh);
            }    
            return table;
        }
        #endregion

        // Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        #region Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        public DataTable ShowTenKhTheoMaKn(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_HienThiTenKHTheoMaKH(px.MaKh);
            DataTable table = new DataTable();
            table.Columns.Add("TENKH", typeof(string));
            foreach (sp_HienThiTenKHTheoMaKHResult gt in result)
                table.Rows.Add(gt.TENKH);
            return table;
        }
        #endregion

        // HienThiTenSpTheoMaSp
        #region HienThiTenSpTheoMaSp
        public DataTable HienThiTenSpTheoMaSp(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_HienThiTenSPTheoMaSP(px.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("TENSP", typeof(string));
            foreach (sp_HienThiTenSPTheoMaSPResult gt in result)
                table.Rows.Add(gt.TENSP);
            return table;
        }
        #endregion

        // Hiển thị Mã Sản Phẩm
        #region Hiển thị Mã Sản Phẩm
        public DataTable ShowMaSanPham()
        {
            var result = phieuXuatDAL.sp_HienThiDanhSachPhieuXuatTheoMaSP();
            DataTable table = new DataTable();
            table.Columns.Add("MASP", typeof(Int32));
            foreach (sp_HienThiDanhSachPhieuXuatTheoMaSPResult px in result)
            {
                PhieuXuatHang pxh = new PhieuXuatHang();
                pxh.MaSp = px.MASP;
                table.Rows.Add(pxh.MaSp);
            }    
            return table;
        }
        #endregion

        // Hiển thị Số Lượng Đặt Hàng
        #region Hiển thị Số Lượng Đặt Hàng
        public DataTable ShowSoLuongDatHang()
        {
            var result = phieuXuatDAL.sp_HienThiDanhSachPhieuXuatTheoSLDH();
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_HienThiDanhSachPhieuXuatTheoSLDHResult px in result)
            {
                PhieuXuatHang pxh = new PhieuXuatHang();
                pxh.Slx = px.SLDH;
                table.Rows.Add(pxh.Slx);
            }    
            return table;
        }
        #endregion

        // Thêm PHIẾU XUẤT HÀNG
        #region Thêm PHIẾU XUẤT HÀNG
        public bool InsertPhieuXuatHang(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_Insert_PHIEUXUAT(px.MaNv, px.MaKh, px.MaSp, px.Slx, px.NgayXuat, px.PhanTram);
            phieuXuatDAL.SubmitChanges();
            return true;
        }
        #endregion


        // Edit Phieu Xuat hang
        #region Edit Phieu Xuat
        public bool EditPhieuXuat(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_UPDATE_PHIEUXUAT(px.MaNv, px.MaKh, px.MaSp, px.Slx,px.PhanTram,px.ThanhTiens,px.NgayXuat,px.MaPx);
            phieuXuatDAL.SubmitChanges();
            return true;
        }
        #endregion

        // Delete Phieu Xuat Hang
        #region Delte Phieu Xuat
        public bool DeletePhieuXuat(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_DELETE_PHIEUXUAT(px.MaPx,px.MaSp);
            phieuXuatDAL.SubmitChanges();
            return true;
        }
        #endregion

        // Select Gia Thanh San Pham
        public DataTable SelectGiaThanhSanPham(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_HienThiGiaThanhTheoMaSP(px.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("GIATHANH", typeof(Int32));
            foreach (sp_HienThiGiaThanhTheoMaSPResult gt in result)
                table.Rows.Add(gt.GIATHANH);
            return table;
        }

        // Tim Kiem Phieu Xuat 
        public List<PhieuXuatHang> TimKiemPhieuXuatHang(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_TimKiemPhieuXuat(px.Search);
            List<PhieuXuatHang> list = new List<PhieuXuatHang>();
            foreach (sp_TimKiemPhieuXuatResult pxs in result)
                list.Add(new PhieuXuatHang { MaPx = pxs.MAPX, MaNv = pxs.MANV, MaKh = pxs.MAKH, NgayXuat = pxs.NGAYXUAT, MaSp = pxs.MASP, Slx = pxs.SLX, PhanTram = pxs.PHANTRAM, ThanhTiens = pxs.THANHTIEN });
            return list;
        }

        // Loc Danh Sach Phieu Xuat
        public List<PhieuXuatHang> LocDanhSachPhieuXuatHang(PhieuXuatHang px)
        {
            List<PhieuXuatHang> list = new List<PhieuXuatHang>();
            if (px.Search == "Mã Phiếu Xuất")
            {
                var result = phieuXuatDAL.sp_LocDanhSachPhieuXuatTheoMaPX();
                foreach (sp_LocDanhSachPhieuXuatTheoMaPXResult pxs in result)
                    list.Add(new PhieuXuatHang { MaPx = pxs.MAPX });
            }
            else if (px.Search == "Mã Nhân Viên")
            {
                var result = phieuXuatDAL.sp_LocDanhSachPhieuXuatTheoMaNV();
                foreach (sp_LocDanhSachPhieuXuatTheoMaNVResult pxs in result)
                    list.Add(new PhieuXuatHang { MaNv = pxs.MANV });
            }
            else if (px.Search == "Mã Khách Hàng")
            {
                var result = phieuXuatDAL.sp_LocDanhSachPhieuXuatTheoMaKH();
                foreach (sp_LocDanhSachPhieuXuatTheoMaKHResult pxs in result)
                    list.Add(new PhieuXuatHang { MaKh = pxs.MAKH });
            }
            else if (px.Search == "Mã Sản Phẩm")
            {
                var result = phieuXuatDAL.sp_LocDanhSachPhieuXuatTheoMaSP();
                foreach (sp_LocDanhSachPhieuXuatTheoMaSPResult pxs in result)
                    list.Add(new PhieuXuatHang { MaSp = pxs.MASP });
            }
            return list;
        }

        public DataTable TongSoLuongTonTheoMaSp(PhieuXuatHang px)
        {
            var result = phieuXuatDAL.sp_HienThiTongSltTheoMaSp(px.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("TONGSLT", typeof(Int32));
            foreach (sp_HienThiTongSltTheoMaSpResult gt in result)
                table.Rows.Add(gt.TONGSLT);
            return table;
        }
    }
}
