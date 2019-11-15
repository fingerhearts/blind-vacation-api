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
            #region Domestic Cities x 6
                new City
                {
                    ID = 1,
                    Name = "Seattle, Washington",
                    Description = "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, " +
                    "mountains and evergreen forests, and contains thousands of acres of parkland. " +
                    "Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. " +
                    "The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark. ",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/e3/Seattle_Kerry_Park_Skyline.jpg",
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
                    ImageURL = "https://cdn.pixabay.com/photo/2012/08/27/22/15/niagara-falls-55119_960_720.jpg",
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
                    ImageURL = "https://storage.needpix.com/rsynced_images/los-angeles-1598750_1280.jpg",
                    Hot = 1,
                    InUSA = 1,
                    Price = 3
                },
                new City
                {
                    ID = 4,
                    Name = "Orlando, Florida",
                    Description = "Orlando, a city in central Florida, is home to more than a dozen theme parks. Chief among its claims to fame is Walt Disney World, comprised of parks like the Magic Kingdom and Epcot, as well as water parks. " +
                    "Another major destination, Universal Orlando, offers Universal Studios and Islands of Adventure, with the Wizarding World of Harry Potter straddling both.",
                    ImageURL = "https://cdn.pixabay.com/photo/2017/08/29/09/26/disney-2692578_960_720.jpg",
                    Hot = 1,
                    InUSA = 1,
                    Price = 2
                },
                new City
                {
                    ID = 5,
                    Name = "Atlanta, Georgia",
                    Description = "Atlanta is the capital of the U.S. state of Georgia. It played an important part in both the Civil War and the 1960s Civil Rights Movement. " +
                    "Atlanta History Center chronicles the city's past, and the Martin Luther King Jr. National Historic Site is dedicated to the African-American leader’s life and times. " +
                    "Downtown, Centennial Olympic Park, built for the 1996 Olympics, encompasses the massive Georgia Aquarium.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/a/a7/Atlanta_Skyline_from_Buckhead.jpg",
                    Hot = 1,
                    InUSA = 1,
                    Price = 1
                },
                new City
                {
                    ID = 6,
                    Name = "Denver, Colorado",
                    Description = "Denver, the capital of Colorado, is an American metropolis dating to the Old West era. " +
                    "Larimer Square, the city’s oldest block, features landmark 19th-century buildings. " +
                    "Museums include the Denver Art Museum, an ultramodern complex known for its collection of indigenous works, and the mansion of famed Titanic survivor Molly Brown. " +
                    "Denver is also a jumping-off point for ski resorts in the nearby Rocky Mountains.",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAgmDB1n98IbT0LLXff2ASnUgOG7UKuwTMg196OiyPNgJa0E_Hxw&s",
                    Hot = 0,
                    InUSA = 1,
                    Price = 1
                },   
            #endregion
            #region Foreign Cities x 7
                new City
                {
                    ID = 7,
                    Name = "New Delhi, India",
                    Description = "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India." +
                    " The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. " +
                    "It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.",
                    ImageURL = "https://live.staticflickr.com/2834/9491020841_08c3c47f11_b.jpg",
                    Hot = 1,
                    InUSA = 0,
                    Price = 1
                },
                new City
                {
                    ID = 8,
                    Name = "Paris, France",
                    Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. " +
                    "Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. " +
                    "Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.",
                    ImageURL = "https://cdn.pixabay.com/photo/2019/07/21/15/48/paris-4353012_960_720.jpg",
                    Hot = 1,
                    InUSA = 0,
                    Price = 3
                },
                new City
                {
                    ID = 9,
                    Name = "Seoul, South Korea",
                    Description = "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. " +
                    "Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.",
                    ImageURL = "https://s.iha.com/00128375786/South-korea-Bongeunsa-temple-in-seoul.jpeg",
                    Hot = 1,
                    InUSA = 0,
                    Price = 2
                },
                new City
                {
                    ID = 10,
                    Name = "Moscow, Russia",
                    Description = "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. " +
                    "Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.",
                    ImageURL = "https://media.defense.gov/2007/Nov/08/2000432272/780/780/0/082207-F-0000A-004.JPG",
                    Hot = 0,
                    InUSA = 0,
                    Price = 2
                },
                new City
                {
                    ID = 11,
                    Name = "Reykjavík, Iceland",
                    Description = "Reykjavik, on the coast of Iceland, is the country's capital and largest city. It's home to the National and Saga museums, tracing Iceland’s Viking history. " +
                    "The striking concrete Hallgrimskirkja church and rotating Perlan glass dome offer sweeping views of the sea and nearby hills. " +
                    "Exemplifying the island’s volcanic activity is the geothermal Blue Lagoon spa, near the village of Grindavik.",
                    ImageURL = "https://c1.staticflickr.com/6/5488/9465885222_b14d4e6d6a_b.jpg",
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
                    ImageURL = "https://cdn.pixabay.com/photo/2019/05/08/22/01/helsinki-cathedral-4189824_960_720.jpg",
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
                    ImageURL = "https://cdn.pixabay.com/photo/2017/02/21/00/54/beach-2084350_960_720.jpg",
                    Hot = 1,
                    InUSA = 0,
                    Price = 2
                }
            #endregion
                );

            modelBuilder.Entity<Hotel>().HasData(
            #region Seattle Hotels
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
            #endregion
            #region Buffalo Hotels
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
            #endregion
            #region LA Hotels
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
            #endregion
            #region Orlando Hotels
                //cheap, average, and expensive hotels in Orlando
                new Hotel
                {
                    ID = 10,
                    CityID = 4,
                    Name = "Howard Johnson by Wyndham Lake Front Park Kissimmee",
                    Price = 1
                },
                new Hotel
                {
                    ID = 11,
                    CityID = 4,
                    Name = "DoubleTree by Hilton Hotel at the Entrance to Universal Orlando",
                    Price = 2
                },
                new Hotel
                {
                    ID = 12,
                    CityID = 4,
                    Name = "Grand Bohemian Hotel Orlando, Autograph Collection",
                    Price = 3
                },
            #endregion
            #region Atlanta Hotels
                //cheap, average, and expensive hotels in Atlanta
                new Hotel
                {
                    ID = 13,
                    CityID = 5,
                    Name = "Super 8 by Wyndham Austell/Six Flags",
                    Price = 1
                },
                new Hotel
                {
                    ID = 14,
                    CityID = 5,
                    Name = "Crowne Plaza Atlanta-Airport",
                    Price = 2
                },
                new Hotel
                {
                    ID = 15,
                    CityID = 5,
                    Name = "Four Seasons Hotel Atlanta",
                    Price = 3
                },
            #endregion
            #region Denver Hotels
                //cheap, average, and expensive hotels in Denver
                new Hotel
                {
                    ID = 16,
                    CityID = 6,
                    Name = "Ember Hostel",
                    Price = 1
                },
                new Hotel
                {
                    ID = 17,
                    CityID = 6,
                    Name = "Home2 Suites by Hilton Denver International Airport",
                    Price = 2
                },
                new Hotel
                {
                    ID = 18,
                    CityID = 6,
                    Name = "Four Seasons Hotel Denver",
                    Price = 3
                },
            #endregion
            #region New Delhi Hotels
                //cheap, average, and expensive hotels in new delhi
                new Hotel
                {
                    ID = 19,
                    CityID = 7,
                    Name = "Suites Admiral",
                    Price = 1
                },
                new Hotel
                {
                    ID = 20,
                    CityID = 7,
                    Name = "Haveli Dharampura",
                    Price = 3
                },
                new Hotel
                {
                    ID = 21,
                    CityID = 7,
                    Name = "Hotel Diplomat",
                    Price = 2
                },
            #endregion
            #region Paris Hotels
                //cheap, average, and expensive hotels in Paris
                new Hotel
                {
                    ID = 22,
                    CityID = 8,
                    Name = "Le Regent Montmarte",
                    Price = 1
                },
                new Hotel
                {
                    ID = 23,
                    CityID = 8,
                    Name = "Holiday Inn Paris",
                    Price = 2
                },
                new Hotel
                {
                    ID = 24,
                    CityID = 8,
                    Name = "InterContinental Paris",
                    Price = 3
                },
            #endregion
            #region Seoul Hotels
                //cheap, average, and expensive hotels in Seoul Korea
                new Hotel
                {
                    ID = 25,
                    CityID = 9,
                    Name = "Hongdae Chef Guesthouse",
                    Price = 1
                },
                new Hotel
                {
                    ID = 26,
                    CityID = 9,
                    Name = "Tmark Hotel Myeongdong",
                    Price = 2
                },
                new Hotel
                {
                    ID = 27,
                    CityID = 9,
                    Name = "Park Hyatt Seoul",
                    Price = 3
                },
            #endregion
            #region Moscow Hotels
                //cheap, average, and expensive hotels in Moscow
                new Hotel
                {
                    ID = 28,
                    CityID = 10,
                    Name = "Winterfell Hotel Tverskaya",
                    Price = 1
                },
                new Hotel
                {
                    ID = 29,
                    CityID = 10,
                    Name = "Hilton Garden Inn Moscow Krasnoselskaya",
                    Price = 2
                },
                new Hotel
                {
                    ID = 30,
                    CityID = 10,
                    Name = "The St. Regis Moscow Nikolskaya",
                    Price = 3
                },
            #endregion
            #region Reykjavik Hotels
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
            #endregion
            #region Helsinki Hotels
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
            #endregion
            #region Phuket Hotels
                //cheap, average, and expensive hotels in Phuket
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
                #endregion
               );

            //ACTIVITES FOR EACH CITY BASED OFF OF USER'S RESPONSE ON THE SURVEY.
            // 0 = FALSE, 1 = TRUE

            modelBuilder.Entity<Activity>().HasData(
            #region Seattle Activities
                new Activity
                {
                    //activities for Seattle with family and outdoors 
                    ID = 1,
                    CityID = 1,
                    Name = "1) Space Needle\n\n" + "This is it. You’re about to walk into a memory. Soaring 520 feet skyward. The city actually, really, truly at your feet. Step up. Step out. Step beyond your comfort zone. And experience wonder on a higher level. Visit the Space Needle in the heart of Seattle.\n\n" +
                    "2) Ride the Ducks of Seattle\n\n" + "When you and your friends arrive in Seattle by plane, cruise ship, car or Seattle-style bicycle, 'Ride the Ducks of Seattle' should be your first stop. In ninety minutes, you’ll see the top sights and hear about how the city developed into the tech-coffee-expensive-real-estate hub it is today. Before you start drinking your double tall, extra foam, skinny vanilla latte or posting photos when “the mountain’s out,” enjoy all that makes Seattle famous on the tour that was rated #1 City Tour for more than a decade.\n\n" +
                    "3) Pike Place Market\n\n" + "One of the few authentic farmer's markets in the United States, this hub of delicious scents, delectable eats and delightful personalities attracts nine million visitors a year. Take a tour of Pike Place Market and find out why this market has become a staple in Seattle.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Seattle without family and outdoors 
                    ID = 2,
                    CityID = 1,
                    Name = "1) Fly high indoors at IFly\n\n" + "An exiciting indoors skydiving center located only mintues outside of Seattle.\n\n" +
                    "2) Canoeing at University of Washington Waterfront\n\n" + "Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.\n\n" +
                    "3) Rock Climing at REI\n\n" + "Visit REI in downtown Seattle and try your luck at Rock Climbing.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Seattle with family and indoors 
                    ID = 3,
                    CityID = 1,
                    Name = "1) Seattle Art Museum\n\n" + "Visit Seattle Art Museum to see a museum carved into the city, as much a part of Seattle's landscape and personality as the coffee, rain, mountains, Pike Place Market, and the Space Needle.\n\n" +
                    "2) Seattle Aquarium\n\n" + "The Seattle Aquarium is a public aquarium opened in 1977 and located on Pier 59 on the Elliott Bay waterfront in Seattle.\n\n" +
                    "3) Pacific Science Center\n\n" + "Pacific Science Center is a science center with a mission to ignite curiosity and fuel a passion for discovery, experimentation, and critical thinking.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Seattle without family and indoors 
                    ID = 4,
                    CityID = 1,
                    Name = "1) Bill Speidel's Underground Tour\n\n" + "Bill Special's Underground Tour is Seattle’s most unusual attraction, a humorous stroll through intriguing subterranean storefronts and sidewalks entombed when the city rebuilt on top of itself after the Great Fire of 1889.\n\n" +
                    "2) Capitol Hill\n\n" + "Capitol Hill is a densely populated residential district. It is one of the city's most prominent nightlife and entertainment districts and is the center of the city's LGBT and counterculture communities.\n\n" +
                    "3) Six Seven Restaurant\n\n" + "The award-winning Six Seven features seasonally inspired cuisine crafted with only the freshest and finest organic and naturally raised ingredients, procured for you to enjoy via our Executive Chef Jesse Souza's new and exciting menus.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Buffalo Activities
                new Activity
                {
                    //activities for Buffalo with family and outdoors 
                    ID = 5,
                    CityID = 2,
                    Name = "1) Buffalo Zoo\n\n" + "Each year, the Buffalo Zoo welcomes approximately 400,000 visitors and is the second largest tourist attraction in Western New York.\n\n" +
                    "2) Buffalo Harbor State Park\n\n" + "Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park.\n\n" +
                    "3) Canalside\n\n" + "Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Buffalo without family and outdoors 
                    // info from: https://www.onlyinyourstate.com/new-york/buffalo/free-outdoor-activities-buffalo/
                    // info from: https://www.tripadvisor.com/Attraction_Review-g60974-d7396332-Reviews-Buffalo_Pedal_Tours-Buffalo_New_York.html
                    ID = 6,
                    CityID = 2,
                    Name = "1) Niagara Falls\n\n" + "One of the world's most awe-inspiring waterfalls. Just about 20 miles north of Buffalo, Niagara Falls makes for a great day trip.\n\n" +
                    "2) Buffalo and Erie County Botanical Gardens\n\n" + "The Botanical Gardens is an education center and tourist destination full of exotic horticulture treasures from around the world." + "Come enjoy the amazing architecture and the indoor and outdoor garden sanctuaries.\n\n " +
                    "3) Buffalo Pedal Tour\n\n" + "Hop aboard on the Buffalo Pedal Tour, this people powered tour bus or boat for a fun filled time. On land and now on the water!\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Buffalo with family and indoors 
                    ID = 7,
                    CityID = 2,
                    Name = "1) Pierce-Arrow Museum\n\n" + "This unique museum focuses on Buffalo's transportation history featuring Pierce Arrow, Thomas Flyer, electric vehicles, vintage bicycles, motorcycles, muscle cars and trucks, many made in Western New York.\n\n " +
                    "2) Theodore Roosevelt Inaugural National Historic Site\n\n" + "Come tour the historical neighborhoods and enojoy the exhibits of Roosevelt's life!\n\n " +
                    "3) Buffalo Museum of Science\n\n" + "The Buffalo Museum of Science offers educational and exciting experiences the whole family can enjoy!\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Buffalo without family and indoors 
                    ID = 8,
                    CityID = 2,
                    Name = "1) Flying Bison Brewing Company\n\n" + "The music, food and beer at Flying Bison are on point. If you enjoy local brews this is the place you must stop by!\n\n" +
                    "2) Buffalo & Erie County Naval & Military Park\n\n" + "There are 3 ships displayed at the Buffalo & Erie County Naval & Military Park. The exhibits displayed date back to the First World War.\n\n" +
                    "3) Burchfield Penney Art Center\n\n" + "This is the only museum dedicated exclusively to the art and artists of Western New York.\n\n ",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Los Angeles Activities
                new Activity
                {
                    //activities for Los Angeles with family and outdoors 
                    ID = 9,
                    CityID = 3,
                    Name = "1) Speed Zone\n\n" + "It's your chance of steering and speed at Speed Zone’s four go-kart tracks! Don't forget to Electric Alley’s arcade of over 100 video games!\n\n" +
                    "2) Los Angeles County Arboretum & Botanical Garden\n\n" + "These gorgeous grounds in Arcadia, very close to the Santa Anita racetrack, have been designed as an educational facility.\n\n" +
                    "3) Temescal Gateway Park\n\n" + "The loop at Temescal Canyon winds through a densely wooded, well-maintained trail with sweeping ocean views and a seasonal waterfall.\n\n ",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Los Angeles without family and outdoors 
                    ID = 10,
                    CityID = 3,
                    Name = "1) Sail to Catalina Island to Snorkel\n\n" + "This is a great day-trip option for those looking to escape the city crowds and enjoy the sea view.\n\n" +
                    "2) Summit Mount Bald\n\n" + "Mount Baldy is the highest peak in Los Angeles County. If you love hiking, you should definitely hike Mount Baldy!\n\n" +
                    "3) Visit Joshua Tree National Park\n\n" + "Spend a couple of days bouldering among Martian-looking landscapes and exploring the palm-fringed oases.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Los Angeles with family and indoors 
                    ID = 11,
                    CityID = 3,
                    Name = "1) Madame Tussauds Hollywood\n\n" + "The life-like wax figures you’ll find at the museum are so real looking. There are 100+ wax figures here!\n\n" +
                    "2) Cabrillo Marine Aquarium\n\n" + "Featuring over 200 species of marine animals that live in the Southern California region, the Cabrillo is number one of its class.\n\n" +
                    "3) Dolby Theatre Guided Tour\n\n" + "You’ll will see areas of the theatre not seen on TV, plus get a behind-the-scenes look at where lots of popular events take place.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },                
                new Activity
                {
                    //activities for los angeles without family and indoors 
                    ID = 12,
                    CityID = 3,
                    Name = "1) Studio Tours\n\n" + "Come visit a real working studio and see behind-the-scenes of how Hollywood works.\n\n" +
                    "2) K1 Speed Indoor Karting\n\n" + "High-performance, zero-emission cars equipped with the newest technology make K1 Speed one of the premier places to go in LA!\n\n" +
                    "3) Grammy Museum\n\n" + "The Grammy Museum has impressive collection of artifacts, exhibits, films, and more.\n\n ",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Orlando Activities
                new Activity
                {
                    //activities for Orlando with family and outdoors 
                    ID = 13,
                    CityID = 4,
                    Name = "1) Discovery Cove\n\n" + "Discovery Cove is a one-of-a kind experience where you can interact with bottlenose dolphins, feed tropical birds, play inches from a family of otters and even walk on the Grand Reef floor-all in one day.\n\n" +
                    "2) Exotic Animal Experience\n\n" + "Exotic Animal Experience is a TOTALLY interactive, hands on experience with exotic animals!\n\n" +
                    "3) Walt Disney World\n\n" + "Walt Disney World Resort features four theme parks with interactive rides, animal adventures, magical attractions and many more!\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Orlando without family and outdoors 
                    ID = 14,
                    CityID = 4,
                    Name = "1) Kayak Tours at Central Florida\n\n" + "From rivers to lakes to breathtaking sparkling springs, there are so many waterways to explore in Central Florida.\n\n" +
                    "2) Orlando Balloon Rides\n\n" + "See Orlando from the air in a different way, on this sunrise hot-air balloon adventure.\n\n" +
                    "3) Falcon Flyboarding\n\n" + "No prior experience is needed! Just after some simple training and you will be souring through the air in no time.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Orlando with family and indoors 
                    ID = 15,
                    CityID = 4,
                    Name = "1) Crayola Experience\n\n" + "Aspiring artists of all ages can enjoy 26 hands-on activities while experiencing the fun of learning and creating with color.\n\n" +
                    "2) iFLY Orlando Indoor Skydiving\n\n" + "Enjoy the feeling of free flight at iFLY Orlando Indoor Skydiving!\n\n" +
                    "3) Sea Life Orlando Aquarium\n\n" + "Soak up incredible views from Orlando’s only 360-degree underwater tunnel!\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Orlando without family and indoors 
                    ID = 16,
                    CityID = 4,
                    Name = "1) Escape Rooms\n\n" + "Teams are locked into a room, and the mission is to escape by using logic, creative thinking and the provided tools to solve puzzles!\n\n" +
                    "2) Virtual Reality Attractions\n\n" + "Escape to realms of pure digital imagination at Orlando’s VR attractions!\n\n" +
                    "3) Wonderworks\n\n" + "This interactive museum has lots of interactive and diverse exhibits that teach while they entertain.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Atlanta Activities
                new Activity
                {
                    //activities for Atlanta with family and outdoors 
                    ID = 17,
                    CityID = 5,
                    Name = "1) River Floating Down The Chattahoochee River\n\n" + "Enjoy the water and sun while paddleboarding, kayaking, canoeing, and floating down the river.\n\n" +
                    "2) Atlanta Botanical Garden\n\n" + "The onset of spring brings a fresh crop of blooming flowers at the Atlanta Botanical Garden that you can't see year-round.\n\n" +
                    "3) Six Flags Theme Park\n\n" + "Get ready to dive into the largest expansion in park history at Six Flags Over Georgia with the all-new Hurricane Harbor water park!\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Atlanta without family and outdoors 
                    ID = 18,
                    CityID = 5,
                    Name = "1) Trek Up Stone Mountain\n\n" + "Follow the yellow-painted line to the top of Stone Mountain, one of Georgia's most-visited attractions, for an incredible view of downtown Atlanta and the North Georgia mountains.\n\n" +
                    "2) Porsche Experience Center\n\n" + "With a fleet of over 75 new model vehicles and Porsche Drive Coaches to navigate you through the 1.6 mile handling circuit, the Porsche Experience Center may be the world's greatest test drive.\n\n" +
                    "3) Hike to the Waterfalls at the Warwoman Dell Trail\n\n" + "The eponymous trail and the Bartram Trail travel along a pebble-lined stream, through densely green forests, and past a pastiche of wildflowers and ferns.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Atlanta with family and indoors 
                    ID = 19,
                    CityID = 5,
                    Name = "1) World of Coca-Cola\n\n" + "Whether you are in town for vacation, planning a staycation with the family, or just looking for a fun weekend outing, the World of Coca-Cola is a great place to start.\n\n" +
                    "2) LEGOLAND Discovery Center – Atlanta\n\n" + "A LEGOLAND Discovery Center ticket includes access to several LEGO-themed rides, the 4D cinema, and all the rest of the LEGO attractions.\n\n" +
                    "3) X-Drenaline\n\n" + "This trampoline park has everything your kids need to work off some pent-up energy.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Atlanta without family and indoors 
                    ID = 20,
                    CityID = 5,
                    Name = "1) Atlanta Brewing Company\n\n" + "Established in 1993, Atlanta Brewing Co was Georgia’s first craft brewery.\n\n" +
                    "2) Martin Luther King Jr. National Historic Site\n\n" + "This is a major Atlanta attraction, the park draws some 500,000 visitors each year.\n\n" +
                    "3) Fernbank\n\n" + "Discover a World of Wow at Fernbank, Atlanta's Science and Nature Experience.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Denver Activities
                new Activity
                {
                    //activities for Denver with family and outdoors 
                    ID = 21,
                    CityID = 6,
                    Name = "1) Visit an Asian Village Populated by Elephants at Denver Zoo\n\n" + "The Denver Zoo's phenomenal Toyota Elephant Passage offers you the chance to get up close and personal with some amazing animals, all in an extremely cool setting designed to look like a rustic Asian village.\n\n" +
                    "2) See Large Carnivores at Wild Animal Sanctuary\n\n" + "The Wild Animal Sanctuary is a 720-acre rescue and educational facility where more than 350 animals rescued from dire situations now roam free.\n\n" +
                    "3) Take a Bike Ride on 85 Miles of Paths\n\n" + "With 85 miles of bike trails and 300 days of sunshine, Denver is a cycling paradise.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Denver without family and outdoors 
                    ID = 22,
                    CityID = 6,
                    Name = "1) Take a Thrilling Zip Line Tour\n\n" + "Soar along on 1.5 miles of zip line at speeds of up to 50 miles per hour, climb a 42-foot climbing wall and return via 'adrenaline jumping stations' or a 'kamikaze zip' straight to the ground.\n\n" +
                    "2) Take a Hot Air Balloon Ride\n\n" + "Enjoy spectacular views of the majestic Rockies as you float high above the Front Range.\n\n" +
                    "3) Whitewater Rafting\n\n " + "There are lots of companies offering rafting along beautiful Clear Creek in Idaho Springs and the Arkansas River at the Royal Gorge.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Denver with family and indoors 
                    ID = 23,
                    CityID = 6,
                    Name = "1) Swim with Sharks at Downtown Aquarium\n\n" + "There are more than 15,000 fish, mammals and plants at the Downtown Aquarium — and you can do more than gaze at them through the glass.\n\n" +
                    "2) Wings Over the Rockies Air & Space Museum\n\n" + "The museum preserves the history of Lowry AFB's operations from 1938 to 1994 in its collections, archives, and research library. Features of the museum's collection include the USAF's B-1A Lancer and B-52 Stratofortress bombers and many other military and general aviation aircraft.\n\n" +
                    "3) Denver Art Museum\n\n" + "The Denver Art Museum's collection includes more than 70000 works of art.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Denver without family and indoors 
                    ID = 24,
                    CityID = 6,
                    Name = "1) Stranahan's Colorado Whiskey Tour\n\n" + "Who doesn't love to taste shots and keeping the shot glass as a memento? If you love whiskey this is the place for you!\n\n" +
                    "2) Forney Museum of Transportation\n\n" + "The Forney Museum of Transportation is a one-of-a-kind collection of over 600 artifacts relating to historical transportation.\n\n" +
                    "3) Balistreri Vineyards\n\n" + "Their award-winning wines are traditionally handcrafted, without addition of sulfites or other chemicals. The tastingroom and vineyard is located just 10 minutes from downtown Denver!\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region New Delhi Activities
                new Activity
                {
                    //activities for New Delhi with family and outdoors 
                    ID = 25,
                    CityID = 7,
                    Name = "1) Taj Mahal\n\n" + "Taj Mahal is an ivory-white marble Islamic mausoleum. It was commissioned in 1632 by the Mughal emperor Shah Jahan to house the tomb of his favourite wife.\n\n" +
                    "2) National Zoological Park of Delhi\n\n" + "National Zoological Park is a 176-acre zoo near the Oldfort in Delhi. The zoo can be seen on foot or using a battery-operated vehicle which can be rented at the zoo.\n\n" +
                    "3) Go boating at the Old Fort\n\n" + "The Old Fort, or Purana Qila as called locally, has a quaint boating area set amidst the ruins of the Fort and the Delhi Zoo as a boundary.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },                
                new Activity
                {
                    //activities for New Delhi without family and outdoors 
                    ID = 26,
                    CityID = 7,
                    Name = "1) Akshardham Temple\n\n" + "A place of worship, complete with exhibits, boat rides, water shows and lush gardens, the Akshardham temple situated in East Delhi is unlike any other, not only in India but the entire world.\n\n" +
                    "2) Jama Masjid\n\n" + "The largest Islamic mosque in the city, Jama Masjid, was constructed way back in the 17th century. The imposing building is an iconic landmark of Old Delhi and an important place of worship.\n\n" +
                    "3) Chhatarpur Temple\n\n" + "Located in South Delhi, the group of temples known as Chhatarpur are the second largest of their kind in India. The temple is dedicated to the Goddess Katyayani (Durga) and is made entirely of marble.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for New Delhi with family and indoors 
                    ID = 27,
                    CityID = 7,
                    Name = "1) National Mesuem - New Delhi\n\n" + "The collection consists of about 200,000 objects, mainly from the Indus Valley Civilization dating as far back as 2,500 BC.\n\n" +
                    "2) India Habitat Center\n\n" + "The India Habitat Center has frequent classical music and dance concerts. Come and experience Indian classical and folk music, dance and drama.\n\n" +
                    "3) Kingdom of Dreams\n\n" + "Get out of Delhi for the day and take a trip to one of India's best theme parks, the spectacular Kingdom of Dreams.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {//activities for New Delhi without family and indoors 
                    ID = 28,
                    CityID = 7,
                    Name = "1) Gurudwara Bangla Sahib\n\n" + "This is the place you must visit. The amazing Sikh Religion Temple is a beautiful building with a rich Sikh religious culture.\n\n" +
                    "2) ISKCON Temple Delhi\n\n" + "ISKCON as a transcendental mission with a strong philosophical and culture base, Popularly Known with Hare Krishna Movement.\n\n" +
                    "3) Spa Treatment at Shangri La's Eros Hotel\n\n" + "The Spa at the Shangri La's Eros Hotel is an exception. It focuses on traditional techniques from Asian cultures.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Paris Activities
                new Activity
                {
                    //activities for Paris with family and outdoors 
                    ID = 29,
                    CityID = 8,
                    Name = "1) Jardin des Plantes\n\n" + "Considered France's principle botanical garden, the Jardin des Plantes was established in the 17th century under the reign of Louis XIII.\n\n" +
                    "2) Jardin D'Acclimatation\n\n" + "This is zoological park with many other attractions including the Exploradome, merry-go-rounds and puppet shows.\n\n" +
                    "3) Eiffel Tower\n\n" + "The Eiffel Tower is a wrought-iron lattice tower on the Champ de Mars in Paris, France.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Paris without family and outdoors 
                    ID = 30,
                    CityID = 8,
                    Name = "1) L'Arc de Triomphe\n\n" + "This symbol of French victory was commissioned by Napoleon and completed in 1836.\n\n" +
                    "2) Canal Cruising\n\n" + "A cruise from the Bastille marina towards the Marne river will take you to those bucolic open air dance halls.\n\n" +
                    "3) Sacre Coeur De Montmartre\n\n" + "Located on the highest peak of Paris, the view from the Sacré Coeur is breathtaking.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Paris with family and indoors 
                    ID = 31,
                    CityID = 8,
                    Name = "1) Jardin des Plantes\n\n" + "The most famous greenhouse in Paris is Grandes Serres in the Jardin des Plantes. The plants are kept warm all year round, which make the greenhouses a welcoming retreat from inclement weather.\n\n" +
                    "2) Paris Aquarium\n\n" + "With 43 tanks, more than 10,000 fish and invertebrates, and 25 sharks, there is a veritable bounty of delightful sights.\n\n" +
                    "3) Relax in a Turkish Bath\n\n" + "Paris has warmly embraced the tradition of languorous baths, particularly Turkish baths, also known as ‘hammams.’ These steam baths will warm your tired bones, and are often accompanied by a full-body scrub.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Paris without family and indoors 
                    ID = 32,
                    CityID = 8,
                    Name = "1) Walk Through a Haunted House\n\n" + "This haunted house makes a thoroughly spooky, and thoroughly fun, retreat from bad weather. \n" +
                    "2) Indulge in Hot Chocolate and Tea Rooms\n\n" + "Paris’ most famous spot for hot chocolate is Angelina’s. This is a tea house which has almost pudding-like hot chocolate and Belle Époque decor.\n\n" +
                    "3) The Catacombs\n\n" + "The Catacombs are one of Paris’ most unsettling and fascinating sights.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Seoul Activities
                new Activity
                {
                    //activities for Seoul with family and outdoors 
                    ID = 33,
                    CityID = 9,
                    Name = "1) Children’s Grand Park\n\n" + "Children’s Grand Park is one of the more famous family spots in Seoul, featuring a zoo, an amusement park, and plenty of paths for strolling.\n\n" +
                    "2) Bukhansan National Park\n\n" + "One of the most popular pastimes in Seoul is hiking and this stunning national park just outside the city is a local favorite. Aside from a variety of hiking trails for every skill level, you’ll also see lots of flora and fauna, temples and ancient fortresses.\n\n" +
                    "3) Visit Rabbit Park\n\n" + "This amazing park is located in the trendy french neighborhood Seorae Village. Check out the nearby area for great bakeries, wine bars, and better yet a park filled with friendly rabbits!\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Seoul without family and outdoors 
                    ID = 34,
                    CityID = 9,
                    Name = "1) Enjoy the scene at Hangang River\n\n" + "The Hangang River is the most important physical landmark in the city. Lined with parks and recreational facilities on both banks, it’s the perfect place to rent bikes, go on cruise up the river, enjoy bird-watching, or splash around and cool off in public swimming pools during the summer months.\n\n" +
                    "2) Hike the Mountain Baegaksan\n\n" + "Mt.Baegaksan is a 342-meter high granite mountain in the middle of Seoul and is home to Gyeongbokgung Palace and a Joseon Dynasty fortress.\n\n" +
                    "3) Myeongdong Real Gun Shooting Range\n\n" + "The Myeongdong Real Gun Shooting Range is an indoor live firing range located in Myeong-dong. With over a 100 firearms to choose from, visitors can try their best to shoot at targets with a real gun.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Seoul with family and indoors 
                    ID = 35,
                    CityID = 9,
                    Name = "1) Visit the COEX Aquarium\n\n" + "The COEX Aquarium consists of 183 display tanks and 90 breeding tanks with over 3,500 tons of water volume. 40.000 animals from 650 different species live here.\n\n" +
                    "2) Take funny photos at the Trick Eye Museum\n\n" + "The Trick Eye Museum is an artistic game of sorts which uses distorted perspectives and scientific calculations to transform well-known paintings in optically amusing ones.\n\n" +
                    "3) See the legendary Nanta Cooking Show\n\n" + "Nanta is the first non-verbal performance produced in Korea that comically depicts happenings in the kitchen by integrating Korea’s traditional rhythm, 'Samulnori'.\n\n",

                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Seoul without family and indoors 
                    ID = 36,
                    CityID = 9,
                    Name = "1) Jjimjilbang Hot Sauna\n\n" + "Jjimjilbang is deeply integrated with Korean culture. Locals enjoy going to the hot saunas, taking rejuvenating baths and getting body scrubs and massages.\n\n" + "2) Get Creative!\n\n" + "In Seoul, you can visit a ring making café and craft your own rings! You can also create your own perfume or visit a cake shop and decorate your own cake!\n\n" +
                    "3) Discover Korea’s Bang Culture\n\n " + "If you spontaneously want to have a crazy dancing and singing party with your friends, you can rent a Noraebang (Karaoke room) for a few dollars and be the star of your own concert.\n\n",

                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Moscow Activities
                new Activity
                {
                    //activities for Moscow with family and outdoors 
                    ID = 37,
                    CityID = 10,
                    Name = "1) activity with family outdoors placeholder #1. \n" +
                    "2) activity with family outdoors placeholder #2. \n" +
                    "3) activity with family outdoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Moscow without family and outdoors 
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
                    //activities for Moscow with family and indoors 
                    ID = 39,
                    CityID = 10,
                    Name = "1) activity with family indoors placeholder #1. \n" +
                    "2) activity with family indoors placeholder #2.\n" +
                    "3) activity with family indoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Moscow without family and indoors 
                    ID = 40,
                    CityID = 10,
                    Name = "1) activity without family indoors placeholder #1. \n" +
                    "2) activity without family indoors placeholder #2.\n" +
                    "3) activity without family indoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Reykjavik Activities
                new Activity
                {
                    //activities for Reykjavík with family and outdoors 
                    ID = 41,
                    CityID = 11,
                    Name = "1) activity with family outdoors placeholder #1. \n" +
                    "2) activity with family outdoors placeholder #2. \n" +
                    "3) activity with family outdoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 1
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
                    //activities for Reykjavík with family and indoors 
                    ID = 43,
                    CityID = 11,
                    Name = "1) activity with family indoors placeholder #1. \n" +
                    "2) activity with family indoors placeholder #2.\n" +
                    "3) activity with family indoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Reykjavík without family and indoors 
                    ID = 44,
                    CityID = 11,
                    Name = "1) activity without family indoors placeholder #1. \n" +
                    "2) activity without family indoors placeholder #2.\n" +
                    "3) activity without family indoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Helsinki Activities
                new Activity
                {
                    //activities for Helsinki with family and outdoors 
                    ID = 45,
                    CityID = 12,
                    Name = "1) activity with family outdoors placeholder #1. \n" +
                    "2) activity with family outdoors placeholder #2. \n" +
                    "3) activity with family outdoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Helsinki without family and outdoors 
                    ID = 46,
                    CityID = 12,
                    Name = "1) activity without family outdoors placeholder #1. \n" +
                    "2) activity without family outdoors placeholder #2.\n" +
                    "3) activity without family outdoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Helsinki with family and indoors 
                    ID = 47,
                    CityID = 12,
                    Name = "1) activity with family indoors placeholder #1. \n" +
                    "2) activity with family indoors placeholder #2.\n" +
                    "3) activity with family indoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Helsinki without family and indoors 
                    ID = 48,
                    CityID = 12,
                    Name = "1) activity without family indoors placeholder #1. \n" +
                    "2) activity without family indoors placeholder #2.\n" +
                    "3) activity without family indoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 0
                },
            #endregion
            #region Phuket Activities
                new Activity
                {
                    //activities for Phuket with family and outdoors 
                    ID = 49,
                    CityID = 13,
                    Name = "1) activity with family outdoors placeholder #1. \n" +
                    "2) activity with family outdoors placeholder #2. \n" +
                    "3) activity with family outdoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Phuket without family and outdoors 
                    ID = 50,
                    CityID = 13,
                    Name = "1) activity without family outdoors placeholder #1. \n" +
                    "2) activity without family outdoors placeholder #2.\n" +
                    "3) activity without family outdoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 1
                },
                new Activity
                {
                    //activities for Phuket with family and indoors 
                    ID = 51,
                    CityID = 13,
                    Name = "1) activity with family indoors placeholder #1. \n" +
                    "2) activity with family indoors placeholder #2.\n" +
                    "3) activity with family indoors placeholder #3.\n ",
                    FamilyFriendly = 1,
                    Outdoors = 0
                },
                new Activity
                {
                    //activities for Phuket without family and indoors 
                    ID = 52,
                    CityID = 13,
                    Name = "1) activity without family indoors placeholder #1. \n" +
                    "2) activity without family indoors placeholder #2.\n" +
                    "3) activity without family indoors placeholder #3.\n ",
                    FamilyFriendly = 0,
                    Outdoors = 0
                }
                #endregion
               );
        }
        public DbSet<City> City { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Plan> SavedVacation { get; set; }
    }
}