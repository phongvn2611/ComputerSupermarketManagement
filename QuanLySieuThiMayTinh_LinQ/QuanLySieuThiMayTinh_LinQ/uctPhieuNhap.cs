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
    public partial class uctPhieuNhap : UserControl
    {
        PhieuNhapHang pn = new PhieuNhapHang();
        PhieuNhapBLL pnbll = new PhieuNhapBLL();
        int isCheck = 0;

        public uctPhieuNhap()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
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
            lbMaPn.Visible = false;
            lbMaNv.Visible = false;
            lbMaDh.Visible = false;
            lbNgayNhap.Visible = false;
            lbMaSp.Visible = false;
            lbSln.Visible = false;
            lbDonGia.Visible = false;
        }

        private void TurnOnTextBox(bool isCheck)
        {
            txtMaNv.Enabled = false;
            txtMaPn.Enabled = false;
            dtmNgayNhap.Enabled = isCheck;
            txtSln.Enabled = isCheck;
            txtDonGia.Enabled = isCheck;
            cboMaDh.Enabled = isCheck;
            cboMaSp.Enabled = false;
            cboTenSp.Enabled = false;
            cboSld.Enabled = false;
            cboGiaThanh.Enabled = false;
            txtSlcn.Enabled = false;
        }

        private void RefreshTextBox()
        {
            //txtMaNv.Text = "";
            txtMaPn.Text = "";
            dtmNgayNhap.Text = "";
            txtSln.Text = "";
            txtDonGia.Text = "";
            cboMaDh.Text = "";
            cboMaSp.Text = "";
            cboTenSp.Text = "";
            txtSln.Text = "";
            txtDonGia.Text = "";
            cboSld.Text = "";
            cboGiaThanh.Text = "";
        }

        private void HienThiPhieuNhap()
        {
            int i = 0;
            dgvPhieuNhap.Rows.Clear();
            List<PhieuNhapHang> pnlist = pnbll.GetAllListPhieuNhap();
            foreach (PhieuNhapHang pns in pnlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuNhap);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pns.MaPn;
                row.Cells[2].Value = pns.MaNv;
                row.Cells[3].Value = pns.MaDh;
                row.Cells[4].Value = pns.NgayNhap;
                row.Cells[5].Value = pns.MaSp;
                row.Cells[6].Value = pns.Sln;
                row.Cells[7].Value = pns.DonGias;

                dgvPhieuNhap.Rows.Add(row);
                ++i;
            }
            cboMaDh.DataSource = pnbll.LoadComboxBoxMaDh();
            cboMaSp.DataSource = pnbll.LoadComboBoxMaSanPham();

            txtMaNv.Text = UserInfo.Id.ToString();
        }

        private void uc_PhieuNhap_Load(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
            EnableHome(true);
            TurnOnTextBox(false);
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.Columns[0].Width = 30;
            dgvPhieuNhap.Columns[7].DefaultCellStyle.Format = "c";
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
            txtDonGia.Enabled = true;
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
                    pn.MaNv = int.Parse(txtMaNv.Text);
                    pn.NgayNhap = DateTime.Parse(dtmNgayNhap.Value.ToLongDateString());
                    double n = 0;
                    int m = 0;
                    if (txtDonGia.Text != "")
                    {
                        if (double.TryParse(txtDonGia.Text, out n))
                        {
                            double DonGia = double.Parse(txtDonGia.Text);
                            if (DonGia > 0)
                            {
                                lbDonGia.Visible = false;
                                check = true;
                                pn.DonGias = decimal.Parse(txtDonGia.Text);
                            }
                            else
                            {
                                lbDonGia.Visible = true;
                                check = false;
                                lbDonGia.Text = "* Giá trị của Đơn Giá phải > 0! *";
                            }
                        }
                        else
                        {
                            lbDonGia.Visible = true;
                            check = false;
                            lbDonGia.Text = "* Giá trị của Đơn Giá phải là số! *";

                        }
                    }
                    else
                    {
                        lbDonGia.Visible = true;
                        check = false;
                        lbDonGia.Text = "* Đơn giá không được phép để trống! *";
                    }

                    if (cboMaDh.Text == "")
                    {
                        lbMaDh.Visible = true;
                        check = false;
                        lbMaDh.Text = "* Mã đơn hàng không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaDh.Text, out m))
                        {
                            lbMaDh.Visible = false;
                            check = true;
                            pn.MaDh = int.Parse(cboMaDh.Text);
                        }
                        else
                        {
                            lbMaDh.Visible = true;
                            check = false;
                            lbMaDh.Text = "* Mã đơn hàng phải là số! *";
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
                        if (int.TryParse(cboMaDh.Text, out m))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            pn.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                        }
                    }

                    int sln = 0, sld = 0, slcl = 0;
                    if (txtSln.Text != "")
                    {
                        if (int.TryParse(txtSln.Text, out sln))
                        {
                            sln = int.Parse(txtSln.Text);
                            sld = int.Parse(cboSld.Text);
                            slcl = int.Parse(txtSlcn.Text);
                            if (sln > 0 && sld == slcl)
                            {
                                lbSln.Visible = false;
                                check = true;
                                pn.Sln = sln;
                            }
                            else if (sln > 0 && sln <= (sld - slcl))
                            {
                                lbSln.Visible = false;
                                check = true;
                                pn.Sln = sln;
                            }
                            else
                            {
                                if (slcl == 0)
                                {
                                    lbSln.Visible = true;
                                    check = false;
                                    lbSln.Text = "* Giá trị của Số lượng nhập phải > 0 và Số lượng nhập phải <= Số lượng đặt! *";
                                }
                                else
                                {
                                    lbSln.Visible = true;
                                    check = false;
                                    lbSln.Text = "* Giá trị của số lượng nhập phải > 0 và số lượng nhập phải <= Số lượng còn nhập: " + slcl.ToString() + "*";
                                }

                            }
                        }
                        else
                        {
                            lbSln.Visible = true;
                            check = false;
                            lbSln.Text = "* Giá trị của Số lượng nhập phải là số! *";
                        }

                    }
                    else
                    {
                        lbSln.Visible = true;
                        check = false;
                        lbSln.Text = "* Giá trị trường Số lượng nhập không được để trống ! *";
                    }

                    if (check == true)
                    {
                        bool result = pnbll.InsertPhieuNhap(pn);
                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome(true);
                                //RefreshTextBox();
                                TurnOnTextBox(false);
                                HienThiPhieuNhap();
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
                    cboMaDh.Enabled = false;
                    pn.MaNv = int.Parse(txtMaNv.Text);
                    pn.NgayNhap = DateTime.Parse(dtmNgayNhap.Value.ToLongDateString());
                    double n = 0;
                    int m = 0;
                    if (txtMaPn.Text == "")
                    {
                        lbMaPn.Visible = true;
                        check = false;
                        lbMaPn.Text = "* Mã phiếu nhập đang để  trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMaPn.Text, out m))
                        {
                            lbMaPn.Visible = false;
                            check = true;
                            pn.MaPn = int.Parse(txtMaPn.Text);
                        }
                        else
                        {
                            lbMaPn.Visible = true;
                            check = false;
                            lbMaPn.Text = "* Mã phiếu nhập phải là số! *";
                            return;
                        }
                    }
                    if (txtDonGia.Text != "")
                    {
                        if (double.TryParse(txtDonGia.Text, out n))
                        {
                            double DonGia = double.Parse(txtDonGia.Text);
                            if (DonGia > 0)
                            {
                                lbDonGia.Visible = false;
                                check = true;
                                pn.DonGias = decimal.Parse(txtDonGia.Text);
                            }
                            else
                            {
                                lbDonGia.Visible = true;
                                check = false;
                                lbDonGia.Text = "* Giá trị của Đơn Giá phải > 0! *";
                                return;
                            }
                        }
                        else
                        {
                            lbDonGia.Visible = true;
                            check = false;
                            lbDonGia.Text = "* Giá trị của Đơn Giá phải là số! *";
                            return;
                        }
                    }
                    else
                    {
                        lbDonGia.Visible = true;
                        check = false;
                        lbDonGia.Text = "* Đơn giá không được phép để trống! *";
                        return;
                    }

                    if (cboMaDh.Text == "")
                    {
                        lbMaDh.Visible = true;
                        check = false;
                        lbMaDh.Text = "* Mã đơn hàng không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaDh.Text, out m))
                        {
                            lbMaDh.Visible = false;
                            check = true;
                            pn.MaDh = int.Parse(cboMaDh.Text);
                        }
                        else
                        {
                            lbMaDh.Visible = true;
                            check = false;
                            lbMaDh.Text = "* Mã đơn hàng phải là số! *";
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
                        if (int.TryParse(cboMaDh.Text, out m))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            pn.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                            return;
                        }
                    }

                    int sln = 0, sld = 0, slcl = 0;
                    if (txtSln.Text != "")
                    {
                        if (int.TryParse(txtSln.Text, out sln))
                        {
                            sln = int.Parse(txtSln.Text);
                            sld = int.Parse(cboSld.Text);
                            slcl = int.Parse(txtSlcn.Text);
                            if (sln > 0 && sld == slcl)
                            {
                                lbSln.Visible = false;
                                check = true;
                                pn.Sln = sln;
                            }
                            else if (sln > 0 && sln <= (sld - slcl))
                            {
                                lbSln.Visible = false;
                                check = true;
                                pn.Sln = sln;
                            }
                            else
                            {
                                if (slcl == 0)
                                {
                                    lbSln.Visible = true;
                                    check = false;
                                    lbSln.Text = "* Giá trị của Số lượng nhập phải > 0 và Số lượng nhập phải <= Số lượng đặt! *";
                                    return;
                                }
                                else
                                {
                                    lbSln.Visible = true;
                                    check = false;
                                    lbSln.Text = "* Giá trị của số lượng nhập phải > 0 và số lượng nhập phải <= Số lượng còn nhập: " + slcl.ToString() + "*";
                                    return;
                                }

                            }
                        }
                        else
                        {
                            lbSln.Visible = true;
                            check = false;
                            lbSln.Text = "* Giá trị của Số lượng nhập phải là số! *";
                            return;
                        }

                    }
                    else
                    {
                        lbSln.Visible = true;
                        check = false;
                        lbSln.Text = "* Giá trị trường Số lượng nhập không được để trống ! *";
                        return;
                    }

                    if (check == true)
                    {
                        bool result = pnbll.EditPhieuNhap(pn);
                        if (result)
                        {
                            DialogResult dialogResultEdit = MessageBox.Show("Edit Success !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultEdit == DialogResult.OK)
                            {
                                TurnOnTextBox(false);
                                EnableHome(true);
                                btnDelete.Enabled = true;
                                HienThiPhieuNhap();
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
                    pn.MaPn = int.Parse(txtMaPn.Text);
                    pn.MaSp = int.Parse(cboMaSp.Text);

                    bool result = pnbll.DeletePhieuNhap(pn);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {

                            RefreshTextBox();
                            HienThiPhieuNhap();
                            EnableHome(true);
                            TurnOnTextBox(false);
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
            frmReportPhieuNhap rpPhieuNhap = new frmReportPhieuNhap();
            rpPhieuNhap.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome(true);
            TurnOnTextBox(false);
        }

        private void cboMaDh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaDh.SelectedIndex == -1)
                {
                    return;
                }
                pn.MaDh = int.Parse(cboMaDh.Text);
                List<PhieuNhapHang> pnlist = pnbll.HienThiThongTinChoPhieuNhap(pn);
                foreach (PhieuNhapHang pns in pnlist)
                {
                    cboMaSp.Text = pns.MaSp.ToString();
                    cboSld.Text = pns.Sld.ToString();

                    if (pns.Sln == pns.Sld)
                    {
                        TurnOnTextBox(true);
                        isCheck = 1;
                        txtMaPn.Text = pns.MaPn.ToString();
                        txtSln.Text = pns.Sln.ToString();
                        txtSlcn.Text = (pns.Sld - pns.Sln).ToString();
                        txtDonGia.Text = pns.DonGias.ToString();
                    }
                    else if (pns.Sln > 0)
                    {
                        TurnOnTextBox(true);
                        txtSln.Text = pns.Sln.ToString();
                        txtDonGia.Text = pns.DonGias.ToString();
                        txtSlcn.Text = (pns.Sld - pns.Sln).ToString();
                    }
                    else
                    {
                        TurnOnTextBox(true);
                        int i = 0;
                        txtSln.Text = i.ToString();
                        txtDonGia.Text = i.ToString();
                        txtSlcn.Text = (pns.Sld - pns.Sln).ToString();
                    }

                }
                if (txtSln.Text == cboSld.Text)
                {
                    txtSln.Enabled = false;
                    cboGiaThanh.Enabled = false;
                    txtSlcn.Enabled = false;
                    txtDonGia.Enabled = false;
                }
                else
                {
                    txtSln.Enabled = true;
                }

                cboMaSp.DataSource = pnbll.HienThiThongTinChoPhieuNhap(pn);

                pn.MaSp = int.Parse(cboMaSp.Text);
                cboGiaThanh.DataSource = pnbll.HienThiGiaThanhMaSp(pn);
                double gia = double.Parse(cboGiaThanh.Text);
                cboGiaThanh.Text = gia.ToString("00,00.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Mã Đơn Hàng!" + ex.Message);
            }

        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            EnableHome(false);
            btnDelete.Enabled = true;
            txtMaPn.Text = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            txtMaNv.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            cboMaDh.Text = dgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();
            dtmNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[4].Value.ToString();
            cboMaSp.Text = dgvPhieuNhap.CurrentRow.Cells[5].Value.ToString();
            txtSln.Text = dgvPhieuNhap.CurrentRow.Cells[6].Value.ToString();

            double donGia = double.Parse(dgvPhieuNhap.CurrentRow.Cells[7].Value.ToString());
            txtDonGia.Text = donGia.ToString("00,00.##");
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            pn.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<PhieuNhapHang> pnlist = pnbll.LocDanhSachPhieuNhap(pn);

            if (cboChoose.Text == "Mã Phiếu Nhập")
            {
                cboSearch.Text = "";
                foreach (PhieuNhapHang pns in pnlist)
                {
                    cboSearch.Items.Add(pns.MaPn);
                }
            }
            else if (cboChoose.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (PhieuNhapHang pns in pnlist)
                {
                    cboSearch.Items.Add(pns.MaNv);
                }
            }
            else if (cboChoose.Text == "Mã Đơn Hàng")
            {
                cboSearch.Text = "";
                foreach (PhieuNhapHang pns in pnlist)
                {
                    cboSearch.Items.Add(pns.MaDh);
                }
            }
            else if (cboChoose.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (PhieuNhapHang pns in pnlist)
                {
                    cboSearch.Items.Add(pns.MaSp);
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
                HienThiPhieuNhap();
                return;
            }
            pn.Search = cboSearch.Text;
            List<PhieuNhapHang> pnlist = pnbll.TimKiemPhieuNhap(pn);
            dgvPhieuNhap.Rows.Clear();

            foreach (PhieuNhapHang pns in pnlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuNhap);

                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pns.MaPn;
                row.Cells[2].Value = pns.MaNv;
                row.Cells[3].Value = pns.MaDh;
                row.Cells[4].Value = pns.NgayNhap;
                row.Cells[5].Value = pns.MaSp;
                row.Cells[6].Value = pns.Sln;
                row.Cells[7].Value = pns.DonGias;

                dgvPhieuNhap.Rows.Add(row);
                ++i;
            }
        }
    }
}
