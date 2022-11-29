﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(QLDbContext))]
    partial class QLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaCV");

                    b.Property<string>("TenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenCV");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiaChi");

                    b.Property<Guid?>("IdKH")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaHD");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("SDT");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("Datetime")
                        .HasColumnName("ThoiGianTao");

                    b.Property<DateTime>("ThoiGianThanhToan")
                        .HasColumnType("Datetime")
                        .HasColumnName("ThoiGianThanhToan");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdKH");

                    b.HasIndex("IdNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal")
                        .HasColumnName("DonGia");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("IdSP", "IdHD");

                    b.HasIndex("IdHD");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("DiaChi");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaKH");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenKH");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiSP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaLoaiSP");

                    b.Property<string>("TenLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenLoaiSP");

                    b.HasKey("Id");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("IdCV")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkAnh")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("Datetime");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenNV")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Trangthai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal")
                        .HasColumnName("GiaBan");

                    b.Property<Guid?>("IdLoaiSP")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSize")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LinkAnh");

                    b.Property<string>("MaSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaSP");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSP");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("Trangthai");

                    b.HasKey("Id");

                    b.HasIndex("IdLoaiSP");

                    b.HasIndex("IdSize");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal")
                        .HasColumnName("Gia");

                    b.Property<string>("MaSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaSize");

                    b.Property<string>("TenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenSize");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonCT", b =>
                {
                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IdCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.HasOne("_1.DAL.Models.LoaiSP", "LoaiSP")
                        .WithMany()
                        .HasForeignKey("IdLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("IdSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSP");

                    b.Navigation("Size");
                });
#pragma warning restore 612, 618
        }
    }
}
