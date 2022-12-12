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
        private IHoaDonServices _IHoaDonServices;
        private Guid _idWhenClick;
        public frmKhachHang()
        {
            InitializeComponent();
            _IKhachHangServices = new KhachHangServices();
            _IHoaDonServices=new HoaDonServices();
            LoadKH(null);
        }
        public void LoadKH(string input)
        {
            int stt = 1;
            dggrid_Khachhang.ColumnCount = 6;
            dggrid_Khachhang.Columns[0].Name = "STT";
            dggrid_Khachhang.Columns[1].Name = "ID";
            dggrid_Khachhang.Columns[1].Visible = false;
            dggrid_Khachhang.Columns[2].Name = "Mã Khách Hàng";
            dggrid_Khachhang.Columns[3].Name = "Tên Khách Hàng";
            dggrid_Khachhang.Columns[4].Name = "SĐT";
            dggrid_Khachhang.Columns[5].Name = "Địa Chỉ";

            dggrid_Khachhang.Rows.Clear();

            foreach (var x in _IKhachHangServices.GetAll(input))
            {
                dggrid_Khachhang.Rows.Add(stt++,x.Id,x.MaKH,x.TenKH,x.SDT,x.DiaChi);
            }

        }
        public bool Checkduluu()
        {
           
             if (txt_Tenkh.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Khách Hàng");
                return false;
            }
            else if (txt_Tenkh.Text.Length < 5)
            {
                MessageBox.Show("Tên Khách Hàng phải có ít nhất 5 kí tự");
                return false;
            }
            else if (txt_Tenkh.Text.Length > 100)
            {
                MessageBox.Show("Tên Khách Hàng phải nhỏ hơn 100 kí tự");
                return false;
            }
            else  if (txt_Makh.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã Khách Hàng");
                return false;
            }
            else if (txt_Makh.Text.Length < 2)
            {
                MessageBox.Show("mã Khách Hàng phải có ít nhất 2 kí tự");
                return false;
            }
            else if (txt_Makh.Text.Length > 50)
            {
                MessageBox.Show("mã Khách Hàng phải nhỏ hơn 50 kí tự");
                return false;
            }
       
            //else if (txt_Sdt.Text.Length < 10)
            //{
            //    MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");
            //    return false;
            //}
            //else if (txt_Sdt.Text.Length > 12)
            //{
            //    MessageBox.Show("Số điện thoại không được lớn hơn 12  kí tự");
            //    return false;
            //}
            //else if (!txt_Sdt.Text.All(char.IsNumber))
            //{
            //    MessageBox.Show("Số điện thoại phải là số !");
            //    return false;
            //}
            //else if (txt_Diachi.Text.Length == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập địa chỉ !");
            //    return false;
            //}

            return true;
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
            if (_IKhachHangServices.GetAll().Any(x => x.MaKH == txt_Makh.Text))
            {
                MessageBox.Show("Mã Khách Hàng Đã Tồn tại");

            }
            else
            {
                if (!Checkduluu())
                {

                }
                else
                {
                    MessageBox.Show(_IKhachHangServices.Add(GetDataFromGui()));
                    LoadKH(null);
                }
            }
       
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!Checkduluu())
            {

            }
            else
            {
                var temp = GetDataFromGui();
                temp.Id = _idWhenClick;
                MessageBox.Show(_IKhachHangServices.Update(temp));
                LoadKH(null);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Guid h = _IKhachHangServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick).Id;
            var kh = _IHoaDonServices.GetAll().FirstOrDefault(x => x.IdKH == h);

            if (kh != null)
            {
                MessageBox.Show("khách hàng đã mua hàng nên k thể xóa đ");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn muốn xóa khách hàng  không việc xóa khách hàng có thể làm mất hóa đơn chứ khách hàng?", "Xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var temp = GetDataFromGui();
                    temp.Id = _idWhenClick;
                    MessageBox.Show(_IKhachHangServices.Delete(temp));
                    LoadKH(null);
                }
            }
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

        private void txt_Nhaptim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nhaptim.Text)) return;
            LoadKH(txt_Nhaptim.Text);
        }

        private void txt_Nhaptim_Leave(object sender, EventArgs e)
        {
            txt_Nhaptim.Text = "Tìm kiếm .......";
            LoadKH(null);
        }

        private void txt_Nhaptim_Click(object sender, EventArgs e)
        {
            txt_Nhaptim.Clear();
        }
    }
}
