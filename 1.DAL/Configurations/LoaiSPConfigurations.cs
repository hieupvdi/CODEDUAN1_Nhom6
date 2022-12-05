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
    internal class LoaiSPConfigurations : IEntityTypeConfiguration<LoaiSP>
    {
        public void Configure(EntityTypeBuilder<LoaiSP> builder)
        {
            builder.ToTable("LoaiSP"); // Đặt tên bảng (Nếu ko thì lấy mặc định của class)
            builder.HasKey(x => x.Id); // Set khóa chính
 
            // Cấu hình dữ liệu
            //builder.Property(p => p.MaLoaiSP).HasColumnName("MaLoaiSP").
            //  HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
            //builder.Property(p => p.TenLoaiSP).HasColumnName("TenLoaiSP").
            //    HasColumnType("nvarchar(100)").IsRequired(); // nvarchar(100) not null
        }
    }
}
