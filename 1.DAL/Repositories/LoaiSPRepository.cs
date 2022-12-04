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
    public class LoaiSPRepository : ILoaiSPRepository
    {
        private QLDbContext _DbContext;
        public LoaiSPRepository()
        {
            _DbContext=new QLDbContext();
        }
        public bool Add(LoaiSP obj)
        {
            if (obj == null) return false;
           // obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.LoaiSPs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSP obj)
        {

            if (obj == null) return false;

            var LSP = _DbContext.LoaiSPs.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.LoaiSPs.Remove(LSP);
            _DbContext.SaveChanges();
            return true;
        }

        public List<LoaiSP> GetAll()
        {
            return _DbContext.LoaiSPs.ToList();
        }

        public LoaiSP GetById(int id)
        {
           // if (id == Guid.Empty) return null;
            return _DbContext.LoaiSPs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(LoaiSP obj)
        {
            if (obj == null) return false;

            var LSP = _DbContext.LoaiSPs.FirstOrDefault(c => c.Id == obj.Id);

            LSP.TenLoaiSP = obj.TenLoaiSP;

            _DbContext.LoaiSPs.Update(LSP);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
