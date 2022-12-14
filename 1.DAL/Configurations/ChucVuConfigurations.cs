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
    internal class ChucVuConfigurations : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính

            // Cấu hình dữ liệu
            builder.Property(p => p.MaCV).HasColumnName("MaCV").
                HasColumnType("nvarchar(50)").IsRequired(); // nvarchar(50) not null
            builder.Property(p => p.TenCV).HasColumnName("TenCV").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
        }
    }
}
