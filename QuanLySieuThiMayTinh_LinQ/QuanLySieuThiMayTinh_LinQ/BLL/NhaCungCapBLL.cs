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
    public class NhaCungCapBLL
    {
        QuanLySieuThiMayTinhDataContext nhaCungCapDAL = new QuanLySieuThiMayTinhDataContext();

        public List<NhaCungCap> GetAllListNhaCungCap()
        {
            var result = nhaCungCapDAL.sp_HienThiDanhSachNhaCC();
            List<NhaCungCap> list = new List<NhaCungCap>();
            foreach (sp_HienThiDanhSachNhaCCResult ncc in result)
                list.Add(new NhaCungCap { MaCC = ncc.MACC, TenCC = ncc.TENCC, DiaChi = ncc.DIACHI, Sdt = ncc.SDT });
            return list;
        }

        public bool InsertNhaCungCap(NhaCungCap ncc)
        {
            var result = nhaCungCapDAL.sp_Insert_NHACC(ncc.TenCC, ncc.DiaChi, ncc.Sdt);
            nhaCungCapDAL.SubmitChanges();
            return true;
        }

        public bool EditNhaCungCap(NhaCungCap ncc)
        {
            var result = nhaCungCapDAL.sp_UPDATE_NHACC(ncc.TenCC, ncc.DiaChi, ncc.Sdt, ncc.MaCC);
            nhaCungCapDAL.SubmitChanges();
            return true;
        }

        public bool DeleteNhaCungCap(NhaCungCap ncc)
        {
            var result = nhaCungCapDAL.sp_DELETE_NHACC(ncc.MaCC);
            nhaCungCapDAL.SubmitChanges();
            return true;
        }

        public List<NhaCungCap> TimKiemNhaCungCap(NhaCungCap ncc)
        {
            var result = nhaCungCapDAL.sp_TimKiemNhaCungCap(ncc.Search);
            List<NhaCungCap> list = new List<NhaCungCap>();
            foreach (sp_TimKiemNhaCungCapResult cc in result)
                list.Add(new NhaCungCap { MaCC = cc.MACC, TenCC = cc.TENCC, DiaChi = cc.DIACHI, Sdt = cc.SDT });
            return list;
        }

        public List<NhaCungCap> LocDanhSachNhaCungCap(NhaCungCap ncc)
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            if (ncc.Search=="Mã Cung Cấp")
            {
                var result = nhaCungCapDAL.sp_LocDanhSachNhaCCTheoMaCC();
                foreach (sp_LocDanhSachNhaCCTheoMaCCResult cc in result)
                    list.Add(new NhaCungCap { MaCC = cc.MACC });
            }
            else if (ncc.Search=="Tên Cung Cấp")
            {
                var result = nhaCungCapDAL.sp_LocDanhSachNhaCCTheoTenCC();
                foreach (sp_LocDanhSachNhaCCTheoTenCCResult cc in result)
                    list.Add(new NhaCungCap { TenCC = cc.TENCC });
            }    
            else if (ncc.Search=="Số Điện Thoại")
            {
                var result = nhaCungCapDAL.sp_LocDanhSachNhaCCTheoSDT();
                foreach (sp_LocDanhSachNhaCCTheoSDTResult cc in result)
                    list.Add(new NhaCungCap { Sdt = cc.SDT });
            }    
            return list;
        }
    }
}
