using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyData.Migrations
{
    /// <inheritdoc />
    public partial class AddDiaperRecordAndTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaperRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    UserId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    BabyId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    ColorCode = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Notes = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    StartTimeUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EndTimeUtc = table.Column<DateTime>(type: "TIMESTAMP", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaperRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(256)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaperTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    TagId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false),
                    DiaperRecordId = table.Column<Guid>(type: "CHAR(16) CHARACTER SET OCTETS", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaperTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiaperTags_DiaperRecords_Di~",
                        column: x => x.DiaperRecordId,
                        principalTable: "DiaperRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaperTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaperTags_DiaperRecordId",
                table: "DiaperTags",
                column: "DiaperRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_DiaperTags_TagId",
                table: "DiaperTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Title",
                table: "Tags",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaperTags");

            migrationBuilder.DropTable(
                name: "DiaperRecords");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
