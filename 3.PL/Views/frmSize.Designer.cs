namespace _3.PL.Views
{
    partial class frmSize
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
            this.txt_Tensize = new System.Windows.Forms.TextBox();
            this.txt_Masize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.dgrid_Size = new System.Windows.Forms.DataGridView();
            this.rbtn_Nghiban = new System.Windows.Forms.RadioButton();
            this.rbtn_ConBan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Giaban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(598, 154);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(167, 54);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(598, 86);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(167, 53);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(598, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(167, 55);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.TabStop = false;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Tensize
            // 
            this.txt_Tensize.Location = new System.Drawing.Point(141, 68);
            this.txt_Tensize.Name = "txt_Tensize";
            this.txt_Tensize.Size = new System.Drawing.Size(338, 26);
            this.txt_Tensize.TabIndex = 20;
            // 
            // txt_Masize
            // 
            this.txt_Masize.Location = new System.Drawing.Point(141, 27);
            this.txt_Masize.Name = "txt_Masize";
            this.txt_Masize.Size = new System.Drawing.Size(338, 26);
            this.txt_Masize.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên size";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(36, 33);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(59, 20);
            this.T.TabIndex = 17;
            this.T.Text = "Mã size";
            // 
            // dgrid_Size
            // 
            this.dgrid_Size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Size.Location = new System.Drawing.Point(47, 246);
            this.dgrid_Size.Name = "dgrid_Size";
            this.dgrid_Size.RowHeadersWidth = 49;
            this.dgrid_Size.RowTemplate.Height = 28;
            this.dgrid_Size.Size = new System.Drawing.Size(698, 180);
            this.dgrid_Size.TabIndex = 16;
            this.dgrid_Size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Size_CellClick);
            // 
            // rbtn_Nghiban
            // 
            this.rbtn_Nghiban.AutoSize = true;
            this.rbtn_Nghiban.Location = new System.Drawing.Point(233, 156);
            this.rbtn_Nghiban.Name = "rbtn_Nghiban";
            this.rbtn_Nghiban.Size = new System.Drawing.Size(88, 24);
            this.rbtn_Nghiban.TabIndex = 35;
            this.rbtn_Nghiban.TabStop = true;
            this.rbtn_Nghiban.Text = "Nghỉ Bán";
            this.rbtn_Nghiban.UseVisualStyleBackColor = true;
            // 
            // rbtn_ConBan
            // 
            this.rbtn_ConBan.AutoSize = true;
            this.rbtn_ConBan.Location = new System.Drawing.Point(132, 156);
            this.rbtn_ConBan.Name = "rbtn_ConBan";
            this.rbtn_ConBan.Size = new System.Drawing.Size(82, 24);
            this.rbtn_ConBan.TabIndex = 34;
            this.rbtn_ConBan.TabStop = true;
            this.rbtn_ConBan.Text = "Còn Bán";
            this.rbtn_ConBan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Trạng Thái";
            // 
            // txt_Giaban
            // 
            this.txt_Giaban.Location = new System.Drawing.Point(141, 113);
            this.txt_Giaban.Name = "txt_Giaban";
            this.txt_Giaban.Size = new System.Drawing.Size(338, 26);
            this.txt_Giaban.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gía Bán";
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Giaban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_Nghiban);
            this.Controls.Add(this.rbtn_ConBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Tensize);
            this.Controls.Add(this.txt_Masize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T);
            this.Controls.Add(this.dgrid_Size);
            this.Name = "frmSize";
            this.Text = "frmSize";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Tensize;
        private System.Windows.Forms.TextBox txt_Masize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.DataGridView dgrid_Size;
        private System.Windows.Forms.RadioButton rbtn_Nghiban;
        private System.Windows.Forms.RadioButton rbtn_ConBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Giaban;
        private System.Windows.Forms.Label label1;
    }
}