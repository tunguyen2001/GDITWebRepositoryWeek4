using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRepositoryWeek4.Migrations
{
    public partial class addproduct1_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product1",
                columns: table => new
                {
                    ProductId1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product1", x => x.ProductId1);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product1");
        }
    }
}
