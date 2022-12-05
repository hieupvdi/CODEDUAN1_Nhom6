namespace _3.PL.Views
{
    partial class frmBanHang
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
            this.dgrid_QLSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Xoahet = new System.Windows.Forms.Button();
            this.btn_Xoagh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Makh = new System.Windows.Forms.TextBox();
            this.btn_Themkhachhang = new System.Windows.Forms.Button();
            this.dgrid_QLHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_Taohdcho = new System.Windows.Forms.Button();
            this.dgrid_Hoadonct = new System.Windows.Forms.DataGridView();
            this.cmb_Nhanvien = new System.Windows.Forms.ComboBox();
            this.cmb_Khachhang = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrid_QLSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 320);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm";
            // 
            // dgrid_QLSanPham
            // 
            this.dgrid_QLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLSanPham.Location = new System.Drawing.Point(26, 50);
            this.dgrid_QLSanPham.Name = "dgrid_QLSanPham";
            this.dgrid_QLSanPham.RowHeadersWidth = 49;
            this.dgrid_QLSanPham.RowTemplate.Height = 28;
            this.dgrid_QLSanPham.Size = new System.Drawing.Size(904, 246);
            this.dgrid_QLSanPham.TabIndex = 0;
            this.dgrid_QLSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLSanPham_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_TongTien);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_Xoahet);
            this.groupBox3.Controls.Add(this.btn_Xoagh);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dgrid_Hoadonct);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1086, 596);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giỏ Hàng";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(164, 503);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(33, 20);
            this.lb_TongTien.TabIndex = 57;
            this.lb_TongTien.Text = "$$$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Tổng Tiền :";
            // 
            // btn_Xoahet
            // 
            this.btn_Xoahet.Location = new System.Drawing.Point(523, 512);
            this.btn_Xoahet.Name = "btn_Xoahet";
            this.btn_Xoahet.Size = new System.Drawing.Size(114, 50);
            this.btn_Xoahet.TabIndex = 55;
            this.btn_Xoahet.Text = "Xóa Hết";
            this.btn_Xoahet.UseVisualStyleBackColor = true;
            this.btn_Xoahet.Click += new System.EventHandler(this.btn_Xoahet_Click);
            // 
            // btn_Xoagh
            // 
            this.btn_Xoagh.Location = new System.Drawing.Point(371, 512);
            this.btn_Xoagh.Name = "btn_Xoagh";
            this.btn_Xoagh.Size = new System.Drawing.Size(114, 50);
            this.btn_Xoagh.TabIndex = 54;
            this.btn_Xoagh.Text = "Xóa Giỏ Hàng";
            this.btn_Xoagh.UseVisualStyleBackColor = true;
            this.btn_Xoagh.Click += new System.EventHandler(this.btn_Xoagh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Makh);
            this.groupBox1.Controls.Add(this.btn_Themkhachhang);
            this.groupBox1.Controls.Add(this.dgrid_QLHoaDon);
            this.groupBox1.Controls.Add(this.btn_Taohdcho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(683, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn chờ";
            // 
            // txt_Makh
            // 
            this.txt_Makh.Location = new System.Drawing.Point(22, 418);
            this.txt_Makh.Name = "txt_Makh";
            this.txt_Makh.Size = new System.Drawing.Size(355, 26);
            this.txt_Makh.TabIndex = 52;
            // 
            // btn_Themkhachhang
            // 
            this.btn_Themkhachhang.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Themkhachhang.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Themkhachhang.Location = new System.Drawing.Point(22, 472);
            this.btn_Themkhachhang.Name = "btn_Themkhachhang";
            this.btn_Themkhachhang.Size = new System.Drawing.Size(170, 49);
            this.btn_Themkhachhang.TabIndex = 54;
            this.btn_Themkhachhang.Text = "Thêm Khách Hàng";
            this.btn_Themkhachhang.UseVisualStyleBackColor = false;
            this.btn_Themkhachhang.Click += new System.EventHandler(this.btn_Themkhachhang_Click);
            // 
            // dgrid_QLHoaDon
            // 
            this.dgrid_QLHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLHoaDon.Location = new System.Drawing.Point(22, 37);
            this.dgrid_QLHoaDon.Name = "dgrid_QLHoaDon";
            this.dgrid_QLHoaDon.RowHeadersWidth = 49;
            this.dgrid_QLHoaDon.RowTemplate.Height = 28;
            this.dgrid_QLHoaDon.Size = new System.Drawing.Size(355, 358);
            this.dgrid_QLHoaDon.TabIndex = 1;
            this.dgrid_QLHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLHoaDon_CellClick);
            // 
            // btn_Taohdcho
            // 
            this.btn_Taohdcho.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Taohdcho.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Taohdcho.Location = new System.Drawing.Point(227, 472);
            this.btn_Taohdcho.Name = "btn_Taohdcho";
            this.btn_Taohdcho.Size = new System.Drawing.Size(150, 49);
            this.btn_Taohdcho.TabIndex = 52;
            this.btn_Taohdcho.Text = "Tạo Hóa Đơn chờ";
            this.btn_Taohdcho.UseVisualStyleBackColor = false;
            this.btn_Taohdcho.Click += new System.EventHandler(this.btn_Taohdcho_Click);
            // 
            // dgrid_Hoadonct
            // 
            this.dgrid_Hoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Hoadonct.Location = new System.Drawing.Point(26, 49);
            this.dgrid_Hoadonct.Name = "dgrid_Hoadonct";
            this.dgrid_Hoadonct.RowHeadersWidth = 49;
            this.dgrid_Hoadonct.RowTemplate.Height = 28;
            this.dgrid_Hoadonct.Size = new System.Drawing.Size(627, 368);
            this.dgrid_Hoadonct.TabIndex = 0;
            this.dgrid_Hoadonct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Hoadonct_CellClick);
            // 
            // cmb_Nhanvien
            // 
            this.cmb_Nhanvien.FormattingEnabled = true;
            this.cmb_Nhanvien.Location = new System.Drawing.Point(131, 36);
            this.cmb_Nhanvien.Name = "cmb_Nhanvien";
            this.cmb_Nhanvien.Size = new System.Drawing.Size(256, 27);
            this.cmb_Nhanvien.TabIndex = 35;
            // 
            // cmb_Khachhang
            // 
            this.cmb_Khachhang.FormattingEnabled = true;
            this.cmb_Khachhang.Location = new System.Drawing.Point(131, 73);
            this.cmb_Khachhang.Name = "cmb_Khachhang";
            this.cmb_Khachhang.Size = new System.Drawing.Size(256, 27);
            this.cmb_Khachhang.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Sua);
            this.groupBox4.Controls.Add(this.txt_Diachi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmb_Nhanvien);
            this.groupBox4.Controls.Add(this.cmb_Khachhang);
            this.groupBox4.Controls.Add(this.txt_Sdt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(1086, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(443, 916);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(38, 695);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(365, 64);
            this.btn_Sua.TabIndex = 51;
            this.btn_Sua.Text = "Thanh Toán";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(131, 170);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(256, 26);
            this.txt_Diachi.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(131, 123);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(256, 26);
            this.txt_Sdt.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nhân Viên";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1529, 916);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_QLSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_Hoadonct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_QLHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Taohdcho;
        private System.Windows.Forms.Button btn_Xoahet;
        private System.Windows.Forms.Button btn_Xoagh;
        private System.Windows.Forms.Button btn_Themkhachhang;
        private System.Windows.Forms.ComboBox cmb_Nhanvien;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Makh;
        private System.Windows.Forms.TextBox txt_id;
    }
}