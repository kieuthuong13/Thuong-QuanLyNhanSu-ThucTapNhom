using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmQuanLy : Form
    {
        // mỗi label đi kèm với một textbox
        private List<TextBox> ltextbox = new List<TextBox>();
        private List<Label> llabel = new List<Label>();
        private List<DateTimePicker> ldatetimepicker = new List<DateTimePicker>();

        private Point _locationNextTextBox;
        private bool FirstLoadDataGridViews = false;

        // Kiểu bảng nào truyền vào
        private GUI.MyStruct.MyTableName eNameTable = new MyStruct.MyTableName();
        


        public frmQuanLy(GUI.MyStruct.MyTableName nameTable)
        {
            InitializeComponent();
            this.MinimizeBox = this.MaximizeBox = false;
            // this.MaximumSize = this.MinimumSize = new Size(1100, 550);
            this.dataGridView1.ReadOnly = true;

            eNameTable = nameTable;
            lbNameForm.Text = "Quản lý ";
            switch (eNameTable)
            {
                case MyStruct.MyTableName.DUAN:
                    lbNameForm.Text += "Dự án";
                    break;
                case MyStruct.MyTableName.LUONG:
                    lbNameForm.Text += "Lương";
                    break;
                case MyStruct.MyTableName.NHANVIEN:
                    lbNameForm.Text += "Nhân viên";
                    break;
                case MyStruct.MyTableName.PHANCONG:
                    lbNameForm.Text += "Phân công";
                    break;
                case MyStruct.MyTableName.PHONGBAN:
                    lbNameForm.Text += "Phòng ban";
                    break;
                case MyStruct.MyTableName.TAIKHOAN:
                    lbNameForm.Text += "Tài khoản";
                    break;
                default:
                    lbNameForm.Text += "Gì đó";
                    break;
            }
        }

        /// <summary>
        /// 
        /// Cái này để để gán giá trị cho mấy cái textbox khi có sự kiện thay đổi giá trị của thằng DataTimePicker
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeValues_DateTimePicker(object sender, EventArgs e)
        {
            int i = llabel.FindIndex(m => string.Equals(m.Text, "NGAYNC"));
            if(i > -1)
            {
                ltextbox[i].Text = ldatetimepicker[0].Value.ToShortDateString();
                return;
            }

            i = llabel.FindIndex(m => string.Equals(m.Text, "NGAYSINH"));
            if ( i > -1)
            {
                ltextbox[i].Text = ldatetimepicker[0].Value.ToShortDateString();
                return;
            }
        }
        
        /// <summary>
        /// 
        /// Làm rỗng input của tất cả textbox thuộc list<TextBox>
        /// 
        /// </summary>
        /// <param name="lt"></param>
        private void InitInput_Textbox(ref List<TextBox> lt)
        {
            for (int i = 0; i < lt.Count; i++)
            {
                lt[i].Text = "";
            }
        }

        /// <summary>
        /// 
        /// Hàm này để gán giá trị của các textbox trong list<textbox> vào từng kiểu dữ liệu tương ứng
        /// 
        /// </summary>
        /// <param name="lt"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        private object AddData_FromListTextbox_ToObject(ref List<TextBox> lt, MyStruct.MyTableName TableName)
        {
            int itam = 0;

            switch (TableName)
            {
                case MyStruct.MyTableName.DUAN:
                    GUI.MyStruct.DUAN da = new MyStruct.DUAN();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MADA"));
                    da.MADA = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MAPB"));
                    da.MAPB = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"TENDA"));
                    da.TENDA = string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"DIADIEM"));
                    da.DIADIEM = string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"TONGSOGIO"));
                    da.TONGSOGIO = float.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);
                    
                    return da;
                case MyStruct.MyTableName.LUONG:
                    MyStruct.LUONG lg = new MyStruct.LUONG();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"BACLUONG"));
                    lg.BACLUONG = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"LUONGCOBAN"));
                    lg.LUONGCOBAN = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"HESOLUONG"));
                    lg.HESOLUONG = float.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"HESOPHUCAP"));
                    lg.HESOPHUCAP = float.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);
                    
                    return lg;
                case MyStruct.MyTableName.NHANVIEN:
                    MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MANV"));
                    nv.MANV = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MAPB"));
                    nv.MAPB = int.Parse(string.IsNullOrWhiteSpace(ltextbox[itam].Text) ? null : ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"TENNV"));
                    nv.TENNV = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"NGAYSINH"));
                    string stam = string.IsNullOrWhiteSpace(ltextbox[itam].Text)
                                    ? new DateTime(2000, 1, 1).ToShortDateString()
                                    : ltextbox[itam].Text;
                    nv.NGAYSINH = DateTime.Parse(stam);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"GIOITINH"));
                    nv.GIOITINH = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MA_NGS"));
                    nv.MA_NGS = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"BACLUONG"));
                    nv.BACLUONG = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"DIACHI"));
                    nv.DIACHI = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"ACCOUNT"));
                    nv.ACCOUNT = ltextbox[itam].Text;
                    
                    return nv;
                case MyStruct.MyTableName.PHANCONG:
                    MyStruct.PHANCONG pc = new MyStruct.PHANCONG();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MANV"));
                    pc.MANV = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MADA"));
                    pc.MADA = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"SOGIO"));
                    pc.SOGIO = float.Parse(ltextbox[itam].Text);
                    
                    return pc;
                case MyStruct.MyTableName.PHONGBAN:
                    MyStruct.PHONGBAN pb = new MyStruct.PHONGBAN();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MAPB"));
                    pb.MAPB = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"TENPB"));
                    pb.TENPB = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"MATP"));
                    pb.MATP = int.Parse(ltextbox[itam].Text);

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"DIADIEM"));
                    pb.DIADIEM = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"NGAYNC"));
                    pb.NGAYNC = DateTime.Parse(DateTime.Parse(ltextbox[itam].Text).ToShortDateString());
                    
                    return pb;
                case MyStruct.MyTableName.TAIKHOAN:
                    MyStruct.TAIKHOAN tk = new MyStruct.TAIKHOAN();
                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"ACCOUNT"));
                    tk.ACCOUNT = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"PASSWORD"));
                    tk.PASSWORD = ltextbox[itam].Text;

                    itam = llabel.FindIndex(n => string.Equals(n.Text, @"ACCESS"));
                    tk.ACCESS = ltextbox[itam].Text;
                    
                    return tk;
                default:
                    return null;
            }
        }

        /// <summary>
        /// 
        /// Thằng này sẽ được gọi đến khi form bắt đầu chạy
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuanLy_Load(object sender, EventArgs e)
        {
            this.Text = @"Quản lý " + eNameTable.ToString();
            EditMode(true);
            GUI.FillTo.DataGridViews(eNameTable.ToString(), ref this.dataGridView1);
            FirstLoadDataGridViews = true;

            _locationNextTextBox = this.groupBox3.Location;

            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                // tạo label mới hiển thị nhãn
                Label lb = new Label();
                lb.Text = this.dataGridView1.Columns[i].Name;
                lb.AutoSize = true;
                lb.Size = new System.Drawing.Size(35, 13);

                // tạo một textbox mới hiển thị giá trị
                TextBox tb = new TextBox();
                tb.Size = new System.Drawing.Size(160, 20);
                tb.Enabled = false;

                // chỉnh toạ độ
                _locationNextTextBox.Y += 25;
                lb.Location = new Point(_locationNextTextBox.X + 5, _locationNextTextBox.Y - 190);
                tb.Location = new Point(_locationNextTextBox.X + 90, _locationNextTextBox.Y - 190);

                // gán textbox và label vào trong groupbox
                this.groupBox3.Controls.Add(lb);
                this.groupBox3.Controls.Add(tb);

                // nếu gặp kiểu dữ liệu datetime sẽ gán thêm một ô datatimepicker
                if (string.Equals(dataGridView1.Columns[i].Name, "NGAYNC")
                        || string.Equals(dataGridView1.Columns[i].Name, "NGAYSINH"))
                {
                    // tạo một kiểu DateTimePicker để gán ngày
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Value = DateTime.Now;
                    dtp.Size = new Size(20, 20);
                    dtp.Location = new Point(_locationNextTextBox.X + 90 + 140, _locationNextTextBox.Y - 190);

                    tb.Size = new System.Drawing.Size(130, 20);

                    ldatetimepicker.Add(dtp);
                    dtp.ValueChanged += new System.EventHandler(this.ChangeValues_DateTimePicker);


                    this.groupBox3.Controls.Add(dtp);
                }

                // thêm vào danh sách
                llabel.Add(lb);
                ltextbox.Add(tb);
            }

            StateAll_ListDateTimePicker(ref ldatetimepicker, false);

            return;
        }

        /// <summary>
        /// 
        /// Chế độ chỉnh sửa thông tin
        /// 
        /// </summary>
        /// <param name="_bState_Hide"></param>
        private void EditMode(bool _bState_Hide = true)
        {
            button5_LuuThayDoi.Enabled 
                = button7_HuyBo.Enabled 
                = !_bState_Hide;
        }

        /// <summary>
        /// 
        /// Sửa trạng thái hoạt động cho tất cả TextBox 
        /// 
        /// </summary>
        /// <param name="lt"></param>
        /// <param name="_EditMode"></param>
        private void StateAll_ListTextBox(ref List<TextBox> lt, bool _EditMode = true)
        {
            for (int i = 0; i < lt.Count; i++)
            {
                lt[i].Enabled = _EditMode;
            }
        }

        /// <summary>
        /// 
        /// Sửa trạng thái hoạt động cho tất cả DateTimePicker
        /// 
        /// </summary>
        /// <param name="ldtp"></param>
        /// <param name="_EditMode"></param>
        private void StateAll_ListDateTimePicker(ref List<DateTimePicker> ldtp, bool _EditMode = true)
        {
            for (int i = 0; i < ldtp.Count; i++)
            {
                ldtp[i].Enabled = _EditMode;
            }
        }

        /// <summary>
        /// 
        /// Khi click vào nút Thay đổi
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_ThayDoi_Click(object sender, EventArgs e)
        {
            EditMode(false);
            StateAll_ListTextBox(ref ltextbox, true);

            // Chỉnh những dòng nào ko được phép sửa (VD: Khoá chính)
            switch (eNameTable)
            {
                case MyStruct.MyTableName.DUAN:
                case MyStruct.MyTableName.LUONG:
                case MyStruct.MyTableName.NHANVIEN:
                case MyStruct.MyTableName.PHONGBAN:
                case MyStruct.MyTableName.TAIKHOAN:
                    ltextbox[0].Enabled = false;
                    break;
                case MyStruct.MyTableName.PHANCONG:
                    ltextbox[0].Enabled = ltextbox[1].Enabled = false;
                    break;
                default:
                    break;
            }
            
            // nếu có các nút thay đổi ngày tháng
            for (int i = 0; i < ldatetimepicker.Count; i++)
            {
                ldatetimepicker[i].Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// Khi click vào nút Huỷ bỏ
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_HuyBo_Click(object sender, EventArgs e)
        {
            EditMode(true);
            StateAll_ListTextBox(ref ltextbox, false);
            bClickButtonThemYet = false;
            button3_Them.Text = "Thêm";
            button4_ThayDoi.Enabled = button6_Xoa.Enabled = true;
            bIgnoreRowEnter = false;

            for (int i = 0; i < ldatetimepicker.Count; i++)
            {
                ldatetimepicker[i].Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// Khi click vào nút Thêm
        /// 
        /// </summary>
        private bool bClickButtonThemYet = false;
        private void button3_Them_Click(object sender, EventArgs e)
        {
            if (!bClickButtonThemYet)
            {
                // Đổi trạng thái chặn cái nút bấm khác + thay đổi thông tin
                button3_Them.Text = "Lưu mới";
                bClickButtonThemYet = true;
                button4_ThayDoi.Enabled = button5_LuuThayDoi.Enabled = button6_Xoa.Enabled = false;
                button7_HuyBo.Enabled = true;
                bIgnoreRowEnter = true;

                // làm rỗng input để điền thông tin mới vào nè
                this.InitInput_Textbox(ref ltextbox);
                StateAll_ListTextBox(ref ltextbox, true);
                StateAll_ListDateTimePicker(ref ldatetimepicker, true);

                // Chỉnh những dòng nào ko được phép sửa (VD: Khoá chính) + tự động cấp mã cho bản ghi mới
                switch (eNameTable)
                {
                    case MyStruct.MyTableName.DUAN:
                        ltextbox[0].Text = GUI.Insert.DUAN.GetNextIndex().ToString();
                        ltextbox[0].Enabled = false;
                        break;
                    case MyStruct.MyTableName.LUONG:
                        ltextbox[0].Text = GUI.Insert.LUONG.GetNextIndex().ToString();
                        ltextbox[0].Enabled = false;
                        break;
                    case MyStruct.MyTableName.NHANVIEN:
                        ltextbox[0].Text = GUI.Insert.NHANVIEN.GetNextIndex().ToString();
                        ltextbox[0].Enabled = false;
                        break;
                    case MyStruct.MyTableName.PHONGBAN:
                        ltextbox[0].Text = GUI.Insert.PHONGBAN.GetNextIndex().ToString();
                        ltextbox[0].Enabled = false;
                        break;
                    case MyStruct.MyTableName.TAIKHOAN:
                    case MyStruct.MyTableName.PHANCONG:
                    default:
                        break;
                }
            }
            else
            {
                // Đổi trạng thái chặn cái nút bấm khác + thay đổi thông tin
                bClickButtonThemYet = false;
                button3_Them.Text = "Thêm";
                EditMode(true);
                bIgnoreRowEnter = false;

                // cái này để lưu bản ghi đã nhập vào trong Database nè
                bool bSuccess = false;
                switch (eNameTable)
                {
                    case MyStruct.MyTableName.DUAN:
                        MyStruct.DUAN da = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.DUAN) as MyStruct.DUAN;
                        bSuccess = GUI.Insert.DUAN.CreateNewRecord(da);
                        break;

                    case MyStruct.MyTableName.LUONG:
                        MyStruct.LUONG lg = AddData_FromListTextbox_ToObject
                                                (ref ltextbox, MyStruct.MyTableName.LUONG)
                                                as MyStruct.LUONG;
                        bSuccess = GUI.Insert.LUONG.CreateNewRecord(lg);
                        break;

                    case MyStruct.MyTableName.NHANVIEN:
                        MyStruct.NHANVIEN nv = AddData_FromListTextbox_ToObject
                                                (ref ltextbox, MyStruct.MyTableName.NHANVIEN) 
                                                as MyStruct.NHANVIEN;
                        bSuccess = GUI.Insert.NHANVIEN.CreateNewRecord(nv);
                        break;

                    case MyStruct.MyTableName.PHANCONG:
                        MyStruct.PHANCONG pc = AddData_FromListTextbox_ToObject
                                                (ref ltextbox, MyStruct.MyTableName.PHANCONG) 
                                                as MyStruct.PHANCONG;
                        bSuccess = GUI.Insert.PHANCONG.CreateNewRecord(pc);
                        break;

                    case MyStruct.MyTableName.PHONGBAN:
                        MyStruct.PHONGBAN pb = AddData_FromListTextbox_ToObject
                                                (ref ltextbox, MyStruct.MyTableName.PHONGBAN) 
                                                as MyStruct.PHONGBAN;
                        bSuccess = GUI.Insert.PHONGBAN.CreateNewRecord(pb);
                        break;

                    case MyStruct.MyTableName.TAIKHOAN:
                        MyStruct.TAIKHOAN tk = AddData_FromListTextbox_ToObject
                                                (ref ltextbox, MyStruct.MyTableName.TAIKHOAN) 
                                                as MyStruct.TAIKHOAN;
                        bSuccess = GUI.Insert.TAIKHOAN.CreateNewRecord(tk);
                        break;

                    default:
                        break;
                }

                /// cái này chỉ là thông báo kết quả
                if (bSuccess)
                {
                    MessageBox.Show("Tạo bản ghi mới thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể tạo bản ghi!\n\nMã lỗi 100x000012");
                }
            }
        }

        /// <summary>
        /// 
        /// Khi click vào nút Làm mới
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_LamMoi_Click(object sender, EventArgs e)
        {
            GUI.FillTo.DataGridViews(eNameTable.ToString(), ref this.dataGridView1);
        }

        /// <summary>
        /// 
        /// Khi đang mở vào bản ghi
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool bIgnoreRowEnter = false;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Có thể dùng biến bIgnoreRowEnter để bỏ qua hàm này

            // khi vào một hàng bất kỳ -> in dữ liệu ra textbox
            if (!bIgnoreRowEnter && FirstLoadDataGridViews && e.RowIndex > -1 && e.RowIndex < this.dataGridView1.RowCount)
            {
                try
                {
                    int j = 0;
                    for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                    {
                        ltextbox[i].Text = this.dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                        if (string.Equals(dataGridView1.Columns[i].Name, "NGAYNC")
                                || string.Equals(dataGridView1.Columns[i].Name, "NGAYSINH"))
                        {
                            ldatetimepicker[j].Value = DateTime.Parse(ltextbox[i].Text);
                        }
                    }
                }
                catch
                {
                    // bắt lỗi nếu ô đang chọn không nằm trong khoảng dữ liệu hiển thị
                    //
                }
                
            }
        }

        /// <summary>
        /// 
        /// Hàm xoá bản ghi, sẽ xoá các bản ghi liên quan nếu các bảng liên quan là lấy giá trị của bản ghi hiện tại là khoá chính
        /// Còn không, đổi giá trị thuộc tính của bản ghi liên kết tới bản ghi hiện tại là null
        /// 
        /// </summary>
        /// <param name="_NameTable"></param>
        /// <param name="_Value"></param>
        private void DeleteRecord(MyStruct.MyTableName _NameTable, object _Value)
        {
            string messageError = "";
            switch (_NameTable)
            {
                case MyStruct.MyTableName.DUAN:
                    MyStruct.DUAN da = _Value as MyStruct.DUAN;
                    if (!GUI.Delete.DUAN.DeleteRecord_Primary(da.MADA))
                    {
                        if (DialogResult.OK == 
                                MessageBox.Show(
                                    "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n" 
                                    +"- PHANCONG\n\nBạn có muốn xoá tất cả các bản ghi liên kết với bảng hiện tại không?",
                                    "Cảnh báo xoá", MessageBoxButtons.OKCancel))
                        {
                            if (!GUI.Delete.PHANCONG.DeleteAllRecord_HaveTableX(MyStruct.PHANCONG.enumStruct.MADA, 
                                    da.MADA.ToString()))
                            {
                                messageError += "\n\n- PHANCONG";
                            }

                            if (!GUI.Delete.DUAN.DeleteRecord_Primary(da.MADA))
                            {
                                messageError += "\n\n- DUAN";
                            }

                            // thông báo lỗi
                            if (!string.IsNullOrEmpty(messageError))
                            {
                                MessageBox.Show("Không thể sửa hoặc xoá bản ghi trong table:" + messageError);
                            }
                            else
                            {
                                MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- PHANCONG\n- DUAN");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- DUAN");
                    }
                    break;

                case MyStruct.MyTableName.LUONG:
                    MyStruct.LUONG lg = _Value as MyStruct.LUONG;
                    if (!GUI.Delete.LUONG.DeleteRecord_Primary(lg.BACLUONG))
                    {
                        if (DialogResult.OK ==
                                MessageBox.Show(
                                    "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n"
                                    + "- NHANVIEN\n\nBạn có muốn sửa tất cả các bản ghi liên kết với bảng hiện tại không?",
                                    "Cảnh báo sửa", MessageBoxButtons.OKCancel))
                        {
                            if (!GUI.Update.NHANVIEN.UpdateAllRecord_HaveTableX(
                                    MyStruct.NHANVIEN.enumStruct.BACLUONG, "null"))
                            {
                                messageError += "\n\n- NHANVIEN";
                            }

                            if (!GUI.Delete.LUONG.DeleteRecord_Primary(lg.BACLUONG))
                            {
                                messageError += "\n\n- LUONG";
                            }

                            // thông báo lỗi
                            if (!string.IsNullOrEmpty(messageError))
                            {
                                MessageBox.Show("Không thể sửa hoặc xoá bản ghi trong table:" + messageError);
                            }
                            else
                            {
                                MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- NHANVIEN\n- LUONG");
                            }
                        }
                    }
                    break;

                case MyStruct.MyTableName.NHANVIEN:
                    MyStruct.NHANVIEN nv = _Value as MyStruct.NHANVIEN;
                    if (!GUI.Delete.NHANVIEN.DeleteRecord_Primary(nv.MANV))
                    {
                        if (DialogResult.OK ==
                                MessageBox.Show(
                                    "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n"
                                    + "- PHANCONG\n\nBạn có muốn xoá tất cả các bản ghi liên kết với bảng hiện tại không?",
                                    "Cảnh báo xoá", MessageBoxButtons.OKCancel))
                        {
                            if (!GUI.Delete.PHANCONG.DeleteAllRecord_HaveTableX(MyStruct.PHANCONG.enumStruct.MANV,nv.MANV.ToString()))
                            {
                                messageError += "\n\n- PHANCONG";
                            }

                            if (!GUI.Delete.NHANVIEN.DeleteRecord_Primary(nv.MANV))
                            {
                                messageError += "\n\n- NHANVIEN";
                            }

                            // thông báo lỗi
                            if (!string.IsNullOrEmpty(messageError))
                            {
                                MessageBox.Show("Không thể xoá bản ghi trong table:" + messageError);
                            }
                            else
                            {
                                MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- PHANCONG\n- NHANVIEN");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- NHANVIEN");
                    }
                    break;

                case MyStruct.MyTableName.PHANCONG:
                    MyStruct.PHANCONG pc = _Value as MyStruct.PHANCONG;
                    if (!GUI.Delete.PHANCONG.DeleteRecord_Primary(pc.MANV, pc.MADA))
                    {
                        #region để dành nâng cấp nếu thay đổi database và có table liên kết đến bảng PHANCONG

                        /*
                        //if (DialogResult.OK ==
                        //        MessageBox.Show(
                        //            "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n"
                        //            + "- ?? :D ??\n\nBạn có muốn xoá tất cả các bản ghi liên kết với bảng hiện tại không?",
                        //            "Cảnh báo xoá", MessageBoxButtons.OKCancel))
                        //{
                        //    if (!GUI.Delete.PHANCONG.DeleteAllRecord_HaveTableX(MyStruct.PHANCONG.enumStruct.MADA,
                        //            pc.MADA.ToString()))
                        //    {
                        //        messageError += "\n\n- PHANCONG";
                        //    }

                        //    if (!GUI.Delete.DUAN.DeleteRecord_Primary(pc.MADA))
                        //    {
                        //        messageError += "\n\n- DUAN";
                        //    }

                        //    // thông báo lỗi
                        //    if (!string.IsNullOrEmpty(messageError))
                        //    {
                        //        MessageBox.Show("Không thể xoá bản ghi trong table:" + messageError);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Xoá bản ghi thành công, table:\n\n- PHANCONG\n- DUAN");
                        //    }
                        //}
                        */
                        #endregion

                        MessageBox.Show("Không thể xoá bản ghi!");
                    }
                    else
                    {
                        MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- PHANCONG");
                    }
                    break;

                case MyStruct.MyTableName.PHONGBAN:
                    MyStruct.PHONGBAN pb = _Value as MyStruct.PHONGBAN;
                    if (!GUI.Delete.PHONGBAN.DeleteRecord_Primary(pb.MAPB))
                    {
                        if (DialogResult.OK ==
                                MessageBox.Show(
                                    "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n"
                                    + "- DUAN\n-NHANVIEN\n\nBạn có muốn sửa tất cả các bản ghi liên kết với bảng hiện tại không?",
                                    "Cảnh báo sửa", MessageBoxButtons.OKCancel))
                        {
                            if (!GUI.Update.NHANVIEN.UpdateAllRecord_HaveTableX(MyStruct.NHANVIEN.enumStruct.MAPB, "null"))
                            {
                                messageError += "\n\n- NHANVIEN";
                            }

                            if (!GUI.Update.DUAN.UpdateAllRecord_HaveTable(MyStruct.DUAN.enumStruct.MAPB, "null"))
                            {
                                messageError += "\n\n- DUAN";
                            }

                            if (!GUI.Delete.PHONGBAN.DeleteRecord_Primary(pb.MAPB))
                            {
                                messageError += "\n\n- PHONGBAN";
                            }

                            // thông báo lỗi
                            if (!string.IsNullOrEmpty(messageError))
                            {
                                MessageBox.Show("Không thể xoá bản ghi trong table:" + messageError);
                            }
                            else
                            {
                                MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- NHANVIEN\n- DUAN\n- PHONGBAN");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- PHONGBAN");
                    }
                    break;

                case MyStruct.MyTableName.TAIKHOAN:
                    MyStruct.TAIKHOAN tk = _Value as MyStruct.TAIKHOAN;
                    if (!GUI.Delete.TAIKHOAN.DeleteRecord_Primary(tk.ACCOUNT))
                    {
                        if (DialogResult.OK ==
                                MessageBox.Show(
                                    "Không thể xoá bản ghi!\nBản ghi hiện tại liên kết với các bản ghi trong Table:\n"
                                    + "- PHANCONG\n\nBạn có muốn xoá tất cả các bản ghi liên kết với bảng hiện tại không?",
                                    "Cảnh báo xoá", MessageBoxButtons.OKCancel))
                        {
                            if (!GUI.Update.NHANVIEN.UpdateAllRecord_HaveTableX(MyStruct.NHANVIEN.enumStruct.ACCOUNT, "null"))
                            {
                                messageError += "\n\n- NHANVIEN";
                            }

                            if (!GUI.Delete.TAIKHOAN.DeleteRecord_Primary(tk.ACCOUNT))
                            {
                                messageError += "\n\n- TAIKHOAN";
                            }

                            // thông báo lỗi
                            if (!string.IsNullOrEmpty(messageError))
                            {
                                MessageBox.Show("Không thể xoá bản ghi trong table:" + messageError);
                            }
                            else
                            {
                                MessageBox.Show("Xoá bản ghi thành công, table:\n\n- NHANVIEN\n- TAIKHOAN");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá (sửa) bản ghi thành công, table:\n\n- TAIKHOAN");
                    }
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// Click vào nút Xoá
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Xoa_Click(object sender, EventArgs e)
        {
            //button6_Xoa.Text = "Chức năng này hiện chưa được nâp cấp";
            //button6_Xoa.Enabled = false;
            switch (eNameTable)
            {
                case MyStruct.MyTableName.DUAN:
                    MyStruct.DUAN da = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.DUAN) as MyStruct.DUAN;
                    DeleteRecord(eNameTable, da);
                    break;

                case MyStruct.MyTableName.LUONG:
                    MyStruct.LUONG lg = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.LUONG) as MyStruct.LUONG;
                    DeleteRecord(eNameTable, lg);
                    break;

                case MyStruct.MyTableName.NHANVIEN:
                    MyStruct.NHANVIEN nv = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.NHANVIEN) as MyStruct.NHANVIEN;
                    DeleteRecord(eNameTable, nv);
                    break;

                case MyStruct.MyTableName.PHANCONG:
                    MyStruct.PHANCONG pc = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.PHANCONG) as MyStruct.PHANCONG;
                    DeleteRecord(eNameTable, pc);
                    break;

                case MyStruct.MyTableName.PHONGBAN:
                    MyStruct.PHONGBAN pb = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.PHONGBAN) as MyStruct.PHONGBAN;
                    DeleteRecord(eNameTable, pb);
                    break;

                case MyStruct.MyTableName.TAIKHOAN:
                    MyStruct.TAIKHOAN tk = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.TAIKHOAN) as MyStruct.TAIKHOAN;
                    DeleteRecord(eNameTable, tk);
                    break;

                default:
                    return;
            }

        }
        private void button5_LuuThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSuccess = false;

                switch (eNameTable)
                {
                    case MyStruct.MyTableName.DUAN:
                        GUI.MyStruct.DUAN da = new MyStruct.DUAN();
                        // gán giá trị từ textbox vào biến
                        da = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.DUAN) as MyStruct.DUAN;
                        bSuccess = GUI.Update.DUAN.UpdateOneRecord(da);
                        break;

                    case MyStruct.MyTableName.LUONG:
                        MyStruct.LUONG lg = new MyStruct.LUONG();
                        // gán giá trị từ textbox vào biến
                        lg = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.LUONG) as MyStruct.LUONG;
                        bSuccess = GUI.Update.LUONG.UpdateOneRecord(lg);
                        break;

                    case MyStruct.MyTableName.NHANVIEN:
                        MyStruct.NHANVIEN nv = new MyStruct.NHANVIEN();
                        // gán giá trị từ textbox vào biến
                        nv = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.NHANVIEN) as MyStruct.NHANVIEN;
                        bSuccess = GUI.Update.NHANVIEN.UpdateOneRecord(nv);
                        break;

                    case MyStruct.MyTableName.PHANCONG:
                        MyStruct.PHANCONG pc = new MyStruct.PHANCONG();
                        // gán giá trị từ textbox vào biến
                        pc = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.PHANCONG) as MyStruct.PHANCONG;
                        bSuccess = GUI.Update.PHANCONG.UpdateOneRecord(pc);
                        break;

                    case MyStruct.MyTableName.PHONGBAN:
                        MyStruct.PHONGBAN pb = new MyStruct.PHONGBAN();
                        // gán giá trị từ textbox vào biến
                        pb = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.PHONGBAN) as MyStruct.PHONGBAN;
                        bSuccess = GUI.Update.PHONGBAN.UpdateOneRecord(pb);
                        break;

                    case MyStruct.MyTableName.TAIKHOAN:
                        MyStruct.TAIKHOAN tk = new MyStruct.TAIKHOAN();
                        // gán giá trị từ textbox vào biến
                        tk = AddData_FromListTextbox_ToObject(ref ltextbox, MyStruct.MyTableName.TAIKHOAN) as MyStruct.TAIKHOAN;
                        bSuccess = GUI.Update.TAIKHOAN.UpdateOneRecord(tk);
                        break;

                    default:
                        break;
                }
                if (bSuccess)
                {
                    MessageBox.Show("Update thành công !");
                }
            }
            catch
            {
                MessageBox.Show("Không thể lưu bản ghi\n\nMột thuộc tính bị trống, xin hãy kiểm tra lại!");
            }

            this.button7_HuyBo_Click(sender, e);
            return;
        }

        private void button8_Thoat_Click(object sender, EventArgs e)
        {
            GUI.frmLogin.fmain.Show();
            this.Dispose();
        }

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI.frmLogin.fmain.Show();
            this.Dispose();
        }

        /// <summary>
        /// 
        /// Hàm tìm kiếm, bôi đậm kết quả đầu tiên tìm được
        /// 
        /// </summary>
        /// <param name="strSearch"></param>
        /// <returns></returns>
        private bool Find(string strSearch)
        {
            for (int j = 0; j < this.dataGridView1.ColumnCount; ++j)
            {
                for (int i = 0; i < this.dataGridView1.RowCount; ++i)
                {
                    try
                    {
                        if (this.dataGridView1.Rows[i].Cells[j].Value.ToString() == strSearch)
                        {
                            //dataGridView1.Rows[row].Selected = true;
                            this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
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

        /// <summary>
        /// 
        /// Click vào nút tìm kiếm
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_TimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                Find(this.textBox1.Text);
            }
        }

       
    }
}
