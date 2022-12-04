using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamServices
    {
        string Add(QLSanPhamView obj);
        string Update(QLSanPhamView obj);
        string Delete(QLSanPhamView obj);
        List<QLSanPhamView> GetAll();
        List<QLSanPhamView> GetAll(string input);
        SanPham GetById(int id);
        int GetIdByName(string name);
    }
}
