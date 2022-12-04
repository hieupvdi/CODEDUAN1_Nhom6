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
    public class HoaDonCTServices : IHoaDonCTServices
    {
        private IHoaDonCTRepository _IHoaDonCTRepository;
        private IHoaDonRepository _IHoaDonRepository;
        private ISanPhamRepository _ISanPhamRepository;
       // private ILoaiSPRepository _ILoaiSPRepository;
        public HoaDonCTServices()
        {
            _IHoaDonCTRepository= new HoaDonCTRepository();
            _IHoaDonRepository = new HoaDonRepository();
            _ISanPhamRepository = new SanPhamRepository();
            //_ILoaiSPRepository = new LoaiSPRepository();
        }
        public string Add(HoaDonCTView obj)
        {
            if (obj == null)
                return "Them that bai";
            var HDCT = new HoaDonCT()
            {
                IdHD = obj.IdHD,
                IdSP = obj.IdSP,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,

            };
            if (_IHoaDonCTRepository.Add(HDCT))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(HoaDonCTView obj)
        {
            if (obj == null) return "Xoa that bai";
            var HDCT = _IHoaDonCTRepository.GetAll().FirstOrDefault(c => c.IdSP == obj.IdSP);

            if (_IHoaDonCTRepository.Delete(HDCT))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<HoaDonCTView> GetAll()
        {
            List<HoaDonCTView> lst = new List<HoaDonCTView>();
            lst =
                (
                from a in _IHoaDonCTRepository.GetAll()
                join b in _IHoaDonRepository.GetAll() on a.IdHD equals b.Id
                join c in _ISanPhamRepository.GetAll() on a.IdSP equals c.Id
                //join d in _ILoaiSPRepository.GetAll() on c.IdLoaiSP equals d.Id
                select new HoaDonCTView()
                {

                    //IdHD = a.IdHD,
                    IdSP = a.IdSP,
                    SoLuong = a.SoLuong,
                    DonGia = a.DonGia,
                    //Hóa Đơn
                    // Id = a.Id,
                    IdNV = b.IdNV,
                    IdKH = b.IdKH,
                    MaHD = b.MaHD,
                    ThoiGianTao = b.ThoiGianTao,
                    ThoiGianThanhToan = b.ThoiGianThanhToan,
                    SDT = b.SDT,
                    DiaChi = b.DiaChi,
                    TrangThai = b.TrangThai,

                    // Sản Phẩm
                    //Id = a.Id,                
                    IdLoaiSP = c.IdLoaiSP,
                    IdSize = c.IdSize,
                    MaSP = c.MaSP,
                    TenSP = c.TenSP,
                    LinkAnh = c.LinkAnh,
                    GiaBan = c.GiaBan,
                    TrangThaiSP = c.TrangThai,

                }
                ).ToList();
            return lst;
        }

        public List<HoaDonCTView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.MaSP.ToLower().StartsWith(input.ToLower()) || c.TenSP.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public HoaDonCT GetById(int id)
        {
            return _IHoaDonCTRepository.GetAll().FirstOrDefault(c => c.IdSP == id);
        }

        public int GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.TenSP == name).IdSP;
        }

        public string Update(HoaDonCTView obj)
        {
            if (obj == null) return "Sua that bai";
            var HDCT = _IHoaDonCTRepository.GetAll().FirstOrDefault(c => c.IdSP == obj.IdSP);

            HDCT.IdHD = obj.IdHD;
           // HDCT.IdSP = obj.IdSP;
            HDCT.SoLuong = obj.SoLuong;
            HDCT.DonGia = obj.DonGia;

            if (_IHoaDonCTRepository.Update(HDCT))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
