using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMayTinh_LinQ
{
    public partial class frmReportSanPham : Form
    {
        public frmReportSanPham()
        {
            InitializeComponent();
        }

        private void frmReportSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsSanPham.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.dtsSanPham.SanPham);

            this.reportViewer1.RefreshReport();
        }
    }
}
