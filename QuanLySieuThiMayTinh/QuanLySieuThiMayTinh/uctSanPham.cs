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
    public partial class uctSanPham : UserControl
    {
        SanPham sp = new SanPham();
        SanPhamBLL spbll = new SanPhamBLL();
        int isCheck = 0;

        public uctSanPham()
        {
            InitializeComponent();
        }

        public void EnableHome()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = true;
            lbMaSp.Visible = false;
            lbTenSp.Visible = false;
            lbMaSx.Visible = false;
            lbMaLoai.Visible = false;
            lbGiaThanh.Visible = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaSp.Enabled = false;
            txtAmThanh.Enabled = isCheck;
            txtCardManHinh.Enabled = isCheck;
            txtCongKetNoi.Enabled = isCheck;
            txtCpu.Enabled = isCheck;
            txtGiaoTiepMang.Enabled = isCheck;
            txtGiaThanh.Enabled = isCheck;
            txtHeDieuHanh.Enabled = isCheck;
            txtManHinh.Enabled = isCheck;
            txtPin.Enabled = isCheck;
            txtTenSp.Enabled = isCheck;
            cboTrongLuong_1.Enabled = isCheck;
            cboTrongLuong_2.Enabled = isCheck;
            txtWebCam.Enabled = isCheck;
            cboBaoHanh_1.Enabled = isCheck;
            cboBaoHanh_2.Enabled = isCheck;
            cboDiaQuang.Enabled = isCheck;
            cboMaLoai.Enabled = isCheck;
            cboMaSx.Enabled = isCheck;
            cboOcung_1.Enabled = isCheck;
            cboOcung_2.Enabled = isCheck;
            cboOcung_3.Enabled = isCheck;
            cboRam_1.Enabled = isCheck;
            cboRam_2.Enabled = isCheck;
            cboRam_3.Enabled = isCheck;
            cboTenLoai.Enabled = isCheck;
            cboTenSx.Enabled = isCheck;

        }

        private void RefreshTextBox()
        {
            txtAmThanh.Text = "";
            txtCardManHinh.Text = "";
            txtCongKetNoi.Text = "";
            txtCpu.Text = "";
            txtGiaoTiepMang.Text = "";
            txtGiaThanh.Text = "";
            txtHeDieuHanh.Text = "";
            txtManHinh.Text = "";
            txtMaSp.Text = "";
            txtPin.Text = "";
            txtTenSp.Text = "";
            cboTrongLuong_1.Text = "";
            cboTrongLuong_2.Text = "";
            txtWebCam.Text = "";
            cboBaoHanh_1.Text = "";
            cboBaoHanh_2.Text = "";
            cboDiaQuang.Text = "";
            cboMaLoai.Text = "";
            cboMaSx.Text = "";
            cboOcung_1.Text = "";
            cboOcung_2.Text = "";
            cboOcung_3.Text = "";
            cboRam_1.Text = "";
            cboRam_2.Text = "";
            cboRam_3.Text = "";
            cboTenLoai.Text = "";
            cboTenSx.Text = "";

        }

        private void HienThiDanhSachSanPham()
        {
            int i = 0;
            dgvSanPham.Rows.Clear();
            List<SanPham> splist = spbll.GetAllListSanPham();
            foreach (SanPham sps in splist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = sps.MaSp;
                row.Cells[2].Value = sps.TenSp;
                row.Cells[3].Value = sps.MaSx;
                row.Cells[4].Value = sps.MaLoai;
                row.Cells[5].Value = sps.GiaThanhs.ToString("00,00.##");
                row.Cells[6].Value = sps.Cpu;
                row.Cells[7].Value = sps.Ram;
                row.Cells[8].Value = sps.Ocung;
                row.Cells[9].Value = sps.ManHinh;
                row.Cells[10].Value = sps.CardManHinh;
                row.Cells[11].Value = sps.CongKetNoi;
                row.Cells[12].Value = sps.Hdt;
                row.Cells[13].Value = sps.AmThanh;
                row.Cells[14].Value = sps.DiaQuang;
                row.Cells[15].Value = sps.GiaoTiepMang;
                row.Cells[16].Value = sps.WebCam;
                row.Cells[17].Value = sps.Pin;
                row.Cells[18].Value = sps.TrongLuong;
                row.Cells[19].Value = sps.BaoHanh;

                dgvSanPham.Rows.Add(row);
                ++i;
            }
            cboMaLoai.DataSource = spbll.ShowAllMaLoaiSp();
            cboMaSx.DataSource = spbll.ShowAllMaSx();
            cboTenSx.DataSource = spbll.ShowAllTenNhaSx();
            cboTenLoai.DataSource = spbll.ShowAllTenLoaiSp();
        }

        private void uc_SanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            EnableHome();
            TurnOffTextBox(false);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.Columns[0].Width = 30;
            dgvSanPham.Columns[1].Width = 150;
            dgvSanPham.Columns[2].Width = 150;
            dgvSanPham.Columns[3].Width = 150;
            dgvSanPham.Columns[10].Width = 150;
            dgvSanPham.Columns[11].Width = 150;
            dgvSanPham.Columns[12].Width = 150;
            dgvSanPham.Columns[15].Width = 150;
            dgvSanPham.Columns[18].Width = 150;
            //dgvSanPham.Columns[5].DefaultCellStyle.Format = "c";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            TurnOffTextBox(true);
            RefreshTextBox();
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnPrint.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnPrint.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (isCheck == 0)
            {
                try
                {
                    int n = 0;
                    sp.AmThanh = txtAmThanh.Text;
                    sp.CardManHinh = txtCardManHinh.Text;
                    sp.CongKetNoi = txtCongKetNoi.Text;
                    sp.Cpu = txtCpu.Text;
                    sp.GiaoTiepMang = txtGiaoTiepMang.Text;

                    sp.Hdt = txtHeDieuHanh.Text;
                    sp.ManHinh = txtManHinh.Text;
                    sp.Pin = txtPin.Text;

                    sp.WebCam = txtWebCam.Text;
                    sp.BaoHanh = cboBaoHanh_1.Text + " " + cboBaoHanh_2.Text;
                    sp.DiaQuang = cboDiaQuang.Text;


                    sp.Ocung = cboOcung_1.Text + " " + cboOcung_2.Text + " " + cboOcung_3.Text;
                    sp.Ram = cboRam_1.Text + " " + cboRam_2.Text + " " + cboRam_3.Text;
                    //sp.TenLoai = cboTenLoai.Text;
                    //sp.TenSx = cboTenSx.Text;
                    sp.TrongLuong = cboTrongLuong_1.Text + " " + cboTrongLuong_2.Text;
                    //sp.NgayNhap = DateTime.Now;

                    if (txtTenSp.Text == "")
                    {
                        lbTenSp.Visible = true;
                        check = false;
                        lbTenSp.Text = "* Tên sản phẩm không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtTenSp.Text, out n))
                        {
                            lbTenSp.Visible = true;
                            check = false;
                            lbTenSp.Text = "* Tên sản phẩm không thể chỉ là số ! *";
                        }
                        else
                        {
                            lbTenSp.Visible = false;
                            check = true;
                            sp.TenSp = txtTenSp.Text;
                        }
                    }

                    if (cboMaSx.Text == "")
                    {
                        lbMaSx.Visible = true;
                        check = false;
                        lbMaSx.Text = "* Mã sản xuất không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaSx.Text, out n))
                        {
                            lbMaSx.Visible = false;
                            check = true;
                            sp.MaSx = int.Parse(cboMaSx.Text);
                        }
                        else
                        {
                            lbMaSx.Visible = true;
                            check = false;
                            lbMaSx.Text = "* Mã sản xuất không được là chữ! *";
                        }
                    }

                    if (cboMaLoai.Text == "")
                    {
                        lbMaLoai.Visible = true;
                        check = false;
                        lbMaLoai.Text = "* Mã loại không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaLoai.Text, out n))
                        {
                            lbMaLoai.Visible = false;
                            check = true;
                            sp.MaLoai = int.Parse(cboMaLoai.Text);
                        }
                        else
                        {
                            lbMaSx.Visible = true;
                            check = false;
                            lbMaLoai.Text = "* Mã Loại không được là chữ! *";
                        }
                    }

                    if (txtGiaThanh.Text == "")
                    {
                        lbGiaThanh.Visible = true;
                        check = false;
                        lbGiaThanh.Text = "* Giá thành không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtGiaThanh.Text, out n))
                        {
                            lbGiaThanh.Visible = false;
                            check = true;
                            sp.GiaThanh = float.Parse(txtGiaThanh.Text);
                        }
                        else
                        {
                            lbGiaThanh.Visible = true;
                            check = false;
                            lbGiaThanh.Text = "* Giá thành không thể là chữ ! *";
                        }
                    }

                    if (check == true)
                    {
                        bool result = spbll.InserSanPham(sp);
                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Sucessful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                RefreshTextBox();
                                HienThiDanhSachSanPham();
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
                    int n = 0;
                    sp.AmThanh = txtAmThanh.Text;
                    sp.CardManHinh = txtCardManHinh.Text;
                    sp.CongKetNoi = txtCongKetNoi.Text;
                    sp.Cpu = txtCpu.Text;
                    sp.GiaoTiepMang = txtGiaoTiepMang.Text;

                    sp.Hdt = txtHeDieuHanh.Text;
                    sp.ManHinh = txtManHinh.Text;

                    sp.Pin = txtPin.Text;

                    sp.WebCam = txtWebCam.Text;
                    sp.BaoHanh = cboBaoHanh_1.Text + " " + cboBaoHanh_2.Text;
                    sp.DiaQuang = cboDiaQuang.Text;

                    sp.Ocung = cboOcung_1.Text + " " + cboOcung_2.Text + " " + cboOcung_3.Text;
                    sp.Ram = cboRam_1.Text + " " + cboRam_2.Text + " " + cboRam_3.Text;
                    //sp.TenLoai = cboTenLoai.Text;
                    //sp.TenSx = cboTenSx.Text;
                    sp.TrongLuong = cboTrongLuong_1.Text + " " + cboTrongLuong_2.Text;

                    if (txtMaSp.Text == "")
                    {
                        lbMaSp.Visible = true;
                        check = false;
                        lbMaSp.Text = "* Mã sản phẩm không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMaSp.Text, out n))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            sp.MaSp = int.Parse(txtMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số !*";
                            return;
                        }
                    }

                    if (txtTenSp.Text == "")
                    {
                        lbTenSp.Visible = true;
                        check = false;
                        lbTenSp.Text = "* Tên sản phẩm không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtTenSp.Text, out n))
                        {
                            lbTenSp.Visible = true;
                            check = false;
                            lbTenSp.Text = "* Tên sản phẩm không thể chỉ là số ! *";
                            return;
                        }
                        else
                        {
                            lbTenSp.Visible = false;
                            check = true;
                            sp.TenSp = txtTenSp.Text;
                        }
                    }

                    if (cboMaSx.Text == "")
                    {
                        lbMaSx.Visible = true;
                        check = false;
                        lbMaSx.Text = "* Mã sản xuất không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaSx.Text, out n))
                        {
                            lbMaSx.Visible = false;
                            check = true;
                            sp.MaSx = int.Parse(cboMaSx.Text);
                        }
                        else
                        {
                            lbMaSx.Visible = true;
                            check = false;
                            lbMaSx.Text = "* Mã sản xuất không được là chữ! *";
                            return;
                        }
                    }

                    if (cboMaLoai.Text == "")
                    {
                        lbMaLoai.Visible = true;
                        check = false;
                        lbMaLoai.Text = "* Mã loại không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaLoai.Text, out n))
                        {
                            lbMaLoai.Visible = false;
                            check = true;
                            sp.MaLoai = int.Parse(cboMaLoai.Text);
                        }
                        else
                        {
                            lbMaSx.Visible = true;
                            check = false;
                            lbMaLoai.Text = "* Mã Loại không được là chữ! *";
                            return;
                        }
                    }

                    if (txtGiaThanh.Text == "")
                    {
                        lbGiaThanh.Visible = true;
                        check = false;
                        lbGiaThanh.Text = "* Giá thành không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtGiaThanh.Text, out n))
                        {
                            lbGiaThanh.Visible = false;
                            check = true;
                            sp.GiaThanh = float.Parse(txtGiaThanh.Text);
                        }
                        else
                        {
                            lbGiaThanh.Visible = true;
                            check = false;
                            lbGiaThanh.Text = "* Giá thành không thể là chữ ! *";
                            return;
                        }
                    }

                    if (check == true)
                    {
                        bool result = spbll.EditSanPham(sp);
                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Sucessful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                btnDelete.Enabled = true;
                                HienThiDanhSachSanPham();
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
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    sp.MaSp = int.Parse(txtMaSp.Text);
                    bool result = spbll.DeleteSanPham(sp);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            EnableHome();
                            HienThiDanhSachSanPham();
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
            frmReportSanPham rpSanPham = new frmReportSanPham();
            rpSanPham.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                txtMaSp.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtTenSp.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                cboMaSx.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                cboMaLoai.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtGiaThanh.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtCpu.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();

                string strRam = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                string[] arrListRam = strRam.Split(' ');
                cboRam_1.Text = arrListRam[0].ToString();
                cboRam_2.Text = arrListRam[1].ToString();
                cboRam_3.Text = arrListRam[2].ToString();

                string strOcung = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
                string[] arrayListOcung = strOcung.Split(' ');
                cboOcung_1.Text = arrayListOcung[0].ToString();
                cboOcung_2.Text = arrayListOcung[1].ToString();
                cboOcung_3.Text = arrayListOcung[2].ToString();

                txtManHinh.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
                txtCardManHinh.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
                txtCongKetNoi.Text = dgvSanPham.CurrentRow.Cells[11].Value.ToString();
                txtHeDieuHanh.Text = dgvSanPham.CurrentRow.Cells[12].Value.ToString();
                txtAmThanh.Text = dgvSanPham.CurrentRow.Cells[13].Value.ToString();
                cboDiaQuang.Text = dgvSanPham.CurrentRow.Cells[14].Value.ToString();
                txtGiaoTiepMang.Text = dgvSanPham.CurrentRow.Cells[15].Value.ToString();
                txtWebCam.Text = dgvSanPham.CurrentRow.Cells[16].Value.ToString();
                txtPin.Text = dgvSanPham.CurrentRow.Cells[17].Value.ToString();

                string strTrongLuong = dgvSanPham.CurrentRow.Cells[18].Value.ToString();
                string[] strListTrongLuong = strTrongLuong.Split(' ');
                cboTrongLuong_1.Text = strListTrongLuong[0].ToString();
                cboTrongLuong_2.Text = strListTrongLuong[1].ToString();

                string strBaoHanh = dgvSanPham.CurrentRow.Cells[19].Value.ToString();
                string[] strListbaohanh = strBaoHanh.Split(' ');
                cboBaoHanh_1.Text = strListbaohanh[0].ToString();
                cboBaoHanh_2.Text = strListbaohanh[1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dat Grid View Loi" + ex.Message);
            }
        }

        private void cboMaSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaSx.SelectedIndex == -1)
            //{
            //    return;
            //}
            //sp.MaSx = int.Parse(cboMaSx.Text);
            //cboTenSx.DataSource = spbll.ShowNameNhaSxFlow(sp);
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaLoai.SelectedIndex == -1)
            //{
            //    return;
            //}
            //sp.MaLoai = int.Parse(cboMaLoai.Text);
            //cboTenLoai.DataSource = spbll.ShowNameLoaiSpFlow(sp);
        }

        private void cboTenSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSx.SelectedIndex == -1)
            {
                return;
            }
            sp.TenSx = cboTenSx.Text;
            cboMaSx.DataSource = spbll.ShowIdNhaSxFlow(sp);
        }

        private void cboTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenLoai.SelectedIndex == -1)
            {
                return;
            }
            sp.TenLoai = cboTenLoai.Text;
            cboMaLoai.DataSource = spbll.ShowIdLoaiSanPhamFlow(sp);

        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            sp.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<SanPham> splist = spbll.LocDanhSachSanPham(sp);
            if (cboChoose.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaSp);
                }
            }
            else if (cboChoose.Text == "Mã Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaSx);
                }
            }
            else if (cboChoose.Text == "Mã Loại")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaLoai);
                }
            }
            else if (cboChoose.Text == "Tên Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.TenSp);
                }
            }
            else if (cboChoose.Text == "Tên Loại")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.TenLoai);
                }
            }
            else if (cboChoose.Text == "Tên Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.TenSx);
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
                HienThiDanhSachSanPham();
                return;
            }
            sp.Search = cboSearch.Text;
            List<SanPham> splist = spbll.TimKiemSanPham(sp);
            dgvSanPham.Rows.Clear();

            foreach (SanPham sps in splist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = sps.MaSp;
                row.Cells[2].Value = sps.TenSp;
                row.Cells[3].Value = sps.MaSx;
                row.Cells[4].Value = sps.MaLoai;
                row.Cells[5].Value = sps.GiaThanhs;
                row.Cells[6].Value = sps.Cpu;
                row.Cells[7].Value = sps.Ram;
                row.Cells[8].Value = sps.Ocung;
                row.Cells[9].Value = sps.ManHinh;
                row.Cells[10].Value = sps.CardManHinh;
                row.Cells[11].Value = sps.CongKetNoi;
                row.Cells[12].Value = sps.Hdt;
                row.Cells[13].Value = sps.AmThanh;
                row.Cells[14].Value = sps.DiaQuang;
                row.Cells[15].Value = sps.GiaoTiepMang;
                row.Cells[16].Value = sps.WebCam;
                row.Cells[17].Value = sps.Pin;
                row.Cells[18].Value = sps.TrongLuong;
                row.Cells[19].Value = sps.BaoHanh;

                dgvSanPham.Rows.Add(row);
                ++i;
            }
        }
    }
}
