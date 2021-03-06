﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MidtermApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FamilyFriendly = table.Column<int>(nullable: false),
                    Outdoors = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Hot = table.Column<int>(nullable: false),
                    InUSA = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SavedVacation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(nullable: true),
                    HotelID = table.Column<int>(nullable: true),
                    ActivityID = table.Column<int>(nullable: true),
                    RecommendationCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedVacation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SavedVacation_Activity_ActivityID",
                        column: x => x.ActivityID,
                        principalTable: "Activity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedVacation_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedVacation_Hotel_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ID", "CityID", "FamilyFriendly", "Name", "Outdoors" },
                values: new object[,]
                {
                    { 1, 1, 1, @"1) This is it. You’re about to walk into a memory. Soaring 520 feet skyward. The city actually, really, truly at your feet. Step up. Step out. Step beyond your comfort zone. And experience wonder on a higher level. Visit the Space Needle in the heart of Seattle. 
                 2) When you and your friends arrive in Seattle by plane, cruise ship, car or Seattle-style bicycle, 'Ride the Ducks of Seattle' should be your first stop. In ninety minutes, you’ll see the top sights and hear about how the city developed into the tech-coffee-expensive-real-estate hub it is today. Before you start drinking your double tall, extra foam, skinny vanilla latte or posting photos when “the mountain’s out,” enjoy all that makes Seattle famous on the tour that was rated #1 City Tour for more than a decade.3) One of the few authentic farmer's markets in the United States, this hub of delicious scents, delectable eats and delightful personalities attracts nine million visitors a year. Take a tour of Pike Place Market and find outwhy this market has become a staple in Seattle. 
                ", 1 },
                    { 30, 8, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 31, 8, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 32, 8, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 33, 9, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 34, 9, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 35, 9, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 36, 9, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 37, 10, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 38, 10, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 39, 10, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 28, 7, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 40, 10, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 42, 11, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 43, 11, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 44, 11, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 45, 12, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 46, 12, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 47, 12, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 48, 13, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 49, 13, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 50, 13, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 51, 13, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 41, 11, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 27, 7, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 29, 8, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 25, 7, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 2, 1, 0, @"1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle 
                2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.
                 3) Visit REI in downtown Seattle and try your luck at Rock Climbing 
                ", 1 },
                    { 3, 1, 1, "1) Visit the Seattle Art Museum in downtown Seattle._ 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront._ 3) Visit the Pacific Science Center.", 0 },
                    { 4, 1, 0, "1) Take a tour of Seattle underground with Bill Speidel's Underground Tour._ 2) Get some drinks at some great bars on Capitol Hill._ 3) Get a bite to eat with a great view at Six Seven Restaurant.", 0 },
                    { 5, 2, 1, "1) Visit the Buffalo Zoo._ 2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park._ 3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.", 1 },
                    { 6, 2, 0, @"1) Hop aboard on the Buffalo Pedal Tour, this people powered tour bus or boat for a fun filled time. On land and now on the water! Our professional drivers will guide you and your friends through the streets of Buffalo as you provide the energy by pedaling. 
                2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.
                 3) Activity without family outdoors placeholder 
                ", 1 },
                    { 7, 2, 1, @"1) activity with family indoors placeholder #1.
                 2) activity with family indoors placeholder #2.
                 3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 8, 2, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 9, 3, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 10, 3, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 26, 7, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 12, 3, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 13, 4, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 11, 3, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 15, 4, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 24, 6, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 14, 4, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 22, 6, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 21, 6, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 23, 6, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 19, 5, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 18, 5, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 17, 5, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 16, 4, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 20, 5, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "ID", "Description", "Hot", "ImageURL", "InUSA", "Name", "Price" },
                values: new object[,]
                {
                    { 9, "Atlanta is the capital of the U.S. state of Georgia. It played an important part in both the Civil War and the 1960s Civil Rights Movement. Atlanta History Center chronicles the city's past, and the Martin Luther King Jr. National Historic Site is dedicated to the African-American leader’s life and times. Downtown, Centennial Olympic Park, built for the 1996 Olympics, encompasses the massive Georgia Aquarium.", 1, "", 1, "Atlanta, Georgia", 1 },
                    { 13, "Phuket, a rainforested, mountainous island in the Andaman Sea, has some of Thailand’s most popular beaches, mainly situated along the clear waters of the western shore. The island is home to many high-end seaside resorts, spas and restaurants. Phuket City, the capital, has old shophouses and busy markets. Patong, the main resort town, has many nightclubs, bars and discos.", 1, "", 0, "Phuket, Thailand", 2 },
                    { 12, "Helsinki, Finland’s southern capital, sits on a peninsula in the Gulf of Finland. Its central avenue, Mannerheimintie, is flanked by institutions including the National Museum, tracing Finnish history from the Stone Age to the present. Also on Mannerheimintie are the imposing Parliament House and Kiasma, a contemporary art museum. Ornate red-brick Uspenski Cathedral overlooks a harbor.", 0, "", 0, "Helsinki, Finland", 1 },
                    { 11, "Reykjavik, on the coast of Iceland, is the country's capital and largest city. It's home to the National and Saga museums, tracing Iceland’s Viking history. The striking concrete Hallgrimskirkja church and rotating Perlan glass dome offer sweeping views of the sea and nearby hills. Exemplifying the island’s volcanic activity is the geothermal Blue Lagoon spa, near the village of Grindavik.", 0, "", 0, "Reykjavík, Iceland", 3 },
                    { 10, "Denver, the capital of Colorado, is an American metropolis dating to the Old West era. Larimer Square, the city’s oldest block, features landmark 19th-century buildings. Museums include the Denver Art Museum, an ultramodern complex known for its collection of indigenous works, and the mansion of famed Titanic survivor Molly Brown. Denver is also a jumping-off point for ski resorts in the nearby Rocky Mountains.", 0, "", 1, "Denver, Colorado", 1 },
                    { 8, "Orlando, a city in central Florida, is home to more than a dozen theme parks. Chief among its claims to fame is Walt Disney World, comprised of parks like the Magic Kingdom and Epcot, as well as water parks. Another major destination, Universal Orlando, offers Universal Studios and Islands of Adventure, with the Wizarding World of Harry Potter straddling both.", 1, "", 1, "Orlando, Florida", 2 },
                    { 1, "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, mountains and evergreen forests, and contains thousands of acres of parkland. Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark. ", 0, "", 1, "Seattle, Washington", 2 },
                    { 6, "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.", 1, "", 0, "Seoul, South Korea", 2 },
                    { 5, "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.", 1, "", 0, "Paris, France", 3 },
                    { 4, "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India. The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.", 1, "", 0, "New Delhi, India", 1 },
                    { 3, "Los Angeles is a sprawling Southern California city and the center of the nation’s film and television industry. Near its iconic Hollywood sign, studios such as Paramount Pictures, Universal and Warner Brothers offer behind-the-scenes tours. On Hollywood Boulevard, TCL Chinese Theatre displays celebrities’ hand- and footprints, the Walk of Fame honors thousands of luminaries and vendors sell maps to stars’ homes.", 1, "", 1, "Los Angeles, California", 3 },
                    { 2, "Buffalo is a city on the shores of Lake Erie in upstate New York. Its fine neoclassical, beaux arts and art deco architecture speaks to its history as an industrial capital in the early 20th century. Its landmarks include the 398-ft art deco City Hall, the Frank Lloyd Wright–designed Darwin D. Martin House and the Albright-Knox Art Gallery, a Greek Revival museum with works by Picasso and Warhol.", 0, "", 1, "Buffalo, New York", 1 },
                    { 7, "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.", 0, "", 0, "Moscow, Russia", 2 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "CityID", "Name", "Price" },
                values: new object[,]
                {
                    { 21, 7, "The St. Regis Moscow Nikolskaya", 3 },
                    { 22, 8, "Howard Johnson by Wyndham Lake Front Park Kissimmee", 1 },
                    { 23, 8, "DoubleTree by Hilton Hotel at the Entrance to Universal Orlando", 2 },
                    { 24, 8, "Grand Bohemian Hotel Orlando, Autograph Collection", 3 },
                    { 25, 9, "Super 8 by Wyndham Austell/Six Flags", 1 },
                    { 26, 9, "Crowne Plaza Atlanta-Airport", 2 },
                    { 27, 9, "Four Seasons Hotel Atlanta", 3 },
                    { 28, 10, "Ember Hostel", 1 },
                    { 31, 11, "Reykjavik Downtown HI Hostel", 1 },
                    { 30, 10, "Four Seasons Hotel Denver", 3 },
                    { 32, 11, "Grand Hótel Reykjavík", 2 },
                    { 33, 11, "Kvosin Downtown Hotel", 3 },
                    { 34, 12, "Reykjavik Downtown HI Hostel", 1 },
                    { 35, 12, "Grand Hótel Reykjavík", 2 },
                    { 36, 12, "Kvosin Downtown Hotel", 3 },
                    { 37, 13, "The Bukit", 1 },
                    { 29, 10, "Home2 Suites by Hilton Denver International Airport", 2 },
                    { 20, 7, "Hilton Garden Inn Moscow Krasnoselskaya", 2 },
                    { 17, 6, "Tmark Hotel Myeongdong", 2 },
                    { 18, 6, "Park Hyatt Seoul", 3 },
                    { 38, 13, "Andacura Beachfront collextion Panwa Phuket", 2 },
                    { 1, 1, "Roy Street Commons", 1 },
                    { 2, 1, "Hilton Seattle", 2 },
                    { 3, 1, "Four Seasons Hotel", 3 },
                    { 4, 2, "Motel 6 Buffalo Airport", 1 },
                    { 5, 2, "Millennium Buffalo", 2 },
                    { 6, 2, "Curtiss Hotel", 3 },
                    { 7, 3, "Monterey Inn", 1 },
                    { 8, 3, "Freehand Los Angeles", 2 },
                    { 9, 3, "The Ritz-Carlton, Los Angeles", 3 },
                    { 10, 4, "Suites Admiral", 1 },
                    { 11, 4, "Haveli Dharampura", 3 },
                    { 12, 4, "Hotel Diplomat", 2 },
                    { 13, 5, "Le Regent Montmarte", 1 },
                    { 14, 5, "Holiday Inn Paris", 2 },
                    { 15, 5, "InterContinental Paris", 3 },
                    { 16, 6, "Hongdae Chef Guesthouse", 1 },
                    { 19, 7, "Winterfell Hotel Tverskaya", 1 },
                    { 39, 13, "The Westin Siray Bay Resort & Spa, Phuket", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavedVacation_ActivityID",
                table: "SavedVacation",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedVacation_CityID",
                table: "SavedVacation",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedVacation_HotelID",
                table: "SavedVacation",
                column: "HotelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedVacation");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
