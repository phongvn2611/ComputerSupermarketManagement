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
    public class PhieuXuatDAL : DataConnect
    {

        // Hiển thị danh sách Phiếu Xuất Hàng
        #region Hiển thị danh sách Phiếu Xuất Hàng
        public List<PhieuXuatHang> GetAllListPhieuNhap()
        {
            try
            {
                OpenConnection();
                List<PhieuXuatHang> pxlist = new List<PhieuXuatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT px.*,ct.MASP,ct.SLX,ct.PHANTRAM,ct.THANHTIEN FROM dbo.PHIEUXUAT AS px JOIN dbo.CTPX ct ON ct.MAPX = px.MAPX";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuXuatHang px = new PhieuXuatHang();
                    px.MaPx = int.Parse(dt.Rows[i][0].ToString());
                    px.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    px.MaKh = int.Parse(dt.Rows[i][2].ToString());
                    px.NgayXuat = DateTime.Parse(dt.Rows[i][3].ToString());
                    //px.MaDh = int.Parse(dt.Rows[i][4].ToString());
                    px.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    px.Slx = int.Parse(dt.Rows[i][5].ToString());
                    px.PhanTram = float.Parse(dt.Rows[i][6].ToString());
                    px.ThanhTiens = double.Parse(dt.Rows[i][7].ToString());

                    pxlist.Add(px);
                }
                sqlReader.Close();
                return pxlist;

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

        // Hiển thị Mã Khách Hàng
        #region Hiển thị Mã Khách Hàng
        public DataTable HienThiMaKhachHang()
        {
            try
            {
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MAKH FROM dbo.KHACHHANG", conn);

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

        // Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        #region Hiển thị Tên Khách Hàng Theo Mã Khách Hàng
        public DataTable HienThiTenKhTheoMaKh(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TENKH FROM dbo.KHACHHANG WHERE MAKH=@makh";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = px.MaKh;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

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



        // Hiển thị Mã Sản Phẩm
        #region Hiển thị Mã Sản Phẩm
        public DataTable HienThiMaSanPham()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MASP FROM dbo.SANPHAM", conn);

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


        // Hiển thị Tên Sản Phẩm Theo Mã Sản Phẩm
        #region Hiển thị Tên Sản Phẩm Theo Mã Sản Phẩm
        public DataTable HienThiTenSpTheoMaSp(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TENSP FROM dbo.SANPHAM WHERE MASP=@MASP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;

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

        // Hiển thị Số Lượng Đơn Hàng
        #region Hiển thị Số Lượng Xuất Hàng
        public DataTable HienThiSoLuongXuấtHang()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT SLDH FROM dbo.CTDH", conn);

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

        // Thêm PHIẾU Xuất HÀNG
        #region Thêm Phiếu Xuất Hàng
        public bool ThemPhieuXuatHang(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Insert_PHIEUXUAT";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = px.MaNv;
                sqlCommand.Parameters.Add("@MAKH", SqlDbType.Int).Value = px.MaKh;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;
                sqlCommand.Parameters.Add("@SLX", SqlDbType.Int).Value = px.Slx;
                //sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Float).Value = px.DonGia;
                sqlCommand.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime).Value = px.NgayXuat;
                //sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = px.MaDh;
                sqlCommand.Parameters.Add("@PHANTRAM", SqlDbType.Real).Value = px.PhanTram;

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


        // Hiển Thị Thông Tin PHiếu Xuất Theo Mã Đơn Hàng
        #region
        public List<PhieuXuatHang> HienThiThongTinPhieuXuatTheoMaDh(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                List<PhieuXuatHang> pxlist = new List<PhieuXuatHang>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Select_ThongTinPhieuXuatTheoMaDh";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = px.MaDh;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuXuatHang pxh = new PhieuXuatHang();
                    pxh.MaDh = int.Parse(dt.Rows[i][0].ToString());
                    pxh.MaSp = int.Parse(dt.Rows[i][1].ToString());
                    pxh.Slx = int.Parse(dt.Rows[i][2].ToString());

                    pxlist.Add(pxh);
                }
                sqlReader.Close();
                return pxlist;

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

        // Edit Phieu Xuat
        #region Edit Phieu Xuat
        public bool EditPhieuXuat(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();

                bool isCheck = false;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_UPDATE_PHIEUXUAT";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = px.MaNv;
                sqlCommand.Parameters.Add("@MAKH", SqlDbType.Int).Value = px.MaKh;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;
                sqlCommand.Parameters.Add("@SLX", SqlDbType.Int).Value = px.Slx;
                sqlCommand.Parameters.Add("@PHANTRAM", SqlDbType.Real).Value = px.PhanTram;
                sqlCommand.Parameters.Add("@THANHTIEN", SqlDbType.Money).Value = px.ThanhTiens;
                sqlCommand.Parameters.Add("@NGAYXUAT", SqlDbType.DateTime).Value = px.NgayXuat;
                sqlCommand.Parameters.Add("@MAPX", SqlDbType.Int).Value = px.MaPx;

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

        // Xoa Phieu Xuat Hang
        #region Delete Phieu Xuat
        public bool DeletePhieuXuat(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_PHIEUXUAT";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MAPX", SqlDbType.Int).Value = px.MaPx;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;

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

        // Select GiaThanh San PHam
        #region SelectGiaThanhSanPham
        public DataTable SelectGiaThanhSanPham(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT GIATHANH FROM SANPHAM WHERE MASP=@MASP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;

                SqlDataAdapter sqlReader = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable();

                sqlReader.Fill(dt);

                return dt;
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

        // Tim Kiem Phieu Xuat
        public List<PhieuXuatHang> TimKiemPhieuXuatHang(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                List<PhieuXuatHang> pxlist = new List<PhieuXuatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemPhieuXuat";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = px.Search;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuXuatHang pxh = new PhieuXuatHang();
                    pxh.MaPx = int.Parse(dt.Rows[i][0].ToString());
                    pxh.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    pxh.MaKh = int.Parse(dt.Rows[i][2].ToString());
                    pxh.NgayXuat = DateTime.Parse(dt.Rows[i][3].ToString());
                    pxh.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    pxh.Slx = int.Parse(dt.Rows[i][5].ToString());
                    pxh.PhanTram = float.Parse(dt.Rows[i][6].ToString());
                    pxh.ThanhTiens = double.Parse(dt.Rows[i][7].ToString());

                    pxlist.Add(pxh);
                }

                sqlReader.Close();
                return pxlist;
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


        // Loc Danh Sach Phieu Xuat Hang
        public List<PhieuXuatHang> LocDanhSachPhieuXuatHang(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                List<PhieuXuatHang> pxlist = new List<PhieuXuatHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (px.Search == "Mã Phiếu Xuất")
                {
                    sqlCommand.CommandText = "SELECT px.MAPX FROM dbo.PHIEUXUAT AS px JOIN dbo.CTPX AS ct ON ct.MAPX = px.MAPX ";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuXuatHang pxh = new PhieuXuatHang();
                        pxh.MaPx = int.Parse(dt.Rows[i][0].ToString());

                        pxlist.Add(pxh);
                    }

                }
                else if (px.Search == "Mã Nhân Viên")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MANV) FROM dbo.PHIEUXUAT";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuXuatHang pxh = new PhieuXuatHang();
                        pxh.MaNv = int.Parse(dt.Rows[i][0].ToString());

                        pxlist.Add(pxh);
                    }

                }
                else if (px.Search == "Mã Khách Hàng")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MAKH) FROM dbo.PHIEUXUAT";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuXuatHang pxh = new PhieuXuatHang();
                        pxh.MaKh = int.Parse(dt.Rows[i][0].ToString());

                        pxlist.Add(pxh);
                    }
                }
                else if (px.Search == "Mã Sản Phẩm")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MASP) FROM dbo.CTPX";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuXuatHang pxh = new PhieuXuatHang();
                        pxh.MaSp = int.Parse(dt.Rows[i][0].ToString());

                        pxlist.Add(pxh);
                    }
                }

                sqlReader.Close();
                return pxlist;

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


        // Hien Thi So Luong To Kho Theo Ma San Pham
        public DataTable TongSoLuongTonTheoMaSp(PhieuXuatHang px)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_HienThiTongSltTheoMaSp";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = px.MaSp;

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
    }
}
