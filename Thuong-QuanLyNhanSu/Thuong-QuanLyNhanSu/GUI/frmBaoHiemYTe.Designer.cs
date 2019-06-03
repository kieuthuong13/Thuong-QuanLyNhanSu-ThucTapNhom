namespace QuanLyNhanSu.GUI
{
    partial class frmBaoHiemYTe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBHYTe = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBNoiDK = new System.Windows.Forms.Label();
            this.txtNoiDK = new System.Windows.Forms.TextBox();
            this.LbHieuLuc = new System.Windows.Forms.Label();
            this.txtMaBHYT = new System.Windows.Forms.TextBox();
            this.LbMaBHYT = new System.Windows.Forms.Label();
            this.LbSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.dptHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBHYTe
            // 
            this.dgvBHYTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBHYTe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBHYTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHYTe.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBHYTe.Location = new System.Drawing.Point(323, 122);
            this.dgvBHYTe.Name = "dgvBHYTe";
            this.dgvBHYTe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBHYTe.Size = new System.Drawing.Size(649, 370);
            this.dgvBHYTe.TabIndex = 211;
            this.dgvBHYTe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBHYTe_RowEnter);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(115, 313);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 22);
            this.txtMaNV.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 196;
            this.label2.Text = "Mã nhân viên   ";
            // 
            // LBNoiDK
            // 
            this.LBNoiDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBNoiDK.AutoSize = true;
            this.LBNoiDK.BackColor = System.Drawing.Color.Plum;
            this.LBNoiDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNoiDK.Location = new System.Drawing.Point(8, 227);
            this.LBNoiDK.Name = "LBNoiDK";
            this.LBNoiDK.Size = new System.Drawing.Size(100, 19);
            this.LBNoiDK.TabIndex = 197;
            this.LBNoiDK.Text = "Nơi đăng ký    ";
            // 
            // txtNoiDK
            // 
            this.txtNoiDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoiDK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiDK.Location = new System.Drawing.Point(115, 227);
            this.txtNoiDK.Name = "txtNoiDK";
            this.txtNoiDK.Size = new System.Drawing.Size(191, 22);
            this.txtNoiDK.TabIndex = 198;
            // 
            // LbHieuLuc
            // 
            this.LbHieuLuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbHieuLuc.AutoSize = true;
            this.LbHieuLuc.BackColor = System.Drawing.Color.Plum;
            this.LbHieuLuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHieuLuc.Location = new System.Drawing.Point(7, 285);
            this.LbHieuLuc.Name = "LbHieuLuc";
            this.LbHieuLuc.Size = new System.Drawing.Size(100, 19);
            this.LbHieuLuc.TabIndex = 201;
            this.LbHieuLuc.Text = "Hiệu lực          ";
            // 
            // txtMaBHYT
            // 
            this.txtMaBHYT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaBHYT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaBHYT.Location = new System.Drawing.Point(115, 199);
            this.txtMaBHYT.Name = "txtMaBHYT";
            this.txtMaBHYT.Size = new System.Drawing.Size(191, 22);
            this.txtMaBHYT.TabIndex = 216;
            // 
            // LbMaBHYT
            // 
            this.LbMaBHYT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbMaBHYT.AutoSize = true;
            this.LbMaBHYT.BackColor = System.Drawing.Color.Plum;
            this.LbMaBHYT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaBHYT.Location = new System.Drawing.Point(8, 199);
            this.LbMaBHYT.Name = "LbMaBHYT";
            this.LbMaBHYT.Size = new System.Drawing.Size(101, 19);
            this.LbMaBHYT.TabIndex = 215;
            this.LbMaBHYT.Text = "Mã BH y tế     ";
            // 
            // LbSoTien
            // 
            this.LbSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbSoTien.AutoSize = true;
            this.LbSoTien.BackColor = System.Drawing.Color.Plum;
            this.LbSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSoTien.Location = new System.Drawing.Point(8, 255);
            this.LbSoTien.Name = "LbSoTien";
            this.LbSoTien.Size = new System.Drawing.Size(99, 19);
            this.LbSoTien.TabIndex = 217;
            this.LbSoTien.Text = "Số tiền            ";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTien.Location = new System.Drawing.Point(115, 255);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(191, 22);
            this.txtSoTien.TabIndex = 218;
            // 
            // dptHieuLuc
            // 
            this.dptHieuLuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dptHieuLuc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dptHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptHieuLuc.Location = new System.Drawing.Point(115, 282);
            this.dptHieuLuc.Name = "dptHieuLuc";
            this.dptHieuLuc.Size = new System.Drawing.Size(191, 22);
            this.dptHieuLuc.TabIndex = 219;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Plum;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.cancel_f2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(141, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 53);
            this.btnThoat.TabIndex = 227;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.Plum;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.zoom_48_hot;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(452, 63);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 53);
            this.btnTimKiem.TabIndex = 226;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(581, 80);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(391, 22);
            this.txtTimKiem.TabIndex = 225;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi.BackColor = System.Drawing.Color.Plum;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.refresh_48_hot;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(323, 63);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(123, 53);
            this.btnLamMoi.TabIndex = 224;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.Plum;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.addusers;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 53);
            this.btnThem.TabIndex = 223;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.Plum;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.save_48_hot;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(12, 71);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 53);
            this.btnLuu.TabIndex = 222;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.Plum;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.delete_f2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(141, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 53);
            this.btnXoa.TabIndex = 221;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.Plum;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.editadd_48_hot;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(141, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 53);
            this.btnSua.TabIndex = 220;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // frmBaoHiemYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thuong_QuanLyNhanSu.Properties.Resources.hoacuc3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 522);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dptHieuLuc);
            this.Controls.Add(this.LbSoTien);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtMaBHYT);
            this.Controls.Add(this.LbMaBHYT);
            this.Controls.Add(this.dgvBHYTe);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBNoiDK);
            this.Controls.Add(this.txtNoiDK);
            this.Controls.Add(this.LbHieuLuc);
            this.Name = "frmBaoHiemYTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo Hiểm Y Tế";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBaoHiemYTe_FormClosed);
            this.Load += new System.EventHandler(this.frmBaoHiemYTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBHYTe;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBNoiDK;
        private System.Windows.Forms.TextBox txtNoiDK;
        private System.Windows.Forms.Label LbHieuLuc;
        private System.Windows.Forms.TextBox txtMaBHYT;
        private System.Windows.Forms.Label LbMaBHYT;
        private System.Windows.Forms.Label LbSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.DateTimePicker dptHieuLuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}