﻿using System;
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
    public partial class frmMani : Form
    {
        public frmMani()
        {
            InitializeComponent();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            frmMani f = new frmMani();
            f.ShowDialog();
           
        }

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham f = new frmQLSanPham();
            f.ShowDialog();
           
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.ShowDialog();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            frmQLHoaDon f = new frmQLHoaDon();
            f.ShowDialog();
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.ShowDialog();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
