﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240316184754_AddForeignKeyToVillaTable")]
    partial class AddForeignKeyToVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 3, 16, 23, 47, 54, 664, DateTimeKind.Local).AddTicks(2075),
                            Details = "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 3, 16, 23, 47, 54, 664, DateTimeKind.Local).AddTicks(2088),
                            Details = "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                            ImageUrl = "",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 3, 16, 23, 47, 54, 664, DateTimeKind.Local).AddTicks(2090),
                            Details = "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                            ImageUrl = "",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany("VillaNumbers")
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Navigation("VillaNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
