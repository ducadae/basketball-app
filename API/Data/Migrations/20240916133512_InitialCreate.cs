using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    YearsPro = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    College = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: false),
                    SecondaryPosition = table.Column<string>(type: "TEXT", nullable: true),
                    Handedness = table.Column<string>(type: "TEXT", nullable: false),
                    ShotClose = table.Column<int>(type: "INTEGER", nullable: false),
                    ShotMed = table.Column<int>(type: "INTEGER", nullable: false),
                    ShotThreePoint = table.Column<int>(type: "INTEGER", nullable: false),
                    ShotLow = table.Column<int>(type: "INTEGER", nullable: false),
                    Layup = table.Column<int>(type: "INTEGER", nullable: false),
                    Dunk = table.Column<int>(type: "INTEGER", nullable: false),
                    FreeThrow = table.Column<int>(type: "INTEGER", nullable: false),
                    Passing = table.Column<int>(type: "INTEGER", nullable: false),
                    Dribbling = table.Column<int>(type: "INTEGER", nullable: false),
                    OffhandDribbling = table.Column<int>(type: "INTEGER", nullable: false),
                    OffensiveIQ = table.Column<int>(type: "INTEGER", nullable: false),
                    DefensiveIQ = table.Column<int>(type: "INTEGER", nullable: false),
                    LowPostTechnique = table.Column<int>(type: "INTEGER", nullable: false),
                    PerimeterDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    PostDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    HelpDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    Steal = table.Column<int>(type: "INTEGER", nullable: false),
                    Block = table.Column<int>(type: "INTEGER", nullable: false),
                    DefReb = table.Column<int>(type: "INTEGER", nullable: false),
                    OffReb = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Quickness = table.Column<int>(type: "INTEGER", nullable: false),
                    Vertical = table.Column<int>(type: "INTEGER", nullable: false),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Durability = table.Column<int>(type: "INTEGER", nullable: false),
                    Potential = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
