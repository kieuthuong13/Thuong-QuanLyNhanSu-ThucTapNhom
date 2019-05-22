namespace QuanLyNhanSu.GUI
{
    partial class frmQuanLy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8_Thoat = new System.Windows.Forms.Button();
            this.button4_ThayDoi = new System.Windows.Forms.Button();
            this.button7_HuyBo = new System.Windows.Forms.Button();
            this.button6_Xoa = new System.Windows.Forms.Button();
            this.button5_LuuThayDoi = new System.Windows.Forms.Button();
            this.button3_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2_LamMoi = new System.Windows.Forms.Button();
            this.button1_TimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbNameForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8_Thoat);
            this.groupBox1.Controls.Add(this.button4_ThayDoi);
            this.groupBox1.Controls.Add(this.button7_HuyBo);
            this.groupBox1.Controls.Add(this.button6_Xoa);
            this.groupBox1.Controls.Add(this.button5_LuuThayDoi);
            this.groupBox1.Controls.Add(this.button3_Them);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button8_Thoat
            // 
            this.button8_Thoat.Location = new System.Drawing.Point(6, 109);
            this.button8_Thoat.Name = "button8_Thoat";
            this.button8_Thoat.Size = new System.Drawing.Size(126, 39);
            this.button8_Thoat.TabIndex = 9;
            this.button8_Thoat.Text = "Thoát";
            this.button8_Thoat.UseVisualStyleBackColor = true;
            this.button8_Thoat.Click += new System.EventHandler(this.button8_Thoat_Click);
            // 
            // button4_ThayDoi
            // 
            this.button4_ThayDoi.Location = new System.Drawing.Point(152, 19);
            this.button4_ThayDoi.Name = "button4_ThayDoi";
            this.button4_ThayDoi.Size = new System.Drawing.Size(126, 39);
            this.button4_ThayDoi.TabIndex = 5;
            this.button4_ThayDoi.Text = "Thay đổi";
            this.button4_ThayDoi.UseVisualStyleBackColor = true;
            this.button4_ThayDoi.Click += new System.EventHandler(this.button4_ThayDoi_Click);
            // 
            // button7_HuyBo
            // 
            this.button7_HuyBo.Location = new System.Drawing.Point(152, 109);
            this.button7_HuyBo.Name = "button7_HuyBo";
            this.button7_HuyBo.Size = new System.Drawing.Size(126, 39);
            this.button7_HuyBo.TabIndex = 8;
            this.button7_HuyBo.Text = "Huỷ bỏ";
            this.button7_HuyBo.UseVisualStyleBackColor = true;
            this.button7_HuyBo.Click += new System.EventHandler(this.button7_HuyBo_Click);
            // 
            // button6_Xoa
            // 
            this.button6_Xoa.Location = new System.Drawing.Point(152, 64);
            this.button6_Xoa.Name = "button6_Xoa";
            this.button6_Xoa.Size = new System.Drawing.Size(126, 39);
            this.button6_Xoa.TabIndex = 7;
            this.button6_Xoa.Text = "Xoá";
            this.button6_Xoa.UseVisualStyleBackColor = true;
            this.button6_Xoa.Click += new System.EventHandler(this.button6_Xoa_Click);
            // 
            // button5_LuuThayDoi
            // 
            this.button5_LuuThayDoi.Location = new System.Drawing.Point(6, 64);
            this.button5_LuuThayDoi.Name = "button5_LuuThayDoi";
            this.button5_LuuThayDoi.Size = new System.Drawing.Size(126, 39);
            this.button5_LuuThayDoi.TabIndex = 6;
            this.button5_LuuThayDoi.Text = "Lưu thay đổi";
            this.button5_LuuThayDoi.UseVisualStyleBackColor = true;
            this.button5_LuuThayDoi.Click += new System.EventHandler(this.button5_LuuThayDoi_Click);
            // 
            // button3_Them
            // 
            this.button3_Them.Location = new System.Drawing.Point(6, 19);
            this.button3_Them.Name = "button3_Them";
            this.button3_Them.Size = new System.Drawing.Size(126, 39);
            this.button3_Them.TabIndex = 4;
            this.button3_Them.Text = "Thêm";
            this.button3_Them.UseVisualStyleBackColor = true;
            this.button3_Them.Click += new System.EventHandler(this.button3_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2_LamMoi);
            this.groupBox2.Controls.Add(this.button1_TimKiem);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(315, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 476);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button2_LamMoi
            // 
            this.button2_LamMoi.Location = new System.Drawing.Point(6, 19);
            this.button2_LamMoi.Name = "button2_LamMoi";
            this.button2_LamMoi.Size = new System.Drawing.Size(89, 39);
            this.button2_LamMoi.TabIndex = 2;
            this.button2_LamMoi.Text = "Làm mới";
            this.button2_LamMoi.UseVisualStyleBackColor = true;
            this.button2_LamMoi.Click += new System.EventHandler(this.button2_LamMoi_Click);
            // 
            // button1_TimKiem
            // 
            this.button1_TimKiem.Location = new System.Drawing.Point(641, 19);
            this.button1_TimKiem.Name = "button1_TimKiem";
            this.button1_TimKiem.Size = new System.Drawing.Size(89, 39);
            this.button1_TimKiem.TabIndex = 1;
            this.button1_TimKiem.Text = "Tìm kiếm";
            this.button1_TimKiem.UseVisualStyleBackColor = true;
            this.button1_TimKiem.Click += new System.EventHandler(this.button1_TimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 308);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbNameForm.Location = new System.Drawing.Point(12, 14);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(126, 31);
            this.lbNameForm.TabIndex = 4;
            this.lbNameForm.Text = "dddddddđ";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 528);
            this.Controls.Add(this.lbNameForm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLy";
            this.Text = "QuanLy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2_LamMoi;
        private System.Windows.Forms.Button button1_TimKiem;
        private System.Windows.Forms.Button button3_Them;
        private System.Windows.Forms.Button button7_HuyBo;
        private System.Windows.Forms.Button button6_Xoa;
        private System.Windows.Forms.Button button5_LuuThayDoi;
        private System.Windows.Forms.Button button4_ThayDoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8_Thoat;
        private System.Windows.Forms.Label lbNameForm;
    }
}