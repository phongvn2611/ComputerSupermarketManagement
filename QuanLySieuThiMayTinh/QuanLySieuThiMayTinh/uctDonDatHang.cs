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
    public partial class uctDonDatHang : UserControl
    {
        DonDatHang dh = new DonDatHang();
        DonDatHangBLL dhbll = new DonDatHangBLL();
        int isCheck = 0;

        public uctDonDatHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EnableHome()
        {
            btnSave.Enabled = false;
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnPrint.Enabled = true;
            btnCancel.Enabled = false;
            lbMaDh.Visible = false;
            lbMaNv.Visible = false;
            lbMaCc.Visible = false;
            lbMaSp.Visible = false;
            lbNgayDat.Visible = false;
            lbSld.Visible = false;

        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaDh.Enabled = false;
            cboMaNv.Enabled = false;
            cboTenNv.Enabled = false;
            cboMaCc.Enabled = isCheck;
            cboMaSp.Enabled = isCheck;
            cboTenCc.Enabled = isCheck;
            cboTenSp.Enabled = isCheck;
            txtNgayDat.Enabled = false;
            txtSld.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtMaDh.Text = "";
            //txtMaNv.Text = "";
            txtNgayDat.Text = "";
            txtSld.Text = "";
            cboMaCc.Text = "";
            cboMaSp.Text = "";
            cboTenCc.Text = "";
            cboTenSp.Text = "";
            txtSld.Text = "";

        }

        private void HienThiDonHang()
        {
            int i = 0;
            dgvDonDatHang.Rows.Clear();
            List<DonDatHang> dhlist = dhbll.GetAllDataDonDh();
            foreach (DonDatHang dhs in dhlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDonDatHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = dhs.MaDh;
                row.Cells[2].Value = dhs.MaNv;
                row.Cells[3].Value = dhs.MaCc;
                row.Cells[4].Value = dhs.MaSp;
                row.Cells[5].Value = dhs.SlDh;
                row.Cells[6].Value = dhs.NgayDh;

                dgvDonDatHang.Rows.Add(row);
                ++i;
            }
            cboMaCc.DataSource = dhbll.LoadComboBoxMacc();
            cboMaSp.DataSource = dhbll.ShowDataMaSp();
            cboMaNv.Text = UserInfo.Id.ToString();
            cboTenNv.Text = UserInfo.FullName.ToString();
            //string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            //txtNgayDh.Text = datetime;
        }


        private void uc_DonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDonHang();
            EnableHome();
            TurnOffTextBox(false);
            dgvDonDatHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonDatHang.AllowUserToAddRows = false;
            dgvDonDatHang.Columns[0].Width = 30;
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
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);
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
                    dh.MaNv = int.Parse(cboMaNv.Text);

                    int n = 0;
                    if (cboMaCc.Text == "")
                    {
                        lbMaCc.Visible = true;
                        check = false;
                        lbMaCc.Text = "* Mã cung cấp không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(cboMaCc.Text, out n))
                        {
                            lbMaCc.Visible = false;
                            check = true;
                            dh.MaCc = int.Parse(cboMaCc.Text);
                        }
                        else
                        {
                            lbMaCc.Visible = true;
                            check = false;
                            lbMaCc.Text = "* Mã cung cấp phải là số! *";
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
                        if (int.TryParse(cboMaSp.Text, out n))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            dh.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                        }
                    }

                    if (txtSld.Text == "")
                    {
                        lbSld.Visible = true;
                        check = false;
                        lbSld.Text = "* Số lượng đặt không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtSld.Text, out n))
                        {
                            int i = int.Parse(txtSld.Text);
                            if (i > 0)
                            {
                                lbSld.Visible = true;
                                check = true;
                                dh.SlDh = i;
                            }
                            else
                            {
                                lbSld.Visible = true;
                                check = false;
                                lbSld.Text = "* Số lượng đặt phải > 0 *";
                            }
                        }
                        else
                        {
                            lbSld.Visible = true;
                            check = false;
                            lbSld.Text = "* Số lượng đặt phải là số !*";
                        }
                    }


                    dh.NgayDh = DateTime.Now;
                    txtNgayDat.Text = dh.NgayDh.ToLongDateString();
                    //dh.NgayDh = DateTime.Parse(dtmNgayDat.Value.ToLongDateString());

                    if (check == true)
                    {
                        bool result = dhbll.InsertDonDatHang(dh);

                        if (result)
                        {
                            DialogResult dr = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                RefreshTextBox();
                                TurnOffTextBox(false);
                                EnableHome();
                                HienThiDonHang();
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
                    dh.MaNv = int.Parse(cboMaNv.Text);

                    int n = 0;

                    if (txtMaDh.Text == "")
                    {
                        lbMaDh.Visible = true;
                        check = false;
                        lbMaDh.Text = "* Mã đơn hàng đang để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMaDh.Text, out n))
                        {
                            lbMaDh.Visible = false;
                            check = true;
                            dh.MaDh = int.Parse(txtMaDh.Text);
                        }
                        else
                        {
                            lbMaDh.Visible = true;
                            check = false;
                            lbMaDh.Text = "* Mã đơn hàng phải là số! *";
                            return;
                        }
                    }

                    if (cboMaCc.Text == "")
                    {
                        lbMaCc.Visible = true;
                        check = false;
                        lbMaCc.Text = "* Mã cung cấp không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(cboMaCc.Text, out n))
                        {
                            lbMaCc.Visible = false;
                            check = true;
                            dh.MaCc = int.Parse(cboMaCc.Text);
                        }
                        else
                        {
                            lbMaCc.Visible = true;
                            check = false;
                            lbMaCc.Text = "* Mã cung cấp phải là số! *";
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
                        if (int.TryParse(cboMaSp.Text, out n))
                        {
                            lbMaSp.Visible = false;
                            check = true;
                            dh.MaSp = int.Parse(cboMaSp.Text);
                        }
                        else
                        {
                            lbMaSp.Visible = true;
                            check = false;
                            lbMaSp.Text = "* Mã sản phẩm phải là số! *";
                            return;
                        }
                    }

                    if (txtSld.Text == "")
                    {
                        lbSld.Visible = true;
                        check = false;
                        lbSld.Text = "* Số lượng đặt không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtSld.Text, out n))
                        {
                            int i = int.Parse(txtSld.Text);
                            if (i > 0)
                            {
                                lbSld.Visible = false;
                                check = true;
                                dh.SlDh = i;
                            }
                            else
                            {
                                lbSld.Visible = true;
                                check = false;
                                lbSld.Text = "* Số lượng đặt phải > 0 *";
                                return;
                            }
                        }
                        else
                        {
                            lbSld.Visible = true;
                            check = false;
                            lbSld.Text = "* Số lượng đặt phải là số !*";
                            return;
                        }
                    }
                    //dh.NgayDh = DateTime.Parse(txtNgayDh.Text);
                    //dh.NgayDh = DateTime.Parse(dtmNgayDat.Value.ToLongDateString());
                    dh.NgayDh = DateTime.Parse(txtNgayDat.Text);

                    if (check == true)
                    {
                        bool result = dhbll.EditDonDatHang(dh);

                        if (result)
                        {
                            DialogResult dr = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dr == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                btnDelete.Enabled = true;
                                HienThiDonHang();
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
                    dh.MaDh = int.Parse(txtMaDh.Text);

                    bool result = dhbll.DeleteDonDatHang(dh);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            HienThiDonHang();
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
            frmReportDonDatHang rpDonDh = new frmReportDonDatHang();
            rpDonDh.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TurnOffTextBox(false);
            EnableHome();
        }

        private void cboMaCc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaCc.SelectedIndex == -1)
            {
                return;
            }
            dh.MaCc = int.Parse(cboMaCc.Text);
            cboTenCc.DataSource = dhbll.ShowTenCCFlowMaCC(dh);
        }

        private void cboMaNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaNv.SelectedIndex == -1)
            //{
            //    return;
            //}
            //dh.MaNv = int.Parse(cboMaNv.Text);
            //cboTenNv.DataSource = dhbll.HienThiTenNhanVienTheoMaNv(dh);
        }

        private void dgvDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaDh.Text = dgvDonDatHang.CurrentRow.Cells[1].Value.ToString();
            cboMaNv.Text = dgvDonDatHang.CurrentRow.Cells[2].Value.ToString();
            cboMaCc.Text = dgvDonDatHang.CurrentRow.Cells[3].Value.ToString();
            cboMaSp.Text = dgvDonDatHang.CurrentRow.Cells[4].Value.ToString();
            txtSld.Text = dgvDonDatHang.CurrentRow.Cells[5].Value.ToString();
            txtNgayDat.Text = dgvDonDatHang.CurrentRow.Cells[6].Value.ToString();
        }

        private void cboMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSp.SelectedIndex == -1)
            {
                return;
            }
            dh.MaSp = int.Parse(cboMaSp.Text);
            cboTenSp.DataSource = dhbll.HienThiTenSpTheoMaSp(dh);
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            dh.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<DonDatHang> dhlist = dhbll.LocDanhSanhSachDonDatHang(dh);

            if (cboChoose.Text == "Mã Đơn Hàng")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaDh);
                }
            }
            else if (cboChoose.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaNv);
                }
            }
            else if (cboChoose.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaSp);
                }
            }
            else if (cboChoose.Text == "Mã Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaCc);
                }
            }
            else if (cboChoose.Text == "Số Lượng Đặt")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.SlDh);
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
                HienThiDonHang();
                return;
            }
            dh.Search = cboSearch.Text;
            List<DonDatHang> dhlist = dhbll.TimKiemDonDatHang(dh);
            dgvDonDatHang.Rows.Clear();

            foreach (DonDatHang dhs in dhlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDonDatHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = dhs.MaDh;
                row.Cells[2].Value = dhs.MaNv;
                row.Cells[3].Value = dhs.MaCc;
                row.Cells[4].Value = dhs.MaSp;
                row.Cells[5].Value = dhs.SlDh;
                row.Cells[6].Value = dhs.NgayDh;

                dgvDonDatHang.Rows.Add(row);
                ++i;
            }
        }
    }
}
