using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Height", "Name", "Postcode" },
                values: new object[] { 1, 33, 1.5, "Alex", "SO14 5DH" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Height", "Name", "Postcode" },
                values: new object[] { 2, 20, 1.0, "Anna", "NW10 7DD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Height", "Name", "Postcode" },
                values: new object[] { 3, 15, 2.0, "Andrew", "NN20 8HD" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
