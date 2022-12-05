using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiSPRepository
    {
        bool Add(LoaiSP obj);
        bool Update(LoaiSP obj);
        bool Delete(LoaiSP obj);

        LoaiSP GetById(Guid id);//Phuong thuc tim san pham theo id
        List<LoaiSP> GetAll();
    }
}
