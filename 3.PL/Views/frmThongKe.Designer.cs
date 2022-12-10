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
            this.lb_Sodonngay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Doanhthungay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dgrid_Thongke.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Thongke_CellClick);
            // 
            // groupBox1
            // 
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
            this.groupBox3.Text = "Doanh thu Chưa trừ giá nguyên liệu";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Đơn :";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu :";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_Thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nhaptim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Sodonngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Doanhthungay;
    }
}