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

namespace QuanLyNhanSu.GUI
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
            dgvThanNhan.DataSource = db.THANNHANs.ToList();
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
                THANNHAN tn = new THANNHAN();

                //gán giá trị từ textbox vào các biến
                tn.MaNhanVien = int.Parse(txtMaNV.Text);
                tn.TenThanNhan = txtTenTN.Text;
                tn.NgaySinh = dtpNgaySinh.Value;
                tn.GioiTinh = cbxGioiTinh.Text;
                tn.QuanHe = txtQuanHe.Text;

                //thêm hoặc update bản ghi của nhân viên

                db.THANNHANs.AddOrUpdate(tn);

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //hỏi lại có chắc chắn muốn xóa k
            if (DialogResult.OK == MessageBox.Show("Xóa bản ghi hiện tại sẽ làm thay đổi hoặc xóa các bản ghi liên kết!\nBạn có muốn tiếp tục không?"
                , "Cảnh báo xóa!", MessageBoxButtons.OKCancel))
            {
                db.Database.ExecuteSqlCommand("UPDATE NHANVIEN SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE THANNHAN SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE THANNHAN SET TenThanNhan = NULL WHERE TenThanNhan = " + txtTenTN.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }

        private void dgvThanNhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null
                if (dgvThanNhan.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
                {
                    txtMaNV.Text = dgvThanNhan.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                }
                if (dgvThanNhan.Rows[e.RowIndex].Cells["TenThanNhan"].Value != null)
                {
                    txtTenTN.Text = dgvThanNhan.Rows[e.RowIndex].Cells["TenThanNhan"].Value.ToString();
                }
                if (dgvThanNhan.Rows[e.RowIndex].Cells["GioiTinh"].Value != null)
                {
                    cbxGioiTinh.Text = dgvThanNhan.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                }
                if(dgvThanNhan.Rows[e.RowIndex].Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = DateTime.Parse(dgvThanNhan.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
                }
                if (dgvThanNhan.Rows[e.RowIndex].Cells["QuanHe"].Value != null)
                {
                    txtQuanHe.Text = dgvThanNhan.Rows[e.RowIndex].Cells["QuanHe"].Value.ToString();
                }
            }
            catch (Exception)
            {
                //trường họp không load được -> lầm tróng tất cả các ô
                Clear();
            }
        }
    }
}
