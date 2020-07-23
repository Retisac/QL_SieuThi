namespace QL_SieuThi
{
    partial class frmTimKiemNhanVien
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
            this.lblTimNhanVien = new System.Windows.Forms.Label();
            this.dgvNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTimTheoChucVu = new System.Windows.Forms.ComboBox();
            this.cboTimTheoGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTimTheoHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTimTheoMaNhanVien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radTimTheoGioiTinh = new System.Windows.Forms.RadioButton();
            this.radTimTheoHoTen = new System.Windows.Forms.RadioButton();
            this.radTimTheoChucVu = new System.Windows.Forms.RadioButton();
            this.radTimTheoMaNhanVien = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimNhanVien
            // 
            this.lblTimNhanVien.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimNhanVien.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTimNhanVien.Location = new System.Drawing.Point(28, 21);
            this.lblTimNhanVien.Name = "lblTimNhanVien";
            this.lblTimNhanVien.Size = new System.Drawing.Size(257, 37);
            this.lblTimNhanVien.TabIndex = 112;
            this.lblTimNhanVien.Text = "Tìm nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.DoubleBuffered = true;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.DarkGray;
            this.dgvNhanVien.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
            this.dgvNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 330);
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
            this.dgvNhanVien.TabIndex = 113;
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
            // cboTimTheoChucVu
            // 
            this.cboTimTheoChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoChucVu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoChucVu.FormattingEnabled = true;
            this.cboTimTheoChucVu.Location = new System.Drawing.Point(742, 172);
            this.cboTimTheoChucVu.Name = "cboTimTheoChucVu";
            this.cboTimTheoChucVu.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoChucVu.TabIndex = 8;
            // 
            // cboTimTheoGioiTinh
            // 
            this.cboTimTheoGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoGioiTinh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoGioiTinh.FormattingEnabled = true;
            this.cboTimTheoGioiTinh.Location = new System.Drawing.Point(368, 172);
            this.cboTimTheoGioiTinh.Name = "cboTimTheoGioiTinh";
            this.cboTimTheoGioiTinh.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoGioiTinh.TabIndex = 6;
            // 
            // txtTimTheoHoTen
            // 
            this.txtTimTheoHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTheoHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTheoHoTen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTimTheoHoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTheoHoTen.HintText = "";
            this.txtTimTheoHoTen.isPassword = false;
            this.txtTimTheoHoTen.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimTheoHoTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTimTheoHoTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTheoHoTen.LineThickness = 1;
            this.txtTimTheoHoTen.Location = new System.Drawing.Point(742, 61);
            this.txtTimTheoHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimTheoHoTen.Name = "txtTimTheoHoTen";
            this.txtTimTheoHoTen.Size = new System.Drawing.Size(271, 39);
            this.txtTimTheoHoTen.TabIndex = 4;
            this.txtTimTheoHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTimTheoMaNhanVien
            // 
            this.txtTimTheoMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTheoMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTheoMaNhanVien.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTimTheoMaNhanVien.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTheoMaNhanVien.HintText = "";
            this.txtTimTheoMaNhanVien.isPassword = false;
            this.txtTimTheoMaNhanVien.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimTheoMaNhanVien.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTimTheoMaNhanVien.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTheoMaNhanVien.LineThickness = 1;
            this.txtTimTheoMaNhanVien.Location = new System.Drawing.Point(368, 61);
            this.txtTimTheoMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimTheoMaNhanVien.Name = "txtTimTheoMaNhanVien";
            this.txtTimTheoMaNhanVien.Size = new System.Drawing.Size(271, 39);
            this.txtTimTheoMaNhanVien.TabIndex = 2;
            this.txtTimTheoMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.radTimTheoGioiTinh.TabIndex = 5;
            this.radTimTheoGioiTinh.TabStop = true;
            this.radTimTheoGioiTinh.Text = "Tìm theo giới tính";
            this.radTimTheoGioiTinh.UseVisualStyleBackColor = true;
            // 
            // radTimTheoHoTen
            // 
            this.radTimTheoHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoHoTen.AutoSize = true;
            this.radTimTheoHoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoHoTen.Location = new System.Drawing.Point(742, 33);
            this.radTimTheoHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoHoTen.Name = "radTimTheoHoTen";
            this.radTimTheoHoTen.Size = new System.Drawing.Size(123, 23);
            this.radTimTheoHoTen.TabIndex = 3;
            this.radTimTheoHoTen.TabStop = true;
            this.radTimTheoHoTen.Text = "Tìm theo Tên";
            this.radTimTheoHoTen.UseVisualStyleBackColor = true;
            // 
            // radTimTheoChucVu
            // 
            this.radTimTheoChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoChucVu.AutoSize = true;
            this.radTimTheoChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoChucVu.Location = new System.Drawing.Point(742, 140);
            this.radTimTheoChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoChucVu.Name = "radTimTheoChucVu";
            this.radTimTheoChucVu.Size = new System.Drawing.Size(157, 23);
            this.radTimTheoChucVu.TabIndex = 7;
            this.radTimTheoChucVu.TabStop = true;
            this.radTimTheoChucVu.Text = "Tìm theo chức vụ";
            this.radTimTheoChucVu.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMaNhanVien
            // 
            this.radTimTheoMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoMaNhanVien.AutoSize = true;
            this.radTimTheoMaNhanVien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoMaNhanVien.Location = new System.Drawing.Point(368, 33);
            this.radTimTheoMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoMaNhanVien.Name = "radTimTheoMaNhanVien";
            this.radTimTheoMaNhanVien.Size = new System.Drawing.Size(205, 23);
            this.radTimTheoMaNhanVien.TabIndex = 1;
            this.radTimTheoMaNhanVien.TabStop = true;
            this.radTimTheoMaNhanVien.Text = "Tìm theo mã nhân viên";
            this.radTimTheoMaNhanVien.UseVisualStyleBackColor = true;
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
            this.btnTimKiem.TabIndex = 114;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.radTimTheoGioiTinh);
            this.Controls.Add(this.radTimTheoHoTen);
            this.Controls.Add(this.radTimTheoChucVu);
            this.Controls.Add(this.radTimTheoMaNhanVien);
            this.Controls.Add(this.cboTimTheoChucVu);
            this.Controls.Add(this.cboTimTheoGioiTinh);
            this.Controls.Add(this.txtTimTheoHoTen);
            this.Controls.Add(this.txtTimTheoMaNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lblTimNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimNhanVien;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.ComboBox cboTimTheoChucVu;
        private System.Windows.Forms.ComboBox cboTimTheoGioiTinh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTheoHoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTheoMaNhanVien;
        private System.Windows.Forms.RadioButton radTimTheoGioiTinh;
        private System.Windows.Forms.RadioButton radTimTheoHoTen;
        private System.Windows.Forms.RadioButton radTimTheoChucVu;
        private System.Windows.Forms.RadioButton radTimTheoMaNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
    }
}