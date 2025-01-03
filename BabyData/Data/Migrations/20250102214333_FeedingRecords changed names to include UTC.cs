using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyData.Migrations
{
    /// <inheritdoc />
    public partial class FeedingRecordschangednamestoincludeUTC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "FeedingRecords",
                newName: "StartTimeUtc");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "FeedingRecords",
                newName: "EndTimeUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTimeUtc",
                table: "FeedingRecords",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "EndTimeUtc",
                table: "FeedingRecords",
                newName: "EndTime");
        }
    }
}
