namespace _3.PL.Views
{
    partial class frmLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoai));
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Tenlsp = new System.Windows.Forms.TextBox();
            this.txt_Malsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dggrid_LoaisanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dggrid_LoaisanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(449, 176);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(184, 50);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(237, 169);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(184, 54);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Cập Nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(23, 166);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(184, 60);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tenlsp
            // 
            this.txt_Tenlsp.Location = new System.Drawing.Point(178, 93);
            this.txt_Tenlsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Tenlsp.Name = "txt_Tenlsp";
            this.txt_Tenlsp.Size = new System.Drawing.Size(442, 29);
            this.txt_Tenlsp.TabIndex = 12;
            // 
            // txt_Malsp
            // 
            this.txt_Malsp.Location = new System.Drawing.Point(178, 28);
            this.txt_Malsp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Malsp.Name = "txt_Malsp";
            this.txt_Malsp.Size = new System.Drawing.Size(442, 29);
            this.txt_Malsp.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ten Loại sp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Loại sp";
            // 
            // dggrid_LoaisanPham
            // 
            this.dggrid_LoaisanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggrid_LoaisanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dggrid_LoaisanPham.Location = new System.Drawing.Point(0, 253);
            this.dggrid_LoaisanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dggrid_LoaisanPham.Name = "dggrid_LoaisanPham";
            this.dggrid_LoaisanPham.RowHeadersWidth = 49;
            this.dggrid_LoaisanPham.RowTemplate.Height = 28;
            this.dggrid_LoaisanPham.Size = new System.Drawing.Size(714, 244);
            this.dggrid_LoaisanPham.TabIndex = 8;
            this.dggrid_LoaisanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dggrid_LoaisanPham_CellClick);
            // 
            // frmLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 497);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tenlsp);
            this.Controls.Add(this.txt_Malsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggrid_LoaisanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLoai";
            this.Text = "frmLoai";
            ((System.ComponentModel.ISupportInitialize)(this.dggrid_LoaisanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Tenlsp;
        private System.Windows.Forms.TextBox txt_Malsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dggrid_LoaisanPham;
    }
}