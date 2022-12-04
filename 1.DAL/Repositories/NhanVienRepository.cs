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
    public class NhanVienRepository : INhanVienRepository
    {
        private QLDbContext _DbContext;
        public NhanVienRepository()
        {
            _DbContext=new QLDbContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
           // obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _DbContext.NhanViens.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;

            var NV = _DbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);

            _DbContext.NhanViens.Remove(NV);
            _DbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _DbContext.NhanViens.ToList();
        }

        public NhanVien GetById(int id)
        {
            //if (id == Guid.Empty) return null;
            return _DbContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(NhanVien obj)
        {

            if (obj == null) return false;

            var NV = _DbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);

            NV.MaNV = obj.MaNV;
            NV.TenNV = obj.TenNV;
            NV.GioiTinh = obj.GioiTinh;
            NV.NgaySinh = obj.NgaySinh;
            NV.Email = obj.Email;
            NV.SDT = obj.SDT;
            NV.DiaChi = obj.DiaChi;
            NV.MatKhau = obj.MatKhau;
            NV.Trangthai = obj.Trangthai;

            _DbContext.NhanViens.Update(NV);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
