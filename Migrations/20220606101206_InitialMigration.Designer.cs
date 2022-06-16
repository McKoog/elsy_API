﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectTestAPI_1;

#nullable disable

namespace ProjectTestAPI_1.Migrations
{
    [DbContext(typeof(StationConfigurationContext))]
    [Migration("20220606101206_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("ProjectTestAPI_1.Models.StationsFPNozzles", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("FuelId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("FuelPointId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("NozzleId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("StationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("stationsFPNozzles");
                });
#pragma warning restore 612, 618
        }
    }
}