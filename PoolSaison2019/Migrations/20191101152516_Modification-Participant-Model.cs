using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolSaison2019.Migrations
{
    public partial class ModificationParticipantModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DernierRang",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rang",
                table: "Participant",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DernierRang",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Rang",
                table: "Participant");
        }
    }
}
