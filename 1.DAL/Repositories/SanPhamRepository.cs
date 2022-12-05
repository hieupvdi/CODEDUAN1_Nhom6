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
    public class SanPhamRepository : ISanPhamRepository
    {
        private QLDbContext _DbContext;
        public SanPhamRepository()
        {
            _DbContext = new QLDbContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
             obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.SanPhams.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;

            var SP = _DbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.SanPhams.Remove(SP);
            _DbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _DbContext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;

            var SP = _DbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            SP.IdLoaiSP=obj.IdLoaiSP;
            SP.IdSize = obj.IdSize;
            SP.MaSP = obj.MaSP;
            SP.TenSP = obj.TenSP;
            SP.LinkAnh=obj.LinkAnh;
            SP.GiaBan = obj.GiaBan;
            SP.TrangThai=obj.TrangThai;
           
            _DbContext.SanPhams.Update(SP);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
