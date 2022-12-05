using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid Id { get; set; }

        public Guid? IdNV { get; set; }

        public Guid? IdKH { get; set; }
        public string MaHD { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public decimal TongTien { get; set; }
        public int TrangThai { get; set; }

        //bảng Nhân viên
        //public Guid Id { get; set; }
        public Guid? IdCV { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string LinkAnh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDTNV { get; set; }
        public string DiaChiNV { get; set; }
        public string MatKhau { get; set; }
        public int Trangthai { get; set; }

        //bảng Khách hàng
        //public Guid Id { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDTKH { get; set; }
        public string DiaChiKH { get; set; }




    }
}
