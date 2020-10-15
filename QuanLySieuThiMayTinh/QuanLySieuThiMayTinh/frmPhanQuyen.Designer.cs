namespace QuanLySieuThiMayTinh
{
    partial class frmPhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDsTaiKhoanNv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboMaQh_DsNv = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnFilterDsNv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDsTaiKhoanTheoMaQh = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cboMaQh_ThongTinNv = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnFilterDsNvTheoMaQh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTaiKhoanNv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTaiKhoanTheoMaQh)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDsTaiKhoanNv);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 749);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Tài Khoản Nhân Viên";
            // 
            // dgvDsTaiKhoanNv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDsTaiKhoanNv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsTaiKhoanNv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDsTaiKhoanNv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDsTaiKhoanNv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsTaiKhoanNv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsTaiKhoanNv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTaiKhoanNv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDsTaiKhoanNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsTaiKhoanNv.DoubleBuffered = true;
            this.dgvDsTaiKhoanNv.EnableHeadersVisualStyles = false;
            this.dgvDsTaiKhoanNv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvDsTaiKhoanNv.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDsTaiKhoanNv.Location = new System.Drawing.Point(3, 46);
            this.dgvDsTaiKhoanNv.Name = "dgvDsTaiKhoanNv";
            this.dgvDsTaiKhoanNv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsTaiKhoanNv.RowHeadersWidth = 51;
            this.dgvDsTaiKhoanNv.Size = new System.Drawing.Size(771, 700);
            this.dgvDsTaiKhoanNv.TabIndex = 2;
            this.dgvDsTaiKhoanNv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsTaiKhoanNv_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fullname";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QLBH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NVBH";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "NVNEW";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 23);
            this.panel3.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cboMaQh_DsNv);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(604, 23);
            this.panel7.TabIndex = 1;
            // 
            // cboMaQh_DsNv
            // 
            this.cboMaQh_DsNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaQh_DsNv.FormattingEnabled = true;
            this.cboMaQh_DsNv.Location = new System.Drawing.Point(0, 0);
            this.cboMaQh_DsNv.Name = "cboMaQh_DsNv";
            this.cboMaQh_DsNv.Size = new System.Drawing.Size(604, 27);
            this.cboMaQh_DsNv.TabIndex = 1;
            this.cboMaQh_DsNv.TextChanged += new System.EventHandler(this.cboMaQh_DsNv_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnFilterDsNv);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(604, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 23);
            this.panel6.TabIndex = 1;
            // 
            // btnFilterDsNv
            // 
            this.btnFilterDsNv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterDsNv.BorderRadius = 0;
            this.btnFilterDsNv.ButtonText = "Filter";
            this.btnFilterDsNv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterDsNv.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilterDsNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterDsNv.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilterDsNv.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFilterDsNv.Iconimage")));
            this.btnFilterDsNv.Iconimage_right = null;
            this.btnFilterDsNv.Iconimage_right_Selected = null;
            this.btnFilterDsNv.Iconimage_Selected = null;
            this.btnFilterDsNv.IconMarginLeft = 0;
            this.btnFilterDsNv.IconMarginRight = 0;
            this.btnFilterDsNv.IconRightVisible = true;
            this.btnFilterDsNv.IconRightZoom = 0D;
            this.btnFilterDsNv.IconVisible = true;
            this.btnFilterDsNv.IconZoom = 30D;
            this.btnFilterDsNv.IsTab = false;
            this.btnFilterDsNv.Location = new System.Drawing.Point(0, 0);
            this.btnFilterDsNv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterDsNv.Name = "btnFilterDsNv";
            this.btnFilterDsNv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFilterDsNv.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilterDsNv.selected = false;
            this.btnFilterDsNv.Size = new System.Drawing.Size(167, 23);
            this.btnFilterDsNv.TabIndex = 0;
            this.btnFilterDsNv.Text = "Filter";
            this.btnFilterDsNv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilterDsNv.Textcolor = System.Drawing.Color.White;
            this.btnFilterDsNv.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 227);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Tài Khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bunifuFlatButton1);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtPermission);
            this.panel5.Controls.Add(this.txtFullname);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Controls.Add(this.txtUsername);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 201);
            this.panel5.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Edit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(207, 140);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(113, 39);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Edit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.IconZoom = 70D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(389, 140);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Permission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // txtPermission
            // 
            this.txtPermission.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermission.Location = new System.Drawing.Point(207, 102);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(296, 27);
            this.txtPermission.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(207, 73);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(296, 27);
            this.txtFullname.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(207, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 27);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(207, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel17);
            this.groupBox3.Controls.Add(this.panel16);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 522);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Tài Khoản Theo Từng Quyền Hạn";
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 495);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(556, 24);
            this.panel17.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel4);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(3, 23);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(556, 472);
            this.panel16.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDsTaiKhoanTheoMaQh);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 472);
            this.panel4.TabIndex = 1;
            // 
            // dgvDsTaiKhoanTheoMaQh
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDsTaiKhoanTheoMaQh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDsTaiKhoanTheoMaQh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDsTaiKhoanTheoMaQh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDsTaiKhoanTheoMaQh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsTaiKhoanTheoMaQh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDsTaiKhoanTheoMaQh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTaiKhoanTheoMaQh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column10});
            this.dgvDsTaiKhoanTheoMaQh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsTaiKhoanTheoMaQh.DoubleBuffered = true;
            this.dgvDsTaiKhoanTheoMaQh.EnableHeadersVisualStyles = false;
            this.dgvDsTaiKhoanTheoMaQh.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvDsTaiKhoanTheoMaQh.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDsTaiKhoanTheoMaQh.Location = new System.Drawing.Point(0, 23);
            this.dgvDsTaiKhoanTheoMaQh.Name = "dgvDsTaiKhoanTheoMaQh";
            this.dgvDsTaiKhoanTheoMaQh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsTaiKhoanTheoMaQh.RowHeadersWidth = 51;
            this.dgvDsTaiKhoanTheoMaQh.Size = new System.Drawing.Size(556, 449);
            this.dgvDsTaiKhoanTheoMaQh.TabIndex = 2;
            this.dgvDsTaiKhoanTheoMaQh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsTaiKhoanTheoMaQh_CellClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Username";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Password";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Fullname";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Permission";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(556, 23);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cboMaQh_ThongTinNv);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(389, 23);
            this.panel12.TabIndex = 1;
            // 
            // cboMaQh_ThongTinNv
            // 
            this.cboMaQh_ThongTinNv.DisplayMember = "MAQH";
            this.cboMaQh_ThongTinNv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaQh_ThongTinNv.FormattingEnabled = true;
            this.cboMaQh_ThongTinNv.Location = new System.Drawing.Point(0, 0);
            this.cboMaQh_ThongTinNv.Name = "cboMaQh_ThongTinNv";
            this.cboMaQh_ThongTinNv.Size = new System.Drawing.Size(389, 27);
            this.cboMaQh_ThongTinNv.TabIndex = 1;
            this.cboMaQh_ThongTinNv.ValueMember = "MAQH";
            this.cboMaQh_ThongTinNv.TextChanged += new System.EventHandler(this.cboMaQh_ThongTinNv_TextChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnFilterDsNvTheoMaQh);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(389, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(167, 23);
            this.panel13.TabIndex = 1;
            // 
            // btnFilterDsNvTheoMaQh
            // 
            this.btnFilterDsNvTheoMaQh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNvTheoMaQh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNvTheoMaQh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterDsNvTheoMaQh.BorderRadius = 0;
            this.btnFilterDsNvTheoMaQh.ButtonText = "Filter";
            this.btnFilterDsNvTheoMaQh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterDsNvTheoMaQh.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilterDsNvTheoMaQh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterDsNvTheoMaQh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilterDsNvTheoMaQh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFilterDsNvTheoMaQh.Iconimage")));
            this.btnFilterDsNvTheoMaQh.Iconimage_right = null;
            this.btnFilterDsNvTheoMaQh.Iconimage_right_Selected = null;
            this.btnFilterDsNvTheoMaQh.Iconimage_Selected = null;
            this.btnFilterDsNvTheoMaQh.IconMarginLeft = 0;
            this.btnFilterDsNvTheoMaQh.IconMarginRight = 0;
            this.btnFilterDsNvTheoMaQh.IconRightVisible = true;
            this.btnFilterDsNvTheoMaQh.IconRightZoom = 0D;
            this.btnFilterDsNvTheoMaQh.IconVisible = true;
            this.btnFilterDsNvTheoMaQh.IconZoom = 30D;
            this.btnFilterDsNvTheoMaQh.IsTab = false;
            this.btnFilterDsNvTheoMaQh.Location = new System.Drawing.Point(0, 0);
            this.btnFilterDsNvTheoMaQh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterDsNvTheoMaQh.Name = "btnFilterDsNvTheoMaQh";
            this.btnFilterDsNvTheoMaQh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFilterDsNvTheoMaQh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFilterDsNvTheoMaQh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilterDsNvTheoMaQh.selected = false;
            this.btnFilterDsNvTheoMaQh.Size = new System.Drawing.Size(167, 23);
            this.btnFilterDsNvTheoMaQh.TabIndex = 0;
            this.btnFilterDsNvTheoMaQh.Text = "Filter";
            this.btnFilterDsNvTheoMaQh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilterDsNvTheoMaQh.Textcolor = System.Drawing.Color.White;
            this.btnFilterDsNvTheoMaQh.TextFont = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 749);
            this.panel1.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(777, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(31, 749);
            this.panel15.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.groupBox1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(777, 749);
            this.panel14.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(808, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 749);
            this.panel2.TabIndex = 1;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTaiKhoanNv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTaiKhoanTheoMaQh)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cboMaQh_DsNv;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilterDsNv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cboMaQh_ThongTinNv;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilterDsNvTheoMaQh;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDsTaiKhoanNv;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDsTaiKhoanTheoMaQh;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}