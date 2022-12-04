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
    public partial class frmLoai : Form
    {
        private ILoaiSPServices _ILoaiSPServices;
        private int _idWhenClick;
        public frmLoai()
        {
            InitializeComponent();
            _ILoaiSPServices=new LoaiSPServices();
            LoadLSP(null);
        }

        public void LoadLSP(string input)
        {
            int stt = 1;
            dggrid_LoaisanPham.ColumnCount = 4;
            dggrid_LoaisanPham.Columns[0].Name = "STT";
            dggrid_LoaisanPham.Columns[1].Name = "Id";
            dggrid_LoaisanPham.Columns[1].Visible = false;
            dggrid_LoaisanPham.Columns[2].Name = "Mã loại sp";
            dggrid_LoaisanPham.Columns[3].Name = "Tên loại SP";
            dggrid_LoaisanPham.Rows.Clear();
            foreach (var x in _ILoaiSPServices.GetAll(input))
            {
                dggrid_LoaisanPham.Rows.Add(stt++, x.Id, x.MaLoaiSP, x.TenLoaiSP);
            }
        }
        public LoaiSPView GetDataFromGui()
        {
            return new LoaiSPView()
            {
               // Id = Guid.Empty,
                MaLoaiSP = txt_Malsp.Text,
                TenLoaiSP = txt_Tenlsp.Text,

            };
        }

        private void dggrid_LoaisanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _ILoaiSPServices.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Convert.ToInt32(dggrid_LoaisanPham.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _ILoaiSPServices.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Malsp.Text = obj.MaLoaiSP;
            txt_Tenlsp.Text = obj.TenLoaiSP;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ILoaiSPServices.Add(GetDataFromGui()));
            LoadLSP(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_ILoaiSPServices.Update(temp));
            LoadLSP(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_ILoaiSPServices.Delete(temp));
            LoadLSP(null);
        }
    }
}
