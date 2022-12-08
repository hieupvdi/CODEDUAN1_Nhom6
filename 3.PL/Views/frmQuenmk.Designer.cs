namespace _3.PL.Views
{
    partial class frmQuenmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenmk));
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.txt_Matkhaumoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Maxacnhan = new System.Windows.Forms.TextBox();
            this.btn_Doimk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(71, 147);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(61, 21);
            this.lb_Email.TabIndex = 14;
            this.lb_Email.Text = "Email :";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(258, 139);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(486, 29);
            this.txt_Email.TabIndex = 16;
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(71, 297);
            this.lb_Pass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(124, 21);
            this.lb_Pass.TabIndex = 17;
            this.lb_Pass.Text = "Mật khẩu mới :";
            // 
            // txt_Matkhaumoi
            // 
            this.txt_Matkhaumoi.Location = new System.Drawing.Point(258, 294);
            this.txt_Matkhaumoi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_Matkhaumoi.Name = "txt_Matkhaumoi";
            this.txt_Matkhaumoi.PasswordChar = '*';
            this.txt_Matkhaumoi.Size = new System.Drawing.Size(486, 29);
            this.txt_Matkhaumoi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Xác Nhận :";
            // 
            // txt_Maxacnhan
            // 
            this.txt_Maxacnhan.Location = new System.Drawing.Point(258, 211);
            this.txt_Maxacnhan.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_Maxacnhan.Name = "txt_Maxacnhan";
            this.txt_Maxacnhan.PasswordChar = '*';
            this.txt_Maxacnhan.Size = new System.Drawing.Size(145, 29);
            this.txt_Maxacnhan.TabIndex = 20;
            // 
            // btn_Doimk
            // 
            this.btn_Doimk.Image = ((System.Drawing.Image)(resources.GetObject("btn_Doimk.Image")));
            this.btn_Doimk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Doimk.Location = new System.Drawing.Point(343, 403);
            this.btn_Doimk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Doimk.Name = "btn_Doimk";
            this.btn_Doimk.Size = new System.Drawing.Size(205, 65);
            this.btn_Doimk.TabIndex = 21;
            this.btn_Doimk.Text = "Đổi Mật Khẩu";
            this.btn_Doimk.UseVisualStyleBackColor = true;
            this.btn_Doimk.Click += new System.EventHandler(this.btn_Doimk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 36.31305F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(171, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 76);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quên Mật khẩu";
            // 
            // frmQuenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Doimk);
            this.Controls.Add(this.txt_Maxacnhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Matkhaumoi);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_Email);
            this.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQuenmk";
            this.Text = "frmQuenmk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.TextBox txt_Matkhaumoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Maxacnhan;
        private System.Windows.Forms.Button btn_Doimk;
        private System.Windows.Forms.Label label2;
    }
}