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
    public partial class frmReportLoaiSanPham : Form
    {
        public frmReportLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmReportLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsLoaiSanPham.LOAISP' table. You can move, or remove it, as needed.
            this.LOAISPTableAdapter.Fill(this.dtsLoaiSanPham.LOAISP);

            this.reportViewer1.RefreshReport();
        }
    }
}
