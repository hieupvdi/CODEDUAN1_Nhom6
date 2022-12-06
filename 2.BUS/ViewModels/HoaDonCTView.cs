using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonCTView
    {
        
        public Guid IdHD { get; set; }
        public Guid IdSP { get; set; }
    
        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        //Bảng Hóa Đơn
        // public Guid Id { get; set; }

        public Guid? IdNV { get; set; }

        public Guid? IdKH { get; set; }
        public string MaHD { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public decimal TongTien { get; set; }
        public int TrangThai { get; set; }

        //Bảng  Sản Phẩm
        // public Guid Id { get; set; }

        public Guid? IdLoaiSP { get; set; }
        public Guid? IdSize { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LinkAnh { get; set; }

        public decimal GiaBan { get; set; }
        public int TrangThaiSP { get; set; }



    }
}
