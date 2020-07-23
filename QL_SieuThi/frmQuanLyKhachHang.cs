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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            TrangThaiBanDau();
        }

        void TrangThaiBanDau()
        {
            txtMaKhachHang.Enabled = false;
            txtHoTen.Enabled = false;
            dtmNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            cboGioiTinh.Enabled = false;
            dtmNgayLap.Enabled = false;
            cboHoatDong.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemSuaXong.Visible = false;
            btnHuy.Visible = false;
        }

        void TrangThaiThemSua()
        {
            txtMaKhachHang.Enabled = true;
            txtHoTen.Enabled = true;
            dtmNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtmNgayLap.Enabled = true;
            cboHoatDong.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemSuaXong.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangThaiThemSua();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangThaiThemSua();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void KiemTraNhap()
        {
            // lat coi csdl lam
        }

        private void btnThemSuaXong_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }      
    }
}
