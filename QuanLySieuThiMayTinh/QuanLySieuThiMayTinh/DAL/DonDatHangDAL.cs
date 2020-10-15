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
    public class DonDatHangDAL : DataConnect
    {

        // Hiển thị danh sách Đơn Đặt Hàng Version 2
        #region Hiển thị danh sách Đơn Đặt Hàng Version 2
        public List<DonDatHang> GetAllListDonDatHang()
        {
            try
            {
                OpenConnection();
                List<DonDatHang> dhlist = new List<DonDatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT dh.*,ct.MASP,ct.SLDH FROM dbo.DONDH AS dh JOIN dbo.CTDH ct ON ct.MADH = dh.MADH ";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DonDatHang dh = new DonDatHang();
                    dh.MaDh = int.Parse(dt.Rows[i][0].ToString());
                    dh.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    dh.MaCc = int.Parse(dt.Rows[i][2].ToString());
                    dh.NgayDh = DateTime.Parse(dt.Rows[i][3].ToString());
                    dh.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    dh.SlDh = int.Parse(dt.Rows[i][5].ToString());

                    dhlist.Add(dh);
                }
                sqlReader.Close();
                return dhlist;

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
        #endregion

        // Thêm Đơn Đặt Hàng
        #region Thêm Đơn Đặt Hàng
        public bool ThemDonHang(DonDatHang dh)
        {
            try
            {
                bool isCheck = false;
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Insert_DONDH";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = dh.MaNv;
                sqlCommand.Parameters.Add("@MACC", SqlDbType.Int).Value = dh.MaCc;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = dh.MaSp;
                sqlCommand.Parameters.Add("@SLDH", SqlDbType.Int).Value = dh.SlDh;
                sqlCommand.Parameters.Add("@NGDH", SqlDbType.DateTime).Value = dh.NgayDh;

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

        #endregion


        // Edit Đơn Đặt Hàng
        #region
        public bool EditDonDathang(DonDatHang dh)
        {
            try
            {
                bool isCheck = false;
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_UPDATE_DONDH";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = dh.MaDh;
                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = dh.MaNv;
                sqlCommand.Parameters.Add("@MACC", SqlDbType.Int).Value = dh.MaCc;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = dh.MaSp;
                sqlCommand.Parameters.Add("@SLDH", SqlDbType.Int).Value = dh.SlDh;
                sqlCommand.Parameters.Add("@NGDH", SqlDbType.DateTime).Value = dh.NgayDh;

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
        #endregion

        // Delete Don Dat Hang
        #region Delete Don Dat Hang
        public bool DeleteDonDatHang(DonDatHang dh)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_DONDH";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = dh.MaDh;

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
        #endregion

        // Load Data Lên ComboBox Nhà Cung Cấp
        #region Load Data Lên ComboBox Nhà Cung Cấp
        public DataTable LoadDataComboBoxMaCC()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MACC FROM dbo.NHACC", conn);
                DataTable dt = new DataTable();

                sqlDataAdapter.Fill(dt);

                return (dt);
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

        #endregion

        //Hiển thị Mã Sản Phẩm
        #region Hiển thị Mã Sản Phẩm
        public DataTable HienThiMaSp()
        {
            OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MASP FROM dbo.SANPHAM", conn);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return (dt);

        }
        #endregion

        #region
        public DataTable HienThiTenSpTheoMaSp(DonDatHang dh)
        {
            try
            {
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TENSP FROM dbo.SANPHAM WHERE MASP=@MASP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = dh.MaSp;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable();

                sqlData.Fill(dt);

                return (dt);
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
        #endregion

        // Hiển Thị Tên Nhà Cung Câp Theo Mã Cung Câp
        #region Hiển Thị Tên Nhà Cung Câp Theo Mã Cung Câp
        public DataTable HienThiTenNhaCCTheoMacc(DonDatHang dh)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT TENCC FROM dbo.NHACC WHERE MACC=@macc";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@macc", SqlDbType.Int).Value = dh.MaCc;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            return (dt);

        }

        #endregion

        // TIm Kiem Don Dat Hang
        public List<DonDatHang> TimKiemDonDatHang(DonDatHang ddh)
        {
            try
            {
                OpenConnection();
                List<DonDatHang> dhlist = new List<DonDatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemDonDatHang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = ddh.Search;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DonDatHang dh = new DonDatHang();
                    dh.MaDh = int.Parse(dt.Rows[i][0].ToString());
                    dh.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    dh.MaCc = int.Parse(dt.Rows[i][2].ToString());
                    dh.NgayDh = DateTime.Parse(dt.Rows[i][3].ToString());
                    dh.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    dh.SlDh = int.Parse(dt.Rows[i][5].ToString());

                    dhlist.Add(dh);
                }

                sqlReader.Close();
                return dhlist;
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


        // Loc Danh Sach Don Hang
        public List<DonDatHang> LocDanhSachDonHang(DonDatHang dh)
        {
            try
            {
                OpenConnection();
                List<DonDatHang> lsplist = new List<DonDatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();


                if (dh.Search == "Mã Đơn Hàng")
                {

                    sqlCommand.CommandText = "SELECT MADH FROM dbo.DONDH";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DonDatHang dhs = new DonDatHang();
                        dhs.MaDh = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(dhs);
                    }

                }
                else if (dh.Search == "Mã Nhân Viên")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MANV) FROM dbo.DONDH";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DonDatHang dhs = new DonDatHang();
                        dhs.MaNv = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(dhs);
                    }

                }
                else if (dh.Search == "Mã Cung Cấp")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MACC) FROM dbo.DONDH";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DonDatHang dhs = new DonDatHang();
                        dhs.MaCc = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(dhs);
                    }

                }
                else if (dh.Search == "Mã Sản Phẩm")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MASP) FROM dbo.CTDH";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DonDatHang dhs = new DonDatHang();
                        dhs.MaSp = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(dhs);
                    }

                }
                else if (dh.Search == "Số Lượng Đặt")
                {
                    sqlCommand.CommandText = "SELECT SLDH FROM dbo.CTDH";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DonDatHang dhs = new DonDatHang();
                        dhs.SlDh = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(dhs);
                    }

                }
                sqlReader.Close();
                return lsplist;

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
