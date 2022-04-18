using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherProject.Migrations.WeatherDB
{
    public partial class WEATHER_MEASUREMENT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AMBIENT_TEMPERATURE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GROUND_TEMPERATURE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AIR_QUALITY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AIR_PRESSURE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HUMIDITY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WIND_DIRECTION = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WIND_SPEED = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WIND_GUST_SPEED = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RAINFALL = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
