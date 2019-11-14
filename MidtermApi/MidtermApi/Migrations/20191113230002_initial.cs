using Microsoft.EntityFrameworkCore.Migrations;

namespace MidtermApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Hot = table.Column<bool>(nullable: false),
                    InUSA = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FamilyFriendly = table.Column<bool>(nullable: false),
                    Outdoors = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Activity_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                table: "City",
                columns: new[] { "ID", "Description", "Hot", "ImageURL", "InUSA", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, mountains and evergreen forests, and contains thousands of acres of parkland. Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark.", false, "", true, "Seattle, Washington", 2 },
                    { 2, "Buffalo is a city on the shores of Lake Erie in upstate New York. Its fine neoclassical, beaux arts and art deco architecture speaks to its history as an industrial capital in the early 20th century. Its landmarks include the 398-ft art deco City Hall, the Frank Lloyd Wright–designed Darwin D. Martin House and the Albright-Knox Art Gallery, a Greek Revival museum with works by Picasso and Warhol.", false, "", true, "Buffalo, New York", 1 },
                    { 3, "Los Angeles is a sprawling Southern California city and the center of the nation’s film and television industry. Near its iconic Hollywood sign, studios such as Paramount Pictures, Universal and Warner Brothers offer behind-the-scenes tours. On Hollywood Boulevard, TCL Chinese Theatre displays celebrities’ hand- and footprints, the Walk of Fame honors thousands of luminaries and vendors sell maps to stars’ homes.", true, "", true, "Los Angeles, California", 3 },
                    { 4, "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India. The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.", true, "", false, "New Delhi, India", 1 },
                    { 5, "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.", true, "", false, "Paris, France", 3 },
                    { 6, "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.", true, "", false, "Seoul, South Korea", 2 },
                    { 7, "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.", false, "", false, "Moscow, Russia", 2 }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ID", "CityID", "FamilyFriendly", "Name", "Outdoors" },
                values: new object[,]
                {
                    { 1, 1, true, @"1) Visit the Space Needle 
                 2) Ride the Duck 
                 3) Tour Pike Place Market 
                ", true },
                    { 9, 5, false, @"1) Test 1 activity 
                2) Test 2 acivity.
                3) Test 3 activity.
                 ", false },
                    { 8, 2, false, @"1) Take a tour of Seattle underground with Bill Speidel's Underground Tour. 
                2) Get some drinks at some great bars on Capitol Hill.
                3) Get a bite to eat with a great view at the Six Seven Restaurant.
                 ", false },
                    { 7, 2, true, @"1) Visit the Buffalo Museum of Science.
                 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront.
                 3) Visit the Pacific Science Center.
                 ", false },
                    { 5, 2, true, @"1) Visit the Buffalo Zoo 
                 2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park. 
                 3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.
                ", true },
                    { 6, 2, false, @"1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle 
                2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.
                 3) Visit REI in downtown Seattle and try Rock Climbing 
                ", true },
                    { 4, 1, false, @"1) Take a tour of Seattle underground with Bill Speidel's Underground Tour. 
                2) Get some drinks at some great bars on Capitol Hill.
                3) Get a bite to eat with a great view at Six Seven Restaurant.
                 ", false },
                    { 3, 1, true, @"1) Visit the Seattle Art Museum in downtown Seattle.
                 2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront.
                 3) Visit the Pacific Science Center.
                 ", false },
                    { 2, 1, false, @"1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle 
                2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.
                 3) Visit REI in downtown Seattle and try Rock Climbing 
                ", true }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "CityID", "Name", "Price" },
                values: new object[,]
                {
                    { 17, 6, "Tmark Hotel Myeongdong", 2 },
                    { 19, 7, "Winterfell Hotel Tverskaya", 1 },
                    { 12, 4, "Hotel Diplomat", 2 },
                    { 16, 6, "Hongdae Chef Guesthouse", 1 },
                    { 15, 5, "InterContinental Paris", 3 },
                    { 14, 5, "Holiday Inn Paris", 2 },
                    { 13, 5, "Le Regent Montmarte", 1 },
                    { 18, 6, "Park Hyatt Seoul", 3 },
                    { 11, 4, "Haveli Dharampura", 3 },
                    { 7, 3, "Monterey Inn", 1 },
                    { 9, 3, "The Ritz-Carlton, Los Angeles", 3 },
                    { 8, 3, "Freehand Los Angeles", 2 },
                    { 20, 7, "Hilton Garden Inn Moscow Krasnoselskaya", 2 },
                    { 6, 2, "Curtiss Hotel", 3 },
                    { 5, 2, "Millennium Buffalo", 2 },
                    { 4, 2, "Motel 6 Buffalo Airport", 1 },
                    { 3, 1, "Four Seasons Hotel", 3 },
                    { 2, 1, "Hilton Seattle", 2 },
                    { 1, 1, "Roy Street Commons", 1 },
                    { 10, 4, "Suites Admiral", 1 },
                    { 21, 7, "The St. Regis Moscow Nikolskaya", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_CityID",
                table: "Activity",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityID",
                table: "Hotel",
                column: "CityID");

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
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
