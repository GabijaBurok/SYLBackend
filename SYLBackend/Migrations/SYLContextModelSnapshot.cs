﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SYLBackend.Context;

namespace SYLBackend.Migrations
{
    [DbContext(typeof(SYLContext))]
    partial class SYLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SYLBackend.Models.Orders", b =>
                {
                    b.Property<string>("orderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("customerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("quantity")
                        .HasColumnType("real");

                    b.Property<TimeSpan>("timeStamp")
                        .HasColumnType("time");

                    b.HasKey("orderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SYLBackend.Models.Products", b =>
                {
                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("productPrice")
                        .HasColumnType("real");

                    b.Property<int>("productType")
                        .HasColumnType("int");

                    b.Property<string>("shopId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SYLBackend.Models.Reviews", b =>
                {
                    b.Property<string>("reviewId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("customerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reviewComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("reviewRating")
                        .HasColumnType("int");

                    b.Property<string>("shopId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SYLBackend.Models.Shops", b =>
                {
                    b.Property<string>("shopId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("sellerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shopPicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("shopId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("SYLBackend.Models.Users", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userType")
                        .HasColumnType("int");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
