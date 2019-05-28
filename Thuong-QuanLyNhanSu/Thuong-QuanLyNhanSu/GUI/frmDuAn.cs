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
    public partial class frmDuAn : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaDA.Clear();
            txtTenDA.Clear();
            txtDiaDiem.Clear();
            txtMaPB.Clear();
            txtTongSoGio.Clear();
        }

        public frmDuAn()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 800);
        }

        private void frmDuAn_Load(object sender, EventArgs e)
        {
            dgvDuAn.DataSource = db.DUANs.ToList();
        }

        private void frmDuAn_FormClosed(object sender, FormClosedEventArgs e)
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
            dgvDuAn.DataSource = db.DUANs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DUAN da = new DUAN();
                //gán giá trị từ textbox vào các biến

                da.MaDuAn = int.Parse(txtMaDA.Text);
                da.TenDuAn = txtTenDA.Text;
                da.DiaDiem = txtDiaDiem.Text;
                da.MaPhongBan = int.Parse(txtMaPB.Text);
                da.TongSoGio = int.Parse(txtTongSoGio.Text);

                //thêm hoặc apdate bản ghi dự án
                db.DUANs.AddOrUpdate(da);

                //lưu thay đổi
                db.SaveChanges();
                MessageBox.Show("Thêm dữ liệu thành công!");
                btnLamMoi_Click(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Một hoặc nhiều thông tin đang trống!\nXin hãy kiểm tra lại.");
                return;
            }
        }

        private void dgvDuAn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null
                
                if (dgvDuAn.Rows[e.RowIndex].Cells["MaDuAn"].Value != null)
                {
                    txtMaDA.Text = dgvDuAn.Rows[e.RowIndex].Cells["MaDuAn"].Value.ToString();
                }
                if (dgvDuAn.Rows[e.RowIndex].Cells["TenDuAn"].Value != null)
                {
                    txtTenDA.Text = dgvDuAn.Rows[e.RowIndex].Cells["TenDuAn"].Value.ToString();
                }
                if (dgvDuAn.Rows[e.RowIndex].Cells["DiaDiem"].Value != null)
                {
                    txtDiaDiem.Text = dgvDuAn.Rows[e.RowIndex].Cells["DiaDiem"].Value.ToString();
                }
                if (dgvDuAn.Rows[e.RowIndex].Cells["MaPhongBan"].Value != null)
                {
                    txtMaPB.Text = dgvDuAn.Rows[e.RowIndex].Cells["MaPhongBan"].Value.ToString();
                }
                if (dgvDuAn.Rows[e.RowIndex].Cells["TongSoGio"].Value != null)
                {
                    txtTongSoGio.Text = dgvDuAn.Rows[e.RowIndex].Cells["TongSoGio"].Value.ToString();
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
                // muốn xóa của dự án này thì phải xóa các bản ghi dùng MaDuAn làm khóa chính (trong bảng khác)
                // và thay đổi các bản ghi dùng MaDuAn làm khóa phụ (có thể update cho nó = null, hoặc nếu xóa luôn nếu thích)

                // trong bảng DUAN thì có bảng PHANCONG lấy MaDuAn làm khóa phụ
                // có thể sửa thành null các bản ghi dùng MaDuAn, hoặc xóa cmn đi nếu cần

                //đang lỗi
                db.Database.ExecuteSqlCommand("UPDATE PHANCONG SET MaDuAn = NULL WHERE MaDuAn = " + txtMaDA.Text);
                db.Database.ExecuteSqlCommand("UPDATE DUAN SET MaDuAn = NULL WHERE MaDuAn = " + txtMaDA.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }
    }
}
