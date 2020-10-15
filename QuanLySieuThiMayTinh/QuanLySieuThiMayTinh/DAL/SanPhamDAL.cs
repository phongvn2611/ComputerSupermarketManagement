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
    public class SanPhamDAL : DataConnect
    {
        // Hiển Thị Danh Sách Sản Phẩm Version 2
        #region Hiển Thị Danh Sách Sản Phẩm Version 2
        public List<SanPham> GetAllListSanPham()
        {
            try
            {
                OpenConnection();
                List<SanPham> splist = new List<SanPham>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT ct.*, sp.TENSP,sp.MASX,sp.MALOAI,sp.GIATHANH FROM dbo.SANPHAM AS sp JOIN dbo.CTSP ct ON ct.MASP = sp.MASP";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanPham sp = new SanPham();
                    sp.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    sp.Cpu = dt.Rows[i][1].ToString();
                    sp.Ram = dt.Rows[i][2].ToString();
                    sp.Ocung = dt.Rows[i][3].ToString();
                    sp.CardManHinh = dt.Rows[i][4].ToString();
                    sp.ManHinh = dt.Rows[i][5].ToString();
                    sp.CongKetNoi = dt.Rows[i][6].ToString();
                    sp.Hdt = dt.Rows[i][7].ToString();
                    sp.AmThanh = dt.Rows[i][8].ToString();
                    sp.DiaQuang = dt.Rows[i][9].ToString();
                    sp.GiaoTiepMang = dt.Rows[i][10].ToString();
                    sp.WebCam = dt.Rows[i][11].ToString();
                    sp.Pin = dt.Rows[i][12].ToString();
                    sp.TrongLuong = dt.Rows[i][13].ToString();
                    sp.BaoHanh = dt.Rows[i][14].ToString();
                    sp.TenSp = dt.Rows[i][15].ToString();
                    sp.MaSx = int.Parse(dt.Rows[i][16].ToString());
                    sp.MaLoai = int.Parse(dt.Rows[i][17].ToString());
                    sp.GiaThanhs = double.Parse(dt.Rows[i][18].ToString());

                    splist.Add(sp);
                }
                sqlReader.Close();
                return splist;
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

        // Load Mã Nhà Sản Xuất Lên Comobox
        #region Load Mã Nhà Sản Xuất Lên Comobox
        public DataTable HienThiMaNhaSanXuat()
        {
            try
            {
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MASX FROM dbo.NHASX", conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

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

        // Load Mã Loại Sản Phẩm Lên Comobox
        #region Load Mã Loại Sản Phẩm Lên Comobox
        public DataTable HienThiMaLoaiSP()
        {
            try
            {
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MALOAI FROM dbo.LOAISP", conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

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


        // Hien Thi Ten Nha San Xuat
        #region Hien Thi Ten Nha San Xuat
        public DataTable HienThiTenNhaSanXuat()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TENSX FROM dbo.NHASX", conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

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


        // Hiển Thị Tên Loại Sản Phẩm
        #region Hiển Thị Tên Loại Sản Phẩm
        public DataTable HienThiTenLoaiSanPham()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TENLOAI FROM dbo.LOAISP", conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

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

        // Lấy Mã Sản Xuất Theo Tên Nhà Sản Xuất
        #region Lấy Mã Sản Xuất Theo Tên Nhà Sản Xuất
        public DataTable LayThongTinMaSxTheoTenNhaSx(SanPham sp)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT MASX FROM dbo.NHASX WHERE TENSX = @tensx";
                command.Connection = conn;

                command.Parameters.Add("@tensx", SqlDbType.NVarChar).Value = sp.TenSx;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

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


        // Lấy Mã Loại Sản Phẩm Theo Tên Loại Sản Phẩm
        #region Lấy Mã Loại Sản Phẩm Theo Tên Loại Sản Phẩm
        public DataTable LayThongTinMaLoaiTheoTenLoaiSanPham(SanPham sp)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT MALOAI FROM dbo.LOAISP WHERE TENLOAI = @tenloai";
                command.Connection = conn;

                command.Parameters.Add("@tenloai", SqlDbType.NVarChar).Value = sp.TenLoai;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

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

        // Thêm Sản Phẩm
        #region Thêm Sản Phẩm
        public bool ThemSanPham(SanPham sp)
        {
            try
            {
                bool isCheck = false;

                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Insert_SANPHAM";
                command.Connection = conn;

                command.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TenSp;
                command.Parameters.Add("@MASX", SqlDbType.Int).Value = sp.MaSx;
                command.Parameters.Add("@MALOAI", SqlDbType.Int).Value = sp.MaLoai;
                command.Parameters.Add("@GIATHANH", SqlDbType.Float).Value = sp.GiaThanh;
                command.Parameters.Add("@CPU", SqlDbType.NVarChar).Value = sp.Cpu;
                command.Parameters.Add("@RAM", SqlDbType.NVarChar).Value = sp.Ram;
                command.Parameters.Add("@OCUNG", SqlDbType.NVarChar).Value = sp.Ocung;
                command.Parameters.Add("@MANHINH", SqlDbType.NVarChar).Value = sp.ManHinh;
                command.Parameters.Add("@CARD", SqlDbType.NVarChar).Value = sp.CardManHinh;
                command.Parameters.Add("@PORTCONNECT", SqlDbType.NVarChar).Value = sp.CongKetNoi;
                command.Parameters.Add("@HDT", SqlDbType.NVarChar).Value = sp.Hdt;
                command.Parameters.Add("@AMTHANH", SqlDbType.NVarChar).Value = sp.AmThanh;
                command.Parameters.Add("@DIAQUANG", SqlDbType.NVarChar).Value = sp.DiaQuang;
                command.Parameters.Add("@GIAOTIEP", SqlDbType.NVarChar).Value = sp.GiaoTiepMang;
                command.Parameters.Add("@WEBCAM", SqlDbType.NVarChar).Value = sp.WebCam;
                command.Parameters.Add("@PIN", SqlDbType.NVarChar).Value = sp.Pin;
                command.Parameters.Add("@TRONGLUONG", SqlDbType.NVarChar).Value = sp.TrongLuong;
                command.Parameters.Add("@BAOHANH", SqlDbType.NVarChar).Value = sp.BaoHanh;
                command.Parameters.Add("@NGAYNHAP", SqlDbType.Date).Value = sp.NgayNhap;

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
        #endregion


        // Edt San Pham
        #region Edit San Pham
        public bool EditSanPham(SanPham sp)
        {

            try
            {
                bool isCheck = false;

                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_SANPHAM";
                command.Connection = conn;

                command.Parameters.Add("@MASP", SqlDbType.Int).Value = sp.MaSp;
                command.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TenSp;
                command.Parameters.Add("@MASX", SqlDbType.Int).Value = sp.MaSx;
                command.Parameters.Add("@MALOAI", SqlDbType.Int).Value = sp.MaLoai;
                command.Parameters.Add("@GIATHANH", SqlDbType.Float).Value = sp.GiaThanh;
                command.Parameters.Add("@CPU", SqlDbType.NVarChar).Value = sp.Cpu;
                command.Parameters.Add("@RAM", SqlDbType.NVarChar).Value = sp.Ram;
                command.Parameters.Add("@OCUNG", SqlDbType.NVarChar).Value = sp.Ocung;
                command.Parameters.Add("@MANHINH", SqlDbType.NVarChar).Value = sp.ManHinh;
                command.Parameters.Add("@CARD", SqlDbType.NVarChar).Value = sp.CardManHinh;
                command.Parameters.Add("@PORTCONNECT", SqlDbType.NVarChar).Value = sp.CongKetNoi;
                command.Parameters.Add("@HDT", SqlDbType.NVarChar).Value = sp.Hdt;
                command.Parameters.Add("@AMTHANH", SqlDbType.NVarChar).Value = sp.AmThanh;
                command.Parameters.Add("@DIAQUANG", SqlDbType.NVarChar).Value = sp.DiaQuang;
                command.Parameters.Add("@GIAOTIEP", SqlDbType.NVarChar).Value = sp.GiaoTiepMang;
                command.Parameters.Add("@WEBCAM", SqlDbType.NVarChar).Value = sp.WebCam;
                command.Parameters.Add("@PIN", SqlDbType.NVarChar).Value = sp.Pin;
                command.Parameters.Add("@TRONGLUONG", SqlDbType.NVarChar).Value = sp.TrongLuong;
                command.Parameters.Add("@BAOHANH", SqlDbType.NVarChar).Value = sp.BaoHanh;

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

        #endregion


        // Delete San PHam
        #region
        public bool DeleteSanPham(SanPham sp)
        {
            bool isCheck = false;
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_SANPHAM";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = sp.MaSp;

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


        // Tim Kiem San Pham
        public List<SanPham> TimKiemSanPham(SanPham sp)
        {
            try
            {
                OpenConnection();
                List<SanPham> splist = new List<SanPham>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemSanPham";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = sp.Search;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SanPham sps = new SanPham();
                    sps.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    sps.Cpu = dt.Rows[i][1].ToString();
                    sps.Ram = dt.Rows[i][2].ToString();
                    sps.Ocung = dt.Rows[i][3].ToString();
                    sps.CardManHinh = dt.Rows[i][4].ToString();
                    sps.ManHinh = dt.Rows[i][5].ToString();
                    sps.CongKetNoi = dt.Rows[i][6].ToString();
                    sps.Hdt = dt.Rows[i][7].ToString();
                    sps.AmThanh = dt.Rows[i][8].ToString();
                    sps.DiaQuang = dt.Rows[i][9].ToString();
                    sps.GiaoTiepMang = dt.Rows[i][10].ToString();
                    sps.WebCam = dt.Rows[i][11].ToString();
                    sps.Pin = dt.Rows[i][12].ToString();
                    sps.TrongLuong = dt.Rows[i][13].ToString();
                    sps.BaoHanh = dt.Rows[i][14].ToString();
                    sps.TenSp = dt.Rows[i][15].ToString();
                    sps.MaSx = int.Parse(dt.Rows[i][16].ToString());
                    sps.MaLoai = int.Parse(dt.Rows[i][17].ToString());
                    sps.GiaThanhs = double.Parse(dt.Rows[i][18].ToString());

                    splist.Add(sps);
                }

                sqlReader.Close();
                return splist;
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


        // Loc San Pham
        public List<SanPham> LocDanhSachSanhPham(SanPham sp)
        {
            try
            {
                OpenConnection();
                List<SanPham> splist = new List<SanPham>();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (sp.Search == "Mã Sản Phẩm")
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT MASP FROM dbo.SANPHAM";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.MaSp = int.Parse(dt.Rows[i][0].ToString());

                        splist.Add(sps);
                    }

                }
                else if (sp.Search == "Tên Sản Phẩm")
                {
                    sqlCommand.CommandText = "SELECT TENSP FROM dbo.SANPHAM";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.TenSp = dt.Rows[i][0].ToString();

                        splist.Add(sps);
                    }

                }
                else if (sp.Search == "Mã Sản Xuất")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MASX) FROM dbo.SANPHAM";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.MaSx = int.Parse(dt.Rows[i][0].ToString());

                        splist.Add(sps);
                    }
                }
                else if (sp.Search == "Tên Sản Xuất")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(TENSX) FROM dbo.NHASX";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.TenSx = dt.Rows[i][0].ToString();

                        splist.Add(sps);
                    }

                }
                else if (sp.Search == "Mã Loại")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(MALOAI) FROM dbo.SANPHAM";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.MaLoai = int.Parse(dt.Rows[i][0].ToString());

                        splist.Add(sps);
                    }
                }
                else if (sp.Search == "Tên Loại")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(TENLOAI) FROM dbo.LOAISP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SanPham sps = new SanPham();
                        sps.TenLoai = dt.Rows[i][0].ToString();

                        splist.Add(sps);
                    }

                }
                sqlReader.Close();
                return splist;

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
