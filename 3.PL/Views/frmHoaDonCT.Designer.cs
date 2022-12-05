namespace _3.PL.Views
{
    partial class frmHoaDonCT
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
            this.dgrid_Hoadonct = new System.Windows.Forms.DataGridView();
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Loaisp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_Hoadonct
            // 
            this.dgrid_Hoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Hoadonct.Location = new System.Drawing.Point(59, 207);
            this.dgrid_Hoadonct.Name = "dgrid_Hoadonct";
            this.dgrid_Hoadonct.RowHeadersWidth = 49;
            this.dgrid_Hoadonct.RowTemplate.Height = 28;
            this.dgrid_Hoadonct.Size = new System.Drawing.Size(658, 220);
            this.dgrid_Hoadonct.TabIndex = 1;
            // 
            // cmb_Size
            // 
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Location = new System.Drawing.Point(169, 96);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(193, 27);
            this.cmb_Size.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Size";
            // 
            // cmb_Loaisp
            // 
            this.cmb_Loaisp.FormattingEnabled = true;
            this.cmb_Loaisp.Location = new System.Drawing.Point(168, 54);
            this.cmb_Loaisp.Name = "cmb_Loaisp";
            this.cmb_Loaisp.Size = new System.Drawing.Size(193, 27);
            this.cmb_Loaisp.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Loaị SP";
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Location = new System.Drawing.Point(0, 0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(800, 28);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.Text = "Thêm Hóa Đơn";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frmHoaDonCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cmb_Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Loaisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_Hoadonct);
            this.Name = "frmHoaDonCT";
            this.Text = "frmHoaDonCT";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadonct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Hoadonct;
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Loaisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
    }
}