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
using QuanLySieuThiMayTinh.BLL;

namespace QuanLySieuThiMayTinh
{
    public partial class frmMain : Form
    {
        public frmMain(string fullname, string namepermission)
        {
            InitializeComponent();
            lbFullName.Text = fullname;
            lbNamePermission.Text = namepermission;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhanVien.Height;
            panel_Slide.Top = btnNhanVien.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhanVien());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhaCungCap.Height;
            panel_Slide.Top = btnNhaCungCap.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhaCungCap());
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnNhaSanXuat.Height;
            panel_Slide.Top = btnNhaSanXuat.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhaSanXuat());
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnLoaiSanPham.Height;
            panel_Slide.Top = btnLoaiSanPham.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctLoaiSanPham());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnSanPham.Height;
            panel_Slide.Top = btnSanPham.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctSanPham());
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnDonDatHang.Height;
            panel_Slide.Top = btnDonDatHang.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctDonDatHang());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuNhap.Height;
            panel_Slide.Top = btnPhieuNhap.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctPhieuNhap());
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuXuat.Height;
            panel_Slide.Top = btnPhieuXuat.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctPhieuXuat());
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Visible = false;
            if (UserInfo.permission == "NVBH")
            {
                phânQuyềnToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                btnNhanVien.Visible = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn bạn có muốn thoát?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctThongKeDonHang());
        }

        private void thốngKêPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctThongKePhieuNhap());
        }

        private void thốngKêHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctThongKePhieuXuat());
        }

        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctThongKeTonKho());
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frmPhanQuyen = new frmPhanQuyen();
            frmPhanQuyen.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel_Slide.Height = btnPhieuNhap.Height;
            panel_Slide.Top = btnPhieuNhap.Bottom;

            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhanVien());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhaCungCap());
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctNhaSanXuat());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctLoaiSanPham());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctDonDatHang());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctDonDatHang());
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctPhieuNhap());
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctPhieuXuat());
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctThongTin());
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uctHuongDan());
        }
    }
}
