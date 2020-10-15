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
    public class NhaCungCapDAL : DataConnect
    {
        public List<NhaCungCap> GetAllListNhaCungCap()
        {
            try
            {
                OpenConnection();
                List<NhaCungCap> ncclist = new List<NhaCungCap>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT *FROM dbo.NHACC";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaCC = int.Parse(dt.Rows[i][0].ToString());
                    ncc.TenCC = dt.Rows[i][1].ToString();
                    ncc.DiaChi = dt.Rows[i][2].ToString();
                    ncc.Sdt = dt.Rows[i][3].ToString();

                    ncclist.Add(ncc);
                }
                sqlReader.Close();
                return ncclist;
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

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                OpenConnection();
                bool nhaccCheck = false;

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Insert_NHACC";
                command.Connection = conn;

                command.Parameters.Add("@TENCC", SqlDbType.NVarChar).Value = ncc.TenCC;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DiaChi;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = ncc.Sdt;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    nhaccCheck = true;
                }

                return nhaccCheck;
            }
            catch
            {
                throw;
            }
        }


        public bool SuNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                OpenConnection();
                bool nhaccCheck = false;

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_UPDATE_NHACC";
                command.Connection = conn;

                command.Parameters.Add("@TENCC", SqlDbType.NVarChar).Value = ncc.TenCC;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DiaChi;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = ncc.Sdt;
                command.Parameters.Add("@MACC", SqlDbType.Int).Value = ncc.MaCC;

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    nhaccCheck = true;
                }

                return nhaccCheck;
            }
            catch
            {
                throw;
            }
        }

        public bool DeleteNhaCungCap(NhaCungCap ncc)
        {
            bool isCheck = false;
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DELETE_NHACC";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MACC", SqlDbType.Int).Value = ncc.MaCC;

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

        // Tim Kiem Nha Cung Cap
        public List<NhaCungCap> TimKiemNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                OpenConnection();
                List<NhaCungCap> ncclist = new List<NhaCungCap>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_TimKiemNhaCungCap";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = ncc.Search;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhaCungCap nccs = new NhaCungCap();
                    nccs.MaCC = int.Parse(dt.Rows[i][0].ToString());
                    nccs.TenCC = dt.Rows[i][1].ToString();
                    nccs.DiaChi = dt.Rows[i][2].ToString();
                    nccs.Sdt = dt.Rows[i][3].ToString();

                    ncclist.Add(nccs);
                }

                sqlReader.Close();
                return ncclist;
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



        // Loc Nha Cung Cap
        public List<NhaCungCap> LocDanhSachNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                OpenConnection();
                List<NhaCungCap> ncclist = new List<NhaCungCap>();
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataReader sqlReader = null;
                DataTable dt = new DataTable();

                if (ncc.Search == "Mã Cung Cấp")
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "SELECT MACC FROM dbo.NHACC";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaCungCap nccs = new NhaCungCap();
                        nccs.MaCC = int.Parse(dt.Rows[i][0].ToString());

                        ncclist.Add(nccs);
                    }

                }
                else if (ncc.Search == "Tên Cung Cấp")
                {
                    sqlCommand.CommandText = "SELECT TENCC FROM dbo.NHACC";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();

                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaCungCap nccs = new NhaCungCap();
                        nccs.TenCC = dt.Rows[i][0].ToString();

                        ncclist.Add(nccs);
                    }

                }
                else if (ncc.Search == "Số Điện Thoại")
                {
                    sqlCommand.CommandText = "SELECT SDT FROM dbo.NHACC";
                    sqlCommand.Connection = conn;
                    sqlReader = sqlCommand.ExecuteReader();
                    dt.Load(sqlReader);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        NhaCungCap nccs = new NhaCungCap();
                        nccs.Sdt = dt.Rows[i][0].ToString();

                        ncclist.Add(nccs);
                    }
                }

                sqlReader.Close();
                return ncclist;

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
