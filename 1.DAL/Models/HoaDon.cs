using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{

    public class HoaDon
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

        //trong hóa đơn có nhiều hóa đơn chi tiết
       // public List<HoaDonCT> HoaDonCTs { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhachHang? KhachHang { get; set; }

        //
        //public NhanVien NhanVien { get; set; }
        //public KhachHang KhachHang { get; set; }

        //public List<HoaDonCT> HoaDonCTs { get; set; }


    }
}
