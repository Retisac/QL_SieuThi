using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_SieuThi
{
    public partial class frmTaiKhoanCuaToi : Form
    {
        public frmTaiKhoanCuaToi()
        {
            InitializeComponent();
            TrangThaiBanDau();
        }

        void TrangThaiBanDau()
        {
            txtMaNhanVien.Enabled = false;
            txtHoTen.Enabled = false;
            dtmNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtLuong.Enabled = false;
            cboChucVu.Enabled = false;

            btnChinhSua.Enabled = true;
            btnDangXuat.Enabled = true;
            btnSuaXong.Visible = false;
            btnHuy.Visible = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            txtHoTen.Enabled = true;
            dtmNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtLuong.Enabled = true;
            cboChucVu.Enabled = true;

            btnChinhSua.Enabled = false;
            btnDangXuat.Enabled = false;
            btnSuaXong.Visible = true;
            btnHuy.Visible = true;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void KiemTraNhap()
        {
            string manv = txtMaNhanVien.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string dienthoai = txtDienThoai.Text.Trim();
            string luong = txtLuong.Text.Trim();

            //kiem tra dieu kien nhap
            if (manv != "" && hoten != "" && diachi != "" && dienthoai != "" && luong!= "")
            {
                //Sua thanh cong
                btnChinhSua.Enabled = true;
                btnDangXuat.Enabled = true;
                TrangThaiBanDau();
            }
            else
            {
                //Khong cho sua that bai vi khong dien du thong tin
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaXong_Click(object sender, EventArgs e)
        {
            KiemTraNhap();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnChinhSua.Enabled = true;
            btnDangXuat.Enabled = true;
            TrangThaiBanDau();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //Ong lam giup tui cho nut dang xuat nha
        }

    }
}
