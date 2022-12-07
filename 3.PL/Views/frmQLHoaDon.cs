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
        private IQLSanPhamServices _IQLSanPhamServices;


        //
        private IHoaDonCTServices _IHoaDonCTServices;
        private Guid _idWhenClick;
        public Guid oID;
        public Guid u;
        public Guid _idhdcho;
        public List<HoaDonCTView> _lstHoaDonCTView;
        public frmQLHoaDon()
        {
            InitializeComponent();
            _IHoaDonServices = new HoaDonServices();
            _IHoaDonCTServices = new HoaDonCTServices();
            _IQLSanPhamServices = new QLSanPhamServices();
            _lstHoaDonCTView = new List<HoaDonCTView>();
          

            LoadHoaDon();
       


        }
        //bảng  hóa đơn
        public void LoadHoaDon()
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
                dgrid_QLHoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH, x.ThoiGianTao, x.ThoiGianThanhToan, x.SDT, x.DiaChi, (x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán"));
            }

        }

        //bảng chi tiết hóa đơn
        public void LoadHoaDonCT(/*Guid idhd*/)
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

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (oID == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa");
            }
            else
            {
                HoaDonView hd = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == oID);
                if (hd.TrangThai != 0)
                {
                    MessageBox.Show("Chỉ có hóa đơn chưa thanh toán mới được xóa : Định Trộm Tiền của quán à");
                }
                else
                {
                    var _lshd = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == oID);
                    foreach (var a in _lshd)
                    {
                        var p = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == a.IdSP);
                     
                        _IHoaDonCTServices.Delete(a);
                    }
                    _IHoaDonServices.Delete(hd);
                  
                    MessageBox.Show("Xóa thành công");
                    LoadHoaDon();
                    dgrid_Hoadonct.Rows.Clear();
                }
            }
        }

        private void dgrid_QLHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_QLHoaDon.Rows[e.RowIndex];


                _idhdcho = Guid.Parse(r.Cells[1].Value.ToString());



                //hóa dơn chi tiết
                var od = _IHoaDonCTServices.GetAll().Where(x => x.IdHD == _idhdcho);
                //hóa đơn
                var cid = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idhdcho).IdKH;
                // khách hàng
               

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

                    LoadHoaDonCT();
                }

            

                //if (e.RowIndex >= 0)
                //{
                //    DataGridViewRow r = dgrid_QLHoaDon.Rows[e.RowIndex];
                //    u = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[1].Value.ToString())).Id;
                //    LoadHoaDonCT(u);
                //}


            }
        }

        private void btn_Inhd_Click(object sender, EventArgs e)
        {
            frmInHoaDon f = new frmInHoaDon();
            f.ShowDialog();
        }
    }
}
