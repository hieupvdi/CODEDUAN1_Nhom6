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
    public class LoaiSPServices : ILoaiSPServices
    {
        private ILoaiSPRepository _ILoaiSPRepository;
        public LoaiSPServices()
        {
            _ILoaiSPRepository = new LoaiSPRepository();
        }
        public string Add(LoaiSPView obj)
        {
            if (obj == null)
                return "Them that bai";
            var lsp = new LoaiSP()
            {
                Id = obj.Id,
                MaLoaiSP = obj.MaLoaiSP,
                TenLoaiSP = obj.TenLoaiSP
            };
            if (_ILoaiSPRepository.Add(lsp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(LoaiSPView obj)
        {
            if (obj == null) return "Xoa that bai";
            var lsp = _ILoaiSPRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_ILoaiSPRepository.Delete(lsp))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<LoaiSPView> GetAll()
        {
            List<LoaiSPView> lst = new List<LoaiSPView>();
            lst =
                (
                from a in _ILoaiSPRepository.GetAll()
                select new LoaiSPView()
                {
                    Id = a.Id,
                    MaLoaiSP = a.MaLoaiSP,
                    TenLoaiSP = a.TenLoaiSP
                }
                ).ToList();
            return lst;
        }

        public List<LoaiSPView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaLoaiSP.ToLower().StartsWith(input.ToLower()) || c.TenLoaiSP.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public LoaiSP GetById(int id)
        {
            return _ILoaiSPRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public int GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenLoaiSP == name).Id;
        }

        public string Update(LoaiSPView obj)
        {
            if (obj == null) return "Sua that bai";
            var lsp = _ILoaiSPRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            lsp.MaLoaiSP = obj.MaLoaiSP;
            lsp.TenLoaiSP = obj.TenLoaiSP;
            if (_ILoaiSPRepository.Update(lsp))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
