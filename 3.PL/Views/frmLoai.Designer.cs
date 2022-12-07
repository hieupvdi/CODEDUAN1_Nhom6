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
            this.btn_Xoa.Location = new System.Drawing.Point(604, 153);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(147, 45);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(604, 82);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(147, 49);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(604, 13);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(147, 54);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tenlsp
            // 
            this.txt_Tenlsp.Location = new System.Drawing.Point(142, 84);
            this.txt_Tenlsp.Name = "txt_Tenlsp";
            this.txt_Tenlsp.Size = new System.Drawing.Size(354, 26);
            this.txt_Tenlsp.TabIndex = 12;
            // 
            // txt_Malsp
            // 
            this.txt_Malsp.Location = new System.Drawing.Point(142, 25);
            this.txt_Malsp.Name = "txt_Malsp";
            this.txt_Malsp.Size = new System.Drawing.Size(354, 26);
            this.txt_Malsp.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ten Loại sp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Loại sp";
            // 
            // dggrid_LoaisanPham
            // 
            this.dggrid_LoaisanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggrid_LoaisanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dggrid_LoaisanPham.Location = new System.Drawing.Point(0, 229);
            this.dggrid_LoaisanPham.Name = "dggrid_LoaisanPham";
            this.dggrid_LoaisanPham.RowHeadersWidth = 49;
            this.dggrid_LoaisanPham.RowTemplate.Height = 28;
            this.dggrid_LoaisanPham.Size = new System.Drawing.Size(800, 221);
            this.dggrid_LoaisanPham.TabIndex = 8;
            this.dggrid_LoaisanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dggrid_LoaisanPham_CellClick);
            // 
            // frmLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tenlsp);
            this.Controls.Add(this.txt_Malsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggrid_LoaisanPham);
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