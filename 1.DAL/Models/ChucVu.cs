using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{

    public class ChucVu
    {
        
        public Guid Id { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }

        //public List<NhanVien> NhanVien { get; set; }
    }
}
