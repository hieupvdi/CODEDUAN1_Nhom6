using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmMani : Form
    {
        private IQLNhanVienServices _IQLNhanVienServices;
        private IChucVuServices _IChucVuServices;
        private Form frmchinh;
        bool isThoat = true;
        public frmMani()
        {
            InitializeComponent();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IChucVuServices = new ChucVuServices();
        }
      
        public void ChuyenForm(Form form) //chuyển from

        {
            if (frmchinh != null)
            {
                frmchinh.Close();
            }
            frmchinh = form;
            form.TopLevel = false;
            pn_frmchuyen.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pb_TrangChu.Hide();
            form.Show();
        }
   

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham f = new frmQLSanPham();
            ChuyenForm(f);

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            ChuyenForm(f);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            frmQLHoaDon f = new frmQLHoaDon();
            ChuyenForm(f);
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            ChuyenForm(f);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            ChuyenForm(f);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn Đăng Xuất không?", "Đăng Xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isThoat = false;
                this.Close();
                frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Hide();
            }
          
        }

        private void frmMani_Load(object sender, EventArgs e)
        {
            var layEmail = Properties.Settings.Default.TaiKhoan;
            var nhanvien = _IQLNhanVienServices.GetAll().FirstOrDefault(p => p.Email == layEmail);
            if (nhanvien.LinkAnh != null)
            {
                string linkanh = nhanvien.LinkAnh.Replace(@"\", @"/");
                if (File.Exists(linkanh))
                {
                    pb_Anhdn.Image = Image.FromFile(linkanh);
                    pb_Anhdn.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            var chucVu = _IChucVuServices.GetAll().FirstOrDefault(x => x.Id == nhanvien.IdCV);
            lb_Tennv.Text = "Tên nhân viên : " + nhanvien.TenNV;
            lb_Chucvu.Text = "Chức vụ : " + chucVu.TenCV;
        }
    }
}
