﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MidtermApi.Data;

namespace MidtermApi.Migrations
{
    [DbContext(typeof(VacationDbContext))]
    partial class VacationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MidtermApi.Models.Activities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CitiesID")
                        .HasColumnType("int");

                    b.Property<bool>("FamilyFriendly")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Outdoors")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CitiesID");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CitiesID = 1,
                            FamilyFriendly = true,
                            Name = "Activity 1",
                            Outdoors = false
                        },
                        new
                        {
                            ID = 2,
                            CitiesID = 2,
                            FamilyFriendly = false,
                            Name = "Activity 2",
                            Outdoors = false
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.Cities", b =>
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

                    b.ToTable("Cities");

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

            modelBuilder.Entity("MidtermApi.Models.Hotels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CitiesID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CitiesID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CitiesID = 1,
                            Name = "Test INN",
                            Price = 80
                        },
                        new
                        {
                            ID = 2,
                            CitiesID = 2,
                            Name = "Test INN 2",
                            Price = 50
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.SavedVacation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CitiesID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecommendationCode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CitiesID");

                    b.ToTable("SavedVacation");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CitiesID = 1,
                            Name = "saved vacation 1",
                            RecommendationCode = 1234
                        },
                        new
                        {
                            ID = 2,
                            CitiesID = 2,
                            Name = "saved vacation 2",
                            RecommendationCode = 4321
                        });
                });

            modelBuilder.Entity("MidtermApi.Models.Activities", b =>
                {
                    b.HasOne("MidtermApi.Models.Cities", "Citites")
                        .WithMany()
                        .HasForeignKey("CitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MidtermApi.Models.Hotels", b =>
                {
                    b.HasOne("MidtermApi.Models.Cities", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MidtermApi.Models.SavedVacation", b =>
                {
                    b.HasOne("MidtermApi.Models.Cities", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
