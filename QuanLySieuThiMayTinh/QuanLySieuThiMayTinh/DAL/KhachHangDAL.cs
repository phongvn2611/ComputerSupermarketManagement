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
    public class KhachHangDAL : DataConnect
    {
        public List<KhachHang> GetAllListCustomer()
        {
            try
            {

                List<KhachHang> khlist = new List<KhachHang>();
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT *FROM dbo.KHACHHANG";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKh = int.Parse(dt.Rows[i][0].ToString());
                    kh.Hoten = dt.Rows[i][1].ToString();
                    kh.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    kh.GioiTinh = dt.Rows[i][3].ToString();
                    kh.Sdt = dt.Rows[i][4].ToString();
                    kh.Mail = dt.Rows[i][5].ToString();
                    kh.DiaChi = dt.Rows[i][6].ToString();
                    kh.NgayDk = DateTime.Parse(dt.Rows[i][7].ToString());

                    khlist.Add(kh);
                }
                sqlReader.Close();
                return khlist;
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


        // Insert KHACHHANG
        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                OpenConnection();

                bool checkInsert = false;

                // gọi câu truy vấn thêm Khách Hàng
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Insert_KHACHHANG";
                command.Connection = conn;

                command.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.Hoten;
                command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = kh.NgaySinh;
                command.Parameters.Add("@GT", SqlDbType.NChar).Value = kh.GioiTinh;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.Sdt;
                command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = kh.Mail;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = kh.DiaChi;
                command.Parameters.Add("@NGAYDK", SqlDbType.DateTime).Value = kh.NgayDk;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    checkInsert = true;
                }

                return checkInsert;
            }
            catch
            {
                throw;
            }
        }


        // Edit KHACHHANG
        public bool EditKhachHang(KhachHang kh)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_KHACHHANG";
                command.Connection = conn;

                command.Parameters.Add("@MAKH", SqlDbType.Int).Value = kh.MaKh;
                command.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.Hoten;
                command.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = kh.NgaySinh;
                command.Parameters.Add("@GT", SqlDbType.NChar).Value = kh.GioiTinh;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.Sdt;
                command.Parameters.Add("@MAIL", SqlDbType.NChar).Value = kh.Mail;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = kh.DiaChi;
                command.Parameters.Add("@NGAYDK", SqlDbType.DateTime).Value = kh.NgayDk;

                int result = command.ExecuteNonQuery();
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


        // Delete Khách Hàng
        public bool DeleteKhachHang(KhachHang kh)
        {
            bool isCheck = false;
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_KHACHHANG";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MAKH", SqlDbType.Int).Value = kh.MaKh;

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

        // Loc Nhan Vien
        public List<KhachHang> LocDanhSachKhachHang(KhachHang nv)
        {
            try
            {
                OpenConnection();

                List<KhachHang> khlist = new List<KhachHang>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (nv.Search == "Mã Khách Hàng")
                {

                    sqlCommand.CommandText = "SELECT MAKH FROM dbo.KHACHHANG";
                    sqlCommand.Connection = conn;

                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        KhachHang khs = new KhachHang();
                        khs.MaKh = int.Parse(dt.Rows[i][0].ToString());

                        khlist.Add(khs);
                    }

                }
                else if (nv.Search == "Họ Tên")
                {
                    sqlCommand.CommandText = "SELECT TENKH FROM dbo.KHACHHANG";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        KhachHang khs = new KhachHang();
                        khs.Hoten = dt.Rows[i][0].ToString();

                        khlist.Add(khs);
                    }

                }
                else if (nv.Search == "Số Điện Thoại")
                {
                    sqlCommand.CommandText = "SELECT SDT FROM dbo.KHACHHANG";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        KhachHang khs = new KhachHang();
                        khs.Sdt = dt.Rows[i][0].ToString();

                        khlist.Add(khs);
                    }
                }
                else if (nv.Search == "Mail")
                {
                    sqlCommand.CommandText = "SELECT MAIL FROM dbo.KHACHHANG";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        KhachHang khs = new KhachHang();
                        khs.Mail = dt.Rows[i][0].ToString();

                        khlist.Add(khs);
                    }
                }
                else if (nv.Search == "Giới Tính")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(GT) FROM dbo.KHACHHANG";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        KhachHang khs = new KhachHang();
                        khs.GioiTinh = dt.Rows[i][0].ToString();

                        khlist.Add(khs);
                    }

                }

                sqlReader.Close();
                return khlist;

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


        public List<KhachHang> TimKiemKhachHang(KhachHang kh)
        {
            try
            {
                OpenConnection();
                List<KhachHang> khlist = new List<KhachHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemKhachHang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = kh.Search;


                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang khs = new KhachHang();
                    khs.MaKh = int.Parse(dt.Rows[i][0].ToString());
                    khs.Hoten = dt.Rows[i][1].ToString();
                    khs.NgaySinh = DateTime.Parse(dt.Rows[i][2].ToString());
                    khs.GioiTinh = dt.Rows[i][3].ToString();
                    khs.Sdt = dt.Rows[i][4].ToString();
                    khs.Mail = dt.Rows[i][5].ToString();
                    khs.DiaChi = dt.Rows[i][6].ToString();
                    khs.NgayDk = DateTime.Parse(dt.Rows[i][7].ToString());

                    khlist.Add(khs);
                }
                sqlReader.Close();

                return khlist;
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
