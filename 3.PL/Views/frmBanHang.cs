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
    public partial class frmBanHang : Form
    {
        //gọi sv ql sp
        private IQLSanPhamServices _IQLSanPhamServices;

   
        //Gọi sv hóa đơn chờ
        private IKhachHangServices _IKhachHangServices;
        //Gọi sv hóa đơn ct-giỏ hàng
        private IHoaDonCTServices _IHoaDonCTServices;
        private IHoaDonServices _IHoaDonServices;
        private IQLNhanVienServices _IQLNhanVienServices;
        public KhachHangView c;


        public Guid u;
        public Guid UH;
        public List<HoaDonCTView> _lstHoaDonCTView;
 
        public Guid _idhdcho;
        public frmBanHang()
        {
            InitializeComponent();
            _IQLSanPhamServices = new QLSanPhamServices();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IHoaDonServices = new HoaDonServices();
            _IHoaDonCTServices = new HoaDonCTServices();
            _IKhachHangServices = new KhachHangServices();

            _lstHoaDonCTView = new List<HoaDonCTView>();
      
            c = new KhachHangView();
         
            LoadDSSanPham(null);
            LoadGioHang();
            LoadHDCho();
    



        }

        //bảng hóa đơn -hóa đơn chờ
        public void LoadHDCho()
        {
          
                int stt = 1;
            dgrid_QLHoaDon.ColumnCount = 8;
            dgrid_QLHoaDon.Columns[0].Name = "STT";
            dgrid_QLHoaDon.Columns[1].Name = "ID";
            dgrid_QLHoaDon.Columns[1].Visible = false;
            dgrid_QLHoaDon.Columns[2].Name = "Mã Hóa Đơn";
            dgrid_QLHoaDon.Columns[3].Name = "Nhân Viên";
            dgrid_QLHoaDon.Columns[4].Name = "Tên Khách Hàng";
            dgrid_QLHoaDon.Columns[5].Name = "Thời Gian Tạo";
            dgrid_QLHoaDon.Columns[6].Name = "Tổng Tiền";
            //dgrid_QLHoaDon.Columns[6].Name = "Thời Gian Thanh Toán";
            //dgrid_QLHoaDon.Columns[7].Name = "SĐT";
            //dgrid_QLHoaDon.Columns[8].Name = "Địa Chỉ";
            dgrid_QLHoaDon.Columns[7].Name = "Trạng Thái";

            dgrid_QLHoaDon.Rows.Clear();

       
           
                foreach (var x in _IHoaDonServices.GetAll())
                {
                    if (x.TrangThai == 1)
                    {
                        dgrid_QLHoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH, x.ThoiGianTao,/* x.ThoiGianThanhToan, x.SDT, x.DiaChi,*/x.TongTien, (x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán"));
                    }
                    
                }
            
        }
        //Bảng sản phẩm
        public void LoadDSSanPham(string input)
        {
            int stt = 1;
            dgrid_QLSanPham.ColumnCount = 8;
            dgrid_QLSanPham.Columns[0].Name = "STT";
            dgrid_QLSanPham.Columns[1].Name = "ID";
            dgrid_QLSanPham.Columns[1].Visible = false;
            dgrid_QLSanPham.Columns[2].Name = "Mã Sản Phẩm";
            dgrid_QLSanPham.Columns[3].Name = "Tên Sản Phẩm";          
            dgrid_QLSanPham.Columns[4].Name = "Loại SP";
            dgrid_QLSanPham.Columns[5].Name = "Size SP";
            dgrid_QLSanPham.Columns[6].Name = "Gía bán";
            dgrid_QLSanPham.Columns[7].Name = "Trạng Thái";

            dgrid_QLSanPham.Rows.Clear();

            foreach (var x in _IQLSanPhamServices.GetAll(input))
            {
                dgrid_QLSanPham.Rows.Add(stt++, x.Id, x.MaSP, x.TenSP, x.TenLoaiSP, x.TenSize, x.GiaBan, (x.TrangThai == 0 ? "Còn Bán" : "Nghỉ Bán"));
            }

        }


        //bảng hóa đơn chi tiết hay giỏ hàng
        public void LoadGioHang()
        {


            int stt = 1;
            dgrid_Hoadonct.ColumnCount = 6;
            dgrid_Hoadonct.Columns[0].Name = "STT";
            dgrid_Hoadonct.Columns[1].Name = "ID";
            dgrid_Hoadonct.Columns[1].Visible = false;
            dgrid_Hoadonct.Columns[2].Name = "Mã sp";
            dgrid_Hoadonct.Columns[3].Name = "Tên sp";
            dgrid_Hoadonct.Columns[4].Name = "Số Lượng";
            dgrid_Hoadonct.Columns[5].Name = "Đơn Gía";
       

            dgrid_Hoadonct.Rows.Clear();

            foreach (var x in _lstHoaDonCTView)
            {
                dgrid_Hoadonct.Rows.Add(stt++, x.IdSP, x.MaSP, x.TenSP, x.SoLuong, x.DonGia);
            }
            TinhTienGH();

        }


        public bool Checkduluu()
        {

       
             if (txt_Makh.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã Khách Hàng");
                return false;
            }
            else if (txt_Makh.Text.Length < 2)
            {
                MessageBox.Show("mã Khách Hàng phải có ít nhất 2 kí tự");
                return false;
            }
       
            else if (!txt_Tienkhdua.Text.All(char.IsNumber))
            {
                MessageBox.Show("Tiền khách đưa  phải là số !");
                return false;
            }
          

            return true;
        }
        private void dgrid_QLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLSanPham.Rows[e.RowIndex];
                u = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[1].Value.ToString())).Id;
                var obj = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == u);
                if (obj.TrangThai == 1)
                {
                    MessageBox.Show("Sản phẩm đã nghỉ bán");
                }
                else {

                    AddGioHang(u);

                }
                
              
            }
        }
        private void AddGioHang(Guid u)
        {

            var sp = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == u);

            var data = _lstHoaDonCTView.FirstOrDefault(x => x.IdSP == sp.Id);
            if (data == null)
            {
                HoaDonCTView ghct = new HoaDonCTView()
                {


                    IdSP = sp.Id,
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = 1,
                  
                   
                };
                _lstHoaDonCTView.Add(ghct);

            }
            else
            {
                data.SoLuong++;
            }
            LoadGioHang();


        }
        public void TinhTienGH()
        {
            if (_lstHoaDonCTView != null)
            {
                int tien = 0;
                foreach (var item in _lstHoaDonCTView)
                {
                    tien += Convert.ToInt32(item.DonGia) * item.SoLuong;
                }
                lb_TongTiengh.Text = tien.ToString()+"VNĐ";
               
            }
            else
            {
                lb_TongTiengh.Text = "";
              
            }
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
            if (!Checkduluu())
            {

            }
            else
            {
                if (_lstHoaDonCTView.Any())//check có sp trong bảng tạm có k
                {
                    decimal tien = 0;
                    foreach (var item in _lstHoaDonCTView)
                    {
                        tien += item.DonGia * item.SoLuong;
                    }
                    //lấy id nv / id kh

                    Guid h = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TaiKhoan).Id;
                    c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.MaKH == txt_Makh.Text);

                    if (c != null)
                    {
                        Random rd = new Random();

                        var HoaDonView = new HoaDonView()
                        {

                            Id = Guid.NewGuid(),
                            MaHD = "HD" + rd.Next(1, 10000),
                            ThoiGianTao = DateTime.Now,
                            IdNV = h,
                            IdKH = c.Id,
                            DiaChi = c.DiaChi,
                            SDT = c.SDT,
                            TongTien = tien,
                            TrangThai = 1,


                        };
                        _IHoaDonServices.Add(HoaDonView);

                        foreach (var item in _lstHoaDonCTView)
                        {
                            var HoaDonCTView = new HoaDonCTView()
                            {
                                IdHD = HoaDonView.Id,
                                IdSP = item.IdSP,
                                GiaBan = HoaDonView.TongTien,
                                SoLuong = item.SoLuong
                            };
                            _IHoaDonCTServices.Add(HoaDonCTView);

                        }

                        lb_Mahd.Text = HoaDonView.MaHD.ToString();
                        lb_Tongtientt.Text = HoaDonView.TongTien.ToString();
                        txt_Makh.Text = "";
                        lb_TongTiengh.Text = "";
                        MessageBox.Show($"Tạo hóa đơn thành công Mã Hóa Đơn là : {HoaDonView.MaHD}");
                        LoadDSSanPham(null);
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

        }

        private void btn_Themkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void dgrid_QLHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLHoaDon.Rows[e.RowIndex];

                //_idhdcho = _IHoaDonServices.GetAll().FirstOrDefault(x=> x.Id==Guid.Parse(r.Cells[1].Value.ToString())).Id;
                _idhdcho = Guid.Parse(r.Cells[1].Value.ToString());



                //hóa dơn chi tiết
                var od = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == _idhdcho);
                //hóa đơn
                var cid = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idhdcho).IdKH;
                // khách hàng
                var c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Id == cid);
                txt_Makh.Text = c.MaKH;
             
                _lstHoaDonCTView = new List<HoaDonCTView>();
                foreach (var item in od)
                {
                    var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == item.IdSP);

                    HoaDonCTView HoaDonCTView = new HoaDonCTView()
                    {
                        IdSP = p.Id,
                        MaSP = p.MaSP,
                        TenSP = p.TenSP,
                        DonGia = p.GiaBan,
                        SoLuong = od.FirstOrDefault(x => x.IdSP == p.Id).SoLuong
                    };
                    _lstHoaDonCTView.Add(HoaDonCTView);

                    LoadGioHang();
                }

                lb_Mahd.Text = r.Cells[2].Value.ToString();
                lb_Tongtientt.Text = r.Cells[6].Value.ToString();
                TinhTienGH();

            }
        }

        private void btn_Capnhatsp_Click(object sender, EventArgs e)
        {
            var hd = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idhdcho);

            if (hd.TrangThai != 0)
            {
                if (_lstHoaDonCTView.Any())
                {
                    int tien = 0;
                    c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.MaKH == txt_Makh.Text);
                    if (c != null)
                    {
                        var hoadon = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idhdcho);
                        var hoadonct = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == _idhdcho);
                        foreach (var x in hoadonct)
                        {
                            _IHoaDonCTServices.Delete(x);
                        }


                        foreach (var item in _lstHoaDonCTView)
                        {
                            var HoaDonCTView  = new HoaDonCTView()
                            {
                                IdHD = _idhdcho,
                                IdSP = item.IdSP,
                                DonGia = item.GiaBan,
                                SoLuong = item.SoLuong
                            };
                            tien += Convert.ToInt32(item.DonGia * item.SoLuong);
                            _IHoaDonCTServices.Add(HoaDonCTView);
                        
                        }


                        Guid h = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TaiKhoan).Id;
                        hoadon.ThoiGianTao = DateTime.Now;
                        hoadon.IdNV = h;
                        hoadon.IdKH = c.Id;
                        hoadon.TongTien = tien;
                        _IHoaDonServices.Update(hoadon);

                        lb_Mahd.Text = _idhdcho.ToString();
                        lb_Tongtientt.Text = tien.ToString()+"VNĐ";
                        txt_Makh.Text = "";
                        lb_TongTiengh.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {hd.MaHD}");
                      
                        LoadDSSanPham(null);         
                        LoadHDCho();
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
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

            private void txt_Makh_TextChanged(object sender, EventArgs e)
        {
           
                c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.MaKH == txt_Makh.Text);
                if (c != null)
                {
                    lb_Tenkh.Text = c.TenKH;
                   
                }
                else
                {
                    lb_Tenkh.Text = "Chưa nhập mã kh";
               
                }
         
        }

        private void txt_Tienkhdua_TextChanged(object sender, EventArgs e)
        {


             if (!txt_Tienkhdua.Text.All(char.IsNumber))
            {
                MessageBox.Show("Tiền khách đưa  phải là số !");
            
            }
            else if(txt_Tienkhdua.Text != "")
            {
                lb_Tienthua.Text = (Convert.ToDouble(txt_Tienkhdua.Text) - Convert.ToDouble(lb_Tongtientt.Text)).ToString();
           
            }
         
           
           
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            if (!Checkduluu())
            {

            }
            else
            {
                if (lb_Mahd.Text != null)
                {
                    var hd = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idhdcho);
                    if (hd.TrangThai != 1)
                    {
                        MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                        lb_Tongtientt.Text = "0";
                    }
                    else
                    {


                        if (Convert.ToDouble(txt_Tienkhdua.Text) < Convert.ToDouble(lb_Tongtientt.Text))
                        {
                            MessageBox.Show("Thieu tien");
                        }
                        else
                        {
                            var Khachhang = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Id == hd.IdKH);
                            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                hd.ThoiGianThanhToan = DateTime.Now;
                                hd.TrangThai = 0;


                                _IHoaDonServices.Update(hd);

                                _IKhachHangServices.Update(Khachhang);
                                MessageBox.Show("Thanh toán thành công");

                                txt_Tienkhdua.Text = "";
                                lb_Tongtientt.Text = "0";
                                lb_Tienthua.Text = "0";
                                LoadHDCho();

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mã hóa đơn");
                }

            }



        }

     

        private void txt_Nhaptim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nhaptim.Text)) return;
            LoadDSSanPham(txt_Nhaptim.Text);
        }

        private void txt_Nhaptim_Leave(object sender, EventArgs e)
        {
            txt_Nhaptim.Text = "Tìm kiếm .......";
            LoadDSSanPham(null);
        }

        private void txt_Nhaptim_Click(object sender, EventArgs e)
        {
            txt_Nhaptim.Clear();
        }

      
    }
}
