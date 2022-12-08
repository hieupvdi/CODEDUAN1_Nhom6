namespace _3.PL.Views
{
    partial class frmInHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDon));
            this.lb_Tienthua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tienkhdua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Tienthua
            // 
            this.lb_Tienthua.AutoSize = true;
            this.lb_Tienthua.Location = new System.Drawing.Point(341, 236);
            this.lb_Tienthua.Name = "lb_Tienthua";
            this.lb_Tienthua.Size = new System.Drawing.Size(52, 20);
            this.lb_Tienthua.TabIndex = 66;
            this.lb_Tienthua.Text = "0 VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Tiền Thừa :";
            // 
            // txt_Tienkhdua
            // 
            this.txt_Tienkhdua.Location = new System.Drawing.Point(341, 195);
            this.txt_Tienkhdua.Name = "txt_Tienkhdua";
            this.txt_Tienkhdua.Size = new System.Drawing.Size(256, 26);
            this.txt_Tienkhdua.TabIndex = 64;
            this.txt_Tienkhdua.TextChanged += new System.EventHandler(this.txt_Tienkhdua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tiền khách đưa:";
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thanhtoan.Image")));
            this.btn_Thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thanhtoan.Location = new System.Drawing.Point(249, 309);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(245, 64);
            this.btn_Thanhtoan.TabIndex = 67;
            this.btn_Thanhtoan.Text = "Thanh Toán";
            this.btn_Thanhtoan.UseVisualStyleBackColor = true;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(341, 133);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(256, 26);
            this.txt_Tongtien.TabIndex = 68;
            this.txt_Tongtien.TextChanged += new System.EventHandler(this.txt_Tongtien_TextChanged);
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.btn_Thanhtoan);
            this.Controls.Add(this.lb_Tienthua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Tienkhdua);
            this.Controls.Add(this.label4);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Tienthua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tienkhdua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.TextBox txt_Tongtien;
    }
}