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
    public partial class uctNhanVien : UserControl
    {
        NhanVien nv = new NhanVien();
        NhanVienBLL nvbll = new NhanVienBLL();
        int isCheck = 0;

        public uctNhanVien()
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
            lbMaNv.Visible = false;
            lbHoTen.Visible = false;
            lbNgayLam.Visible = false;
            lbNgaySinh.Visible = false;
            lbGioiTinh.Visible = false;
            lbMail.Visible = false;
            lbDiaChi.Visible = false;
            lbDienThoai.Visible = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtDiaChi.Enabled = isCheck;
            txtHoten.Enabled = isCheck;
            txtMail.Enabled = isCheck;
            txtMaNv.Enabled = false;
            txtDienThoai.Enabled = isCheck;
            cboGioiTinh.Enabled = isCheck;
            dtmNgayLam.Enabled = isCheck;
            dtmNgaySinh.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtMaNv.Text = "";
            txtHoten.Text = "";
            dtmNgayLam.Text = "";
            cboGioiTinh.Text = "";
            txtDienThoai.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            dtmNgayLam.Text = "";
            dtmNgaySinh.Text = "";
        }

        private void uc_NhanVien_Load(object sender, EventArgs e)
        {

            EnableHome();
            TurnOffTextBox(false);
            HienThiDSNV();

            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.Columns[0].Width = 40;
            dgvNhanVien.Columns[2].Width = 150;
        }

        // Hiển Thị Danh Sách Nhân Viên
        private void HienThiDSNV()
        {
            int i = 0;
            dgvNhanVien.Rows.Clear();
            TurnOffTextBox(false);
            List<NhanVien> nvlist = nvbll.GetAllLISTEmployee();
            foreach (NhanVien nvs in nvlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhanVien);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nvs.MaNv;
                row.Cells[2].Value = nvs.Hoten;
                row.Cells[3].Value = nvs.NgaySinh;
                row.Cells[4].Value = nvs.GioTinh;
                row.Cells[5].Value = nvs.Sdt;
                row.Cells[6].Value = nvs.Mail;
                row.Cells[7].Value = nvs.DiaChi;
                row.Cells[8].Value = nvs.NgayLam;
                //row.Cells[0].Value = nvs.MaNv;
                //row.Cells[1].Value = nvs.Hoten;
                //row.Cells[2].Value = nvs.NgaySinh;
                //row.Cells[3].Value = nvs.GioTinh;
                //row.Cells[4].Value = nvs.Sdt;
                //row.Cells[5].Value = nvs.Mail;
                //row.Cells[6].Value = nvs.DiaChi;
                //row.Cells[7].Value = nvs.NgayLam;
                //row.Cells[8].Value = nvs.Image_01;
                dgvNhanVien.Rows.Add(row);
                ++i;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;

            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            TurnOffTextBox(true);
            RefreshTextBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            TurnOffTextBox(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultDelete == DialogResult.Yes)
            {
                nv.MaNv = int.Parse(txtMaNv.Text);

                if (txtMaNv.Text == null)
                {
                    DialogResult dialogResultCheck = MessageBox.Show("Không tồn tại nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResultCheck == DialogResult.OK)
                    {
                        HienThiDSNV();
                    }
                }

                bool result = nvbll.DeleteNhanVien(nv);

                if (result)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete successful!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        HienThiDSNV();
                    }
                    RefreshTextBox();
                    EnableHome();
                }
                else
                {
                    MessageBox.Show("Error Delete !");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;

            if (isCheck == 0)
            {
                try
                {
                    int n = 0;

                    string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();

                    if (txtHoten.Text == "")
                    {
                        check = false;
                        lbHoTen.Visible = true;
                        lbHoTen.Text = "Họ tên không được phép để trống!";
                    }
                    else
                    {

                        if (int.TryParse(txtHoten.Text, out n))
                        {
                            check = false;
                            lbHoTen.Visible = true;
                            lbHoTen.Text = "Họ tên phải là chữ!";
                        }
                        else
                        {
                            check = true;
                            nv.Hoten = txtHoten.Text;
                        }
                    }



                    if (cboGioiTinh.Text == "")
                    {
                        check = false;
                        lbGioiTinh.Visible = true;
                        lbGioiTinh.Text = "Giới tính không được phép để trống!";
                    }
                    else
                    {
                        check = true;
                        if (cboGioiTinh.SelectedIndex == 0)
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.SelectedIndex == 1)
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.SelectedIndex == 2)
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }

                    }


                    if (txtDienThoai.Text == "")
                    {
                        check = false;
                        lbDienThoai.Visible = true;
                        lbDienThoai.Text = "Điện thoại không được phép để trống !";
                    }
                    else
                    {
                        if (int.TryParse(txtDienThoai.Text, out n))
                        {
                            check = true;
                            nv.Sdt = txtDienThoai.Text;
                        }
                        else
                        {
                            check = false;
                            lbDienThoai.Visible = true;
                            lbDienThoai.Text = "Sdt phải là số!";
                        }
                    }

                    if (txtDiaChi.Text == "")
                    {
                        check = false;
                        lbDiaChi.Visible = true;
                        lbDiaChi.Text = "Địa chỉ không được để trống!";
                    }
                    else
                    {
                        if (int.TryParse(txtDiaChi.Text, out n))
                        {
                            check = false;
                            lbDiaChi.Visible = true;
                            lbDiaChi.Text = "Địa chỉ phải là số hoặc chữ hoặc cả hai!";
                        }
                        else
                        {
                            check = true;
                            nv.DiaChi = txtDiaChi.Text;
                        }
                    }

                    if (txtMail.Text == "")
                    {
                        check = false;
                        lbMail.Visible = true;
                        lbMail.Text = "Mail không được phép để trống!";
                    }
                    else
                    {
                        if (int.TryParse(txtMail.Text, out n))
                        {
                            check = false;
                            lbMail.Visible = true;
                            lbMail.Text = "Mail phải là sô và chữ!";
                        }
                        else
                        {
                            check = true;
                            nv.Mail = txtMail.Text;
                        }
                    }

                    nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());
                    nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                    if (check == true)
                    {
                        bool result = nvbll.InserNhanVien(nv);

                        if (result)
                        {
                            DialogResult dialogResult_01 = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK);
                            if (dialogResult_01 == DialogResult.OK)
                            {
                                EnableHome();
                                TurnOffTextBox(false);
                                RefreshTextBox();
                                HienThiDSNV();
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Insert !" + ex.Message);
                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    //string sCommobox = this.cboGioTinh.SelectedIndex.ToString();
                    int n = 0;


                    if (txtMaNv.Text == "")
                    {
                        check = false;
                        lbMaNv.Visible = true;
                        lbMaNv.Text = "*Bạn phải chọn Nhân Viên cần sửa trước!*";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMaNv.Text, out n))
                        {
                            check = true;
                            lbMaNv.Visible = false;
                            nv.MaNv = int.Parse(txtMaNv.Text);
                        }
                        else
                        {
                            check = false;
                            lbMaNv.Visible = true;
                            lbMaNv.Text = "* Mã Nhân viên phải là số!*";
                            return;
                        }
                    }

                    if (txtHoten.Text == "")
                    {
                        check = false;
                        lbHoTen.Visible = true;
                        lbHoTen.Text = "Họ tên không được phép để trống!";
                        return;
                    }
                    else
                    {

                        if (int.TryParse(txtHoten.Text, out n))
                        {
                            check = false;
                            lbHoTen.Visible = true;
                            lbHoTen.Text = "Họ tên phải là chữ!";
                            return;
                        }
                        else
                        {
                            check = true;
                            nv.Hoten = txtHoten.Text;
                        }
                    }



                    if (cboGioiTinh.Text == "")
                    {
                        check = false;
                        lbGioiTinh.Visible = true;
                        lbGioiTinh.Text = "Giới tính không được phép để trống!";
                        return;
                    }
                    else
                    {
                        check = true;
                        if (cboGioiTinh.SelectedIndex == -1)
                        {
                            //cboGioiTinh.Text = UserInfo.GioiTinh.ToString().Trim();
                            if (cboGioiTinh.Text.Trim() == "Nam")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                            else if (cboGioiTinh.Text.Trim() == "Nữ")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                            else if (cboGioiTinh.Text.Trim() == "Khác")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                        }
                        else
                        {
                            if (cboGioiTinh.Text.Trim() == "Nam")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                            else if (cboGioiTinh.Text.Trim() == "Nữ")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                            else if (cboGioiTinh.Text.Trim() == "Khác")
                            {
                                nv.GioTinh = cboGioiTinh.Text;
                            }
                        }

                    }


                    if (txtDienThoai.Text == "")
                    {
                        check = false;
                        lbDienThoai.Visible = true;
                        lbDienThoai.Text = "Điện thoại không được phép để trống !";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtDienThoai.Text, out n))
                        {
                            check = true;
                            nv.Sdt = txtDienThoai.Text;
                        }
                        else
                        {
                            check = false;
                            lbDienThoai.Visible = true;
                            lbDienThoai.Text = "Sdt phải là số!";
                            return;
                        }
                    }

                    if (txtDiaChi.Text == "")
                    {
                        check = false;
                        lbDiaChi.Visible = true;
                        lbDiaChi.Text = "Địa chỉ không được để trống!";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtDiaChi.Text, out n))
                        {
                            check = false;
                            lbDiaChi.Visible = true;
                            lbDiaChi.Text = "Địa chỉ phải là số hoặc chữ hoặc cả hai!";
                            return;
                        }
                        else
                        {
                            check = true;
                            nv.DiaChi = txtDiaChi.Text;
                        }
                    }

                    if (txtMail.Text == "")
                    {
                        check = false;
                        lbMail.Visible = true;
                        lbMail.Text = "Mail không được phép để trống!";
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtMail.Text, out n))
                        {
                            check = false;
                            lbMail.Visible = true;
                            lbMail.Text = "Mail phải là sô và chữ!";
                            return;
                        }
                        else
                        {
                            check = true;
                            nv.Mail = txtMail.Text;
                        }
                    }

                    nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());
                    nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                    if (check == true)
                    {
                        bool result = nvbll.UpdateNhanVien(nv);

                        if (result)
                        {
                            DialogResult dialogResult_01 = MessageBox.Show("Edit Success !", "Thông báo", MessageBoxButtons.OK);
                            if (dialogResult_01 == DialogResult.OK)
                            {
                                EnableHome();
                                btnDelete.Enabled = true;
                                TurnOffTextBox(false);
                                HienThiDSNV();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Edit !" + ex.Message);
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportNhanVien rpNhanVien = new frmReportNhanVien();
            rpNhanVien.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaNv.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            dtmNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dtmNgayLam.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
        }

        private void cboChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboChoose.SelectedIndex == -1)
            {
                return;
            }
            nv.Search = cboChoose.Text;
            cboSearch.Items.Clear();
            List<NhanVien> nvlist = nvbll.LocDSNhanVien(nv);
            if (cboChoose.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.MaNv);
                }
            }
            else if (cboChoose.Text == "Họ Tên")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Hoten);
                }
            }
            else if (cboChoose.Text == "Giới Tính")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.GioTinh);
                }
            }
            else if (cboChoose.Text == "Mail")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Mail);
                }
            }
            else if (cboChoose.Text == "Điện Thoại")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Sdt);
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
                HienThiDSNV();
                return;
            }
            nv.Search = cboSearch.Text;
            List<NhanVien> nvlist = nvbll.TimKiemNhanVien(nv);
            dgvNhanVien.Rows.Clear();
            foreach (NhanVien nvs in nvlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhanVien);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nvs.MaNv.ToString();
                row.Cells[2].Value = nvs.Hoten.ToString();
                row.Cells[3].Value = nvs.NgaySinh.ToString();
                row.Cells[4].Value = nvs.GioTinh.ToString();
                row.Cells[5].Value = nvs.Sdt.ToString();
                row.Cells[6].Value = nvs.Mail.ToString();
                row.Cells[7].Value = nvs.DiaChi.ToString();
                row.Cells[8].Value = nvs.NgayLam.ToString();

                dgvNhanVien.Rows.Add(row);
                ++i;
            }
        }
    }
}
