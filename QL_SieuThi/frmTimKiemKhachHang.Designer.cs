namespace QL_SieuThi
{
    partial class frmTimKiemKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radTimTheoGioiTinh = new System.Windows.Forms.RadioButton();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radTimTheoNgayLap = new System.Windows.Forms.RadioButton();
            this.radTimTheoMaKhachHang = new System.Windows.Forms.RadioButton();
            this.cboTimTheoNgayLap = new System.Windows.Forms.ComboBox();
            this.cboTimTheoGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTimTheoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTimTheoMaKhachHang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoatdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // radTimTheoGioiTinh
            // 
            this.radTimTheoGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoGioiTinh.AutoSize = true;
            this.radTimTheoGioiTinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoGioiTinh.Location = new System.Drawing.Point(368, 140);
            this.radTimTheoGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoGioiTinh.Name = "radTimTheoGioiTinh";
            this.radTimTheoGioiTinh.Size = new System.Drawing.Size(157, 23);
            this.radTimTheoGioiTinh.TabIndex = 119;
            this.radTimTheoGioiTinh.TabStop = true;
            this.radTimTheoGioiTinh.Text = "Tìm theo giới tính";
            this.radTimTheoGioiTinh.UseVisualStyleBackColor = true;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoTen.Location = new System.Drawing.Point(742, 33);
            this.radTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(123, 23);
            this.radTimTheoTen.TabIndex = 117;
            this.radTimTheoTen.TabStop = true;
            this.radTimTheoTen.Text = "Tìm theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radTimTheoNgayLap
            // 
            this.radTimTheoNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoNgayLap.AutoSize = true;
            this.radTimTheoNgayLap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoNgayLap.Location = new System.Drawing.Point(742, 140);
            this.radTimTheoNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoNgayLap.Name = "radTimTheoNgayLap";
            this.radTimTheoNgayLap.Size = new System.Drawing.Size(165, 23);
            this.radTimTheoNgayLap.TabIndex = 121;
            this.radTimTheoNgayLap.TabStop = true;
            this.radTimTheoNgayLap.Text = "Tìm theo ngày lập";
            this.radTimTheoNgayLap.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMaKhachHang
            // 
            this.radTimTheoMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoMaKhachHang.AutoSize = true;
            this.radTimTheoMaKhachHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoMaKhachHang.Location = new System.Drawing.Point(368, 33);
            this.radTimTheoMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoMaKhachHang.Name = "radTimTheoMaKhachHang";
            this.radTimTheoMaKhachHang.Size = new System.Drawing.Size(223, 23);
            this.radTimTheoMaKhachHang.TabIndex = 115;
            this.radTimTheoMaKhachHang.TabStop = true;
            this.radTimTheoMaKhachHang.Text = "Tìm theo mã khách hàng";
            this.radTimTheoMaKhachHang.UseVisualStyleBackColor = true;
            // 
            // cboTimTheoNgayLap
            // 
            this.cboTimTheoNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoNgayLap.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoNgayLap.FormattingEnabled = true;
            this.cboTimTheoNgayLap.Location = new System.Drawing.Point(742, 172);
            this.cboTimTheoNgayLap.Name = "cboTimTheoNgayLap";
            this.cboTimTheoNgayLap.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoNgayLap.TabIndex = 122;
            // 
            // cboTimTheoGioiTinh
            // 
            this.cboTimTheoGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoGioiTinh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoGioiTinh.FormattingEnabled = true;
            this.cboTimTheoGioiTinh.Location = new System.Drawing.Point(368, 172);
            this.cboTimTheoGioiTinh.Name = "cboTimTheoGioiTinh";
            this.cboTimTheoGioiTinh.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoGioiTinh.TabIndex = 120;
            // 
            // txtTimTheoTen
            // 
            this.txtTimTheoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTheoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTheoTen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTimTheoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTheoTen.HintText = "";
            this.txtTimTheoTen.isPassword = false;
            this.txtTimTheoTen.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimTheoTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTimTheoTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTheoTen.LineThickness = 1;
            this.txtTimTheoTen.Location = new System.Drawing.Point(742, 61);
            this.txtTimTheoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimTheoTen.Name = "txtTimTheoTen";
            this.txtTimTheoTen.Size = new System.Drawing.Size(271, 39);
            this.txtTimTheoTen.TabIndex = 118;
            this.txtTimTheoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTimTheoMaKhachHang
            // 
            this.txtTimTheoMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTheoMaKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTheoMaKhachHang.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTimTheoMaKhachHang.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTheoMaKhachHang.HintText = "";
            this.txtTimTheoMaKhachHang.isPassword = false;
            this.txtTimTheoMaKhachHang.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimTheoMaKhachHang.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTimTheoMaKhachHang.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTheoMaKhachHang.LineThickness = 1;
            this.txtTimTheoMaKhachHang.Location = new System.Drawing.Point(368, 61);
            this.txtTimTheoMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimTheoMaKhachHang.Name = "txtTimTheoMaKhachHang";
            this.txtTimTheoMaKhachHang.Size = new System.Drawing.Size(271, 39);
            this.txtTimTheoMaKhachHang.TabIndex = 116;
            this.txtTimTheoMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKhachHang.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTimKhachHang.Location = new System.Drawing.Point(28, 21);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(257, 37);
            this.lblTimKhachHang.TabIndex = 123;
            this.lblTimKhachHang.Text = "Tìm khách hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = global::QL_SieuThi.Properties.Resources.icons8_searchwhite_in_list_32;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 50D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(526, 251);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(348, 45);
            this.btnTimKiem.TabIndex = 125;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.dgvKhachHang.TabIndex = 142;
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
            // frmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.radTimTheoGioiTinh);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radTimTheoNgayLap);
            this.Controls.Add(this.radTimTheoMaKhachHang);
            this.Controls.Add(this.cboTimTheoNgayLap);
            this.Controls.Add(this.cboTimTheoGioiTinh);
            this.Controls.Add(this.txtTimTheoTen);
            this.Controls.Add(this.txtTimTheoMaKhachHang);
            this.Controls.Add(this.lblTimKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.RadioButton radTimTheoGioiTinh;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radTimTheoNgayLap;
        private System.Windows.Forms.RadioButton radTimTheoMaKhachHang;
        private System.Windows.Forms.ComboBox cboTimTheoNgayLap;
        private System.Windows.Forms.ComboBox cboTimTheoGioiTinh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTheoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTheoMaKhachHang;
        private System.Windows.Forms.Label lblTimKhachHang;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
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