namespace QuanLySieuThiMayTinh_LinQ
{
    partial class frmReportNhaSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportNhaSanXuat));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsNhaSanXuat = new QuanLySieuThiMayTinh_LinQ.dtsNhaSanXuat();
            this.NHASXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHASXTableAdapter = new QuanLySieuThiMayTinh_LinQ.dtsNhaSanXuatTableAdapters.NHASXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhaSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHASXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh_LinQ.rptNhaSanXuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsNhaSanXuat
            // 
            this.dtsNhaSanXuat.DataSetName = "dtsNhaSanXuat";
            this.dtsNhaSanXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHASXBindingSource
            // 
            this.NHASXBindingSource.DataMember = "NHASX";
            this.NHASXBindingSource.DataSource = this.dtsNhaSanXuat;
            // 
            // NHASXTableAdapter
            // 
            this.NHASXTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportNhaSanXuat";
            this.Text = "In nhà sản xuất";
            this.Load += new System.EventHandler(this.frmReportNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsNhaSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASXBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHASXBindingSource;
        private dtsNhaSanXuat dtsNhaSanXuat;
        private dtsNhaSanXuatTableAdapters.NHASXTableAdapter NHASXTableAdapter;
    }
}