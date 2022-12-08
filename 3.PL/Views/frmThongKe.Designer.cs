namespace _3.PL.Views
{
    partial class frmThongKe
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
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            this.dgrid_Thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Doanhthungay = new System.Windows.Forms.Label();
            this.lb_Doanhthuthang = new System.Windows.Forms.Label();
            this.llb_Doanhthunam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Sodonngay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Sodonthang = new System.Windows.Forms.Label();
            this.lb_Sodonnam = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nhaptim);
            this.groupBox2.Controls.Add(this.dgrid_Thongke);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 366);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1339, 391);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // txt_Nhaptim
            // 
            this.txt_Nhaptim.Location = new System.Drawing.Point(28, 56);
            this.txt_Nhaptim.Name = "txt_Nhaptim";
            this.txt_Nhaptim.Size = new System.Drawing.Size(423, 29);
            this.txt_Nhaptim.TabIndex = 22;
            this.txt_Nhaptim.Text = "                  Tìm Kiếm";
            this.txt_Nhaptim.Click += new System.EventHandler(this.txt_Nhaptim_Click);
            this.txt_Nhaptim.TextChanged += new System.EventHandler(this.txt_Nhaptim_TextChanged);
            this.txt_Nhaptim.Leave += new System.EventHandler(this.txt_Nhaptim_Leave);
            // 
            // dgrid_Thongke
            // 
            this.dgrid_Thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Thongke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_Thongke.Location = new System.Drawing.Point(4, 123);
            this.dgrid_Thongke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrid_Thongke.Name = "dgrid_Thongke";
            this.dgrid_Thongke.RowHeadersWidth = 49;
            this.dgrid_Thongke.RowTemplate.Height = 28;
            this.dgrid_Thongke.Size = new System.Drawing.Size(1331, 265);
            this.dgrid_Thongke.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1339, 366);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.lb_Sodonngay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_Doanhthungay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(37, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 252);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh thu ngày";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.lb_Sodonthang);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lb_Doanhthuthang);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(515, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 242);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doanh thu tháng";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Controls.Add(this.lb_Sodonnam);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.llb_Doanhthunam);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(916, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 242);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doanh thu năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doanh Thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh Thu :";
            // 
            // lb_Doanhthungay
            // 
            this.lb_Doanhthungay.AutoSize = true;
            this.lb_Doanhthungay.Location = new System.Drawing.Point(179, 50);
            this.lb_Doanhthungay.Name = "lb_Doanhthungay";
            this.lb_Doanhthungay.Size = new System.Drawing.Size(59, 21);
            this.lb_Doanhthungay.TabIndex = 1;
            this.lb_Doanhthungay.Text = "0 VNĐ";
            // 
            // lb_Doanhthuthang
            // 
            this.lb_Doanhthuthang.AutoSize = true;
            this.lb_Doanhthuthang.Location = new System.Drawing.Point(174, 50);
            this.lb_Doanhthuthang.Name = "lb_Doanhthuthang";
            this.lb_Doanhthuthang.Size = new System.Drawing.Size(59, 21);
            this.lb_Doanhthuthang.TabIndex = 2;
            this.lb_Doanhthuthang.Text = "0 VNĐ";
            // 
            // llb_Doanhthunam
            // 
            this.llb_Doanhthunam.AutoSize = true;
            this.llb_Doanhthunam.Location = new System.Drawing.Point(178, 50);
            this.llb_Doanhthunam.Name = "llb_Doanhthunam";
            this.llb_Doanhthunam.Size = new System.Drawing.Size(59, 21);
            this.llb_Doanhthunam.TabIndex = 3;
            this.llb_Doanhthunam.Text = "0 VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Đơn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Đơn :";
            // 
            // lb_Sodonngay
            // 
            this.lb_Sodonngay.AutoSize = true;
            this.lb_Sodonngay.Location = new System.Drawing.Point(179, 106);
            this.lb_Sodonngay.Name = "lb_Sodonngay";
            this.lb_Sodonngay.Size = new System.Drawing.Size(19, 21);
            this.lb_Sodonngay.TabIndex = 3;
            this.lb_Sodonngay.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "0";
            // 
            // lb_Sodonthang
            // 
            this.lb_Sodonthang.AutoSize = true;
            this.lb_Sodonthang.Location = new System.Drawing.Point(169, 111);
            this.lb_Sodonthang.Name = "lb_Sodonthang";
            this.lb_Sodonthang.Size = new System.Drawing.Size(19, 21);
            this.lb_Sodonthang.TabIndex = 5;
            this.lb_Sodonthang.Text = "0";
            // 
            // lb_Sodonnam
            // 
            this.lb_Sodonnam.AutoSize = true;
            this.lb_Sodonnam.Location = new System.Drawing.Point(178, 91);
            this.lb_Sodonnam.Name = "lb_Sodonnam";
            this.lb_Sodonnam.Size = new System.Drawing.Size(19, 21);
            this.lb_Sodonnam.TabIndex = 6;
            this.lb_Sodonnam.Text = "0";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1339, 757);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Thongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_Thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nhaptim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Sodonnam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label llb_Doanhthunam;
        private System.Windows.Forms.Label lb_Sodonthang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Doanhthuthang;
        private System.Windows.Forms.Label lb_Sodonngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Doanhthungay;
    }
}