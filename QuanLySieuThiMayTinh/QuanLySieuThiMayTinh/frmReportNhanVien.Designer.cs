namespace QuanLySieuThiMayTinh
{
    partial class frmReportNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportNhanVien));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsNhanVien = new QuanLySieuThiMayTinh.dtsNhanVien();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QuanLySieuThiMayTinh.dtsNhanVienTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh.rptNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsNhanVien
            // 
            this.dtsNhanVien.DataSetName = "dtsNhanVien";
            this.dtsNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.dtsNhanVien;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportNhanVien";
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.frmReportNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private dtsNhanVien dtsNhanVien;
        private dtsNhanVienTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
    }
}