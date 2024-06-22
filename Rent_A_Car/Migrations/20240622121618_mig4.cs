using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rent_A_Car.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DestinationLocations",
                columns: table => new
                {
                    DestinationLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationLocations", x => x.DestinationLocationID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingLocations",
                columns: table => new
                {
                    ReceivingLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingLocations", x => x.ReceivingLocationID);
                });

            migrationBuilder.CreateTable(
                name: "RentACars",
                columns: table => new
                {
                    RentACarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PckUpDate = table.Column<DateTime>(type: "Date", nullable: false),
                    DropOffDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ReceivingLocationID = table.Column<int>(type: "int", nullable: false),
                    DestinationLocationID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentACars", x => x.RentACarID);
                    table.ForeignKey(
                        name: "FK_RentACars_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACars_DestinationLocations_DestinationLocationID",
                        column: x => x.DestinationLocationID,
                        principalTable: "DestinationLocations",
                        principalColumn: "DestinationLocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentACars_ReceivingLocations_ReceivingLocationID",
                        column: x => x.ReceivingLocationID,
                        principalTable: "ReceivingLocations",
                        principalColumn: "ReceivingLocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_CarID",
                table: "RentACars",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_DestinationLocationID",
                table: "RentACars",
                column: "DestinationLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_ReceivingLocationID",
                table: "RentACars",
                column: "ReceivingLocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentACars");

            migrationBuilder.DropTable(
                name: "DestinationLocations");

            migrationBuilder.DropTable(
                name: "ReceivingLocations");
        }
    }
}
