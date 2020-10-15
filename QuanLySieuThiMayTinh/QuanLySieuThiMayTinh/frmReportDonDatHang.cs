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
    public partial class frmReportDonDatHang : Form
    {
        public frmReportDonDatHang()
        {
            InitializeComponent();
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsDonDatHang.DonDatHang' table. You can move, or remove it, as needed.
            this.DonDatHangTableAdapter.Fill(this.dtsDonDatHang.DonDatHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
