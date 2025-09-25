using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessTracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MembershipType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Age", "Email", "FirstName", "IsActive", "JoinDate", "LastName", "MembershipType", "Phone" },
                values: new object[,]
                {
                    { 1, 28, "john.doe@email.com", "John", true, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", "Premium", "(555) 123-4567" },
                    { 2, 32, "jane.smith@email.com", "Jane", true, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", "Basic", "(555) 987-6543" },
                    { 3, 25, "mike.johnson@email.com", "Mike", true, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", "Premium", "(555) 456-7890" },
                    { 4, 29, "sarah.wilson@email.com", "Sarah", true, new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", "Standard", "(555) 234-5678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
