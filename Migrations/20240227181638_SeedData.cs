using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstrologyApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Signs",
                columns: new[] { "SignId", "Concentration", "Description", "Expression", "SignName" },
                values: new object[] { 1, "action", "idealist", "dominant", "Aries" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Signs",
                keyColumn: "SignId",
                keyValue: 1);
        }
    }
}
