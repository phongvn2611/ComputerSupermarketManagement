using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.DAL;

namespace QuanLySieuThiMayTinh.BLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public bool KiemTraDangNhap(Login login)
        {
            return loginDAL.KiemTraDangNhap(login);
        }
    }
}
