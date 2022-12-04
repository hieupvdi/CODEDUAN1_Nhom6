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
    public class QLNhanVienServices : IQLNhanVienServices
    {
        private INhanVienRepository _INhanVienRepository;
        private IChucVuRepository _IChucVuRepository;
        public QLNhanVienServices()
        {
            _INhanVienRepository=new NhanVienRepository();
            _IChucVuRepository=new ChucVuRepository();
        }
        public string Add(QLNhanVienView obj)
        {
            if (obj == null)
                return "Them that bai";
            var NV = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                MaNV = obj.MaNV,
                TenNV = obj.TenNV,
                LinkAnh=obj.LinkAnh,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                Email = obj.Email,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                MatKhau = obj.MatKhau,
                Trangthai = obj.Trangthai,
                
            
            };
            if (_INhanVienRepository.Add(NV))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(QLNhanVienView obj)
        {
            if (obj == null) return "Xoa that bai";
            var NV = _INhanVienRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_INhanVienRepository.Delete(NV))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<QLNhanVienView> GetAll()
        {
            List<QLNhanVienView> lst = new List<QLNhanVienView>();
            lst =
                (
                from a in _INhanVienRepository.GetAll()
                join b in _IChucVuRepository.GetAll() on a.IdCV equals b.Id
                select new QLNhanVienView()
                {
                    Id = a.Id,
                    IdCV = a.IdCV,
                    MaNV = a.MaNV,
                    TenNV = a.TenNV,
                    LinkAnh = a.LinkAnh,
                    GioiTinh = a.GioiTinh,
                    NgaySinh = (DateTime)a.NgaySinh,
                    Email = a.Email,
                    SDT = a.SDT,
                    DiaChi = a.DiaChi,
                    MatKhau = a.MatKhau,
                    Trangthai = a.Trangthai,
                    //Chức Vụ
                    //IdCV=b.Id,
                    MaCV = b.MaCV,
                    TenCV=b.TenCV,


                }
                ).ToList();
            return lst;
        }

        public List<QLNhanVienView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaNV.ToLower().StartsWith(input.ToLower()) || c.TenNV.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public NhanVien GetById(int id)
        {
            return _INhanVienRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public int GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenNV == name).Id;
        }

        public string Update(QLNhanVienView obj)
        {
            if (obj == null) return "Sua that bai";
            var NV = _INhanVienRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            NV.Id = obj.Id;
            NV.IdCV = obj.IdCV;
            NV.MaNV = obj.MaNV;
            NV.TenNV = obj.TenNV;
            NV.LinkAnh = obj.LinkAnh;
            NV.GioiTinh = obj.GioiTinh;
            NV.NgaySinh = obj.NgaySinh;
            NV.Email = obj.Email;
            NV.SDT = obj.SDT;
            NV.DiaChi = obj.DiaChi;
            NV.MatKhau = obj.MatKhau;
            NV.Trangthai = obj.Trangthai;
            if (_INhanVienRepository.Update(NV))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
