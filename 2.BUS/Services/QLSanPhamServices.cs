using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLSanPhamServices : IQLSanPhamServices
    {
       
        private ISanPhamRepository _ISanPhamRepository;
        private ILoaiSPRepository _ILoaiSPRepository;
        private ISizeRepository _ISizeRepository;
        public QLSanPhamServices()
        {
           
            _ISanPhamRepository=new SanPhamRepository();
            _ILoaiSPRepository=new LoaiSPRepository();
            _ISizeRepository=new SizeRepository();
        }

        public string Add(QLSanPhamView obj)
        {
            if (obj == null)
                return "Them that bai";
            var SP = new SanPham()
            {
                Id = obj.Id,              
                IdLoaiSP = obj.IdLoaiSP,
                IdSize=obj.IdSize,
                MaSP = obj.MaSP,
                TenSP = obj.TenSP,
                LinkAnh = obj.LinkAnh,
                GiaBan = obj.GiaBan,
                TrangThai = obj.TrangThai,

            };
            if (_ISanPhamRepository.Add(SP))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(QLSanPhamView obj)
        {
            if (obj == null) return "Xoa that bai";
            var SP = _ISanPhamRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_ISanPhamRepository.Delete(SP))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<QLSanPhamView> GetAll()
        {
            List<QLSanPhamView> lst = new List<QLSanPhamView>();
            lst =
                (
                from a in _ISanPhamRepository.GetAll()           
                join b in _ILoaiSPRepository.GetAll() on a.IdLoaiSP equals b.Id
                join c in _ISizeRepository.GetAll() on a.IdSize equals c.Id
                select new QLSanPhamView()
                {

                    Id = a.Id,
                    IdLoaiSP = a.IdLoaiSP,
                    IdSize = a.IdSize,
                    MaSP = a.MaSP,
                    TenSP = a.TenSP,
                    LinkAnh = a.LinkAnh,
                    GiaBan = a.GiaBan,
                    TrangThai = a.TrangThai,
                    //loai sp
                    //IdLoaiSP =obj.IdLoaiSP,
                    MaLoaiSP = b.MaLoaiSP,
                    TenLoaiSP = b.TenLoaiSP,
                    //size
                    //IdSize=c.IdSize,
                    MaSize=c.MaSize,
                    TenSize=c.TenSize,
                    Gia=c.Gia,
                    TrangThaiSize=c.TrangThai,


                }
                ).ToList();
            return lst;
        }

        public List<QLSanPhamView> GetAll(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaSP.ToLower().StartsWith(input.ToLower()) || c.TenSP.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public SanPham GetById(Guid id)
        {
            return _ISanPhamRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.MaSP == name).Id;
        }

        public string Update(QLSanPhamView obj)
        {
            if (obj == null) return "Sua that bai";
            var SP = _ISanPhamRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            SP.Id = obj.Id;
            SP.IdLoaiSP = obj.IdLoaiSP;
            SP.IdSize = obj.IdSize;
            SP.MaSP = obj.MaSP;
            SP.TenSP = obj.TenSP;
            SP.LinkAnh = obj.LinkAnh;
            SP.GiaBan = obj.GiaBan;
            SP.TrangThai = obj.TrangThai;
            if (_ISanPhamRepository.Update(SP))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
