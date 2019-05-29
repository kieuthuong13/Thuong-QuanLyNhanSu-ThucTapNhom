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
    public partial class frmPhanCong : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaNV.Clear();
            txtMaDA.Clear();
            txtSoGio.Clear();
        }

        public frmPhanCong()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            this.dgvPhanCong.DataSource = db.PHANCONGs.ToList();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPhanCong_FormClosed(object sender, FormClosedEventArgs e)
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
            dgvPhanCong.DataSource = db.PHANCONGs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                PHANCONG pc = new PHANCONG();

                //gán giá trị từ textbox vào các biến

                pc.MaNhanVien = int.Parse(txtMaNV.Text);
                pc.MaDuAn = int.Parse(txtMaDA.Text);
                pc.SoGioThamGia = int.Parse(txtSoGio.Text);

                //thêm hoặc update bản ghi của bảng phân công

                db.PHANCONGs.AddOrUpdate(pc);

                //lưu thay đổi
                db.SaveChanges();
                MessageBox.Show("Thêm dữ liệu thành công!");

                btnLamMoi_Click(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Một hoặc nhiều thông tin đang để trống.\nXin kiểm tra lại.");
                return;
            }
        }

        private void dgvPhanCong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                //xét dòng vừa click vào, hoặc vừa chọn vào:
                //cái này gán vào textboc
                //if để xét nếu ô = null
                if (dgvPhanCong.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
                {
                    txtMaNV.Text = dgvPhanCong.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                }
                if (dgvPhanCong.Rows[e.RowIndex].Cells["MaDuAn"].Value != null)
                {
                    txtMaDA.Text = dgvPhanCong.Rows[e.RowIndex].Cells["MaDuAn"].Value.ToString();
                }
                if (dgvPhanCong.Rows[e.RowIndex].Cells["SoGioThamGia"].Value != null)
                {
                    txtSoGio.Text = dgvPhanCong.Rows[e.RowIndex].Cells["SoGioThamGia"].Value.ToString();
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
                
                //đang lỗi
                db.Database.ExecuteSqlCommand("DELETE PHANCONG WHERE MaNhanVien =" + txtMaNV.Text + " AND MaDuAn = " + txtMaDA.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }
    }
}
