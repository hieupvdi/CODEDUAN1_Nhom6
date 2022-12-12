using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class AddData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>().HasData(
             new ChucVu() { Id = Guid.Parse("e26fa84e-3019-4a14-862f-9fafc6014dfe"), MaCV = "CV1", TenCV = "Nhân Viên" }

             );
            modelBuilder.Entity<LoaiSP>().HasData(
             new LoaiSP() { Id = Guid.Parse("222265ab-a78d-435e-af41-d0e61033ede1"), MaLoaiSP = "LSP1", TenLoaiSP = "CAPE" }

            );
            modelBuilder.Entity<Size>().HasData(
             new Size() { Id = Guid.Parse("98917e72-9634-401d-b5f4-6a30b1741b82"), MaSize = "S1", TenSize = "Size Lớn" }

            );
            modelBuilder.Entity<KhachHang>().HasData(
             new KhachHang() { Id = Guid.Parse("6e735591-ec79-4cf9-bc37-c376a498aa30"), MaKH = "KH1", TenKH = "Đức Hải", SDT = "0337019932", DiaChi = "Thanh Hóa" }


             );
            modelBuilder.Entity<NhanVien>().HasData(
          new NhanVien() { Id = Guid.Parse("16819dd5-fbe9-404e-8940-0f2816ec533c"), IdCV = Guid.Parse("e26fa84e-3019-4a14-862f-9fafc6014dfe"), MaNV = "NV1", TenNV = "Lê Minh Thanh", LinkAnh = @"C:\Users\hieup\OneDrive\Máy tính\DU_AN_1\icon\c2437ba9152ab9a7_ec2594949c8901fa_9972415113439532143215.jpg", GioiTinh = "Nam", NgaySinh = DateTime.Now, Email = "hieuphamvan.dev.it@gmail.com", SDT = "0337019932", DiaChi = "Thanh Hóa", MatKhau = "123", Trangthai = 0 }
          );

        }
    }
}
