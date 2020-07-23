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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //kiem tra co nhap khoang trang khong
            string tendangnhap = txtTenDangNhap.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            if (tendangnhap != "" && matkhau != "")
            {
                //Kiem tra du lieu voi csdl de dang nhap vi da nhap du thong tin
                //mo form
                frmMain formMain = new frmMain();
                formMain.Show();
                Program.OpenDetailFormOnClose = true;
                this.Close();
            }
            else
            {
                //Khong cho dang nhap vi ten dang nhap, mat khau trong
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.isPassword = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.isPassword = false;
            }
        }

    }
}
