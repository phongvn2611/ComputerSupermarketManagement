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
    public class NhaSanXuatBLL
    {
        QuanLySieuThiMayTinhDataContext nhaSanXuatDAL = new QuanLySieuThiMayTinhDataContext();

        public List<NhaSanXuat> GetAllListNhaSx()
        {
            var result = nhaSanXuatDAL.sp_HienThiDanhSachNhaSX();
            List<NhaSanXuat> list = new List<NhaSanXuat>();
            foreach (sp_HienThiDanhSachNhaSXResult nsx in result)
                list.Add(new NhaSanXuat { MaSx = nsx.MASX, TenSx = nsx.TENSX, QuocGia = nsx.QUOCGIA });
            return list;
        }

        public bool InserNhaSx(NhaSanXuat nsx)
        {
            var result = nhaSanXuatDAL.sp_Insert_NHASX(nsx.TenSx, nsx.QuocGia);
            nhaSanXuatDAL.SubmitChanges();
            return true;
        }

        public bool EditNhaSx(NhaSanXuat nsx)
        {
            var result = nhaSanXuatDAL.sp_UPDATE_NHASX(nsx.TenSx, nsx.QuocGia, nsx.MaSx);
            nhaSanXuatDAL.SubmitChanges();
            return true;
        }

        public bool DeleteNhaSx(NhaSanXuat nsx)
        {
            var result = nhaSanXuatDAL.sp_DELETE_NHASX(nsx.MaSx);
            nhaSanXuatDAL.SubmitChanges();
            return true;
        }

        // Tim kiem Nha San Xuat
        public List<NhaSanXuat> TimKiemNhaSx(NhaSanXuat nsx)
        {
            var result = nhaSanXuatDAL.sp_TimKiemNhaSanXuat(nsx.Search);
            List<NhaSanXuat> list = new List<NhaSanXuat>();
            foreach (sp_TimKiemNhaSanXuatResult sx in result)
                list.Add(new NhaSanXuat { MaSx = sx.MASX, TenSx = sx.TENSX, QuocGia = sx.QUOCGIA });
            return list;
        }

        // Loc Danh sAch Nha San Xuat
        public List<NhaSanXuat> LocDanhSachNhaSanXuat(NhaSanXuat nsx)
        {
            List<NhaSanXuat> list = new List<NhaSanXuat>();
            if (nsx.Search=="Mã Sản Xuất")
            {
                var result = nhaSanXuatDAL.sp_LocDanhSachNhaSXTheoMaSX();
                foreach (sp_LocDanhSachNhaSXTheoMaSXResult sx in result)
                    list.Add(new NhaSanXuat { MaSx = sx.MASX });
            }  
            else if (nsx.Search=="Tên Sản Xuất")
            {
                var result = nhaSanXuatDAL.sp_LocDanhSachNhaSXTheoTenSX();
                foreach (sp_LocDanhSachNhaSXTheoTenSXResult sx in result)
                    list.Add(new NhaSanXuat { TenSx=sx.TENSX });
            }   
            else if (nsx.Search=="Quốc Gia")
            {
                var result = nhaSanXuatDAL.sp_LocDanhSachNhaSXTheoQuocGia();
                foreach (sp_LocDanhSachNhaSXTheoQuocGiaResult sx in result)
                    list.Add(new NhaSanXuat { QuocGia = sx.QUOCGIA });
            }
            return list;
        }
    }
}
