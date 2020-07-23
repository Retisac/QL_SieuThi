namespace QL_SieuThi
{
    partial class frmQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDienThoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaNhanVien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuy = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThemSuaXong = new Bunifu.Framework.UI.BunifuImageButton();
            this.picTaiKhoan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChucVu
            // 
            this.cboChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChucVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(799, 291);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(217, 27);
            this.cboChucVu.TabIndex = 11;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioiTinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(799, 151);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(217, 27);
            this.cboGioiTinh.TabIndex = 9;
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
            this.txtDiaChi.Location = new System.Drawing.Point(340, 282);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 32);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtLuong.HintText = "";
            this.txtLuong.isPassword = false;
            this.txtLuong.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLuong.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtLuong.LineThickness = 1;
            this.txtLuong.Location = new System.Drawing.Point(799, 214);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(217, 32);
            this.txtLuong.TabIndex = 10;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
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
            this.txtHoTen.Location = new System.Drawing.Point(341, 146);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(217, 32);
            this.txtHoTen.TabIndex = 5;
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
            this.txtDienThoai.Location = new System.Drawing.Point(799, 78);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(217, 32);
            this.txtDienThoai.TabIndex = 8;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaNhanVien.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaNhanVien.HintText = "";
            this.txtMaNhanVien.isPassword = false;
            this.txtMaNhanVien.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaNhanVien.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaNhanVien.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtMaNhanVien.LineThickness = 1;
            this.txtMaNhanVien.Location = new System.Drawing.Point(340, 78);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(217, 32);
            this.txtMaNhanVien.TabIndex = 4;
            this.txtMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblLuong
            // 
            this.lblLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblLuong.Location = new System.Drawing.Point(665, 224);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(67, 26);
            this.lblLuong.TabIndex = 119;
            this.lblLuong.Text = "Lương";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDienThoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDienThoai.Location = new System.Drawing.Point(665, 88);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(100, 26);
            this.lblDienThoai.TabIndex = 118;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblChucVu
            // 
            this.lblChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChucVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblChucVu.Location = new System.Drawing.Point(665, 292);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(81, 26);
            this.lblChucVu.TabIndex = 117;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGioiTinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(665, 156);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 26);
            this.lblGioiTinh.TabIndex = 116;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDiaChi.Location = new System.Drawing.Point(206, 292);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(70, 26);
            this.lblDiaChi.TabIndex = 115;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(206, 224);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(96, 26);
            this.lblNgaySinh.TabIndex = 114;
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
            this.lblHoTen.TabIndex = 113;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblMaNhanVien.Location = new System.Drawing.Point(206, 88);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(128, 26);
            this.lblMaNhanVien.TabIndex = 112;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(21, 24);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(257, 37);
            this.lblQuanLyNhanVien.TabIndex = 111;
            this.lblQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtmNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgaySinh.Location = new System.Drawing.Point(340, 218);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(217, 27);
            this.dtmNgaySinh.TabIndex = 6;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNhanVien.ColumnHeadersHeight = 50;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hovaten,
            this.ngaysinh,
            this.diachi,
            this.dienThoai,
            this.gioiTinh,
            this.luong,
            this.chucvu});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNhanVien.DoubleBuffered = true;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.DarkGray;
            this.dgvNhanVien.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
            this.dgvNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(5, 333);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 50;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvNhanVien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNhanVien.RowTemplate.DividerHeight = 1;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1240, 310);
            this.dgvNhanVien.TabIndex = 14;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // hovaten
            // 
            this.hovaten.HeaderText = "Họ và tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // dienThoai
            // 
            this.dienThoai.HeaderText = "Điện thoại";
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // luong
            // 
            this.luong.HeaderText = "Lương";
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
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
            this.btnHuy.TabIndex = 129;
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
            this.btnThemSuaXong.TabIndex = 128;
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
            this.picTaiKhoan.TabIndex = 110;
            this.picTaiKhoan.TabStop = false;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtmNgaySinh);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemSuaXong);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblQuanLyNhanVien);
            this.Controls.Add(this.picTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private Bunifu.Framework.UI.BunifuImageButton btnHuy;
        private Bunifu.Framework.UI.BunifuImageButton btnThemSuaXong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDienThoai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaNhanVien;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblQuanLyNhanVien;
        private System.Windows.Forms.PictureBox picTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
    }
}