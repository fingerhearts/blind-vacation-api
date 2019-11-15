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
                    { 1, 1, 1, @"1) Space Needle

                This is it. You’re about to walk into a memory. Soaring 520 feet skyward. The city actually, really, truly at your feet. Step up. Step out. Step beyond your comfort zone. And experience wonder on a higher level. Visit the Space Needle in the heart of Seattle.

                2) Ride the Ducks of Seattle

                When you and your friends arrive in Seattle by plane, cruise ship, car or Seattle-style bicycle, 'Ride the Ducks of Seattle' should be your first stop. In ninety minutes, you’ll see the top sights and hear about how the city developed into the tech-coffee-expensive-real-estate hub it is today. Before you start drinking your double tall, extra foam, skinny vanilla latte or posting photos when “the mountain’s out,” enjoy all that makes Seattle famous on the tour that was rated #1 City Tour for more than a decade.

                3) Pike Place Market

                One of the few authentic farmer's markets in the United States, this hub of delicious scents, delectable eats and delightful personalities attracts nine million visitors a year. Take a tour of Pike Place Market and find out why this market has become a staple in Seattle.

                ", 1 },
                    { 29, 8, 1, @"1) Jardin des Plantes

                Considered France's principle botanical garden, the Jardin des Plantes was established in the 17th century under the reign of Louis XIII.

                2) Jardin D'Acclimatation

                This is zoological park with many other attractions including the Exploradome, merry-go-rounds and puppet shows.

                3) Eiffel Tower

                The Eiffel Tower is a wrought-iron lattice tower on the Champ de Mars in Paris, France.

                ", 1 },
                    { 30, 8, 0, @"1) L'Arc de Triomphe

                This symbol of French victory was commissioned by Napoleon and completed in 1836.

                2) Canal Cruising

                A cruise from the Bastille marina towards the Marne river will take you to those bucolic open air dance halls.

                3) Sacre Coeur De Montmartre

                Located on the highest peak of Paris, the view from the Sacré Coeur is breathtaking.

                ", 1 },
                    { 31, 8, 1, @"1) Jardin des Plantes

                The most famous greenhouse in Paris is Grandes Serres in the Jardin des Plantes. The plants are kept warm all year round, which make the greenhouses a welcoming retreat from inclement weather.

                2) Paris Aquarium

                With 43 tanks, more than 10,000 fish and invertebrates, and 25 sharks, there is a veritable bounty of delightful sights.

                3) Relax in a Turkish Bath

                Paris has warmly embraced the tradition of languorous baths, particularly Turkish baths, also known as ‘hammams.’ These steam baths will warm your tired bones, and are often accompanied by a full-body scrub.

                ", 0 },
                    { 32, 8, 0, @"1) Walk Through a Haunted House

                This haunted house makes a thoroughly spooky, and thoroughly fun, retreat from bad weather. 
                2) Indulge in Hot Chocolate and Tea Rooms

                Paris’ most famous spot for hot chocolate is Angelina’s. This is a tea house which has almost pudding-like hot chocolate and Belle Époque decor.

                3) The Catacombs

                The Catacombs are one of Paris’ most unsettling and fascinating sights.

                ", 0 },
                    { 33, 9, 1, @"1) Children’s Grand Park

                Children’s Grand Park is one of the more famous family spots in Seoul, featuring a zoo, an amusement park, and plenty of paths for strolling.

                2) Bukhansan National Park

                One of the most popular pastimes in Seoul is hiking and this stunning national park just outside the city is a local favorite. Aside from a variety of hiking trails for every skill level, you’ll also see lots of flora and fauna, temples and ancient fortresses.

                3) Visit Rabbit Park

                This amazing park is located in the trendy french neighborhood Seorae Village. Check out the nearby area for great bakeries, wine bars, and better yet a park filled with friendly rabbits!

                ", 1 },
                    { 34, 9, 0, @"1) Enjoy the scene at Hangang River

                The Hangang River is the most important physical landmark in the city. Lined with parks and recreational facilities on both banks, it’s the perfect place to rent bikes, go on cruise up the river, enjoy bird-watching, or splash around and cool off in public swimming pools during the summer months.

                2) Hike the Mountain Baegaksan

                Mt.Baegaksan is a 342-meter high granite mountain in the middle of Seoul and is home to Gyeongbokgung Palace and a Joseon Dynasty fortress.

                3) Myeongdong Real Gun Shooting Range

                The Myeongdong Real Gun Shooting Range is an indoor live firing range located in Myeong-dong. With over a 100 firearms to choose from, visitors can try their best to shoot at targets with a real gun.

                ", 1 },
                    { 35, 9, 1, @"1) Visit the COEX Aquarium

                The COEX Aquarium consists of 183 display tanks and 90 breeding tanks with over 3,500 tons of water volume. 40.000 animals from 650 different species live here.

                2) Take funny photos at the Trick Eye Museum

                The Trick Eye Museum is an artistic game of sorts which uses distorted perspectives and scientific calculations to transform well-known paintings in optically amusing ones.

                3) See the legendary Nanta Cooking Show

                Nanta is the first non-verbal performance produced in Korea that comically depicts happenings in the kitchen by integrating Korea’s traditional rhythm, 'Samulnori'.

                ", 0 },
                    { 36, 9, 0, @"1) Jjimjilbang Hot Sauna

                Jjimjilbang is deeply integrated with Korean culture. Locals enjoy going to the hot saunas, taking rejuvenating baths and getting body scrubs and massages.

                2) Get Creative!

                In Seoul, you can visit a ring making café and craft your own rings! You can also create your own perfume or visit a cake shop and decorate your own cake!

                3) Discover Korea’s Bang Culture

                 If you spontaneously want to have a crazy dancing and singing party with your friends, you can rent a Noraebang (Karaoke room) for a few dollars and be the star of your own concert.

                ", 0 },
                    { 37, 10, 1, @"1) Saint Basil’s Cathedral

                Get stunned by the cathedral’s architectural magnificence designed on a flame of a bonfire. At night, the lit up cathedral looks very lively and colorful and you will never regret visiting it.

                2) Izmailovo Flea Market

                Experience the vibrant architecture of Moscow during a tour of the Izmailovo Flea Market and the Izmailovo Kremlin. Brimming with museums, galleries, and regal palaces, the area is a colorful cultural hub that provides ample photo opportunities. Browse stalls selling Russian crafts, culinary specialties, and antiques, and admire the architecture of the Izmailovo Kremlin and the Tsar’s Palaces.

                3) Gorky Park – Go Cycling

                The Gorky Park is undoubtedly among Moscow’s premier green spaces and offers tonnes of entertainment for every taste. From outdoor dancing sessions, yoga and fitness classes in the summer, to activities like beach volleyball, ping-pong, rollerblading, skateboarding, cycling, this place offers everything!

                ", 1 },
                    { 38, 10, 0, @"1) Sparrow Hills – Trek

                Sparrow Hills, also known as Lenin Hills, is the highest point in Moscow. Trekking to these hills is one of the most adventurous things to do in Moscow.

                2) Moscow Hermitage Garden – Indulge In Events

                This popular recreation spot also hosts a number of cultural events like ballet, opera, and concerts.

                3) Sokolniki Park – Tour The Falcon Hunt Ground

                In the 15th century, the today’s Sokolniki Park was a thick forest and was used for grand ducal falcon hunt by the kings and princes. Later, it became a social gathering place for nobles and common people. Today, it stands majestically in a thick cover of a woods as one of the largest and oldest parks in Europe.

                ", 1 },
                    { 39, 10, 1, @"1) Bolshoi Theatre – Watch A Live Ballet/Opera Performance

                Watch Russia’s authentic Bolshoi Ballet and Bolshoi Opera in the neoclassical theatre designed by architect Joseph Bové.

                2) Tsaritsyno Museum-Reserve

                The former summer residence of Empress Catherine the Great was commissioned in 1775, and succumbed to deterioration during the Soviet era. The whole of Tsaritsyno Museum-Reserve has been fundamentally renovated since 1980s to look even brighter than the original. With its opulently decorated buildings, gardens, meadows and forests, Tsaritsyno Park is the perfect place for a green respite in Moscow.

                3) Novodevichy Convent

                Founded in 1524, the Novodevichy Convent is a place steeped in history. Behind the walls that once served as a fortress, there are four cathedrals with a fascinating icon collection and a venerable cemetery.

                ", 0 },
                    { 40, 10, 0, @"1) State Historical Museum

                An attraction in its own right, the State Historical Museum, sheltered in a neo-Russian style building, was founded in 1872 by Ivan Zabelin and Aleksey Uvarov.

                2) Moscow Metro – Ride

                Riding the city’s underground rapid transit system is an experience in itself. The vaulted, marble-columned stations, some with ornate mosaics and splendid stained glass are architectural marvels.

                3) GUM Department Store

                Russia’s main department store, GUM’s stunning interior houses a variety of high-end boutiques. Built between 1890 and 1893 and known as the Upper Trading Rows until the 1920s, the legendary store is now home to over 200 boutiques selling a variety of brands.

                ", 0 },
                    { 41, 11, 1, @"1) Visit the Grótta lighthouse and soak your feet in the hot pool

                After a long day of exploring I promise this will be an amazing (and free!) way to end your day.

                2) Take in the unique nature at Heiðmörk

                A popular recreational area in Reykjavik, Heiðmörk is one of my favorite outdoor spots to spend a sunny day exploring. Just a short drive outside of the city will take you to Heiðmörk and all the unique nature in the area. From red colored rock formations to caves, Heiðmörk will keep you entertained all day long, you never know what you will discover next!

                3) Snorkeling at Silfra

                Located in Thingvellir National Park, the Silfra rift is a fissure that lies between the Eurasian and North American tectonic plates. The water is fed from the meltwater of a nearby glacier and visibility is top notch.

                ", 1 },
                    { 42, 11, 0, @"1) Hike Mt Esja and take in the stunning views of Reykjavik

                Mt. Esja is a quick drive away and you can easily get the bus out there from downtown Reykjavik. Everyone should try hiking while in Iceland during the summer and with a little bit of everything Mt. Esja if the perfect hike to fit in.

                2) Take the ferry to Viðey Island

                With Esja on one side, the city of Reykjavik on the other and the ocean surrounding you Viðey Island is a must see spot when in Reykjavik. Pack a picnic and take the ferry over and enjoy the nature on this little island.

                3) Glacier Hiking and Ice Climbing

                More than 10% of Iceland is covered with glaciers, so “The Land of Fire and Ice” is the perfect place for glacier hiking and ice climbing!

                ", 1 },
                    { 43, 11, 1, @"1) Volcano House

                Volcano House is one of the most popular tourist attractions in the heart of Reykjavik. This is the place where one can learn about the Icelandic volcanoes by watching high quality film that were created for the Volcano House. Moreover, there is a great lava stones collection, souvenir shop and the collection of arts from famous Icelandic artists.

                2) Whales of Iceland

                Whales of Iceland is largest whale exhibition in Europe, located in Reykjavík's harbour area. The exhibition features life-size models of 23 whale species that have been seen in Icelandic waters, as well as man-made skeletons of select whales. There is no better way to learn about whales than seeing these giants up close in full-size. You will leave with a new perspective and appreciation for these interesting and beautiful animals.

                3) Perlan

                At Perlan’s exhibitions you learn all about Icelandic nature in interactive and fun ways. Natural wonders come alive at your fingertips – volcanoes, northern lights, glaciers, ocean-life, seabirds and so much more. You explore a real ice cave, sit back in a first-class Planetarium, have fun with interactive displays and enjoy views all over Reykjavík city.

                ", 0 },
                    { 44, 11, 0, @"1) Hallgrimskirkja

                Hallgrimskirkja is the largest church in the country, and towers over the centre of Reykjavik. Its 73-metre-high tower provides a wonderful 360° view over all Reykjavik, the mountains around and the ocean streaching west to Greenland and the Americas. Because of this, the tower is among the most visited tourist destinations in Reykjavik.

                2) Eimverk Distillery

                Eimverk Distillery is Icelands' first and only whisky distillery and a perfect destination for whiskey fans and for anyone with an interest in Icelandic Spirits. During the Distillery tour you will have the opportunity to sample Floki Icelands' first and only whiskey, learn about the processes involved in creating Icelandic spirits from Icelandic barley, as well as sampling Vor our premium pot distilled gin.

                3) Harpa Reykjavik Concert Hall and Conference Centre

                Harpa Concert Hall and Conference Centre at the heart of Reykjavik is an award-winning building situated at the old harbour. Harpa opened its doors in 2011 and boasts a wide variety of hosted events where all musical genres play a part.

                ", 0 },
                    { 45, 12, 1, @"1) Linnanmaki

                Linnanmäki is the most popular amusement park in Finland. The outdoor amusement park is open from April to October. It was opened in 1950 and is owned by a non-profit foundation for child welfare.

                2) Picnic in Esplanad Park

                The Esplanad park is in the heart of Helsinki and a popular place for people to get together and have picnics.

                3) Paddling Helsinki

                Ferries to the islands are a good way to see Helsinki from the sea but if you are adventurous paddling is an excellent option. Many places rent kayaks including some seaside cafes but if you don’t have much previous experience it may be a good idea to go on a guided tour.

                 ", 1 },
                    { 46, 12, 0, @"1) Suomenlinna Sea Fortress

                The sea fortress is a Unesco World Heritage Site and one of the most popular attractions in Finland. Suomenlinna is accessible around the year by ferry from the market square with a regular public transportation ticket. The market is a perfect spot to buy some Finnish berries and peas from to take along.

                2) Pihlajasaari

                Pihlajasaari is known for one of the best beaches in Helsinki so it’s a great place to spend a warm day. Keep in mind that the sea is usually cold. The island is accessible by ferry connections from Merisatama, next to Café Carousel and from Ruoholahti, next to Restaurant Faro.

                3) Bicycling Along The Coastline

                Rent a bicycle and head west from Helsinki through Lauttasaari to Espoo Westend where you reach the waterfront walkway Rantaraitti that offers an about 30 km long walking and cycling path along the coast. There are nice seaside cafes along the route.

                ", 1 },
                    { 47, 12, 1, @"1) Old Market Hall

                Old Market Hall is aesthetically pleasing as well as historically interesting, and well located by the harbour. It is filled with every imaginable fresh and cooked food, and quickly became our local coffee hang whilst in Helsinki, as well as the place to gather local produce and meats to prepare for dinner.

                2) Helsinki Cathedral

                Helsinki Cathedral is the Finnish Evangelical Lutheran cathedral of the Diocese of Helsinki, located in the neighborhood of Kruununhaka in the centre of Helsinki, Finland. The church was originally built from 1830-1852 as a tribute to the Grand Duke of Finland, Tsar Nicholas I of Russia.

                3) Kamppi Chapel of Silence

                In the center of the busy town of Helsinki you find this Little chapel which looks so different from other chapels. The building is 11,5 meter in High and is build in 3 different tree types.You can have a seat and really enjoy the silence and peace.

                ", 0 },
                    { 48, 12, 0, @"1) Tallink and Silja Line - Cruises

                With the most modern fleet operating in the Baltic Sea today, there are various short cruises of routes include Stockholm-Helsinki, Stockholm-Turku, Helsinki-Tallinn, Stockholm-Tallinn and Stockholm-Riga.

                2) Museum of Contemporary Art Kiasma

                Kiasma is a contemporary art museum located on Mannerheimintie in Helsinki, Finland. Kiasma is part of the Finnish National Gallery, and it is responsible for the gallery's contemporary art collection. Its central goal is to showcase contemporary art and to strengthen its status.

                3) Stockmann Department Store

                Founded in 1862, Stockmann is the largest department store in Scandinavia. Here you can find everything you need. The flagship of the department store chain, located in the heart of Helsinki, offers more than 50,000 square meters of shopping space across ten floors. Stockmann is famous for its wide selection of products and excellent customer service.

                ", 0 },
                    { 49, 13, 1, @"1) Sea Cave Canoeing

                Well known for its limestone karsts jutting out of the sea, numerous caves and the shimmery emerald-green water, Phang Nga Bay is an ideal to find the thrill and serenity on a journey through the spectacular scenery and exotic seascape on the east coast of Phuket.

                2) Zipline

                Zipline in Phuket combines a thrilling mix of adrenaline and the beauty of nature. This exciting activity will let you soar above the rainforest canopy and take in spectacular views that stretch out as far as the Andaman Sea.

                3) Nai Harn Beach

                Situated in the south of the island is Nai Harn Beach, it is a popular beach with thousands of visitors every year but it is still relatively untouched and maintains a lot of its originality.  With beautifully soft sand and crystal clear water you will immediately see why the beach is so popular.

                ", 1 },
                    { 50, 13, 0, @"1) Jungle Bungee Jump

                A jungle bungee jump in Kathu gives a perfect combination of views and thrills. Jumpers can choose to stay dry, to be dunked in the water, or try something different from the classic solo jump, like tandem and catapult variations.

                2) Water Skiing

                Whether you’re a newbie to this extreme sport or you’ve been doing it for ages, water skiing is an fun-filled activity that will keep your adventurous spirit alive. The operators in Phuket have got everything you need to have a great time riding the water from beginner to intermediate.

                3) ATV Ride to the Big Buddha

                This fun adventure activity combines a thrilled ride on an ATV quad bike and the exciting safari camp on Nakkerd Hill. The ATV ride provides some of the most stunning views over Phuket Town, Chalong Bay, Rawai Beach and the Andaman archipelago. The path takes you through dirt roads in the jungle and up over to the Big Buddha, one of the most important landmarks in Phuket, on top of the hill.

                ", 1 },
                    { 51, 13, 1, @"1) Phuket Trickeye Museum

                Phuket Trickeye Museum is an interactive 3D painting museum offering amazing photo opportunities and great fun for the whole family. Phuket Trickeye Museum features a gallery of about 100 scenes painted using trompe-l’oeil techniques.

                2) Central Festival Phuket

                Central Festival Phuket is a fully equipped one-stop shopping mall lying just outside of Phuket Town. Rightly regarded as the shopping hub of the island, Central plays host to over 120 outlets. It's literally possible to spend a full day here - shopping, catching the latest movies, and dining out at the range of international restaurants that offer everything from French cuisine to Japanese to local Thai outlets.

                3) Phuket Aquarium

                The aquarium is surrounded by some of the most beautiful scenery, making it a perfect destination for the whole family as well as providing educational activities for kids.

                ", 0 },
                    { 28, 7, 0, @"1) Gurudwara Bangla Sahib

                This is the place you must visit. The amazing Sikh Religion Temple is a beautiful building with a rich Sikh religious culture.

                2) ISKCON Temple Delhi

                ISKCON as a transcendental mission with a strong philosophical and culture base, Popularly Known with Hare Krishna Movement.

                3) Spa Treatment at Shangri La's Eros Hotel

                The Spa at the Shangri La's Eros Hotel is an exception. It focuses on traditional techniques from Asian cultures.

                ", 0 },
                    { 27, 7, 1, @"1) National Mesuem - New Delhi

                The collection consists of about 200,000 objects, mainly from the Indus Valley Civilization dating as far back as 2,500 BC.

                2) India Habitat Center

                The India Habitat Center has frequent classical music and dance concerts. Come and experience Indian classical and folk music, dance and drama.

                3) Kingdom of Dreams

                Get out of Delhi for the day and take a trip to one of India's best theme parks, the spectacular Kingdom of Dreams.

                ", 0 },
                    { 52, 13, 0, @"1) Have a Tour of The Chalong Bay Rum Distillery

                There is lots to do when you arrive at the distillery, you start by taking a tour where you will learn about the way the rum is produced before taking a look at the work that goes on behind the scenes. The final part of the trip is in the cocktail workshop and bar, here you will learn how to make various cocktails that all include Chalong Bay Rum and then relax while you sample them.

                2) Wat Chalong

                The highlight of your visit will be the Grand Pagoda which contains a small splinter from the bone of Lord Buddha, The pagoda is beautifully decorated with Buddha images and pictures that depict his life story.

                3) See The Ladyboys at the Simon Cabaret Show

                For over two decades the now very famous Simon Cabaret show has wowed tourists to Phuket with the most beautiful of ladyboys performing night after night. For one hour you will be treated to spectacular cabaret by the various performers including a big fat transvestite who always wipes her sweaty boobs on an unsuspecting gentleman sitting in the front row.

                ", 0 },
                    { 25, 7, 1, @"1) Taj Mahal

                Taj Mahal is an ivory-white marble Islamic mausoleum. It was commissioned in 1632 by the Mughal emperor Shah Jahan to house the tomb of his favourite wife.

                2) National Zoological Park of Delhi

                National Zoological Park is a 176-acre zoo near the Oldfort in Delhi. The zoo can be seen on foot or using a battery-operated vehicle which can be rented at the zoo.

                3) Go boating at the Old Fort

                The Old Fort, or Purana Qila as called locally, has a quaint boating area set amidst the ruins of the Fort and the Delhi Zoo as a boundary.

                ", 1 },
                    { 26, 7, 0, @"1) Akshardham Temple

                A place of worship, complete with exhibits, boat rides, water shows and lush gardens, the Akshardham temple situated in East Delhi is unlike any other, not only in India but the entire world.

                2) Jama Masjid

                The largest Islamic mosque in the city, Jama Masjid, was constructed way back in the 17th century. The imposing building is an iconic landmark of Old Delhi and an important place of worship.

                3) Chhatarpur Temple

                Located in South Delhi, the group of temples known as Chhatarpur are the second largest of their kind in India. The temple is dedicated to the Goddess Katyayani (Durga) and is made entirely of marble.

                ", 1 },
                    { 2, 1, 0, @"1) Fly high indoors at IFly

                An exiciting indoors skydiving center located only mintues outside of Seattle.

                2) Canoeing at University of Washington Waterfront

                Try to stay dry canoeing on Lake Washington at the University of Washington Waterfront Activities Center.

                3) Rock Climing at REI

                Visit REI in downtown Seattle and try your luck at Rock Climbing.

                ", 1 },
                    { 3, 1, 1, @"1) Seattle Art Museum

                Visit Seattle Art Museum to see a museum carved into the city, as much a part of Seattle's landscape and personality as the coffee, rain, mountains, Pike Place Market, and the Space Needle.

                2) Seattle Aquarium

                The Seattle Aquarium is a public aquarium opened in 1977 and located on Pier 59 on the Elliott Bay waterfront in Seattle.

                3) Pacific Science Center

                Pacific Science Center is a science center with a mission to ignite curiosity and fuel a passion for discovery, experimentation, and critical thinking.

                ", 0 },
                    { 4, 1, 0, @"1) Bill Speidel's Underground Tour

                Bill Special's Underground Tour is Seattle’s most unusual attraction, a humorous stroll through intriguing subterranean storefronts and sidewalks entombed when the city rebuilt on top of itself after the Great Fire of 1889.

                2) Capitol Hill

                Capitol Hill is a densely populated residential district. It is one of the city's most prominent nightlife and entertainment districts and is the center of the city's LGBT and counterculture communities.

                3) Six Seven Restaurant

                The award-winning Six Seven features seasonally inspired cuisine crafted with only the freshest and finest organic and naturally raised ingredients, procured for you to enjoy via our Executive Chef Jesse Souza's new and exciting menus.

                ", 0 },
                    { 5, 2, 1, @"1) Buffalo Zoo

                Each year, the Buffalo Zoo welcomes approximately 400,000 visitors and is the second largest tourist attraction in Western New York.

                2) Buffalo Harbor State Park

                Swim, climb, and slide on a nautical-themed playground at the Buffalo Harbor State Park.

                3) Canalside

                Have some outdoor fun at Canalside, a master-planned neighborhood and festival marketplace within the inner harbor of Buffalo.

                ", 1 },
                    { 6, 2, 0, @"1) Niagara Falls

                One of the world's most awe-inspiring waterfalls. Just about 20 miles north of Buffalo, Niagara Falls makes for a great day trip.

                2) Buffalo and Erie County Botanical Gardens

                The Botanical Gardens is an education center and tourist destination full of exotic horticulture treasures from around the world.Come enjoy the amazing architecture and the indoor and outdoor garden sanctuaries.

                 3) Buffalo Pedal Tour

                Hop aboard on the Buffalo Pedal Tour, this people powered tour bus or boat for a fun filled time. On land and now on the water!

                ", 1 },
                    { 7, 2, 1, @"1) Pierce-Arrow Museum

                This unique museum focuses on Buffalo's transportation history featuring Pierce Arrow, Thomas Flyer, electric vehicles, vintage bicycles, motorcycles, muscle cars and trucks, many made in Western New York.

                 2) Theodore Roosevelt Inaugural National Historic Site

                Come tour the historical neighborhoods and enojoy the exhibits of Roosevelt's life!

                 3) Buffalo Museum of Science

                The Buffalo Museum of Science offers educational and exciting experiences the whole family can enjoy!

                ", 0 },
                    { 8, 2, 0, @"1) Flying Bison Brewing Company

                The music, food and beer at Flying Bison are on point. If you enjoy local brews this is the place you must stop by!

                2) Buffalo & Erie County Naval & Military Park

                There are 3 ships displayed at the Buffalo & Erie County Naval & Military Park. The exhibits displayed date back to the First World War.

                3) Burchfield Penney Art Center

                This is the only museum dedicated exclusively to the art and artists of Western New York.

                 ", 0 },
                    { 9, 3, 1, @"1) Speed Zone

                It's your chance of steering and speed at Speed Zone’s four go-kart tracks! Don't forget to Electric Alley’s arcade of over 100 video games!

                2) Los Angeles County Arboretum & Botanical Garden

                These gorgeous grounds in Arcadia, very close to the Santa Anita racetrack, have been designed as an educational facility.

                3) Temescal Gateway Park

                The loop at Temescal Canyon winds through a densely wooded, well-maintained trail with sweeping ocean views and a seasonal waterfall.

                 ", 1 },
                    { 11, 3, 1, @"1) Madame Tussauds Hollywood

                The life-like wax figures you’ll find at the museum are so real looking. There are 100+ wax figures here!

                2) Cabrillo Marine Aquarium

                Featuring over 200 species of marine animals that live in the Southern California region, the Cabrillo is number one of its class.

                3) Dolby Theatre Guided Tour

                You’ll will see areas of the theatre not seen on TV, plus get a behind-the-scenes look at where lots of popular events take place.

                ", 0 },
                    { 12, 3, 0, @"1) Studio Tours

                Come visit a real working studio and see behind-the-scenes of how Hollywood works.

                2) K1 Speed Indoor Karting

                High-performance, zero-emission cars equipped with the newest technology make K1 Speed one of the premier places to go in LA!

                3) Grammy Museum

                The Grammy Museum has impressive collection of artifacts, exhibits, films, and more.

                 ", 0 },
                    { 10, 3, 0, @"1) Sail to Catalina Island to Snorkel

                This is a great day-trip option for those looking to escape the city crowds and enjoy the sea view.

                2) Summit Mount Bald

                Mount Baldy is the highest peak in Los Angeles County. If you love hiking, you should definitely hike Mount Baldy!

                3) Visit Joshua Tree National Park

                Spend a couple of days bouldering among Martian-looking landscapes and exploring the palm-fringed oases.

                ", 1 },
                    { 14, 4, 0, @"1) Kayak Tours at Central Florida

                From rivers to lakes to breathtaking sparkling springs, there are so many waterways to explore in Central Florida.

                2) Orlando Balloon Rides

                See Orlando from the air in a different way, on this sunrise hot-air balloon adventure.

                3) Falcon Flyboarding

                No prior experience is needed! Just after some simple training and you will be souring through the air in no time.

                ", 1 },
                    { 24, 6, 0, @"1) Stranahan's Colorado Whiskey Tour

                Who doesn't love to taste shots and keeping the shot glass as a memento? If you love whiskey this is the place for you!

                2) Forney Museum of Transportation

                The Forney Museum of Transportation is a one-of-a-kind collection of over 600 artifacts relating to historical transportation.

                3) Balistreri Vineyards

                Their award-winning wines are traditionally handcrafted, without addition of sulfites or other chemicals. The tastingroom and vineyard is located just 10 minutes from downtown Denver!

                ", 0 },
                    { 23, 6, 1, @"1) Swim with Sharks at Downtown Aquarium

                There are more than 15,000 fish, mammals and plants at the Downtown Aquarium — and you can do more than gaze at them through the glass.

                2) Wings Over the Rockies Air & Space Museum

                The museum preserves the history of Lowry AFB's operations from 1938 to 1994 in its collections, archives, and research library. Features of the museum's collection include the USAF's B-1A Lancer and B-52 Stratofortress bombers and many other military and general aviation aircraft.

                3) Denver Art Museum

                The Denver Art Museum's collection includes more than 70000 works of art.

                ", 0 },
                    { 22, 6, 0, @"1) Take a Thrilling Zip Line Tour

                Soar along on 1.5 miles of zip line at speeds of up to 50 miles per hour, climb a 42-foot climbing wall and return via 'adrenaline jumping stations' or a 'kamikaze zip' straight to the ground.

                2) Take a Hot Air Balloon Ride

                Enjoy spectacular views of the majestic Rockies as you float high above the Front Range.

                3) Whitewater Rafting

                 There are lots of companies offering rafting along beautiful Clear Creek in Idaho Springs and the Arkansas River at the Royal Gorge.

                ", 1 },
                    { 13, 4, 1, @"1) Discovery Cove

                Discovery Cove is a one-of-a kind experience where you can interact with bottlenose dolphins, feed tropical birds, play inches from a family of otters and even walk on the Grand Reef floor-all in one day.

                2) Exotic Animal Experience

                Exotic Animal Experience is a TOTALLY interactive, hands on experience with exotic animals!

                3) Walt Disney World

                Walt Disney World Resort features four theme parks with interactive rides, animal adventures, magical attractions and many more!

                ", 1 },
                    { 20, 5, 0, @"1) Atlanta Brewing Company

                Established in 1993, Atlanta Brewing Co was Georgia’s first craft brewery.

                2) Martin Luther King Jr. National Historic Site

                This is a major Atlanta attraction, the park draws some 500,000 visitors each year.

                3) Fernbank

                Discover a World of Wow at Fernbank, Atlanta's Science and Nature Experience.

                ", 0 },
                    { 21, 6, 1, @"1) Visit an Asian Village Populated by Elephants at Denver Zoo

                The Denver Zoo's phenomenal Toyota Elephant Passage offers you the chance to get up close and personal with some amazing animals, all in an extremely cool setting designed to look like a rustic Asian village.

                2) See Large Carnivores at Wild Animal Sanctuary

                The Wild Animal Sanctuary is a 720-acre rescue and educational facility where more than 350 animals rescued from dire situations now roam free.

                3) Take a Bike Ride on 85 Miles of Paths

                With 85 miles of bike trails and 300 days of sunshine, Denver is a cycling paradise.

                ", 1 },
                    { 18, 5, 0, @"1) Trek Up Stone Mountain

                Follow the yellow-painted line to the top of Stone Mountain, one of Georgia's most-visited attractions, for an incredible view of downtown Atlanta and the North Georgia mountains.

                2) Porsche Experience Center

                With a fleet of over 75 new model vehicles and Porsche Drive Coaches to navigate you through the 1.6 mile handling circuit, the Porsche Experience Center may be the world's greatest test drive.

                3) Hike to the Waterfalls at the Warwoman Dell Trail

                The eponymous trail and the Bartram Trail travel along a pebble-lined stream, through densely green forests, and past a pastiche of wildflowers and ferns.

                ", 1 },
                    { 17, 5, 1, @"1) River Floating Down The Chattahoochee River

                Enjoy the water and sun while paddleboarding, kayaking, canoeing, and floating down the river.

                2) Atlanta Botanical Garden

                The onset of spring brings a fresh crop of blooming flowers at the Atlanta Botanical Garden that you can't see year-round.

                3) Six Flags Theme Park

                Get ready to dive into the largest expansion in park history at Six Flags Over Georgia with the all-new Hurricane Harbor water park!

                ", 1 },
                    { 16, 4, 0, @"1) Escape Rooms

                Teams are locked into a room, and the mission is to escape by using logic, creative thinking and the provided tools to solve puzzles!

                2) Virtual Reality Attractions

                Escape to realms of pure digital imagination at Orlando’s VR attractions!

                3) Wonderworks

                This interactive museum has lots of interactive and diverse exhibits that teach while they entertain.

                ", 0 },
                    { 15, 4, 1, @"1) Crayola Experience

                Aspiring artists of all ages can enjoy 26 hands-on activities while experiencing the fun of learning and creating with color.

                2) iFLY Orlando Indoor Skydiving

                Enjoy the feeling of free flight at iFLY Orlando Indoor Skydiving!

                3) Sea Life Orlando Aquarium

                Soak up incredible views from Orlando’s only 360-degree underwater tunnel!

                ", 0 },
                    { 19, 5, 1, @"1) World of Coca-Cola

                Whether you are in town for vacation, planning a staycation with the family, or just looking for a fun weekend outing, the World of Coca-Cola is a great place to start.

                2) LEGOLAND Discovery Center – Atlanta

                A LEGOLAND Discovery Center ticket includes access to several LEGO-themed rides, the 4D cinema, and all the rest of the LEGO attractions.

                3) X-Drenaline

                This trampoline park has everything your kids need to work off some pent-up energy.

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
                    { 34, 12, "Crowne Plaza Helsinki - Hesperia", 1 },
                    { 35, 12, "Kotimaailma Helsinki Homes", 2 },
                    { 36, 12, "Hotel St. George Helsinki", 3 },
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
