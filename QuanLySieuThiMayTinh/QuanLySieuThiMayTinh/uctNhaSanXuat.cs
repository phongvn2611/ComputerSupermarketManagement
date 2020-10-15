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
    public partial class uctNhaSanXuat : UserControl
    {
        NhaSanXuat nsx = new NhaSanXuat();
        NhaSanXuatBLL nsxbll = new NhaSanXuatBLL();
        int isCheck = 0;

        public uctNhaSanXuat()
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
            lbMaSx.Visible = false;
            lbTenSx.Visible = false;
            lbQuocGia.Visible = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaSx.Enabled = false;
            txtTenSx.Enabled = isCheck;
            txtQuocGia.Enabled = isCheck;

        }

        private void RefreshTextBox()
        {
            txtMaSx.Text = "";
            txtTenSx.Text = "";
            txtQuocGia.Text = "";

        }

        private void HienThiNhaSanxuat()
        {
            int i = 0;
            dgvNhaSx.Rows.Clear();
            List<NhaSanXuat> nsxlist = nsxbll.GetAllListNhaSx();
            foreach (NhaSanXuat nsxs in nsxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaSx);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nsxs.MaSx;
                row.Cells[2].Value = nsxs.TenSx;
                row.Cells[3].Value = nsxs.QuocGia;

                dgvNhaSx.Rows.Add(row);
                ++i;
            }
        }

        private void uc_NhaSanXuat_Load(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
            HienThiNhaSanxuat();

            dgvNhaSx.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhaSx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaSx.AllowUserToAddRows = false;
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
                    if (txtTenSx.Text == "")
                    {
                        lbTenSx.Visible = true;
                        check = false;
                        lbTenSx.Text = "* Tên Nhà Sản Xuất không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtTenSx.Text, out n))
                        {
                            lbTenSx.Visible = true;
                            check = false;
                            lbTenSx.Text = "* Tên Nhà Sản Xuất không được phép là số! *";
                        }
                        else
                        {
                            lbTenSx.Visible = false;
                            check = true;
                            nsx.TenSx = txtTenSx.Text;
                        }
                    }

                    if (txtQuocGia.Text == "")
                    {
                        lbQuocGia.Visible = true;
                        check = false;
                        lbQuocGia.Text = "* Trường Quốc Gia không được để trống! *";
                    }
                    else
                    {
                        if (int.TryParse(txtQuocGia.Text, out n))
                        {
                            lbQuocGia.Visible = true;
                            check = false;
                            lbQuocGia.Text = "* Giá trị trường Quốc Gia không được phép là số *";
                        }
                        else
                        {
                            lbQuocGia.Visible = false;
                            check = true;
                            nsx.QuocGia = txtQuocGia.Text;
                        }
                    }

                    if (check == true)
                    {
                        bool result = nsxbll.InserNhaSx(nsx);
                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                HienThiNhaSanxuat();
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
                    if (txtMaSx.Text == "")
                    {
                        lbMaSx.Visible = true;
                        check = false;
                        lbMaSx.Text = "* Bạn phải chọn nhà sản xuất cần sửa trước!*";
                        return;
                    }
                    else
                    {
                        lbMaSx.Visible = false;
                        check = true;
                        nsx.MaSx = int.Parse(txtMaSx.Text);
                    }

                    if (txtTenSx.Text == "")
                    {
                        lbTenSx.Visible = true;
                        check = false;
                        lbTenSx.Text = "* Tên Nhà Sản Xuất không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtTenSx.Text, out n))
                        {
                            lbTenSx.Visible = true;
                            check = false;
                            lbTenSx.Text = "* Tên Nhà Sản Xuất không được phép là số! *";
                            return;
                        }
                        else
                        {
                            lbTenSx.Visible = false;
                            check = true;
                            nsx.TenSx = txtTenSx.Text;
                        }
                    }

                    if (txtQuocGia.Text == "")
                    {
                        lbQuocGia.Visible = true;
                        check = false;
                        lbQuocGia.Text = "* Trường Quốc Gia không được để trống! *";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtQuocGia.Text, out n))
                        {
                            lbQuocGia.Visible = true;
                            check = false;
                            lbQuocGia.Text = "* Giá trị trường Quốc Gia không được phép là số *";
                            return;
                        }
                        else
                        {
                            lbQuocGia.Visible = false;
                            check = true;
                            nsx.QuocGia = txtQuocGia.Text;
                        }
                    }

                    if (check == true)
                    {
                        bool result = nsxbll.EditNhaSx(nsx);
                        if (result)
                        {
                            DialogResult dialogResultInsert = MessageBox.Show("Edit Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialogResultInsert == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                btnDelete.Enabled = true;
                                HienThiNhaSanxuat();
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
            DialogResult dialogResultDelete = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhân xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResultDelete == DialogResult.Yes)
            {
                try
                {
                    nsx.MaSx = int.Parse(txtMaSx.Text);
                    bool result = nsxbll.DeleteNhaSx(nsx);
                    if (result)
                    {
                        DialogResult dialogResult = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            HienThiNhaSanxuat();
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
            frmReportNhaSanXuat rpNhaSx = new frmReportNhaSanXuat();
            rpNhaSx.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TurnOffTextBox(false);
            EnableHome();
        }

        private void dgvNhaSx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaSx.Text = dgvNhaSx.CurrentRow.Cells[1].Value.ToString();
            txtTenSx.Text = dgvNhaSx.CurrentRow.Cells[2].Value.ToString();
            txtQuocGia.Text = dgvNhaSx.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }

            nsx.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<NhaSanXuat> nsxlist = nsxbll.LocDanhSachNhaSanXuat(nsx);

            if (cboChoose.Text == "Mã Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (NhaSanXuat nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.MaSx);
                }
            }
            else if (cboChoose.Text == "Tên Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (NhaSanXuat nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.TenSx);
                }
            }
            else if (cboChoose.Text == "Quốc Gia")
            {
                cboSearch.Text = "";
                foreach (NhaSanXuat nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.QuocGia);
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
                HienThiNhaSanxuat();
                return;
            }
            nsx.Search = cboSearch.Text;
            List<NhaSanXuat> nsxlist = nsxbll.TimKiemNhaSx(nsx);
            dgvNhaSx.Rows.Clear();

            foreach (NhaSanXuat nsxs in nsxlist)
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaSx);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nsxs.MaSx;
                row.Cells[2].Value = nsxs.TenSx;
                row.Cells[3].Value = nsxs.QuocGia;

                dgvNhaSx.Rows.Add(row);
                ++i;

            }
        }
    }
}
