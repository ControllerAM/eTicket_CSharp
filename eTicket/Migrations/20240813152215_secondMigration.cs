using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicket.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePicture");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePicture");

            migrationBuilder.AlterColumn<int>(
                name: "Logo",
                table: "Cinemas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
