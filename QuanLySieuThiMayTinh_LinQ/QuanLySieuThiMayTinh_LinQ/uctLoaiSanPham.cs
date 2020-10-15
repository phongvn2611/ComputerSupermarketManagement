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
    public partial class uctLoaiSanPham : UserControl
    {
        LoaiSanPham lsp = new LoaiSanPham();
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
        int isCheck = 0;

        public uctLoaiSanPham()
        {
            InitializeComponent();
        }

        private void EnableHome()
        {
            btnSave.Enabled = false;
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnPrint.Enabled = true;
            btnCancel.Enabled = false;
            lbMaLoai.Visible = false;
            lbTenLoai.Visible = false;
            lbDvt.Visible = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaLoai.Enabled = false;
            txtTenLoai.Enabled = isCheck;
            txtDvt.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtDvt.Text = "";

        }

        private void HienThiLoaiSanPham()
        {
            int i = 0;
            dgvLoaiSp.Rows.Clear();
            TurnOffTextBox(false);
            List<LoaiSanPham> lsplist = lspbll.GetAllListLoaiSp();
            foreach (LoaiSanPham lsps in lsplist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLoaiSp);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = lsps.MaLoai;
                row.Cells[2].Value = lsps.TenLoai;
                row.Cells[3].Value = lsps.Dvt;

                dgvLoaiSp.Rows.Add(row);
                ++i;

            }

        }

        private void uc_LoaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiLoaiSanPham();
            EnableHome();
            TurnOffTextBox(false);

            dgvLoaiSp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSp.AllowUserToAddRows = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            RefreshTextBox();
            TurnOffTextBox(true);
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
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

                    if (txtTenLoai.Text == "")
                    {
                        lbTenLoai.Visible = true;
                        check = false;
                        lbTenLoai.Text = "* Trường dữ liệu Tên Loại không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtTenLoai.Text, out n))
                        {
                            lbTenLoai.Visible = true;
                            check = false;
                            lbTenLoai.Text = "* Trường dữ liệu Tên Loại không được chỉ là số! *";
                        }
                        else
                        {
                            lbTenLoai.Visible = false;
                            check = true;
                            lsp.TenLoai = txtTenLoai.Text;
                        }
                    }

                    if (txtDvt.Text == "")
                    {
                        lbDvt.Visible = true;
                        check = false;
                        lbDvt.Text = "* Trường dữ liệu DVT không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtDvt.Text, out n))
                        {
                            lbDvt.Visible = true;
                            check = false;
                            lbDvt.Text = "* Trường dữ liệu DVT không được là số! *";
                        }
                        else
                        {
                            lbDvt.Visible = false;
                            check = true;
                            lsp.Dvt = txtDvt.Text;
                        }
                    }

                    if (check == true)
                    {
                        bool result = lspbll.InserLoaiSanPham(lsp);

                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                HienThiLoaiSanPham();
                                EnableHome();
                            }

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Fail!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isCheck == 1)
            {
                try
                {

                    int n = 0;

                    if (txtMaLoai.Text == "")
                    {
                        lbTenLoai.Visible = true;
                        check = false;
                        lbTenLoai.Text = "* Ban phải chọn loại sản phẩm cần sửa trước!*";
                        return;
                    }
                    else
                    {
                        lbTenLoai.Visible = false;
                        check = true;
                        lsp.MaLoai = int.Parse(txtMaLoai.Text);
                    }

                    if (txtTenLoai.Text == "")
                    {
                        lbTenLoai.Visible = true;
                        check = false;
                        lbTenLoai.Text = "* Trường dữ liệu Tên Loại không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtTenLoai.Text, out n))
                        {
                            lbTenLoai.Visible = true;
                            check = false;
                            lbTenLoai.Text = "* Trường dữ liệu Tên Loại không được chỉ là số! *";
                            return;
                        }
                        else
                        {
                            lbTenLoai.Visible = false;
                            check = true;
                            lsp.TenLoai = txtTenLoai.Text;
                        }
                    }

                    if (txtDvt.Text == "")
                    {
                        lbDvt.Visible = true;
                        check = false;
                        lbDvt.Text = "* Trường dữ liệu DVT không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtDvt.Text, out n))
                        {
                            lbDvt.Visible = true;
                            check = false;
                            lbDvt.Text = "* Trường dữ liệu DVT không được là số! *";
                            return;
                        }
                        else
                        {
                            lbDvt.Visible = false;
                            check = true;
                            lsp.Dvt = txtDvt.Text;
                        }
                    }

                    if (check == true)
                    {
                        bool result = lspbll.EditLoaiSanPham(lsp);

                        if (result)
                        {
                            DialogResult dialogResultEdit = MessageBox.Show("Edit Successfull!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultEdit == DialogResult.OK)
                            {
                                HienThiLoaiSanPham();
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Fail!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    lsp.MaLoai = int.Parse(txtMaLoai.Text);

                    bool result = lspbll.DeleteLoaiSanPham(lsp);
                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            HienThiLoaiSanPham();
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
            frmReportLoaiSanPham frmLoaiSp = new frmReportLoaiSanPham();
            frmLoaiSp.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
        }

        private void dgvLoaiSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaLoai.Text = dgvLoaiSp.CurrentRow.Cells[1].Value.ToString();
            txtTenLoai.Text = dgvLoaiSp.CurrentRow.Cells[2].Value.ToString();
            txtDvt.Text = dgvLoaiSp.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            lsp.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<LoaiSanPham> lsplist = lspbll.LocDanhSachLoaiSanPham(lsp);

            if (cboChoose.Text == "Mã Loại")
            {
                cboSearch.Text = "";
                foreach (LoaiSanPham lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.MaLoai);
                }
            }
            else if (cboChoose.Text == "Tên Loại")
            {
                cboSearch.Text = "";
                foreach (LoaiSanPham lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.TenLoai);
                }
            }
            else if (cboChoose.Text == "Đơn Vị Tính")
            {
                cboSearch.Text = "";
                foreach (LoaiSanPham lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.Dvt);
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
                HienThiLoaiSanPham();
                return;
            }
            lsp.Search = cboSearch.Text;
            List<LoaiSanPham> lsplist = lspbll.TimKiemLoaiSanPham(lsp);
            dgvLoaiSp.Rows.Clear();

            foreach (LoaiSanPham lsps in lsplist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLoaiSp);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = lsps.MaLoai;
                row.Cells[2].Value = lsps.TenLoai;
                row.Cells[3].Value = lsps.Dvt;

                dgvLoaiSp.Rows.Add(row);
                ++i;
            }
        }
    }
}
