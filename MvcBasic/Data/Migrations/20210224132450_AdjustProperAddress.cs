using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcBasic.Data.Migrations
{
    public partial class AdjustProperAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicPplace",
                table: "Addresses",
                newName: "PublicPlace");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicPlace",
                table: "Addresses",
                newName: "PublicPplace");
        }
    }
}
