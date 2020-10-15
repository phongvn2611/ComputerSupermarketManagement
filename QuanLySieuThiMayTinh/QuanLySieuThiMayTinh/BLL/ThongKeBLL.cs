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
    public class ThongKeBLL
    {
        ThongKeDAL thongKeDAL = new ThongKeDAL();

        public List<ThongKe> ThongKeDonDatHangTheoNgayThang(ThongKe tk)
        {
            return thongKeDAL.ThongKeDonDatHangTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKeDonDatHang()
        {
            return thongKeDAL.ThongKeDonDatHang();
        }

        public DataTable TongSldh()
        {
            return thongKeDAL.TongSldh();
        }

        public DataTable TonSldhTheoMaSp(ThongKe tk)
        {
            return thongKeDAL.TonSldhTheoMaSp(tk);
        }

        public List<ThongKe> ThongKeTonKho()
        {
            return thongKeDAL.ThongKeTonKho();
        }

        public List<ThongKe> ThongKeTonKhoTheoNgayThang(ThongKe tk)
        {
            return thongKeDAL.ThongKeTonKhoTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenLoaiSanPham()
        {
            return thongKeDAL.HienThiTenLoaiSanPham();
        }

        public List<ThongKe> HienThiTenNhaSanXuat()
        {
            return thongKeDAL.HienThiTenNhaSanXuat();
        }

        public List<ThongKe> ThongKeDonDatHangTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.ThongKeDonDatHangTheoLoaiSp(tk);
        }

        public List<ThongKe> ThongKeDonDatHangTheoNhaSx(ThongKe tk)
        {
            return thongKeDAL.ThongKeDonDatHangTheoNhaSx(tk);
        }

        public List<ThongKe> ThongKePhieuNhap()
        {
            return thongKeDAL.ThongKePhieuNhap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNgayThang(ThongKe tk)
        {
            return thongKeDAL.ThongKePhieuNhapTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKePhieuXuat()
        {
            return thongKeDAL.ThongKePhieuXuat();
        }

        public List<ThongKe> ThongKePhieuXuatTheoNgayThang(ThongKe tk)
        {
            return thongKeDAL.ThongKePhieuXuatTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenNhaCungCap()
        {
            return thongKeDAL.HienThiTenNhaCungCap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNhaCungCap(ThongKe tk)
        {
            return thongKeDAL.ThongKePhieuNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> ThongKePhieuNhapLoaiSp(ThongKe tk)
        {
            return thongKeDAL.ThongKePhieuNhapLoaiSp(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoSanPham(ThongKe tk)
        {
            return thongKeDAL.ThongKePHieuXuatTHeoSanPham(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.ThongKePHieuXuatTHeoLoaiSp(tk);
        }

        public bool UpdateTongSldTonKho(ThongKe tk)
        {
            return thongKeDAL.UpdateTongSldTonKho(tk);
        }

        public List<ThongKe> ThongKeTonKhoTHeoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.ThongKeTonKhoTHeoLoaiSp(tk);
        }

        public List<ThongKe> ThongKeTonKhoTHeoNhaSx(ThongKe tk)
        {
            return thongKeDAL.ThongKeTonKhoTHeoNhaSx(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNhaSx(ThongKe tk)
        {
            return thongKeDAL.TinhTongSoLuongTonKhoTheoNhaSx(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.TinhTongSoLuongTonKhoTheoLoaiSp(tk);
        }

        public DataTable TongSldhTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.TongSldhTheoLoaiSp(tk);
        }

        public DataTable TongSldhTheoNhaSx(ThongKe tk)
        {
            return thongKeDAL.TongSldhTheoNhaSx(tk);
        }

        public DataTable TongSldhTheoNgayDh(ThongKe tk)
        {
            return thongKeDAL.TongSldhTheoNgayDh(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongConNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNgayNhap(ThongKe tk)
        {
            return thongKeDAL.TinhThanhTienPhieuNhapTheoNgayNhap(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongConNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoLoaiSp(ThongKe tk)
        {
            return thongKeDAL.TinhThanhTienPhieuNhapTheoLoaiSp(tk);
        }

        public List<ThongKe> TongSoLuongNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> TongSoLuongConNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongConNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNhaCc(ThongKe tk)
        {
            return thongKeDAL.TinhThanhTienPhieuNhapTheoNhaCc(tk);
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNgayThang(ThongKe tk)
        {
            return thongKeDAL.TinhTongSoLuongTonKhoTheoNgayThang(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoLoaiSanPham(ThongKe tk)
        {
            return thongKeDAL.TinhTongSlpxTheoLoaiSanPham(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoLoaiSanPham(ThongKe tk)
        {
            return thongKeDAL.TinhTongThanhTienTheoLoaiSanPham(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoNhaSanXuat(ThongKe tk)
        {
            return thongKeDAL.TinhTongSlpxTheoNhaSanXuat(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoNhaSanXuat(ThongKe tk)
        {
            return thongKeDAL.TinhTongThanhTienTheoNhaSanXuat(tk);
        }

        public List<ThongKe> TinhTongSlpxTheoNgayXuat(ThongKe tk)
        {
            return thongKeDAL.TinhTongSlpxTheoNgayXuat(tk);
        }

        public List<ThongKe> TinhTongThanhTienTheoNgayXuat(ThongKe tk)
        {
            return thongKeDAL.TinhTongThanhTienTheoNgayXuat(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoNhaSx(ThongKe tk)
        {
            return thongKeDAL.ThongKePHieuXuatTHeoNhaSx(tk);
        }

        public DataTable TongSoLuongTonTheoMaSp(ThongKe tk)
        {
            return thongKeDAL.TongSoLuongTonTheoMaSp(tk);
        }
    }
}
