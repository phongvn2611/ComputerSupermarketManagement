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
    public class TaiKhoanBLL
    {
        QuanLySieuThiMayTinhDataContext taiKhoanDAL = new QuanLySieuThiMayTinhDataContext();
        public List<TaiKhoan> ShowTaiKhoan()
        {
            var result = taiKhoanDAL.sp_Search_HienThiThongTinTaiKhoanNhanVien();
            List<TaiKhoan> list = new List<TaiKhoan>();
            foreach (sp_Search_HienThiThongTinTaiKhoanNhanVienResult tk in result)
                list.Add(new TaiKhoan { Id = tk.ID, Password = tk.Password, Fullname = tk.HOTEN, Permission = tk.MAQH });
            return list;
        }


        // Phan quyen
        public bool PermissionForEmployee(TaiKhoan tk)
        {
            bool isCheck = false;
            var result = taiKhoanDAL.sp_PHANQUYEN_NHANVIEN(tk.Id, tk.Permission);
            if (result > 0)
                isCheck = true;
            return isCheck;
        }

        // Hien Thi Ma Quyen Han Len Combox 
        public DataTable LoadComboBoxMAQH()
        {
            var result = taiKhoanDAL.sp_HienThiMaQuyenHan();
            DataTable table = new DataTable();
            table.Columns.Add("MAQH", typeof(string));
            foreach (sp_HienThiMaQuyenHanResult qh in result)
                table.Rows.Add(qh.MAQH);
            return table;
        }


        // Loc Tai Khoan Nhan Vien Theo Ma Quyen Han
        public List<TaiKhoan> FilterEmployeeFlowIdPermission(TaiKhoan tk)
        {
            var result = taiKhoanDAL.sp_SearchTaiKhoanNhanVienTheoMaQh(tk.Permission);
            List<TaiKhoan> list = new List<TaiKhoan>();
            foreach (sp_SearchTaiKhoanNhanVienTheoMaQhResult tknv in result)
                list.Add(new TaiKhoan { Id = tknv.ID, Password = tknv.Password, Fullname = tknv.HOTEN, Permission = tknv.MAQH, Namepermission = tknv.TENQH });
            return list;
        }

        // Update Tai Khoan
        public bool UpdateTaiKhoan(TaiKhoan tk)
        {
            var result = taiKhoanDAL.sp_UPDATE_TAIKHOAN(tk.Id, tk.Password);
            taiKhoanDAL.SubmitChanges();
            return true;
        }
    }
}
