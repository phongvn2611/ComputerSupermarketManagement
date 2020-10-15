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
    public partial class uctThongKeTonKho : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uctThongKeTonKho()
        {
            InitializeComponent();
        }

        public void ThongKeTonKho()
        {
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeTonKho();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKho);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKho.Rows.Add(row);
                ++i;
            }
            cboTongSanPham.Text = i.ToString();
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

        private void uc_ThongKeTonKho_Load(object sender, EventArgs e)
        {
            ThongKeTonKho();

            dgvThongKeTonKho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKeTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeTonKho.AllowUserToAddRows = false;
            dgvThongKeTonKho.Columns[0].Width = 30;
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            int i = 0;
            tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            List<ThongKe> tklist = tkbll.ThongKeTonKhoTheoNgayThang(tk);
            dgvThongKeTonKho.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKho);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKho.Rows.Add(row);
                ++i;
            }
            cboTongSanPham.Text = i.ToString();
            List<ThongKe> tklist1 = tkbll.TinhTongSoLuongTonKhoTheoNgayThang(tk);
            foreach (ThongKe tks1 in tklist1)
            {
                cboTongSoLuongTon.Text = tks1.Slcl.ToString();
            }
        }

        private void cboNhaSx_TextChanged(object sender, EventArgs e)
        {
            if (cboNhaSx.Text == "")
            {
                ThongKeTonKho();
                return;
            }
            tk.TenSx = cboNhaSx.Text;
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeTonKhoTHeoNhaSx(tk);
            dgvThongKeTonKho.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKho);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKho.Rows.Add(row);
                ++i;
            }

            List<ThongKe> tklists = tkbll.TinhTongSoLuongTonKhoTheoNhaSx(tk);
            foreach (ThongKe tks1 in tklists)
            {
                cboTongSoLuongTon.Text = tks1.Slcl.ToString();

            }
            cboTongSanPham.Text = i.ToString();
        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiSp.Text == "")
            {
                ThongKeTonKho();
                return;
            }

            tk.TenLoai = cboLoaiSp.Text;
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeTonKhoTHeoLoaiSp(tk);
            dgvThongKeTonKho.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKho);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKho.Rows.Add(row);
                ++i;
            }

            List<ThongKe> tklists = tkbll.TinhTongSoLuongTonKhoTheoLoaiSp(tk);
            foreach (ThongKe tks1 in tklists)
            {
                cboTongSoLuongTon.Text = tks1.Slcl.ToString();
            }
            cboTongSanPham.Text = i.ToString();
        }
    }
}
