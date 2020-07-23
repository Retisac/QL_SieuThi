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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaNhanVien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.radGioiTinh = new System.Windows.Forms.RadioButton();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.radChucVu = new System.Windows.Forms.RadioButton();
            this.radMaNv = new System.Windows.Forms.RadioButton();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
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
            // cboChucVu
            // 
            this.cboChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChucVu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(742, 172);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(271, 34);
            this.cboChucVu.TabIndex = 8;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioiTinh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(368, 172);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(271, 34);
            this.cboGioiTinh.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtHoTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTen.HintText = "";
            this.txtHoTen.isPassword = false;
            this.txtHoTen.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtHoTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHoTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtHoTen.LineThickness = 1;
            this.txtHoTen.Location = new System.Drawing.Point(742, 61);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(271, 39);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaNhanVien.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaNhanVien.HintText = "";
            this.txtMaNhanVien.isPassword = false;
            this.txtMaNhanVien.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtMaNhanVien.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaNhanVien.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtMaNhanVien.LineThickness = 1;
            this.txtMaNhanVien.Location = new System.Drawing.Point(368, 61);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(271, 39);
            this.txtMaNhanVien.TabIndex = 2;
            this.txtMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // radGioiTinh
            // 
            this.radGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGioiTinh.AutoSize = true;
            this.radGioiTinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGioiTinh.Location = new System.Drawing.Point(368, 140);
            this.radGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.radGioiTinh.Name = "radGioiTinh";
            this.radGioiTinh.Size = new System.Drawing.Size(157, 23);
            this.radGioiTinh.TabIndex = 5;
            this.radGioiTinh.TabStop = true;
            this.radGioiTinh.Text = "Tìm theo giới tính";
            this.radGioiTinh.UseVisualStyleBackColor = true;
            // 
            // radHoTen
            // 
            this.radHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radHoTen.AutoSize = true;
            this.radHoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHoTen.Location = new System.Drawing.Point(742, 33);
            this.radHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(123, 23);
            this.radHoTen.TabIndex = 3;
            this.radHoTen.TabStop = true;
            this.radHoTen.Text = "Tìm theo Tên";
            this.radHoTen.UseVisualStyleBackColor = true;
            // 
            // radChucVu
            // 
            this.radChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radChucVu.AutoSize = true;
            this.radChucVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChucVu.Location = new System.Drawing.Point(742, 140);
            this.radChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.radChucVu.Name = "radChucVu";
            this.radChucVu.Size = new System.Drawing.Size(157, 23);
            this.radChucVu.TabIndex = 7;
            this.radChucVu.TabStop = true;
            this.radChucVu.Text = "Tìm theo chức vụ";
            this.radChucVu.UseVisualStyleBackColor = true;
            // 
            // radMaNv
            // 
            this.radMaNv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radMaNv.AutoSize = true;
            this.radMaNv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaNv.Location = new System.Drawing.Point(368, 33);
            this.radMaNv.Margin = new System.Windows.Forms.Padding(2);
            this.radMaNv.Name = "radMaNv";
            this.radMaNv.Size = new System.Drawing.Size(205, 23);
            this.radMaNv.TabIndex = 1;
            this.radMaNv.TabStop = true;
            this.radMaNv.Text = "Tìm theo mã nhân viên";
            this.radMaNv.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.radGioiTinh);
            this.Controls.Add(this.radHoTen);
            this.Controls.Add(this.radChucVu);
            this.Controls.Add(this.radMaNv);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
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
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaNhanVien;
        private System.Windows.Forms.RadioButton radGioiTinh;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.RadioButton radChucVu;
        private System.Windows.Forms.RadioButton radMaNv;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
    }
}