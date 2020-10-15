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
    public class LoaiSanPhamDAL : DataConnect
    {
        public List<LoaiSanPham> GetAllListLoaiSp()
        {
            try
            {
                OpenConnection();
                List<LoaiSanPham> lsplist = new List<LoaiSanPham>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM dbo.LOAISP";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.MaLoai = int.Parse(dt.Rows[i][0].ToString());
                    lsp.TenLoai = dt.Rows[i][1].ToString();
                    lsp.Dvt = dt.Rows[i][2].ToString();

                    lsplist.Add(lsp);
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

        public bool ThemLoaiSanPham(LoaiSanPham lsp)
        {
            bool loaispCheck = false;

            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_Insert_LOAISP";
            command.Connection = conn;

            command.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lsp.TenLoai;
            command.Parameters.Add("@DVT", SqlDbType.NChar).Value = lsp.Dvt;

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                loaispCheck = true;
            }
            return loaispCheck;
        }


        public bool SuaLoaiSanPham(LoaiSanPham lsp)
        {

            bool isCheck = false;
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_UPDATE_LOAISP";
            command.Connection = conn;

            command.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lsp.MaLoai;
            command.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = lsp.TenLoai;
            command.Parameters.Add("@DVT", SqlDbType.NChar).Value = lsp.Dvt;

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                isCheck = true;
            }
            return isCheck;
        }

        //Delete Loại Sản Phẩm
        public bool DeleteLoaiSanPham(LoaiSanPham lsp)
        {
            bool isCheck = false;

            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_LOAISP";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MALOAI", SqlDbType.Int).Value = lsp.MaLoai;

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

        // Tim Kiem Loai San Pham
        public List<LoaiSanPham> TimKiemLoaiSanPham(LoaiSanPham lsp)
        {
            try
            {
                OpenConnection();
                List<LoaiSanPham> lsplist = new List<LoaiSanPham>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemLoaiSanPham";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = lsp.Search;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiSanPham lsps = new LoaiSanPham();
                    lsps.MaLoai = int.Parse(dt.Rows[i][0].ToString());
                    lsps.TenLoai = dt.Rows[i][1].ToString();
                    lsps.Dvt = dt.Rows[i][2].ToString();

                    lsplist.Add(lsps);
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


        // Load Danh Loai San Pham
        public List<LoaiSanPham> LoadDanhSachLoaiSanPham(LoaiSanPham lsp)
        {
            try
            {
                OpenConnection();
                List<LoaiSanPham> lsplist = new List<LoaiSanPham>();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (lsp.Search == "Mã Loại")
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT MALOAI FROM dbo.LOAISP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        LoaiSanPham lsps = new LoaiSanPham();
                        lsps.MaLoai = int.Parse(dt.Rows[i][0].ToString());

                        lsplist.Add(lsps);
                    }

                }
                else if (lsp.Search == "Tên Loại")
                {
                    sqlCommand.CommandText = "SELECT TENLOAI FROM dbo.LOAISP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        LoaiSanPham lsps = new LoaiSanPham();
                        lsps.TenLoai = dt.Rows[i][0].ToString();

                        lsplist.Add(lsps);
                    }

                }
                else if (lsp.Search == "Đơn Vị Tính")
                {
                    sqlCommand.CommandText = "SELECT DISTINCT(DVT) FROM dbo.LOAISP";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        LoaiSanPham lsps = new LoaiSanPham();
                        lsps.Dvt = dt.Rows[i][0].ToString();

                        lsplist.Add(lsps);
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
