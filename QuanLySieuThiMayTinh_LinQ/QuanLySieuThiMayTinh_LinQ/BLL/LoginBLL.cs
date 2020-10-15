using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using QuanLySieuThiMayTinh_LinQ;
using System.Data;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace QuanLySieuThiMayTinh.BLL
{
    public class LoginBLL
    {
        QuanLySieuThiMayTinhDataContext loginDAL = new QuanLySieuThiMayTinhDataContext();
        public bool KiemTraDangNhap(Login login)
        {
            bool loginCheck = false;
            var result = loginDAL.sp_Search_ThongTinTaiKhoanNhanVien(login.username, login.password);
            DataTable table = new DataTable();
            table.Columns.Add("MAQH", typeof(string));
            table.Columns.Add("HOTEN", typeof(string));
            table.Columns.Add("TENQH", typeof(string));
            foreach (sp_Search_ThongTinTaiKhoanNhanVienResult nv in result)
            {
                login.permission = nv.MAQH.Trim();
                login.fullname = nv.HOTEN;
                login.namepermision = nv.TENQH;
                table.Rows.Add(login.permission, login.fullname, login.namepermision);
            }
            if (table.Rows.Count==1)
            {
                if (login.permission=="QLBH")
                {
                    loginCheck = true;
                    login.permission = "QLBH";
                }    
                else if (login.permission=="NVBH")
                {
                    loginCheck = true;
                    login.permission = "NVBH";
                }    
                else if (login.permission=="NVNEW")
                {
                    loginCheck = true;
                    login.permission = "NVNEW";
                }    
            }
            return loginCheck;
        }
    }
}
