using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_twoodru8.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 100, "Action", "George Lucas", null, null, null, "PG-13", "Star Wars: Episode III", 2005 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 101, "Action", "George Lucas", null, null, null, "PG", "Star Wars: Episode II", 2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 102, "Action", "George Lucas", null, null, null, "PG", "Star Wars: Episode I", 1999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "MovieId",
                keyValue: 102);
        }
    }
}
