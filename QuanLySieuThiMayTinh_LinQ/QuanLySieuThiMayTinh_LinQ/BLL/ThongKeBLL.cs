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
    public class ThongKeBLL
    {
        QuanLySieuThiMayTinhDataContext thongKeDAL = new QuanLySieuThiMayTinhDataContext();

        public List<ThongKe> ThongKeDonDatHangTheoNgayThang(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeDonDatHangTheoNgayThang(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeDonDatHangTheoNgayThangResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLDH });
            return list;
        }

        public List<ThongKe> ThongKeDonDatHang()
        {
            var result = thongKeDAL.sp_ThongKeDonDatHang();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeDonDatHangResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLDH });
            return list;
        }

        public DataTable TongSldh()
        {
            var result = thongKeDAL.sp_TongSoLuongDatHang();
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_TongSoLuongDatHangResult tong in result)
                table.Rows.Add(tong.Column1);
            return table;
        }

        public DataTable TonSldhTheoMaSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeTongSoDoDhTheoMaSp(tk.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_ThongKeTongSoDoDhTheoMaSpResult tong in result)
                table.Rows.Add(tong.SLDH);
            return table;
        }

        public List<ThongKe> ThongKeTonKho()
        {
            var result = thongKeDAL.sp_DanhSachTonKho();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_DanhSachTonKhoResult ds in result)
                list.Add(new ThongKe { MaSp = ds.MASP, TenSp = ds.TENSP, Sld = ds.TONGSLD, Sln = ds.TONGSLN, Slx = ds.TONGSLX, Slcl = ds.TONGSLT });
            return list;
        }

        public List<ThongKe> ThongKeTonKhoTheoNgayThang(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeTonKhoTheoNgayThang(tk.DateOne,tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeTonKhoTheoNgayThangResult ds in result)
                list.Add(new ThongKe { MaSp = ds.MASP, TenSp = ds.TENSP, Sld = ds.TONGSLD, Sln = ds.TONGSLN, Slx = ds.TONGSLX, Slcl = ds.TONGSLT });
            return list;
        }

        public List<ThongKe> HienThiTenLoaiSanPham()
        {
            var result = thongKeDAL.sp_HienThiTenLoaiSanPham();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_HienThiTenLoaiSanPhamResult sp in result)
                list.Add(new ThongKe { TenLoai = sp.TENLOAI });
            return list;
        }

        public List<ThongKe> HienThiTenNhaSanXuat()
        {
            var result = thongKeDAL.sp_HienThiTenNhaSX();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_HienThiTenNhaSXResult sx in result)
                list.Add(new ThongKe { TenSx=sx.TENSX });
            return list;
        }

        public List<ThongKe> ThongKeDonDatHangTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeDonHangTheoTenLoai(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeDonHangTheoTenLoaiResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLDH });
            return list;
        }

        public List<ThongKe> ThongKeDonDatHangTheoNhaSx(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeDonHangTheoNhaSx(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeDonHangTheoNhaSxResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLDH });
            return list;
        }

        public List<ThongKe> ThongKePhieuNhap()
        {
            var result = thongKeDAL.sp_ThongKePhieuNhap();
            List<ThongKe> list = new List<ThongKe>();
            foreach(sp_ThongKePhieuNhapResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLD, Sln=tks.SLN, Slcl=tks.SLCN, DonGia=tks.DONGIA, ThanhTien=tks.THANTIEN });
            return list;
        }

        public List<ThongKe> ThongKePhieuNhapTheoNgayThang(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuNhapTheoNgayThang(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuNhapTheoNgayThangResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLD, Sln = tks.SLN, Slcl = tks.SLCN, DonGia = tks.DONGIA, ThanhTien = tks.ThanhTien });
            return list;
        }

        public List<ThongKe> ThongKePhieuXuat()
        {
            var result = thongKeDAL.sp_ThongKePhieuXuat();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuXuatResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, TenKh=tks.TENKH, Slx = tks.SLX, TongTien=tks.TongTien, PhanTram=tks.PHANTRAM, ThanhTien=tks.THANHTIEN });
            return list;
        }

        public List<ThongKe> ThongKePhieuXuatTheoNgayThang(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuXuatTtheoNgayThang(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuXuatTtheoNgayThangResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, TenKh = tks.TENKH, Slx = tks.SLX, TongTien = tks.TongTien, PhanTram = tks.PHANTRAM, ThanhTien = tks.THANHTIEN });
            return list;
        }

        public List<ThongKe> HienThiTenNhaCungCap()
        {
            var result = thongKeDAL.sp_HienThiTenNhaCC();
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_HienThiTenNhaCCResult ncc in result)
                list.Add(new ThongKe { TenCc = ncc.TENCC });
            return list;
        }

        public List<ThongKe> ThongKePhieuNhapTheoNhaCungCap(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuNhapTheoNhaCungCap(tk.TenCc);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuNhapTheoNhaCungCapResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLD, Sln = tks.SLN, Slcl = tks.SLCN, DonGia = tks.DONGIA, ThanhTien = tks.ThanhTien });
            return list;
        }

        public List<ThongKe> ThongKePhieuNhapLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuNhapTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuNhapTheoLoaiSpResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, Sld = tks.SLD, Sln = tks.SLN, Slcl = tks.SLCN, DonGia = tks.DONGIA, ThanhTien = tks.ThanhTien });
            return list;
        }

        public List<ThongKe> ThongKePHieuXuatTHeoSanPham(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuXuatTtheoTenSp(tk.TenSp);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuXuatTtheoTenSpResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, TenKh = tks.TENKH, Slx = tks.SLX, TongTien = tks.TongTien, PhanTram = tks.PHANTRAM, ThanhTien = tks.THANHTIEN });
            return list;
        }

        public List<ThongKe> ThongKePHieuXuatTHeoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuXuatTtheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuXuatTtheoLoaiSpResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, TenKh = tks.TENKH, Slx = tks.SLX, TongTien = tks.TongTien, PhanTram = tks.PHANTRAM, ThanhTien = tks.THANHTIEN });
            return list;
        }

        public bool UpdateTongSldTonKho(ThongKe tk)
        {
            bool isCheck = false;
            var result = thongKeDAL.sp_UPDATE_TONKHO(tk.Sld, tk.MaSp);
            if (result > 0)
                isCheck = true;
            return isCheck;
        }

        public List<ThongKe> ThongKeTonKhoTHeoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeTonKhoTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeTonKhoTheoLoaiSpResult ds in result)
                list.Add(new ThongKe { MaSp = ds.MASP, TenSp = ds.TENSP, Sld = ds.TONGSLD, Sln = ds.TONGSLN, Slx = ds.TONGSLX, Slcl = ds.TONGSLT });
            return list;
        }

        public List<ThongKe> ThongKeTonKhoTHeoNhaSx(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKeTonKhoTheoNhaSx(tk.TenSx);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKeTonKhoTheoNhaSxResult ds in result)
                list.Add(new ThongKe { MaSp = ds.MASP, TenSp = ds.TENSP, Sld = ds.TONGSLD, Sln = ds.TONGSLN, Slx = ds.TONGSLX, Slcl = ds.TONGSLT });
            return list;
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNhaSx(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSltChoTonKho(tk.TenSx);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSltChoTonKhoResult tks in result)
                list.Add(new ThongKe { Slcl = tks.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSltChoTonKhoTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSltChoTonKhoTheoLoaiSpResult tks in result)
                list.Add(new ThongKe { Slcl = tks.Column1 });
            return list;
        }

        public DataTable TongSldhTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlDonDhTheoLoaiSp(tk.TenLoai);
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_TinhTongSlDonDhTheoLoaiSpResult dh in result)
                table.Rows.Add(dh.SLDH);
            return table;
        }

        public DataTable TongSldhTheoNhaSx(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlDonDhTheoNhaSx(tk.TenSx);
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_TinhTongSlDonDhTheoNhaSxResult dh in result)
                table.Rows.Add(dh.SLDH);
            return table;
        }

        public DataTable TongSldhTheoNgayDh(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlDonDhTheoNgayDatHang(tk.DateOne, tk.DateTwo);
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            foreach (sp_TinhTongSlDonDhTheoNgayDatHangResult dh in result)
                table.Rows.Add(dh.SLDH);
            return table;
        }

        public List<ThongKe> TongSoLuongNhapTheoNgayNhap(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuNhapTheoNgayThang(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuNhapTheoNgayThangResult pn in result)
                list.Add(new ThongKe { Sln = pn.Column1 });
            return list;
        }

        public List<ThongKe> TongSoLuongConNhapTheoNgayNhap(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuConNhapTheoNgayNhap(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuConNhapTheoNgayNhapResult pn in result)
                list.Add(new ThongKe { Slcl = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNgayNhap(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongThanhTienPhieuNhapTheoNgayNhap(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongThanhTienPhieuNhapTheoNgayNhapResult pn in result)
                list.Add(new ThongKe { ThanhTien=pn.Column1 });
            return list;
        }

        public List<ThongKe> TongSoLuongNhapTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuNhapTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuNhapTheoLoaiSpResult pn in result)
                list.Add(new ThongKe { Sln = pn.Column1 });
            return list;
        }

        public List<ThongKe> TongSoLuongConNhapTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuConNhapTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuConNhapTheoLoaiSpResult pn in result)
                list.Add(new ThongKe { Slcl = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoLoaiSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongThanhTienPHieuXuatTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongThanhTienPHieuXuatTheoLoaiSpResult pn in result)
                list.Add(new ThongKe { ThanhTien = pn.Column1 });
            return list;
        }

        public List<ThongKe> TongSoLuongNhapTheoNhaCc(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuNhapTheoNhaCungCap(tk.TenCc);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuNhapTheoNhaCungCapResult pn in result)
                list.Add(new ThongKe { Sln = pn.Column1 });
            return list;
        }

        public List<ThongKe> TongSoLuongConNhapTheoNhaCc(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSoPhieuConNhapTheoNhaCungCap(tk.TenCc);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSoPhieuConNhapTheoNhaCungCapResult pn in result)
                list.Add(new ThongKe { Slcl = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhThanhTienPhieuNhapTheoNhaCc(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongThanhTienPhieuNhapTheoNhaCc(tk.TenCc);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongThanhTienPhieuNhapTheoNhaCcResult pn in result)
                list.Add(new ThongKe { ThanhTien = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongSoLuongTonKhoTheoNgayThang(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSltChoTonKhoTheoNgayThang(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSltChoTonKhoTheoNgayThangResult tks in result)
                list.Add(new ThongKe { Slcl = tks.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongSlpxTheoLoaiSanPham(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlxPHieuXuatTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSlxPHieuXuatTheoLoaiSpResult pn in result)
                list.Add(new ThongKe { Slx=pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongThanhTienTheoLoaiSanPham(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongThanhTienPHieuXuatTheoLoaiSp(tk.TenLoai);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongThanhTienPHieuXuatTheoLoaiSpResult pn in result)
                list.Add(new ThongKe { ThanhTien=pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongSlpxTheoNhaSanXuat(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlxPhieuXuatTheoNhaSx(tk.TenSx);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSlxPhieuXuatTheoNhaSxResult pn in result)
                list.Add(new ThongKe { Slx = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongThanhTienTheoNhaSanXuat(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhhTongThanhTienPHieuXuatTheoNhaSx(tk.TenSx);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhhTongThanhTienPHieuXuatTheoNhaSxResult pn in result)
                list.Add(new ThongKe { ThanhTien = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongSlpxTheoNgayXuat(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongSlxPhieuXuatTheoNgayXuat(tk.DateOne, tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongSlxPhieuXuatTheoNgayXuatResult pn in result)
                list.Add(new ThongKe { Slx = pn.Column1 });
            return list;
        }

        public List<ThongKe> TinhTongThanhTienTheoNgayXuat(ThongKe tk)
        {
            var result = thongKeDAL.sp_TinhTongThanhTienPhieuXuatTheoNgayXuat(tk.DateOne,tk.DateTwo);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_TinhTongThanhTienPhieuXuatTheoNgayXuatResult pn in result)
                list.Add(new ThongKe { ThanhTien = pn.Column1 });
            return list;
        }

        public List<ThongKe> ThongKePHieuXuatTHeoNhaSx(ThongKe tk)
        {
            var result = thongKeDAL.sp_ThongKePhieuXuatTtheoNhaSx(tk.TenSx);
            List<ThongKe> list = new List<ThongKe>();
            foreach (sp_ThongKePhieuXuatTtheoNhaSxResult tks in result)
                list.Add(new ThongKe { MaSp = tks.MASP, TenSp = tks.TENSP, TenLoai = tks.TENLOAI, TenSx = tks.TENSX, TenKh = tks.TENKH, Slx = tks.SLX, TongTien = tks.TongTien, PhanTram = tks.PHANTRAM, ThanhTien = tks.THANHTIEN });
            return list;
        }

        public DataTable TongSoLuongTonTheoMaSp(ThongKe tk)
        {
            var result = thongKeDAL.sp_HienThiTongSltTheoMaSp(tk.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("TONGSLT", typeof(Int32));
            foreach (sp_HienThiTongSltTheoMaSpResult sp in result)
                table.Rows.Add(sp.TONGSLT);
            return table;
        }
    }
}
