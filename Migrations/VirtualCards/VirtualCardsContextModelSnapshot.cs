﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectTestAPI_1.SQLiteDb;

#nullable disable

namespace ProjectTestAPI_1.Migrations.VirtualCards
{
    [DbContext(typeof(VirtualCardsContext))]
    partial class VirtualCardsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("ProjectTestAPI_1.Models.VirtualCard", b =>
                {
                    b.Property<ulong>("CardNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CardToken")
                        .HasColumnType("TEXT");

                    b.HasKey("CardNumber");

                    b.ToTable("virtualCards");
                });
#pragma warning restore 612, 618
        }
    }
}