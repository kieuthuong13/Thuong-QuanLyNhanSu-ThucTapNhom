namespace QuanLyNhanSu.GUI
{
    partial class frmDuAn
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongSoGio = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "Địa điểm";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(232, 470);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(153, 20);
            this.txtDiaDiem.TabIndex = 99;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(232, 321);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(153, 20);
            this.txtMaDA.TabIndex = 98;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(232, 370);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(153, 20);
            this.txtTenDA.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Mã PB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tên dự án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "Mã Dự Án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(435, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 37);
            this.label4.TabIndex = 102;
            this.label4.Text = "Quản Lý Dự Án";
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDuAn.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Location = new System.Drawing.Point(413, 148);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.Size = new System.Drawing.Size(727, 403);
            this.dgvDuAn.TabIndex = 127;
            this.dgvDuAn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_RowEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 135;
            this.label6.Text = "Tổng Số Giờ";
            // 
            // txtTongSoGio
            // 
            this.txtTongSoGio.Location = new System.Drawing.Point(232, 520);
            this.txtTongSoGio.Name = "txtTongSoGio";
            this.txtTongSoGio.Size = new System.Drawing.Size(153, 20);
            this.txtTongSoGio.TabIndex = 134;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(232, 419);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(153, 20);
            this.txtMaPB.TabIndex = 161;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Plum;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.addusers;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(113, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 53);
            this.btnThem.TabIndex = 171;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Plum;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.save_48_hot;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(252, 139);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 53);
            this.btnLuu.TabIndex = 170;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Plum;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.delete_f2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(252, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 53);
            this.btnXoa.TabIndex = 169;
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
            this.btnSua.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.editadd_48_hot;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(113, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 53);
            this.btnSua.TabIndex = 168;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Plum;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.refresh_48_hot;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(433, 83);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(123, 53);
            this.btnLamMoi.TabIndex = 172;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Plum;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.zoom_48_hot;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(578, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 53);
            this.btnTimKiem.TabIndex = 174;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(717, 101);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 20);
            this.txtTimKiem.TabIndex = 173;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Plum;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::Thuong_QuanLyNhanSu.Properties.Resources.cancel_f2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1044, 83);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 53);
            this.btnThoat.TabIndex = 175;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Thuong_QuanLyNhanSu.Properties.Resources.hoacuc2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 596);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongSoGio);
            this.Controls.Add(this.dgvDuAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDuAn";
            this.Text = "Dự Án";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDuAn_FormClosed);
            this.Load += new System.EventHandler(this.frmDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongSoGio;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}