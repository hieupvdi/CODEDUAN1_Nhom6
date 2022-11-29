using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{

    public class HoaDonCT
    {


    
        public Guid IdHD { get; set; }

        public Guid IdSP { get; set; }
   
        public int SoLuong { get; set; }
  
        public decimal  DonGia{ get; set; }

        //
        public virtual HoaDon? HoaDon { get; set; }
        public virtual SanPham? SanPham { get; set; }
        ///
        //public HoaDon HoaDon { get; set; }
        //public SanPham SanPham { get; set; }

    }
}
