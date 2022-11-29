using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienServices
    {
        string Add(QLNhanVienView obj);
        string Update(QLNhanVienView obj);
        string Delete(QLNhanVienView obj);
        List<QLNhanVienView> GetAll();
        List<QLNhanVienView> GetAll(string input);
        NhanVien GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
