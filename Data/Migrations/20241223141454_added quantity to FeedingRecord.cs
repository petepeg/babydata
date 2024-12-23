using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyData.Migrations
{
    /// <inheritdoc />
    public partial class addedquantitytoFeedingRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "QuantityInOz",
                table: "FeedingRecords",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityInOz",
                table: "FeedingRecords");
        }
    }
}
