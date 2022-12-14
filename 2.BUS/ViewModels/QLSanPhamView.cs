using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class QLSanPhamView
    {

        public Guid Id { get; set; }

        public Guid? IdLoaiSP { get; set; }
        public Guid? IdSize { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LinkAnh { get; set; }

        public decimal GiaBan { get; set; }
        public int TrangThai { get; set; }

        //bảng loại sản phẩm
        // public Guid? IdLoaiSP { get; set; }
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        //Bảng Size
        //public Guid IdSize { get; set; }
        public string MaSize { get; set; }
        public string TenSize { get; set; }
        //public decimal Gia { get; set; }
        public int TrangThaiSize { get; set; }



    }
}
