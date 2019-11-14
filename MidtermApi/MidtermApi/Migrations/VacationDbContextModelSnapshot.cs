﻿// <auto-generated />
using System;
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

            modelBuilder.Entity("MidtermApi.Models.Activity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("FamilyFriendly")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Outdoors")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Activity");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityID = 1,
                            FamilyFriendly = 1,
                            Name = "1) Visit the Space Needle_ 2) Ride the Duck_ 3) Tour Pike Place Market",
                            Outdoors = 1
                        },
                        new
                        {
                            ID = 2,
                            CityID = 1,
                            FamilyFriendly = 0,
                            Name = "1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle._ 2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center._ 3) Visit REI in downtown Seattle and try Rock Climbing.",
                            Outdoors = 1
                        },
                        new
                        {
                            ID = 3,
                            CityID = 1,
                            FamilyFriendly = 1,
                            Name = "1) Visit the Seattle Art Museum in downtown Seattle._ 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront._ 3) Visit the Pacific Science Center.",
                            Outdoors = 0
                        },
                        new
                        {
                            ID = 4,
                            CityID = 1,
                            FamilyFriendly = 0,
                            Name = "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour._ 2) Get some drinks at some great bars on Capitol Hill._ 3) Get a bite to eat with a great view at Six Seven Restaurant.",
                            Outdoors = 0
                        },
                        new
                        {
                            ID = 5,
                            CityID = 2,
                            FamilyFriendly = 1,
                            Name = "1) Visit the Buffalo Zoo._ 2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park._ 3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.",
                            Outdoors = 1
                        },
                        new
                        {
                            ID = 6,
                            CityID = 2,
                            FamilyFriendly = 0,
                            Name = "1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle._ 2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center._ 3) Visit REI in downtown Seattle and try Rock Climbing.",
                            Outdoors = 1
                        },
                        new
                        {
                            ID = 7,
                            CityID = 2,
                            FamilyFriendly = 1,
                            Name = "1) Visit the Buffalo Museum of Science._ 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront._3) Visit the Pacific Science Center.",
                            Outdoors = 0
                        },
                        new
                        {
                            ID = 8,
                            CityID = 2,
                            FamilyFriendly = 0,
                            Name = "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour._ 2) Get some drinks at some great bars on Capitol Hill._3) Get a bite to eat with a great view at the Six Seven Restaurant.",
                            Outdoors = 0
                        },
                        new
                        {
                            ID = 9,
                            CityID = 5,
                            FamilyFriendly = 0,
                            Name = "1) Test 1 activity_2) Test 2 acivity._3) Test 3 activity.",
                            Outdoors = 0
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

                    b.Property<int>("Hot")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InUSA")
                        .HasColumnType("int");

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
                            Description = "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, mountains and evergreen forests, and contains thousands of acres of parkland. Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark. ",
                            Hot = 0,
                            ImageURL = "",
                            InUSA = 1,
                            Name = "Seattle, Washington",
                            Price = 2
                        },
                        new
                        {
                            ID = 2,
                            Description = "Buffalo is a city on the shores of Lake Erie in upstate New York. Its fine neoclassical, beaux arts and art deco architecture speaks to its history as an industrial capital in the early 20th century. Its landmarks include the 398-ft art deco City Hall, the Frank Lloyd Wright–designed Darwin D. Martin House and the Albright-Knox Art Gallery, a Greek Revival museum with works by Picasso and Warhol.",
                            Hot = 0,
                            ImageURL = "",
                            InUSA = 1,
                            Name = "Buffalo, New York",
                            Price = 1
                        },
                        new
                        {
                            ID = 3,
                            Description = "Los Angeles is a sprawling Southern California city and the center of the nation’s film and television industry. Near its iconic Hollywood sign, studios such as Paramount Pictures, Universal and Warner Brothers offer behind-the-scenes tours. On Hollywood Boulevard, TCL Chinese Theatre displays celebrities’ hand- and footprints, the Walk of Fame honors thousands of luminaries and vendors sell maps to stars’ homes.",
                            Hot = 1,
                            ImageURL = "",
                            InUSA = 1,
                            Name = "Los Angeles, California",
                            Price = 3
                        },
                        new
                        {
                            ID = 4,
                            Description = "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India. The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.",
                            Hot = 1,
                            ImageURL = "",
                            InUSA = 0,
                            Name = "New Delhi, India",
                            Price = 1
                        },
                        new
                        {
                            ID = 5,
                            Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.",
                            Hot = 1,
                            ImageURL = "",
                            InUSA = 0,
                            Name = "Paris, France",
                            Price = 3
                        },
                        new
                        {
                            ID = 6,
                            Description = "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.",
                            Hot = 1,
                            ImageURL = "",
                            InUSA = 0,
                            Name = "Seoul, South Korea",
                            Price = 2
                        },
                        new
                        {
                            ID = 7,
                            Description = "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.",
                            Hot = 0,
                            ImageURL = "",
                            InUSA = 0,
                            Name = "Moscow, Russia",
                            Price = 2
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

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityID = 1,
                            Name = "Roy Street Commons",
                            Price = 1
                        },
                        new
                        {
                            ID = 2,
                            CityID = 1,
                            Name = "Hilton Seattle",
                            Price = 2
                        },
                        new
                        {
                            ID = 3,
                            CityID = 1,
                            Name = "Four Seasons Hotel",
                            Price = 3
                        },
                        new
                        {
                            ID = 4,
                            CityID = 2,
                            Name = "Motel 6 Buffalo Airport",
                            Price = 1
                        },
                        new
                        {
                            ID = 5,
                            CityID = 2,
                            Name = "Millennium Buffalo",
                            Price = 2
                        },
                        new
                        {
                            ID = 6,
                            CityID = 2,
                            Name = "Curtiss Hotel",
                            Price = 3
                        },
                        new
                        {
                            ID = 7,
                            CityID = 3,
                            Name = "Monterey Inn",
                            Price = 1
                        },
                        new
                        {
                            ID = 8,
                            CityID = 3,
                            Name = "Freehand Los Angeles",
                            Price = 2
                        },
                        new
                        {
                            ID = 9,
                            CityID = 3,
                            Name = "The Ritz-Carlton, Los Angeles",
                            Price = 3
                        },
                        new
                        {
                            ID = 10,
                            CityID = 4,
                            Name = "Suites Admiral",
                            Price = 1
                        },
                        new
                        {
                            ID = 11,
                            CityID = 4,
                            Name = "Haveli Dharampura",
                            Price = 3
                        },
                        new
                        {
                            ID = 12,
                            CityID = 4,
                            Name = "Hotel Diplomat",
                            Price = 2
                        },
                        new
                        {
                            ID = 13,
                            CityID = 5,
                            Name = "Le Regent Montmarte",
                            Price = 1
                        },
                        new
                        {
                            ID = 14,
                            CityID = 5,
                            Name = "Holiday Inn Paris",
                            Price = 2
                        },
                        new
                        {
                            ID = 15,
                            CityID = 5,
                            Name = "InterContinental Paris",
                            Price = 3
                        },
                        new
                        {
                            ID = 16,
                            CityID = 6,
                            Name = "Hongdae Chef Guesthouse",
                            Price = 1
                        },
                        new
                        {
                            ID = 17,
                            CityID = 6,
                            Name = "Tmark Hotel Myeongdong",
                            Price = 2
                        },
                        new
                        {
                            ID = 18,
                            CityID = 6,
                            Name = "Park Hyatt Seoul",
                            Price = 3
                        },
                        new
                        {
                            ID = 19,
                            CityID = 7,
                            Name = "Winterfell Hotel Tverskaya",
                            Price = 1
                        },
                        new
                        {
                            ID = 20,
                            CityID = 7,
                            Name = "Hilton Garden Inn Moscow Krasnoselskaya",
                            Price = 2
                        },
                        new
                        {
                            ID = 21,
                            CityID = 7,
                            Name = "The St. Regis Moscow Nikolskaya",
                            Price = 3
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
