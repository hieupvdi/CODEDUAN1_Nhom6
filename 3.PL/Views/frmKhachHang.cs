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
    public partial class frmKhachHang : Form
    {
        private IKhachHangServices _IKhachHangServices;
        private Guid _idWhenClick;
        public frmKhachHang()
        {
            InitializeComponent();
            _IKhachHangServices = new KhachHangServices();
            LoadKH(null);
        }
        public void LoadKH(string input)
        {
            int stt = 1;
            dggrid_Khachhang.ColumnCount = 11;
            dggrid_Khachhang.Columns[0].Name = "STT";
            dggrid_Khachhang.Columns[1].Name = "ID";
            dggrid_Khachhang.Columns[2].Name = "Mã Khách Hàng";
            dggrid_Khachhang.Columns[3].Name = "Tên Khách Hàng";
            dggrid_Khachhang.Columns[4].Name = "SĐT";
            dggrid_Khachhang.Columns[5].Name = "Địa Chỉ";

            dggrid_Khachhang.Rows.Clear();

            foreach (var x in _IKhachHangServices.GetAll(input))
            {
                dggrid_Khachhang.Rows.Add(stt++,x.Id,x.MaKH,x.TenKH,x.TenKH,x.SDT,x.DiaChi);
            }

        }
        private KhachHangView GetDataFromGui()
        {        
            return new KhachHangView()
            {
                Id = Guid.Empty,
                MaKH=txt_Makh.Text,
                TenKH=txt_Tenkh.Text,
                SDT=txt_Sdt.Text,
                DiaChi=txt_Diachi.Text,
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IKhachHangServices.Add(GetDataFromGui()));
            LoadKH(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IKhachHangServices.Update(temp));
            LoadKH(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IKhachHangServices.Delete(temp));
            LoadKH(null);
        }

        private void dggrid_Khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IKhachHangServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dggrid_Khachhang.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Makh.Text = obj.MaKH;
            txt_Tenkh.Text = obj.TenKH;
            txt_Sdt.Text = obj.SDT;
            txt_Diachi.Text = obj.DiaChi;
        }
    }
}
