using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.DAL;
using QuanLySieuThiMayTinh.BLL;

namespace QuanLySieuThiMayTinh
{
    public partial class uctThongKeDonHang : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uctThongKeDonHang()
        {
            InitializeComponent();
        }

        public void HienThiThongKe()
        {
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeDonDatHang();
            dgvThongKeDonHang.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDonHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDonHang.Rows.Add(row);
                ++i;
            }
            cboTongDondh.Text = i.ToString();
        }

        private void HienThiTenLoaiSp()
        {
            List<ThongKe> tklist = tkbll.HienThiTenLoaiSanPham();
            foreach (ThongKe tks in tklist)
            {
                cboLoaiSp.Items.Add(tks.TenLoai);
            }
        }

        private void HienThiTenSanXuat()
        {
            List<ThongKe> tklist = tkbll.HienThiTenNhaSanXuat();
            foreach (ThongKe tks in tklist)
            {
                cboNhaSx.Items.Add(tks.TenSx);
            }
        }

        private void uc_ThongKeDonHang_Load(object sender, EventArgs e)
        {
            HienThiThongKe();
            dgvThongKeDonHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKeDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeDonHang.AllowUserToAddRows = false;
            dgvThongKeDonHang.Columns[0].Width = 30;
            cboTongSldh.DataSource = tkbll.TongSldh();
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }

        private void dtmTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtmDenNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cboNhaSx.Text = "";
                cboLoaiSp.Text = "";

                int i = 0;
                tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
                tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

                List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
                dgvThongKeDonHang.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKeDonHang);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp;
                    row.Cells[2].Value = tks.TenSp;
                    row.Cells[3].Value = tks.TenLoai;
                    row.Cells[4].Value = tks.TenSx;
                    row.Cells[5].Value = tks.Sld;

                    dgvThongKeDonHang.Rows.Add(row);
                    ++i;
                }
                cboTongDondh.Text = i.ToString();
                cboTongSldh.DataSource = tkbll.TongSldhTheoNgayDh(tk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Filter!" + ex.Message);
            }

        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (cboLoaiSp.Text == "")
                {
                    HienThiThongKe();
                    return;
                }

                cboNhaSx.Text = "";

                int i = 0;

                tk.TenLoai = cboLoaiSp.Text;
                List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoLoaiSp(tk);

                dgvThongKeDonHang.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKeDonHang);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp;
                    row.Cells[2].Value = tks.TenSp;
                    row.Cells[3].Value = tks.TenLoai;
                    row.Cells[4].Value = tks.TenSx;
                    row.Cells[5].Value = tks.Sld;

                    dgvThongKeDonHang.Rows.Add(row);
                    ++i;
                }
                cboTongDondh.Text = i.ToString();
                cboTongSldh.DataSource = tkbll.TongSldhTheoLoaiSp(tk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Loại Sản Phẩm!" + ex.Message);
            }

        }

        private void cboNhaSx_TextChanged(object sender, EventArgs e)
        {
            if (cboNhaSx.Text == "")
            {
                HienThiThongKe();
                return;
            }

            cboLoaiSp.Text = "";

            int i = 0;
            tk.TenSx = cboNhaSx.Text;
            List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNhaSx(tk);

            dgvThongKeDonHang.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDonHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDonHang.Rows.Add(row);
                ++i;
            }
            cboTongDondh.Text = i.ToString();
            cboTongSldh.DataSource = tkbll.TongSldhTheoNhaSx(tk);
        }

        private void dgvThongKeDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tk.MaSp = int.Parse(dgvThongKeDonHang.CurrentRow.Cells[1].Value.ToString());
            cboTongSldh.DataSource = tkbll.TonSldhTheoMaSp(tk);
        }
    }
}
