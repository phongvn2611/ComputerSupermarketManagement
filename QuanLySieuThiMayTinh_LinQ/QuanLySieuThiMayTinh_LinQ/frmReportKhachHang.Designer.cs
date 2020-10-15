namespace QuanLySieuThiMayTinh_LinQ
{
    partial class frmReportKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportKhachHang));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsKhachHang = new QuanLySieuThiMayTinh_LinQ.dtsKhachHang();
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHACHHANGTableAdapter = new QuanLySieuThiMayTinh_LinQ.dtsKhachHangTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh_LinQ.rptKhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsKhachHang
            // 
            this.dtsKhachHang.DataSetName = "dtsKhachHang";
            this.dtsKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.dtsKhachHang;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportKhachHang";
            this.Text = "In khách hàng";
            this.Load += new System.EventHandler(this.frmReportKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private dtsKhachHang dtsKhachHang;
        private dtsKhachHangTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
    }
}