using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);

        HoaDon GetById(int id);//Phuong thuc tim san pham theo id
        List<HoaDon> GetAll();
    }
}
