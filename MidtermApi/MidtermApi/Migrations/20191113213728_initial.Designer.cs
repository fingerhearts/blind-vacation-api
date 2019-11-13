﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MidtermApi.Data;

namespace MidtermApi.Migrations
{
    [DbContext(typeof(VacationDbContext))]
    [Migration("20191113213728_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MidtermApi.Models.Activity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<bool>("FamilyFriendly")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Outdoors")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Activity");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityID = 1,
                            FamilyFriendly = true,
                            Name = "Activity 1",
                            Outdoors = false
                        },
                        new
                        {
                            ID = 2,
                            CityID = 2,
                            FamilyFriendly = false,
                            Name = "Activity 2",
                            Outdoors = false
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hot")
                        .HasColumnType("bit");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InUSA")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "test",
                            Hot = false,
                            ImageURL = "",
                            InUSA = true,
                            Name = "Seattle",
                            Price = 20
                        },
                        new
                        {
                            ID = 2,
                            Description = "test2",
                            Hot = true,
                            ImageURL = "",
                            InUSA = true,
                            Name = "Los Angeles",
                            Price = 100
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityID = 1,
                            Name = "Test INN",
                            Price = 80
                        },
                        new
                        {
                            ID = 2,
                            CityID = 2,
                            Name = "Test INN 2",
                            Price = 50
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityID")
                        .HasColumnType("int");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RecommendationCode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ActivityID");

                    b.HasIndex("CityID");

                    b.HasIndex("HotelID");

                    b.ToTable("SavedVacation");
                });

            modelBuilder.Entity("MidtermApi.Models.Activity", b =>
                {
                    b.HasOne("MidtermApi.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MidtermApi.Models.Hotel", b =>
                {
                    b.HasOne("MidtermApi.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MidtermApi.Models.Plan", b =>
                {
                    b.HasOne("MidtermApi.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityID");

                    b.HasOne("MidtermApi.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("MidtermApi.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID");
                });
#pragma warning restore 612, 618
        }
    }
}