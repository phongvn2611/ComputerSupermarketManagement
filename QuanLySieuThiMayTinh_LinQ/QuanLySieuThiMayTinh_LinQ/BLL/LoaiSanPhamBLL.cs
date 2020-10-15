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
    public class LoaiSanPhamBLL
    {
        QuanLySieuThiMayTinhDataContext loaiSanPhamDAL = new QuanLySieuThiMayTinhDataContext();

        public List<LoaiSanPham> GetAllListLoaiSp()
        {
            var result = loaiSanPhamDAL.sp_HienThiDanhSachLoaiSP();
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            foreach (sp_HienThiDanhSachLoaiSPResult lsp in result)
                list.Add(new LoaiSanPham { MaLoai = lsp.MALOAI, TenLoai = lsp.TENLOAI, Dvt = lsp.DVT });
            return list;
        }

        public bool InserLoaiSanPham(LoaiSanPham lsp)
        {
            var result = loaiSanPhamDAL.sp_Insert_LOAISP(lsp.TenLoai, lsp.Dvt);
            loaiSanPhamDAL.SubmitChanges();
            return true;
        }

        public bool EditLoaiSanPham(LoaiSanPham lsp)
        {
            var result = loaiSanPhamDAL.sp_UPDATE_LOAISP(lsp.TenLoai, lsp.Dvt.Trim(), lsp.MaLoai);
            loaiSanPhamDAL.SubmitChanges();
            return true;
        }

        public bool DeleteLoaiSanPham(LoaiSanPham lsp)
        {
            var result = loaiSanPhamDAL.sp_DELETE_LOAISP(lsp.MaLoai);
            loaiSanPhamDAL.SubmitChanges();
            return true;
        }

        // Tim Kiem Loai San Pham
        public List<LoaiSanPham> TimKiemLoaiSanPham(LoaiSanPham lsp)
        {
            var result = loaiSanPhamDAL.sp_TimKiemLoaiSanPham(lsp.Search);
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            foreach (sp_TimKiemLoaiSanPhamResult sp in result)
                list.Add(new LoaiSanPham { MaLoai = sp.MALOAI, TenLoai = sp.TENLOAI, Dvt = sp.DVT });
            return list;
        }

        // Load Danh Sach Loai San Pham
        public List<LoaiSanPham> LocDanhSachLoaiSanPham(LoaiSanPham lsp)
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            if (lsp.Search=="Mã Loại")
            {
                var result = loaiSanPhamDAL.sp_LocDanhSachLoaiSPTheoMaLoai();
                foreach (sp_LocDanhSachLoaiSPTheoMaLoaiResult sp in result)
                    list.Add(new LoaiSanPham { MaLoai = sp.MALOAI });
            }   
            else if (lsp.Search=="Tên Loại")
            {
                var result = loaiSanPhamDAL.sp_LocDanhSachLoaiSPTheoTenLoai();
                foreach (sp_LocDanhSachLoaiSPTheoTenLoaiResult sp in result)
                    list.Add(new LoaiSanPham { TenLoai = sp.TENLOAI });
            }   
            else if (lsp.Search=="Đơn Vị Tính")
            {
                var result = loaiSanPhamDAL.sp_LocDanhSachLoaiSPTheoDVT();
                foreach (sp_LocDanhSachLoaiSPTheoDVTResult sp in result)
                    list.Add(new LoaiSanPham { Dvt = sp.DVT });
            }
            return list;
        }
    }
}
