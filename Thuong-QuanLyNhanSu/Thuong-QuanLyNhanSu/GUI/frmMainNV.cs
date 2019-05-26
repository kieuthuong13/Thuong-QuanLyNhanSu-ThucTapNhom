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
    public partial class frmMainNV : Form
    {
        public static GUI.PasswordChangingForm fchangepass;
        private MyStruct.TAIKHOAN myAccount = new MyStruct.TAIKHOAN();

        public frmMainNV()
        {
            InitializeComponent();
            // this.MaximizeBox = this.MinimizeBox = false;
            this.MinimumSize = new Size(1066, 554);

            LbDangXuat.Location = new Point(this.Size.Width - 85, LbDangXuat.Location.Y);
            LbTroGiup.Location = new Point(this.Size.Width - 180, LbTroGiup.Location.Y);
          
        }

        private void LbNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmNhanVien t = new frmNhanVien();
            t.Show();
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmNhanVien t = new frmNhanVien();
            t.Show();
        }

        private void LbPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmPhongBan t = new frmPhongBan();
            t.Show();
        }

        private void picPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmPhongBan t = new frmPhongBan();
            t.Show();
        }

        private void LbDuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmDuAn t = new frmDuAn();
            t.Show();
        }

        private void picDuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmDuAn t = new frmDuAn();
            t.Show();
        }

        private void picPhanCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmPhanCong t = new frmPhanCong();
            t.Show();
        }

        private void LbPhanCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmPhanCong t = new frmPhanCong();
            t.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LbTroGiup_Click(object sender, EventArgs e)
        {
            GUI.frmMainNV.fchangepass = new PasswordChangingForm(myAccount);
            fchangepass.Show();
            this.Hide();
        }

        private void LbDangXuat_Click(object sender, EventArgs e)
        {
            frmMainNV_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
        }

        private void frmMainNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.flogin.Show();
            Program.flogin.ClearInput();
            this.Dispose();
        }

        private void frmMainNV_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(this.Width, groupBox1.Size.Height);
            groupBox2.Size = new Size(groupBox2.Size.Width,this.Height);
            LbDangXuat.Location = new Point(this.Size.Width - 85, LbDangXuat.Location.Y);
            LbTroGiup.Location = new Point(this.Size.Width - 180, LbTroGiup.Location.Y);
            pictureBox1.Size = new Size(this.Size.Width - 110, this.Size.Height - 80);
        }

        private void picCongTy_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmPhanCong t = new frmPhanCong();
            t.Show();
        }
    }
}
