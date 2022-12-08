using _2.BUS.IServices;
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
    public partial class frmThongKe : Form
    {
        private IHoaDonServices _IHoaDonServices;
        private IQLNhanVienServices _IQLNhanVienServices;
     
        public frmThongKe()
        {
            InitializeComponent();
            _IHoaDonServices = new HoaDonServices();
            _IQLNhanVienServices = new QLNhanVienServices();
            LoadHD(null);
        }

        public void LoadHD(string input)
        {
            int stt = 1;
            dgrid_Thongke.ColumnCount = 10;
            dgrid_Thongke.Columns[0].Name = "STT";
            dgrid_Thongke.Columns[1].Name = "ID";
            dgrid_Thongke.Columns[1].Visible = false;
            dgrid_Thongke.Columns[2].Name = "Mã Hóa Đơn";
            dgrid_Thongke.Columns[3].Name = "Nhân Viên";
            dgrid_Thongke.Columns[4].Name = "Tên Khách Hàng";
            dgrid_Thongke.Columns[5].Name = "Thời Gian Tạo";
            dgrid_Thongke.Columns[6].Name = "Thời Gian Thanh Toán";
            dgrid_Thongke.Columns[7].Name = "SĐT";
            dgrid_Thongke.Columns[8].Name = "Địa Chỉ";
            dgrid_Thongke.Columns[9].Name = "Trạng Thái";

            dgrid_Thongke.Rows.Clear();

            foreach (var x in _IHoaDonServices.GetAll(input))
            {
                dgrid_Thongke.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH, x.ThoiGianTao, x.ThoiGianThanhToan, x.SDT, x.DiaChi, (x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán"));
            }

        }

        private void txt_Nhaptim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nhaptim.Text)) return;
            LoadHD(txt_Nhaptim.Text);
        }

        private void txt_Nhaptim_Leave(object sender, EventArgs e)
        {
            txt_Nhaptim.Text = "Tìm kiếm .......";
            LoadHD(null);
        }

        private void txt_Nhaptim_Click(object sender, EventArgs e)
        {
            txt_Nhaptim.Clear();
        }
    }
}
