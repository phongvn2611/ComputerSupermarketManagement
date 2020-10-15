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
    public class PhieuNhapDAL : DataConnect
    {
        // Hiên thị danh sách Phiếu Nhập
        public List<PhieuNhapHang> GetAllListPhieuNhap()
        {
            try
            {
                OpenConnection();
                List<PhieuNhapHang> pnlist = new List<PhieuNhapHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT pn.*, ct.MASP,ct.SLN,ct.DONGIA FROM dbo.PHIEUNHAP AS pn JOIN dbo.CTPN AS ct ON ct.MAPN = pn.MAPN";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuNhapHang pn = new PhieuNhapHang();
                    pn.MaPn = int.Parse(dt.Rows[i][0].ToString());
                    pn.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    pn.NgayNhap = DateTime.Parse(dt.Rows[i][2].ToString());
                    pn.MaDh = int.Parse(dt.Rows[i][3].ToString());
                    pn.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    pn.Sln = int.Parse(dt.Rows[i][5].ToString());
                    pn.DonGias = double.Parse(dt.Rows[i][6].ToString());

                    pnlist.Add(pn);
                }
                sqlReader.Close();
                return pnlist;
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

        // Load Mã Nhà Cung Cấp Lên ComboBox 
        public DataTable HienThiMaDonDatHang()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MADH FROM dbo.DONDH", conn);

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

        // Hiển Thị Thông Chi Cho Phiếu Nhập
        public List<PhieuNhapHang> HienThiThongTinChoPhieuNhap(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                List<PhieuNhapHang> pnlist = new List<PhieuNhapHang>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_HienThiDanhSachDonDhChoPhieuNhap";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = pn.MaDh;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuNhapHang pns = new PhieuNhapHang();
                    pns.Sld = int.Parse(dt.Rows[i][0].ToString());
                    pns.MaSp = int.Parse(dt.Rows[i][1].ToString());
                    pns.Sln = int.Parse(dt.Rows[i][2].ToString());
                    if (pns.Sln == pns.Sld)
                    {
                        pns.MaPn = int.Parse(dt.Rows[i][3].ToString());
                        pns.DonGias = double.Parse(dt.Rows[i][4].ToString());
                    }
                    else
                    {
                        pns.DonGias = double.Parse(dt.Rows[i][4].ToString());
                    }
                    pnlist.Add(pns);
                }
                sqlReader.Close();

                return pnlist;
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

        // Hiển Thị Giá Sản Phẩm Theo Mã Sản PHẩm
        public DataTable HienThiGiaThanhMaSp(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.CommandType = CommandType.Text;
                sqlcommand.CommandText = "SELECT GIATHANH FROM dbo.SANPHAM WHERE MASP = @MASP";
                sqlcommand.Connection = conn;

                sqlcommand.Parameters.Add("@MASP", SqlDbType.Int).Value = pn.MaSp;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);

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

        // Load Mã Sản Phẩm Lên ComboBox
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

        // Thêm Phiếu Nhập
        public bool ThemPhieuNhap(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Insert_PHIEUNHAP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = pn.MaNv;
                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = pn.MaDh;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = pn.MaSp;
                sqlCommand.Parameters.Add("@SLN", SqlDbType.Int).Value = pn.Sln;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Money).Value = pn.DonGias;
                sqlCommand.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime).Value = pn.NgayNhap;

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

        // Edit Phieu Nhap
        public bool EditPhieuNhap(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                bool isCheck = false;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_UPDATE_PHIEUNHAP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MAPN", SqlDbType.Int).Value = pn.MaPn;
                sqlCommand.Parameters.Add("@MANV", SqlDbType.Int).Value = pn.MaNv;
                sqlCommand.Parameters.Add("@MADH", SqlDbType.Int).Value = pn.MaDh;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = pn.MaSp;
                sqlCommand.Parameters.Add("@SLN", SqlDbType.Int).Value = pn.Sln;
                sqlCommand.Parameters.Add("@DONGIA", SqlDbType.Money).Value = pn.DonGias;
                sqlCommand.Parameters.Add("@NGAYNHAP", SqlDbType.DateTime).Value = pn.NgayNhap;

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

        // Delete Phieu Nhap
        public bool DeletePhieuNhap(PhieuNhapHang pn)
        {
            try
            {

                bool isCheck = false;
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_PHIEUNHAP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MAPN", SqlDbType.Int).Value = pn.MaPn;
                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = pn.MaSp;

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

        // Tim Kiem Phieu Nap
        public List<PhieuNhapHang> TimKiemPhieuNhap(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                List<PhieuNhapHang> pnlist = new List<PhieuNhapHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemPhieuNhap";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = pn.Search;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhieuNhapHang pns = new PhieuNhapHang();
                    pns.MaPn = int.Parse(dt.Rows[i][0].ToString());
                    pns.MaNv = int.Parse(dt.Rows[i][1].ToString());
                    pns.NgayNhap = DateTime.Parse(dt.Rows[i][2].ToString());
                    pns.MaDh = int.Parse(dt.Rows[i][3].ToString());
                    pns.MaSp = int.Parse(dt.Rows[i][4].ToString());
                    pns.Sln = int.Parse(dt.Rows[i][5].ToString());
                    pns.DonGias = double.Parse(dt.Rows[i][6].ToString());

                    pnlist.Add(pns);
                }

                sqlReader.Close();
                return pnlist;
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

        // Loc Danh Sach Phieu Nhap
        public List<PhieuNhapHang> LocDanhSachPhieuNhap(PhieuNhapHang pn)
        {
            try
            {
                OpenConnection();
                List<PhieuNhapHang> pnlist = new List<PhieuNhapHang>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (pn.Search == "Mã Phiếu Nhập")
                {
                    sqlCommand.CommandText = "SELECT MAPN FROM dbo.PHIEUNHAP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuNhapHang pnh = new PhieuNhapHang();
                        pnh.MaPn = int.Parse(dt.Rows[i][0].ToString());

                        pnlist.Add(pnh);
                    }

                }
                else if (pn.Search == "Mã Nhân Viên")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MANV) FROM dbo.PHIEUNHAP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuNhapHang pnh = new PhieuNhapHang();
                        pnh.MaNv = int.Parse(dt.Rows[i][0].ToString());

                        pnlist.Add(pnh);
                    }

                }
                else if (pn.Search == "Mã Đơn Hàng")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MADH) FROM dbo.PHIEUNHAP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuNhapHang pnh = new PhieuNhapHang();
                        pnh.MaDh = int.Parse(dt.Rows[i][0].ToString());

                        pnlist.Add(pnh);
                    }
                }
                else if (pn.Search == "Mã Sản Phẩm")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MASP) FROM dbo.CTPN";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PhieuNhapHang pnh = new PhieuNhapHang();
                        pnh.MaSp = int.Parse(dt.Rows[i][0].ToString());

                        pnlist.Add(pnh);
                    }
                }

                sqlReader.Close();
                return pnlist;

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
