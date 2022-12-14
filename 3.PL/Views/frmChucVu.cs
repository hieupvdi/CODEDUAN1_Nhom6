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
    public partial class frmChucVu : Form
    {
        private IChucVuServices _IChucVuServices;
        private Guid _idWhenClick;
        public frmChucVu()
        {
            InitializeComponent();
            _IChucVuServices = new ChucVuServices();
            LoadCV(null);
        }
        public void LoadCV(string input)
        {
            int stt = 1;
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = "STT";
            dgrid_ChucVu.Columns[1].Name = "Id";
            dgrid_ChucVu.Columns[1].Visible=false;
           dgrid_ChucVu.Columns[2].Name = "Mã CV";
            dgrid_ChucVu.Columns[3].Name = "Tên cv";
            dgrid_ChucVu.Rows.Clear();
            foreach (var x in _IChucVuServices.GetAll(input))
            {
                dgrid_ChucVu.Rows.Add(stt++, x.Id, x.MaCV, x.TenCV);
            }
        }
        public bool Checkduluu()
        {

            if (txt_Tencv.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Chức Vụ");
                return false;
            }
            else if (txt_Tencv.Text.Length < 5)
            {
                MessageBox.Show("Tên Chức Vụ phải có ít nhất 5 kí tự");
                return false;
            }
            else if (txt_Tencv.Text.Length > 100)
            {
                MessageBox.Show("Tên Chức Vụ phải nhỏ hơn 100 kí tự");
                return false;
            }
            else if (txt_Macv.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã Chức Vụ");
                return false;
            }
            else if (txt_Macv.Text.Length < 2)
            {
                MessageBox.Show("mã Chức Vụ phải có ít nhất 2 kí tự");
                return false;
            }
            else if (txt_Macv.Text.Length > 50)
            {
                MessageBox.Show("mã Chức Vụ phải nhỏ hơn 50 kí tự");
                return false;
            }
        
    

            return true;
        }
        public ChucVuView GetDataFromGui()
        {
            return new ChucVuView()
            {
                Id = Guid.Empty,
                MaCV = txt_Macv.Text,
                TenCV = txt_Tencv.Text,

            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (_IChucVuServices.GetAll().Any(x => x.MaCV == txt_Macv.Text))
            {
                MessageBox.Show("Mã Chức Vụ Đã Tồn tại");
               
            }
            else
            {
                if (!Checkduluu())
                {

                }
                else
                {
                    MessageBox.Show(_IChucVuServices.Add(GetDataFromGui()));
                    LoadCV(null);
                }
            }
        
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IChucVuServices.Update(temp));
            LoadCV(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_IChucVuServices.Delete(temp));
            LoadCV(null);
        }

        private void dgrid_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _IChucVuServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_ChucVu.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _IChucVuServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Macv.Text = obj.MaCV;
            txt_Tencv.Text = obj.TenCV;
        }
    }
}
