namespace _3.PL.Views
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.cb_Hienmk = new System.Windows.Forms.CheckBox();
            this.cb_Luumk = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(444, 192);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(313, 26);
            this.txt_pass.TabIndex = 16;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(444, 116);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(313, 26);
            this.txt_Email.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pass";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(339, 122);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(46, 20);
            this.T.TabIndex = 13;
            this.T.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 511);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Location = new System.Drawing.Point(502, 295);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(164, 59);
            this.btn_Dangnhap.TabIndex = 18;
            this.btn_Dangnhap.Text = "Đăng Nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // cb_Hienmk
            // 
            this.cb_Hienmk.AutoSize = true;
            this.cb_Hienmk.Location = new System.Drawing.Point(631, 247);
            this.cb_Hienmk.Name = "cb_Hienmk";
            this.cb_Hienmk.Size = new System.Drawing.Size(126, 24);
            this.cb_Hienmk.TabIndex = 19;
            this.cb_Hienmk.Text = "Hiện Mật Khẩu";
            this.cb_Hienmk.UseVisualStyleBackColor = true;
            this.cb_Hienmk.CheckedChanged += new System.EventHandler(this.cb_Hienmk_CheckedChanged);
            // 
            // cb_Luumk
            // 
            this.cb_Luumk.AutoSize = true;
            this.cb_Luumk.Location = new System.Drawing.Point(444, 247);
            this.cb_Luumk.Name = "cb_Luumk";
            this.cb_Luumk.Size = new System.Drawing.Size(119, 24);
            this.cb_Luumk.TabIndex = 20;
            this.cb_Luumk.Text = "Lưu Mật Khẩu";
            this.cb_Luumk.UseVisualStyleBackColor = true;
            this.cb_Luumk.CheckedChanged += new System.EventHandler(this.cb_Luumk_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(857, 511);
            this.Controls.Add(this.cb_Luumk);
            this.Controls.Add(this.cb_Hienmk);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_Hienmk;
        private System.Windows.Forms.CheckBox cb_Luumk;
    }
}