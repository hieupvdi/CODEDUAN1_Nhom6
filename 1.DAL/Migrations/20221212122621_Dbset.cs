using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class Dbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiSP = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal", nullable: false),
                    Trangthai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_IdLoaiSP",
                        column: x => x.IdLoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => new { x.IdSP, x.IdHD });
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaCV", "TenCV" },
                values: new object[] { new Guid("e26fa84e-3019-4a14-862f-9fafc6014dfe"), "CV1", "Nhân Viên" });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "MaKH", "SDT", "TenKH" },
                values: new object[] { new Guid("6e735591-ec79-4cf9-bc37-c376a498aa30"), "Thanh Hóa", "KH1", "0337019932", "Đức Hải" });

            migrationBuilder.InsertData(
                table: "LoaiSP",
                columns: new[] { "Id", "MaLoaiSP", "TenLoaiSP" },
                values: new object[] { new Guid("222265ab-a78d-435e-af41-d0e61033ede1"), "LSP1", "CAPE" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "TenSize", "TrangThai" },
                values: new object[] { new Guid("98917e72-9634-401d-b5f4-6a30b1741b82"), "S1", "Size Lớn", 0 });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdCV", "LinkAnh", "MaNV", "MatKhau", "NgaySinh", "SDT", "TenNV", "Trangthai" },
                values: new object[] { new Guid("16819dd5-fbe9-404e-8940-0f2816ec533c"), "Thanh Hóa", "hieuphamvan.dev.it@gmail.com", "Nam", new Guid("e26fa84e-3019-4a14-862f-9fafc6014dfe"), "C:\\Users\\hieup\\OneDrive\\Máy tính\\DU_AN_1\\icon\\c2437ba9152ab9a7_ec2594949c8901fa_9972415113439532143215.jpg", "NV1", "123", new DateTime(2022, 12, 12, 19, 26, 21, 298, DateTimeKind.Local).AddTicks(5355), "0337019932", "Lê Minh Thanh", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_IdHD",
                table: "HoaDonCT",
                column: "IdHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdLoaiSP",
                table: "SanPham",
                column: "IdLoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdSize",
                table: "SanPham",
                column: "IdSize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
