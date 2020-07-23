namespace QL_SieuThi
{
    partial class frmQuanLySanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.txtTenSanPham = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNhaSanXuat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaSanPham = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.lblQuanLySanPham = new System.Windows.Forms.Label();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuy = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThemSuaXong = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSoLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvKhachHang.ColumnHeadersHeight = 50;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensanpham,
            this.loaisanpham,
            this.nhasanxuat,
            this.soluong,
            this.dongia,
            this.trangthai});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvKhachHang.DoubleBuffered = true;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.DarkGray;
            this.dgvKhachHang.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
            this.dgvKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.Location = new System.Drawing.Point(8, 322);
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
            this.dgvKhachHang.TabIndex = 165;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cboTrangThai.Location = new System.Drawing.Point(748, 212);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(217, 27);
            this.cboTrangThai.TabIndex = 164;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Items.AddRange(new object[] {
            "Kem đánh răng",
            "Bàn chải"});
            this.cboLoaiSanPham.Location = new System.Drawing.Point(289, 210);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(217, 27);
            this.cboLoaiSanPham.TabIndex = 161;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTenSanPham.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenSanPham.HintText = "";
            this.txtTenSanPham.isPassword = false;
            this.txtTenSanPham.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTenSanPham.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenSanPham.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTenSanPham.LineThickness = 1;
            this.txtTenSanPham.Location = new System.Drawing.Point(289, 135);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(217, 32);
            this.txtTenSanPham.TabIndex = 158;
            this.txtTenSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhaSanXuat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaSanXuat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaSanXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNhaSanXuat.HintForeColor = System.Drawing.Color.Empty;
            this.txtNhaSanXuat.HintText = "";
            this.txtNhaSanXuat.isPassword = false;
            this.txtNhaSanXuat.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtNhaSanXuat.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNhaSanXuat.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtNhaSanXuat.LineThickness = 1;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(289, 271);
            this.txtNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(217, 32);
            this.txtNhaSanXuat.TabIndex = 160;
            this.txtNhaSanXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaSanPham.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaSanPham.HintText = "";
            this.txtMaSanPham.isPassword = false;
            this.txtMaSanPham.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaSanPham.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaSanPham.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtMaSanPham.LineThickness = 1;
            this.txtMaSanPham.Location = new System.Drawing.Point(289, 67);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(217, 32);
            this.txtMaSanPham.TabIndex = 157;
            this.txtMaSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNhaSanXuat
            // 
            this.lblNhaSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhaSanXuat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaSanXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblNhaSanXuat.Location = new System.Drawing.Point(155, 281);
            this.lblNhaSanXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaSanXuat.Name = "lblNhaSanXuat";
            this.lblNhaSanXuat.Size = new System.Drawing.Size(107, 26);
            this.lblNhaSanXuat.TabIndex = 175;
            this.lblNhaSanXuat.Text = "Nhà sản xuất";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangThai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblTrangThai.Location = new System.Drawing.Point(614, 213);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(81, 26);
            this.lblTrangThai.TabIndex = 174;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSoLuong.Location = new System.Drawing.Point(614, 77);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(86, 26);
            this.lblSoLuong.TabIndex = 173;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblLoaiSanPham.Location = new System.Drawing.Point(155, 213);
            this.lblLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(107, 26);
            this.lblLoaiSanPham.TabIndex = 172;
            this.lblLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblTenSanPham.Location = new System.Drawing.Point(155, 145);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(107, 26);
            this.lblTenSanPham.TabIndex = 169;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaSanPham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblMaSanPham.Location = new System.Drawing.Point(155, 77);
            this.lblMaSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(107, 26);
            this.lblMaSanPham.TabIndex = 168;
            this.lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // lblQuanLySanPham
            // 
            this.lblQuanLySanPham.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLySanPham.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblQuanLySanPham.Location = new System.Drawing.Point(16, 13);
            this.lblQuanLySanPham.Name = "lblQuanLySanPham";
            this.lblQuanLySanPham.Size = new System.Drawing.Size(263, 37);
            this.lblQuanLySanPham.TabIndex = 167;
            this.lblQuanLySanPham.Text = "Quản lý sản phẩm";
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
            this.btnXoa.Location = new System.Drawing.Point(992, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(146, 40);
            this.btnXoa.TabIndex = 156;
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
            this.btnSua.Location = new System.Drawing.Point(992, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(146, 40);
            this.btnSua.TabIndex = 155;
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
            this.btnThem.Location = new System.Drawing.Point(992, 63);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(146, 40);
            this.btnThem.TabIndex = 154;
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
            this.btnHuy.Location = new System.Drawing.Point(1076, 269);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(62, 42);
            this.btnHuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHuy.TabIndex = 177;
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
            this.btnThemSuaXong.Location = new System.Drawing.Point(992, 269);
            this.btnThemSuaXong.Name = "btnThemSuaXong";
            this.btnThemSuaXong.Size = new System.Drawing.Size(62, 42);
            this.btnThemSuaXong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnThemSuaXong.TabIndex = 176;
            this.btnThemSuaXong.TabStop = false;
            this.btnThemSuaXong.Zoom = 10;
            this.btnThemSuaXong.Click += new System.EventHandler(this.btnThemSuaXong_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSoLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuong.HintText = "";
            this.txtSoLuong.isPassword = false;
            this.txtSoLuong.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtSoLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoLuong.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtSoLuong.LineThickness = 1;
            this.txtSoLuong.Location = new System.Drawing.Point(748, 71);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(217, 32);
            this.txtSoLuong.TabIndex = 157;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonGia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblDonGia.Location = new System.Drawing.Point(614, 145);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(86, 26);
            this.lblDonGia.TabIndex = 173;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDonGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtDonGia.HintText = "";
            this.txtDonGia.isPassword = false;
            this.txtDonGia.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtDonGia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDonGia.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtDonGia.LineThickness = 1;
            this.txtDonGia.Location = new System.Drawing.Point(748, 139);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(217, 32);
            this.txtDonGia.TabIndex = 157;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensanpham
            // 
            this.tensanpham.DataPropertyName = "tensanpham";
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            // 
            // loaisanpham
            // 
            this.loaisanpham.DataPropertyName = "loaisanpham";
            this.loaisanpham.HeaderText = "Loại sản phẩm";
            this.loaisanpham.Name = "loaisanpham";
            this.loaisanpham.ReadOnly = true;
            // 
            // nhasanxuat
            // 
            this.nhasanxuat.DataPropertyName = "nhasanxuat";
            this.nhasanxuat.HeaderText = "Nhà sản xuất";
            this.nhasanxuat.Name = "nhasanxuat";
            this.nhasanxuat.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "hoatdong";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.cboLoaiSanPham);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemSuaXong);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtNhaSanXuat);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lblNhaSanXuat);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblLoaiSanPham);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.lblQuanLySanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuaXong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private Bunifu.Framework.UI.BunifuImageButton btnHuy;
        private Bunifu.Framework.UI.BunifuImageButton btnThemSuaXong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenSanPham;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNhaSanXuat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaSanPham;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label lblQuanLySanPham;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}