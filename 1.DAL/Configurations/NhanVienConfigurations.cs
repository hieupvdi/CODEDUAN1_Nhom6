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
    internal class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id);
        
            builder.Property(k => k.IdCV).IsRequired();


            builder.Property(p => p.MaNV).HasColumnName("MaNV").
               HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.TenNV).HasColumnName("TenNV").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.LinkAnh).HasColumnName("LinkAnh").
                HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnName("GioiTinh").
                HasColumnType("nvarchar(20)").IsRequired(); // nvarchar(100) not null
            //builder.Property(p => p.NgaySinh).HasColumnName("NgaySinh").
            //    HasColumnType("Datetime").IsRequired();
            builder.Property(p => p.Email).HasColumnName("Email").
                HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT").
                HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").
               HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.MatKhau).HasColumnName("MatKhau").
                HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.Trangthai).HasColumnName("Trangthai").
                HasColumnType("int").IsRequired();


            // Set khóa ngoại
            builder.HasOne(x => x.ChucVu)
            .WithMany().HasForeignKey(p => p.IdCV);
          
        }
    }
}
