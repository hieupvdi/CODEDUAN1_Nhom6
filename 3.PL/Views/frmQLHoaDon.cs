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
    public partial class frmQLHoaDon : Form
    {
       
        private IHoaDonServices _IHoaDonServices;
        private IQLNhanVienServices _IQLNhanVienServices;
        private IKhachHangServices _IKhachHangServices;

        //
        private IHoaDonCTServices _IHoaDonCTServices;
        private Guid _idWhenClick;
        public int oID;
        public frmQLHoaDon()
        {
            InitializeComponent();
            _IHoaDonServices = new HoaDonServices();
            _IHoaDonCTServices = new HoaDonCTServices();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IKhachHangServices = new KhachHangServices();
            oID = 0;
            LoadQLHD();
           
        }
        //bảng  hóa đơn
        public void LoadQLHD()
        {
            int stt = 1;
            dgrid_QLHoaDon.ColumnCount = 10;
            dgrid_QLHoaDon.Columns[0].Name = "STT";
            dgrid_QLHoaDon.Columns[1].Name = "ID";
            dgrid_QLHoaDon.Columns[1].Visible = false;
            dgrid_QLHoaDon.Columns[2].Name = "Mã Hóa Đơn";
            dgrid_QLHoaDon.Columns[3].Name = "Nhân Viên";
            dgrid_QLHoaDon.Columns[4].Name = "Tên Khách Hàng";
            dgrid_QLHoaDon.Columns[5].Name = "Thời Gian Tạo";
            dgrid_QLHoaDon.Columns[6].Name = "Thời Gian Thanh Toán";
            dgrid_QLHoaDon.Columns[7].Name = "SĐT";
            dgrid_QLHoaDon.Columns[8].Name = "Địa Chỉ";
            dgrid_QLHoaDon.Columns[9].Name = "Trạng Thái";

            dgrid_QLHoaDon.Rows.Clear();

            foreach (var x in _IHoaDonServices.GetAll())
            {
                dgrid_QLHoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH, x.ThoiGianTao, x.ThoiGianThanhToan, x.SDT, x.DiaChi, (x.TrangThai == 0 ? "Chưa Thanh Toán" : "Đã Thanh Toán"));
            }

        }

        //bảng chi tiết hóa đơn
        public void LoadQLCTHD(int orderID)
        {
            oID = orderID;
            int stt = 1;
            dgrid_Hoadonct.ColumnCount = 10;
            dgrid_Hoadonct.Columns[0].Name = "STT";
            dgrid_Hoadonct.Columns[1].Name = "IDHD";
            dgrid_Hoadonct.Columns[1].Visible = false;
            dgrid_Hoadonct.Columns[2].Name = "IDCTSP";
            dgrid_Hoadonct.Columns[2].Visible = false;
            dgrid_Hoadonct.Columns[3].Name = "Mã sp";
            dgrid_Hoadonct.Columns[4].Name = "Tên sp";
            dgrid_Hoadonct.Columns[5].Name = "Số Lượng";
            dgrid_Hoadonct.Columns[6].Name = "Đơn Gía";
      

            dgrid_Hoadonct.Rows.Clear();

            foreach (var x in _IHoaDonCTServices.GetAll())
            {
                dgrid_Hoadonct.Rows.Add(stt++, /*x.IdHD,*/ x.IdSP,x.MaSP,x.TenSP, x.SoLuong, x.DonGia);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //HoaDonView HD = new HoaDonView()
            //{
            //    Id = Guid.Empty,
            //    MaHD = txt_Mahd.Text,
            //    IdNV = _IQLNhanVienServices.GetAll()[cmb_Nhanvien.SelectedIndex].Id,
            //    IdKH = _IKhachHangServices.GetAll()[cmb_Khachhang.SelectedIndex].Id,
            //    ThoiGianTao = date_TGtao.Value,
            //    ThoiGianThanhToan = date_TGTT.Value,
            //    SDT = txt_Sdt.Text,
            //    DiaChi = txt_Diachi.Text,
            //    TrangThai = rbtn_ChuaTT.Checked ? 0 : 1,


            //};
            //return HD;
            //var temp = GetDataFromGui();
            //HoaDonView u = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idHoad);
            //MessageBox.Show(_IHoaDonServices.Delete(u));
            //LoadQLHD();
        }

        private void dgrid_QLHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow r = dgrid_QLHoaDon.Rows[e.RowIndex];
            //    u = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[1].Value.ToString())).Id;
            //    AddGioHang(u);
            //}
        }

        private void btn_Inhd_Click(object sender, EventArgs e)
        {

        }
    }
}
