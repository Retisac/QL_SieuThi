namespace QL_SieuThi
{
    partial class frmTimTheoLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radTimTheoLoai = new System.Windows.Forms.RadioButton();
            this.radTimTheoTrangThai = new System.Windows.Forms.RadioButton();
            this.radTimTheoMaSanPham = new System.Windows.Forms.RadioButton();
            this.cboTimTheoTrangThai = new System.Windows.Forms.ComboBox();
            this.cboTimTheoLoai = new System.Windows.Forms.ComboBox();
            this.txtTimTheoMaSanPham = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTimSanPham = new System.Windows.Forms.Label();
            this.dgvKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhasanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(473, 251);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(348, 45);
            this.btnTimKiem.TabIndex = 152;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radTimTheoLoai
            // 
            this.radTimTheoLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoLoai.AutoSize = true;
            this.radTimTheoLoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoLoai.Location = new System.Drawing.Point(508, 131);
            this.radTimTheoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoLoai.Name = "radTimTheoLoai";
            this.radTimTheoLoai.Size = new System.Drawing.Size(123, 23);
            this.radTimTheoLoai.TabIndex = 147;
            this.radTimTheoLoai.TabStop = true;
            this.radTimTheoLoai.Text = "Tìm theo loại";
            this.radTimTheoLoai.UseVisualStyleBackColor = true;
            // 
            // radTimTheoTrangThai
            // 
            this.radTimTheoTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoTrangThai.AutoSize = true;
            this.radTimTheoTrangThai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoTrangThai.Location = new System.Drawing.Point(882, 131);
            this.radTimTheoTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoTrangThai.Name = "radTimTheoTrangThai";
            this.radTimTheoTrangThai.Size = new System.Drawing.Size(168, 23);
            this.radTimTheoTrangThai.TabIndex = 149;
            this.radTimTheoTrangThai.TabStop = true;
            this.radTimTheoTrangThai.Text = "Tìm theo trạng thái";
            this.radTimTheoTrangThai.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMaSanPham
            // 
            this.radTimTheoMaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoMaSanPham.AutoSize = true;
            this.radTimTheoMaSanPham.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoMaSanPham.Location = new System.Drawing.Point(135, 131);
            this.radTimTheoMaSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoMaSanPham.Name = "radTimTheoMaSanPham";
            this.radTimTheoMaSanPham.Size = new System.Drawing.Size(202, 23);
            this.radTimTheoMaSanPham.TabIndex = 143;
            this.radTimTheoMaSanPham.TabStop = true;
            this.radTimTheoMaSanPham.Text = "Tìm theo mã sản phẩm";
            this.radTimTheoMaSanPham.UseVisualStyleBackColor = true;
            // 
            // cboTimTheoTrangThai
            // 
            this.cboTimTheoTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoTrangThai.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoTrangThai.FormattingEnabled = true;
            this.cboTimTheoTrangThai.Location = new System.Drawing.Point(882, 163);
            this.cboTimTheoTrangThai.Name = "cboTimTheoTrangThai";
            this.cboTimTheoTrangThai.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoTrangThai.TabIndex = 150;
            // 
            // cboTimTheoLoai
            // 
            this.cboTimTheoLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimTheoLoai.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimTheoLoai.FormattingEnabled = true;
            this.cboTimTheoLoai.Location = new System.Drawing.Point(508, 163);
            this.cboTimTheoLoai.Name = "cboTimTheoLoai";
            this.cboTimTheoLoai.Size = new System.Drawing.Size(271, 34);
            this.cboTimTheoLoai.TabIndex = 148;
            // 
            // txtTimTheoMaSanPham
            // 
            this.txtTimTheoMaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTheoMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTheoMaSanPham.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTheoMaSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTimTheoMaSanPham.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTheoMaSanPham.HintText = "";
            this.txtTimTheoMaSanPham.isPassword = false;
            this.txtTimTheoMaSanPham.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtTimTheoMaSanPham.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTimTheoMaSanPham.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTheoMaSanPham.LineThickness = 1;
            this.txtTimTheoMaSanPham.Location = new System.Drawing.Point(135, 157);
            this.txtTimTheoMaSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimTheoMaSanPham.Name = "txtTimTheoMaSanPham";
            this.txtTimTheoMaSanPham.Size = new System.Drawing.Size(271, 39);
            this.txtTimTheoMaSanPham.TabIndex = 144;
            this.txtTimTheoMaSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTimSanPham
            // 
            this.lblTimSanPham.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimSanPham.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTimSanPham.Location = new System.Drawing.Point(28, 21);
            this.lblTimSanPham.Name = "lblTimSanPham";
            this.lblTimSanPham.Size = new System.Drawing.Size(203, 37);
            this.lblTimSanPham.TabIndex = 151;
            this.lblTimSanPham.Text = "Tìm sản phẩm";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvKhachHang.ColumnHeadersHeight = 50;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensanpham,
            this.loaisanpham,
            this.nhasanxuat,
            this.soluong,
            this.dongia,
            this.trangthai});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvKhachHang.DoubleBuffered = true;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.DarkGray;
            this.dgvKhachHang.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
            this.dgvKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.Location = new System.Drawing.Point(7, 339);
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
            this.dgvKhachHang.TabIndex = 166;
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
            // frmTimTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 645);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.radTimTheoLoai);
            this.Controls.Add(this.radTimTheoTrangThai);
            this.Controls.Add(this.radTimTheoMaSanPham);
            this.Controls.Add(this.cboTimTheoTrangThai);
            this.Controls.Add(this.cboTimTheoLoai);
            this.Controls.Add(this.txtTimTheoMaSanPham);
            this.Controls.Add(this.lblTimSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimTheoLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.RadioButton radTimTheoLoai;
        private System.Windows.Forms.RadioButton radTimTheoTrangThai;
        private System.Windows.Forms.RadioButton radTimTheoMaSanPham;
        private System.Windows.Forms.ComboBox cboTimTheoTrangThai;
        private System.Windows.Forms.ComboBox cboTimTheoLoai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTheoMaSanPham;
        private System.Windows.Forms.Label lblTimSanPham;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhasanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}