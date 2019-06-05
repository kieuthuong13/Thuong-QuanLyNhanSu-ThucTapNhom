namespace QuanLyNhanSu.GUI
{
    partial class frmThanNhan
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
            this.dgvThanNhan = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThanNhan
            // 
            this.dgvThanNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvThanNhan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanNhan.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThanNhan.Location = new System.Drawing.Point(351, 85);
            this.dgvThanNhan.Name = "dgvThanNhan";
            this.dgvThanNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanNhan.Size = new System.Drawing.Size(768, 361);
            this.dgvThanNhan.TabIndex = 192;
            this.dgvThanNhan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanNhan_RowEnter);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(154, 228);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 22);
            this.txtMaNV.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 173;
            this.label2.Text = "Mã Nhân Viên ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 174;
            this.label3.Text = "Tên Thân Nhân";
            // 
            // txtTenTN
            // 
            this.txtTenTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTN.Location = new System.Drawing.Point(154, 271);
            this.txtTenTN.Name = "txtTenTN";
            this.txtTenTN.Size = new System.Drawing.Size(191, 22);
            this.txtTenTN.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 176;
            this.label5.Text = "Giới Tính          ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 177;
            this.label4.Text = "Ngày Sinh        ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Plum;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 178;
            this.label6.Text = "Quan Hệ          ";
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuanHe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQuanHe.Location = new System.Drawing.Point(154, 395);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(191, 22);
            this.txtQuanHe.TabIndex = 179;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(154, 354);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(191, 23);
            this.cbxGioiTinh.TabIndex = 184;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(154, 310);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(191, 22);
            this.dtpNgaySinh.TabIndex = 183;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Plum;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.cancel_f2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(177, 139);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 53);
            this.btnThoat.TabIndex = 200;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi.BackColor = System.Drawing.Color.Plum;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.refresh_48_hot;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(351, 22);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(123, 53);
            this.btnLamMoi.TabIndex = 199;
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
            this.btnThem.Location = new System.Drawing.Point(48, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 53);
            this.btnThem.TabIndex = 198;
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
            this.btnLuu.Location = new System.Drawing.Point(177, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 53);
            this.btnLuu.TabIndex = 197;
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
            this.btnXoa.Location = new System.Drawing.Point(177, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 53);
            this.btnXoa.TabIndex = 196;
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
            this.btnSua.Location = new System.Drawing.Point(48, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 53);
            this.btnSua.TabIndex = 195;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.Plum;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.zoom_48_hot;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(480, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 53);
            this.btnTimKiem.TabIndex = 202;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(609, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(191, 22);
            this.txtTimKiem.TabIndex = 201;
            // 
            // frmThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thuong_QuanLyNhanSu.Properties.Resources.hinh_nen_3d_dep_cho_dien_thoai_13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 479);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvThanNhan);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuanHe);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Name = "frmThanNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thân Nhân";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThanNhan_FormClosed);
            this.Load += new System.EventHandler(this.frmThanNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThanNhan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}