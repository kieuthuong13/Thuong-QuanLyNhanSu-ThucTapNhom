using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuong_QuanLyNhanSu.Models;

namespace QuanLyNhanSu.GUI
{
    public partial class frmLogin : Form
    {
        public static GUI.frmMainNV fmain;
        private QuanLyNhanVien db = new QuanLyNhanVien();

        public frmLogin()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        public void ClearInput()
        {
            textBoxPass.Text = "";
            textBoxUser.Focus();
            textBoxUser.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxUser.Text) || string.IsNullOrEmpty(this.textBoxPass.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống, xin hãy kiểm tra lại.");
                return;
            }
            string tendangnhap = db.Database.SqlQuery<string>("SELECT TOP 1 TaiKhoan FROM TAIKHOAN WHERE TaiKhoan = N'" + textBoxUser.Text + "' AND PassWord = N'" + textBoxPass.Text + "'").SingleOrDefault();

            // Đăng nhập thành công thì nhảy vào
            if (this.textBoxPass.Text == tendangnhap)
            {
                // MessageBox.Show("Đăng nhập thành công.");

                // Phân quyền

                this.Hide();

                fmain = new frmMainNV();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxPass.Focus();
                this.textBoxPass.SelectAll();
                textBoxPass_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
