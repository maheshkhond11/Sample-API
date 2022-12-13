﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.DBContext;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221212151227_updatedstructure2")]
    partial class updatedstructure2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.DBContext.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.DBContext.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Models.DBContext.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<double>("PhoneDiscount")
                        .HasColumnType("float");

                    b.Property<string>("PhoneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PhonePrice")
                        .HasColumnType("float");

                    b.HasKey("PhoneId");

                    b.HasIndex("BrandId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Models.DBContext.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"), 1L, 1);

                    b.Property<double>("FinalPrice")
                        .HasColumnType("float");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PhoneId")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SoldDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RecordId");

                    b.HasIndex("Id");

                    b.HasIndex("PhoneId");

                    b.HasIndex("SaleId");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("Models.DBContext.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"), 1L, 1);

                    b.Property<string>("SaleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalDiscount")
                        .HasColumnType("float");

                    b.HasKey("SaleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Models.DBContext.Phone", b =>
                {
                    b.HasOne("Models.DBContext.Brand", "Brand")
                        .WithMany("Phones")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Models.DBContext.Record", b =>
                {
                    b.HasOne("Models.DBContext.AppUser", "AppUser")
                        .WithMany("Record")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.DBContext.Phone", "Phone")
                        .WithMany("Record")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.DBContext.Sale", "Sale")
                        .WithMany("Record")
                        .HasForeignKey("SaleId");

                    b.Navigation("AppUser");

                    b.Navigation("Phone");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Models.DBContext.AppUser", b =>
                {
                    b.Navigation("Record");
                });

            modelBuilder.Entity("Models.DBContext.Brand", b =>
                {
                    b.Navigation("Phones");
                });

            modelBuilder.Entity("Models.DBContext.Phone", b =>
                {
                    b.Navigation("Record");
                });

            modelBuilder.Entity("Models.DBContext.Sale", b =>
                {
                    b.Navigation("Record");
                });
#pragma warning restore 612, 618
        }
    }
}