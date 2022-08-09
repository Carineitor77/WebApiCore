﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCore.Data.Context;

#nullable disable

namespace WebApiCore.Api.Migrations
{
    [DbContext(typeof(WebApiCoreContext))]
    partial class WebApiCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiCore.Data.Models.CurrentWeather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("MaxTemp")
                        .HasColumnType("real");

                    b.Property<float>("MinTemp")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weathers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaxTemp = 22f,
                            MinTemp = 20f,
                            Status = "Cloud"
                        },
                        new
                        {
                            Id = 2,
                            MaxTemp = 20f,
                            MinTemp = 18f,
                            Status = "Clear"
                        });
                });

            modelBuilder.Entity("WebApiCore.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Nick@mail.com",
                            Name = "Nick"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1980, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Tom@mail.com",
                            Name = "Tom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
