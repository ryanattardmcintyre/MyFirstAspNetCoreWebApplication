using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductReview.DataAccess.Migrations
{
    public partial class addingusertoreview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Reviews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Reviews");
        }
    }
}
