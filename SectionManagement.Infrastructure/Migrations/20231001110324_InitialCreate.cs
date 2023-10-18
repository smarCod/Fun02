using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SectionManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostPort",
                columns: table => new
                {
                    PortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostPort", x => x.PortId);
                });

            migrationBuilder.CreateTable(
                name: "PostSection",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSection", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "PostUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostSectionSingle",
                columns: table => new
                {
                    SectionSingleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionTyp = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSectionSingle", x => x.SectionSingleId);
                    table.ForeignKey(
                        name: "FK_PostSectionSingle_PostSection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "PostSection",
                        principalColumn: "SectionId");
                });

            migrationBuilder.CreateTable(
                name: "PostDevice",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionSingleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDevice", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_PostDevice_PostSectionSingle_SectionSingleId",
                        column: x => x.SectionSingleId,
                        principalTable: "PostSectionSingle",
                        principalColumn: "SectionSingleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostSectionSinglePort",
                columns: table => new
                {
                    SectionSingleId = table.Column<int>(type: "int", nullable: false),
                    PortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSectionSinglePort", x => new { x.SectionSingleId, x.PortId });
                    table.ForeignKey(
                        name: "FK_PostSectionSinglePort_PostPort_PortId",
                        column: x => x.PortId,
                        principalTable: "PostPort",
                        principalColumn: "PortId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostSectionSinglePort_PostSectionSingle_SectionSingleId",
                        column: x => x.SectionSingleId,
                        principalTable: "PostSectionSingle",
                        principalColumn: "SectionSingleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostDevice_SectionSingleId",
                table: "PostDevice",
                column: "SectionSingleId");

            migrationBuilder.CreateIndex(
                name: "IX_PostSectionSingle_SectionId",
                table: "PostSectionSingle",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostSectionSinglePort_PortId",
                table: "PostSectionSinglePort",
                column: "PortId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostDevice");

            migrationBuilder.DropTable(
                name: "PostSectionSinglePort");

            migrationBuilder.DropTable(
                name: "PostUser");

            migrationBuilder.DropTable(
                name: "PostPort");

            migrationBuilder.DropTable(
                name: "PostSectionSingle");

            migrationBuilder.DropTable(
                name: "PostSection");
        }
    }
}
