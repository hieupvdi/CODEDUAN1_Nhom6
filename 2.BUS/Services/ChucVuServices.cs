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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuRepository _IChucVuRepository;
        public ChucVuServices()
        {
            _IChucVuRepository = new ChucVuRepository();
        }
        public string Add(ChucVuView obj)
        {
            if (obj == null)
                return "Them that bai";
            var CV = new ChucVu()
            {
                Id = obj.Id,
                MaCV = obj.MaCV,
                TenCV = obj.TenCV,

            };
            if (_IChucVuRepository.Add(CV))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "Xoa that bai";
            var CV = _IChucVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_IChucVuRepository.Delete(CV))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<ChucVuView> GetAll()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst =
                (
                from a in _IChucVuRepository.GetAll()
                select new ChucVuView()
                {
                    Id = a.Id,
                    MaCV = a.MaCV,
                    TenCV = a.TenCV,
                }
                ).ToList();
            return lst;
        }

        public List<ChucVuView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaCV.ToLower().StartsWith(input.ToLower()) || c.TenCV.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public ChucVu GetById(Guid id)
        {
            return _IChucVuRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenCV == name).Id;
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "Sua that bai";
            var CV = _IChucVuRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            CV.MaCV = obj.MaCV;
            CV.TenCV = obj.TenCV;
            if (_IChucVuRepository.Update(CV))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
