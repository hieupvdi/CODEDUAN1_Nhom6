namespace _3.PL.Views
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            this.dgrid_QLSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Themanh = new System.Windows.Forms.Button();
            this.btn_ThemSize = new System.Windows.Forms.Button();
            this.btn_Themloaisp = new System.Windows.Forms.Button();
            this.txt_Masp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_Anh = new System.Windows.Forms.PictureBox();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tensp = new System.Windows.Forms.TextBox();
            this.cmb_Loaisp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtn_Nghiban = new System.Windows.Forms.RadioButton();
            this.rbtn_ConBan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Giaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Nhaptim);
            this.groupBox2.Controls.Add(this.dgrid_QLSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 424);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1401, 413);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // txt_Nhaptim
            // 
            this.txt_Nhaptim.Location = new System.Drawing.Point(78, 47);
            this.txt_Nhaptim.Name = "txt_Nhaptim";
            this.txt_Nhaptim.Size = new System.Drawing.Size(423, 29);
            this.txt_Nhaptim.TabIndex = 2;
            this.txt_Nhaptim.Text = "                  Tìm Kiếm";
            this.txt_Nhaptim.Click += new System.EventHandler(this.txt_Nhaptim_Click);
            this.txt_Nhaptim.TextChanged += new System.EventHandler(this.txt_Nhaptim_TextChanged);
            this.txt_Nhaptim.Leave += new System.EventHandler(this.txt_Nhaptim_Leave);
            // 
            // dgrid_QLSanPham
            // 
            this.dgrid_QLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_QLSanPham.Location = new System.Drawing.Point(4, 98);
            this.dgrid_QLSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrid_QLSanPham.Name = "dgrid_QLSanPham";
            this.dgrid_QLSanPham.RowHeadersWidth = 49;
            this.dgrid_QLSanPham.RowTemplate.Height = 28;
            this.dgrid_QLSanPham.Size = new System.Drawing.Size(1393, 312);
            this.dgrid_QLSanPham.TabIndex = 0;
            this.dgrid_QLSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLSanPham_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_Clear);
            this.groupBox3.Controls.Add(this.btn_Xóa);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1125, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(276, 424);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Vụ";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(4, 184);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(268, 51);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_clre_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xóa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xóa.Image")));
            this.btn_Xóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xóa.Location = new System.Drawing.Point(4, 137);
            this.btn_Xóa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(268, 47);
            this.btn_Xóa.TabIndex = 2;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(4, 81);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(268, 56);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Cập Nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(4, 25);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(268, 56);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm Sản Phẩm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Themanh);
            this.groupBox1.Controls.Add(this.btn_ThemSize);
            this.groupBox1.Controls.Add(this.btn_Themloaisp);
            this.groupBox1.Controls.Add(this.txt_Masp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_Anh);
            this.groupBox1.Controls.Add(this.cmb_Size);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Tensp);
            this.groupBox1.Controls.Add(this.cmb_Loaisp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbtn_Nghiban);
            this.groupBox1.Controls.Add(this.rbtn_ConBan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Giaban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1125, 424);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // btn_Themanh
            // 
            this.btn_Themanh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themanh.Image")));
            this.btn_Themanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Themanh.Location = new System.Drawing.Point(618, 279);
            this.btn_Themanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Themanh.Name = "btn_Themanh";
            this.btn_Themanh.Size = new System.Drawing.Size(192, 54);
            this.btn_Themanh.TabIndex = 42;
            this.btn_Themanh.Text = "Thêm Ảnh";
            this.btn_Themanh.UseVisualStyleBackColor = true;
            this.btn_Themanh.Click += new System.EventHandler(this.btn_Themanh_Click);
            // 
            // btn_ThemSize
            // 
            this.btn_ThemSize.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemSize.Image")));
            this.btn_ThemSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemSize.Location = new System.Drawing.Point(846, 353);
            this.btn_ThemSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ThemSize.Name = "btn_ThemSize";
            this.btn_ThemSize.Size = new System.Drawing.Size(192, 54);
            this.btn_ThemSize.TabIndex = 41;
            this.btn_ThemSize.Text = "Thêm Size";
            this.btn_ThemSize.UseVisualStyleBackColor = true;
            this.btn_ThemSize.Click += new System.EventHandler(this.btn_ThemSize_Click);
            // 
            // btn_Themloaisp
            // 
            this.btn_Themloaisp.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themloaisp.Image")));
            this.btn_Themloaisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Themloaisp.Location = new System.Drawing.Point(618, 353);
            this.btn_Themloaisp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Themloaisp.Name = "btn_Themloaisp";
            this.btn_Themloaisp.Size = new System.Drawing.Size(200, 54);
            this.btn_Themloaisp.TabIndex = 2;
            this.btn_Themloaisp.Text = "Thêm Loại SP";
            this.btn_Themloaisp.UseVisualStyleBackColor = true;
            this.btn_Themloaisp.Click += new System.EventHandler(this.btn_Themloaisp_Click);
            // 
            // txt_Masp
            // 
            this.txt_Masp.Location = new System.Drawing.Point(175, 40);
            this.txt_Masp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Masp.Name = "txt_Masp";
            this.txt_Masp.Size = new System.Drawing.Size(326, 29);
            this.txt_Masp.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã Sản Phẩm";
            // 
            // pb_Anh
            // 
            this.pb_Anh.BackColor = System.Drawing.SystemColors.Info;
            this.pb_Anh.Location = new System.Drawing.Point(618, 28);
            this.pb_Anh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_Anh.Name = "pb_Anh";
            this.pb_Anh.Size = new System.Drawing.Size(578, 227);
            this.pb_Anh.TabIndex = 38;
            this.pb_Anh.TabStop = false;
            // 
            // cmb_Size
            // 
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(175, 181);
            this.cmb_Size.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(240, 29);
            this.cmb_Size.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Size";
            // 
            // txt_Tensp
            // 
            this.txt_Tensp.Location = new System.Drawing.Point(175, 85);
            this.txt_Tensp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Tensp.Name = "txt_Tensp";
            this.txt_Tensp.Size = new System.Drawing.Size(326, 29);
            this.txt_Tensp.TabIndex = 35;
            // 
            // cmb_Loaisp
            // 
            this.cmb_Loaisp.FormattingEnabled = true;
            this.cmb_Loaisp.Location = new System.Drawing.Point(174, 135);
            this.cmb_Loaisp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Loaisp.Name = "cmb_Loaisp";
            this.cmb_Loaisp.Size = new System.Drawing.Size(240, 29);
            this.cmb_Loaisp.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Loaị SP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sản Phẩm";
            // 
            // rbtn_Nghiban
            // 
            this.rbtn_Nghiban.AutoSize = true;
            this.rbtn_Nghiban.Location = new System.Drawing.Point(319, 308);
            this.rbtn_Nghiban.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_Nghiban.Name = "rbtn_Nghiban";
            this.rbtn_Nghiban.Size = new System.Drawing.Size(99, 25);
            this.rbtn_Nghiban.TabIndex = 30;
            this.rbtn_Nghiban.TabStop = true;
            this.rbtn_Nghiban.Text = "Nghỉ Bán";
            this.rbtn_Nghiban.UseVisualStyleBackColor = true;
            // 
            // rbtn_ConBan
            // 
            this.rbtn_ConBan.AutoSize = true;
            this.rbtn_ConBan.Location = new System.Drawing.Point(174, 308);
            this.rbtn_ConBan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_ConBan.Name = "rbtn_ConBan";
            this.rbtn_ConBan.Size = new System.Drawing.Size(91, 25);
            this.rbtn_ConBan.TabIndex = 29;
            this.rbtn_ConBan.TabStop = true;
            this.rbtn_ConBan.Text = "Còn Bán";
            this.rbtn_ConBan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Trạng Thái";
            // 
            // txt_Giaban
            // 
            this.txt_Giaban.Location = new System.Drawing.Point(175, 238);
            this.txt_Giaban.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Giaban.Name = "txt_Giaban";
            this.txt_Giaban.Size = new System.Drawing.Size(335, 29);
            this.txt_Giaban.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Gía Bán";
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1401, 837);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_QLSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Giaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_Nghiban;
        private System.Windows.Forms.RadioButton rbtn_ConBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Loaisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tensp;
        private System.Windows.Forms.PictureBox pb_Anh;
        private System.Windows.Forms.TextBox txt_Masp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThemSize;
        private System.Windows.Forms.Button btn_Themloaisp;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Themanh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_Nhaptim;
    }
}