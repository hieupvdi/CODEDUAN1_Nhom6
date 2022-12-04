using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonCTServices
    {
        string Add(HoaDonCTView obj);
        string Update(HoaDonCTView obj);
        string Delete(HoaDonCTView obj);
        List<HoaDonCTView> GetAll();
        List<HoaDonCTView> GetAll(string input);
        HoaDonCT GetById(int id);
        int GetIdByName(string name);
    }
}
