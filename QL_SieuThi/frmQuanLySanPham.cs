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
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
            TrangThaiBanDau();
        }

        void TrangThaiBanDau()
        {
            txtMaSanPham.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            cboLoaiSanPham.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            cboTrangThai.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemSuaXong.Visible = false;
            btnHuy.Visible = false;
        }

        void TrangThaiThemSua()
        {
            txtMaSanPham.Enabled = true;
            txtTenSanPham.Enabled = true;
            txtNhaSanXuat.Enabled = true;
            cboLoaiSanPham.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            cboTrangThai.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemSuaXong.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangThaiThemSua();

            cboLoaiSanPham.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangThaiThemSua();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void KiemTraNhap()
        {
            string masp = txtMaSanPham.Text.Trim();
            string tensp = txtTenSanPham.Text.Trim();
            string nhasanxuat = txtNhaSanXuat.Text.Trim();
            string soluong = txtSoLuong.Text.Trim();
            string dongia = txtDonGia.Text.Trim();
            //kiem tra dieu kien nhap
            if (masp != "" && tensp != "" && nhasanxuat != "" && soluong != "" && dongia != "")
            {
                //Them Sua thanh cong
                TrangThaiBanDau();
            }
            else
            {
                //Khong cho Them hoac Sua that bai vi khong dien du thong tin
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemSuaXong_Click(object sender, EventArgs e)
        {
            KiemTraNhap();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }
    }
}
