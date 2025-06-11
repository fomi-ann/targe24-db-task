using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessId1",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_AccessId1",
                table: "Positions",
                column: "AccessId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_AccessLevels_AccessId1",
                table: "Positions",
                column: "AccessId1",
                principalTable: "AccessLevels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_AccessLevels_AccessId1",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_AccessId1",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "AccessId1",
                table: "Positions");
        }
    }
}
