﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20181121173537_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DAL.Model.ChildrenProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ColorId");

                    b.Property<int?>("EgresosId");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("EgresosId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ChildrenProducts");
                });

            modelBuilder.Entity("DAL.Model.Colors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DAL.Model.Egresos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Egresos");
                });

            modelBuilder.Entity("DAL.Model.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DAL.Model.Sizes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("DAL.Model.ChildrenProducts", b =>
                {
                    b.HasOne("DAL.Model.Colors", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("DAL.Model.Egresos")
                        .WithMany("ChildrenProducts")
                        .HasForeignKey("EgresosId");

                    b.HasOne("DAL.Model.Products", "Product")
                        .WithMany("ChildrenProduct")
                        .HasForeignKey("ProductId");

                    b.HasOne("DAL.Model.Sizes", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");
                });
#pragma warning restore 612, 618
        }
    }
}
