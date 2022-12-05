using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangServices
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> GetAll();
        List<KhachHangView> GetAll(string input);

        KhachHang GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
