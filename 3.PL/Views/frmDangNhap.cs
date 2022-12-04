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
          

        }
    }
}
