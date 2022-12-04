﻿using _2.BUS.IServices;
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
    public partial class frmBanHang : Form
    {
        //gọi sv ql sp
        private IQLSanPhamServices _IQLSanPhamServices;

        private ISizeServices _ISizeServices;
        //Gọi sv hóa đơn chờ
        private IKhachHangServices _IKhachHangServices;
        //Gọi sv hóa đơn ct-giỏ hàng
        private IHoaDonCTServices _IHoaDonCTServices;
        private IHoaDonServices _IHoaDonServices;
        private IQLNhanVienServices _IQLNhanVienServices;
        public KhachHangView c;

        public int u;
        public List<HoaDonCTView> _lstHoaDonCTView;

        public frmBanHang()
        {
            InitializeComponent();
            _IQLSanPhamServices = new QLSanPhamServices();
            _IQLNhanVienServices = new QLNhanVienServices();
            _ISizeServices = new SizeServices();
            _IHoaDonServices = new HoaDonServices();
            _IHoaDonCTServices = new HoaDonCTServices();
            _IKhachHangServices = new KhachHangServices();
            _lstHoaDonCTView = new List<HoaDonCTView>();
            c = new KhachHangView();
     
            LoadDSSanPham();
            LoadGioHang();
            LoadHDCho();
            LoadCmb();
        }
        public void LoadCmb()
        {
            foreach (var x in _IQLNhanVienServices.GetAll())
            {
                cmb_Nhanvien.Items.Add(x.MaNV);
            }
            cmb_Nhanvien.SelectedIndex = 0;
            foreach (var x in _IKhachHangServices.GetAll())
            {
                cmb_Khachhang.Items.Add(x.TenKH);
            }
            cmb_Khachhang.SelectedIndex = 0;



        }
        //bảng hóa đơn -hóa đơn chờ
        public void LoadHDCho()
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
        //Bảng sản phẩm
        public void LoadDSSanPham()
        {
            int stt = 1;
            dgrid_QLSanPham.ColumnCount = 9;
            dgrid_QLSanPham.Columns[0].Name = "STT";
            dgrid_QLSanPham.Columns[1].Name = "ID";
            dgrid_QLSanPham.Columns[1].Visible = false;
            dgrid_QLSanPham.Columns[2].Name = "Mã Sản Phẩm";
            dgrid_QLSanPham.Columns[3].Name = "Tên Sản Phẩm";
            // dgrid_QLSanPham.Columns[4].Name = "Link Ảnh";
            dgrid_QLSanPham.Columns[4].Name = "Loại SP";
            dgrid_QLSanPham.Columns[5].Name = "Size SP";
            dgrid_QLSanPham.Columns[6].Name = "Gía bán";
            dgrid_QLSanPham.Columns[7].Name = "Trạng Thái";

            dgrid_QLSanPham.Rows.Clear();

            foreach (var x in _IQLSanPhamServices.GetAll())
            {
                dgrid_QLSanPham.Rows.Add(stt++, x.Id, x.MaSP, x.TenSP, x.TenLoaiSP, x.TenSize, x.GiaBan, (x.TrangThai == 0 ? "Còn Bán" : "Nghỉ Bán"));
            }

        }


        //bảng hóa đơn chi tiết hay giỏ hàng
        public void LoadGioHang()
        {


            int stt = 1;
            dgrid_Hoadonct.ColumnCount = 10;
            dgrid_Hoadonct.Columns[0].Name = "STT";
            dgrid_Hoadonct.Columns[1].Name = "ID";
            dgrid_Hoadonct.Columns[1].Visible = false;
            dgrid_Hoadonct.Columns[2].Name = "Mã sp";
            dgrid_Hoadonct.Columns[3].Name = "Tên sp";
            dgrid_Hoadonct.Columns[4].Name = "Số Lượng";
            dgrid_Hoadonct.Columns[5].Name = "Đơn Gía";
            //dgrid_Hoadonct.Columns[5].Name = "Thành Tiền";

            dgrid_Hoadonct.Rows.Clear();

            foreach (var x in _lstHoaDonCTView)
            {
                dgrid_Hoadonct.Rows.Add(stt++, x.IdSP, x.MaSP, x.TenSP, x.SoLuong, x.DonGia);
            }

        }

        private void btn_Themgh_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_QLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLSanPham.Rows[e.RowIndex];

                u = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.MaSP == r.Cells[2].Value.ToString()).Id;
                // u = Convert.ToInt32(r.Cells[2].Value.ToString());
                AddGioHang(u);
            }
        }
        private void AddGioHang(int u)
        {

            var sp = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == u);

            var data = _lstHoaDonCTView.FirstOrDefault(x => x.IdSP == sp.Id);
            if (data == null)
            {
                HoaDonCTView ghct = new HoaDonCTView()
                {


                    IdSP = sp.Id,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = 1,
                    MaSP = sp.MaSP,
                };
                _lstHoaDonCTView.Add(ghct);

            }
            else
            {
                data.SoLuong++;
            }
            LoadGioHang();


        }





        private void btn_Xoagh_Click(object sender, EventArgs e)
        {

            var item = _lstHoaDonCTView.FirstOrDefault(x => x.IdSP == u);
            _lstHoaDonCTView.Remove(item);


            LoadGioHang();


        }

        private void dgrid_Hoadonct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLSanPham.Rows[e.RowIndex];
                //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                u = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.MaSP == r.Cells[2].Value.ToString()).Id;
                //AddGioHang(u);
            }
        }

        private void btn_Xoahet_Click(object sender, EventArgs e)
        {
            if (_lstHoaDonCTView.Any())
            {
                _lstHoaDonCTView = new List<HoaDonCTView>();
                LoadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_Taohdcho_Click(object sender, EventArgs e)
        {
            if (_lstHoaDonCTView.Any())//check có sp trong bảng tạm k
            {
                decimal Tien = 0;
                foreach (var item in _lstHoaDonCTView)
                {
                    Tien += item.DonGia * item.SoLuong;
                }
                //lấy id nv / id kh
                //int eID = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).ID;
                //c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Phone == tb_sdt.Text);


                int h = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TaiKhoan).Id;
                c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.MaKH == txt_Makh.Text);
             
                if (c != null)
                {

                    var HoaDonView = new HoaDonView()
                    {
                        ////MaHD = txt_Mahd.Text,
                        //Id = Convert.ToInt32(idhd) + 1,
                        //MaHD = "HD0000" + _IHoaDonServices.GetAll().Select(x => x.Id).LastOrDefault(),
                        //ThoiGianTao = DateTime.Now,
                        //IdNV = _IQLNhanVienServices.GetAll()[cmb_Nhanvien.SelectedIndex].Id,
                        //IdKH = _IKhachHangServices.GetAll()[cmb_Khachhang.SelectedIndex].Id,
                        //TongTien = Tien,
                        //TrangThai = 0,
                        //Id = Convert.ToInt32(hd) + 1,
                        MaHD = "HD0000" + _IHoaDonServices.GetAll().Select(x => x.Id).LastOrDefault(),
                        ThoiGianTao = DateTime.Now,
                        IdNV = h,
                        IdKH = c.Id,
                        TongTien = Tien,

                    };
                    _IHoaDonServices.Add(HoaDonView);
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {HoaDonView.Id}");
                    foreach (var item in _lstHoaDonCTView)
                    {
                        var HoaDonCTView = new HoaDonCTView()
                        {
                        IdHD = HoaDonView.Id,
                        IdSP = item.IdSP,
                        GiaBan = item.GiaBan,
                        SoLuong = item.SoLuong
                        };
                         _IHoaDonCTServices.Add(HoaDonCTView);
                    //var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == item.IdSP);
                    // p.Stock -= item.Quantity;
                    // _IQLSanPhamServices.Update(p);
                    }

                    //tbt_mahd.Text = o.Id.ToString();
                    //lb_TongTien.Text = o.TotalPrice.ToString();
                    //lb_TongTien = Convert.ToDecimal(Tien);
                    //tb_sdt.Text = "";
                    //lb_totalcart.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {HoaDonView.Id}");
                    
                    LoadDSSanPham();
                    LoadHDCho();
                    LoadGioHang();
                    _lstHoaDonCTView = new List<HoaDonCTView>();
                    dgrid_Hoadonct.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }








        }

        private void btn_Themkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }
    }
}
