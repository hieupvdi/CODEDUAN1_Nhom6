using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmQuenmk : Form
    {
     
        private IQLNhanVienServices _IQLNhanVienServices;
   
        public frmQuenmk()
        {
            InitializeComponent();
            txt_Email.Text = Properties.Settings.Default.TaiKhoan;
            _IQLNhanVienServices = new QLNhanVienServices();
        }
        Random rd = new Random();
        int otp;
        public bool Checkduluu()
        {
            string email = txt_Email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Email không hợp lệ!!!");
                txt_Email.Text = "";
                return false;
            }


            return true;
        }
        private void btn_Otp_Click(object sender, EventArgs e)
        {
            try
            {
                //tạo mã otp 
                otp = rd.Next(6,100000);
                var fromAddress = new MailAddress("hieuphamtnt123456789@gmail.com"); //email dùng để gửi mã otp
                var toAddress = new MailAddress(txt_Email.ToString()); //email dùng để nhận mã otp
                const string frompass = "rizvxvbbwtfdunrj";//mã xác thực 2 lớp  rồi để nhận mã

                const string subject = "OTP Code";
                string body = otp.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 2000000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body


                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Mã OTP Đã Được Gửi đến Email :" + txt_Email.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email :" + txt_Email.Text + " Không tồn tại hoặc ghi sai Email");
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Doimk_Click(object sender, EventArgs e)
        {
            if (!Checkduluu())
            {

            }
            else
            {
                if (otp.ToString().Equals(txt_Maxacnhan.Text))
                {
                    MessageBox.Show("Xác Minh Thành công");

                    Guid h = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TaiKhoan).Id;
                    var NV = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Id == h);
                    NV.MatKhau = txt_Matkhaumoi.Text;

                    _IQLNhanVienServices.Update(NV);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    frmDangNhap f = new frmDangNhap();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mã xác minh không chính xác ");
                }
            }
        }

        private void cb_Hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Hienmk.Checked)
            {
                txt_Matkhaumoi.PasswordChar = '\0';

            }
            else
            {
                txt_Matkhaumoi.PasswordChar = '*';
            }
        }
    }
}
