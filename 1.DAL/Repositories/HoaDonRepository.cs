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
    public class HoaDonRepository : IHoaDonRepository
    {
        private QLDbContext _DbContext;
        public HoaDonRepository()
        {
            _DbContext = new QLDbContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
           // obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.HoaDons.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;

            var HD = _DbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.HoaDons.Remove(HD);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _DbContext.HoaDons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;

            var HD = _DbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);

            HD.IdNV = obj.IdNV;
            HD.IdKH = obj.IdKH;
            HD.ThoiGianTao = obj.ThoiGianTao;
            HD.ThoiGianThanhToan = obj.ThoiGianThanhToan;
            HD.SDT = obj.SDT;
            HD.DiaChi = obj.DiaChi;
            HD.TongTien = obj.TongTien;
            HD.TrangThai = obj.TrangThai;
           

            _DbContext.HoaDons.Update(HD);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
