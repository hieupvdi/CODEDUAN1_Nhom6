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
             new ChucVu() { Id = Guid.Parse("25E391AC-7AA5-42AC-B254-554DA2AC3208"), MaCV = "CV1" , TenCV = "Anh nhân viên May Mắn" }
           
             );
            modelBuilder.Entity<LoaiSP>().HasData(
             new LoaiSP() { Id = Guid.Parse("35E391AC-7AA5-42AC-B254-554DA2AC3208"), MaLoaiSP = "LSP1", TenLoaiSP = "CAPE" }
          
            );
            modelBuilder.Entity<Size>().HasData(
             new Size() { Id = Guid.Parse("45E391AC-7AA5-42AC-B254-554DA2AC3208"), MaSize = "S1", TenSize = "Size Lớn" }
          
            );
            modelBuilder.Entity<KhachHang>().HasData(
             new KhachHang() { Id = Guid.Parse("55E391AC-7AA5-42AC-B254-554DA2AC3208"), MaKH = "KH1", TenKH = "hiếu", SDT="0337019932", DiaChi="Thanh Hóa" }
           
        );
        }
    }
}
