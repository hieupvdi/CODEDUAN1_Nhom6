namespace _3.PL.Views
{
    partial class frmChucVu
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
            this.txt_Tencv = new System.Windows.Forms.TextBox();
            this.txt_Macv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.dgrid_ChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(565, 164);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(214, 57);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(565, 101);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(214, 57);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(565, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(214, 62);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tencv
            // 
            this.txt_Tencv.Location = new System.Drawing.Point(142, 101);
            this.txt_Tencv.Name = "txt_Tencv";
            this.txt_Tencv.Size = new System.Drawing.Size(313, 26);
            this.txt_Tencv.TabIndex = 12;
            // 
            // txt_Macv
            // 
            this.txt_Macv.Location = new System.Drawing.Point(142, 25);
            this.txt_Macv.Name = "txt_Macv";
            this.txt_Macv.Size = new System.Drawing.Size(313, 26);
            this.txt_Macv.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "TenCV";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(37, 31);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(48, 20);
            this.T.TabIndex = 9;
            this.T.Text = "MaCV";
            // 
            // dgrid_ChucVu
            // 
            this.dgrid_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChucVu.Location = new System.Drawing.Point(48, 244);
            this.dgrid_ChucVu.Name = "dgrid_ChucVu";
            this.dgrid_ChucVu.RowHeadersWidth = 49;
            this.dgrid_ChucVu.RowTemplate.Height = 28;
            this.dgrid_ChucVu.Size = new System.Drawing.Size(698, 180);
            this.dgrid_ChucVu.TabIndex = 8;
            this.dgrid_ChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChucVu_CellClick);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tencv);
            this.Controls.Add(this.txt_Macv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T);
            this.Controls.Add(this.dgrid_ChucVu);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Tencv;
        private System.Windows.Forms.TextBox txt_Macv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.DataGridView dgrid_ChucVu;
    }
}