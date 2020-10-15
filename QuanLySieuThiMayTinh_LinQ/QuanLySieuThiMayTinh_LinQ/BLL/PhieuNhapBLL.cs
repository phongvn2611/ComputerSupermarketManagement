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
using System.ComponentModel;
using System.Xml.Linq;

namespace QuanLySieuThiMayTinh.BLL
{
    public class PhieuNhapBLL
    {
        QuanLySieuThiMayTinhDataContext phieuNhapDAL = new QuanLySieuThiMayTinhDataContext();

        // Hiển thị Phiếu Nhập
        public List<PhieuNhapHang> GetAllListPhieuNhap()
        {
            var result = phieuNhapDAL.sp_HienThiDanhSachPhieuNhap();
            List<PhieuNhapHang> list = new List<PhieuNhapHang>();
            foreach (sp_HienThiDanhSachPhieuNhapResult pn in result)
                list.Add(new PhieuNhapHang
                {
                    MaPn = pn.MAPN,
                    MaNv = pn.MANV,
                    NgayNhap = pn.NGAYNHAP,
                    MaDh = pn.MADH,
                    MaSp = pn.MASP,
                    Sln = pn.SLN,
                    DonGias = pn.DONGIA
                });
            return list;
        }

        // Thêm Phiếu Nhập
        public bool InsertPhieuNhap(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_Insert_PHIEUNHAP(pn.MaNv, pn.MaDh, pn.MaSp, pn.Sln, pn.DonGias, pn.NgayNhap);
            phieuNhapDAL.SubmitChanges();
            return true;
        }

        // Sửa Phiếu Nhập
        public bool EditPhieuNhap(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_UPDATE_PHIEUNHAP(pn.MaNv, pn.MaDh, pn.MaSp, pn.Sln, pn.DonGias, pn.NgayNhap, pn.MaPn);
            phieuNhapDAL.SubmitChanges();
            return true;
        }


        // Xóa Phiếu Nhập
        public bool DeletePhieuNhap(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_DELETE_PHIEUNHAP(pn.MaPn, pn.MaSp);
            phieuNhapDAL.SubmitChanges();
            return true;
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboxBoxMaDh()
        {
            var result = phieuNhapDAL.sp_HienThiDanhSachPhieuNhapTheoMaDH();
            DataTable table = new DataTable();
            table.Columns.Add("MADH", typeof(Int32));
            foreach (sp_HienThiDanhSachPhieuNhapTheoMaDHResult pn in result)
            {
                PhieuNhapHang pnh = new PhieuNhapHang();
                pnh.MaDh = pn.MADH;
                table.Rows.Add(pnh.MaDh);
            }       
            return table;
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable LoadComboBoxMaSanPham()
        {
            var result = phieuNhapDAL.sp_HienThiDanhSachPhieuNhapTheoMaSP();
            DataTable table = new DataTable();
            table.Columns.Add("MASP", typeof(Int32));
            foreach (sp_HienThiDanhSachPhieuNhapTheoMaSPResult pn in result)
            {
                PhieuNhapHang pnh = new PhieuNhapHang();
                pnh.MaSp = pn.MASP;
                table.Rows.Add(pnh.MaSp);
            }
            return table;
        }

        // Hiển Thị Giá Thành
        public DataTable HienThiGiaThanhMaSp(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_HienThiGiaThanhTheoMaSP(pn.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("GIATHANH", typeof(Int32));
            foreach (sp_HienThiGiaThanhTheoMaSPResult gt in result)
                table.Rows.Add(gt.GIATHANH);
            return table;
        }

        // Tim Kiem Phieu Nhap Hang
        public List<PhieuNhapHang> TimKiemPhieuNhap(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_TimKiemPhieuNhap(pn.Search);
            List<PhieuNhapHang> list = new List<PhieuNhapHang>();
            foreach (sp_TimKiemPhieuNhapResult pns in result)
                list.Add(new PhieuNhapHang { MaPn = pns.MAPN, MaNv = pns.MANV, NgayNhap = pns.NGAYNHAP, MaDh = pns.MADH, MaSp = pns.MASP, Sln = pns.SLN, DonGias = pns.DONGIA });
            return list;
        }

        // Loc Danh Sach Phieu Nhap Hang
        public List<PhieuNhapHang> LocDanhSachPhieuNhap(PhieuNhapHang pn)
        {
            List<PhieuNhapHang> list = new List<PhieuNhapHang>();
            if (pn.Search=="Mã Phiếu Nhập")
            {
                var result = phieuNhapDAL.sp_LocDanhSachPhieuNhapTheoMaPN();
                foreach (sp_LocDanhSachPhieuNhapTheoMaPNResult pns in result)
                    list.Add(new PhieuNhapHang { MaPn = pns.MAPN });
            }    
            else if (pn.Search=="Mã Nhân Viên")
            {
                var result = phieuNhapDAL.sp_LocDanhSachPhieuNhapTheoMaNV();
                foreach (sp_LocDanhSachPhieuNhapTheoMaNVResult pns in result)
                    list.Add(new PhieuNhapHang { MaNv = pns.MANV });
            }    
            else if (pn.Search=="Mã Đơn Hàng")
            {
                var result = phieuNhapDAL.sp_LocDanhSachPhieuNhapTheoMaDH();
                foreach (sp_LocDanhSachPhieuNhapTheoMaDHResult pns in result)
                    list.Add(new PhieuNhapHang { MaDh = pns.MADH });
            } 
            else if (pn.Search=="Mã Sản Phẩm")
            {
                var result = phieuNhapDAL.sp_LocDanhSachPhieuNhapTheoMaSP();
                foreach (sp_LocDanhSachPhieuNhapTheoMaSPResult pns in result)
                    list.Add(new PhieuNhapHang { MaSp = pns.MASP });
            }
            return list;
        }

        // Hiển Thị Thông Chi Cho Phiếu Nhập
        public List<PhieuNhapHang> HienThiThongTinChoPhieuNhap(PhieuNhapHang pn)
        {
            var result = phieuNhapDAL.sp_HienThiDanhSachDonDhChoPhieuNhap(pn.MaDh);
            List<PhieuNhapHang> list = new List<PhieuNhapHang>();
            DataTable table = new DataTable();
            table.Columns.Add("SLDH", typeof(Int32));
            table.Columns.Add("MASP", typeof(Int32));
            table.Columns.Add("SLN", typeof(Int32));
            foreach (sp_HienThiDanhSachDonDhChoPhieuNhapResult pns in result)
            {
                table.Rows.Add(pns.SLDH, pns.MASP, pns.SLN);
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (pn.Sln == pn.Sld)
                {
                    table.Columns.Add("MAPN", typeof(Int32));
                    table.Columns.Add("DONGIA", typeof(Int32));
                    foreach (sp_HienThiDanhSachDonDhChoPhieuNhapResult pns in result)
                        table.Rows.Add(pns.MAPN, pns.DONGIA);
                }
                else
                {
                    table.Columns.Add("DONGIA", typeof(Int32));
                    foreach (sp_HienThiDanhSachDonDhChoPhieuNhapResult pns in result)
                        table.Rows.Add(pns.DONGIA);
                }
                list.Add(pn);
            }
            return list;
        }
    }
}
