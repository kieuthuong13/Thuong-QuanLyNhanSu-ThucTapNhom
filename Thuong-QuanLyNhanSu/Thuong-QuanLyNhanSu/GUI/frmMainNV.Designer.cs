namespace QuanLyNhanSu.GUI
{
    partial class frmMainNV
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
            this.LbTroGiup = new System.Windows.Forms.Label();
            this.LbPhanCong = new System.Windows.Forms.Label();
            this.LbDangXuat = new System.Windows.Forms.Label();
            this.LbTrangChu = new System.Windows.Forms.Label();
            this.LbDuAn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbPhongBan = new System.Windows.Forms.Label();
            this.LbNhanVien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbBHXH = new System.Windows.Forms.Label();
            this.LbBHYT = new System.Windows.Forms.Label();
            this.picBHXH = new System.Windows.Forms.PictureBox();
            this.picBHYT = new System.Windows.Forms.PictureBox();
            this.LbThanNhan = new System.Windows.Forms.Label();
            this.picThanNhan = new System.Windows.Forms.PictureBox();
            this.picPhanCong = new System.Windows.Forms.PictureBox();
            this.picDuAn = new System.Windows.Forms.PictureBox();
            this.picPhongBan = new System.Windows.Forms.PictureBox();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBHXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBHYT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThanNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTroGiup
            // 
            this.LbTroGiup.AutoSize = true;
            this.LbTroGiup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbTroGiup.Location = new System.Drawing.Point(890, 11);
            this.LbTroGiup.Name = "LbTroGiup";
            this.LbTroGiup.Size = new System.Drawing.Size(70, 13);
            this.LbTroGiup.TabIndex = 2;
            this.LbTroGiup.Text = "Đổi mật khẩu";
            this.LbTroGiup.Click += new System.EventHandler(this.LbTroGiup_Click);
            // 
            // LbPhanCong
            // 
            this.LbPhanCong.AutoSize = true;
            this.LbPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhanCong.Location = new System.Drawing.Point(11, 290);
            this.LbPhanCong.Name = "LbPhanCong";
            this.LbPhanCong.Size = new System.Drawing.Size(74, 16);
            this.LbPhanCong.TabIndex = 3;
            this.LbPhanCong.Text = "Phân Công";
            this.LbPhanCong.Click += new System.EventHandler(this.LbPhanCong_Click);
            // 
            // LbDangXuat
            // 
            this.LbDangXuat.AutoSize = true;
            this.LbDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbDangXuat.Location = new System.Drawing.Point(976, 11);
            this.LbDangXuat.Name = "LbDangXuat";
            this.LbDangXuat.Size = new System.Drawing.Size(56, 13);
            this.LbDangXuat.TabIndex = 1;
            this.LbDangXuat.Text = "Đăng xuất";
            this.LbDangXuat.Click += new System.EventHandler(this.LbDangXuat_Click);
            // 
            // LbTrangChu
            // 
            this.LbTrangChu.AutoSize = true;
            this.LbTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTrangChu.Location = new System.Drawing.Point(6, 6);
            this.LbTrangChu.Name = "LbTrangChu";
            this.LbTrangChu.Size = new System.Drawing.Size(89, 20);
            this.LbTrangChu.TabIndex = 0;
            this.LbTrangChu.Text = "Trang chủ";
            // 
            // LbDuAn
            // 
            this.LbDuAn.AutoSize = true;
            this.LbDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDuAn.Location = new System.Drawing.Point(27, 215);
            this.LbDuAn.Name = "LbDuAn";
            this.LbDuAn.Size = new System.Drawing.Size(44, 16);
            this.LbDuAn.TabIndex = 6;
            this.LbDuAn.Text = "Dự Án";
            this.LbDuAn.Click += new System.EventHandler(this.LbDuAn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.LbTroGiup);
            this.groupBox1.Controls.Add(this.LbDangXuat);
            this.groupBox1.Controls.Add(this.LbTrangChu);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // LbPhongBan
            // 
            this.LbPhongBan.AutoSize = true;
            this.LbPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhongBan.Location = new System.Drawing.Point(11, 140);
            this.LbPhongBan.Name = "LbPhongBan";
            this.LbPhongBan.Size = new System.Drawing.Size(74, 16);
            this.LbPhongBan.TabIndex = 5;
            this.LbPhongBan.Text = "Phòng Ban";
            this.LbPhongBan.Click += new System.EventHandler(this.LbPhongBan_Click);
            // 
            // LbNhanVien
            // 
            this.LbNhanVien.AutoSize = true;
            this.LbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNhanVien.Location = new System.Drawing.Point(15, 65);
            this.LbNhanVien.Name = "LbNhanVien";
            this.LbNhanVien.Size = new System.Drawing.Size(70, 16);
            this.LbNhanVien.TabIndex = 4;
            this.LbNhanVien.Text = "Nhân Viên";
            this.LbNhanVien.Click += new System.EventHandler(this.LbNhanVien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.LbBHXH);
            this.groupBox2.Controls.Add(this.LbBHYT);
            this.groupBox2.Controls.Add(this.picBHXH);
            this.groupBox2.Controls.Add(this.picBHYT);
            this.groupBox2.Controls.Add(this.LbThanNhan);
            this.groupBox2.Controls.Add(this.picThanNhan);
            this.groupBox2.Controls.Add(this.LbPhanCong);
            this.groupBox2.Controls.Add(this.picPhanCong);
            this.groupBox2.Controls.Add(this.picDuAn);
            this.groupBox2.Controls.Add(this.picPhongBan);
            this.groupBox2.Controls.Add(this.LbDuAn);
            this.groupBox2.Controls.Add(this.LbPhongBan);
            this.groupBox2.Controls.Add(this.LbNhanVien);
            this.groupBox2.Controls.Add(this.picNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(1, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 560);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // LbBHXH
            // 
            this.LbBHXH.AutoSize = true;
            this.LbBHXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBHXH.Location = new System.Drawing.Point(6, 515);
            this.LbBHXH.Name = "LbBHXH";
            this.LbBHXH.Size = new System.Drawing.Size(111, 16);
            this.LbBHXH.TabIndex = 14;
            this.LbBHXH.Text = "Bảo Hiểm Xã Hội";
            this.LbBHXH.Click += new System.EventHandler(this.LbBHXH_Click);
            // 
            // LbBHYT
            // 
            this.LbBHYT.AutoSize = true;
            this.LbBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBHYT.Location = new System.Drawing.Point(6, 440);
            this.LbBHYT.Name = "LbBHYT";
            this.LbBHYT.Size = new System.Drawing.Size(100, 16);
            this.LbBHYT.TabIndex = 13;
            this.LbBHYT.Text = "Bảo Hiểm Y Tế";
            this.LbBHYT.Click += new System.EventHandler(this.LbBHYT_Click);
            // 
            // picBHXH
            // 
            this.picBHXH.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.BaoHiemXaHoi;
            this.picBHXH.Location = new System.Drawing.Point(11, 459);
            this.picBHXH.Name = "picBHXH";
            this.picBHXH.Size = new System.Drawing.Size(80, 53);
            this.picBHXH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBHXH.TabIndex = 12;
            this.picBHXH.TabStop = false;
            this.picBHXH.Click += new System.EventHandler(this.picBHXH_Click);
            // 
            // picBHYT
            // 
            this.picBHYT.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.thannhan;
            this.picBHYT.Location = new System.Drawing.Point(11, 384);
            this.picBHYT.Name = "picBHYT";
            this.picBHYT.Size = new System.Drawing.Size(80, 53);
            this.picBHYT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBHYT.TabIndex = 11;
            this.picBHYT.TabStop = false;
            this.picBHYT.Click += new System.EventHandler(this.picBHYT_Click);
            // 
            // LbThanNhan
            // 
            this.LbThanNhan.AutoSize = true;
            this.LbThanNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbThanNhan.Location = new System.Drawing.Point(11, 365);
            this.LbThanNhan.Name = "LbThanNhan";
            this.LbThanNhan.Size = new System.Drawing.Size(74, 16);
            this.LbThanNhan.TabIndex = 10;
            this.LbThanNhan.Text = "Thân Nhân";
            this.LbThanNhan.Click += new System.EventHandler(this.LbThanNhan_Click);
            // 
            // picThanNhan
            // 
            this.picThanNhan.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.thannhan;
            this.picThanNhan.Location = new System.Drawing.Point(10, 309);
            this.picThanNhan.Name = "picThanNhan";
            this.picThanNhan.Size = new System.Drawing.Size(80, 53);
            this.picThanNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThanNhan.TabIndex = 8;
            this.picThanNhan.TabStop = false;
            this.picThanNhan.Click += new System.EventHandler(this.picThanNhan_Click);
            // 
            // picPhanCong
            // 
            this.picPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhanCong.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.duann;
            this.picPhanCong.Location = new System.Drawing.Point(11, 234);
            this.picPhanCong.Name = "picPhanCong";
            this.picPhanCong.Size = new System.Drawing.Size(79, 53);
            this.picPhanCong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhanCong.TabIndex = 3;
            this.picPhanCong.TabStop = false;
            this.picPhanCong.Click += new System.EventHandler(this.picPhanCong_Click);
            // 
            // picDuAn
            // 
            this.picDuAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDuAn.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.duan;
            this.picDuAn.Location = new System.Drawing.Point(11, 159);
            this.picDuAn.Name = "picDuAn";
            this.picDuAn.Size = new System.Drawing.Size(79, 53);
            this.picDuAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDuAn.TabIndex = 2;
            this.picDuAn.TabStop = false;
            this.picDuAn.Click += new System.EventHandler(this.picDuAn_Click);
            // 
            // picPhongBan
            // 
            this.picPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhongBan.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.phongban;
            this.picPhongBan.Location = new System.Drawing.Point(11, 84);
            this.picPhongBan.Name = "picPhongBan";
            this.picPhongBan.Size = new System.Drawing.Size(79, 53);
            this.picPhongBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhongBan.TabIndex = 1;
            this.picPhongBan.TabStop = false;
            this.picPhongBan.Click += new System.EventHandler(this.picPhongBan_Click);
            // 
            // picNhanVien
            // 
            this.picNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNhanVien.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.nhanvien;
            this.picNhanVien.Location = new System.Drawing.Point(11, 9);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(79, 53);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNhanVien.TabIndex = 0;
            this.picNhanVien.TabStop = false;
            this.picNhanVien.Click += new System.EventHandler(this.picNhanVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.top_6_hinh_anh_nha_xuong_dep_khong_the_bo_qua_2;
            this.pictureBox1.Location = new System.Drawing.Point(124, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainNV";
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainNV_FormClosed);
            this.SizeChanged += new System.EventHandler(this.frmMainNV_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBHXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBHYT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThanNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picDuAn;
        private System.Windows.Forms.Label LbTroGiup;
        private System.Windows.Forms.Label LbPhanCong;
        private System.Windows.Forms.PictureBox picPhongBan;
        private System.Windows.Forms.Label LbDangXuat;
        private System.Windows.Forms.Label LbTrangChu;
        private System.Windows.Forms.PictureBox picPhanCong;
        private System.Windows.Forms.Label LbDuAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbPhongBan;
        private System.Windows.Forms.Label LbNhanVien;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbThanNhan;
        private System.Windows.Forms.PictureBox picThanNhan;
        private System.Windows.Forms.Label LbBHXH;
        private System.Windows.Forms.Label LbBHYT;
        private System.Windows.Forms.PictureBox picBHXH;
        private System.Windows.Forms.PictureBox picBHYT;
    }
}