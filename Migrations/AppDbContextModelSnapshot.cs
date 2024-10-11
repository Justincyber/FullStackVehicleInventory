﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VehicleInventoryProj.Models;

#nullable disable

namespace VehicleInventoryProj.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VehicleInventoryProj.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("color");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ColorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("ColorId");

                    b.ToTable("colors", (string)null);

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            Name = "Midnight Black"
                        },
                        new
                        {
                            ColorId = 2,
                            Name = "Ruby Flare Pearl"
                        },
                        new
                        {
                            ColorId = 3,
                            Name = "Blueprint"
                        },
                        new
                        {
                            ColorId = 4,
                            Name = "Cypress"
                        },
                        new
                        {
                            ColorId = 5,
                            Name = "Magentic Gray"
                        },
                        new
                        {
                            ColorId = 6,
                            Name = "Wind Chill Pearl"
                        });
                });

            modelBuilder.Entity("VehicleInventoryProj.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("vehicle_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VehicleId"));

                    b.Property<string>("Build")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("build");

                    b.Property<int?>("CityMPG")
                        .HasColumnType("integer")
                        .HasColumnName("city_mpg");

                    b.Property<int?>("ColorId")
                        .HasColumnType("integer")
                        .HasColumnName("color_id");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("fuel_type");

                    b.Property<int?>("HwyMPG")
                        .HasColumnType("integer")
                        .HasColumnName("hwy_mpg");

                    b.Property<string>("ImgPath")
                        .HasColumnType("text")
                        .HasColumnName("img_path");

                    b.Property<bool>("InStock")
                        .HasColumnType("boolean")
                        .HasColumnName("in_stock");

                    b.Property<int>("MSRP")
                        .HasColumnType("integer")
                        .HasColumnName("msrp");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasColumnName("make");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("model");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("VehicleId");

                    b.HasIndex("ColorId");

                    b.ToTable("vehicles", (string)null);

                    b.HasData(
                        new
                        {
                            VehicleId = 1,
                            Build = "Sedan",
                            CityMPG = 32,
                            ColorId = 1,
                            FuelType = "Gas",
                            HwyMPG = 41,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2025/corolla/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 22175,
                            Make = "Toyota",
                            Model = "Corolla",
                            Year = 2025
                        },
                        new
                        {
                            VehicleId = 2,
                            Build = "Truck",
                            CityMPG = 21,
                            ColorId = 2,
                            FuelType = "Gas",
                            HwyMPG = 26,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/tacoma/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 31500,
                            Make = "Toyota",
                            Model = "Tacoma",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 3,
                            Build = "Sedan",
                            CityMPG = 57,
                            ColorId = 3,
                            FuelType = "Hybrid",
                            HwyMPG = 56,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/prius/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = false,
                            MSRP = 27950,
                            Make = "Toyota",
                            Model = "Prius",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 4,
                            Build = "Truck",
                            CityMPG = 18,
                            ColorId = 4,
                            FuelType = "Gas",
                            HwyMPG = 23,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/tundra/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = false,
                            MSRP = 40090,
                            Make = "Toyota",
                            Model = "Tundra",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 5,
                            Build = "SUV",
                            CityMPG = 36,
                            ColorId = 6,
                            FuelType = "Hyrbid",
                            HwyMPG = 35,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/highlanderhybrid/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 40970,
                            Make = "Toyota",
                            Model = "Highlander Hybrid",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 6,
                            Build = "SUV",
                            ColorId = 3,
                            FuelType = "Electric",
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/bz4x/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 43070,
                            Make = "Toyota",
                            Model = "bZ4X",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 7,
                            Build = "Sedan",
                            CityMPG = 20,
                            ColorId = 1,
                            FuelType = "Gas",
                            HwyMPG = 26,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/gr86/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 29300,
                            Make = "Toyota",
                            Model = "GR86",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 8,
                            Build = "Sedan",
                            CityMPG = 23,
                            ColorId = 3,
                            FuelType = "Gas",
                            HwyMPG = 31,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2025/grsupra/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = false,
                            MSRP = 56250,
                            Make = "Toyota",
                            Model = "GR Supra",
                            Year = 2025
                        },
                        new
                        {
                            VehicleId = 9,
                            Build = "Sedan",
                            CityMPG = 76,
                            ColorId = 4,
                            FuelType = "Hydrogen",
                            HwyMPG = 71,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/mirai/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 50190,
                            Make = "Toyota",
                            Model = "Mirai",
                            Year = 2025
                        },
                        new
                        {
                            VehicleId = 10,
                            Build = "SUV",
                            CityMPG = 40,
                            ColorId = 3,
                            FuelType = "Hybrid",
                            HwyMPG = 37,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2024/venza/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 35070,
                            Make = "Toyota",
                            Model = "Venza",
                            Year = 2024
                        },
                        new
                        {
                            VehicleId = 11,
                            Build = "Sedan",
                            CityMPG = 42,
                            ColorId = 5,
                            FuelType = "Hybrid",
                            HwyMPG = 41,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2025/toyotacrown/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 41440,
                            Make = "Toyota",
                            Model = "Crown",
                            Year = 2025
                        },
                        new
                        {
                            VehicleId = 12,
                            Build = "SUV",
                            CityMPG = 22,
                            ColorId = 2,
                            FuelType = "Hybrid",
                            HwyMPG = 25,
                            ImgPath = "https://tmna.aemassets.toyota.com/is/image/toyota/toyota/jellies/relative/2025/landcruiser/base.png?bg=fff&fmt=webp&qlt=90&wid=345",
                            InStock = true,
                            MSRP = 56450,
                            Make = "Toyota",
                            Model = "Land Cruiser",
                            Year = 2025
                        });
                });

            modelBuilder.Entity("VehicleInventoryProj.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleInventoryProj.Models.Color", "Color")
                        .WithMany("Vehicles")
                        .HasForeignKey("ColorId");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("VehicleInventoryProj.Models.Color", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
