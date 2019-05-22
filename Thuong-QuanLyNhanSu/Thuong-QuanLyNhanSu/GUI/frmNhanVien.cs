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

namespace QuanLyNhanSu.GUI
{
    public partial class frmNhanVien : Form
    {
        SqlConnection localConnect;
        SqlCommand localCommand = new SqlCommand();
        public frmNhanVien()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1200, 600);
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaNV.Enabled = false;
            this.btnCancel.Enabled = false;
            this.dgvNhanVien.ReadOnly = true;

            EditInfoMode(false);

            localConnect = GUI.SQLServer.GetMySQL();
            localCommand.Connection = localConnect;

            GUI.FillTo.DataGridViews("NHANVIEN",ref this.dgvNhanVien);
        }

        private void EditInfoMode(bool _AreYouSure = false)
        {
            this.txtTenNV.Enabled = _AreYouSure;
            this.txtGioiTinh.Enabled = _AreYouSure;
            this.dtpNgaySinh.Enabled = _AreYouSure;
            this.txtDiaChi.Enabled = _AreYouSure;
            this.txtLuong.Enabled = _AreYouSure;
            this.txtMaNGS.Enabled = _AreYouSure;
            this.txtMaPB.Enabled = _AreYouSure;
            this.txtTaiKhoan.Enabled = _AreYouSure;

            this.btnLuu.Enabled = _AreYouSure;
            this.btnXoa.Enabled = _AreYouSure;
            this.btnCancel.Enabled = _AreYouSure;

            this.dgvNhanVien.Enabled = true;
        }

        private bool IsClickAddTwice = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.txtMaNV.Text = GUI.Insert.NHANVIEN.GetNextIndex().ToString();
            if (IsClickAddTwice)
            {
                MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
                nv.TENNV = this.txtTenNV.Text ?? null;
                nv.GIOITINH = this.txtGioiTinh.Text ?? null;
                nv.NGAYSINH = DateTime.Parse(this.dtpNgaySinh.Text);
                nv.DIACHI = this.txtDiaChi.Text ?? null;
                nv.BACLUONG = int.Parse(this.txtLuong.Text);
                nv.MA_NGS = int.Parse(this.txtMaNGS.Text);
                nv.MAPB = int.Parse(this.txtMaPB.Text);
                nv.ACCOUNT = this.txtTaiKhoan.Text;
                this.IsClickAddTwice = false;


                if (GUI.Insert.NHANVIEN.CreateNewRecord(nv))
                {
                    MessageBox.Show("Create success!");
                }

                this.btnCancel_Click(sender, e);
                this.btnRefersh_Click(sender, e);
                this.btnSua.Enabled = true;
                EditInfoMode(false);

                return;
            }

            this.IsClickAddTwice = true;

            EditInfoMode(true);
            this.dgvNhanVien.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = false;

            this.btnRefersh_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EditInfoMode(true);
            this.dgvNhanVien.Enabled = false;
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            GUI.FillTo.DataGridViews("NHANVIEN", ref this.dgvNhanVien);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtTimKiem.Text))
            {
                Find(this.txtTimKiem.Text);
            }
        }
        private bool Find(string strSearch)
        {
            for(int j = 0; j < this.dgvNhanVien.ColumnCount; ++j)
            {
                for(int i = 0; i < this.dgvNhanVien.RowCount; ++i)
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

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.txtMaNV.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                this.txtTenNV.Text = this.dgvNhanVien.SelectedRows[0].Cells["TenNV"].Value.ToString();
                this.txtGioiTinh.Text = this.dgvNhanVien.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                this.dtpNgaySinh.Text = this.dgvNhanVien.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                this.txtDiaChi.Text = this.dgvNhanVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                this.txtLuong.Text = this.dgvNhanVien.SelectedRows[0].Cells["Luong"].Value.ToString();
                this.txtMaNGS.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaNGS"].Value.ToString();
                this.txtMaPB.Text = this.dgvNhanVien.SelectedRows[0].Cells["MaPB"].Value.ToString();
                this.txtTaiKhoan.Text = this.dgvNhanVien.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
            }
            catch
            {
                this.txtMaNV.Text = "";
                this.txtTenNV.Text = "";
                this.txtGioiTinh.Text = "";
                this.dtpNgaySinh.Text = "";
                this.txtDiaChi.Text = "";
                this.txtLuong.Text = "";
                this.txtMaNGS.Text = "";
                this.txtMaPB.Text = "";
                this.txtTaiKhoan.Text = "";
            }
            
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // luu data vào trong sql
            MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
            nv.MANV = int.Parse(this.txtMaNV.Text);
            nv.TENNV = !string.IsNullOrWhiteSpace(this.txtTenNV.Text) ? this.txtTenNV.Text : "Đã bị xoá";
            nv.GIOITINH = this.txtGioiTinh.Text ?? "Khác";
            nv.NGAYSINH = DateTime.Parse(this.dtpNgaySinh.Text);
            nv.DIACHI = this.txtDiaChi.Text ?? " ";
            nv.BACLUONG = !string.IsNullOrWhiteSpace(this.txtLuong.Text) ? int.Parse(this.txtLuong.Text) : 1;
            nv.MA_NGS = int.Parse(this.txtMaNGS.Text);
            nv.MAPB = int.Parse(this.txtMaPB.Text);
            nv.ACCOUNT = this.txtTaiKhoan.Text;

            GUI.Update.NHANVIEN.UpdateOneRecord(nv);

            this.btnRefersh_Click(sender, e);
            EditInfoMode(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xoá nhân viên
            if (!GUI.Delete.NHANVIEN.DeleteRecord_Primary(int.Parse(this.txtMaNV.Text)))
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("Cant delete\nCause this record is connecting to the other record!\n\n\nDo you want to delete all of the another record connecting this?? :D ?",
                    "Can not delete the record!", MessageBoxButtons.YesNo))
                {
                    if (GUI.Delete.PHANCONG.DeleteAllRecord_HaveTableX(MyStruct.PHANCONG.enumStruct.MANV, this.txtMaNV.Text)
                        && GUI.Delete.NHANVIEN.DeleteRecord_Primary(int.Parse(this.txtMaNV.Text)))
                    {
                        MessageBox.Show("Delete success!");
                    }
                    else
                    {
                        MessageBox.Show("Cant del the record!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Delete success!");
            }
            
                

            this.btnRefersh_Click(sender, e);
            EditInfoMode(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EditInfoMode(false);
        }
    }
}
