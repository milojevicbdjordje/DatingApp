using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO 'Values' (Name) VALUES ('Value 101')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
