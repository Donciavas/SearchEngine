using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchEngine.Migrations
{
    public partial class FourthUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "FileEntities",
                newName: "SizeInKb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeInKb",
                table: "FileEntities",
                newName: "Size");
        }
    }
}
