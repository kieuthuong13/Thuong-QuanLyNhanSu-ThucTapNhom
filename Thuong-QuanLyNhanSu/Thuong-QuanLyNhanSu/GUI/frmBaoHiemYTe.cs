﻿using System;
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

namespace QuanLyNhanSu.GUI
{
    public partial class frmBaoHiemYTe : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaBHYT.Clear();
            txtNoiDK.Clear();
            txtSoTien.Clear();
            dptHieuLuc.Focus();
            txtMaNV.Clear();
        }
        public frmBaoHiemYTe()
        {
            InitializeComponent();
            //định dạng size mặc định
            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 800);
        }

        private void frmBaoHiemYTe_Load(object sender, EventArgs e)
        {
            dgvBHYTe.DataSource = db.BAOHIEMYTEs.ToList();
        }

        private void frmBaoHiemYTe_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainNV fm = new frmMainNV();
            fm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMainNV fm = new frmMainNV();
            fm.Show();
            this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvBHYTe.DataSource = db.BAOHIEMYTEs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //bấm nút lưu thì nó sẽ lưu bản ghe
            try
            {
                BAOHIEMYTE yt = new BAOHIEMYTE();

                //gán giá trị từ textbox vào các biến
                yt.MaBHYT = int.Parse(txtMaBHYT.Text);
                yt.NoiDangKyKCB = txtNoiDK.Text;
                yt.SoTien = int.Parse(txtSoTien.Text);
                yt.HieuLuc = dptHieuLuc.Value;
                yt.MaNhanVien = int.Parse(txtMaNV.Text);

                //thêm hoặc update bản ghi của bảng bảo hiểm y tế

                db.BAOHIEMYTEs.AddOrUpdate(yt);

                //lưu thay đổi
                db.SaveChanges();
                MessageBox.Show("Thêm dữ liệu thân nhân thành công!");

                btnLamMoi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Một hoặc nhiều thông tin đang để trống!\nXin hãy kiểm tra lại");
                return;
            }
        }

        private void dgvBHYTe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null

                if (dgvBHYTe.Rows[e.RowIndex].Cells["MaBHYT"].Value != null)
                {
                    txtMaBHYT.Text = dgvBHYTe.Rows[e.RowIndex].Cells["MaBHYT"].Value.ToString();
                }
                if (dgvBHYTe.Rows[e.RowIndex].Cells["NoiDangKyKCB"].Value != null)
                {
                    txtNoiDK.Text = dgvBHYTe.Rows[e.RowIndex].Cells["NoiDangKyKCB"].Value.ToString();
                }
                if (dgvBHYTe.Rows[e.RowIndex].Cells["SoTien"].Value != null)
                {
                    txtSoTien.Text = dgvBHYTe.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
                }
                if (dgvBHYTe.Rows[e.RowIndex].Cells["HieuLuc"].Value != null)
                {
                    dptHieuLuc.Value = DateTime.Parse(dgvBHYTe.Rows[e.RowIndex].Cells["HieuLuc"].Value.ToString());
                }
                if (dgvBHYTe.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
                {
                    txtMaNV.Text = dgvBHYTe.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                }
            
            }
            catch (Exception)
            {
                //trường họp không load được -> lầm tróng tất cả các ô
                Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //hỏi lại có chắc chắn muốn xóa k
            if (DialogResult.OK == MessageBox.Show("Xóa bản ghi hiện tại sẽ làm thay đổi hoặc xóa các bản ghi liên kết!\nBạn có muốn tiếp tục không?"
                , "Cảnh báo xóa!", MessageBoxButtons.OKCancel))
            {
                db.Database.ExecuteSqlCommand("UPDATE BAOHIEMYTE SET MaBHYT = NULL WHERE MaBHYT = " + txtMaBHYT.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }
    }
}