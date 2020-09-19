using Microsoft.EntityFrameworkCore.Migrations;

namespace Taruma.DAL.Migrations
{
    public partial class _004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "606998b4-6e5b-4e58-93c0-54a6becf9bef");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "793e1721-7d39-44b0-ac5e-10dcc17a9957");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "81ccd030-0e3e-4f1e-83fe-48ce75533281");

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "9733dd42-721c-4cda-8771-e0eb2379d0a6", "099d49a3-2fcd-4f61-8d09-42934f75f0b9", "Apartments Resident", "Resident", "RESIDENT" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "1856e2f2-a111-41a6-bbf5-1fca790e2c54", "74bfa253-206b-4ea5-9cf3-31cc7215ff4e", "Apartments Sindical", "Sindical", "SINDICAL" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "719e71d8-2eb1-4b17-be1a-d4be0fd95eeb", "0b112b54-5de7-4296-8a62-a593b2204ab1", "Apartments Administrator", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "1856e2f2-a111-41a6-bbf5-1fca790e2c54");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "719e71d8-2eb1-4b17-be1a-d4be0fd95eeb");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "9733dd42-721c-4cda-8771-e0eb2379d0a6");

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "606998b4-6e5b-4e58-93c0-54a6becf9bef", "e023aecd-8ae8-418f-a114-c8ccd67085f6", "Apartments Resident", "Resident", "RESIDENT" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "793e1721-7d39-44b0-ac5e-10dcc17a9957", "b46be649-f0f2-495b-ba49-ab3cf57e2d34", "Apartments Sindical", "Sindical", "SINDICAL" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "81ccd030-0e3e-4f1e-83fe-48ce75533281", "3948a77a-8f0a-4c19-8631-5ab1dc3d229b", "Apartments Administrator", "Administrator", "ADMINISTRATOR" });
        }
    }
}
