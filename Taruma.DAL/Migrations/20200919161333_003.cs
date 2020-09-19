using Microsoft.EntityFrameworkCore.Migrations;

namespace Taruma.DAL.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "3168350e-b248-45e2-89ab-42eb74fc6cb9");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "5bdc07c2-dd43-4518-8add-90d5b2f1edee");

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: "75f0cec7-f549-4d14-bc7f-af7c83d7b3dd");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Users",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11) CHARACTER SET utf8mb4",
                oldMaxLength: 11);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Users",
                type: "varchar(11) CHARACTER SET utf8mb4",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "75f0cec7-f549-4d14-bc7f-af7c83d7b3dd", "4288e268-ac21-4709-8150-c520490ec38b", "Apartments Resident", "Resident", "RESIDENT" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "3168350e-b248-45e2-89ab-42eb74fc6cb9", "c2ea9591-f849-44fd-bfbe-1cffddb9197a", "Apartments Sindical", "Sindical", "SINDICAL" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "5bdc07c2-dd43-4518-8add-90d5b2f1edee", "0bcc9ed2-a3a5-4352-aeb9-a21fe66af4cf", "Apartments Administrator", "Administrator", "ADMINISTRATOR" });
        }
    }
}
