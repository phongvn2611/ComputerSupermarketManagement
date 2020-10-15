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
    public partial class uctThongKePhieuXuat : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uctThongKePhieuXuat()
        {
            InitializeComponent();
        }

        #region
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void DanhSachThongKe()
        {
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKePhieuXuat();
            dgvThongKePhieuXuat.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.TenKh.ToString();
                row.Cells[6].Value = tks.Slx.ToString();
                row.Cells[7].Value = tks.TongTien.ToString("00,00.##");
                row.Cells[8].Value = tks.PhanTram.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString("00,00.##");

                dgvThongKePhieuXuat.Rows.Add(row);
                ++i;
            }
            cboTongPhieuXuat.Text = i.ToString();
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

        private void uc_ThongKePhieuXuat_Load(object sender, EventArgs e)
        {
            DanhSachThongKe();
            dgvThongKePhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKePhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKePhieuXuat.AllowUserToAddRows = false;
            dgvThongKePhieuXuat.Columns[0].Width = 30;
            dgvThongKePhieuXuat.Columns[3].Width = 80;
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
                tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

                List<ThongKe> tklist = tkbll.ThongKePhieuXuatTheoNgayThang(tk);
                dgvThongKePhieuXuat.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuXuat);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.TenKh.ToString();
                    row.Cells[6].Value = tks.Slx.ToString();
                    row.Cells[7].Value = tks.TongTien.ToString("00,00.##");
                    row.Cells[8].Value = tks.PhanTram.ToString();
                    row.Cells[9].Value = tks.ThanhTien.ToString("00,00.##");

                    dgvThongKePhieuXuat.Rows.Add(row);
                    ++i;
                }
                cboTongPhieuXuat.Text = i.ToString();

                List<ThongKe> tklist1 = tkbll.TinhTongSlpxTheoNgayXuat(tk);
                List<ThongKe> tklist2 = tkbll.TinhTongThanhTienTheoNgayXuat(tk);
                foreach (ThongKe tks1 in tklist1)
                {
                    cboTongSoLuongXuat.Text = tks1.Slx.ToString();
                }
                foreach (ThongKe tks2 in tklist2)
                {
                    cboTongTien.Text = tks2.ThanhTien.ToString("00,00.##");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiSp.Text == "")
            {
                DanhSachThongKe();
                return;
            }

            //cboTenSp.Text = "";

            int i = 0;
            int Sum = 0;
            tk.TenLoai = cboLoaiSp.Text;
            List<ThongKe> tklist = tkbll.ThongKePHieuXuatTHeoLoaiSp(tk);

            dgvThongKePhieuXuat.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.TenKh.ToString();
                row.Cells[6].Value = tks.Slx.ToString();
                row.Cells[7].Value = tks.TongTien.ToString("00,00.##");
                row.Cells[8].Value = tks.PhanTram.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString("00,00.##");

                dgvThongKePhieuXuat.Rows.Add(row);
                ++i;
                Sum += i;
            }
            cboTongPhieuXuat.Text = i.ToString();

            List<ThongKe> tklist1 = tkbll.TinhTongSlpxTheoLoaiSanPham(tk);
            List<ThongKe> tklist2 = tkbll.TinhTongThanhTienTheoLoaiSanPham(tk);
            foreach (ThongKe tks1 in tklist1)
            {
                cboTongSoLuongXuat.Text = tks1.Slx.ToString();
            }
            foreach (ThongKe tks2 in tklist2)
            {
                cboTongTien.Text = tks2.ThanhTien.ToString("00,00.##");
            }
        }

        private void cboNhaSx_TextChanged(object sender, EventArgs e)
        {
            if (cboNhaSx.Text == "")
            {
                DanhSachThongKe();
                return;
            }

            //cboTenSp.Text = "";

            int i = 0;
            int Sum = 0;
            tk.TenSx = cboNhaSx.Text;
            List<ThongKe> tklist = tkbll.ThongKePHieuXuatTHeoNhaSx(tk);

            dgvThongKePhieuXuat.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.TenKh.ToString();
                row.Cells[6].Value = tks.Slx.ToString();
                row.Cells[7].Value = tks.TongTien.ToString("00,00.##");
                row.Cells[8].Value = tks.PhanTram.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString("00,00.##");

                dgvThongKePhieuXuat.Rows.Add(row);
                ++i;
                Sum += i;
            }
            cboTongPhieuXuat.Text = i.ToString();

            List<ThongKe> tklist1 = tkbll.TinhTongSlpxTheoNhaSanXuat(tk);
            List<ThongKe> tklist2 = tkbll.TinhTongThanhTienTheoNhaSanXuat(tk);
            foreach (ThongKe tks1 in tklist1)
            {
                cboTongSoLuongXuat.Text = tks1.Slx.ToString();
            }
            foreach (ThongKe tks2 in tklist2)
            {
                cboTongTien.Text = tks2.ThanhTien.ToString("00,00.##");
            }
        }
    }
}
