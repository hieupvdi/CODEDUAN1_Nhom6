using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
  
        Guid _ID;
        public frmThongKe()
        {
            InitializeComponent();
            _IHoaDonServices = new HoaDonServices();
            _IQLNhanVienServices = new QLNhanVienServices();
     
            LoadHD(null);
            doanhthu();
        }

        public void LoadHD(string input)
        {
            int stt = 1;
    
            dgrid_Thongke.ColumnCount = 11;
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
            dgrid_Thongke.Columns[9].Name = "Tổng Tiền";
            dgrid_Thongke.Columns[10].Name = "Trạng Thái";
            dgrid_Thongke.Rows.Clear();
          
                foreach (var x in _IHoaDonServices.GetAll(input))
                {
                    dgrid_Thongke.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH, x.ThoiGianTao, x.ThoiGianThanhToan, x.SDT, x.DiaChi, x.TongTien, (x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán"));
                 

                }
           
        }
        public void doanhthu()
        {
            //_ID = Guid.Parse(dgrid_Thongke.Rows.);

            //var obj = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _ID);

            // Guid _id = Guid.Parse(_IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == x.TrangThai == 1)).ToString();


            int sp = dgrid_Thongke.Rows.Count;

            sp = sp - 1;
            lb_Sodonngay.Text = sp.ToString();


            //String data = dgrid_Thongke.DocumentText;
            //if (match.Success)
            //{
            //    dgrid_Thongke.Text = match.Groups[0].Value;
            //}
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

        private void dgrid_Thongke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IHoaDonServices.GetAll().Count)
            {
                return;
            }
            _ID = Guid.Parse(dgrid_Thongke.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _ID);

       


        }
    }
}
