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
    public class KhachHangRepository : IKhachHangRepository
    {
        private QLDbContext _DbContext;
        public KhachHangRepository()
        {
            _DbContext=new QLDbContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.KhachHangs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;

            var KH = _DbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.KhachHangs.Remove(KH);
            _DbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _DbContext.KhachHangs.ToList();
        }

        public KhachHang GetById(Guid id)
        {

            if (id == Guid.Empty) return null;
            return _DbContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;

            var KH = _DbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);

            KH.TenKH = obj.TenKH;
            KH.SDT = obj.SDT;
            KH.DiaChi = obj.DiaChi;
            _DbContext.KhachHangs.Update(KH);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
