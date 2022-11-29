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
             new ChucVu() { Id = Guid.NewGuid(), MaCV = "CV1" , TenCV = "Anh nhân viên May Mắn" }
           
             );
            modelBuilder.Entity<LoaiSP>().HasData(
             new LoaiSP() { Id = Guid.NewGuid(), MaLoaiSP = "LSP1", TenLoaiSP = "CAPE" }
          
            );
            modelBuilder.Entity<Size>().HasData(
             new Size() { Id = Guid.NewGuid(), MaSize = "S1", TenSize = "Size Lớn" }
          
            );
            modelBuilder.Entity<KhachHang>().HasData(
             new KhachHang() { Id = Guid.NewGuid(), MaKH = "KH1", TenKH = "hiếu", SDT="0337019932", DiaChi="Thanh Hóa" }
           
        );
        }
    }
}
