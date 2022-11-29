using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);

        SanPham GetById(Guid id);//Phuong thuc tim san pham theo id
        List<SanPham> GetAll();
    }
}
