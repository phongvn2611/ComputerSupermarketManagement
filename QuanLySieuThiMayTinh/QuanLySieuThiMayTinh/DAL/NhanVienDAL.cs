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
    public class NhanVienDAL : DataConnect
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            OpenConnection();

            bool checkInsert = false;
            // gọi câu truy vấn thêm Nhân Viên
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_Insert_NhanVien";
            command.Connection = conn;

            command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
            command.Parameters.Add("@GT", SqlDbType.NChar).Value = nv.GioTinh;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.Sdt;
            command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = nv.Mail;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
            command.Parameters.Add("@NGAYLAM", SqlDbType.DateTime).Value = nv.NgayLam;

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                checkInsert = true;
            }

            return checkInsert;
        }

        public List<NhanVien> GetAllLISTEmployee()
        {
            OpenConnection();
            List<NhanVien> nvlist = new List<NhanVien>();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM dbo.NHANVIEN";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nv1 = new NhanVien();
                    nv1.MaNv = int.Parse(dt.Rows[i][0].ToString());
                    nv1.Hoten = dt.Rows[i][1].ToString();
                    nv1.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    nv1.GioTinh = dt.Rows[i][3].ToString();
                    nv1.Sdt = dt.Rows[i][4].ToString();
                    nv1.Mail = dt.Rows[i][5].ToString();
                    nv1.DiaChi = dt.Rows[i][6].ToString();
                    nv1.NgayLam = DateTime.Parse(dt.Rows[i][7].ToString());
                    nvlist.Add(nv1);
                }

                sqlReader.Close();
                return nvlist;

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


        // Update Nhan Vien
        public bool EditNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();

                bool checkUpdate = false;

                // gọi câu truy vấn thêm Nhân Viên
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_NHANVIEN";
                command.Connection = conn;

                command.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MaNv;
                command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nv.Hoten;
                command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
                command.Parameters.Add("@GT", SqlDbType.NChar).Value = nv.GioTinh;
                command.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.Sdt;
                command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = nv.Mail;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
                command.Parameters.Add("@NGAYLAM", SqlDbType.DateTime).Value = nv.NgayLam;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    checkUpdate = true;
                }

                return checkUpdate;
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


        public List<NhanVien> TimKiemNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();
                List<NhanVien> nvlist = new List<NhanVien>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemNhanVien";

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = nv.Search;
              
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nvs = new NhanVien();
                    nvs.MaNv = int.Parse(dt.Rows[i][0].ToString());
                    nvs.Hoten = dt.Rows[i][1].ToString();
                    nvs.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    nvs.GioTinh = dt.Rows[i][3].ToString();
                    nvs.Sdt = dt.Rows[i][4].ToString();
                    nvs.Mail = dt.Rows[i][5].ToString();
                    nvs.DiaChi = dt.Rows[i][6].ToString();
                    nvs.NgayLam = DateTime.Parse(dt.Rows[i][7].ToString());

                    nvlist.Add(nvs);
                }
                sqlReader.Close();

                return nvlist;
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

        //Delete NhanVien
        public bool DeleteNhanVien(NhanVien nv)
        {
            OpenConnection();
            bool isCheck = false;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_DELETE_NHANVIEN";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = nv.MaNv;

            int result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                isCheck = true;
            }

            return isCheck;

        }

        // Loc Nhan Vien
        public List<NhanVien> LocDSNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();
                List<NhanVien> nvlist = new List<NhanVien>();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (nv.Search == "Mã Nhân Viên")
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT MANV FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.MaNv = int.Parse(dt.Rows[i][0].ToString());

                        nvlist.Add(nvs);
                    }

                }
                else if (nv.Search == "Họ Tên")
                {
                    sqlCommand.CommandText = "SELECT HOTEN FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Hoten = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }

                }
                else if (nv.Search == "Ngày Sinh")
                {
                    sqlCommand.CommandText = "SELECT NGAYSINH FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.NgaySinh = DateTime.Parse(dt.Rows[i][0].ToString());

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Điện Thoại")
                {
                    sqlCommand.CommandText = "SELECT SDT FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Sdt = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Mail")
                {
                    sqlCommand.CommandText = "SELECT MAIL FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.Mail = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }
                }
                else if (nv.Search == "Giới Tính")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(GT) FROM dbo.NHANVIEN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhanVien nvs = new NhanVien();
                        nvs.GioTinh = dt.Rows[i][0].ToString();

                        nvlist.Add(nvs);
                    }

                }

                sqlReader.Close();
                return nvlist;

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
