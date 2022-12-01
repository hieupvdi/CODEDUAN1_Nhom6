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
        private ILoaiSPServices _ILoaiSPServices;
        private ISizeServices _ISizeServices;
        //Gọi sv hóa đơn chờ
        private IKhachHangServices _IKhachHangServices;
        //Gọi sv hóa đơn ct-giỏ hàng
        private IHoaDonCTServices _IHoaDonCTServices;
        private IHoaDonServices _IHoaDonServices;

        private Guid _idWhenClick;
        private Guid _idHD;
        private Guid u;
  
        public frmBanHang()
        {
            InitializeComponent();
            _IQLSanPhamServices = new QLSanPhamServices();
            _ILoaiSPServices = new LoaiSPServices();
            _ISizeServices = new SizeServices();
            _IHoaDonServices = new HoaDonServices();
            _IHoaDonCTServices =new HoaDonCTServices();
            _IKhachHangServices = new KhachHangServices();
            LoadQLSP();
            LoadQLCTHD();
            LoadQLHD();
            LoadCmb();
        }
        public void LoadCmb()
        {
            foreach (var x in _IKhachHangServices.GetAll())
            {
                cmb_Khachhang.Items.Add(x.TenKH);
            }
            cmb_Khachhang.SelectedIndex = 0;

        

        }
        //bảng hóa đơn -hóa đơn chờ
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
        //Bảng sản phẩm
        public void LoadQLSP()
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
        public void LoadQLCTHD()
        {
            float ThanhTien;
            int stt = 1;
            dgrid_Hoadonct.ColumnCount = 10;
            dgrid_Hoadonct.Columns[0].Name = "STT";
            dgrid_Hoadonct.Columns[1].Name = "ID";
            dgrid_Hoadonct.Columns[1].Visible = false;
           dgrid_Hoadonct.Columns[1].Name = "Mã sp";
            dgrid_Hoadonct.Columns[2].Name = "Tên sp";
            dgrid_Hoadonct.Columns[3].Name = "Số Lượng";
            dgrid_Hoadonct.Columns[4].Name = "Đơn Gía";
            //dgrid_Hoadonct.Columns[5].Name = "Thành Tiền";

            dgrid_Hoadonct.Rows.Clear();

            foreach (var x in _IHoaDonCTServices.GetAll())
            {
                dgrid_Hoadonct.Rows.Add(stt++, x.MaSP, x.TenSP, x.SoLuong, x.DonGia);
            }

        }

        private void btn_Themgh_Click(object sender, EventArgs e)
        {
            
        }

        private void dgrid_QLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int RowIndex = e.RowIndex;
            //if (e.RowIndex == -1)
            //{
            //    return;
            //}
            //if (RowIndex == _IQLSanPhamServices.GetAll().Count)
            //{
            //    return;
            //}
            //_idWhenClick = Guid.Parse(dgrid_QLSanPham.Rows[RowIndex].Cells[1].Value.ToString());
            //var obj = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.MaSP == _idWhenClick);

            // add Vào dgrid_Hoadonct 
            //dgrid_Hoadonct.Columns[1].Name = obj.MaSP;
            //dgrid_Hoadonct.Columns[2].Name = obj.TenSP;
            //dgrid_Hoadonct.Columns[4].Name = Convert.ToString(obj.GiaBan);
            //bj.GiaBan = dgrid_Hoadonct.Columns[4].Name = "Đơn Gía";
            //_idHD = Guid.Parse(dgrid_QLHoaDon.Rows[RowIndex].Cells[1].Value.ToString());
            //var abj = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idHD);
            //HoaDonCTView nvv = new HoaDonCTView()
            //{

            //    IdHD = abj.Id,
            //    IdSP = obj.Id,
            //    //SoLuong = sl,
            //     GiaBan =  Convert.ToDecimal(obj.GiaBan),
            //};
            //_IHoaDonCTServices.Add(nvv);
            DataGridViewRow r = dgrid_QLSanPham.Rows[e.RowIndex];
            //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
            u = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.MaSP == r.Cells[1].Value.ToString()).Id;
            AddGioHang(u);

        }
        private void AddGioHang(Guid u)
        {
           // FirstOrDefault
            var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == u);
            var data = _IHoaDonCTServices.GetAll().FirstOrDefault(x => x.IdSP == p.Id);
            HoaDonCTView add = new HoaDonCTView()
            {
                IdSP = p.Id,
                TenSP = p.TenSP,
                GiaBan = p.GiaBan,
                SoLuong = 1,
                //MaSp = p.MaSp
            };
            _IHoaDonCTServices.Add(add);
        }
        private HoaDonCTView AddvaoGH()
        {
            int sl=1;
            foreach (var item in _IQLSanPhamServices.GetAll())
            {
                sl++;
            }
            var idhd = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == _idHD);
        
            HoaDonCTView nvv = new HoaDonCTView()
            {

                MaSP = idhd.MaSP,
                TenSP = idhd.TenSP,
                SoLuong = sl,
                GiaBan = idhd.GiaBan,
            };
            return nvv;


        }

        private void btn_Xoagh_Click(object sender, EventArgs e)
        {

            //var temp = add();
            //temp.Id = _idWhenClick;
            //MessageBox.Show(_IKhachHangServices.Delete(temp));
            //LoadQLCTHD();
        }

        private void dgrid_Hoadonct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IHoaDonCTServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_Hoadonct.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IHoaDonCTServices.GetAll().FirstOrDefault(x => x.IdSP == _idWhenClick);



        }
    }
}
