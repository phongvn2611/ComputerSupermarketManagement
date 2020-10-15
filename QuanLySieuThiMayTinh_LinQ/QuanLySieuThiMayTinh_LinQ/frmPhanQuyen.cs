using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiMayTinh.DTO;
using QuanLySieuThiMayTinh.BLL;
using System.Windows.Forms;

namespace QuanLySieuThiMayTinh
{
    public partial class frmPhanQuyen : Form
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan();
            HienThiComboBoxMaQh();
        }

        // Hien thi tai khoan
        private void HienThiDanhSachTaiKhoan()
        {
            int i = 0;
            List<TaiKhoan> tklist = tkbll.ShowTaiKhoan();
            foreach (TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDsTaiKhoanNv);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.Id;
                row.Cells[2].Value = tks.Password;
                row.Cells[3].Value = tks.Fullname;
                row.Cells[4].Value = false;
                row.Cells[5].Value = false;
                row.Cells[6].Value = false;

                if (tks.Permission.ToString().Trim() == "QLBH")
                {
                    row.Cells[4].Value = true;
                }
                else if (tks.Permission.ToString().Trim() == "NVBH")
                {
                    row.Cells[5].Value = true;
                }
                else if (tks.Permission.ToString().Trim() == "NVNEW")
                {
                    row.Cells[6].Value = true;
                }

                dgvDsTaiKhoanNv.Rows.Add(row);
                ++i;
            }

            //
            txtFullname.Enabled = false;
            txtPermission.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            //
            dgvDsTaiKhoanNv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsTaiKhoanNv.AllowUserToAddRows = false;

            //
            dgvDsTaiKhoanTheoMaQh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsTaiKhoanTheoMaQh.AllowUserToAddRows = false;

            //
            dgvDsTaiKhoanNv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsTaiKhoanTheoMaQh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //
            dgvDsTaiKhoanNv.Columns[0].Width = 40;
            dgvDsTaiKhoanNv.Columns[3].Width = 250;

            dgvDsTaiKhoanTheoMaQh.Columns[0].Width = 90;
            dgvDsTaiKhoanTheoMaQh.Columns[1].Width = 100;
            dgvDsTaiKhoanTheoMaQh.Columns[2].Width = 170;
        }



        // Hien Thi ComboxBox MAQH
        private void HienThiComboBoxMaQh()
        {
            cboMaQh_ThongTinNv.DataSource = tkbll.LoadComboBoxMAQH();
            cboMaQh_DsNv.Items.Add("QLBH");
            cboMaQh_DsNv.Items.Add("NVBH");
            cboMaQh_DsNv.Items.Add("NVNEW");

        }

        // Loc Thong tin tai khoan theo MAQH _ 1
        private void LocThongTinTaiKhoanTheoMaQh_1(TaiKhoan permission)
        {
            int i = 0;
            dgvDsTaiKhoanNv.Rows.Clear();
            List<TaiKhoan> tklist = tkbll.FilterEmployeeFlowIdPermission(permission);
            foreach (TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDsTaiKhoanNv);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.Id;
                row.Cells[2].Value = tks.Password;
                row.Cells[3].Value = tks.Fullname;
                string nps = tks.Permission.ToString().Trim();
                if (nps != null)
                {
                    if (nps == "QLBH")
                    {
                        row.Cells[4].Value = true;
                    }
                    else if (nps == "NVBH")
                    {
                        row.Cells[5].Value = true;
                    }
                    else if (nps == "NVNEW")
                    {
                        row.Cells[6].Value = true;
                    }

                }
                else
                {
                    row.Cells[4].Value = false;
                    row.Cells[5].Value = false;
                    row.Cells[6].Value = false;
                }

                dgvDsTaiKhoanNv.Rows.Add(row);
                ++i;
            }
        }


        // Loc Thong tin tai khoan theo MAQH _ 2
        private void LocThongTinTaiKhoanTheoMaQh_2(TaiKhoan permission)
        {
            dgvDsTaiKhoanTheoMaQh.Rows.Clear();
            List<TaiKhoan> tklist = tkbll.FilterEmployeeFlowIdPermission(permission);
            foreach (TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDsTaiKhoanTheoMaQh);
                row.Cells[0].Value = tks.Id;
                row.Cells[1].Value = tks.Password;
                row.Cells[2].Value = tks.Fullname;
                row.Cells[3].Value = tks.Namepermission;

                dgvDsTaiKhoanTheoMaQh.Rows.Add(row);
            }
        }

        private void dgvDS_QLBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            txtUsername.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[1].Value.ToString();
            txtFullname.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[2].Value.ToString();
            txtPermission.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvDsTaiKhoanNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan tks = new TaiKhoan();
            if (e.ColumnIndex == 4)
            {
                string Id = dgvDsTaiKhoanNv.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "QLBH";
                tks.Permission = "QLBH";
                cboMaQh_ThongTinNv.Text = "QLBH";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDsTaiKhoanNv.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }
            }
            if (e.ColumnIndex == 5)
            {
                string Id = dgvDsTaiKhoanNv.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "NVBH";
                tks.Permission = "NVBH";
                cboMaQh_ThongTinNv.Text = "NVBH";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDsTaiKhoanNv.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }

            }
            if (e.ColumnIndex == 6)
            {
                string Id = dgvDsTaiKhoanNv.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "NVNEW";
                tks.Permission = "NVNEW";
                cboMaQh_ThongTinNv.Text = "NVNEW";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDsTaiKhoanNv.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }

            }
        }

        private void dgvDsTaiKhoanTheoMaQh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            txtUsername.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[1].Value.ToString();
            txtFullname.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[2].Value.ToString();
            txtPermission.Text = dgvDsTaiKhoanTheoMaQh.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tk.Id = int.Parse(txtUsername.Text);
            tk.Password = int.Parse(txtPassword.Text);
            bool result = tkbll.UpdateTaiKhoan(tk);
            if (result)
            {
                dgvDsTaiKhoanNv.Rows.Clear();
                dgvDsTaiKhoanTheoMaQh.Rows.Clear();
                HienThiDanhSachTaiKhoan();
                LocThongTinTaiKhoanTheoMaQh_2(tk);
            }
        }

        private void cboMaQh_DsNv_TextChanged(object sender, EventArgs e)
        {
            if (cboMaQh_DsNv.SelectedIndex == -1)
            {
                dgvDsTaiKhoanNv.Rows.Clear();
                HienThiDanhSachTaiKhoan();
                return;
            }
            tk.Permission = cboMaQh_DsNv.Text;
            LocThongTinTaiKhoanTheoMaQh_1(tk);
        }

        private void cboMaQh_ThongTinNv_TextChanged(object sender, EventArgs e)
        {
            if (cboMaQh_ThongTinNv.SelectedIndex == -1)
            {
                //dgvDS_QLBH.Rows.Clear();
                //dgvDS_QLBH.Rows.Clear();
                LocThongTinTaiKhoanTheoMaQh_2(tk);
                return;
            }

            dgvDsTaiKhoanTheoMaQh.Rows.Clear();
            tk.Permission = cboMaQh_ThongTinNv.Text;
            LocThongTinTaiKhoanTheoMaQh_2(tk);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
        }
    }
}
