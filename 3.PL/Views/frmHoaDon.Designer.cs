namespace _3.PL.Views
{
    partial class frmHoaDon
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
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_DaTT = new System.Windows.Forms.RadioButton();
            this.rbtn_ChuaTT = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_TGtao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_TGTT = new System.Windows.Forms.DateTimePicker();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Mahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Khachhang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Nhanvien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_HoaDon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1291, 372);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(35, 97);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 49;
            this.dgrid_HoaDon.RowTemplate.Height = 28;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(1206, 220);
            this.dgrid_HoaDon.TabIndex = 0;
            this.dgrid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbtn_DaTT);
            this.groupBox1.Controls.Add(this.rbtn_ChuaTT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Diachi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_TGtao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_TGTT);
            this.groupBox1.Controls.Add(this.txt_Sdt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Mahd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Khachhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Nhanvien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1291, 410);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // rbtn_DaTT
            // 
            this.rbtn_DaTT.AutoSize = true;
            this.rbtn_DaTT.Location = new System.Drawing.Point(489, 170);
            this.rbtn_DaTT.Name = "rbtn_DaTT";
            this.rbtn_DaTT.Size = new System.Drawing.Size(126, 24);
            this.rbtn_DaTT.TabIndex = 42;
            this.rbtn_DaTT.TabStop = true;
            this.rbtn_DaTT.Text = "Đã Thanh Toán";
            this.rbtn_DaTT.UseVisualStyleBackColor = true;
            // 
            // rbtn_ChuaTT
            // 
            this.rbtn_ChuaTT.AutoSize = true;
            this.rbtn_ChuaTT.Location = new System.Drawing.Point(489, 121);
            this.rbtn_ChuaTT.Name = "rbtn_ChuaTT";
            this.rbtn_ChuaTT.Size = new System.Drawing.Size(141, 24);
            this.rbtn_ChuaTT.TabIndex = 41;
            this.rbtn_ChuaTT.TabStop = true;
            this.rbtn_ChuaTT.Text = "Chưa Thanh Toán";
            this.rbtn_ChuaTT.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Trạng Thái";
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(489, 59);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(120, 26);
            this.txt_Diachi.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Địa Chỉ";
            // 
            // date_TGtao
            // 
            this.date_TGtao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TGtao.Location = new System.Drawing.Point(158, 194);
            this.date_TGtao.Name = "date_TGtao";
            this.date_TGtao.Size = new System.Drawing.Size(172, 26);
            this.date_TGtao.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Thời Gian Tạo";
            // 
            // date_TGTT
            // 
            this.date_TGTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TGTT.Location = new System.Drawing.Point(199, 250);
            this.date_TGTT.Name = "date_TGTT";
            this.date_TGTT.Size = new System.Drawing.Size(131, 26);
            this.date_TGTT.TabIndex = 35;
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(134, 299);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(193, 26);
            this.txt_Sdt.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Thời Gian Thanh Toán";
            // 
            // txt_Mahd
            // 
            this.txt_Mahd.Location = new System.Drawing.Point(134, 52);
            this.txt_Mahd.Name = "txt_Mahd";
            this.txt_Mahd.Size = new System.Drawing.Size(193, 26);
            this.txt_Mahd.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // cmb_Khachhang
            // 
            this.cmb_Khachhang.FormattingEnabled = true;
            this.cmb_Khachhang.Location = new System.Drawing.Point(134, 147);
            this.cmb_Khachhang.Name = "cmb_Khachhang";
            this.cmb_Khachhang.Size = new System.Drawing.Size(193, 27);
            this.cmb_Khachhang.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Khách hàng";
            // 
            // cmb_Nhanvien
            // 
            this.cmb_Nhanvien.FormattingEnabled = true;
            this.cmb_Nhanvien.Location = new System.Drawing.Point(134, 105);
            this.cmb_Nhanvien.Name = "cmb_Nhanvien";
            this.cmb_Nhanvien.Size = new System.Drawing.Size(193, 27);
            this.cmb_Nhanvien.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1079, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 385);
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
            this.btn_Them.Text = "Thêm Hóa Đơn";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_HoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cmb_Khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Nhanvien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Mahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_TGtao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_TGTT;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_DaTT;
        private System.Windows.Forms.RadioButton rbtn_ChuaTT;
        private System.Windows.Forms.Label label9;
    }
}