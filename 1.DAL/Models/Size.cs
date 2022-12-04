using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string MaSize { get; set; }
        public string TenSize { get; set; }
        public decimal Gia { get; set; }
        public int TrangThai { get; set; }
    }
}
