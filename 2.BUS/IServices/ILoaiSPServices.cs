using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiSPServices
    {
        string Add(LoaiSPView obj);
        string Update(LoaiSPView obj);
        string Delete(LoaiSPView obj);
        List<LoaiSPView> GetAll();
        List<LoaiSPView> GetAll(string input);

        LoaiSP GetById(int id);
        int GetIdByName(string name);
    }
}
