﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectTestAPI_1.SQLiteDb;

#nullable disable

namespace ProjectTestAPI_1.Migrations.DiscountCards
{
    [DbContext(typeof(DiscountCardsContext))]
    [Migration("20220624110634_discountcards4")]
    partial class discountcards4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("ProjectTestAPI_1.Models.DiscountCards", b =>
                {
                    b.Property<ulong>("CardNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.HasKey("CardNumber");

                    b.ToTable("discountCards");
                });
#pragma warning restore 612, 618
        }
    }
}