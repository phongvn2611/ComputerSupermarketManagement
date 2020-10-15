namespace QuanLySieuThiMayTinh
{
    partial class frmReportPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPhieuNhap));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsPhieuNhap = new QuanLySieuThiMayTinh.dtsPhieuNhap();
            this.PhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhieuNhapTableAdapter = new QuanLySieuThiMayTinh.dtsPhieuNhapTableAdapters.PhieuNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhieuNhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh.rptPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsPhieuNhap
            // 
            this.dtsPhieuNhap.DataSetName = "dtsPhieuNhap";
            this.dtsPhieuNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhieuNhapBindingSource
            // 
            this.PhieuNhapBindingSource.DataMember = "PhieuNhap";
            this.PhieuNhapBindingSource.DataSource = this.dtsPhieuNhap;
            // 
            // PhieuNhapTableAdapter
            // 
            this.PhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportPhieuNhap";
            this.Text = "In danh sách phiếu nhập";
            this.Load += new System.EventHandler(this.frmReportPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhieuNhapBindingSource;
        private dtsPhieuNhap dtsPhieuNhap;
        private dtsPhieuNhapTableAdapters.PhieuNhapTableAdapter PhieuNhapTableAdapter;
    }
}