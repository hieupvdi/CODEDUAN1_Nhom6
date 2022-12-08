namespace _3.PL.Views
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Tenkh = new System.Windows.Forms.TextBox();
            this.txt_Makh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dggrid_Khachhang = new System.Windows.Forms.DataGridView();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dggrid_Khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(585, 242);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(255, 62);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(292, 242);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(255, 62);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Cập Nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(13, 242);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(255, 62);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tenkh
            // 
            this.txt_Tenkh.Location = new System.Drawing.Point(178, 78);
            this.txt_Tenkh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Tenkh.Name = "txt_Tenkh";
            this.txt_Tenkh.Size = new System.Drawing.Size(402, 29);
            this.txt_Tenkh.TabIndex = 12;
            // 
            // txt_Makh
            // 
            this.txt_Makh.Location = new System.Drawing.Point(178, 28);
            this.txt_Makh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Makh.Name = "txt_Makh";
            this.txt_Makh.Size = new System.Drawing.Size(402, 29);
            this.txt_Makh.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã KH";
            // 
            // dggrid_Khachhang
            // 
            this.dggrid_Khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggrid_Khachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dggrid_Khachhang.Location = new System.Drawing.Point(0, 392);
            this.dggrid_Khachhang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dggrid_Khachhang.Name = "dggrid_Khachhang";
            this.dggrid_Khachhang.RowHeadersWidth = 49;
            this.dggrid_Khachhang.RowTemplate.Height = 28;
            this.dggrid_Khachhang.Size = new System.Drawing.Size(864, 273);
            this.dggrid_Khachhang.TabIndex = 8;
            this.dggrid_Khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dggrid_Khachhang_CellClick);
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(178, 128);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(402, 29);
            this.txt_Sdt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "SĐT";
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(178, 178);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(402, 29);
            this.txt_Diachi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Địa Chỉ";
            // 
            // txt_Nhaptim
            // 
            this.txt_Nhaptim.Location = new System.Drawing.Point(13, 339);
            this.txt_Nhaptim.Name = "txt_Nhaptim";
            this.txt_Nhaptim.Size = new System.Drawing.Size(423, 29);
            this.txt_Nhaptim.TabIndex = 20;
            this.txt_Nhaptim.Text = "                  Tìm Kiếm";
            this.txt_Nhaptim.Click += new System.EventHandler(this.txt_Nhaptim_Click);
            this.txt_Nhaptim.TextChanged += new System.EventHandler(this.txt_Nhaptim_TextChanged);
            this.txt_Nhaptim.Leave += new System.EventHandler(this.txt_Nhaptim_Leave);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 665);
            this.Controls.Add(this.txt_Nhaptim);
            this.Controls.Add(this.txt_Diachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Sdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tenkh);
            this.Controls.Add(this.txt_Makh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggrid_Khachhang);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dggrid_Khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Tenkh;
        private System.Windows.Forms.TextBox txt_Makh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dggrid_Khachhang;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nhaptim;
    }
}