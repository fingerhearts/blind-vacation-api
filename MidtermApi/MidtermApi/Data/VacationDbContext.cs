﻿using Microsoft.EntityFrameworkCore;
using MidtermApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Data
{
    public class VacationDbContext : DbContext
    {
        public VacationDbContext(DbContextOptions<VacationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// seeding database wtih city and all releveant information. Description used from google search and/ or wikipedia. Hotels info also used from google searches; same with activites.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    ID = 1,
                    Name = "Seattle, Washington",
                    Description = "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, " +
                    "mountains and evergreen forests, and contains thousands of acres of parkland. " +
                    "Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. " +
                    "The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark.",
                    ImageURL = "",
                    Hot = 0,
                    InUSA = 1,
                    Price = 2
                },
                  new City
                  {
                      ID = 2,
                      Name = "Buffalo, New York",
                      Description = "Buffalo is a city on the shores of Lake Erie in upstate New York. " +
                      "Its fine neoclassical, beaux arts and art deco architecture speaks to its history as an industrial capital in the early 20th century. " +
                      "Its landmarks include the 398-ft art deco City Hall, the Frank Lloyd Wright–designed Darwin D. Martin House and the Albright-Knox Art Gallery, a Greek Revival museum with works by Picasso and Warhol.",
                      ImageURL = "",
                      Hot = 0,
                      InUSA = 1,
                      Price = 1
                  },
                new City
                {
                    ID = 3,
                    Name = "Los Angeles, California",
                    Description = "Los Angeles is a sprawling Southern California city and the center of the nation’s film and television industry. " +
                    "Near its iconic Hollywood sign, studios such as Paramount Pictures, Universal and Warner Brothers offer behind-the-scenes tours. " +
                    "On Hollywood Boulevard, TCL Chinese Theatre displays celebrities’ hand- and footprints, " +
                    "the Walk of Fame honors thousands of luminaries and vendors sell maps to stars’ homes.",
                    ImageURL = "",
                    Hot = 1,
                    InUSA = 1,
                    Price = 3
                },
                 new City
                 {
                     ID = 4,
                     Name = "New Delhi, India",
                     Description = "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India." +
                     " The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. " +
                     "It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.",
                     ImageURL = "",
                     Hot = 1,
                     InUSA = 0,
                     Price = 1
                 },
                 new City
                 {
                     ID = 5,
                     Name = "Paris, France",
                     Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. " +
                     "Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. " +
                     "Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.",
                     ImageURL = "",
                     Hot = 1,
                     InUSA = 0,
                     Price = 3
                 },
                 new City
                 {
                     ID = 6,
                     Name = "Seoul, South Korea",
                     Description = "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. " +
                     "Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.",
                     ImageURL = "",
                     Hot = 1,
                     InUSA = 0,
                     Price = 2
                 },
                 new City
                 {
                     ID = 7,
                     Name = "Moscow, Russia",
                     Description = "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. " +
                     "Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.",
                     ImageURL = "",
                     Hot = 0,
                     InUSA = 0,
                     Price = 2
                 }
                );

            //cheap, average, and expensive hotels in seattle
            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   ID = 1,
                   CityID = 1,
                   Name = "Roy Street Commons",
                   Price = 1
               },
                 new Hotel
                 {
                     ID = 2,
                     CityID = 1,
                     Name = "Hilton Seattle",
                     Price = 2
                 },
                   new Hotel
                   {
                       ID = 3,
                       CityID = 1,
                       Name = "Four Seasons Hotel",
                       Price = 3
                   },

               //cheap, average, and expensive hotels in buffalo
               new Hotel
               {
                   ID = 4,
                   CityID = 2,
                   Name = "Motel 6 Buffalo Airport",
                   Price = 1
               },
                new Hotel
                {
                    ID = 5,
                    CityID = 2,
                    Name = "Millennium Buffalo",
                    Price = 2
                },
                 new Hotel
                 {
                     ID = 6,
                     CityID = 2,
                     Name = "Curtiss Hotel",
                     Price = 3
                 },

                  //cheap, average, and expensive hotels in Los angeles
                  new Hotel
                  {
                      ID = 7,
                      CityID = 3,
                      Name = "Monterey Inn",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 8,
                       CityID = 3,
                       Name = "Freehand Los Angeles",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 9,
                        CityID = 3,
                        Name = "The Ritz-Carlton, Los Angeles",
                        Price = 3
                    },

                        //cheap, average, and expensive hotels in new delhi
                    new Hotel
                    {
                         ID = 10,
                         CityID = 4,
                         Name = "Suites Admiral",
                         Price = 1
                    },
                    new Hotel
                    {
                         ID = 11,
                         CityID = 4,
                         Name = "Haveli Dharampura",
                         Price = 3
                    },
                    new Hotel
                    {
                         ID = 12,
                         CityID = 4,
                         Name = "Hotel Diplomat",
                         Price = 2
                    },
                  //cheap, average, and expensive hotels in Paris
                  new Hotel
                  {
                      ID = 13,
                      CityID = 5,
                      Name = "Le Regent Montmarte",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 14,
                       CityID = 5,
                       Name = "Holiday Inn Paris",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 15,
                        CityID = 5,
                        Name = "InterContinental Paris",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in Seoul Korea
                  new Hotel
                  {
                      ID = 16,
                      CityID = 6,
                      Name = "Hongdae Chef Guesthouse",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 17,
                       CityID = 6,
                       Name = "Tmark Hotel Myeongdong",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 18,
                        CityID = 6,
                        Name = "Park Hyatt Seoul",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in Moscow
                  new Hotel
                  {
                      ID = 19,
                      CityID = 7,
                      Name = "Winterfell Hotel Tverskaya",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 20,
                       CityID = 7,
                       Name = "Hilton Garden Inn Moscow Krasnoselskaya",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 21,
                        CityID = 7,
                        Name = "The St. Regis Moscow Nikolskaya",
                        Price = 3
                    }
               );

            //activities for each city based off of user's reponse on the survey.
            modelBuilder.Entity<Activity>().HasData(
               new Activity
               {
                   //activities for seattle with family and outdoors 
                   ID = 1,
                   CityID = 1,
                   Name = "1) Visit the Space Needle \n 2) Ride the Duck \n 3) Tour Pike Place Market \n",
                   FamilyFriendly = 1,
                   Outdoors = 1
               },
               new Activity
               {
                   //activities for seattle without family and outdoors 
                   ID = 2,
                   CityID = 1,
                   Name = "1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle \n" +
                   "2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.\n " +
                   "3) Visit REI in downtown Seattle and try Rock Climbing \n",
                   FamilyFriendly = 0,
                   Outdoors = 1
               },
                new Activity
                {
                    //activities for seattle with family and indoors 
                    ID = 3,
                    CityID = 1,
                    Name = "1) Visit the Seattle Art Museum in downtown Seattle.\n " +
                    "2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront.\n " +
                    "3) Visit the Pacific Science Center.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                 new Activity
                 {
                     //activities for seattle without family and indoors 
                     ID = 4,
                     CityID = 1,
                     Name = "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour. \n" +
                     "2) Get some drinks at some great bars on Capitol Hill.\n" +
                     "3) Get a bite to eat with a great view at Six Seven Restaurant.\n ",
                     FamilyFriendly = 0,
                     Outdoors = 0
                 },


                 
                 //STILL WORKING ON BUFFALO SWITCH TO HOT CITY FOR DEMO!!!!


                  new Activity
                  {
                      //activities for buffalo with family and outdoors 
                      ID = 5,
                      CityID = 2,
                      Name = "1) Visit the Buffalo Zoo \n " +
                      "2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park. \n " +
                      "3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.\n",
                      FamilyFriendly = 1,
                      Outdoors = 1
                  },
               new Activity
               {
                   //activities for buffalo without family and outdoors 
                   ID = 6,
                   CityID = 2,
                   Name = "1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle \n" +
                   "2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.\n " +
                   "3) Visit REI in downtown Seattle and try Rock Climbing \n",
                   FamilyFriendly = 0,
                   Outdoors = 1
               },
                new Activity
                {
                    //activities for buffalo with family and indoors 
                    ID = 7,
                    CityID = 2,
                    Name = "1) Visit the Buffalo Museum of Science.\n " +
                    "2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront.\n " +
                    "3) Visit the Pacific Science Center.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                 new Activity
                 {
                     //activities for buffalo without family and indoors 
                     ID = 8,
                     CityID = 2,
                     Name = "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour. \n" +
                     "2) Get some drinks at some great bars on Capitol Hill.\n" +
                     "3) Get a bite to eat with a great view at the Six Seven Restaurant.\n ",
                     FamilyFriendly = 0,
                     Outdoors = 0
                 },




                 new Activity
                 {
                     //activities for paris without family and indoors 
                     ID = 9,
                     CityID = 5,
                     Name = "1) Test 1 activity \n" +
                     "2) Test 2 acivity.\n" +
                     "3) Test 3 activity.\n ",
                     FamilyFriendly = 0,
                     Outdoors = 0
                 }



               );

        }
        public DbSet<City> City { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Plan> SavedVacation { get; set; }
    }
}