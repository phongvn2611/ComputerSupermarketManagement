using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;

namespace QuanLySieuThiMayTinh.DAL
{
    public class LoginDAL : DataConnect
    {
        public bool KiemTraDangNhap(Login login)
        {
            try
            {
                bool loginCheck = false;
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Search_ThongTinTaiKhoanNhanVien";
                command.Connection = conn;

                command.Parameters.Add("@ID", SqlDbType.Int).Value = login.username;
                command.Parameters.Add("@PASS", SqlDbType.Int).Value = login.password;
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                login.permission = dt.Rows[0][0].ToString().Trim();
                login.fullname = dt.Rows[0][1].ToString();
                login.namepermision = dt.Rows[0][2].ToString();

                if (dt.Rows.Count == 1)
                {
                    if (login.permission == "QLBH")
                    {
                        loginCheck = true;
                        login.permission = "QLBH";
                    }
                    else if (login.permission == "NVBH")
                    {
                        loginCheck = true;
                        login.permission = "NVBH";
                    }
                    else if (login.permission == "NVNEW")
                    {
                        loginCheck = true;
                        login.permission = "NVNEW";
                    }
                }

                return loginCheck;

            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
