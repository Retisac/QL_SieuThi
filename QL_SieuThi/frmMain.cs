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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //tao form trang chu
            frmTaiKhoanCuaToi f = new frmTaiKhoanCuaToi();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        
        //su kien re chuot vao imgbtnDong
        private void imgbtnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgbtnDong_MouseEnter(object sender, EventArgs e)
        {
            imgbtnDong.BackColor = Color.Red;
        }

        private void imgbtnDong_MouseLeave(object sender, EventArgs e)
        {
            imgbtnDong.BackColor = Color.WhiteSmoke;
        }

        //su kien re chuot vao imgbtnThuNho
        private void imgbtnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgbtnThuNho_MouseEnter(object sender, EventArgs e)
        {
            imgbtnThuNho.BackColor = Color.Gray;
        }

        private void imgbtnThuNho_MouseLeave(object sender, EventArgs e)
        {
            imgbtnThuNho.BackColor = Color.WhiteSmoke;
        }

        private void ToolStripMenuItemTrangChu_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmTaiKhoanCuaToi
            frmTaiKhoanCuaToi f = new frmTaiKhoanCuaToi();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnTaiKhoanDangDung_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmTaiKhoanCuaToi
            frmTaiKhoanCuaToi f = new frmTaiKhoanCuaToi();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmTimKiemNhanVien f = new frmTimKiemNhanVien();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmQuanLyKhachHang f = new frmQuanLyKhachHang();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void tìmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmTimKiemKhachHang f = new frmTimKiemKhachHang();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmQuanLySanPham f = new frmQuanLySanPham();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void tìmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dong form dang chay
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            //Mo form frmQuanLyNhanVien
            frmTimTheoLoai f = new frmTimTheoLoai();
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
