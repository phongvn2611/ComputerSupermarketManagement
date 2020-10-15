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
    public class TaiKhoanDAL : DataConnect
    {
        // Hien thi danh sach tai khoan
        public List<TaiKhoan> HienThiDanhSachTaiKhoan()
        {
            OpenConnection();
            List<TaiKhoan> tklist = new List<TaiKhoan>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_Search_HienThiThongTinTaiKhoanNhanVien";
            sqlCommand.Connection = conn;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqlDataReader);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.Id = int.Parse(dt.Rows[i][0].ToString());
                tk.Password = int.Parse(dt.Rows[i][1].ToString());
                tk.Fullname = dt.Rows[i][2].ToString();
                tk.Permission = dt.Rows[i][3].ToString();
                tklist.Add(tk);
            }

            sqlDataReader.Close();
            return tklist;
        }


        // Phan Quyen Cho Nhan Vien
        public bool PhanQuyenNhanVien(TaiKhoan tk)
        {
            bool isCheck = false;
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_PHANQUYEN_NHANVIEN";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = tk.Id;
            sqlCommand.Parameters.Add("@MAQH", SqlDbType.NChar).Value = tk.Permission;


            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                isCheck = true;
            }

            return isCheck;
        }


        // Hien Thi Ma Quyen Han Len ComboBox
        public DataTable HienThiMaQuyenHanLenComboBox()
        {
            OpenConnection();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MAQH FROM PHANQUYEN", conn);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            return (dt);
        }

        // Search Thong Tin Tai Khoan Nhan Vien Theo Ma Quyen Han
        public List<TaiKhoan> LocThongTinNhaVienTheoMaQh(TaiKhoan tk)
        {
            OpenConnection();
            List<TaiKhoan> tklist = new List<TaiKhoan>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_SearchTaiKhoanNhanVienTheoMaQh";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@MAQH", SqlDbType.NChar).Value = tk.Permission;

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sqlReader);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //TaiKhoan tks = new TaiKhoan();
                tk = new TaiKhoan();
                tk.Id = int.Parse(dt.Rows[i][0].ToString());
                tk.Password = int.Parse(dt.Rows[i][1].ToString());
                tk.Fullname = dt.Rows[i][2].ToString();
                tk.Namepermission = dt.Rows[i][3].ToString();
                tk.Permission = dt.Rows[i][4].ToString();
                tklist.Add(tk);
            }
            sqlReader.Close();
            return tklist;

        }

        // Update Tai KHoan Nhan Vien
        public bool UpdateTaiKhoan(TaiKhoan tk)
        {
            try
            {
                bool isCheck = false;
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_UPDATE_TAIKHOAN";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = tk.Id;
                sqlCommand.Parameters.Add("@PASS", SqlDbType.Int).Value = tk.Password;

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    isCheck = true;
                }

                return isCheck;
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
