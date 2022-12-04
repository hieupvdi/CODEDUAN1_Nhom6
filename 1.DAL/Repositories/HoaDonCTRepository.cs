using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        private QLDbContext _DbContext;
        public HoaDonCTRepository()
        {
            _DbContext = new QLDbContext();
        }
        public bool Add(HoaDonCT obj)
        {
            if (obj == null) return false;            
            _DbContext.HoaDonCTs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonCT obj)
        {
            if (obj == null) return false;

            var HDCT = _DbContext.HoaDonCTs.FirstOrDefault(c => c.IdSP == obj.IdSP);

            _DbContext.HoaDonCTs.Remove(HDCT);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDonCT> GetAll()
        {
            return _DbContext.HoaDonCTs.ToList();
        }

        public HoaDonCT GetById(int id)
        {
           // if (id == Guid.Empty) return null;
            return _DbContext.HoaDonCTs.FirstOrDefault(c => c.IdSP == id);
        }

        public bool Update(HoaDonCT obj)
        {
            if (obj == null) return false;

            var HDCT = _DbContext.HoaDonCTs.FirstOrDefault(c => c.IdSP == obj.IdSP);

            //HDCT.IdSP = obj.IdSP;
            HDCT.IdHD = obj.IdHD;
            HDCT.SoLuong = obj.SoLuong;
            HDCT.DonGia = obj.DonGia;
            _DbContext.HoaDonCTs.Update(HDCT);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
