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
    public partial class frmBaoHiemXaHoi : Form
    {
        QuanLyNhanVien db = new QuanLyNhanVien();
        public void Clear()
        {
            txtMaBHXH.Clear();
            txtTrangThai.Clear();
            txtSoTien.Clear();
            txtMaNV.Clear();
        }

        public frmBaoHiemXaHoi()
        {
            InitializeComponent();
            //định dạng size mặc định
            this.MinimumSize = new Size(1200, 800);
        }

        private void frmBaoHiemXaHoi_Load(object sender, EventArgs e)
        {
            dgvBHXH.DataSource = db.BAOHIEMXAHOIs.ToList();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmBaoHiemXaHoi_FormClosed(object sender, FormClosedEventArgs e)
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
            dgvBHXH.DataSource = db.BAOHIEMXAHOIs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaBHXH.Text = (db.Database.SqlQuery<int>("SELECT TOP 1 MAX(MaBHXH) FROM BAOHIEMXAHOI").SingleOrDefault() + 1).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //bấm nút lưu thì nó sẽ lưu bản ghe
            try
            {
                BAOHIEMXAHOI yt = new BAOHIEMXAHOI();

                //gán giá trị từ textbox vào các biến
                yt.MaBHXH = int.Parse(txtMaBHXH.Text);
                yt.TrangThai = int.Parse(txtTrangThai.Text);
                yt.SoTien = int.Parse(txtSoTien.Text);
                yt.MaNhanVien = int.Parse(txtMaNV.Text);

                //thêm hoặc update bản ghi của bảng bảo hiểm xã hội

                db.BAOHIEMXAHOIs.AddOrUpdate(yt);

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

                if (dgvBHXH.Rows[e.RowIndex].Cells["MaBHXH"].Value != null)
                {
                    txtMaBHXH.Text = dgvBHXH.Rows[e.RowIndex].Cells["MaBHXH"].Value.ToString();
                }
                if (dgvBHXH.Rows[e.RowIndex].Cells["TrangThai"].Value != null)
                {
                    txtTrangThai.Text = dgvBHXH.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                }
                if (dgvBHXH.Rows[e.RowIndex].Cells["SoTien"].Value != null)
                {
                    txtSoTien.Text = dgvBHXH.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
                }
                if (dgvBHXH.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
                {
                    txtMaNV.Text = dgvBHXH.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
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
                db.Database.ExecuteSqlCommand("DELETE BAOHIEMXAHOI WHERE MaBHXH = " + txtMaBHXH.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }

        private bool Find(string strSearch)
        {
            for (int j = 0; j < this.dgvBHXH.ColumnCount; ++j)
            {
                for (int i = 0; i < this.dgvBHXH.RowCount; ++i)
                {
                    try
                    {
                        if (this.dgvBHXH.Rows[i].Cells[j].Value.ToString() == strSearch)
                        {
                            //dataGridView1.Rows[row].Selected = true;
                            this.dgvBHXH.Rows[i].DefaultCellStyle.BackColor = Color.Red;
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
