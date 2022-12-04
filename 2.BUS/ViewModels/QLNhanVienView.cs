using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class QLNhanVienView
    {
        public int Id { get; set; }
        public int? IdCV { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string LinkAnh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public int Trangthai { get; set; }


        //bảng chức vụ
        // public int ? IdCV { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }

    }
}
