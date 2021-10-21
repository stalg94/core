using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoresWebAPI.Migrations
{
    public partial class DropMainTitleAndSubTitle_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                nullable: true);

            migrationBuilder.Sql(@"Update Books set Title = MainTitle + ' : ' + SubTitle");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "Books");            
            
            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Books");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "SubTitle");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
