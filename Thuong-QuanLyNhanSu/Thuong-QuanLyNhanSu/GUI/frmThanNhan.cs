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
using System.Data.Entity.Migrations;

namespace Thuong_QuanLyNhanSu.GUI
{
    public partial class frmThanNhan: Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaNV.Clear();
            txtTenTN.Clear();
            txtQuanHe.Clear();
            dtpNgaySinh.Focus();
            cbxGioiTinh.Focus();
        }
        public frmThanNhan()
        {
            InitializeComponent();
            //định dạng size mặc định
            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 800);
        }

        private void frmThanNhan_Load(object sender, EventArgs e)
        {
            dgvThanNhan.DataSource = db.THANNHANs.ToList();
        }

        private void frmThanNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
