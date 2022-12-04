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
    public partial class frmHoaDon : Form
    {
        private IHoaDonServices _IHoaDonServices;
        private IQLNhanVienServices _IQLNhanVienServices;
        private IKhachHangServices _IKhachHangServices;
        private int _idWhenClick;
        public frmHoaDon()
        {
            InitializeComponent();
            _IHoaDonServices = new HoaDonServices();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IKhachHangServices = new KhachHangServices();
            rbtn_ChuaTT.Checked = true;
            LoadCmb();
            LoadHD();
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

        public void LoadHD()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 10;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "ID";
            dgrid_HoaDon.Columns[1].Visible = false;
            dgrid_HoaDon.Columns[2].Name = "Mã Hóa Đơn";
            dgrid_HoaDon.Columns[3].Name = "Nhân Viên";
            dgrid_HoaDon.Columns[4].Name = "Tên Khách Hàng";
            dgrid_HoaDon.Columns[5].Name = "Thời Gian Tạo";
            dgrid_HoaDon.Columns[6].Name = "Thời Gian Thanh Toán";
            dgrid_HoaDon.Columns[7].Name = "SĐT";
            dgrid_HoaDon.Columns[8].Name = "Địa Chỉ";
            dgrid_HoaDon.Columns[9].Name = "Trạng Thái";

            dgrid_HoaDon.Rows.Clear();

            foreach (var x in _IHoaDonServices.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.TenNV, x.TenKH,x.ThoiGianTao,x.ThoiGianThanhToan,x.SDT,x.DiaChi,(x.TrangThai == 0 ? "Chưa Thanh Toán" : "Đã Thanh Toán"));
            }

        }
        private HoaDonView GetDataFromGui()
        {
            HoaDonView HD = new HoaDonView()
            {
               // Id = Guid.Empty,
                MaHD = txt_Mahd.Text,
                IdNV = _IQLNhanVienServices.GetAll()[cmb_Nhanvien.SelectedIndex].Id,
                IdKH = _IKhachHangServices.GetAll()[cmb_Khachhang.SelectedIndex].Id,
                ThoiGianTao = date_TGtao.Value,
                ThoiGianThanhToan = date_TGTT.Value,
                SDT=txt_Sdt.Text,
                DiaChi=txt_Diachi.Text,
                TrangThai=rbtn_ChuaTT.Checked ? 0:1,
                

            };
            return HD;


        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
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
            _idWhenClick = Convert.ToInt32(dgrid_HoaDon.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Mahd.Text = obj.MaHD;
            txt_Sdt.Text = obj.SDT;
            txt_Diachi.Text = obj.DiaChi;
            if (obj.TrangThai == 1)
            {
                rbtn_ChuaTT.Checked = true;
            }
            else
            {
                rbtn_DaTT.Checked = true;
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IHoaDonServices.Add(GetDataFromGui()));
            LoadHD();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IHoaDonServices.Update(temp));
            LoadHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IHoaDonServices.Delete(temp));
            LoadHD();
        }
    }
}
