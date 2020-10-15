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
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
        public List<TaiKhoan> ShowTaiKhoan()
        {
            return taiKhoanDAL.HienThiDanhSachTaiKhoan();
        }


        // Phan quyen
        public bool PermissionForEmployee(TaiKhoan tk)
        {
            return taiKhoanDAL.PhanQuyenNhanVien(tk);
        }

        // Hien Thi Ma Quyen Han Len Combox 
        public DataTable LoadComboBoxMAQH()
        {
            return taiKhoanDAL.HienThiMaQuyenHanLenComboBox();
        }


        // Loc Tai Khoan Nhan Vien Theo Ma Quyen Han
        public List<TaiKhoan> FilterEmployeeFlowIdPermission(TaiKhoan tk)
        {
            return taiKhoanDAL.LocThongTinNhaVienTheoMaQh(tk);
        }

        // Update Tai Khoan
        public bool UpdateTaiKhoan(TaiKhoan tk)
        {
            return taiKhoanDAL.UpdateTaiKhoan(tk);
        }
    }
}
