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
using QuanLySieuThiMayTinh_LinQ;

namespace QuanLySieuThiMayTinh
{
    public partial class uctPhieuXuat : UserControl
    {
        PhieuXuatHang px = new PhieuXuatHang();
        PhieuXuatBLL pxbll = new PhieuXuatBLL();
        int isCheck = 0;

        public uctPhieuXuat()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void EnableHome(bool ischeck)
        {
            btnInsert.Enabled = ischeck;
            btnEdit.Enabled = ischeck;
            btnDelete.Enabled = !ischeck;
            btnSave.Enabled = !ischeck;
            btnPrint.Enabled = ischeck;
            btnCancel.Enabled = !ischeck;
            lbMaKh.Visible = false;
            lbMaNv.Visible = false;
            lbMaPx.Visible = false;
            lbMaSp.Visible = false;
            lbSlx.Visible = false;
            lbNgayXuat.Visible = false;
            lbPhanTram.Visible = false;
            lbThanhTien.Visible = false;
        }

        private void TurnOnTextBox(bool isCheck)
        {
            txtMaNv.Enabled = false;
            txtMaPx.Enabled = false;
            txtTenNv.Enabled = false;
            cboSlcl.Enabled = false;
            txtPhanTram.Enabled = isCheck;
            cboMaKh.Enabled = isCheck;
            cboMaSp.Enabled = isCheck;
            cboSlx.Enabled = isCheck;
            cboTenKh.Enabled = isCheck;
            cboTenSp.Enabled = isCheck;
            dtmNgayXuat.Enabled = isCheck;
            txtThanhTien.Enabled = isCheck;
            //txtGiaSanPham.Enabled = isCheck;
            //txtKhuyenMai.Enabled = isCheck;
            //txtTienKhachDua.Enabled = isCheck;
            //txtTienThua.Enabled = isCheck;
            //txtTongTien.Enabled = isCheck;

        }

        private void RefreshTextBox()
        {
            //txtMaNv.Text = "";
            txtMaPx.Text = "";
            txtPhanTram.Text = "";
            cboMaKh.Text = "";
            cboMaSp.Text = "";
            cboSlx.Text = "";
            cboTenKh.Text = "";
            cboTenSp.Text = "";
            dtmNgayXuat.Text = "";
            txtTongTien.Text = "";
        }

        private void HienThiDanhSanhSachPhieuXuat()
        {
            int i = 0;
            dgvPhieuXuat.Rows.Clear();
            List<PhieuXuatHang> pxlist = pxbll.GetAllListPhieuXuat();
            foreach (PhieuXuatHang pxs in pxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pxs.MaPx;
                row.Cells[2].Value = pxs.MaNv;
                row.Cells[3].Value = pxs.MaSp;
                row.Cells[4].Value = pxs.MaKh;
                row.Cells[5].Value = pxs.Slx;
                row.Cells[6].Value = pxs.NgayXuat;
                row.Cells[7].Value = pxs.PhanTram;
                row.Cells[8].Value = pxs.ThanhTiens;

                dgvPhieuXuat.Rows.Add(row);
                ++i;
            }
            cboMaSp.DataSource = pxbll.ShowMaSanPham();
            cboMaKh.DataSource = pxbll.ShowMaKhachHang();
            cboSlx.DataSource = pxbll.ShowSoLuongDatHang();
            txtMaNv.Text = UserInfo.Id.ToString();
            txtTenNv.Text = UserInfo.FullName.ToString();
        }

        private void uc_PhieuXuat_Load(object sender, EventArgs e)
        {
            HienThiDanhSanhSachPhieuXuat();
            EnableHome(true);
            TurnOnTextBox(false);
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuXuat.AllowUserToAddRows = false;
            dgvPhieuXuat.Columns[2].Width = 125;
            dgvPhieuXuat.Columns[0].Width = 30;
            dgvPhieuXuat.Columns[8].DefaultCellStyle.Format = "c";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            TurnOnTextBox(true);
            RefreshTextBox();
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
            txtThanhTien.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOnTextBox(true);
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (isCheck == 0)
            {
                try
                {
                    px.MaNv = int.Parse(txtMaNv.Text);
                    px.NgayXuat = DateTime.Parse(dtmNgayXuat.Value.ToShortDateString());
                    int m = 0;

                    if (cboMaKh.Text == "")
                    {
                        lbMaKh.Visible = true;
                        check = false;
                        lbMaKh.Text = "* Mã khách hàng không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaKh.Text, out m))
                        {
                            lbMaKh.Visible = false;
                            check = true;
                            px.MaKh = int.Parse(cboMaKh.Text);
                        }
                        else
                        {
                            lbMaKh.Visible = true;
                            check = true;
                            lbMaKh.Text = "* Mã khách hàng phải là số! *";
                        }
                    }

                    if (cboMaSp.Text == "")
                    {
                        lbMaSp.Visible = true;
                        check = false;
                        lbMaSp.Text = "* Mã sản phẩm không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaSp.Text, out m))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            px.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                        }
                    }


                    if (cboSlx.Text != "")
                    {
                        if (int.TryParse(cboSlx.Text, out m))
                        {
                            int Slx = int.Parse(cboSlx.Text);
                            if (Slx > 0)
                            {
                                lbSlx.Visible = false;
                                check = true;
                                px.Slx = int.Parse(cboSlx.Text);
                            }
                            else
                            {
                                lbSlx.Visible = true;
                                check = false;
                                lbSlx.Text = "* Số Lượng Xuất phải > 0! *";
                            }
                        }
                        else
                        {
                            lbSlx.Visible = true;
                            check = false;
                            lbSlx.Text = "* Giá trị Số Lượng Xuất phải là số! *";
                        }

                    }
                    else
                    {
                        lbSlx.Visible = true;
                        check = false;
                        lbSlx.Text = "* Giá trị của trường Số Lượng Xuất không được để trống! *";
                    }

                    if (txtPhanTram.Text != "")
                    {
                        int phanTram = 0;
                        if (int.TryParse(this.txtPhanTram.Text, out phanTram))
                        {
                            phanTram = int.Parse(txtPhanTram.Text);
                            if (phanTram > 0)
                            {
                                lbPhanTram.Visible = false;
                                check = true;
                                px.PhanTram = phanTram;
                            }
                            else if (phanTram == 0)
                            {
                                lbPhanTram.Visible = false;
                                check = true;
                                px.PhanTram = 0;
                            }
                            else
                            {
                                lbPhanTram.Visible = true;
                                check = false;
                                lbPhanTram.Text = "* Giá trị của Phẩm Trăm phải >= 0! *";
                            }
                        }
                        else
                        {
                            lbSlx.Visible = true;
                            check = false;
                            lbPhanTram.Text = "* Giá trị của Phẩn Trăm phải là số! *";
                        }
                    }
                    else
                    {
                        px.PhanTram = 0;
                    }

                    if (check == true)
                    {
                        bool result = pxbll.InsertPhieuXuatHang(px);

                        if (result)
                        {
                            DialogResult dr = MessageBox.Show("Insert Success!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                EnableHome(true);
                                RefreshTextBox();
                                TurnOnTextBox(false);
                                HienThiDanhSanhSachPhieuXuat();
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    px.ThanhTiens = decimal.Parse(txtThanhTien.Text);
                    px.MaNv = int.Parse(txtMaNv.Text);
                    px.NgayXuat = DateTime.Parse(dtmNgayXuat.Value.ToShortDateString());

                    int m = 0;
                    if (txtMaPx.Text == "")
                    {
                        lbMaPx.Visible = true;
                        check = false;
                        lbMaPx.Text = "* Mã phiếu xuất không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMaPx.Text, out m))
                        {
                            lbMaPx.Visible = false;
                            check = true;
                            px.MaPx = int.Parse(txtMaPx.Text);
                        }
                        else
                        {
                            lbMaPx.Visible = true;
                            check = false;
                            lbMaPx.Text = "* Mã phiếu xuất phải là số! *";
                            return;
                        }
                    }

                    if (cboMaKh.Text == "")
                    {
                        lbMaKh.Visible = true;
                        check = false;
                        lbMaKh.Text = "* Mã khách hàng không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaKh.Text, out m))
                        {
                            lbMaKh.Visible = false;
                            check = true;
                            px.MaKh = int.Parse(cboMaKh.Text);
                        }
                        else
                        {
                            lbMaKh.Visible = true;
                            check = true;
                            lbMaKh.Text = "* Mã khách hàng phải là số! *";
                            return;
                        }
                    }

                    if (cboMaSp.Text == "")
                    {
                        lbMaSp.Visible = true;
                        check = false;
                        lbMaSp.Text = "* Mã sản phẩm không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaSp.Text, out m))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            px.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                            return;
                        }
                    }


                    if (cboSlx.Text != "")
                    {
                        if (int.TryParse(cboSlx.Text, out m))
                        {
                            int Slx = int.Parse(cboSlx.Text);
                            if (Slx > 0)
                            {
                                lbSlx.Visible = false;
                                check = true;
                                px.Slx = int.Parse(cboSlx.Text);
                            }
                            else
                            {
                                lbSlx.Visible = true;
                                check = false;
                                lbSlx.Text = "* Số Lượng Xuất phải > 0! *";
                                return;
                            }
                        }
                        else
                        {
                            lbSlx.Visible = true;
                            check = false;
                            lbSlx.Text = "* Giá trị Số Lượng Xuất phải là số! *";
                            return;
                        }

                    }
                    else
                    {
                        lbSlx.Visible = true;
                        check = false;
                        lbSlx.Text = "* Giá trị của trường Số Lượng Xuất không được để trống! *";
                        return;
                    }

                    if (txtPhanTram.Text != "")
                    {
                        int phanTram = 0;
                        if (int.TryParse(this.txtPhanTram.Text, out phanTram))
                        {
                            phanTram = int.Parse(txtPhanTram.Text);
                            if (phanTram > 0)
                            {
                                lbPhanTram.Visible = false;
                                check = true;
                                px.PhanTram = phanTram;
                            }
                            else if (phanTram == 0)
                            {
                                lbPhanTram.Visible = false;
                                check = true;
                                px.PhanTram = 0;
                            }
                            else
                            {
                                lbPhanTram.Visible = true;
                                check = false;
                                lbPhanTram.Text = "* Giá trị của Phẩm Trăm phải >= 0! *";
                                return;
                            }
                        }
                        else
                        {
                            lbSlx.Visible = true;
                            check = false;
                            lbPhanTram.Text = "* Giá trị của Phẩn Trăm phải là số! *";
                            return;
                        }
                    }
                    else
                    {
                        px.PhanTram = 0;
                    }

                    if (check == true)
                    {
                        bool result = pxbll.EditPhieuXuat(px);

                        if (result)
                        {
                            DialogResult dr = MessageBox.Show("Edit Sucess!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                EnableHome(true);
                                TurnOnTextBox(false);
                                btnDelete.Enabled = true;
                                HienThiDanhSanhSachPhieuXuat();
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhân xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    px.MaPx = int.Parse(txtMaPx.Text);
                    px.MaSp = int.Parse(cboMaSp.Text);

                    bool result = pxbll.DeletePhieuXuat(px);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            HienThiDanhSanhSachPhieuXuat();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportPhieuXuat rpPhieuXuat = new frmReportPhieuXuat();
            rpPhieuXuat.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome(true);
            TurnOnTextBox(false);
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isCheck = 1;
                btnDelete.Enabled = true;
                txtMaPx.Text = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
                txtMaNv.Text = dgvPhieuXuat.CurrentRow.Cells[2].Value.ToString();
                cboMaSp.Text = dgvPhieuXuat.CurrentRow.Cells[3].Value.ToString();
                cboMaKh.Text = dgvPhieuXuat.CurrentRow.Cells[4].Value.ToString();
                cboSlx.Text = dgvPhieuXuat.CurrentRow.Cells[5].Value.ToString();
                dtmNgayXuat.Text = dgvPhieuXuat.CurrentRow.Cells[6].Value.ToString();
                txtPhanTram.Text = dgvPhieuXuat.CurrentRow.Cells[7].Value.ToString();

                PhieuXuatHang.MaPxKh = int.Parse(txtMaPx.Text);
                PhieuXuatHang.NgayXuatKh = DateTime.Parse(dtmNgayXuat.Text);
                double thanhTien = double.Parse(dgvPhieuXuat.CurrentRow.Cells[8].Value.ToString());
                txtThanhTien.Text = thanhTien.ToString("0,00.##");
                txtTongTien.Text = thanhTien.ToString("0,00.##");

                px.MaSp = int.Parse(cboMaSp.Text);

                cboGiaSanPham.DataSource = pxbll.SelectGiaThanhSanPham(px);
                double giaSp = double.Parse(cboGiaSanPham.Text);
                cboGiaSanPham.Text = giaSp.ToString("0,00.##");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachDua.Text == "")
            {
                return;
            }
            try
            {
                double money = (double.Parse(txtTongTien.Text) - double.Parse(txtTienKhachDua.Text));

                txtTienThua.Text = money.ToString("0,00.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSp.SelectedIndex == -1)
            {
                return;
            }
            px.MaSp = int.Parse(cboMaSp.Text);
            cboTenSp.DataSource = pxbll.HienThiTenSpTheoMaSp(px);
            cboSlcl.DataSource = pxbll.TongSoLuongTonTheoMaSp(px);

            cboGiaSanPham.DataSource = pxbll.SelectGiaThanhSanPham(px);
            double giaSp = double.Parse(cboGiaSanPham.Text);
            PhieuXuatHang.Money = giaSp;
            cboGiaSanPham.Text = giaSp.ToString("0,00.##");
        }

        private void cboMaKh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKh.SelectedIndex == -1)
            {
                return;
            }
            px.MaKh = int.Parse(cboMaKh.Text);
            cboTenKh.DataSource = pxbll.ShowTenKhTheoMaKn(px);
        }

        private void cboSlx_TextChanged(object sender, EventArgs e)
        {
            if (cboSlx.Text == "")
            {
                return;
            }
            double slx = double.Parse(cboSlx.Text);
            double thanhtien = 0;
            double giaSanpham = PhieuXuatHang.Money;

            thanhtien = slx * giaSanpham;
            txtThanhTien.Text = thanhtien.ToString("0,00.##");
        }

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {
            if (txtPhanTram.Text == "")
            {
                return;
            }
            double MoneyNotSale = double.Parse(txtThanhTien.Text);
            double MoneySaled = 0;
            double phanTram = double.Parse(txtPhanTram.Text);
            MoneySaled = (MoneyNotSale * (100 - phanTram)) / (100);
            txtThanhTien.Text = MoneySaled.ToString("0,00.##");
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            px.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<PhieuXuatHang> pxlist = pxbll.LocDanhSachPhieuXuatHang(px);

            if (cboChoose.Text == "Mã Phiếu Xuất")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaPx);
                }
            }
            else if (cboChoose.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaNv);
                }
            }
            else if (cboChoose.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaSp);
                }
            }
            else if (cboChoose.Text == "Mã Khách Hàng")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaKh);
                }
            }
            else
            {
                return;
            }
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (cboSearch.Text == "")
            {
                HienThiDanhSanhSachPhieuXuat();
                return;
            }
            px.Search = cboSearch.Text;
            List<PhieuXuatHang> pxlist = pxbll.TimKiemPhieuXuatHang(px);
            dgvPhieuXuat.Rows.Clear();

            foreach (PhieuXuatHang pxs in pxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pxs.MaPx;
                row.Cells[2].Value = pxs.MaNv;
                row.Cells[3].Value = pxs.MaSp;
                row.Cells[4].Value = pxs.MaKh;
                row.Cells[5].Value = pxs.Slx;
                row.Cells[6].Value = pxs.NgayXuat;
                row.Cells[7].Value = pxs.PhanTram;
                row.Cells[8].Value = pxs.ThanhTiens;

                dgvPhieuXuat.Rows.Add(row);
                ++i;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }
    }
}
