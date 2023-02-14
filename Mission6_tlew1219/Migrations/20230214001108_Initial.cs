using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_tlew1219.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    AppliationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.AppliationID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "AppliationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Thriller", "Martin Scorcese", true, "", "Incredible", "R", "The Departed", (ushort)2006 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "AppliationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Adventure", "Kevin Lima, Chris Buck", false, "", "Thank you Phil Collins", "G", "Tarzan", (ushort)1999 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "AppliationID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Mystery", "Christopher Nolan ", true, "", "Mind blowing", "R", "Memento", (ushort)2000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
