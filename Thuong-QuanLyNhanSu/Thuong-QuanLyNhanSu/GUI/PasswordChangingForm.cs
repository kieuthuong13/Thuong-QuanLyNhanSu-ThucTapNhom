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
    public partial class PasswordChangingForm : Form
    {
        private MyStruct.TAIKHOAN MyAccount = new MyStruct.TAIKHOAN();
        public PasswordChangingForm(MyStruct.TAIKHOAN _Account)
        {
            InitializeComponent();
            MyAccount = _Account;
            if (string.IsNullOrWhiteSpace(MyAccount.ACCESS))
            {
                MyAccount.ACCESS = null;
            }

            this.UsernameTextbox.Text = MyAccount.ACCOUNT;
            this.UsernameTextbox.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            GUI.frmLogin.fmain.Show();
            this.Dispose();
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string messageError = "Lỗi:\n\n";
            bool Accept = false;
            // Cập nhật mất khẩu
            if (!string.Equals(MyAccount.PASSWORD, this.OldPasswordTextbox.Text))
            {
                Accept = false;
                messageError += "- Mật khẩu cũ không đúng\n";
            }
            else
                Accept = true;
            if (!string.Equals(this.NewPasswordTextbox.Text, this.RepeatNewPasswordTextbox.Text))
            {
                Accept = false;
                messageError += "- Nhập lại mật khẩu sai!\n";
            }

            // thông báo
            if (Accept)
            {
                MyAccount.PASSWORD = this.NewPasswordTextbox.Text;
                if (GUI.Update.TAIKHOAN.UpdateOneRecord(MyAccount))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    PasswordChangingForm_FormClosing(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể đổi mật khẩu!\n\nMã lỗi 101x0000003");
                }
            }
            else
            {
                MessageBox.Show(messageError);
            }
        }

        private void PasswordChangingForm_FormClosing(object sender, EventArgs e)
        {
            GUI.frmLogin.fmain.Show();
            this.Dispose();
        }

        private void OldPasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.NewPasswordTextbox.Focus();
                this.NewPasswordTextbox.SelectAll();

                NewPasswordTextbox_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
            return;
        }

        private void NewPasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.RepeatNewPasswordTextbox.Focus();
                this.RepeatNewPasswordTextbox.SelectAll();

                RepeatNewPasswordTextbox_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
            return;
        }

        private void RepeatNewPasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.AcceptButton_Click(sender, e);
            }
            return;
        }

        private void PasswordChangingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
