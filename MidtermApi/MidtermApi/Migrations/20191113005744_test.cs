using Microsoft.EntityFrameworkCore.Migrations;

namespace MidtermApi.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
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
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FamilyFriendly = table.Column<bool>(nullable: false),
                    Outdoors = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Activities_Cities_CitiesID",
                        column: x => x.CitiesID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_CitiesID",
                        column: x => x.CitiesID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedVacation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitiesID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RecommendationCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedVacation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SavedVacation_Cities_CitiesID",
                        column: x => x.CitiesID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Description", "Hot", "ImageURL", "InUSA", "Name", "Price" },
                values: new object[] { 1, "test", false, "", true, "Seattle", 20 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Description", "Hot", "ImageURL", "InUSA", "Name", "Price" },
                values: new object[] { 2, "test2", true, "", true, "Los Angeles", 100 });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ID", "CitiesID", "FamilyFriendly", "Name", "Outdoors" },
                values: new object[,]
                {
                    { 1, 1, true, "Activity 1", false },
                    { 2, 2, false, "Activity 2", false }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "CitiesID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Test INN", 80 },
                    { 2, 2, "Test INN 2", 50 }
                });

            migrationBuilder.InsertData(
                table: "SavedVacation",
                columns: new[] { "ID", "CitiesID", "Name", "RecommendationCode" },
                values: new object[,]
                {
                    { 1, 1, "saved vacation 1", 1234 },
                    { 2, 2, "saved vacation 2", 4321 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CitiesID",
                table: "Activities",
                column: "CitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CitiesID",
                table: "Hotels",
                column: "CitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedVacation_CitiesID",
                table: "SavedVacation",
                column: "CitiesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "SavedVacation");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
