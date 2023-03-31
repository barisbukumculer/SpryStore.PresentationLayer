using Microsoft.EntityFrameworkCore.Migrations;

namespace SpryStore.DataAccessLayer.Migrations
{
    public partial class customerimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerImage",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerImage",
                table: "Customers");
        }
    }
}
