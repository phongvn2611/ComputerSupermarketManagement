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
using QuanLySieuThiMayTinh.BLL;

namespace QuanLySieuThiMayTinh
{
    public partial class uctThongKePhieuNhap : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uctThongKePhieuNhap()
        {
            InitializeComponent();
        }

        private void HienThiTenLoaiSp()
        {
            List<ThongKe> tklist = tkbll.HienThiTenLoaiSanPham();
            foreach (ThongKe tks in tklist)
            {
                cboLoaiSp.Items.Add(tks.TenLoai);
            }
        }

        private void HienThiTenCc()
        {
            List<ThongKe> tklist = tkbll.HienThiTenNhaCungCap();
            foreach (ThongKe tks in tklist)
            {
                cboNhaCc.Items.Add(tks.TenCc);
            }

        }

        private void DanhSachThongKe()
        {
            try
            {
                int i = 0;
                List<ThongKe> tklist = tkbll.ThongKePhieuNhap();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuNhap);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.Sld.ToString();
                    row.Cells[6].Value = tks.Sln.ToString();
                    row.Cells[7].Value = tks.Slcl.ToString();
                    row.Cells[8].Value = tks.DonGia.ToString();
                    row.Cells[9].Value = tks.ThanhTien;

                    dgvThongKePhieuNhap.Rows.Add(row);
                    ++i;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void uc_ThongKePhieuNhap_Load(object sender, EventArgs e)
        {
            DanhSachThongKe();
            dgvThongKePhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKePhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKePhieuNhap.AllowUserToAddRows = false;
            dgvThongKePhieuNhap.Columns[0].Width = 30;
            HienThiTenLoaiSp();
            HienThiTenCc();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
                tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

                List<ThongKe> tklist = tkbll.ThongKePhieuNhapTheoNgayThang(tk);
                dgvThongKePhieuNhap.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuNhap);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.Sld.ToString();
                    row.Cells[6].Value = tks.Sln.ToString();
                    row.Cells[7].Value = tks.Slcl.ToString();
                    row.Cells[8].Value = tks.DonGia.ToString();
                    row.Cells[9].Value = tks.ThanhTien;

                    dgvThongKePhieuNhap.Rows.Add(row);
                    ++i;
                }
                cboTongSoPhieu.Text = i.ToString();

                List<ThongKe> tklist1 = tkbll.TongSoLuongNhapTheoNgayNhap(tk);
                List<ThongKe> tklist2 = tkbll.TongSoLuongConNhapTheoNgayNhap(tk);
                List<ThongKe> tklist3 = tkbll.TinhThanhTienPhieuNhapTheoNgayNhap(tk);


                foreach (ThongKe tks1 in tklist1)
                {
                    cboTongSln.Text = tks1.Sln.ToString();
                }
                foreach (ThongKe tks2 in tklist2)
                {
                    cboTongSlcn.Text = tks2.Slcl.ToString();
                }

                foreach (ThongKe tks3 in tklist3)
                {
                    cboTongThanhTien.Text = tks3.ThanhTien.ToString();
                }
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
                    DanhSachThongKe();
                    return;
                }

                cboNhaCc.Text = "";

                int i = 0;
                int Sum = 0;
                tk.TenLoai = cboLoaiSp.Text;
                List<ThongKe> tklist = tkbll.ThongKePhieuNhapLoaiSp(tk);

                dgvThongKePhieuNhap.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuNhap);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.Sld.ToString();
                    row.Cells[6].Value = tks.Sln.ToString();
                    row.Cells[7].Value = tks.Slcl.ToString();
                    row.Cells[8].Value = tks.DonGia.ToString();
                    row.Cells[9].Value = tks.ThanhTien;

                    dgvThongKePhieuNhap.Rows.Add(row);
                    ++i;
                    Sum += i;
                }

                cboTongSoPhieu.Text = i.ToString();
                List<ThongKe> tklist1 = tkbll.TongSoLuongNhapTheoLoaiSp(tk);
                List<ThongKe> tklist2 = tkbll.TongSoLuongConNhapTheoLoaiSp(tk);
                List<ThongKe> tklist3 = tkbll.TinhThanhTienPhieuNhapTheoLoaiSp(tk);


                foreach (ThongKe tks1 in tklist1)
                {
                    cboTongSln.Text = tks1.Sln.ToString();
                }
                foreach (ThongKe tks2 in tklist2)
                {
                    cboTongSlcn.Text = tks2.Slcl.ToString();
                }

                foreach (ThongKe tks3 in tklist3)
                {
                    cboTongThanhTien.Text = tks3.ThanhTien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Loại Sản Phẩm!" + ex.Message);
            }

        }

        private void cboNhaCc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNhaCc.Text == "")
                {
                    DanhSachThongKe();
                    return;
                }

                cboLoaiSp.Text = "";

                int i = 0;
                int Sum = 0;
                tk.TenCc = cboNhaCc.Text;
                List<ThongKe> tklist = tkbll.ThongKePhieuNhapTheoNhaCungCap(tk);

                dgvThongKePhieuNhap.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuNhap);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.Sld.ToString();
                    row.Cells[6].Value = tks.Sln.ToString();
                    row.Cells[7].Value = tks.Slcl.ToString();
                    row.Cells[8].Value = tks.DonGia.ToString();
                    row.Cells[9].Value = tks.ThanhTien.ToString();

                    dgvThongKePhieuNhap.Rows.Add(row);
                    ++i;
                    Sum += i;
                }

                cboTongSoPhieu.Text = i.ToString();
                List<ThongKe> tklist1 = tkbll.TongSoLuongNhapTheoNhaCc(tk);
                List<ThongKe> tklist2 = tkbll.TongSoLuongConNhapTheoNhaCc(tk);
                List<ThongKe> tklist3 = tkbll.TinhThanhTienPhieuNhapTheoNhaCc(tk);


                foreach (ThongKe tks1 in tklist1)
                {
                    cboTongSln.Text = tks1.Sln.ToString();
                }
                foreach (ThongKe tks2 in tklist2)
                {
                    cboTongSlcn.Text = tks2.Slcl.ToString();
                }

                foreach (ThongKe tks3 in tklist3)
                {
                    cboTongThanhTien.Text = tks3.ThanhTien.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Nhà Cung Cấp !" + ex.Message);
            }
        }
    }
}
