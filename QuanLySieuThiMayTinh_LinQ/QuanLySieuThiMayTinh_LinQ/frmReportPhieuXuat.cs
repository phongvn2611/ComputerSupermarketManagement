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
    public partial class frmReportPhieuXuat : Form
    {
        public frmReportPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmReportPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsPhieuXuat.PhieuXuat' table. You can move, or remove it, as needed.
            this.PhieuXuatTableAdapter.Fill(this.dtsPhieuXuat.PhieuXuat);

            this.reportViewer1.RefreshReport();
        }
    }
}
