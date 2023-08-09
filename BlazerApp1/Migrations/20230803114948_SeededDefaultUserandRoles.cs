using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazerApp1.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc", null, "User", "USER" },
                    { "7ceae20e-1390-475f-8ec5-87293dc79748", null, "Administrator", "ADMININISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "040dac1c-dec8-4c9e-881f-0341615815cc", 0, "0a28b013-0cf1-440b-bd89-2590496ab1ff", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", null, "AQAAAAIAAYagAAAAECo0ec4RWmxnkJwWwLJoczmh74S6LdaDctgvPem7EaZrpIHTNMjl2JsvUMltkXkIYA==", null, false, "121ace5f-5b17-439d-921e-032965193152", false, "user@bookstore.com" },
                    { "b2b3903a-fa2e-4d3d-9749-65560a2f7c05", 0, "f4accc47-a13b-4465-9eef-ff045c5aa480", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", null, "AQAAAAIAAYagAAAAEAfC8DQiF1nXzv82aLkixXhH/h/YDOvEKan37stL830Oj1RaFBMx1Y0XLtYhxSZQ0A==", null, false, "60c48312-4dcc-4c9b-af28-b7a8194921de", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc", "040dac1c-dec8-4c9e-881f-0341615815cc" },
                    { "7ceae20e-1390-475f-8ec5-87293dc79748", "b2b3903a-fa2e-4d3d-9749-65560a2f7c05" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc", "040dac1c-dec8-4c9e-881f-0341615815cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ceae20e-1390-475f-8ec5-87293dc79748", "b2b3903a-fa2e-4d3d-9749-65560a2f7c05" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ceae20e-1390-475f-8ec5-87293dc79748");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "040dac1c-dec8-4c9e-881f-0341615815cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b3903a-fa2e-4d3d-9749-65560a2f7c05");
        }
    }
}
