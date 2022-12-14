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
    public partial class frmSize : Form
    {
        private ISizeServices _ISizeServices;
        private Guid _idWhenClick;
        public frmSize()
        {
            InitializeComponent();
            _ISizeServices = new SizeServices();
            rbtn_ConBan.Checked = true;
            LoadSize();
        }

        public void LoadSize()
        {
            int stt = 1;
            dgrid_Size.ColumnCount = 5;
            dgrid_Size.Columns[0].Name = "STT";
            dgrid_Size.Columns[1].Name = "Id";
            dgrid_Size.Columns[1].Visible = false;
            dgrid_Size.Columns[2].Name = "Mã Size";
            dgrid_Size.Columns[3].Name = "Tên Size";
            //dgrid_Size.Columns[4].Name = "Gía Bán";
            dgrid_Size.Columns[4].Name = "Trạng Thái";
            dgrid_Size.Rows.Clear();
            foreach (var x in _ISizeServices.GetAll())
            {
                dgrid_Size.Rows.Add(stt++, x.Id, x.MaSize, x.TenSize,/*x.Gia,*/x.TrangThai == 0 ? "Còn Bán" : "Nghỉ Bán");
            }
        }
        public bool Checkduluu()
        {

            if (txt_Tensize.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên size");
                return false;
            }
            else if (txt_Tensize.Text.Length < 5)
            {
                MessageBox.Show("Tên size phải có ít nhất 5 kí tự");
                return false;
            }
            else if (txt_Tensize.Text.Length > 100)
            {
                MessageBox.Show("Tên size phải nhỏ hơn 100 kí tự");
                return false;
            }
            else if (txt_Masize.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã size");
                return false;
            }
            else if (txt_Masize.Text.Length < 2)
            {
                MessageBox.Show("mã size phải có ít nhất 2 kí tự");
                return false;
            }
            else if (txt_Masize.Text.Length > 50)
            {
                MessageBox.Show("mã size phải nhỏ hơn 50 kí tự");
                return false;
            }
         
            //else if (!txt_Giaban.Text.All(char.IsNumber))
            //{
            //    MessageBox.Show("Gía bán phải là số !");
            //    return false;
            //}


            return true;
        }
        public SizeView GetDataFromGui()
        {
            return new SizeView()
            {
                Id = Guid.Empty,
                MaSize = txt_Masize.Text,
                TenSize = txt_Tensize.Text,
               // Gia=Convert.ToDecimal(txt_Giaban.Text),
                TrangThai=rbtn_ConBan.Checked ? 0:1,

            };
        }

        private void dgrid_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _ISizeServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_Size.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _ISizeServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Masize.Text = obj.MaSize;
            txt_Tensize.Text = obj.TenSize;
            //txt_Giaban.Text = Convert.ToString(obj.Gia);
            if (obj.TrangThai == 0)
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
            if (_ISizeServices.GetAll().Any(x => x.MaSize == txt_Masize.Text))
            {
                MessageBox.Show("Mã size phẩm Đã Tồn tại");
              
            }
            else
            {
                if (!Checkduluu())
                {

                }
                else
                {
                    MessageBox.Show(_ISizeServices.Add(GetDataFromGui()));
                    LoadSize();
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
                MessageBox.Show(_ISizeServices.Update(temp));
                LoadSize();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_ISizeServices.Delete(temp));
            LoadSize();
        }
    }
}
