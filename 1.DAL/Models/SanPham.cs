﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class SanPham
    {
        public int Id { get; set; }

        public int? IdLoaiSP { get; set; }
        public int? IdSize { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LinkAnh { get; set; }

        public decimal GiaBan { get; set; }
        public int TrangThai { get; set; }
        //-------
        public virtual Size? Size { get; set; }
        public virtual LoaiSP? LoaiSP { get; set; }

        //-------
        //public LoaiSP LoaiSP { get; set; }
        //public List<HoaDonCT> HoaDonCTs { get; set; }
    }
}
