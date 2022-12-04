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
    internal class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id);
            //builder.Property(p => p.MaHD).HasColumnName("MaHD").
            //    HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(k => k.IdNV).IsRequired();
            builder.Property(k => k.IdKH).IsRequired();

          //  builder.Property(p => p.ThoiGianTao).HasColumnName("ThoiGianTao").
          //    HasColumnType("Datetime").IsRequired(); // Datetime not null

          //  builder.Property(p => p.ThoiGianThanhToan).HasColumnName("ThoiGianThanhToan").
          //    HasColumnType("Datetime").IsRequired(); // Datetime not null
          //  builder.Property(p => p.SDT).HasColumnName("SDT").
          //    HasColumnType("nvarchar(20)").IsRequired();
          //  builder.Property(p => p.DiaChi).HasColumnName("DiaChi").
          //    HasColumnType("nvarchar(100)").IsRequired();
          //  builder.Property(p => p.TongTien).HasColumnName("TongTien").
          //HasColumnType("decimal").IsRequired();
          //  builder.Property(p => p.TrangThai).HasColumnName("TrangThai").
          //    HasColumnType("int").IsRequired();

            // Set khóa ngoại
            builder.HasOne(x => x.NhanVien)
            .WithMany().HasForeignKey(p => p.IdNV);
            builder.HasOne(x => x.KhachHang)
            .WithMany().HasForeignKey(p => p.IdKH);
        }
    }
}
