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
            this.dgrid_Thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Thongke)).BeginInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_Thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nhaptim;
    }
}