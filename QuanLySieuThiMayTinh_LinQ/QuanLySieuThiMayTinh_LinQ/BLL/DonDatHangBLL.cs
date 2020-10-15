using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using QuanLySieuThiMayTinh_LinQ;

namespace QuanLySieuThiMayTinh.BLL
{
    public class DonDatHangBLL
    {
        QuanLySieuThiMayTinhDataContext donDatHangDAL = new QuanLySieuThiMayTinhDataContext();

        // Hiển thị danh sách Đơn Đặt Hàng

        public List<DonDatHang> GetAllDataDonDh()
        {
            var result = donDatHangDAL.sp_HienThiDanhSachDonHang();
            List<DonDatHang> list = new List<DonDatHang>();
            foreach (sp_HienThiDanhSachDonHangResult ddh in result)
                list.Add(new DonDatHang { MaDh = ddh.MADH, MaNv = ddh.MANV, MaCc = ddh.MACC, NgayDh = ddh.NGDH, MaSp = ddh.MASP, SlDh = ddh.SLDH });
            return list;
        }

        // Thêm Đơn Đặt Hàng
        public bool InsertDonDatHang(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_Insert_DONDH(dh.MaNv, dh.MaCc, dh.MaSp, dh.SlDh, dh.NgayDh);
            donDatHangDAL.SubmitChanges();
            return true;
        }

        // Sửa Đơn Đặt Hàng
        public bool EditDonDatHang(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_UPDATE_DONDH(dh.MaNv, dh.MaCc, dh.MaSp, dh.SlDh, dh.NgayDh, dh.MaDh);
            donDatHangDAL.SubmitChanges();
            return true;
        }

        // Xóa Đơn Đặt Hàng
        public bool DeleteDonDatHang(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_DELETE_DONDH(dh.MaDh);
            donDatHangDAL.SubmitChanges();
            return true;
        }

        // Hiển Thị Mã Nhà Cung Cấp
        public DataTable LoadComboBoxMacc()
        {
            var result = donDatHangDAL.sp_HienThiMaCC();
            DataTable table = new DataTable();
            table.Columns.Add("MACC", typeof(Int32));
            foreach (sp_HienThiMaCCResult ncc in result)
                table.Rows.Add(ncc.MACC);
            return table;
        }

        // Hiển Thị Mã Sản Phẩm
        public DataTable ShowDataMaSp()
        {
            var result = donDatHangDAL.sp_HienThiDanhSachMaSP();
            DataTable table = new DataTable();
            table.Columns.Add("MASP", typeof(Int32));
            foreach (sp_HienThiDanhSachMaSPResult sp in result)
                table.Rows.Add(sp.MASP);
            return table;
        }

        // Hien Thi Ten San Pham Theo Ma San Pham
        public DataTable HienThiTenSpTheoMaSp(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_HienThiTenSPTheoMaSP(dh.MaSp);
            DataTable table = new DataTable();
            table.Columns.Add("TENSP", typeof(string));
            foreach (sp_HienThiTenSPTheoMaSPResult sp in result)
                table.Columns.Add(sp.TENSP);
            return table;
        }

        // Hiển Thị Tên Nhà Cung Theo Mã Cung Câp
        public DataTable ShowTenCCFlowMaCC(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_HienThiTenCCTheoMaCC(dh.MaCc);
            DataTable table = new DataTable();
            table.Columns.Add("TENCC", typeof(string));
            foreach (sp_HienThiTenCCTheoMaCCResult ncc in result)
                table.Columns.Add(ncc.TENCC);
            return table;
        }
        // Tìm Kiếm Đơn Đặt Hàng
        public List<DonDatHang> TimKiemDonDatHang(DonDatHang dh)
        {
            var result = donDatHangDAL.sp_TimKiemDonDatHang(dh.Search);
            List<DonDatHang> list = new List<DonDatHang>();
            foreach (sp_TimKiemDonDatHangResult ddh in result)
                list.Add(new DonDatHang { MaDh = ddh.MADH, MaNv = ddh.MANV, MaCc = ddh.MACC, NgayDh = ddh.NGDH, MaSp = ddh.MASP, SlDh = ddh.SLDH });
            return list;
        }

        // Loc Đơn Đặt Hàng
        public List<DonDatHang> LocDanhSanhSachDonDatHang(DonDatHang dh)
        {
            List<DonDatHang> list = new List<DonDatHang>();
            if (dh.Search=="Mã Đơn Hàng")
            {
                var result = donDatHangDAL.sp_LocDanhSachDonHangTheoMaDH();
                foreach (sp_LocDanhSachDonHangTheoMaDHResult ddh in result)
                    list.Add(new DonDatHang { MaDh = ddh.MADH });
            }    
            else if (dh.Search=="Mã Nhân Viên")
            {
                var result = donDatHangDAL.sp_LocDanhSachDonHangTheoMaNV();
                foreach (sp_LocDanhSachDonHangTheoMaNVResult ddh in result)
                    list.Add(new DonDatHang { MaNv = ddh.MANV });
            } 
            else if (dh.Search=="Mã Cung Cấp")
            {
                var result = donDatHangDAL.sp_LocDanhSachDonHangTheoMaCC();
                foreach (sp_LocDanhSachDonHangTheoMaCCResult ddh in result)
                    list.Add(new DonDatHang { MaCc = ddh.MACC});
            }   
            else if (dh.Search=="Mã Sản Phẩm")
            {
                var result = donDatHangDAL.sp_LocDanhSachDonHangTheoMaSP();
                foreach (sp_LocDanhSachDonHangTheoMaSPResult ddh in result)
                    list.Add(new DonDatHang { MaSp = ddh.MASP });
            }  
            else if (dh.Search=="Số Lượng Đặt")
            {
                var result = donDatHangDAL.sp_LocDanhSachDonHangTheoSLDH();
                foreach (sp_LocDanhSachDonHangTheoSLDHResult ddh in result)
                    list.Add(new DonDatHang { SlDh = ddh.SLDH });
            }
            return list;
        }
    }
}
