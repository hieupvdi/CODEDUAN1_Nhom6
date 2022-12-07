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
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonRepository _IHoaDonRepository;
        private INhanVienRepository _INhanVienRepository;
        private IKhachHangRepository _IKhachHangRepository;
     
        public HoaDonServices()
        {
            _IHoaDonRepository=new HoaDonRepository();
            _INhanVienRepository = new NhanVienRepository();
            _IKhachHangRepository=new KhachHangRepository();
       
        }
        public string Add(HoaDonView obj)
        {
            if (obj == null)
            return "Them that bai";
            var HD = new HoaDon()
            {
                Id = obj.Id,
                IdNV = obj.IdNV,
                IdKH = obj.IdKH,
                MaHD = obj.MaHD,
                ThoiGianTao = obj.ThoiGianTao,
                ThoiGianThanhToan = obj.ThoiGianThanhToan,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                TongTien = obj.TongTien,
                TrangThai = obj.TrangThai,

            };
            if (_IHoaDonRepository.Add(HD))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(HoaDonView obj)
        {
            if (obj == null) return "Xoa that bai";
            var HD = _IHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_IHoaDonRepository.Delete(HD))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<HoaDonView> GetAll()
        {
            List<HoaDonView> lst = new List<HoaDonView>();
            lst =
                (
                from a in _IHoaDonRepository.GetAll()
                join b in _INhanVienRepository.GetAll() on a.IdNV equals b.Id
                join c in _IKhachHangRepository.GetAll() on a.IdKH equals c.Id
           
                select new HoaDonView()
                {

                    Id = a.Id,
                    IdNV = a.IdNV,
                    IdKH = a.IdKH,
                    MaHD = a.MaHD,
                    ThoiGianTao = a.ThoiGianTao,
                    ThoiGianThanhToan = a.ThoiGianThanhToan,
                    SDT = a.SDT,
                    DiaChi = a.DiaChi,
                    TongTien=a.TongTien,
                    TrangThai = a.TrangThai,
                    //nhân viên
                    IdCV=b.IdCV,
                    MaNV=b.MaNV,
                    TenNV=b.TenNV,
                    LinkAnh = b.LinkAnh,
                    GioiTinh=b.GioiTinh,
                    NgaySinh=b.NgaySinh,
                    Email=b.Email,
                    SDTNV=b.SDT,
                    DiaChiNV=b.DiaChi,
                    MatKhau=b.MatKhau,
                    TrangthaiNV=b.Trangthai,

                    //khách Hàng
                    MaKH=c.MaKH,
                    TenKH=c.TenKH,
                    SDTKH=c.SDT,
                    DiaChiKH=c.DiaChi,
                    //Phục Vụ Chức Năng Bán Hàng ---tester---
                    


                }
                ).ToList();
            return lst;
        }

        public List<HoaDonView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaHD.ToLower().StartsWith(input.ToLower()) || c.TenKH.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public HoaDon GetById(Guid id)
        {
            return _IHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenKH == name).Id;
        }

        public string Update(HoaDonView obj)
        {
            if (obj == null) return "Sua that bai";
            var HD = _IHoaDonRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

          
            HD.IdNV = obj.IdNV;
            HD.IdKH = obj.IdKH;
            HD.MaHD = obj.MaHD;
            HD.ThoiGianTao = obj.ThoiGianTao;
            HD.ThoiGianThanhToan = obj.ThoiGianThanhToan;
            HD.SDT = obj.SDT;
            HD.DiaChi = obj.DiaChi;
            HD.TongTien = obj.TongTien;
            HD.TrangThai = obj.TrangThai;

            if (_IHoaDonRepository.Update(HD))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
