using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyData.Migrations
{
    /// <inheritdoc />
    public partial class AddedBreastSelection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BreastSelection",
                table: "FeedingRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreastSelection",
                table: "FeedingRecords");
        }
    }
}
