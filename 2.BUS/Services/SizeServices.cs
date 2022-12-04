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
    public class SizeServices : ISizeServices
    {
        private ISizeRepository _ISizeRepository;
        public SizeServices()
        {
            _ISizeRepository = new SizeRepository();
        }
        public string Add(SizeView obj)
        {
            if (obj == null)
                return "Them that bai";
            var SI = new Size()
            {
                Id = obj.Id,
                MaSize = obj.MaSize,
                TenSize = obj.TenSize,
                Gia=obj.Gia,
                TrangThai=obj.TrangThai,    

            };
            if (_ISizeRepository.Add(SI))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(SizeView obj)
        {
            if (obj == null) return "Xoa that bai";
            var SI = _ISizeRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_ISizeRepository.Delete(SI))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<SizeView> GetAll()
        {
            List<SizeView> lst = new List<SizeView>();
            lst =
                (
                from a in _ISizeRepository.GetAll()
                select new SizeView()
                {
                    Id = a.Id,
                    MaSize = a.MaSize,
                    TenSize = a.TenSize,
                    Gia = a.Gia,
                    TrangThai = a.TrangThai,
                }
                ).ToList();
            return lst;
        }

        public List<SizeView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaSize.ToLower().StartsWith(input.ToLower()) || c.TenSize.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public Size GetById(int id)
        {
            return _ISizeRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public int GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenSize == name).Id;
        }

        public string Update(SizeView obj)
        {
            if (obj == null) return "Sua that bai";
            var SI = _ISizeRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            SI.Id = obj.Id;
            SI.MaSize = obj.MaSize;
            SI.TenSize = obj.TenSize;
            SI.Gia = obj.Gia;
            SI.TrangThai = obj.TrangThai;
            if (_ISizeRepository.Update(SI))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
