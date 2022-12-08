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

   


                MailAddress From = new MailAddress("hieuphamtnt123456789@gmail.com","Anhhieutnt123");
                MailAddress to = new MailAddress("hieuphamvan.dev.it@gmail.com");
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(From, to);
                message.Subject = "Đemo code Gửi email";
                message.Body = "nội dung muốn gửi email";
                message.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smatp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("hieuphamtnt123456789@gmail.com", "lmgsvrmzqonpynii");
                client.EnableSsl = true;
                client.Send(message);
                MessageBox.Show("Gửi Email  thành công");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Gửi Email Không thành công");
            }
        }
    }
}
