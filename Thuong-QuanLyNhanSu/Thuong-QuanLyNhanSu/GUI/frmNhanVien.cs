using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuong_QuanLyNhanSu.Models;
using System.Data.Entity.Migrations;

namespace QuanLyNhanSu.GUI
{
    public partial class frmNhanVien : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtMaNGS.Clear();
            txtMaPB.Clear();
            cbxGioiTinh.Focus();
        }
        public frmNhanVien()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 800);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.dgvNhanVien.DataSource = db.NHANVIENs.ToList();
        }

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainNV frm = new frmMainNV();
            frm.Show();
            this.Hide();
        }
    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMainNV frm = new frmMainNV();
            frm.Show();
            this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = db.NHANVIENs.ToList();
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
                NHANVIEN nv = new NHANVIEN();

                //gán giá trị từ textbox vào các biến
                nv.MaNhanVien = int.Parse(txtMaNV.Text);
                nv.TenNhanVien = txtTenNV.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.GioiTinh = cbxGioiTinh.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.MaNguoiGiamSat = int.Parse(txtMaNGS.Text);
                nv.MaPhongBan = int.Parse(txtMaPB.Text);

                //thêm hoặc update bản ghi của nhân viên

                db.NHANVIENs.AddOrUpdate(nv);

                //lưu thay đổi
                db.SaveChanges();
                MessageBox.Show("Thêm dữ liệu nhân viên thành công!");

                btnLamMoi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Một hoặc nhiều thông tin đang để trống!\nXin hãy kiểm tra lại");
                return;
            }
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null
                if (dgvNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
                {
                    txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["TenNhanVien"].Value != null)
                {
                    txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value != null)
                {
                    txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value != null)
                {
                    cbxGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["MaNguoiGiamSat"].Value != null)
                {
                    txtMaNGS.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNguoiGiamSat"].Value.ToString();
                }
                if (dgvNhanVien.Rows[e.RowIndex].Cells["MaPhongBan"].Value != null)
                {
                    txtMaPB.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaPhongBan"].Value.ToString();
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
                // muốn xóa thằng nhân viên này thì phải xóa các bản ghi dùng mã nhân viên làm khóa chính (trong bảng khác)
                // và thay đổi các bản ghi dùng mã nhân viên làm khóa phụ (có thể update cho nó = null, hoặc nếu xóa luôn nếu thích)

                // trong bảng nhân viên thì có bảng hóa đơn + tài khoản lấy mã nhân viên làm khóa phụ
                // có thể sửa thành null các bản ghi dùng mã nhân viên, hoặc xóa cmn đi nếu cần

                db.Database.ExecuteSqlCommand("UPDATE BAOHIEMXAHOI SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE BAOHIEMYTE SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE NHANVIEN_CONGTY SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE PHANCONG SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE THANNHAN SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }
    }
}