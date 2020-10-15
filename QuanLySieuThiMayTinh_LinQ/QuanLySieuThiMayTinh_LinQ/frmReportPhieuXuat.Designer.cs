namespace QuanLySieuThiMayTinh_LinQ
{
    partial class frmReportPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPhieuXuat));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsPhieuXuat = new QuanLySieuThiMayTinh_LinQ.dtsPhieuXuat();
            this.PhieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhieuXuatTableAdapter = new QuanLySieuThiMayTinh_LinQ.dtsPhieuXuatTableAdapters.PhieuXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhieuXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh_LinQ.rptPhieuXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsPhieuXuat
            // 
            this.dtsPhieuXuat.DataSetName = "dtsPhieuXuat";
            this.dtsPhieuXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuXuatBindingSource
            // 
            this.PhieuXuatBindingSource.DataMember = "PhieuXuat";
            this.PhieuXuatBindingSource.DataSource = this.dtsPhieuXuat;
            // 
            // PhieuXuatTableAdapter
            // 
            this.PhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPhieuXuat";
            this.Text = "In phiếu xuất";
            this.Load += new System.EventHandler(this.frmReportPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhieuXuatBindingSource;
        private dtsPhieuXuat dtsPhieuXuat;
        private dtsPhieuXuatTableAdapters.PhieuXuatTableAdapter PhieuXuatTableAdapter;
    }
}