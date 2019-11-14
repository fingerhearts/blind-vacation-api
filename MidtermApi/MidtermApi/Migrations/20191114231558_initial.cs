using Microsoft.EntityFrameworkCore.Migrations;

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
                2) When you and your friends arrive in Seattle by plane, cruise ship, car or Seattle-style bicycle, 'Ride the Ducks of Seattle' should be your first stop. In ninety minutes, you’ll see the top sights and hear about how the city developed into the tech-coffee-expensive-real-estate hub it is today. Before you start drinking your double tall, extra foam, skinny vanilla latte or posting photos when “the mountain’s out,” enjoy all that makes Seattle famous on the tour that was rated #1 City Tour for more than a decade. 
                3) One of the few authentic farmer's markets in the United States, this hub of delicious scents, delectable eats and delightful personalities attracts nine million visitors a year. Take a tour of Pike Place Market and find outwhy this market has become a staple in Seattle. 
                ", 1 },
                    { 29, 8, 1, @"1) Jardin des PlantesConsidered France's principle botanical garden, the Jardin des Plantes was established in the 17th century under the reign of Louis XIII. 
                2) Jardin D'AcclimatationThis is zoological park with many other attractions including the Exploradome, merry-go-rounds and puppet shows. 
                3) Eiffel Tower+ The Eiffel Tower is a wrought-iron lattice tower on the Champ de Mars in Paris, France. 
                ", 1 },
                    { 30, 8, 0, @"1) L'Arc de TriompheThis symbol of French victory was commissioned by Napoleon and completed in 1836. 
                2) Canal CruisingA cruise from the Bastille marina towards the Marne river will take you to those bucolic open air dance halls. 
                3) Sacre Coeur De MontmartreLocated on the highest peak of Paris, the view from the Sacré Coeur is breathtaking. 
                 ", 1 },
                    { 31, 8, 1, @"1) Jardin des PlantesThe most famous greenhouse in Paris is Grandes Serres in the Jardin des Plantes. The plants are kept warm all year round, which make the greenhouses a welcoming retreat from inclement weather. 
                2) Paris Aquarium With 43 tanks, more than 10,000 fish and invertebrates, and 25 sharks, there is a veritable bounty of delightful sights.
                3) Relax in a Turkish BathParis has warmly embraced the tradition of languorous baths, particularly Turkish baths, also known as ‘hammams.’ These steam baths will warm your tired bones, and are often accompanied by a full-body scrub. 
                 ", 0 },
                    { 32, 8, 0, @"1) Walk Through a Haunted HouseThis haunted house makes a thoroughly spooky, and thoroughly fun, retreat from bad weather. 
                2) Indulge in Hot Chocolate and Tea RoomsParis’ most famous spot for hot chocolate is Angelina’s. This is a tea house which has almost pudding-like hot chocolate and Belle Époque decor. 
                3) The CatacombsThe Catacombs are one of Paris’ most unsettling and fascinating sights. 
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
                    { 40, 10, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 41, 11, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
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
                    { 46, 12, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 47, 12, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 48, 12, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 49, 13, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 50, 13, 0, @"1) activity without family outdoors placeholder #1. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 51, 13, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 28, 7, 0, @"1) Gurudwara Bangla SahibThis is the place you must visit. The amazing Sikh Religion Temple is a beautiful building with a rich Sikh religious culture. 
                2) ISKCON Temple DelhiISKCON as a transcendental mission with a strong philosophical and culture base, Popularly Known with Hare Krishna Movement. 
                3) Spa Treatment at Shangri La's Eros HotelThe Spa at the Shangri La's Eros Hotel is an exception. It focuses on traditional techniques from Asian cultures. 
                ", 0 },
                    { 27, 7, 1, @"1) National Mesuem - New DelhiThe collection consists of about 200,000 objects, mainly from the Indus Valley Civilization dating as far back as 2,500 BC. 
                2) India Habitat CenterThe India Habitat Center has frequent classical music and dance concerts. Come and experience Indian classical and folk music, dance and drama. 
                3) Kingdom of DreamsGet out of Delhi for the day and take a trip to one of India's best theme parks, the spectacular Kingdom of Dreams. 
                ", 0 },
                    { 52, 13, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 25, 7, 1, @"1) Taj MahalTaj Mahal is an ivory-white marble Islamic mausoleum. It was commissioned in 1632 by the Mughal emperor Shah Jahan to house the tomb of his favourite wife. 
                2) National Zoological Park of DelhiNational Zoological Park is a 176-acre zoo near the Oldfort in Delhi. The zoo can be seen on foot or using a battery-operated vehicle which can be rented at the zoo. 
                3) Go boating at the Old FortThe Old Fort, or Purana Qila as called locally, has a quaint boating area set amidst the ruins of the Fort and the Delhi Zoo as a boundary. 
                 ", 1 },
                    { 26, 7, 0, @"1) Akshardham templeA place of worship, complete with exhibits, boat rides, water shows and lush gardens, the Akshardham temple situated in East Delhi is unlike any other, not only in India but the entire world. 
                2) Jama MasjidThe largest Islamic mosque in the city, Jama Masjid, was constructed way back in the 17th century. The imposing building is an iconic landmark of Old Delhi and an important place of worship. 
                3) Chhatarpur templeLocated in South Delhi, the group of temples known as Chhatarpur are the second largest of their kind in India. The temple is dedicated to the Goddess Katyayani (Durga) and is made entirely of marble. 
                ", 1 },
                    { 2, 1, 0, @"1) Fly high indoors at IFly. An exiciting indoors skydiving center located only mintues outside of Seattle. 
                2) Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center. 
                3) Visit REI in downtown Seattle and try your luck at Rock Climbing. 
                ", 1 },
                    { 3, 1, 1, @"1) Visit the Seattle Art Museum in downtown Seattle. 
                2) Visit the Seattle Aquarium located on Pier 59 on the Elliott Bay waterfront. 
                3) Visit the Pacific Science Center. 
                ", 0 },
                    { 4, 1, 0, @"1) Take a tour of Seattle underground with Bill Speidel's Underground Tour. 
                2) Get some drinks at some great bars on Capitol Hill. 
                3) Get a bite to eat with a great view at Six Seven Restaurant. 
                ", 0 },
                    { 5, 2, 1, @"1) Visit the Buffalo Zoo. 
                2) Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park. 
                3) Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo. 
                ", 1 },
                    { 6, 2, 0, @"1) Niagara FallsOne of the world's most awe-inspiring waterfalls. Just about 20 miles north of Buffalo, Niagara Falls makes for a great day trip. 
                2) Buffalo and Erie County Botanical GardensThe Botanical Gardens is an education center and tourist destination full of exotic horticulture treasures from around the world.Come enjoy the amazing architecture and the indoor and outdoor garden sanctuaries. 
                 3) Hop aboard on the Buffalo Pedal Tour, this people powered tour bus or boat for a fun filled time. On land and now on the water! Our professional drivers will guide you and your friends through the streets of Buffalo as you provide the energy by pedaling. 
                ", 1 },
                    { 7, 2, 1, @"1) Pierce-Arrow Museum.This unique museum focuses on Buffalo's transportation history featuring Pierce Arrow, Thomas Flyer, electric vehicles, vintage bicycles, motorcycles, muscle cars and trucks, many made in Western New York.
                 2) Theodore Roosevelt Inaugural National Historic Site.Come tour the historical neighborhoods and enojoy the exhibits of Roosevelt's life! 
                 3) Buffalo Museum of ScienceThe Buffalo Museum of Science offers educational and exciting experiences the whole family can enjoy! 
                 ", 0 },
                    { 8, 2, 0, @"1) Flying Bison Brewing CompanyThe music, food and beer at Flying Bison are on point. If you enjoy local brews this is the place you must stop by! 
                2) Buffalo & Erie County Naval & Military ParkThere are 3 ships displayed at the Buffalo & Erie County Naval & Military Park. The exhibits displayed date back to the First World War. 
                3) Burchfield Penney Art CenterThis is the only museum dedicated exclusively to the art and artists of Western New York. 
                 ", 0 },
                    { 9, 3, 1, @"1) Speed ZoneIt's your chance of steering and speed at Speed Zone’s four go-kart tracks! Don't forget to Electric Alley’s arcade of over 100 video games! 
                2) Los Angeles County Arboretum & Botanical Garden.These gorgeous grounds in Arcadia, very close to the Santa Anita racetrack, have been designed as an educational facility. 
                3) Temescal Gateway ParkThe loop at Temescal Canyon winds through a densely wooded, well-maintained trail with sweeping ocean views and a seasonal waterfall. 
                 ", 1 },
                    { 11, 3, 1, @"1) Madame Tussauds HollywoodThe life-like wax figures you’ll find at the museum are so real looking. There are 100+ wax figures here! 
                2) Cabrillo Marine AquariumFeaturing over 200 species of marine animals that live in the Southern California region, the Cabrillo is number one of its class. 
                3) Dolby Theatre Guided TourYou’ll will see areas of the theatre not seen on TV, plus get a behind-the-scenes look at where lots of popular events take place. 
                 ", 0 },
                    { 12, 3, 0, @"1) Studio ToursCome visit a real working studio and see behind-the-scenes of how Hollywood works.
                2) K1 Speed Indoor KartingHigh-performance, zero-emission cars equipped with the newest technology make K1 Speed one of the premier places to go in LA! 
                3) Grammy MuseumThe Grammy Museum has impressive collection of artifacts, exhibits, films, and more. 
                 ", 0 },
                    { 10, 3, 0, @"1) Sail to Catalina Island to SnorkelThis is a great day-trip option for those looking to escape the city crowds and enjoy the sea view. 
                2) Summit Mount BaldyMount Baldy is the highest peak in Los Angeles County. If you love hiking, you should definitely hike Mount Baldy! 
                3) Visit Joshua Tree National ParkSpend a couple of days bouldering among Martian-looking landscapes and exploring the palm-fringed oases. 
                 ", 1 },
                    { 14, 4, 0, @"1) Kayak Tours at Central FloridaFrom rivers to lakes to breathtaking sparkling springs, there are so many waterways to explore in Central Florida. 
                2) Orlando Balloon RidesSee Orlando from the air in a different way, on this sunrise hot-air balloon adventure. 
                3) Falcon FlyboardingNo prior experience is needed! Just after some simple training and you will be souring through the air in no time. 
                ", 1 },
                    { 24, 6, 0, @"1) activity without family indoors placeholder #1. 
                2) activity without family indoors placeholder #2.
                3) activity without family indoors placeholder #3.
                 ", 0 },
                    { 23, 6, 1, @"1) activity with family indoors placeholder #1. 
                2) activity with family indoors placeholder #2.
                3) activity with family indoors placeholder #3.
                 ", 0 },
                    { 22, 6, 0, @"1) Take a Bike Ride on 85 Miles of PathsWith 85 miles of bike trails and 300 days of sunshine, Denver is a cycling paradise. 
                2) activity without family outdoors placeholder #2.
                3) activity without family outdoors placeholder #3.
                 ", 1 },
                    { 13, 4, 1, @"1) Discovery CoveDiscovery Cove is a one-of-a kind experience where you can interact with bottlenose dolphins, feed tropical birds, play inches from a family of otters and even walk on the Grand Reef floor-all in one day. 
                2) Exotic Animal ExperienceExotic Animal Experience is a TOTALLY interactive, hands on experience with exotic animals! 
                3) Walt Disney WorldWalt Disney World Resort features four theme parks with interactive rides, animal adventures, magical attractions and many more! 
                ", 1 },
                    { 20, 5, 0, @"1) Atlanta Brewing CompanyEstablished in 1993, Atlanta Brewing Co was Georgia’s first craft brewery. 
                2) Martin Luther King Jr. National Historic SiteThis is a major Atlanta attraction, the park draws some 500,000 visitors each year. 
                3) FernbankDiscover a World of Wow at Fernbank, Atlanta's Science and Nature Experience. 
                ", 0 },
                    { 21, 6, 1, @"1) activity with family outdoors placeholder #1. 
                2) activity with family outdoors placeholder #2. 
                3) activity with family outdoors placeholder #3.
                 ", 1 },
                    { 18, 5, 0, @"1) Trek Up Stone MountainFollow the yellow-painted line to the top of Stone Mountain, one of Georgia's most-visited attractions, for an incredible view of downtown Atlanta and the North Georgia mountains. 
                2) Porsche Experience CenterWith a fleet of over 75 new model vehicles and Porsche Drive Coaches to navigate you through the 1.6 mile handling circuit, the Porsche Experience Center may be the world's greatest test drive. 
                3) Hike to the Waterfalls at the Warwoman Dell TrailThe eponymous trail and the Bartram Trail travel along a pebble-lined stream, through densely green forests, and past a pastiche of wildflowers and ferns. 
                ", 1 },
                    { 17, 5, 1, @"1) River Floating Down The Chattahoochee RiverEnjoy the water and sun while paddleboarding, kayaking, canoeing, and floating down the river. 
                2) Atlanta Botanical GardenThe onset of spring brings a fresh crop of blooming flowers at the Atlanta Botanical Garden that you can't see year-round. 
                3) Six Flags Theme ParkGet ready to dive into the largest expansion in park history at Six Flags Over Georgia with the all-new Hurricane Harbor water park! 
                ", 1 },
                    { 16, 4, 0, @"1) Escape RoomsTeams are locked into a room, and the mission is to escape by using logic, creative thinking and the provided tools to solve puzzles! 
                2) Virtual Reality AttractionsEscape to realms of pure digital imagination at Orlando’s VR attractions! 
                3) WonderworksThis interactive museum has lots of interactive and diverse exhibits that teach while they entertain.
                 ", 0 },
                    { 15, 4, 1, @"1) Crayola ExperienceAspiring artists of all ages can enjoy 26 hands-on activities while experiencing the fun of learning and creating with color. 
                2) iFLY Orlando Indoor SkydivingEnjoy the feeling of free flight at iFLY Orlando Indoor Skydiving! 
                3) Sea Life Orlando AquariumSoak up incredible views from Orlando’s only 360-degree underwater tunnel! 
                 ", 0 },
                    { 19, 5, 1, @"1) World of Coca-ColaWhether you are in town for vacation, planning a staycation with the family, or just looking for a fun weekend outing, the World of Coca-Cola is a great place to start. 
                2) LEGOLAND Discovery Center – AtlantaA LEGOLAND Discovery Center ticket includes access to several LEGO-themed rides, the 4D cinema, and all the rest of the LEGO attractions. 
                3) X-DrenalineThis trampoline park has everything your kids need to work off some pent-up energy. 
                ", 0 }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "ID", "Description", "Hot", "ImageURL", "InUSA", "Name", "Price" },
                values: new object[,]
                {
                    { 9, "Seoul, the capital of South Korea, is a huge metropolis where modern skyscrapers, high-tech subways and pop culture meet Buddhist temples, palaces and street markets. Notable attractions include futuristic Dongdaemun Design Plaza, a convention hall with curving architecture and a rooftop park; Gyeongbokgung Palace, which once had more than 7,000 rooms; and Jogyesa Temple, site of ancient locust and pine trees.", 1, "https://s.iha.com/00128375786/South-korea-Bongeunsa-temple-in-seoul.jpeg", 0, "Seoul, South Korea", 2 },
                    { 13, "Phuket, a rainforested, mountainous island in the Andaman Sea, has some of Thailand’s most popular beaches, mainly situated along the clear waters of the western shore. The island is home to many high-end seaside resorts, spas and restaurants. Phuket City, the capital, has old shophouses and busy markets. Patong, the main resort town, has many nightclubs, bars and discos.", 1, "https://cdn.pixabay.com/photo/2017/02/21/00/54/beach-2084350_960_720.jpg", 0, "Phuket, Thailand", 2 },
                    { 12, "Helsinki, Finland’s southern capital, sits on a peninsula in the Gulf of Finland. Its central avenue, Mannerheimintie, is flanked by institutions including the National Museum, tracing Finnish history from the Stone Age to the present. Also on Mannerheimintie are the imposing Parliament House and Kiasma, a contemporary art museum. Ornate red-brick Uspenski Cathedral overlooks a harbor.", 0, "https://cdn.pixabay.com/photo/2019/05/08/22/01/helsinki-cathedral-4189824_960_720.jpg", 0, "Helsinki, Finland", 1 },
                    { 11, "Reykjavik, on the coast of Iceland, is the country's capital and largest city. It's home to the National and Saga museums, tracing Iceland’s Viking history. The striking concrete Hallgrimskirkja church and rotating Perlan glass dome offer sweeping views of the sea and nearby hills. Exemplifying the island’s volcanic activity is the geothermal Blue Lagoon spa, near the village of Grindavik.", 0, "https://c1.staticflickr.com/6/5488/9465885222_b14d4e6d6a_b.jpg", 0, "Reykjavík, Iceland", 3 },
                    { 10, "Moscow, on the Moskva River in western Russia, is the nation’s cosmopolitan capital. In its historic core is the Kremlin, a complex that’s home to the president and tsarist treasures in the Armoury. Outside its walls is Red Square, Russia's symbolic center. It's home to Lenin’s Mausoleum, the State Historical Museum's comprehensive collection and St. Basil’s Cathedral, known for its colorful, onion-shaped domes.", 0, "https://media.defense.gov/2007/Nov/08/2000432272/780/780/0/082207-F-0000A-004.JPG", 0, "Moscow, Russia", 2 },
                    { 8, "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré.", 1, "https://cdn.pixabay.com/photo/2019/07/21/15/48/paris-4353012_960_720.jpg", 0, "Paris, France", 3 },
                    { 3, "Los Angeles is a sprawling Southern California city and the center of the nation’s film and television industry. Near its iconic Hollywood sign, studios such as Paramount Pictures, Universal and Warner Brothers offer behind-the-scenes tours. On Hollywood Boulevard, TCL Chinese Theatre displays celebrities’ hand- and footprints, the Walk of Fame honors thousands of luminaries and vendors sell maps to stars’ homes.", 1, "https://storage.needpix.com/rsynced_images/los-angeles-1598750_1280.jpg", 1, "Los Angeles, California", 3 },
                    { 6, "Denver, the capital of Colorado, is an American metropolis dating to the Old West era. Larimer Square, the city’s oldest block, features landmark 19th-century buildings. Museums include the Denver Art Museum, an ultramodern complex known for its collection of indigenous works, and the mansion of famed Titanic survivor Molly Brown. Denver is also a jumping-off point for ski resorts in the nearby Rocky Mountains.", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAgmDB1n98IbT0LLXff2ASnUgOG7UKuwTMg196OiyPNgJa0E_Hxw&s", 1, "Denver, Colorado", 1 },
                    { 5, "Atlanta is the capital of the U.S. state of Georgia. It played an important part in both the Civil War and the 1960s Civil Rights Movement. Atlanta History Center chronicles the city's past, and the Martin Luther King Jr. National Historic Site is dedicated to the African-American leader’s life and times. Downtown, Centennial Olympic Park, built for the 1996 Olympics, encompasses the massive Georgia Aquarium.", 1, "https://upload.wikimedia.org/wikipedia/commons/a/a7/Atlanta_Skyline_from_Buckhead.jpg", 1, "Atlanta, Georgia", 1 },
                    { 4, "Orlando, a city in central Florida, is home to more than a dozen theme parks. Chief among its claims to fame is Walt Disney World, comprised of parks like the Magic Kingdom and Epcot, as well as water parks. Another major destination, Universal Orlando, offers Universal Studios and Islands of Adventure, with the Wizarding World of Harry Potter straddling both.", 1, "https://cdn.pixabay.com/photo/2017/08/29/09/26/disney-2692578_960_720.jpg", 1, "Orlando, Florida", 2 },
                    { 2, "Buffalo is a city on the shores of Lake Erie in upstate New York. Its fine neoclassical, beaux arts and art deco architecture speaks to its history as an industrial capital in the early 20th century. Its landmarks include the 398-ft art deco City Hall, the Frank Lloyd Wright–designed Darwin D. Martin House and the Albright-Knox Art Gallery, a Greek Revival museum with works by Picasso and Warhol.", 0, "https://cdn.pixabay.com/photo/2012/08/27/22/15/niagara-falls-55119_960_720.jpg", 1, "Buffalo, New York", 1 },
                    { 1, "Seattle, a city on Puget Sound in the Pacific Northwest, is surrounded by water, mountains and evergreen forests, and contains thousands of acres of parkland. Washington State’s largest city, it’s home to a large tech industry, with Microsoft and Amazon headquartered in its metropolitan area. The futuristic Space Needle, a 1962 World’s Fair legacy, is its most iconic landmark. ", 0, "https://upload.wikimedia.org/wikipedia/commons/e/e3/Seattle_Kerry_Park_Skyline.jpg", 1, "Seattle, Washington", 2 },
                    { 7, "New Delhi is an urban district of Delhi which serves as the capital of India and seat of all three branches of the Government of India. The foundation stone of the city was laid by Emperor George V during the Delhi Durbar of 1911. It was designed by British architects, Sir Edwin Lutyens and Sir Herbert Baker.", 1, "https://live.staticflickr.com/2834/9491020841_08c3c47f11_b.jpg", 0, "New Delhi, India", 1 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "CityID", "Name", "Price" },
                values: new object[,]
                {
                    { 22, 8, "Le Regent Montmarte", 1 },
                    { 23, 8, "Holiday Inn Paris", 2 },
                    { 24, 8, "InterContinental Paris", 3 },
                    { 25, 9, "Hongdae Chef Guesthouse", 1 },
                    { 26, 9, "Tmark Hotel Myeongdong", 2 },
                    { 27, 9, "Park Hyatt Seoul", 3 },
                    { 28, 10, "Winterfell Hotel Tverskaya", 1 },
                    { 29, 10, "Hilton Garden Inn Moscow Krasnoselskaya", 2 },
                    { 32, 11, "Grand Hótel Reykjavík", 2 },
                    { 31, 11, "Reykjavik Downtown HI Hostel", 1 },
                    { 33, 11, "Kvosin Downtown Hotel", 3 },
                    { 34, 12, "Reykjavik Downtown HI Hostel", 1 },
                    { 35, 12, "Grand Hótel Reykjavík", 2 },
                    { 36, 12, "Kvosin Downtown Hotel", 3 },
                    { 37, 13, "The Bukit", 1 },
                    { 21, 7, "Hotel Diplomat", 2 },
                    { 30, 10, "The St. Regis Moscow Nikolskaya", 3 },
                    { 20, 7, "Haveli Dharampura", 3 },
                    { 1, 1, "Roy Street Commons", 1 },
                    { 18, 6, "Four Seasons Hotel Denver", 3 },
                    { 38, 13, "Andacura Beachfront collextion Panwa Phuket", 2 },
                    { 2, 1, "Hilton Seattle", 2 },
                    { 3, 1, "Four Seasons Hotel", 3 },
                    { 4, 2, "Motel 6 Buffalo Airport", 1 },
                    { 5, 2, "Millennium Buffalo", 2 },
                    { 6, 2, "Curtiss Hotel", 3 },
                    { 7, 3, "Monterey Inn", 1 },
                    { 8, 3, "Freehand Los Angeles", 2 },
                    { 9, 3, "The Ritz-Carlton, Los Angeles", 3 },
                    { 10, 4, "Howard Johnson by Wyndham Lake Front Park Kissimmee", 1 },
                    { 11, 4, "DoubleTree by Hilton Hotel at the Entrance to Universal Orlando", 2 },
                    { 12, 4, "Grand Bohemian Hotel Orlando, Autograph Collection", 3 },
                    { 13, 5, "Super 8 by Wyndham Austell/Six Flags", 1 },
                    { 14, 5, "Crowne Plaza Atlanta-Airport", 2 },
                    { 15, 5, "Four Seasons Hotel Atlanta", 3 },
                    { 16, 6, "Ember Hostel", 1 },
                    { 17, 6, "Home2 Suites by Hilton Denver International Airport", 2 },
                    { 19, 7, "Suites Admiral", 1 },
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
