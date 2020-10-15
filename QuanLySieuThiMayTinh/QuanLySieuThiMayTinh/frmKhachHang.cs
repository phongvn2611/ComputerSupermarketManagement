using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.DAL;
using QuanLySieuThiMayTinh.BLL;

namespace QuanLySieuThiMayTinh
{
    public partial class frmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        KhachHangBLL khbll = new KhachHangBLL();
        int isCheck = 0;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void EnableHome()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = true;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtDiaChi.Enabled = isCheck;
            txtTenKh.Enabled = isCheck;
            txtMail.Enabled = isCheck;
            txtMaKh.Enabled = false;
            txtDienThoai.Enabled = isCheck;
            cboGioiTinh.Enabled = isCheck;
            dtmNgayDk.Enabled = isCheck;
            dtmNgaySinh.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtDiaChi.Text = "";
            txtTenKh.Text = "";
            txtMail.Text = "";
            txtMaKh.Text = "";
            txtDienThoai.Text = "";
            cboGioiTinh.Text = "";
            dtmNgayDk.Text = "";
            dtmNgaySinh.Text = "";
        }

        private void HienThiKhachHang()
        {
            int i = 0;
            TurnOffTextBox(false);
            dgvKhachHang.Rows.Clear();
            List<KhachHang> khlist = khbll.ShowAllListKhachHang();
            foreach (KhachHang khs in khlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvKhachHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = khs.MaKh;
                row.Cells[2].Value = khs.Hoten;
                row.Cells[3].Value = khs.NgaySinh;
                row.Cells[4].Value = khs.GioiTinh;
                row.Cells[5].Value = khs.Sdt;
                row.Cells[6].Value = khs.Mail;
                row.Cells[7].Value = khs.DiaChi;
                row.Cells[8].Value = khs.NgayDk;

                dgvKhachHang.Rows.Add(row);
                ++i;
            }
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
            EnableHome();
            TurnOffTextBox(false);
            RefreshTextBox();
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.Columns[0].Width = 30;
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
            if (isCheck == 0)
            {
                try
                {
                    string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();
                    kh.Hoten = txtTenKh.Text;
                    kh.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                    if (cboGioiTinh.SelectedIndex == 0)
                    {
                        kh.GioiTinh = cboGioiTinh.Text;
                    }
                    else if (cboGioiTinh.SelectedIndex == 1)
                    {
                        kh.GioiTinh = cboGioiTinh.Text;
                    }
                    else if (cboGioiTinh.SelectedIndex == 2)
                    {
                        kh.GioiTinh = cboGioiTinh.Text;
                    }
                    kh.Sdt = txtDienThoai.Text;
                    kh.Mail = txtMail.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    //kh.NgayDk = DateTime.Parse(dtmNgayDk.Value.ToShortDateString());
                    kh.NgayDk = DateTime.Now;

                    bool result = khbll.InsertKhachHang(kh);
                    if (result)
                    {
                        HienThiKhachHang();
                        EnableHome();
                    }

                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Insert Khách Hàng Thất Bại!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    //string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();
                    kh.MaKh = int.Parse(txtMaKh.Text);
                    kh.Hoten = txtTenKh.Text;
                    kh.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                    //cboGioiTinh.Text = UserInfo.GioiTinh.ToString().Trim();
                    if (cboGioiTinh.SelectedIndex == -1)
                    {

                        if (cboGioiTinh.Text.Trim() == "nam")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "nữ")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "khác")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                    }
                    else
                    {
                        if (cboGioiTinh.Text.Trim() == "nam")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "nữ")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "khác")
                        {
                            kh.GioiTinh = cboGioiTinh.Text;
                        }
                    }

                    kh.Sdt = txtDienThoai.Text;
                    kh.Mail = txtMail.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.NgayDk = DateTime.Parse(dtmNgayDk.Value.ToShortDateString());

                    bool result = khbll.UpdateKhachHang(kh);
                    if (result)
                    {
                        HienThiKhachHang();
                        EnableHome();
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Edit Khách Hàng Thất Bại!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TurnOffTextBox(false);
            DialogResult dialogResultExecute = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResultExecute == DialogResult.Yes)
            {
                try
                {
                    kh.MaKh = int.Parse(txtMaKh.Text);

                    if (txtMaKh.Text.Trim() == null)
                    {
                        DialogResult dialogResultCheck = MessageBox.Show("Khách Hàng Muốn Xóa Không Tồn Tại, Xin Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultCheck == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    bool result = khbll.DeleteKhachHang(kh);

                    if (result)
                    {
                        DialogResult dialogResultShow = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultShow == DialogResult.OK)
                        {
                            HienThiKhachHang();
                        }

                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Khách Hàng Thất Bại!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportKhachHang rpKhachHang = new frmReportKhachHang();
            rpKhachHang.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaKh.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtTenKh.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            dtmNgaySinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            cboGioiTinh.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
            dtmNgayDk.Text = dgvKhachHang.CurrentRow.Cells[8].Value.ToString();
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }
            kh.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<KhachHang> khlist = khbll.LocDanhSachKhachHang(kh);
            if (cboChoose.Text == "Mã Khách Hàng")
            {
                cboSearch.Text = "";
                foreach (KhachHang nvs in khlist)
                {
                    cboSearch.Items.Add(nvs.MaKh);
                }
            }
            else if (cboChoose.Text == "Họ Tên")
            {
                cboSearch.Text = "";
                foreach (KhachHang nvs in khlist)
                {
                    cboSearch.Items.Add(nvs.Hoten);
                }
            }
            else if (cboChoose.Text == "Giới Tính")
            {
                cboSearch.Text = "";
                foreach (KhachHang nvs in khlist)
                {
                    cboSearch.Items.Add(nvs.GioiTinh);
                }
            }
            else if (cboChoose.Text == "Mail")
            {
                cboSearch.Text = "";
                foreach (KhachHang nvs in khlist)
                {
                    cboSearch.Items.Add(nvs.Mail);
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
                HienThiKhachHang();
                return;
            }
            kh.Search = cboSearch.Text;
            List<KhachHang> khlist = khbll.TimKiemKhachHang(kh);
            dgvKhachHang.Rows.Clear();
            foreach (KhachHang khs in khlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvKhachHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = khs.MaKh.ToString();
                row.Cells[2].Value = khs.Hoten.ToString();
                row.Cells[3].Value = khs.NgaySinh.ToString();
                row.Cells[4].Value = khs.GioiTinh.ToString();
                row.Cells[5].Value = khs.Sdt.ToString();
                row.Cells[6].Value = khs.Mail.ToString();
                row.Cells[7].Value = khs.DiaChi.ToString();
                row.Cells[8].Value = khs.NgayDk.ToString();

                dgvKhachHang.Rows.Add(row);
                ++i;
            }
        }
    }
}
