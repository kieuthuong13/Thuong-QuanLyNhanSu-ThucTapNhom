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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoHiemYTe));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvBHYTe = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Plum;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(40, 85);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 42);
            this.btnTimKiem.TabIndex = 213;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Plum;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(344, 86);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 42);
            this.btnLamMoi.TabIndex = 214;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvBHYTe
            // 
            this.dgvBHYTe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBHYTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHYTe.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBHYTe.Location = new System.Drawing.Point(344, 144);
            this.dgvBHYTe.Name = "dgvBHYTe";
            this.dgvBHYTe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBHYTe.Size = new System.Drawing.Size(649, 370);
            this.dgvBHYTe.TabIndex = 211;
            this.dgvBHYTe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBHYTe_RowEnter);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(160, 99);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(167, 20);
            this.txtTimKiem.TabIndex = 212;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Plum;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(453, 86);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 42);
            this.btnThem.TabIndex = 210;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Plum;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(904, 85);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 42);
            this.btnThoat.TabIndex = 209;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Plum;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(737, 86);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 42);
            this.btnLuu.TabIndex = 208;
            this.btnLuu.Text = "Lưu Mới";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Plum;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(635, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 42);
            this.btnXoa.TabIndex = 207;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Plum;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(544, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 42);
            this.btnSua.TabIndex = 206;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(140, 392);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 20);
            this.txtMaNV.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 196;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // LBNoiDK
            // 
            this.LBNoiDK.AutoSize = true;
            this.LBNoiDK.BackColor = System.Drawing.Color.Plum;
            this.LBNoiDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNoiDK.Location = new System.Drawing.Point(36, 260);
            this.LBNoiDK.Name = "LBNoiDK";
            this.LBNoiDK.Size = new System.Drawing.Size(91, 19);
            this.LBNoiDK.TabIndex = 197;
            this.LBNoiDK.Text = "Nơi Đăng Ký";
            // 
            // txtNoiDK
            // 
            this.txtNoiDK.Location = new System.Drawing.Point(140, 261);
            this.txtNoiDK.Name = "txtNoiDK";
            this.txtNoiDK.Size = new System.Drawing.Size(191, 20);
            this.txtNoiDK.TabIndex = 198;
            // 
            // LbHieuLuc
            // 
            this.LbHieuLuc.AutoSize = true;
            this.LbHieuLuc.BackColor = System.Drawing.Color.Plum;
            this.LbHieuLuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHieuLuc.Location = new System.Drawing.Point(36, 347);
            this.LbHieuLuc.Name = "LbHieuLuc";
            this.LbHieuLuc.Size = new System.Drawing.Size(66, 19);
            this.LbHieuLuc.TabIndex = 201;
            this.LbHieuLuc.Text = "Hiệu Lực";
            // 
            // txtMaBHYT
            // 
            this.txtMaBHYT.Location = new System.Drawing.Point(140, 218);
            this.txtMaBHYT.Name = "txtMaBHYT";
            this.txtMaBHYT.Size = new System.Drawing.Size(191, 20);
            this.txtMaBHYT.TabIndex = 216;
            // 
            // LbMaBHYT
            // 
            this.LbMaBHYT.AutoSize = true;
            this.LbMaBHYT.BackColor = System.Drawing.Color.Plum;
            this.LbMaBHYT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaBHYT.Location = new System.Drawing.Point(36, 217);
            this.LbMaBHYT.Name = "LbMaBHYT";
            this.LbMaBHYT.Size = new System.Drawing.Size(88, 19);
            this.LbMaBHYT.TabIndex = 215;
            this.LbMaBHYT.Text = "Mã BH Y Tế";
            // 
            // LbSoTien
            // 
            this.LbSoTien.AutoSize = true;
            this.LbSoTien.BackColor = System.Drawing.Color.Plum;
            this.LbSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSoTien.Location = new System.Drawing.Point(36, 303);
            this.LbSoTien.Name = "LbSoTien";
            this.LbSoTien.Size = new System.Drawing.Size(55, 19);
            this.LbSoTien.TabIndex = 217;
            this.LbSoTien.Text = "Số Tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(140, 304);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(191, 20);
            this.txtSoTien.TabIndex = 218;
            // 
            // dptHieuLuc
            // 
            this.dptHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptHieuLuc.Location = new System.Drawing.Point(140, 345);
            this.dptHieuLuc.Name = "dptHieuLuc";
            this.dptHieuLuc.Size = new System.Drawing.Size(191, 20);
            this.dptHieuLuc.TabIndex = 219;
            // 
            // frmBaoHiemYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thuong_QuanLyNhanSu.Properties.Resources.hoacuc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 542);
            this.Controls.Add(this.dptHieuLuc);
            this.Controls.Add(this.LbSoTien);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtMaBHYT);
            this.Controls.Add(this.LbMaBHYT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvBHYTe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBNoiDK);
            this.Controls.Add(this.txtNoiDK);
            this.Controls.Add(this.LbHieuLuc);
            this.Name = "frmBaoHiemYTe";
            this.Text = "Bảo Hiểm Y Tế";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBaoHiemYTe_FormClosed);
            this.Load += new System.EventHandler(this.frmBaoHiemYTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvBHYTe;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
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
    }
}