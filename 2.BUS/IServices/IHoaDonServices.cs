using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonServices
    {
        string Add(HoaDonView obj);
        string Update(HoaDonView obj);
        string Delete(HoaDonView obj);
        List<HoaDonView> GetAll();
        List<HoaDonView> GetAll(string input);
        HoaDon GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
