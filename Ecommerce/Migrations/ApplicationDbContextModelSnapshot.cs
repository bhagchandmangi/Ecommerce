﻿// <auto-generated />
using System;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookCoverId")
                        .HasColumnType("int");

                    b.Property<string>("BookUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookWriterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBNNUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookCoverId");

                    b.HasIndex("BookWriterId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Ecommerce.Models.BookCover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookWriterId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookWriterId");

                    b.ToTable("BookCovers");
                });

            modelBuilder.Entity("Ecommerce.Models.BookWriter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("Ecommerce.Models.Book", b =>
                {
                    b.HasOne("Ecommerce.Models.BookCover", "BookCover")
                        .WithMany("Books")
                        .HasForeignKey("BookCoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Models.BookWriter", "BookWriter")
                        .WithMany("Books")
                        .HasForeignKey("BookWriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCover");

                    b.Navigation("BookWriter");
                });

            modelBuilder.Entity("Ecommerce.Models.BookCover", b =>
                {
                    b.HasOne("Ecommerce.Models.BookWriter", null)
                        .WithMany("BookCovers")
                        .HasForeignKey("BookWriterId");
                });

            modelBuilder.Entity("Ecommerce.Models.BookCover", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Ecommerce.Models.BookWriter", b =>
                {
                    b.Navigation("BookCovers");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
