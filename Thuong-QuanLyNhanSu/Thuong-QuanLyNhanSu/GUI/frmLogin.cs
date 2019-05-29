using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmLogin : Form
    {
        public static GUI.frmMainNV fmain;

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
            MyStruct.TAIKHOAN taikhoan = GUI.Select.TAIKHOAN.GetTopOneRecord(textBoxUser.Text);

            // Đăng nhập thành công thì nhảy vào
            if (this.textBoxPass.Text == taikhoan.PASSWORD)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
