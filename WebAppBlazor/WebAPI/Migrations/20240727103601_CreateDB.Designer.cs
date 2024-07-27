﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppBlazor.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240727103601_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppBlazor.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDRole")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDRole");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Bill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("IDThanhToan")
                        .HasColumnType("int");

                    b.Property<int>("IDVanChuyen")
                        .HasColumnType("int");

                    b.Property<string>("NgayDatHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDThanhToan");

                    b.HasIndex("IDVanChuyen");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("WebAppBlazor.Models.BillDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHoaDon");

                    b.HasIndex("IDSanPham");

                    b.ToTable("BillDetail");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebAppBlazor.Models.CategoryType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDDanhMuc")
                        .HasColumnType("int");

                    b.Property<string>("TenLoaiDanhMuc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDDanhMuc");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Favourite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDSanPham");

                    b.ToTable("Favourite");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<int>("IDLoaiDM")
                        .HasColumnType("int");

                    b.Property<string>("KichThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTrongKho")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDLoaiDM");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.ProductImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDSanPham");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Reviews", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DanhGia")
                        .HasColumnType("float");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("IDTaiKhoan")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDSanPham");

                    b.HasIndex("IDTaiKhoan");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Shipping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhuongThucVanChuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Voucher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DieuKienGiamGia")
                        .HasColumnType("float");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDDanhMuc")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<string>("LoaiVoucher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<double>("PhanTramGiamGia")
                        .HasColumnType("float");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenVoucher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDDanhMuc");

                    b.HasIndex("IDSanPham");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Account", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Role", "Role")
                        .WithMany("Account")
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Bill", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Account", "Account")
                        .WithMany("Bill")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Payment", "Payment")
                        .WithMany("Bill")
                        .HasForeignKey("IDThanhToan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Shipping", "Shipping")
                        .WithMany("Bill")
                        .HasForeignKey("IDVanChuyen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Payment");

                    b.Navigation("Shipping");
                });

            modelBuilder.Entity("WebAppBlazor.Models.BillDetail", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Bill", "Bill")
                        .WithMany("BillDetail")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Product", "Product")
                        .WithMany("BillDetail")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.CategoryType", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Category", "Category")
                        .WithMany("CategoryType")
                        .HasForeignKey("IDDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Favourite", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Account", "Account")
                        .WithMany("Favourite")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Product", "Product")
                        .WithMany("Favourite")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Product", b =>
                {
                    b.HasOne("WebAppBlazor.Models.CategoryType", "CategoryType")
                        .WithMany("Product")
                        .HasForeignKey("IDLoaiDM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryType");
                });

            modelBuilder.Entity("WebAppBlazor.Models.ProductImage", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Product", "Product")
                        .WithMany("ProductImage")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Reviews", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Account", "Account")
                        .WithMany("Reviews")
                        .HasForeignKey("IDTaiKhoan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Voucher", b =>
                {
                    b.HasOne("WebAppBlazor.Models.Category", "Category")
                        .WithMany("Voucher")
                        .HasForeignKey("IDDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppBlazor.Models.Product", "Product")
                        .WithMany("Voucher")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Account", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("Favourite");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Bill", b =>
                {
                    b.Navigation("BillDetail");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Category", b =>
                {
                    b.Navigation("CategoryType");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("WebAppBlazor.Models.CategoryType", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Payment", b =>
                {
                    b.Navigation("Bill");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Product", b =>
                {
                    b.Navigation("BillDetail");

                    b.Navigation("Favourite");

                    b.Navigation("ProductImage");

                    b.Navigation("Reviews");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Role", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("WebAppBlazor.Models.Shipping", b =>
                {
                    b.Navigation("Bill");
                });
#pragma warning restore 612, 618
        }
    }
}
