﻿namespace QuanLySieuThiMayTinh
{
    partial class frmReportDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDonDatHang));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsDonDatHang = new QuanLySieuThiMayTinh.dtsDonDatHang();
            this.DonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DonDatHangTableAdapter = new QuanLySieuThiMayTinh.dtsDonDatHangTableAdapters.DonDatHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonDatHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DonDatHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThiMayTinh.rptDonDatHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsDonDatHang
            // 
            this.dtsDonDatHang.DataSetName = "dtsDonDatHang";
            this.dtsDonDatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DonDatHangBindingSource
            // 
            this.DonDatHangBindingSource.DataMember = "DonDatHang";
            this.DonDatHangBindingSource.DataSource = this.dtsDonDatHang;
            // 
            // DonDatHangTableAdapter
            // 
            this.DonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportDonDatHang";
            this.Text = "In danh sách đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonDatHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DonDatHangBindingSource;
        private dtsDonDatHang dtsDonDatHang;
        private dtsDonDatHangTableAdapters.DonDatHangTableAdapter DonDatHangTableAdapter;
    }
}