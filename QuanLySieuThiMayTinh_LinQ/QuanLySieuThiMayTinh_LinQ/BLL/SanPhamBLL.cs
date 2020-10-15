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
    public class SanPhamBLL
    {
        QuanLySieuThiMayTinhDataContext sanPhamDAL = new QuanLySieuThiMayTinhDataContext();

        public List<SanPham> GetAllListSanPham()
        {
            var result = sanPhamDAL.sp_HienThiDanhSachSanPham();
            List<SanPham> list = new List<SanPham>();
            foreach (sp_HienThiDanhSachSanPhamResult sp in result)
                list.Add(new SanPham
                {
                    MaSp=sp.MASP,
                    Cpu=sp.CPU,
                    Ram=sp.RAM,
                    Ocung=sp.OCUNG,
                    CardManHinh=sp.CARDMANHINH,
                    ManHinh=sp.MANHINH,
                    CongKetNoi=sp.PORTCONNECT,
                    Hdt=sp.HDT,
                    AmThanh=sp.AMTHANH,
                    DiaQuang=sp.DIAQUANG,
                    GiaoTiepMang=sp.GIAOTIEPMANG,
                    WebCam=sp.WEBCAM,
                    Pin=sp.PIN,
                    TrongLuong=sp.TRONGLUONG,
                    BaoHanh=sp.BAOHANH,
                    TenSp=sp.TENSP,
                    MaSx=sp.MASX,
                    MaLoai=sp.MALOAI,
                    GiaThanhs=sp.GIATHANH,
                });
            return list;
        }

        // Hiển Thị Mã Nhà Sản Xuất
        public DataTable ShowAllMaSx()
        {
            var result = sanPhamDAL.sp_HienThiDanhSachSanPhamTheoMaSX();
            DataTable table = new DataTable();
            table.Columns.Add("MASX", typeof(Int32));
            foreach (sp_HienThiDanhSachSanPhamTheoMaSXResult sp in result)
                table.Rows.Add(sp.MASX);
            return table;
        }

        // Hiển Thị Mã Loại Sản Phẩm
        public DataTable ShowAllMaLoaiSp()
        {
            var result = sanPhamDAL.sp_HienThiDanhSachSanPhamTheoMaLoai();
            DataTable table = new DataTable();
            table.Columns.Add("MALOAI", typeof(Int32));
            foreach (sp_HienThiDanhSachSanPhamTheoMaLoaiResult sp in result)
            {
                SanPham sps = new SanPham();
                sps.MaLoai = sp.MALOAI;
                table.Rows.Add(sps.MaLoai);
            }    
            return table;
        }

        // Hiển Thị Tên Nhà Sản Xuất
        public DataTable ShowAllTenNhaSx()
        {
            var result = sanPhamDAL.sp_HienThiDanhSachSanPhamTheoTenSX();
            DataTable table = new DataTable();
            table.Columns.Add("TENSX", typeof(string));
            foreach (sp_HienThiDanhSachSanPhamTheoTenSXResult sp in result)
            {
                SanPham sps = new SanPham();
                sps.TenSx = sp.TENSX;
                table.Rows.Add();
            }    
            return table;
        }

        // Hiển Thị Tên Loại Sản Phẩm
        public DataTable ShowAllTenLoaiSp()
        {
            var result = sanPhamDAL.sp_HienThiDanhSachSanPhamTheoTenLoai();
            DataTable table = new DataTable();
            table.Columns.Add("TENLOAI", typeof(string));
            foreach (sp_HienThiDanhSachSanPhamTheoTenLoaiResult sp in result)
                table.Rows.Add(sp.TENLOAI);
            return table;
        }

        // Hiển Thị Mã Sản Xuất Theo Tên Sản Xuất
        public DataTable ShowIdNhaSxFlow(SanPham sp)
        {
            var result = sanPhamDAL.sp_HienThiMaSXTheoTenSX(sp.TenSx);
            DataTable table = new DataTable();
            table.Columns.Add("MASX", typeof(Int32));
            foreach (sp_HienThiMaSXTheoTenSXResult sx in result)
                table.Rows.Add(sx.MASX);
            return table;
        }

        // Hiển Thị Mã Loại Theo Tên Loại Sản Phẩm
        public DataTable ShowIdLoaiSanPhamFlow(SanPham sp)
        {
            var result = sanPhamDAL.sp_HienThiMaLoaiTheoTenLoai(sp.TenLoai);
            DataTable table = new DataTable();
            table.Columns.Add("MALOAI", typeof(Int32));
            foreach (sp_HienThiMaLoaiTheoTenLoaiResult loai in result)
                table.Rows.Add(loai.MALOAI);
            return table;
        }

        // Thêm Sản Phẩm
        public bool InserSanPham(SanPham sp)
        {
            var result = sanPhamDAL.sp_Insert_SANPHAM(sp.TenSp, sp.MaSp, sp.MaLoai, sp.GiaThanhs, sp.Cpu, sp.Ram,
                sp.Ocung, sp.ManHinh, sp.CardManHinh, sp.CongKetNoi, sp.Hdt, sp.AmThanh, sp.DiaQuang, sp.GiaoTiepMang,
                sp.WebCam, sp.Pin, sp.TrongLuong, sp.BaoHanh, sp.NgayNhap);
            sanPhamDAL.SubmitChanges();
            return true;
        }

        // Sửa Sản Phẩm
        public bool EditSanPham(SanPham sp)
        {
            var result = sanPhamDAL.sp_UPDATE_SANPHAM(sp.TenSp, sp.MaSx, sp.MaLoai, sp.GiaThanhs, sp.Cpu, sp.Ram, sp.Ocung,
                sp.ManHinh, sp.CardManHinh, sp.CongKetNoi, sp.Hdt, sp.AmThanh, sp.DiaQuang, sp.GiaoTiepMang, sp.WebCam, sp.Pin,
                sp.TrongLuong, sp.BaoHanh, sp.MaSp);
            sanPhamDAL.SubmitChanges();
            return true;
        }

        // Xóa Sản Phẩm
        public bool DeleteSanPham(SanPham sp)
        {
            var result = sanPhamDAL.sp_DELETE_SANPHAM(sp.MaSp);
            sanPhamDAL.SubmitChanges();
            return true;
        }

        // Tim Kiem San Pham
        public List<SanPham> TimKiemSanPham(SanPham sp)
        {
            var result = sanPhamDAL.sp_TimKiemSanPham(sp.Search);
            List<SanPham> list = new List<SanPham>();
            foreach (sp_TimKiemSanPhamResult sps in result)
                list.Add(new SanPham
                {
                    MaSp = sps.MASP,
                    Cpu = sps.CPU,
                    Ram = sps.RAM,
                    Ocung = sps.OCUNG,
                    CardManHinh = sps.CARDMANHINH,
                    ManHinh = sps.MANHINH,
                    CongKetNoi = sps.PORTCONNECT,
                    Hdt = sps.HDT,
                    AmThanh = sps.AMTHANH,
                    DiaQuang = sps.DIAQUANG,
                    GiaoTiepMang = sps.GIAOTIEPMANG,
                    WebCam = sps.WEBCAM,
                    Pin = sps.PIN,
                    TrongLuong = sps.TRONGLUONG,
                    BaoHanh = sps.BAOHANH,
                    TenSp = sps.TENSP,
                    MaSx = sps.MASX,
                    MaLoai = sps.MALOAI,
                    GiaThanhs = sps.GIATHANH,
                });
            return list;
        }

        // Loc San Pham
        public List<SanPham> LocDanhSachSanPham(SanPham sp)
        {
            List<SanPham> list = new List<SanPham>();
            if (sp.Search == "Mã Sản Phẩm")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoMaSP();
                foreach (sp_LocDanhSachSanPhamTheoMaSPResult sps in result)
                    list.Add(new SanPham { MaSp = sps.MASP });
            }
            else if (sp.Search == "Tên Sản Phẩm")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoTenSP();
                foreach (sp_LocDanhSachSanPhamTheoTenSPResult sps in result)
                    list.Add(new SanPham { TenSp = sps.TENSP });
            }
            else if (sp.Search == "Mã Sản Xuất")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoMaSX();
                foreach (sp_LocDanhSachSanPhamTheoMaSXResult sps in result)
                    list.Add(new SanPham { MaSx = sps.MASX });
            }
            else if (sp.Search == "Tên Sản Xuất")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoTenSX();
                foreach (sp_LocDanhSachSanPhamTheoTenSXResult sps in result)
                    list.Add(new SanPham { TenSx = sps.TENSX });
            }
            else if (sp.Search == "Mã Loại")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoMaLoai();
                foreach (sp_LocDanhSachSanPhamTheoMaLoaiResult sps in result)
                    list.Add(new SanPham { MaLoai = sps.MALOAI });
            }

            else if (sp.Search == "Tên Loại")
            {
                var result = sanPhamDAL.sp_LocDanhSachSanPhamTheoTenLoai();
                foreach (sp_LocDanhSachSanPhamTheoTenLoaiResult sps in result)
                    list.Add(new SanPham { TenLoai = sps.TENLOAI });
            }
            return list;
        }
    }
}
