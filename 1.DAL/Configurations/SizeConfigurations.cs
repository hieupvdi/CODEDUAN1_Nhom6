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
    public class SizeConfigurations : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.ToTable("Size"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính

            //Cấu hình dữ liệu
            builder.Property(p => p.MaSize).HasColumnName("MaSize").
              HasColumnType("nvarchar(50)").IsRequired(); // nvarchar(100) not null
            builder.Property(p => p.TenSize).HasColumnName("TenSize").
                HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
           // builder.Property(p => p.Gia).HasColumnName("Gia").
                //HasColumnType("decimal").IsRequired();
            builder.Property(p => p.TrangThai).HasColumnName("TrangThai").
                HasColumnType("int").IsRequired();
        }
    }
}
