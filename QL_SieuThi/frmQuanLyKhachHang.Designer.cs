namespace QL_SieuThi
{
    partial class frmQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboHoatDong = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDienThoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaKhachHang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblHoatDong = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblQuanLyKhachHang = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuy = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThemSuaXong = new Bunifu.Framework.UI.BunifuImageButton();
            this.picTaiKhoan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 50;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkhachhang,
            this.diachi,
            this.dienThoai,
            this.gioiTinh,
            this.ngaysinh,
            this.ngaylap,
            this.hoatdong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.DoubleBuffered = true;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.DarkGray;
            this.dgvKhachHang.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
            this.dgvKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.Location = new System.Drawing.Point(5, 333);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 50;
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvKhachHang.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvKhachHang.RowTemplate.DividerHeight = 1;
            this.dgvKhachHang.RowTemplate.Height = 30;
            this.dgvKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1242, 310);
            this.dgvKhachHang.TabIndex = 141;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "tenkhachhang";
            this.tenkhachhang.HeaderText = "Họ và tên";
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // dienThoai
            // 
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "Điện thoại";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // hoatdong
            // 
            this.hoatdong.DataPropertyName = "hoatdong";
            this.hoatdong.HeaderText = "Hoạt động";
            this.hoatdong.Name = "hoatdong";
            this.hoatdong.ReadOnly = true;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgaySinh.Location = new System.Drawing.Point(799, 150);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(217, 27);
            this.dtmNgaySinh.TabIndex = 11;
            // 
            // cboHoatDong
            // 
            this.cboHoatDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboHoatDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoatDong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoatDong.FormattingEnabled = true;
            this.cboHoatDong.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboHoatDong.Location = new System.Drawing.Point(799, 291);
            this.cboHoatDong.Name = "cboHoatDong";
            this.cboHoatDong.Size = new System.Drawing.Size(217, 27);
            this.cboHoatDong.TabIndex = 13;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(799, 83);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(217, 27);
            this.cboGioiTinh.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDiaChi.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiaChi.HintText = "";
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtDiaChi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiaChi.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtDiaChi.LineThickness = 1;
            this.txtDiaChi.Location = new System.Drawing.Point(340, 214);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 32);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtHoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.HintText = "";
            this.txtHoTen.isPassword = false;
            this.txtHoTen.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtHoTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHoTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtHoTen.LineThickness = 1;
            this.txtHoTen.Location = new System.Drawing.Point(340, 146);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(217, 32);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDienThoai.HintForeColor = System.Drawing.Color.Empty;
            this.txtDienThoai.HintText = "";
            this.txtDienThoai.isPassword = false;
            this.txtDienThoai.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtDienThoai.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDienThoai.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtDienThoai.LineThickness = 1;
            this.txtDienThoai.Location = new System.Drawing.Point(340, 282);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(217, 32);
            this.txtDienThoai.TabIndex = 9;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaKhachHang.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaKhachHang.HintText = "";
            this.txtMaKhachHang.isPassword = false;
            this.txtMaKhachHang.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaKhachHang.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaKhachHang.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtMaKhachHang.LineThickness = 1;
            this.txtMaKhachHang.Location = new System.Drawing.Point(340, 78);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(217, 32);
            this.txtMaKhachHang.TabIndex = 6;
            this.txtMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDienThoai.Location = new System.Drawing.Point(206, 292);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(100, 26);
            this.lblDienThoai.TabIndex = 150;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoatDong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblHoatDong.Location = new System.Drawing.Point(665, 292);
            this.lblHoatDong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(81, 26);
            this.lblHoatDong.TabIndex = 149;
            this.lblHoatDong.Text = "Hoạt động";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGioiTinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(665, 88);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 26);
            this.lblGioiTinh.TabIndex = 148;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDiaChi.Location = new System.Drawing.Point(206, 224);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(70, 26);
            this.lblDiaChi.TabIndex = 147;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(665, 156);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(96, 26);
            this.lblNgaySinh.TabIndex = 146;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblHoTen.Location = new System.Drawing.Point(206, 156);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 26);
            this.lblHoTen.TabIndex = 145;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblMaKhachHang.Location = new System.Drawing.Point(206, 88);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(128, 26);
            this.lblMaKhachHang.TabIndex = 144;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // lblQuanLyKhachHang
            // 
            this.lblQuanLyKhachHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyKhachHang.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblQuanLyKhachHang.Location = new System.Drawing.Point(13, 24);
            this.lblQuanLyKhachHang.Name = "lblQuanLyKhachHang";
            this.lblQuanLyKhachHang.Size = new System.Drawing.Size(293, 37);
            this.lblQuanLyKhachHang.TabIndex = 143;
            this.lblQuanLyKhachHang.Text = "Quản lý khách hàng";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayLap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblNgayLap.Location = new System.Drawing.Point(665, 224);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(96, 26);
            this.lblNgayLap.TabIndex = 146;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmNgayLap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayLap.Location = new System.Drawing.Point(799, 218);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(217, 27);
            this.dtmNgayLap.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = global::QL_SieuThi.Properties.Resources.icons8_deletewhite_32;
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = true;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = true;
            this.btnXoa.IconZoom = 50D;
            this.btnXoa.IsTab = false;
            this.btnXoa.Location = new System.Drawing.Point(1043, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(146, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::QL_SieuThi.Properties.Resources.icons8_support_32;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 50D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(1043, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(146, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = global::QL_SieuThi.Properties.Resources.icons8_pluswhite_math_32;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 50D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(1043, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(146, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Image = global::QL_SieuThi.Properties.Resources.icons8_deletewhite_32;
            this.btnHuy.ImageActive = null;
            this.btnHuy.Location = new System.Drawing.Point(1127, 280);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 42);
            this.btnHuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHuy.TabIndex = 153;
            this.btnHuy.TabStop = false;
            this.btnHuy.Zoom = 10;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemSuaXong
            // 
            this.btnThemSuaXong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemSuaXong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btnThemSuaXong.Image = global::QL_SieuThi.Properties.Resources.icons8_checkmark_32;
            this.btnThemSuaXong.ImageActive = null;
            this.btnThemSuaXong.Location = new System.Drawing.Point(1043, 280);
            this.btnThemSuaXong.Name = "btnThemSuaXong";
            this.btnThemSuaXong.Size = new System.Drawing.Size(62, 42);
            this.btnThemSuaXong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnThemSuaXong.TabIndex = 152;
            this.btnThemSuaXong.TabStop = false;
            this.btnThemSuaXong.Zoom = 10;
            this.btnThemSuaXong.Click += new System.EventHandler(this.btnThemSuaXong_Click);
            // 
            // picTaiKhoan
            // 
            this.picTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTaiKhoan.Image = global::QL_SieuThi.Properties.Resources.iconfinder_00_ELASTOFONT_STORE_READY_user_circle_2703062__1_;
            this.picTaiKhoan.Location = new System.Drawing.Point(74, 82);
            this.picTaiKhoan.Name = "picTaiKhoan";
            this.picTaiKhoan.Size = new System.Drawing.Size(100, 100);
            this.picTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTaiKhoan.TabIndex = 142;
            this.picTaiKhoan.TabStop = false;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtmNgayLap);
            this.Controls.Add(this.dtmNgaySinh);
            this.Controls.Add(this.cboHoatDong);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemSuaXong);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblHoatDong);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.lblQuanLyKhachHang);
            this.Controls.Add(this.picTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(21, 24);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.ComboBox cboHoatDong;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private Bunifu.Framework.UI.BunifuImageButton btnHuy;
        private Bunifu.Framework.UI.BunifuImageButton btnThemSuaXong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDienThoai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaKhachHang;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblHoatDong;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblQuanLyKhachHang;
        private System.Windows.Forms.PictureBox picTaiKhoan;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoatdong;
    }
}