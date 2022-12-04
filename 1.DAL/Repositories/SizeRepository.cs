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
    public class SizeRepository : ISizeRepository
    {
        private QLDbContext _DbContext;
        public SizeRepository()
        {
            _DbContext=new QLDbContext();
        }
        public bool Add(Size obj)
        {
            if (obj == null) return false;
           // obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.Sizes.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(Size obj)
        {
            if (obj == null) return false;

            var SI = _DbContext.Sizes.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.Sizes.Remove(SI);
            _DbContext.SaveChanges();
            return true;
        }

        public List<Size> GetAll()
        {
            return _DbContext.Sizes.ToList();
        }

        public Size GetById(int id)
        {
            //if (id == Guid.Empty) return null;
            return _DbContext.Sizes.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Size obj)
        {
            if (obj == null) return false;

            var SI = _DbContext.Sizes.FirstOrDefault(c => c.Id == obj.Id);

            SI.MaSize = obj.MaSize;
            SI.TenSize = obj.TenSize;
            SI.Gia = obj.Gia;
            SI.TrangThai = obj.TrangThai;

            _DbContext.Sizes.Update(SI);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
