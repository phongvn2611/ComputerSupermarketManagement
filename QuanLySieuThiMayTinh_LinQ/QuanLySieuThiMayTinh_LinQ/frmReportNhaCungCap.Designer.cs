namespace QuanLySieuThiMayTinh_LinQ
{
    partial class frmReportNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportNhaCungCap));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsNhaCungCap = new QuanLySieuThiMayTinh_LinQ.dtsNhaCungCap();
            this.NHACCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHACCTableAdapter = new QuanLySieuThiMayTinh_LinQ.dtsNhaCungCapTableAdapters.NHACCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHACCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh_LinQ.rptNhaCungCap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsNhaCungCap
            // 
            this.dtsNhaCungCap.DataSetName = "dtsNhaCungCap";
            this.dtsNhaCungCap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHACCBindingSource
            // 
            this.NHACCBindingSource.DataMember = "NHACC";
            this.NHACCBindingSource.DataSource = this.dtsNhaCungCap;
            // 
            // NHACCTableAdapter
            // 
            this.NHACCTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportNhaCungCap";
            this.Text = "In nhà cung cấp";
            this.Load += new System.EventHandler(this.frmReportNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHACCBindingSource;
        private dtsNhaCungCap dtsNhaCungCap;
        private dtsNhaCungCapTableAdapters.NHACCTableAdapter NHACCTableAdapter;
    }
}