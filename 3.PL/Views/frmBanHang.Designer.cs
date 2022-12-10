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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            this.dgrid_QLSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Capnhatsp = new System.Windows.Forms.Button();
            this.lb_TongTiengh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Xoahet = new System.Windows.Forms.Button();
            this.btn_Xoagh = new System.Windows.Forms.Button();
            this.dgrid_Hoadonct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Tenkh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_QLHoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_Mahd = new System.Windows.Forms.Label();
            this.lb_Tienthua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Tongtientt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.txt_Tienkhdua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Makh = new System.Windows.Forms.TextBox();
            this.btn_Themkhachhang = new System.Windows.Forms.Button();
            this.btn_Taohdcho = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nhaptim);
            this.groupBox2.Controls.Add(this.dgrid_QLSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 424);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Danh Sách Sản Phẩm";
            // 
            // txt_Nhaptim
            // 
            this.txt_Nhaptim.Location = new System.Drawing.Point(51, 45);
            this.txt_Nhaptim.Name = "txt_Nhaptim";
            this.txt_Nhaptim.Size = new System.Drawing.Size(423, 29);
            this.txt_Nhaptim.TabIndex = 1;
            this.txt_Nhaptim.Text = "                  Tìm Kiếm";
            this.txt_Nhaptim.Click += new System.EventHandler(this.txt_Nhaptim_Click);
            this.txt_Nhaptim.TextChanged += new System.EventHandler(this.txt_Nhaptim_TextChanged);
            this.txt_Nhaptim.Leave += new System.EventHandler(this.txt_Nhaptim_Leave);
            // 
            // dgrid_QLSanPham
            // 
            this.dgrid_QLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_QLSanPham.Location = new System.Drawing.Point(3, 104);
            this.dgrid_QLSanPham.Name = "dgrid_QLSanPham";
            this.dgrid_QLSanPham.RowHeadersWidth = 49;
            this.dgrid_QLSanPham.RowTemplate.Height = 28;
            this.dgrid_QLSanPham.Size = new System.Drawing.Size(1151, 317);
            this.dgrid_QLSanPham.TabIndex = 0;
            this.dgrid_QLSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLSanPham_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Capnhatsp);
            this.groupBox3.Controls.Add(this.lb_TongTiengh);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_Xoahet);
            this.groupBox3.Controls.Add(this.btn_Xoagh);
            this.groupBox3.Controls.Add(this.dgrid_Hoadonct);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1157, 473);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giỏ Hàng";
            // 
            // btn_Capnhatsp
            // 
            this.btn_Capnhatsp.Image = ((System.Drawing.Image)(resources.GetObject("btn_Capnhatsp.Image")));
            this.btn_Capnhatsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Capnhatsp.Location = new System.Drawing.Point(896, 359);
            this.btn_Capnhatsp.Name = "btn_Capnhatsp";
            this.btn_Capnhatsp.Size = new System.Drawing.Size(208, 61);
            this.btn_Capnhatsp.TabIndex = 58;
            this.btn_Capnhatsp.Text = "Cập Nhật SP";
            this.btn_Capnhatsp.UseVisualStyleBackColor = true;
            this.btn_Capnhatsp.Click += new System.EventHandler(this.btn_Capnhatsp_Click);
            // 
            // lb_TongTiengh
            // 
            this.lb_TongTiengh.AutoSize = true;
            this.lb_TongTiengh.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TongTiengh.Location = new System.Drawing.Point(944, 109);
            this.lb_TongTiengh.Name = "lb_TongTiengh";
            this.lb_TongTiengh.Size = new System.Drawing.Size(94, 36);
            this.lb_TongTiengh.TabIndex = 57;
            this.lb_TongTiengh.Text = "0 VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(944, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 36);
            this.label11.TabIndex = 56;
            this.label11.Text = "Tổng Tiền :";
            // 
            // btn_Xoahet
            // 
            this.btn_Xoahet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoahet.Image")));
            this.btn_Xoahet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoahet.Location = new System.Drawing.Point(896, 276);
            this.btn_Xoahet.Name = "btn_Xoahet";
            this.btn_Xoahet.Size = new System.Drawing.Size(208, 63);
            this.btn_Xoahet.TabIndex = 55;
            this.btn_Xoahet.Text = "Xóa Giỏ Hàng";
            this.btn_Xoahet.UseVisualStyleBackColor = true;
            this.btn_Xoahet.Click += new System.EventHandler(this.btn_Xoahet_Click);
            // 
            // btn_Xoagh
            // 
            this.btn_Xoagh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoagh.Image")));
            this.btn_Xoagh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoagh.Location = new System.Drawing.Point(896, 189);
            this.btn_Xoagh.Name = "btn_Xoagh";
            this.btn_Xoagh.Size = new System.Drawing.Size(208, 63);
            this.btn_Xoagh.TabIndex = 54;
            this.btn_Xoagh.Text = "Xóa SP";
            this.btn_Xoagh.UseVisualStyleBackColor = true;
            this.btn_Xoagh.Click += new System.EventHandler(this.btn_Xoagh_Click);
            // 
            // dgrid_Hoadonct
            // 
            this.dgrid_Hoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Hoadonct.Location = new System.Drawing.Point(26, 49);
            this.dgrid_Hoadonct.Name = "dgrid_Hoadonct";
            this.dgrid_Hoadonct.RowHeadersWidth = 49;
            this.dgrid_Hoadonct.RowTemplate.Height = 28;
            this.dgrid_Hoadonct.Size = new System.Drawing.Size(811, 371);
            this.dgrid_Hoadonct.TabIndex = 0;
            this.dgrid_Hoadonct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Hoadonct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Tenkh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgrid_QLHoaDon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_Makh);
            this.groupBox1.Controls.Add(this.btn_Themkhachhang);
            this.groupBox1.Controls.Add(this.btn_Taohdcho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1157, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 897);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Chờ Thanh Toán";
            // 
            // lb_Tenkh
            // 
            this.lb_Tenkh.AutoSize = true;
            this.lb_Tenkh.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tenkh.Location = new System.Drawing.Point(158, 351);
            this.lb_Tenkh.Name = "lb_Tenkh";
            this.lb_Tenkh.Size = new System.Drawing.Size(36, 25);
            this.lb_Tenkh.TabIndex = 61;
            this.lb_Tenkh.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên KH :";
            // 
            // dgrid_QLHoaDon
            // 
            this.dgrid_QLHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_QLHoaDon.Location = new System.Drawing.Point(3, 25);
            this.dgrid_QLHoaDon.Name = "dgrid_QLHoaDon";
            this.dgrid_QLHoaDon.RowHeadersWidth = 49;
            this.dgrid_QLHoaDon.RowTemplate.Height = 28;
            this.dgrid_QLHoaDon.Size = new System.Drawing.Size(597, 227);
            this.dgrid_QLHoaDon.TabIndex = 1;
            this.dgrid_QLHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLHoaDon_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã KH :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_Mahd);
            this.groupBox4.Controls.Add(this.lb_Tienthua);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lb_Tongtientt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btn_Thanhtoan);
            this.groupBox4.Controls.Add(this.txt_Tienkhdua);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(3, 554);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 340);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh Toán";
            // 
            // lb_Mahd
            // 
            this.lb_Mahd.AutoSize = true;
            this.lb_Mahd.Location = new System.Drawing.Point(178, 41);
            this.lb_Mahd.Name = "lb_Mahd";
            this.lb_Mahd.Size = new System.Drawing.Size(16, 20);
            this.lb_Mahd.TabIndex = 63;
            this.lb_Mahd.Text = "?";
            // 
            // lb_Tienthua
            // 
            this.lb_Tienthua.AutoSize = true;
            this.lb_Tienthua.Location = new System.Drawing.Point(161, 121);
            this.lb_Tienthua.Name = "lb_Tienthua";
            this.lb_Tienthua.Size = new System.Drawing.Size(55, 20);
            this.lb_Tienthua.TabIndex = 62;
            this.lb_Tienthua.Text = "0 VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tiền Thừa :";
            // 
            // lb_Tongtientt
            // 
            this.lb_Tongtientt.AutoSize = true;
            this.lb_Tongtientt.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Tongtientt.Location = new System.Drawing.Point(284, 177);
            this.lb_Tongtientt.Name = "lb_Tongtientt";
            this.lb_Tongtientt.Size = new System.Drawing.Size(94, 36);
            this.lb_Tongtientt.TabIndex = 60;
            this.lb_Tongtientt.Text = "0 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(114, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 36);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tổng Tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mã Hóa Đơn :";
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thanhtoan.Image")));
            this.btn_Thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thanhtoan.Location = new System.Drawing.Point(133, 249);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(245, 64);
            this.btn_Thanhtoan.TabIndex = 51;
            this.btn_Thanhtoan.Text = "Thanh Toán";
            this.btn_Thanhtoan.UseVisualStyleBackColor = true;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // txt_Tienkhdua
            // 
            this.txt_Tienkhdua.Location = new System.Drawing.Point(161, 80);
            this.txt_Tienkhdua.Name = "txt_Tienkhdua";
            this.txt_Tienkhdua.Size = new System.Drawing.Size(256, 26);
            this.txt_Tienkhdua.TabIndex = 47;
            this.txt_Tienkhdua.TextChanged += new System.EventHandler(this.txt_Tienkhdua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tiền khách đưa:";
            // 
            // txt_Makh
            // 
            this.txt_Makh.Location = new System.Drawing.Point(158, 308);
            this.txt_Makh.Name = "txt_Makh";
            this.txt_Makh.Size = new System.Drawing.Size(253, 29);
            this.txt_Makh.TabIndex = 52;
            this.txt_Makh.TextChanged += new System.EventHandler(this.txt_Makh_TextChanged);
            // 
            // btn_Themkhachhang
            // 
            this.btn_Themkhachhang.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Themkhachhang.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Themkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themkhachhang.Image")));
            this.btn_Themkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Themkhachhang.Location = new System.Drawing.Point(37, 411);
            this.btn_Themkhachhang.Name = "btn_Themkhachhang";
            this.btn_Themkhachhang.Size = new System.Drawing.Size(197, 56);
            this.btn_Themkhachhang.TabIndex = 54;
            this.btn_Themkhachhang.Text = "Khách Hàng";
            this.btn_Themkhachhang.UseVisualStyleBackColor = false;
            this.btn_Themkhachhang.Click += new System.EventHandler(this.btn_Themkhachhang_Click);
            // 
            // btn_Taohdcho
            // 
            this.btn_Taohdcho.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Taohdcho.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Taohdcho.Image = ((System.Drawing.Image)(resources.GetObject("btn_Taohdcho.Image")));
            this.btn_Taohdcho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Taohdcho.Location = new System.Drawing.Point(261, 411);
            this.btn_Taohdcho.Name = "btn_Taohdcho";
            this.btn_Taohdcho.Size = new System.Drawing.Size(193, 56);
            this.btn_Taohdcho.TabIndex = 52;
            this.btn_Taohdcho.Text = "Hóa Đơn chờ";
            this.btn_Taohdcho.UseVisualStyleBackColor = false;
            this.btn_Taohdcho.Click += new System.EventHandler(this.btn_Taohdcho_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1760, 897);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Tienkhdua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.Button btn_Taohdcho;
        private System.Windows.Forms.Button btn_Xoahet;
        private System.Windows.Forms.Button btn_Xoagh;
        private System.Windows.Forms.Button btn_Themkhachhang;
        private System.Windows.Forms.Label lb_TongTiengh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Makh;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_Capnhatsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Tongtientt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Tienthua;
        private System.Windows.Forms.Label lb_Mahd;
        private System.Windows.Forms.TextBox txt_Nhaptim;
    }
}