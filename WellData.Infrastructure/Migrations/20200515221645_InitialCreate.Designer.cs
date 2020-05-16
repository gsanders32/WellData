﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WellData.Infrastructure.Data;

namespace WellData.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200515221645_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("WellData.Core.Models.Flow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Rate")
                        .HasColumnType("REAL");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WellId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.HasIndex("WellId");

                    b.ToTable("Flows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 234.22999999999999,
                            UnitTypeId = 1,
                            WellId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 214.22999999999999,
                            UnitTypeId = 1,
                            WellId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 274.23000000000002,
                            UnitTypeId = 1,
                            WellId = 2
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 224.22999999999999,
                            UnitTypeId = 1,
                            WellId = 2
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 214.22999999999999,
                            UnitTypeId = 1,
                            WellId = 3
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rate = 199.22999999999999,
                            UnitTypeId = 1,
                            WellId = 3
                        });
                });

            modelBuilder.Entity("WellData.Core.Models.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "GPM",
                            DisplayName = "Gallons Per Minute"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "ft",
                            DisplayName = "Feet"
                        });
                });

            modelBuilder.Entity("WellData.Core.Models.WaterLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("DepthToWater")
                        .HasColumnType("REAL");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WellId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.HasIndex("WellId");

                    b.ToTable("WaterLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 234.22999999999999,
                            UnitTypeId = 2,
                            WellId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 214.22999999999999,
                            UnitTypeId = 2,
                            WellId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 274.23000000000002,
                            UnitTypeId = 2,
                            WellId = 2
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 224.22999999999999,
                            UnitTypeId = 2,
                            WellId = 2
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 214.22999999999999,
                            UnitTypeId = 2,
                            WellId = 3
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepthToWater = 199.22999999999999,
                            UnitTypeId = 2,
                            WellId = 3
                        });
                });

            modelBuilder.Entity("WellData.Core.Models.Well", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DistrictNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Elevation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Wells");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistrictNumber = 1,
                            Elevation = 3421
                        },
                        new
                        {
                            Id = 2,
                            DistrictNumber = 2,
                            Elevation = 3221
                        },
                        new
                        {
                            Id = 3,
                            DistrictNumber = 3,
                            Elevation = 3321
                        });
                });

            modelBuilder.Entity("WellData.Core.Models.Flow", b =>
                {
                    b.HasOne("WellData.Core.Models.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WellData.Core.Models.Well", null)
                        .WithMany("Flows")
                        .HasForeignKey("WellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WellData.Core.Models.WaterLevel", b =>
                {
                    b.HasOne("WellData.Core.Models.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WellData.Core.Models.Well", null)
                        .WithMany("WaterLevels")
                        .HasForeignKey("WellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
