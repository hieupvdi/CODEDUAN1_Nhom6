using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{

    public class NhanVien
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


        ///---------
        public virtual ChucVu ? ChucVu { get; set; }


    

    }
}
