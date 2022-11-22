using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "ShortName", "name" },
                values: new object[] { 1, "MA", "Morocco" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "ShortName", "name" },
                values: new object[] { 2, "Egy", "Egypt" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "ShortName", "name" },
                values: new object[] { 3, "UAE", "Emirates" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "CountryId", "Rating", "adress", "name" },
                values: new object[] { 1, 1, 5.0, "Marakkesh", "Mamounia" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "CountryId", "Rating", "adress", "name" },
                values: new object[] { 2, 2, 5.0, "Cairo", "Pharon" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "CountryId", "Rating", "adress", "name" },
                values: new object[] { 3, 3, 5.0, "Dubai", "Khalifa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
