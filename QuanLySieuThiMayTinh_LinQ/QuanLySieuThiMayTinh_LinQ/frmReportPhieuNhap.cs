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
    public partial class frmReportPhieuNhap : Form
    {
        public frmReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmReportPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsPhieuNhap.PhieuNhap' table. You can move, or remove it, as needed.
            this.PhieuNhapTableAdapter.Fill(this.dtsPhieuNhap.PhieuNhap);

            this.reportViewer1.RefreshReport();
        }
    }
}
