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

        private ISizeServices _ISizeServices;
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
        public Guid nu;
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
            TinhTienGH();

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

                    var HoaDonView = new HoaDonView()
                    {
                    
                        Id = Guid.Empty,
                        MaHD = "HD" + _IHoaDonServices.GetAll().Select(x => x.Id).FirstOrDefault(),
                        ThoiGianTao = DateTime.Now,
                        IdNV = h,
                        IdKH = c.Id,
                        TongTien = tien,


                    };
                    _IHoaDonServices.Add(HoaDonView);
                    //tìm lại id hóa đơn trong sql      
                    
                    UH = _IHoaDonServices.GetAll().Select(x => x.Id ).FirstOrDefault();
            
                    MessageBox.Show($"Tạo hóa đơn thành công IDHD: {Convert.ToString(UH)}");
                    foreach (var item in _lstHoaDonCTView)
                    {
                        var HoaDonCTView = new HoaDonCTView()
                        {
                            IdHD = UH,
                            IdSP = item.IdSP,
                            GiaBan = item.GiaBan,
                            SoLuong = item.SoLuong
                        };
                        _IHoaDonCTServices.Add(HoaDonCTView);
                        //var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == item.IdSP);
                        // p.Stock -= item.Quantity;
                        // _IQLSanPhamServices.Update(p);
                    }

                    txt_Mahd.Text = HoaDonView.Id.ToString();
                    lb_Tongtientt.Text = HoaDonView.TongTien.ToString();
                    txt_Makh.Text = "";
                    lb_TongTiengh.Text = "";
                    //MessageBox.Show($"Tạo hóa đơn thành công IDHD: {Convert.ToString(UH)}");
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

        private void dgrid_QLHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLHoaDon.Rows[e.RowIndex];
                nu = Guid.Parse(r.Cells[1].Value.ToString());
                //cmb_Khachhang.SelectedIndex = nu.ToString();
                //hóa dơn chi tiết
                var od = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == nu);
                //hóa đơn
                var cid = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == nu).IdKH;
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
            }
        }

        private void btn_Capnhatsp_Click(object sender, EventArgs e)
        {
            //if (nu != -1)
            //{
                if (_lstHoaDonCTView.Any())
                {
                    int tien = 0;
                    c = _IKhachHangServices.GetAll().FirstOrDefault(x => x.MaKH == txt_Makh.Text);
                    if (c != null)
                    {
                        var hoadon = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == nu);
                        var hoadonct = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == nu);
                        foreach (var x in hoadonct)
                        {
                            _IHoaDonCTServices.Delete(x);
                        }


                        foreach (var item in _lstHoaDonCTView)
                        {
                            var HoaDonCTView  = new HoaDonCTView()
                            {
                                IdHD = nu,
                                IdSP = item.IdSP,
                                DonGia = item.GiaBan,
                                SoLuong = item.SoLuong
                            };
                            tien += Convert.ToInt32(item.DonGia * item.SoLuong);
                            _IHoaDonCTServices.Add(HoaDonCTView);
                            //var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == item.IdSP);

                            //_IQLSanPhamServices.Update(p);
                        }


                        Guid h = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Email == Properties.Settings.Default.TaiKhoan).Id;
                        hoadon.ThoiGianTao = DateTime.Now;
                        hoadon.IdNV = h;
                        hoadon.IdKH = c.Id;
                        hoadon.TongTien = tien;
                        _IHoaDonServices.Update(hoadon);

                        txt_Mahd.Text = nu.ToString();
                        lb_Tongtientt.Text = tien.ToString()+"VNĐ";
                        txt_Makh.Text = "";
                        lb_TongTiengh.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {nu}");
                       // oID = -1;
                        LoadDSSanPham();         
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
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            //}
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

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            //txt_Mahd.Text = nu.ToString();
            //lb_Tongtientt.Text = hd.TongTien.ToString() + "VNĐ";
            if (int.TryParse(txt_Mahd.Text, out int m) && txt_Mahd.Text != "")
            {
                HoaDonView hd = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(txt_Mahd.Text) && x.Trangthai == 1);
                if (hd == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                    lb_Tongtientt.Text = "0";
                }
                else
                {
                    var Khachhang = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Id == hd.IdKH);

                    if (Convert.ToDecimal(txt_Tienkhdua.Text) > 0 )
                    {
                        MessageBox.Show("Vui lòng nhập đúng số tiền");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            hd.Trangthai = 0;
                            _IHoaDonServices.Update(hd);
                        
                            _IKhachHangServices.Update(Khachhang);
                            MessageBox.Show("Thanh toán thành công");
                  
                            txt_Tienkhdua.Text = "";
                            lb_Tongtientt.Text = "0";
                            lb_Tienthua.Text = "0";
                           

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
        }

        private void btn_CNhoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
