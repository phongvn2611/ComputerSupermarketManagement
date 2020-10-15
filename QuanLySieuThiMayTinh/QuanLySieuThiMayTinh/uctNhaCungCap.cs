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
    public partial class uctNhaCungCap : UserControl
    {
        NhaCungCap ncc = new NhaCungCap();
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        int isCheck = 0;

        public uctNhaCungCap()
        {
            InitializeComponent();
        }

        private void EnableHome()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = true;
            btnCancel.Enabled = false;
            lbMaCc.Visible = false;
            lbTenCc.Visible = false;
            lbDiaChi.Visible = false;
            lbDienThoai.Visible = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaCc.Enabled = false;
            txtTenCc.Enabled = isCheck;
            txtDienThoai.Enabled = isCheck;
            txtDiaChi.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtMaCc.Text = "";
            txtTenCc.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void HienThiDanhSachNhaCungCap()
        {
            int i = 0;
            dgvNhaCc.Rows.Clear();
            List<NhaCungCap> ncclist = nccbll.GetAllListNhaCungCap();
            foreach (NhaCungCap nccs in ncclist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaCc);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nccs.MaCC;
                row.Cells[2].Value = nccs.TenCC;
                row.Cells[3].Value = nccs.DiaChi;
                row.Cells[4].Value = nccs.Sdt;

                dgvNhaCc.Rows.Add(row);
                ++i;
            }
        }

        private void uc_NhaCungCap_Load(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
            HienThiDanhSachNhaCungCap();

            dgvNhaCc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhaCc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCc.AllowUserToAddRows = false;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            RefreshTextBox();
            TurnOffTextBox(true);
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
                    int n = 0;
                    if (txtTenCc.Text == "")
                    {
                        lbTenCc.Visible = true;
                        check = false;
                        lbTenCc.Text = "* Tên Nhà Cung Cấp không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtTenCc.Text, out n))
                        {
                            lbTenCc.Visible = true;
                            check = false;
                            lbTenCc.Text = "* Tên Nhà Cung Cấp không được là số! *";
                        }
                        else
                        {
                            lbTenCc.Visible = false;
                            check = true;
                            ncc.TenCC = txtTenCc.Text;
                        }
                    }

                    if (txtDiaChi.Text == "")
                    {
                        lbDiaChi.Visible = true;
                        check = false;
                        lbDiaChi.Text = "* Địa chỉ không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtDiaChi.Text, out n))
                        {
                            lbDiaChi.Visible = true;
                            check = false;
                            lbDiaChi.Text = "* Địa chỉ phải là chữ cái hoặc cả chữ và số *";
                        }
                        else
                        {
                            lbDiaChi.Visible = false;
                            check = true;
                            ncc.DiaChi = txtDiaChi.Text;
                        }
                    }

                    if (txtDienThoai.Text == "")
                    {
                        lbDienThoai.Visible = true;
                        check = false;
                        lbDienThoai.Text = "* Trường Điện Thoại Không Được Để Trống *";
                    }
                    else
                    {
                        if (int.TryParse(txtDienThoai.Text, out n))
                        {
                            lbDienThoai.Visible = false;
                            check = true;
                            ncc.Sdt = txtDienThoai.Text;
                        }
                        else
                        {
                            lbDienThoai.Visible = true;
                            check = false;
                            lbDienThoai.Text = "* Số điện thoại phải là số *";
                        }
                    }


                    if (check == true)
                    {
                        bool result = nccbll.InsertNhaCungCap(ncc);

                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                HienThiDanhSachNhaCungCap();
                            }
                        }
                    }
                    else
                    {
                        return;
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



                    if (txtMaCc.Text == "")
                    {
                        check = false;
                        lbMaCc.Visible = true;
                        lbMaCc.Text = "* Mã nhà cung cấp không được phép để trống!*";
                        return;
                    }
                    else
                    {
                        check = true;
                        lbMaCc.Visible = false;
                        ncc.MaCC = int.Parse(txtMaCc.Text);
                    }

                    int n = 0;
                    if (txtTenCc.Text == "")
                    {
                        lbTenCc.Visible = true;
                        check = false;
                        lbTenCc.Text = "* Tên Nhà Cung Cấp không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtTenCc.Text, out n))
                        {
                            lbTenCc.Visible = true;
                            check = false;
                            lbTenCc.Text = "* Tên Nhà Cung Cấp không được là số! *";
                            return;
                        }
                        else
                        {
                            lbTenCc.Visible = false;
                            check = true;
                            ncc.TenCC = txtTenCc.Text;
                        }
                    }

                    if (txtDiaChi.Text == "")
                    {
                        lbDiaChi.Visible = true;
                        check = false;
                        lbDiaChi.Text = "* Địa chỉ không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtDiaChi.Text, out n))
                        {
                            lbDiaChi.Visible = true;
                            check = false;
                            lbDiaChi.Text = "* Địa chỉ phải là chữ cái hoặc cả chữ và số *";
                            return;
                        }
                        else
                        {
                            lbDiaChi.Visible = false;
                            check = true;
                            ncc.DiaChi = txtDiaChi.Text;
                        }
                    }

                    if (txtDienThoai.Text == "")
                    {
                        lbDienThoai.Visible = true;
                        check = false;
                        lbDienThoai.Text = "* Trường Điện Thoại Không Được Để Trống *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtDienThoai.Text, out n))
                        {
                            lbDienThoai.Visible = false;
                            check = true;
                            ncc.Sdt = txtDienThoai.Text;
                        }
                        else
                        {
                            lbDienThoai.Visible = true;
                            check = false;
                            lbDienThoai.Text = "* Số điện thoại phải là số *";
                            return;
                        }
                    }

                    if (check == true)
                    {
                        bool result = nccbll.EditNhaCungCap(ncc);
                        if (result)
                        {
                            DialogResult dialogResultEdit = MessageBox.Show("Edit Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultEdit == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                btnDelete.Enabled = true;
                                HienThiDanhSachNhaCungCap();
                            }
                        }
                    }
                    else
                    {
                        return;
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
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    ncc.MaCC = int.Parse(txtMaCc.Text);
                    bool result = nccbll.DeleteNhaCungCap(ncc);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successfull!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            HienThiDanhSachNhaCungCap();
                            RefreshTextBox();
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
            frmReportNhaCungCap rbNhaCc = new frmReportNhaCungCap();
            rbNhaCc.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TurnOffTextBox(false);
            EnableHome();
        }


        private void dgvNhaCc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaCc.Text = dgvNhaCc.CurrentRow.Cells[1].Value.ToString();
            txtTenCc.Text = dgvNhaCc.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhaCc.CurrentRow.Cells[3].Value.ToString();
            txtDienThoai.Text = dgvNhaCc.CurrentRow.Cells[4].Value.ToString();
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            ncc.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<NhaCungCap> ncclist = nccbll.LocDanhSachNhaCungCap(ncc);

            if (cboChoose.Text == "Mã Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.MaCC);
                }
            }
            else if (cboChoose.Text == "Tên Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.TenCC);
                }
            }
            else if (cboChoose.Text == "Số Điện Thoại")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.Sdt);
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
                HienThiDanhSachNhaCungCap();
                return;
            }
            ncc.Search = cboSearch.Text;
            List<NhaCungCap> ncclist = nccbll.TimKiemNhaCungCap(ncc);
            dgvNhaCc.Rows.Clear();

            foreach (NhaCungCap nccs in ncclist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaCc);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nccs.MaCC;
                row.Cells[2].Value = nccs.TenCC;
                row.Cells[3].Value = nccs.DiaChi;
                row.Cells[4].Value = nccs.Sdt;

                dgvNhaCc.Rows.Add(row);
                ++i;
            }
        }
    }
}
