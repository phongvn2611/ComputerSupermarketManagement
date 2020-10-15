namespace QuanLySieuThiMayTinh
{
    partial class uctPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboChoose = new System.Windows.Forms.ComboBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPhieuNhap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboMaDh = new System.Windows.Forms.ComboBox();
            this.dtmNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lbMaDh = new System.Windows.Forms.Label();
            this.lbMaNv = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSln = new System.Windows.Forms.Label();
            this.lbMaSp = new System.Windows.Forms.Label();
            this.lbMaPn = new System.Windows.Forms.Label();
            this.cboTenSp = new System.Windows.Forms.ComboBox();
            this.cboGiaThanh = new System.Windows.Forms.ComboBox();
            this.cboSld = new System.Windows.Forms.ComboBox();
            this.cboMaSp = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSlcn = new System.Windows.Forms.TextBox();
            this.txtSln = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.txtMaPn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
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
            "Mã Phiếu Nhập",
            "Mã Nhân Viên",
            "Mã Đơn Hàng",
            "Mã Sản Phẩm"});
            this.cboChoose.Location = new System.Drawing.Point(724, 31);
            this.cboChoose.Name = "cboChoose";
            this.cboChoose.Size = new System.Drawing.Size(227, 27);
            this.cboChoose.TabIndex = 5;
            this.cboChoose.SelectedIndexChanged += new System.EventHandler(this.cboChoose_SelectedIndexChanged);
            // 
            // cboSearch
            // 
            this.cboSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(104, 31);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(614, 27);
            this.cboSearch.TabIndex = 4;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPhieuNhap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 340);
            this.panel4.TabIndex = 0;
            // 
            // dgvPhieuNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dgvPhieuNhap.DoubleBuffered = true;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvPhieuNhap.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1084, 340);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "STT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu Nhập";
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
            this.Column3.HeaderText = "Mã Đơn Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Đặt Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã Sản Phẩm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số lượng Nhập";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đơn Giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboMaDh);
            this.panel5.Controls.Add(this.dtmNgayNhap);
            this.panel5.Controls.Add(this.lbMaDh);
            this.panel5.Controls.Add(this.lbMaNv);
            this.panel5.Controls.Add(this.lbNgayNhap);
            this.panel5.Controls.Add(this.lbDonGia);
            this.panel5.Controls.Add(this.lbSln);
            this.panel5.Controls.Add(this.lbMaSp);
            this.panel5.Controls.Add(this.lbMaPn);
            this.panel5.Controls.Add(this.cboTenSp);
            this.panel5.Controls.Add(this.cboGiaThanh);
            this.panel5.Controls.Add(this.cboSld);
            this.panel5.Controls.Add(this.cboMaSp);
            this.panel5.Controls.Add(this.txtDonGia);
            this.panel5.Controls.Add(this.txtSlcn);
            this.panel5.Controls.Add(this.txtSln);
            this.panel5.Controls.Add(this.txtMaNv);
            this.panel5.Controls.Add(this.txtMaPn);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.btnInsert);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1084, 260);
            this.panel5.TabIndex = 0;
            // 
            // cboMaDh
            // 
            this.cboMaDh.DisplayMember = "MADH";
            this.cboMaDh.FormattingEnabled = true;
            this.cboMaDh.Location = new System.Drawing.Point(107, 108);
            this.cboMaDh.Name = "cboMaDh";
            this.cboMaDh.Size = new System.Drawing.Size(197, 27);
            this.cboMaDh.TabIndex = 10;
            this.cboMaDh.ValueMember = "MADH";
            this.cboMaDh.SelectedIndexChanged += new System.EventHandler(this.cboMaDh_SelectedIndexChanged);
            // 
            // dtmNgayNhap
            // 
            this.dtmNgayNhap.Location = new System.Drawing.Point(104, 152);
            this.dtmNgayNhap.Name = "dtmNgayNhap";
            this.dtmNgayNhap.Size = new System.Drawing.Size(200, 27);
            this.dtmNgayNhap.TabIndex = 9;
            // 
            // lbMaDh
            // 
            this.lbMaDh.AutoSize = true;
            this.lbMaDh.ForeColor = System.Drawing.Color.Red;
            this.lbMaDh.Location = new System.Drawing.Point(104, 134);
            this.lbMaDh.Name = "lbMaDh";
            this.lbMaDh.Size = new System.Drawing.Size(62, 20);
            this.lbMaDh.TabIndex = 8;
            this.lbMaDh.Text = "label12";
            // 
            // lbMaNv
            // 
            this.lbMaNv.AutoSize = true;
            this.lbMaNv.ForeColor = System.Drawing.Color.Red;
            this.lbMaNv.Location = new System.Drawing.Point(104, 90);
            this.lbMaNv.Name = "lbMaNv";
            this.lbMaNv.Size = new System.Drawing.Size(62, 20);
            this.lbMaNv.TabIndex = 8;
            this.lbMaNv.Text = "label12";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.ForeColor = System.Drawing.Color.Red;
            this.lbNgayNhap.Location = new System.Drawing.Point(101, 178);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(62, 20);
            this.lbNgayNhap.TabIndex = 7;
            this.lbNgayNhap.Text = "label11";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbDonGia.Location = new System.Drawing.Point(724, 134);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(62, 20);
            this.lbDonGia.TabIndex = 7;
            this.lbDonGia.Text = "label11";
            // 
            // lbSln
            // 
            this.lbSln.AutoSize = true;
            this.lbSln.ForeColor = System.Drawing.Color.Red;
            this.lbSln.Location = new System.Drawing.Point(724, 90);
            this.lbSln.Name = "lbSln";
            this.lbSln.Size = new System.Drawing.Size(62, 20);
            this.lbSln.TabIndex = 7;
            this.lbSln.Text = "label11";
            // 
            // lbMaSp
            // 
            this.lbMaSp.AutoSize = true;
            this.lbMaSp.ForeColor = System.Drawing.Color.Red;
            this.lbMaSp.Location = new System.Drawing.Point(721, 46);
            this.lbMaSp.Name = "lbMaSp";
            this.lbMaSp.Size = new System.Drawing.Size(62, 20);
            this.lbMaSp.TabIndex = 7;
            this.lbMaSp.Text = "label11";
            // 
            // lbMaPn
            // 
            this.lbMaPn.AutoSize = true;
            this.lbMaPn.ForeColor = System.Drawing.Color.Red;
            this.lbMaPn.Location = new System.Drawing.Point(104, 46);
            this.lbMaPn.Name = "lbMaPn";
            this.lbMaPn.Size = new System.Drawing.Size(62, 20);
            this.lbMaPn.TabIndex = 7;
            this.lbMaPn.Text = "label11";
            // 
            // cboTenSp
            // 
            this.cboTenSp.DisplayMember = "TENSP";
            this.cboTenSp.FormattingEnabled = true;
            this.cboTenSp.Location = new System.Drawing.Point(869, 19);
            this.cboTenSp.Name = "cboTenSp";
            this.cboTenSp.Size = new System.Drawing.Size(209, 27);
            this.cboTenSp.TabIndex = 6;
            this.cboTenSp.ValueMember = "TENSP";
            // 
            // cboGiaThanh
            // 
            this.cboGiaThanh.DisplayMember = "GIATHANH";
            this.cboGiaThanh.FormattingEnabled = true;
            this.cboGiaThanh.Location = new System.Drawing.Point(939, 152);
            this.cboGiaThanh.Name = "cboGiaThanh";
            this.cboGiaThanh.Size = new System.Drawing.Size(139, 27);
            this.cboGiaThanh.TabIndex = 5;
            this.cboGiaThanh.ValueMember = "GIATHANH";
            // 
            // cboSld
            // 
            this.cboSld.FormattingEnabled = true;
            this.cboSld.Location = new System.Drawing.Point(724, 152);
            this.cboSld.Name = "cboSld";
            this.cboSld.Size = new System.Drawing.Size(139, 27);
            this.cboSld.TabIndex = 5;
            // 
            // cboMaSp
            // 
            this.cboMaSp.DisplayMember = "MASP";
            this.cboMaSp.FormattingEnabled = true;
            this.cboMaSp.Location = new System.Drawing.Point(724, 20);
            this.cboMaSp.Name = "cboMaSp";
            this.cboMaSp.Size = new System.Drawing.Size(139, 27);
            this.cboMaSp.TabIndex = 5;
            this.cboMaSp.ValueMember = "MASP";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(724, 108);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(354, 27);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtSlcn
            // 
            this.txtSlcn.Location = new System.Drawing.Point(944, 64);
            this.txtSlcn.Name = "txtSlcn";
            this.txtSlcn.Size = new System.Drawing.Size(134, 27);
            this.txtSlcn.TabIndex = 2;
            // 
            // txtSln
            // 
            this.txtSln.Location = new System.Drawing.Point(724, 64);
            this.txtSln.Name = "txtSln";
            this.txtSln.Size = new System.Drawing.Size(139, 27);
            this.txtSln.TabIndex = 2;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(104, 64);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(342, 27);
            this.txtMaNv.TabIndex = 2;
            // 
            // txtMaPn
            // 
            this.txtMaPn.Location = new System.Drawing.Point(104, 20);
            this.txtMaPn.Name = "txtMaPn";
            this.txtMaPn.Size = new System.Drawing.Size(342, 27);
            this.txtMaPn.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số Lượng Đặt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Nhập:";
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
            this.btnCancel.Location = new System.Drawing.Point(908, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(175, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(869, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá Thành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Đơn Hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(875, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Còn Nhập:";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số Lượng Nhập:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên:";
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
            this.btnSave.Location = new System.Drawing.Point(365, 217);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(175, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập:";
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
            this.btnPrint.Location = new System.Drawing.Point(727, 217);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(175, 39);
            this.btnPrint.TabIndex = 4;
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
            this.btnInsert.Location = new System.Drawing.Point(3, 217);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(175, 39);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
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
            this.btnDelete.Location = new System.Drawing.Point(546, 217);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(175, 39);
            this.btnDelete.TabIndex = 4;
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
            this.btnEdit.Location = new System.Drawing.Point(184, 217);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(175, 39);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // uctPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uctPhieuNhap";
            this.Size = new System.Drawing.Size(1104, 687);
            this.Load += new System.EventHandler(this.uc_PhieuNhap_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.TextBox txtMaPn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTenSp;
        private System.Windows.Forms.ComboBox cboMaSp;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSln;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaDh;
        private System.Windows.Forms.Label lbMaNv;
        private System.Windows.Forms.Label lbMaPn;
        private System.Windows.Forms.ComboBox cboGiaThanh;
        private System.Windows.Forms.ComboBox cboSld;
        private System.Windows.Forms.TextBox txtSlcn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSln;
        private System.Windows.Forms.Label lbMaSp;
        private System.Windows.Forms.DateTimePicker dtmNgayNhap;
        private System.Windows.Forms.ComboBox cboMaDh;
    }
}
