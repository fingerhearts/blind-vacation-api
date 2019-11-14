using Microsoft.EntityFrameworkCore;
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
                    "The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark. ",
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
                 },
                new City
                {
                    ID = 8,
                    Name = "Orlando, Florida",
                    Description = "Orlando, a city in central Florida, is home to more than a dozen theme parks. Chief among its claims to fame is Walt Disney World, comprised of parks like the Magic Kingdom and Epcot, as well as water parks. " +
                    "Another major destination, Universal Orlando, offers Universal Studios and Islands of Adventure, with the Wizarding World of Harry Potter straddling both.",
                    ImageURL = "",
                    Hot = 1,
                    InUSA = 1,
                    Price = 2
                },
                 new City
                 {
                     ID = 9,
                     Name = "Atlanta, Georgia",
                     Description = "Atlanta is the capital of the U.S. state of Georgia. It played an important part in both the Civil War and the 1960s Civil Rights Movement. " +
                     "Atlanta History Center chronicles the city's past, and the Martin Luther King Jr. National Historic Site is dedicated to the African-American leader’s life and times. " +
                     "Downtown, Centennial Olympic Park, built for the 1996 Olympics, encompasses the massive Georgia Aquarium.",
                     ImageURL = "",
                     Hot = 1,
                     InUSA = 1,
                     Price = 1
                 },
                  new City
                  {
                      ID = 10,
                      Name = "Denver, Colorado",
                      Description = "Denver, the capital of Colorado, is an American metropolis dating to the Old West era. " +
                      "Larimer Square, the city’s oldest block, features landmark 19th-century buildings. " +
                      "Museums include the Denver Art Museum, an ultramodern complex known for its collection of indigenous works, and the mansion of famed Titanic survivor Molly Brown. " +
                      "Denver is also a jumping-off point for ski resorts in the nearby Rocky Mountains.",
                      ImageURL = "",
                      Hot = 0,
                      InUSA = 1,
                      Price = 1
                  },
                                    new City
                                    {
                                        ID = 11,
                                        Name = "Reykjavík, Iceland",
                                        Description = "Reykjavik, on the coast of Iceland, is the country's capital and largest city. It's home to the National and Saga museums, tracing Iceland’s Viking history. " +
                                        "The striking concrete Hallgrimskirkja church and rotating Perlan glass dome offer sweeping views of the sea and nearby hills. " +
                                        "Exemplifying the island’s volcanic activity is the geothermal Blue Lagoon spa, near the village of Grindavik.",
                                        ImageURL = "",
                                        Hot = 0,
                                        InUSA = 0,
                                        Price = 3
                                    },
                                    new City
                                    {
                                        ID = 12,
                                        Name = "Helsinki, Finland",
                                        Description = "Helsinki, Finland’s southern capital, sits on a peninsula in the Gulf of Finland. " +
                                        "Its central avenue, Mannerheimintie, is flanked by institutions including the National Museum, tracing Finnish history from the Stone Age to the present. " +
                                        "Also on Mannerheimintie are the imposing Parliament House and Kiasma, a contemporary art museum. " +
                                        "Ornate red-brick Uspenski Cathedral overlooks a harbor.",
                                        ImageURL = "",
                                        Hot = 0,
                                        InUSA = 0,
                                        Price = 1
                                    },
                                                                        new City
                                                                        {
                                                                            ID = 13,
                                                                            Name = "Phuket, Thailand",
                                                                            Description = "Phuket, a rainforested, mountainous island in the Andaman Sea, has some of Thailand’s most popular beaches, mainly situated along the clear waters of the western shore. " +
                                                                            "The island is home to many high-end seaside resorts, spas and restaurants. " +
                                                                            "Phuket City, the capital, has old shophouses and busy markets. Patong, the main resort town, has many nightclubs, bars and discos.",
                                                                            ImageURL = "",
                                                                            Hot = 1,
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
                    },

                  //cheap, average, and expensive hotels in Orlando
                  new Hotel
                  {
                      ID = 22,
                      CityID = 8,
                      Name = "Howard Johnson by Wyndham Lake Front Park Kissimmee",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 23,
                       CityID = 8,
                       Name = "DoubleTree by Hilton Hotel at the Entrance to Universal Orlando",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 24,
                        CityID = 8,
                        Name = "Grand Bohemian Hotel Orlando, Autograph Collection",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in ATLANTA
                  new Hotel
                  {
                      ID = 25,
                      CityID = 9,
                      Name = "Super 8 by Wyndham Austell/Six Flags",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 26,
                       CityID = 9,
                       Name = "Crowne Plaza Atlanta-Airport",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 27,
                        CityID = 9,
                        Name = "Four Seasons Hotel Atlanta",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in DENVER
                  new Hotel
                  {
                      ID = 28,
                      CityID = 10,
                      Name = "Ember Hostel",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 29,
                       CityID = 10,
                       Name = "Home2 Suites by Hilton Denver International Airport",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 30,
                        CityID = 10,
                        Name = "Four Seasons Hotel Denver",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in Reykjavík
                  new Hotel
                  {
                      ID = 31,
                      CityID = 11,
                      Name = "Reykjavik Downtown HI Hostel",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 32,
                       CityID = 11,
                       Name = "Grand Hótel Reykjavík",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 33,
                        CityID = 11,
                        Name = "Kvosin Downtown Hotel",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in Helsinki
                  new Hotel
                  {
                      ID = 34,
                      CityID = 12,
                      Name = "Reykjavik Downtown HI Hostel",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 35,
                       CityID = 12,
                       Name = "Grand Hótel Reykjavík",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 36,
                        CityID = 12,
                        Name = "Kvosin Downtown Hotel",
                        Price = 3
                    },

                  //cheap, average, and expensive hotels in PHUKET
                  new Hotel
                  {
                      ID = 37,
                      CityID = 13,
                      Name = "The Bukit",
                      Price = 1
                  },
                   new Hotel
                   {
                       ID = 38,
                       CityID = 13,
                       Name = "Andacura Beachfront collextion Panwa Phuket",
                       Price = 2
                   },
                    new Hotel
                    {
                        ID = 39,
                        CityID = 13,
                        Name = "The Westin Siray Bay Resort & Spa, Phuket",
                        Price = 3
                    }
               );


            //ACTIVITES FOR EACH CITY BASED OFF OF USER'S RESPONSE ON THE SURVEY.
            // 0 = FALSE, 1 = TRUE


            modelBuilder.Entity<Activity>().HasData(
               new Activity
               {
                   //activities for seattle with family and outdoors 
                   ID = 1,
                   CityID = 1,
                   Name = "1) This is it. You’re about to walk into a memory. Soaring 520 feet skyward. The city actually, really, truly at your feet. Step up. " +
                   "Step out. Step beyond your comfort zone. And experience wonder on a higher level. Visit the Space Needle in the heart of Seattle. \n " +
                   "2) When you and your friends arrive in Seattle by plane, cruise ship, car or Seattle-style bicycle, 'Ride the Ducks of Seattle' should be your first stop. " +
                   "In ninety minutes, you’ll see the top sights and hear about how the city developed into the tech-coffee-expensive-real-estate hub it is today. " +
                   "Before you start drinking your double tall, extra foam, skinny vanilla latte or posting photos when “the mountain’s out,” enjoy all that makes Seattle famous on the tour that was rated #1 City Tour for more than a decade." +
                   "3) One of the few authentic farmer's markets in the United States, this hub of delicious scents, delectable eats and delightful personalities attracts nine million visitors a year. Take a tour of Pike Place Market and find out" +
                   "why this market has become a staple in Seattle. \n",

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
                   "3) Visit REI in downtown Seattle and try your luck at Rock Climbing \n",

                   FamilyFriendly = 0,
                   Outdoors = 1
               },
                new Activity
                {
                    //activities for seattle with family and indoors 
                    ID = 3,
                    CityID = 1,
                    Name = "1) Visit the Seattle Art Museum in downtown Seattle._ 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront._ 3) Visit the Pacific Science Center.",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                 new Activity
                 {
                     //activities for seattle without family and indoors 
                     ID = 4,
                     CityID = 1,
                     Name = "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour._ 2) Get some drinks at some great bars on Capitol Hill._ 3) Get a bite to eat with a great view at Six Seven Restaurant.",
                     FamilyFriendly = 0,
                     Outdoors = 0
                 },



                  //BUFFALO ACTIVITIES


                  new Activity
                  {
                      //activities for buffalo with family and outdoors 
                      ID = 5,
                      CityID = 2,
                      Name = "1) Visit the Buffalo Zoo._ 2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park._ 3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.",
                      FamilyFriendly = 1,
                      Outdoors = 1
                  },
               new Activity
               {
                   //activities for buffalo without family and outdoors 
                   // info from: https://www.onlyinyourstate.com/new-york/buffalo/free-outdoor-activities-buffalo/
                   // info from: https://www.tripadvisor.com/Attraction_Review-g60974-d7396332-Reviews-Buffalo_Pedal_Tours-Buffalo_New_York.html
                   ID = 6,
                   CityID = 2,
                   Name = "1) Hop aboard on the Buffalo Pedal Tour, this people powered tour bus or boat for a fun filled time. On land and now on the water! " +
                   "Our professional drivers will guide you and your friends through the streets of Buffalo as you provide the energy by pedaling. \n" +
                   "2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.\n " +
                   "3) Activity without family outdoors placeholder \n",

                   FamilyFriendly = 0,
                   Outdoors = 1
               },
                new Activity
                {
                    //activities for buffalo with family and indoors 
                    ID = 7,
                    CityID = 2,
                    Name = "1) activity with family indoors placeholder #1.\n " +
                    "2) activity with family indoors placeholder #2.\n " +
                    "3) activity with family indoors placeholder #3.\n ",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                 new Activity
                 {
                     //activities for buffalo without family and indoors 
                     ID = 8,
                     CityID = 2,
                     Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",

                     FamilyFriendly = 0,
                     Outdoors = 0
                 },


                  // ACTIVITIES FOR LOS ANGELES


                  new Activity
                  {
                      //activities for los angeles without family and indoors 
                      ID = 9,
                      CityID = 3,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for los angeles without family and outdoors 
                      ID = 10,
                      CityID = 3,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for los angeles with family and outdoors 
                       ID = 11,
                       CityID = 3,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for los angeles with family and indoors 
                        ID = 12,
                        CityID = 3,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },


                  // ACTIVITIES FOR NEW DELHI


                  new Activity
                  {
                      //activities for New Delhi without family and indoors 
                      ID = 13,
                      CityID = 4,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for New Delhi without family and outdoors 
                      ID = 14,
                      CityID = 4,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for New Delhi with family and outdoors 
                       ID = 15,
                       CityID = 4,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for New Delhi with family and indoors 
                        ID = 16,
                        CityID = 4,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },


                  // ACTIVITIES FOR PARIS 


                  new Activity
                  {
                      //activities for PARIS without family and indoors 
                      ID = 17,
                      CityID = 5,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for PARIS without family and outdoors 
                      ID = 18,
                      CityID = 5,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for PARIS with family and outdoors 
                       ID = 19,
                       CityID = 5,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for PARIS with family and indoors 
                        ID = 20,
                        CityID = 5,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },


                  // ACTIVITIES FOR SEOUL 


                  new Activity
                  {
                      //activities for SEOUL without family and indoors 
                      ID = 21,
                      CityID = 6,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for SEOUL without family and outdoors 
                      ID = 22,
                      CityID = 6,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for SEOUL with family and outdoors 
                       ID = 23,
                       CityID = 6,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for SEOUL with family and indoors 
                        ID = 24,
                        CityID = 6,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },


                  // ACTIVITIES FOR MOSCOW 


                  new Activity
                  {
                      //activities for MOSCOW without family and indoors 
                      ID = 25,
                      CityID = 7,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for MOSCOW without family and outdoors 
                      ID = 26,
                      CityID = 7,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for MOSCOW with family and outdoors 
                       ID = 27,
                       CityID = 7,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for MOSCOW with family and indoors 
                        ID = 28,
                        CityID = 7,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },


                  // ACTIVITIES FOR ORLANDO 


                  new Activity
                  {
                      //activities for ORLANDO without family and indoors 
                      ID = 29,
                      CityID = 8,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for ORLANDO without family and outdoors 
                      ID = 30,
                      CityID = 8,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for ORLANDO with family and outdoors 
                       ID = 31,
                       CityID = 8,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for ORLANDO with family and indoors 
                        ID = 32,
                        CityID = 8,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },

                  // ACTIVITIES FOR ATLANTA 


                  new Activity
                  {
                      //activities for ATLANTA without family and indoors 
                      ID = 33,
                      CityID = 9,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for ATLANTA without family and outdoors 
                      ID = 34,
                      CityID = 9,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for ATLANTA with family and outdoors 
                       ID = 35,
                       CityID = 9,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for ATLANTA with family and indoors 
                        ID = 36,
                        CityID = 9,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },

                  // ACTIVITIES FOR DENVER 


                  new Activity
                  {
                      //activities for DENVER without family and indoors 
                      ID = 37,
                      CityID = 10,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for DENVER without family and outdoors 
                      ID = 38,
                      CityID = 10,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for DENVER with family and outdoors 
                       ID = 39,
                       CityID = 10,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for DENVER with family and indoors 
                        ID = 40,
                        CityID = 10,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },

                  // ACTIVITIES FOR Reykjavík 


                  new Activity
                  {
                      //activities for Reykjavík without family and indoors 
                      ID = 41,
                      CityID = 11,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for Reykjavík without family and outdoors 
                      ID = 42,
                      CityID = 11,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for Reykjavík with family and outdoors 
                       ID = 43,
                       CityID = 11,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for Reykjavík with family and indoors 
                        ID = 44,
                        CityID = 11,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },

                  // ACTIVITIES FOR HELSINKI 


                  new Activity
                  {
                      //activities for HELSINKI without family and indoors 
                      ID = 45,
                      CityID = 12,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for HELSINKI without family and outdoors 
                      ID = 45,
                      CityID = 12,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for HELSINKI with family and outdoors 
                       ID = 46,
                       CityID = 12,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for HELSINKI with family and indoors 
                        ID = 47,
                        CityID = 12,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
                        Outdoors = 0
                    },

                  // ACTIVITIES FOR PHUKET 


                  new Activity
                  {
                      //activities for PHUKET without family and indoors 
                      ID = 48,
                      CityID = 13,
                      Name = "1) activity without family indoors placeholder #1. \n" +
                     "2) activity without family indoors placeholder #2.\n" +
                     "3) activity without family indoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 0
                  },

                  new Activity
                  {
                      //activities for PHUKET without family and outdoors 
                      ID = 49,
                      CityID = 13,
                      Name = "1) activity without family outdoors placeholder #1. \n" +
                     "2) activity without family outdoors placeholder #2.\n" +
                     "3) activity without family outdoors placeholder #3.\n ",
                      FamilyFriendly = 0,
                      Outdoors = 1
                  },
                   new Activity
                   {
                       //activities for PHUKET with family and outdoors 
                       ID = 50,
                       CityID = 13,
                       Name = "1) activity with family outdoors placeholder #1. \n" +
                     "2) activity with family outdoors placeholder #2. \n" +
                     "3) activity with family outdoors placeholder #3.\n ",
                       FamilyFriendly = 1,
                       Outdoors = 1
                   },
                    new Activity
                    {
                        //activities for PHUKET with family and indoors 
                        ID = 51,
                        CityID = 13,
                        Name = "1) activity with family indoors placeholder #1. \n" +
                     "2) activity with family indoors placeholder #2.\n" +
                     "3) activity with family indoors placeholder #3.\n ",
                        FamilyFriendly = 1,
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