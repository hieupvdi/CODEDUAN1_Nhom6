using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmQuenmk : Form
    {
        //https://myaccount.google.com/u/0/lesssecureapps?pli=1&rapt=AEjHL4PrZJpj22ximQ3RmHLpgOoZnoDKAPqvptNb7kEol-H88dQWVTQkLuRukBaw7bPok0631R72MR7JNANna80mwn8uVKXUbA  //đã bị chặn dứng dụng k an toàn tắt bảo mật
        public frmQuenmk()
        {
            InitializeComponent();
        }

        private void btn_Doimk_Click(object sender, EventArgs e)
        {
            try {

                SmtpClient mailclient = new SmtpClient("smatp.gmail.com", 587);
                mailclient.EnableSsl=true;
                //tài khoản gửi mã
                mailclient.Credentials = new NetworkCredential("hieuphamtnt123456789@gmail.com", "Anhhieutnt123");
                //tài khoản gửi mã gửi cho ai

                MailMessage message = new MailMessage("hieuphamtnt123456789@gmail.com", txt_Email.Text);

                message.Subject = txt_Maxacnhan.Text;
                message.Body = txt_Maxacnhan.Text;

                mailclient.Send(message);
                MessageBox.Show("Gửi Email  thành công");

            }
            catch
            {
                MessageBox.Show("Gửi Email Không thành công");
            }
        }
    }
}
