using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmDangNhap : Form
    {
        private IQLNhanVienServices _IQLNhanVienServices;
        private int _ID;
        public frmDangNhap()
        {
            InitializeComponent();
            _IQLNhanVienServices = new QLNhanVienServices();
       
      
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "" && txt_pass.Text=="")
            {
                MessageBox.Show("Email và pass trống");
            
            }else if (txt_Email.Text == ""){

                MessageBox.Show("Email trống");

            }
            else if (txt_pass.Text==""){
                MessageBox.Show(" pass trống");
            }
            else {
                var login = _IQLNhanVienServices.GetAll().Where(p => p.Email == txt_Email.Text && p.MatKhau == txt_pass.Text).FirstOrDefault();

                if (login != null)
                {


                    frmMani f = new frmMani();
                    this.Hide();
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Email hoặc pass sai ");

                }

            }
          

        }

        private void cb_Hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Hienmk.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else { 
                txt_pass.PasswordChar = '*';
            }
        }

        private void cb_Luumk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
