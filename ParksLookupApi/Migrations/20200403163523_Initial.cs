using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookupApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(nullable: false),
                    Desination = table.Column<string>(nullable: false),
                    StatesCode = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Weather = table.Column<string>(nullable: true),
                    WebsiteUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
