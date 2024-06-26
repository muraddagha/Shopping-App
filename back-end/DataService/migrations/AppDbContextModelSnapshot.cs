﻿// <auto-generated />
using System;
using DataService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataService.migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataService.Data.Entities.About", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("DataService.Data.Entities.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DataService.Data.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<long?>("DepartmentId1")
                        .HasColumnType("bigint");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId1");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DataService.Data.Entities.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Info")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SettingsId")
                        .HasColumnType("int");

                    b.Property<long?>("SettingsId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId1");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DataService.Data.Entities.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DataService.Data.Entities.Offer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("DataService.Data.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<long?>("BrandId1")
                        .HasColumnType("bigint");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<long?>("CategoryId1")
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAviable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BrandId1");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Sku")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductOptionItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProductOptionId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductOptionId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductOptionId1");

                    b.ToTable("ProductOptionItems");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductPhotos", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("ProductPhotos");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductReview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.Property<double>("Star")
                        .HasColumnType("double");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.HasIndex("UserId1");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductSlider", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SettingsId")
                        .HasColumnType("int");

                    b.Property<long?>("SettingsId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Subtitle")
                        .HasColumnType("longtext");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId1");

                    b.ToTable("ProductSliders");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductSliderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductSliderId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductSliderId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.HasIndex("ProductSliderId1");

                    b.ToTable("ProductSliderItems");
                });

            modelBuilder.Entity("DataService.Data.Entities.Sale", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<double>("TotalSalePrice")
                        .HasColumnType("double");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DataService.Data.Entities.SaleItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<long?>("SaleId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.HasIndex("SaleId1");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("DataService.Data.Entities.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PrivacyPolicy")
                        .HasColumnType("longtext");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DataService.Data.Entities.Slider", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("ButtonId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<long?>("DepartmentId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Img")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Subtitle")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId1");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("DataService.Data.Entities.SocialLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Endpoint")
                        .HasColumnType("longtext");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SettingsId")
                        .HasColumnType("int");

                    b.Property<long?>("SettingsId1")
                        .HasColumnType("bigint");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId1");

                    b.ToTable("SocialLinks");
                });

            modelBuilder.Entity("DataService.Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CreateDate")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("ForgetPasswordToken")
                        .HasColumnType("longtext");

                    b.Property<string>("Fullname")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataService.Data.Entities.Category", b =>
                {
                    b.HasOne("DataService.Data.Entities.Department", "Department")
                        .WithMany("Categories")
                        .HasForeignKey("DepartmentId1");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DataService.Data.Entities.Contact", b =>
                {
                    b.HasOne("DataService.Data.Entities.Settings", "Settings")
                        .WithMany("Contacts")
                        .HasForeignKey("SettingsId1");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("DataService.Data.Entities.Product", b =>
                {
                    b.HasOne("DataService.Data.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId1");

                    b.HasOne("DataService.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId1");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductOption", b =>
                {
                    b.HasOne("DataService.Data.Entities.Product", "Product")
                        .WithMany("Options")
                        .HasForeignKey("ProductId1");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductOptionItem", b =>
                {
                    b.HasOne("DataService.Data.Entities.ProductOption", "ProductOption")
                        .WithMany("ProductOptionItems")
                        .HasForeignKey("ProductOptionId1");

                    b.Navigation("ProductOption");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductPhotos", b =>
                {
                    b.HasOne("DataService.Data.Entities.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId1");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductReview", b =>
                {
                    b.HasOne("DataService.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("DataService.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductSlider", b =>
                {
                    b.HasOne("DataService.Data.Entities.Settings", "Settings")
                        .WithMany("ProductSliders")
                        .HasForeignKey("SettingsId1");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductSliderItem", b =>
                {
                    b.HasOne("DataService.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("DataService.Data.Entities.ProductSlider", "ProductSlider")
                        .WithMany("Products")
                        .HasForeignKey("ProductSliderId1");

                    b.Navigation("Product");

                    b.Navigation("ProductSlider");
                });

            modelBuilder.Entity("DataService.Data.Entities.Sale", b =>
                {
                    b.HasOne("DataService.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataService.Data.Entities.SaleItem", b =>
                {
                    b.HasOne("DataService.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("DataService.Data.Entities.Sale", "Sale")
                        .WithMany("SaleItems")
                        .HasForeignKey("SaleId1");

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("DataService.Data.Entities.Slider", b =>
                {
                    b.HasOne("DataService.Data.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId1");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DataService.Data.Entities.SocialLink", b =>
                {
                    b.HasOne("DataService.Data.Entities.Settings", "Settings")
                        .WithMany("SocialLinks")
                        .HasForeignKey("SettingsId1");

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("DataService.Data.Entities.Department", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("DataService.Data.Entities.Product", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductOption", b =>
                {
                    b.Navigation("ProductOptionItems");
                });

            modelBuilder.Entity("DataService.Data.Entities.ProductSlider", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DataService.Data.Entities.Sale", b =>
                {
                    b.Navigation("SaleItems");
                });

            modelBuilder.Entity("DataService.Data.Entities.Settings", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("ProductSliders");

                    b.Navigation("SocialLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
