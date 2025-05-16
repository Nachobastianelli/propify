using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class PropertyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId1",
                table: "Properties",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId1",
                table: "Properties",
                column: "OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Owner_OwnerId1",
                table: "Properties",
                column: "OwnerId1",
                principalTable: "Owner",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Owner_OwnerId1",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_OwnerId1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "Properties");
        }
    }
}
