namespace _3.PL.Views
{
    partial class frmQLNhanVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrid_QLNhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Anh = new System.Windows.Forms.PictureBox();
            this.btn_Themanh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_ThemCV = new System.Windows.Forms.Button();
            this.rbtn_Nghiviec = new System.Windows.Forms.RadioButton();
            this.rbtn_Danglam = new System.Windows.Forms.RadioButton();
            this.date_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cmb_Chucvu = new System.Windows.Forms.ComboBox();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_Tennv = new System.Windows.Forms.TextBox();
            this.txt_Manv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLNhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_QLNhanvien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1402, 372);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgrid_QLNhanvien
            // 
            this.dgrid_QLNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLNhanvien.Location = new System.Drawing.Point(35, 97);
            this.dgrid_QLNhanvien.Name = "dgrid_QLNhanvien";
            this.dgrid_QLNhanvien.RowHeadersWidth = 49;
            this.dgrid_QLNhanvien.RowTemplate.Height = 28;
            this.dgrid_QLNhanvien.Size = new System.Drawing.Size(1319, 220);
            this.dgrid_QLNhanvien.TabIndex = 0;
            this.dgrid_QLNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLNhanvien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Anh);
            this.groupBox1.Controls.Add(this.btn_Themanh);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txt_Diachi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_ThemCV);
            this.groupBox1.Controls.Add(this.rbtn_Nghiviec);
            this.groupBox1.Controls.Add(this.rbtn_Danglam);
            this.groupBox1.Controls.Add(this.date_Ngaysinh);
            this.groupBox1.Controls.Add(this.cmb_Chucvu);
            this.groupBox1.Controls.Add(this.txt_Matkhau);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Sdt);
            this.groupBox1.Controls.Add(this.txt_Tennv);
            this.groupBox1.Controls.Add(this.txt_Manv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1402, 446);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // pb_Anh
            // 
            this.pb_Anh.BackColor = System.Drawing.SystemColors.Info;
            this.pb_Anh.Location = new System.Drawing.Point(789, 44);
            this.pb_Anh.Name = "pb_Anh";
            this.pb_Anh.Size = new System.Drawing.Size(324, 337);
            this.pb_Anh.TabIndex = 29;
            this.pb_Anh.TabStop = false;
            // 
            // btn_Themanh
            // 
            this.btn_Themanh.Location = new System.Drawing.Point(430, 301);
            this.btn_Themanh.Name = "btn_Themanh";
            this.btn_Themanh.Size = new System.Drawing.Size(286, 59);
            this.btn_Themanh.TabIndex = 28;
            this.btn_Themanh.Text = "Thêm Hình Ảnh";
            this.btn_Themanh.UseVisualStyleBackColor = true;
            this.btn_Themanh.Click += new System.EventHandler(this.btn_Themanh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_Nam);
            this.panel2.Controls.Add(this.rbtn_Nu);
            this.panel2.Location = new System.Drawing.Point(140, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 50);
            this.panel2.TabIndex = 25;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(3, 18);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(59, 24);
            this.rbtn_Nam.TabIndex = 20;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(105, 18);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(47, 24);
            this.rbtn_Nu.TabIndex = 21;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(137, 342);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(196, 26);
            this.txt_Diachi.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Địa Chỉ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1190, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 421);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Vụ";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sua.Location = new System.Drawing.Point(3, 50);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(203, 28);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Cập Nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Location = new System.Drawing.Point(3, 22);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(203, 28);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm Nhân Viên";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_ThemCV
            // 
            this.btn_ThemCV.Location = new System.Drawing.Point(430, 228);
            this.btn_ThemCV.Name = "btn_ThemCV";
            this.btn_ThemCV.Size = new System.Drawing.Size(286, 59);
            this.btn_ThemCV.TabIndex = 24;
            this.btn_ThemCV.Text = "Thêm Chức Vụ";
            this.btn_ThemCV.UseVisualStyleBackColor = true;
            this.btn_ThemCV.Click += new System.EventHandler(this.btn_ThemCV_Click);
            // 
            // rbtn_Nghiviec
            // 
            this.rbtn_Nghiviec.AutoSize = true;
            this.rbtn_Nghiviec.Location = new System.Drawing.Point(627, 182);
            this.rbtn_Nghiviec.Name = "rbtn_Nghiviec";
            this.rbtn_Nghiviec.Size = new System.Drawing.Size(89, 24);
            this.rbtn_Nghiviec.TabIndex = 23;
            this.rbtn_Nghiviec.TabStop = true;
            this.rbtn_Nghiviec.Text = "Nghỉ việc";
            this.rbtn_Nghiviec.UseVisualStyleBackColor = true;
            // 
            // rbtn_Danglam
            // 
            this.rbtn_Danglam.AutoSize = true;
            this.rbtn_Danglam.Location = new System.Drawing.Point(526, 182);
            this.rbtn_Danglam.Name = "rbtn_Danglam";
            this.rbtn_Danglam.Size = new System.Drawing.Size(95, 24);
            this.rbtn_Danglam.TabIndex = 22;
            this.rbtn_Danglam.TabStop = true;
            this.rbtn_Danglam.Text = "Đang Làm";
            this.rbtn_Danglam.UseVisualStyleBackColor = true;
            // 
            // date_Ngaysinh
            // 
            this.date_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Ngaysinh.Location = new System.Drawing.Point(137, 228);
            this.date_Ngaysinh.Name = "date_Ngaysinh";
            this.date_Ngaysinh.Size = new System.Drawing.Size(196, 26);
            this.date_Ngaysinh.TabIndex = 19;
            // 
            // cmb_Chucvu
            // 
            this.cmb_Chucvu.FormattingEnabled = true;
            this.cmb_Chucvu.Location = new System.Drawing.Point(140, 130);
            this.cmb_Chucvu.Name = "cmb_Chucvu";
            this.cmb_Chucvu.Size = new System.Drawing.Size(193, 27);
            this.cmb_Chucvu.TabIndex = 18;
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(526, 118);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(190, 26);
            this.txt_Matkhau.TabIndex = 17;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(526, 65);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(190, 26);
            this.txt_Email.TabIndex = 16;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(140, 292);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(193, 26);
            this.txt_Sdt.TabIndex = 15;
            // 
            // txt_Tennv
            // 
            this.txt_Tennv.Location = new System.Drawing.Point(137, 82);
            this.txt_Tennv.Name = "txt_Tennv";
            this.txt_Tennv.Size = new System.Drawing.Size(196, 26);
            this.txt_Tennv.TabIndex = 14;
            // 
            // txt_Manv
            // 
            this.txt_Manv.Location = new System.Drawing.Point(137, 30);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(196, 26);
            this.txt_Manv.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã NV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Trạng Thái";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Sinh";
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 818);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmQLNhanVien";
            this.Text = "frmQLNhanVien";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLNhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_QLNhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_ThemCV;
        private System.Windows.Forms.RadioButton rbtn_Nghiviec;
        private System.Windows.Forms.RadioButton rbtn_Danglam;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.DateTimePicker date_Ngaysinh;
        private System.Windows.Forms.ComboBox cmb_Chucvu;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_Tennv;
        private System.Windows.Forms.TextBox txt_Manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Themanh;
        private System.Windows.Forms.PictureBox pb_Anh;
    }
}