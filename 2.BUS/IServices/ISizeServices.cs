using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISizeServices
    {
        string Add(SizeView obj);
        string Update(SizeView obj);
        string Delete(SizeView obj);
        List<SizeView> GetAll();
        List<SizeView> GetAll(string input);
        Size GetById(int id);
        int GetIdByName(string name);
    }
}
