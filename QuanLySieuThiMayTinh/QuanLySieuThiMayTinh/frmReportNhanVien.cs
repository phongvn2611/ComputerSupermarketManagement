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
    public partial class frmReportNhanVien : Form
    {
        public frmReportNhanVien()
        {
            InitializeComponent();
        }

        private void frmReportNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsNhanVien.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.dtsNhanVien.NHANVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}
