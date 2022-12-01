using _2.BUS.Services;
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
        private QLNhanVienServices _QLNhanVienServices;
        public frmDangNhap()
        {
            InitializeComponent();
            _QLNhanVienServices=new QLNhanVienServices();
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            if (_QLNhanVienServices.GetAll().Where(c => c.Email = txt_Email && c.MatKhau = txt_pass).Count() > 0)
            {

                MessageBox.Show("Đăng nhập thành công");
                frmMani f = new frmMani();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nhập mk  sai ");

            }

        }
    }
}
