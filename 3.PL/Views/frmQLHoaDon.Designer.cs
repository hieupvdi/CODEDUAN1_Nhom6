namespace _3.PL.Views
{
    partial class frmQLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDon));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nhaptim = new System.Windows.Forms.TextBox();
            this.dgrid_QLHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Inhd = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgrid_Hoadonct = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nhaptim);
            this.groupBox2.Controls.Add(this.dgrid_QLHoaDon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1175, 693);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // txt_Nhaptim
            // 
            this.txt_Nhaptim.Location = new System.Drawing.Point(31, 327);
            this.txt_Nhaptim.Name = "txt_Nhaptim";
            this.txt_Nhaptim.Size = new System.Drawing.Size(423, 29);
            this.txt_Nhaptim.TabIndex = 21;
            this.txt_Nhaptim.Text = "                  Tìm Kiếm";
            this.txt_Nhaptim.Click += new System.EventHandler(this.txt_Nhaptim_Click);
            this.txt_Nhaptim.TextChanged += new System.EventHandler(this.txt_Nhaptim_TextChanged);
            this.txt_Nhaptim.Leave += new System.EventHandler(this.txt_Nhaptim_Leave);
            // 
            // dgrid_QLHoaDon
            // 
            this.dgrid_QLHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_QLHoaDon.Location = new System.Drawing.Point(4, 25);
            this.dgrid_QLHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrid_QLHoaDon.Name = "dgrid_QLHoaDon";
            this.dgrid_QLHoaDon.RowHeadersWidth = 49;
            this.dgrid_QLHoaDon.RowTemplate.Height = 28;
            this.dgrid_QLHoaDon.Size = new System.Drawing.Size(1167, 279);
            this.dgrid_QLHoaDon.TabIndex = 0;
            this.dgrid_QLHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLHoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Inhd);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.dgrid_Hoadonct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 381);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1175, 312);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Chi Tiết";
            // 
            // btn_Inhd
            // 
            this.btn_Inhd.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inhd.Image")));
            this.btn_Inhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inhd.Location = new System.Drawing.Point(840, 157);
            this.btn_Inhd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inhd.Name = "btn_Inhd";
            this.btn_Inhd.Size = new System.Drawing.Size(238, 61);
            this.btn_Inhd.TabIndex = 63;
            this.btn_Inhd.TabStop = false;
            this.btn_Inhd.Text = "Load Lại";
            this.btn_Inhd.UseVisualStyleBackColor = true;
            this.btn_Inhd.Click += new System.EventHandler(this.btn_Inhd_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(840, 83);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(238, 55);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.TabStop = false;
            this.btn_Xoa.Text = "Xóa Hóa Đơn";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgrid_Hoadonct
            // 
            this.dgrid_Hoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Hoadonct.Location = new System.Drawing.Point(31, 53);
            this.dgrid_Hoadonct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrid_Hoadonct.Name = "dgrid_Hoadonct";
            this.dgrid_Hoadonct.RowHeadersWidth = 49;
            this.dgrid_Hoadonct.RowTemplate.Height = 28;
            this.dgrid_Hoadonct.Size = new System.Drawing.Size(771, 247);
            this.dgrid_Hoadonct.TabIndex = 0;
            // 
            // frmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLHoaDon";
            this.ShowInTaskbar = false;
            this.Text = "frmQLHoaDon";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_QLHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_Hoadonct;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Nhaptim;
        private System.Windows.Forms.Button btn_Inhd;
    }
}