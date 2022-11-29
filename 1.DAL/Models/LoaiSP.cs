using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
 
    public class LoaiSP
    {

        public Guid Id { get; set; }
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        //public List<CTSanPham> CTSanPham { get; set; }
    }
}
