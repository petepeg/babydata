using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyData.Migrations
{
    /// <inheritdoc />
    public partial class AddSleepRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SleepRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    UserId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    BabyId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Notes = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    StartTimeUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EndTimeUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepRecords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SleepRecords");
        }
    }
}
