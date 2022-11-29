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
    public class ChucVuRepository : IChucVuRepository
    {
        private QLDbContext _DbContext;
        public ChucVuRepository()
        {
            _DbContext=new QLDbContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.ChucVus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;

            var CV = _DbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.ChucVus.Remove(CV);
            _DbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _DbContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;

            var CV = _DbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            CV.MaCV = obj.MaCV;
            CV.TenCV = obj.TenCV;

            _DbContext.ChucVus.Update(CV);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
