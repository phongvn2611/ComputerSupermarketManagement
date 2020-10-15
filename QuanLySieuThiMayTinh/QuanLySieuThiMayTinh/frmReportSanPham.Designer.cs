namespace QuanLySieuThiMayTinh
{
    partial class frmReportSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportSanPham));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsSanPham = new QuanLySieuThiMayTinh.dtsSanPham();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamTableAdapter = new QuanLySieuThiMayTinh.dtsSanPhamTableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh.rptSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsSanPham
            // 
            this.dtsSanPham.DataSetName = "dtsSanPham";
            this.dtsSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.dtsSanPham;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportSanPham";
            this.Text = "In danh sách sản phẩm";
            this.Load += new System.EventHandler(this.frmReportSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private dtsSanPham dtsSanPham;
        private dtsSanPhamTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
    }
}