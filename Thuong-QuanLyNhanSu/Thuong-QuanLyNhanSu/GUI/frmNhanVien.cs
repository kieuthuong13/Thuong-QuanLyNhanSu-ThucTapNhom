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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
            txtLuong.Clear();
        }

        public frmNhanVien()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
        }

        #region MY FUNCTION

        #endregion

        #region MY STRUCT - CLASS
        [Table("NHANVIEN")]
        public class NHANVIEN_STRUCT
        {

            [Key]
            public int MaNhanVien { get; set; }

            [StringLength(100)]
            public string TenNhanVien { get; set; }

            public DateTime? NgaySinh { get; set; }

            [StringLength(100)]
            public string GioiTinh { get; set; }

            [StringLength(100)]
            public string DiaChi { get; set; }

            public int? MaNguoiGiamSat { get; set; }

            public int? MaPhongBan { get; set; }

            public int? Luong { get; set; }
        }
        #endregion

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
            //this.WindowState = FormWindowState.Maximized;
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
            dgvNhanVien.DataSource = db.Database.SqlQuery<NHANVIEN_STRUCT>("SELECT * FROM NHANVIEN").ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            txtMaNV.Text = (db.Database.SqlQuery<int>("SELECT TOP 1 MAX(MaNhanVien) FROM NHANVIEN").SingleOrDefault() + 1).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //bấm nút lưu thì nó sẽ lưu bản ghe
            try
            {
                NHANVIEN nv = new NHANVIEN();
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[NHANVIEN] ON");
                //gán giá trị từ textbox vào các biến
                nv.MaNhanVien = int.Parse(txtMaNV.Text);
                nv.TenNhanVien = txtTenNV.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.GioiTinh = cbxGioiTinh.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.MaNguoiGiamSat = int.Parse(txtMaNGS.Text);
                nv.MaPhongBan = int.Parse(txtMaPB.Text);
                nv.Luong = int.Parse(txtLuong.Text);

                //thêm hoặc update bản ghi của nhân viên

                db.NHANVIENs.AddOrUpdate(nv);
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF");
                //lưu thay đổi
                db.SaveChanges();
                MessageBox.Show("Thêm dữ liệu nhân viên thành công!");

                //btnLamMoi_Click(sender, e);
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
                if (dgvNhanVien.Rows[e.RowIndex].Cells["Luong"].Value != null)
                {
                    txtMaPB.Text = dgvNhanVien.Rows[e.RowIndex].Cells["Luong"].Value.ToString();
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
            //hỏi lại có chắc chắn muốn xóa hay không
            if (DialogResult.OK == MessageBox.Show("Xóa bản ghi hiện tại sẽ làm thay đổi hoặc xóa các bản ghi liên kết!\nBạn có muốn tiếp tục không?"
                , "Cảnh báo xóa!", MessageBoxButtons.OKCancel))
            {
                db.Database.ExecuteSqlCommand("UPDATE BAOHIEMYTE SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("UPDATE BAOHIEMXAHOI SET MaNhanVien = NULL WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("DELETE PHANCONG WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("DELETE THANNHAN WHERE MaNhanVien = " + txtMaNV.Text);
                db.Database.ExecuteSqlCommand("DELETE NHANVIEN WHERE MaNhanVien = " + txtMaNV.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnLamMoi_Click(sender, e);
            }
        }

        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtTenNV.Focus();
                this.dtpNgaySinh.Select();
                dtpNgaySinh_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void dtpNgaySinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dtpNgaySinh.Focus();
                this.cbxGioiTinh.Select();
                cbxGioiTinh_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void cbxGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cbxGioiTinh.Focus();
                this.txtDiaChi.Select();
                txtDiaChi_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtDiaChi.Focus();
                this.txtMaNGS.Select();
                txtMaNGS_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void txtMaNGS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtMaNGS.Focus();
                this.txtMaPB.Select();
                txtMaPB_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private void txtMaPB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtMaPB.Focus();
                this.txtLuong.Select();
               // txtLuong_KeyDown(sender, new KeyEventArgs(new Keys()));
            }
        }

        private bool Find(string strSearch)
        {
            for (int j = 0; j < this.dgvNhanVien.ColumnCount; ++j)
            {
                for (int i = 0; i < this.dgvNhanVien.RowCount; ++i)
                {
                    try
                    {
                        if (this.dgvNhanVien.Rows[i].Cells[j].Value.ToString() == strSearch)
                        {
                            //dataGridView1.Rows[row].Selected = true;
                            this.dgvNhanVien.Rows[i].DefaultCellStyle.BackColor = Color.Red;
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