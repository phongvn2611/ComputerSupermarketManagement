namespace QuanLySieuThiMayTinh
{
    partial class uctDonDatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctDonDatHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboChoose = new System.Windows.Forms.ComboBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDonDatHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboTenSp = new System.Windows.Forms.ComboBox();
            this.cboTenCc = new System.Windows.Forms.ComboBox();
            this.cboTenNv = new System.Windows.Forms.ComboBox();
            this.cboMaSp = new System.Windows.Forms.ComboBox();
            this.cboMaCc = new System.Windows.Forms.ComboBox();
            this.cboMaNv = new System.Windows.Forms.ComboBox();
            this.lbMaCc = new System.Windows.Forms.Label();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.lbMaNv = new System.Windows.Forms.Label();
            this.lbSld = new System.Windows.Forms.Label();
            this.lbMaSp = new System.Windows.Forms.Label();
            this.lbMaDh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtSld = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaDh = new System.Windows.Forms.TextBox();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 687);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1094, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 687);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboChoose);
            this.panel3.Controls.Add(this.cboSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 87);
            this.panel3.TabIndex = 0;
            // 
            // cboChoose
            // 
            this.cboChoose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChoose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChoose.FormattingEnabled = true;
            this.cboChoose.Items.AddRange(new object[] {
            "Mã Đơn Hàng",
            "Mã Nhân Viên",
            "Mã Sản Phẩm",
            "Mã Cung Cấp",
            "Số Lượng Đặt"});
            this.cboChoose.Location = new System.Drawing.Point(727, 30);
            this.cboChoose.Name = "cboChoose";
            this.cboChoose.Size = new System.Drawing.Size(224, 27);
            this.cboChoose.TabIndex = 1;
            this.cboChoose.SelectedIndexChanged += new System.EventHandler(this.cboChoose_SelectedIndexChanged);
            // 
            // cboSearch
            // 
            this.cboSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(125, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(596, 27);
            this.cboSearch.TabIndex = 0;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDonDatHang);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 364);
            this.panel4.TabIndex = 0;
            // 
            // dgvDonDatHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDonDatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonDatHang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDonDatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonDatHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonDatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dgvDonDatHang.DoubleBuffered = true;
            this.dgvDonDatHang.EnableHeadersVisualStyles = false;
            this.dgvDonDatHang.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvDonDatHang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDonDatHang.Location = new System.Drawing.Point(0, 0);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonDatHang.RowHeadersWidth = 51;
            this.dgvDonDatHang.Size = new System.Drawing.Size(1084, 364);
            this.dgvDonDatHang.TabIndex = 0;
            this.dgvDonDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDatHang_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Đơn Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Cung Cấp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Sản Phẩm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng Đặt";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày Đặt";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboTenSp);
            this.panel5.Controls.Add(this.cboTenCc);
            this.panel5.Controls.Add(this.cboTenNv);
            this.panel5.Controls.Add(this.cboMaSp);
            this.panel5.Controls.Add(this.cboMaCc);
            this.panel5.Controls.Add(this.cboMaNv);
            this.panel5.Controls.Add(this.lbMaCc);
            this.panel5.Controls.Add(this.lbNgayDat);
            this.panel5.Controls.Add(this.lbMaNv);
            this.panel5.Controls.Add(this.lbSld);
            this.panel5.Controls.Add(this.lbMaSp);
            this.panel5.Controls.Add(this.lbMaDh);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtNgayDat);
            this.panel5.Controls.Add(this.txtSld);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.txtMaDh);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.btnInsert);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 451);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1084, 236);
            this.panel5.TabIndex = 0;
            // 
            // cboTenSp
            // 
            this.cboTenSp.DisplayMember = "TENSP";
            this.cboTenSp.FormattingEnabled = true;
            this.cboTenSp.Location = new System.Drawing.Point(857, 15);
            this.cboTenSp.Name = "cboTenSp";
            this.cboTenSp.Size = new System.Drawing.Size(223, 27);
            this.cboTenSp.TabIndex = 7;
            this.cboTenSp.ValueMember = "TENSP";
            // 
            // cboTenCc
            // 
            this.cboTenCc.DisplayMember = "TENCC";
            this.cboTenCc.FormattingEnabled = true;
            this.cboTenCc.Location = new System.Drawing.Point(252, 107);
            this.cboTenCc.Name = "cboTenCc";
            this.cboTenCc.Size = new System.Drawing.Size(223, 27);
            this.cboTenCc.TabIndex = 7;
            this.cboTenCc.ValueMember = "TENCC";
            // 
            // cboTenNv
            // 
            this.cboTenNv.FormattingEnabled = true;
            this.cboTenNv.Location = new System.Drawing.Point(252, 61);
            this.cboTenNv.Name = "cboTenNv";
            this.cboTenNv.Size = new System.Drawing.Size(223, 27);
            this.cboTenNv.TabIndex = 7;
            // 
            // cboMaSp
            // 
            this.cboMaSp.DisplayMember = "MASP";
            this.cboMaSp.FormattingEnabled = true;
            this.cboMaSp.Location = new System.Drawing.Point(730, 15);
            this.cboMaSp.Name = "cboMaSp";
            this.cboMaSp.Size = new System.Drawing.Size(121, 27);
            this.cboMaSp.TabIndex = 6;
            this.cboMaSp.ValueMember = "MASP";
            this.cboMaSp.SelectedIndexChanged += new System.EventHandler(this.cboMaSp_SelectedIndexChanged);
            // 
            // cboMaCc
            // 
            this.cboMaCc.DisplayMember = "MACC";
            this.cboMaCc.FormattingEnabled = true;
            this.cboMaCc.Location = new System.Drawing.Point(125, 107);
            this.cboMaCc.Name = "cboMaCc";
            this.cboMaCc.Size = new System.Drawing.Size(121, 27);
            this.cboMaCc.TabIndex = 6;
            this.cboMaCc.ValueMember = "MACC";
            this.cboMaCc.SelectedIndexChanged += new System.EventHandler(this.cboMaCc_SelectedIndexChanged);
            // 
            // cboMaNv
            // 
            this.cboMaNv.DisplayMember = "MANV";
            this.cboMaNv.FormattingEnabled = true;
            this.cboMaNv.Location = new System.Drawing.Point(125, 61);
            this.cboMaNv.Name = "cboMaNv";
            this.cboMaNv.Size = new System.Drawing.Size(121, 27);
            this.cboMaNv.TabIndex = 6;
            this.cboMaNv.ValueMember = "MANV";
            this.cboMaNv.SelectedIndexChanged += new System.EventHandler(this.cboMaNv_SelectedIndexChanged);
            // 
            // lbMaCc
            // 
            this.lbMaCc.AutoSize = true;
            this.lbMaCc.ForeColor = System.Drawing.Color.Red;
            this.lbMaCc.Location = new System.Drawing.Point(122, 134);
            this.lbMaCc.Name = "lbMaCc";
            this.lbMaCc.Size = new System.Drawing.Size(53, 20);
            this.lbMaCc.TabIndex = 5;
            this.lbMaCc.Text = "label7";
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.AutoSize = true;
            this.lbNgayDat.ForeColor = System.Drawing.Color.Red;
            this.lbNgayDat.Location = new System.Drawing.Point(727, 134);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(53, 20);
            this.lbNgayDat.TabIndex = 4;
            this.lbNgayDat.Text = "label4";
            this.lbNgayDat.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbMaNv
            // 
            this.lbMaNv.AutoSize = true;
            this.lbMaNv.ForeColor = System.Drawing.Color.Red;
            this.lbMaNv.Location = new System.Drawing.Point(122, 88);
            this.lbMaNv.Name = "lbMaNv";
            this.lbMaNv.Size = new System.Drawing.Size(53, 20);
            this.lbMaNv.TabIndex = 5;
            this.lbMaNv.Text = "label7";
            // 
            // lbSld
            // 
            this.lbSld.AutoSize = true;
            this.lbSld.ForeColor = System.Drawing.Color.Red;
            this.lbSld.Location = new System.Drawing.Point(727, 88);
            this.lbSld.Name = "lbSld";
            this.lbSld.Size = new System.Drawing.Size(53, 20);
            this.lbSld.TabIndex = 4;
            this.lbSld.Text = "label4";
            this.lbSld.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbMaSp
            // 
            this.lbMaSp.AutoSize = true;
            this.lbMaSp.ForeColor = System.Drawing.Color.Red;
            this.lbMaSp.Location = new System.Drawing.Point(727, 42);
            this.lbMaSp.Name = "lbMaSp";
            this.lbMaSp.Size = new System.Drawing.Size(53, 20);
            this.lbMaSp.TabIndex = 4;
            this.lbMaSp.Text = "label4";
            this.lbMaSp.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbMaDh
            // 
            this.lbMaDh.AutoSize = true;
            this.lbMaDh.ForeColor = System.Drawing.Color.Red;
            this.lbMaDh.Location = new System.Drawing.Point(122, 42);
            this.lbMaDh.Name = "lbMaDh";
            this.lbMaDh.Size = new System.Drawing.Size(53, 20);
            this.lbMaDh.TabIndex = 4;
            this.lbMaDh.Text = "label4";
            this.lbMaDh.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số Lượng Đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 40D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(908, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(175, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Cung Cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đơn Hàng:";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(730, 107);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(315, 27);
            this.txtNgayDat.TabIndex = 0;
            // 
            // txtSld
            // 
            this.txtSld.Location = new System.Drawing.Point(730, 61);
            this.txtSld.Name = "txtSld";
            this.txtSld.Size = new System.Drawing.Size(121, 27);
            this.txtSld.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 40D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(365, 195);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(175, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMaDh
            // 
            this.txtMaDh.Location = new System.Drawing.Point(125, 15);
            this.txtMaDh.Name = "txtMaDh";
            this.txtMaDh.Size = new System.Drawing.Size(350, 27);
            this.txtMaDh.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 40D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(727, 195);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(175, 39);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "Insert";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInsert.Iconimage")));
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 40D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(3, 195);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(175, 39);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.Transparent;
            this.btnInsert.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 40D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(546, 195);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(175, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 40D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(184, 195);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(175, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // uctDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uctDonDatHang";
            this.Size = new System.Drawing.Size(1104, 687);
            this.Load += new System.EventHandler(this.uc_DonDatHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboChoose;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label lbMaNv;
        private System.Windows.Forms.Label lbMaDh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtSld;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.TextBox txtMaDh;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.ComboBox cboTenSp;
        private System.Windows.Forms.ComboBox cboTenCc;
        private System.Windows.Forms.ComboBox cboTenNv;
        private System.Windows.Forms.ComboBox cboMaSp;
        private System.Windows.Forms.ComboBox cboMaCc;
        private System.Windows.Forms.ComboBox cboMaNv;
        private System.Windows.Forms.Label lbMaCc;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.Label lbSld;
        private System.Windows.Forms.Label lbMaSp;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDonDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
