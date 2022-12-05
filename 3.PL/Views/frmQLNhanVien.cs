using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class frmQLNhanVien : Form
    {
        private IQLNhanVienServices _IQLNhanVienServices;
        private IChucVuServices _IChucVuServices;
        string Imagename;
        private Guid _idWhenClick;
        
    

        public frmQLNhanVien()
        {
            InitializeComponent();
            _IQLNhanVienServices = new QLNhanVienServices();
            _IChucVuServices = new ChucVuServices();
            LoadCV();
            rbtn_Nam.Checked = true;
            rbtn_Danglam.Checked = true;
            LoadQLNhanVien(null);
        }
        public void LoadCV()
        {
            foreach (var item in _IChucVuServices.GetAll())
            {
                cmb_Chucvu.Items.Add(item.TenCV);


            }
            cmb_Chucvu.SelectedIndex = 0;
        }
        public void LoadQLNhanVien(string input)
        {
            int stt = 1;
            dgrid_QLNhanvien.ColumnCount = 13;
            dgrid_QLNhanvien.Columns[0].Name = "STT";
            dgrid_QLNhanvien.Columns[1].Name = "ID";
            dgrid_QLNhanvien.Columns[1].Visible = false;
            dgrid_QLNhanvien.Columns[2].Name = "Mã Nhân Viên";
            dgrid_QLNhanvien.Columns[3].Name = "Tên Nhân Viên";
            //dgrid_QLNhanvien.Columns[4].Name = "Link Ảnh Nhân Viên";
            dgrid_QLNhanvien.Columns[4].Name = "Chức Vụ";
            dgrid_QLNhanvien.Columns[5].Name = "Giới Tính";
            dgrid_QLNhanvien.Columns[6].Name = "Ngày Sinh";
            dgrid_QLNhanvien.Columns[7].Name = "Email";
            dgrid_QLNhanvien.Columns[8].Name = "SĐT";
            dgrid_QLNhanvien.Columns[9].Name = "Địa Chỉ";
            dgrid_QLNhanvien.Columns[10].Name = "Mật Khẩu";
            dgrid_QLNhanvien.Columns[11].Name = "Trang Thái";
            dgrid_QLNhanvien.Rows.Clear();

            foreach (var x in _IQLNhanVienServices.GetAll(input))
            {
                dgrid_QLNhanvien.Rows.Add(stt++, x.Id, x.MaNV, x.TenNV,/*x.LinkAnh,*/ x.TenCV, (x.GioiTinh == "Nam" ? "Nam" : "Nữ"), x.NgaySinh, x.Email, x.SDT, x.DiaChi, x.MatKhau, x.Trangthai == 0 ? "Đang Làm" : "Nghỉ Việc");
            }

        }
        private QLNhanVienView GetDataFromGui()
        {
            QLNhanVienView nvv = new QLNhanVienView()           
            {
                Id = Guid.Empty,
            
                MaNV = txt_Manv.Text,
                TenNV = txt_Tennv.Text,
                LinkAnh = Imagename,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                NgaySinh = date_Ngaysinh.Value,
                Email = txt_Email.Text,
                SDT = txt_Sdt.Text,
                DiaChi = txt_Diachi.Text,
                MatKhau = txt_Matkhau.Text,
                Trangthai = rbtn_Danglam.Checked ? 1 : 0,
                IdCV = _IChucVuServices.GetAll()[cmb_Chucvu.SelectedIndex].Id,
                
            };
            return nvv;
           

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IQLNhanVienServices.Add(GetDataFromGui()));
            LoadQLNhanVien(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IQLNhanVienServices.Update(temp));
            LoadQLNhanVien(null);
        }

   

        private void btn_ThemCV_Click(object sender, EventArgs e)
        {
            frmChucVu f = new frmChucVu();
            f.ShowDialog();
          
        }

        private void dgrid_QLNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IQLNhanVienServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_QLNhanvien.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IQLNhanVienServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Manv.Text = obj.MaNV;
            txt_Tennv.Text = obj.TenNV;
            Imagename = obj.LinkAnh;
            if (Imagename != null && File.Exists(Imagename))
            {
                pb_Anh.Image = Image.FromFile(Imagename);
                pb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pb_Anh.Image = null;
            }

            if (obj.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
            {
                rbtn_Nu.Checked = true;
            }
           
            date_Ngaysinh.Value = obj.NgaySinh;

            txt_Sdt.Text = obj.SDT;
            txt_Diachi.Text = obj.DiaChi;
            txt_Email.Text = obj.Email;
            txt_Matkhau.Text = obj.MatKhau;

            if (obj.Trangthai == 1)
            {
                rbtn_Nghiviec.Checked = true;
                
            }
            else
            {
                rbtn_Danglam.Checked = true;
            }
           
        }

        private void btn_Themanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                Imagename = op.FileName;
                pb_Anh.Image = Image.FromFile(op.FileName);
                pb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    

        private void btn_Nghiviec_Click(object sender, EventArgs e)
        {

        }
    }
    }
