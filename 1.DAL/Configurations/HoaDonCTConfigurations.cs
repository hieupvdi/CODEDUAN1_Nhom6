using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal class HoaDonCTConfigurations : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.ToTable("HoaDonCT"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.Property(k => k.IdSP).IsRequired();
            builder.Property(k => k.IdHD).IsRequired();


            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").
               HasColumnType("int").IsRequired();
            builder.Property(p => p.DonGia).HasColumnName("DonGia").
              HasColumnType("decimal").IsRequired();

            //Sset khóa chính
            builder.HasKey(x => new { x.IdSP, x.IdHD }); // Set khóa chính
            // Set khóa ngoại
            builder.HasOne(x => x.SanPham)
            .WithMany().HasForeignKey(p => p.IdSP);
            builder.HasOne(x => x.HoaDon)
            .WithMany().HasForeignKey(p => p.IdHD);
        }
    }
}
