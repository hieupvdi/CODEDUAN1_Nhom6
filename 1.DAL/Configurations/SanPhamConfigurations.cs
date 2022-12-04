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
    internal class SanPhamConfigurations : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);

            builder.Property(k => k.IdLoaiSP).IsRequired();
            builder.Property(k => k.IdSize).IsRequired();
           // builder.Property(p => p.MaSP).HasColumnName("MaSP").
           //     HasColumnType("nvarchar(100)").IsRequired();
           // builder.Property(p => p.TenSP).HasColumnName("TenSP").
           //     HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
           // builder.Property(p => p.LinkAnh).HasColumnName("LinkAnh").
           //HasColumnType("nvarchar(100)").IsRequired(); // decimal not null
           // builder.Property(p => p.GiaBan).HasColumnName("GiaBan").
           //   HasColumnType("decimal").IsRequired(); // decimal not null

            //builder.Property(p => p.TrangThai).HasColumnName("Trangthai").
            //    HasColumnType("int").IsRequired();

            // Set khóa ngoại
            builder.HasOne(x => x.LoaiSP)
            .WithMany().HasForeignKey(p => p.IdLoaiSP);
            builder.HasOne(x => x.Size)
            .WithMany().HasForeignKey(p => p.IdSize);
        }
    }
}
