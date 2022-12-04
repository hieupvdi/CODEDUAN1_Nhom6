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
    internal class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính
                                       // Cấu hình dữ liệu
            //builder.Property(p => p.MaKH).HasColumnName("MaKH").
            //  HasColumnType("nvarchar(100)").IsRequired();
            //builder.Property(p => p.TenKH).HasColumnName("TenKH").
            //    HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            //builder.Property(p => p.SDT).HasColumnName("SDT").
            //   HasColumnType("nvarchar(20)").IsRequired();
            //builder.Property(p => p.DiaChi).HasColumnName("DiaChi").
            //   HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
