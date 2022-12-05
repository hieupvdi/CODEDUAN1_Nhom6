using _1.DAL.Configurations;
using _1.DAL.Extensions;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class QLDbContext : DbContext
    {
  
        public QLDbContext()
        {

        }
        public QLDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<Size> Sizes { get; set; }   
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
                // Thực hiện các ràng buộc kết nối
                base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-CNC5A0H\\SQLEXPRESS;Initial Catalog=DuAn1_Nhom6;Persist Security Info=True;User ID=hungphph27359;Password=240803"));
                //Data Source=HIEUPHAMVAN\SQLEXPRESS;Initial Catalog=DUAN1;Persist Security Info=True;User ID=hieupvph27565;Password=hieupvph27565"
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //apply cho từng class
        
            modelBuilder.ApplyConfiguration(new ChucVuConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonCTConfigurations());
            modelBuilder.ApplyConfiguration(new KhachHangConfigurations());
            modelBuilder.ApplyConfiguration(new LoaiSPConfigurations());
            modelBuilder.ApplyConfiguration(new NhanVienConfigurations());
            modelBuilder.ApplyConfiguration(new SanPhamConfigurations());
            modelBuilder.ApplyConfiguration(new SizeConfigurations());

            // dùng để áp dữ liệu từ thư mục Extensions đang lỗi
            modelBuilder.Seed();

            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
