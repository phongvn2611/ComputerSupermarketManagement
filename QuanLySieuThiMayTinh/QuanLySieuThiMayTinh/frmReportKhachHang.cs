using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMayTinh
{
    public partial class frmReportKhachHang : Form
    {
        public frmReportKhachHang()
        {
            InitializeComponent();
        }

        private void frmReportKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsKhachHang.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.dtsKhachHang.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
