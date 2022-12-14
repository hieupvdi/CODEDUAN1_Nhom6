using _1.DAL.Models;
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
    public partial class frmQLSanPham : Form
    {

        private IQLSanPhamServices _IQLSanPhamServices;   
        private ILoaiSPServices _ILoaiSPServices;
        private ISizeServices _ISizeServices;
        string Imagename;
        private Guid _idWhenClick;
        public frmQLSanPham()
        {
            InitializeComponent();
            _IQLSanPhamServices=new QLSanPhamServices();            
            _ILoaiSPServices=new LoaiSPServices();
            _ISizeServices=new SizeServices();
            rbtn_ConBan.Checked = true;
            LoadCmb();
            LoadQLSP(null);
        }
        private void LoadCmb()
        {

            foreach (var x in _ILoaiSPServices.GetAll())
            {
                cmb_Loaisp.Items.Add(x.TenLoaiSP);
            }
            cmb_Loaisp.SelectedIndex = 0;

            foreach (var x in _ISizeServices.GetAll())
            {
                cmb_Size.Items.Add(x.TenSize);
            }
            cmb_Size.SelectedIndex = 0;

        }
            public void LoadQLSP(string input)
            {
                int stt = 1;
                dgrid_QLSanPham.ColumnCount = 8;
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

            foreach (var x in _IQLSanPhamServices.GetAll(input))
            {
                dgrid_QLSanPham.Rows.Add(stt++, x.Id,x.MaSP, x.TenSP,x.TenLoaiSP,x.TenSize,x.GiaBan, (x.TrangThai == 0 ? "Còn Bán" : "Nghỉ Bán") );
            }

            }
        private QLSanPhamView GetDataFromGui()
        {
            QLSanPhamView spv = new QLSanPhamView()             
            {
                Id = Guid.Empty,  
                MaSP = txt_Masp.Text,
                TenSP=txt_Tensp.Text,
                LinkAnh = Imagename,
                IdLoaiSP = _ILoaiSPServices.GetAll()[cmb_Loaisp.SelectedIndex].Id,
                IdSize = _ISizeServices.GetAll()[cmb_Size.SelectedIndex].Id,
                GiaBan = Convert.ToDecimal(txt_Giaban.Text),
                TrangThai = rbtn_ConBan.Checked ? 0 : 1,
            };
            return spv;
        }
        public bool Checkduluu()
        {
        
             if (txt_Tensp.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên sản phẩm");
                return false;
            }
            else if (txt_Tensp.Text.Length < 5)
            {
                MessageBox.Show("Tên sản phẩm phải có ít nhất 5 kí tự");
                return false;
            }
            else if (txt_Tensp.Text.Length > 100)
            {
                MessageBox.Show("Tên sản phẩm phải nhỏ hơn 100 kí tự");
                return false;
            }
            else if(txt_Masp.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mã sản phẩm");
                return false;
            }
            else if (txt_Masp.Text.Length < 2)
            {
                MessageBox.Show("Mã sản phẩm phải có ít nhất 2 kí tự");
                return false;
            }
            else if (txt_Masp.Text.Length > 50)
            {
                MessageBox.Show("Mã sản phẩm phải nhỏ hơn 50 kí tự");
                return false;
            }
            else if (!txt_Giaban.Text.All(char.IsNumber))
            {
                MessageBox.Show("Gía bán phải là số !");
                return false;
            }
            else if (pb_Anh.Image == null)
            {
                MessageBox.Show("Bạn chưa tải ảnh sp !");
                return false;
            }

            return true;
        }
        private void dgrid_QLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IQLSanPhamServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_QLSanPham.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IQLSanPhamServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Masp.Text = obj.MaSP;
            txt_Tensp.Text = obj.TenSP;
            cmb_Loaisp.SelectedIndex = _ILoaiSPServices.GetAll().FindIndex(c => c.Id == obj.IdLoaiSP);
            cmb_Size.SelectedIndex = _ISizeServices.GetAll().FindIndex(c => c.Id == obj.IdSize);

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

            txt_Giaban.Text =Convert.ToString(obj.GiaBan);
            if (obj.TrangThai==0)
            {
                rbtn_ConBan.Checked = true;
            }
            else
            {
                rbtn_Nghiban.Checked = true;
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (_IQLSanPhamServices.GetAll().Any(x => x.MaSP == txt_Masp.Text))
            {
                MessageBox.Show("Mã sản phẩm Đã Tồn tại");
               
            }
            else
            {
                if (!Checkduluu())
                {

                }
                else
                {
                    MessageBox.Show(_IQLSanPhamServices.Add(GetDataFromGui()));
                    LoadQLSP(null);
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
                MessageBox.Show(_IQLSanPhamServices.Update(temp));
                LoadQLSP(null);
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IQLSanPhamServices.Delete(temp));
            LoadQLSP(null);
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

        private void btn_clre_Click(object sender, EventArgs e)
        {

            txt_Masp.Text = null;
            txt_Tensp.Text = null;
            pb_Anh.Image = null;
            cmb_Loaisp.SelectedIndex = 0;
            cmb_Size.SelectedIndex = 0;
            txt_Giaban.Text = null;
            rbtn_ConBan.Checked = true;
        }

        private void btn_ThemSize_Click(object sender, EventArgs e)
        {
            frmSize f = new frmSize();
            f.ShowDialog();
        }

        private void btn_Themloaisp_Click(object sender, EventArgs e)
        {
            frmLoai f =new frmLoai();
            f.ShowDialog();
        }

        private void txt_Nhaptim_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nhaptim.Text)) return;
            LoadQLSP(txt_Nhaptim.Text);
        }

        private void txt_Nhaptim_Leave(object sender, EventArgs e)
        {
            txt_Nhaptim.Text = "Tìm kiếm .......";
            LoadQLSP(null);
        }

        private void txt_Nhaptim_Click(object sender, EventArgs e)
        {
            txt_Nhaptim.Clear();
        }
    }
}
