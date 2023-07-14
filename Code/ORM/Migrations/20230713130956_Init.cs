using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ORM.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Designation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Department = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Department", "Description", "Designation", "Name" },
                values: new object[,]
                {
                    { "7d0f3035-8216-4537-971e-734f05ad7dc1", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" },
                    { "7d0f3035-8216-4537-971e-734f05ad7dc2", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" },
                    { "7d0f3035-8216-4537-971e-734f05ad7dc3", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" },
                    { "7d0f3035-8216-4537-971e-734f05ad7dc4", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" },
                    { "7d0f3035-8216-4537-971e-734f05ad7dc5", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" },
                    { "7d0f3035-8216-4537-971e-734f05ad7dc6", "Department Comes Here", "This is some description", "This is the Designation", "Some Name" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
