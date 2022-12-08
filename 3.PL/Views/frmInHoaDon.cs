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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void txt_Tienkhdua_TextChanged(object sender, EventArgs e)
        {
            lb_Tienthua.Text = (int.Parse(txt_Tienkhdua.Text) - int.Parse(txt_Tongtien.Text)).ToString();
        }

        private void txt_Tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {

        }
    }
}
