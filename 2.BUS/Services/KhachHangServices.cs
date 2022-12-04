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
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangRepository _IKhachHangRepository;
        public KhachHangServices()
        {
            _IKhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHangView obj)
        {
            if (obj == null)
                return "Them that bai";
            var KH = new KhachHang()
            {
                Id = obj.Id,
                MaKH = obj.MaKH,
                TenKH = obj.TenKH,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi

            };
            if (_IKhachHangRepository.Add(KH))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(KhachHangView obj)
        {

            if (obj == null) return "Xoa that bai";
            var KH = _IKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_IKhachHangRepository.Delete(KH))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst =
                (
                from a in _IKhachHangRepository.GetAll()
                select new KhachHangView()
                {
                    Id = a.Id,
                    MaKH = a.MaKH,
                    TenKH = a.TenKH,
                    SDT = a.SDT,
                    DiaChi = a.DiaChi
                }
                ).ToList();
            return lst;
        }

        public List<KhachHangView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaKH.ToLower().StartsWith(input.ToLower()) || c.TenKH.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public KhachHang GetById(int id)
        {
            return _IKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public int GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.MaKH == name).Id;
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "Sua that bai";
            var KH = _IKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            KH.MaKH = obj.MaKH;
            KH.TenKH = obj.TenKH;
            KH.SDT = obj.SDT;
            KH.DiaChi = obj.DiaChi;
            if (_IKhachHangRepository.Update(KH))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
