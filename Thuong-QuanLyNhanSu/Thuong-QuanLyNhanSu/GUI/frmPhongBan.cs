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
    public partial class frmPhongBan : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtDiaDiem.Clear();
            txtMaTP.Clear();
        }
        public frmPhongBan()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
        }
     
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            this.dgvPhongBan.DataSource = db.PHONGBANs.ToList();
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void frmPhongBan_FormClosed(object sender, FormClosedEventArgs e)
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
            dgvPhongBan.DataSource = db.PHONGBANs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaPB.Text = (db.Database.SqlQuery<int>("SELECT TOP 1 MAX(MaPhongBan) FROM PHONGBAN").SingleOrDefault() + 1).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGBAN pb = new PHONGBAN();

                //gán giá trị từ textbox vào các biến
                pb.MaPhongBan = int.Parse(txtMaPB.Text);
                pb.TenPhongBan = txtTenPB.Text;
                pb.NgayNhanChuc = dtpNgayNC.Value;
                pb.DiaDiem = txtDiaDiem.Text;
                pb.MaTruongPhong = int.Parse(txtMaTP.Text);

                //thêm hoặc update bản ghi của phòng ban

                db.PHONGBANs.AddOrUpdate(pb);

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

        private void dgvPhongBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null
                if (dgvPhongBan.Rows[e.RowIndex].Cells["MaPhongBan"].Value != null)
                {
                    txtMaPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["MaPhongBan"].Value.ToString();
                }
                if (dgvPhongBan.Rows[e.RowIndex].Cells["TenPhongBan"].Value != null)
                {
                    txtTenPB.Text = dgvPhongBan.Rows[e.RowIndex].Cells["TenPhongBan"].Value.ToString();
                }
                if (dgvPhongBan.Rows[e.RowIndex].Cells["MaTruongPhong"].Value != null)
                {
                    txtMaTP.Text = dgvPhongBan.Rows[e.RowIndex].Cells["MaTruongPhong"].Value.ToString();
                }
                if (dgvPhongBan.Rows[e.RowIndex].Cells["DiaDiem"].Value != null)
                {
                    txtDiaDiem.Text = dgvPhongBan.Rows[e.RowIndex].Cells["DiaDiem"].Value.ToString();
                }
                if (dgvPhongBan.Rows[e.RowIndex].Cells["NgayNhanChuc"].Value != null)
                {
                    dtpNgayNC.Value = DateTime.Parse(dgvPhongBan.Rows[e.RowIndex].Cells["NgayNhanChuc"].Value.ToString());
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
                // muốn xóa bản ghi phòng ban này thì phải xóa các bản ghi dùng mã phòng ban làm khóa chính (trong bảng khác)
                // và thay đổi các bản ghi dùng mã phòng ban làm khóa phụ (có thể update cho nó = null, hoặc nếu xóa luôn nếu thích)

                // trong bảng phòng ban thì có bảng NHANVIEN + DUAN lấy mã phòng ban làm khóa phụ
                // có thể sửa thành null các bản ghi dùng mã mã phòng ban, hoặc xóa cmn đi nếu cần

                db.Database.ExecuteSqlCommand("UPDATE NHANVIEN SET MaPhongBan = NULL WHERE MaPhongBan = " + txtMaPB.Text);
                db.Database.ExecuteSqlCommand("UPDATE DUAN SET MaPhongBan = NULL WHERE MaPhongBan = " + txtMaPB.Text);
                db.Database.ExecuteSqlCommand("DELETE PHONGBAN WHERE MaPhongBan = " + txtMaPB.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }

        private bool Find(string strSearch)
        {
            for (int j = 0; j < this.dgvPhongBan.ColumnCount; ++j)
            {
                for (int i = 0; i < this.dgvPhongBan.RowCount; ++i)
                {
                    try
                    {
                        if (this.dgvPhongBan.Rows[i].Cells[j].Value.ToString() == strSearch)
                        {
                            //dataGridView1.Rows[row].Selected = true;
                            this.dgvPhongBan.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            return true;
                        }
                        if (3 <= j && j <= 7)
                        {
                            j = 7;
                            break;
                        }
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
            return false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtTimKiem.Text))
            {
                Find(this.txtTimKiem.Text);
            }
        }
    }
}
