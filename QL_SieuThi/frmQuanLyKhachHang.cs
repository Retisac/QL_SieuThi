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

            cboGioiTinh.SelectedIndex = 0;
            //khi nao load csdl len cboChucVu thi mo comment dong duoi
            //cboChucVu.SelectedIndex = 0;
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
            string makh = txtMaKhachHang.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();
            string dienthoai = txtDienThoai.Text.Trim();
            //kiem tra dieu kien nhap
            if (makh != "" && hoten != "" && diachi != "" && dienthoai != "")
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
