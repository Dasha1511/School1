using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class rara : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ID_type",
                table: "Vid",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ID_staff",
                table: "Staff",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ID_Predmets",
                table: "Predmets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RaspisanieID",
                table: "Predmets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ID_Dolznost",
                table: "Dolznost",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ID_class",
                table: "Class",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RaspisanieID",
                table: "Class",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Raspisanie",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dennedely = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassID = table.Column<long>(type: "bigint", nullable: true),
                    PredmetsID = table.Column<long>(type: "bigint", nullable: true),
                    Vremanachala = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vremaokonch = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raspisanie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Predmets_RaspisanieID",
                table: "Predmets",
                column: "RaspisanieID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_RaspisanieID",
                table: "Class",
                column: "RaspisanieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Raspisanie_RaspisanieID",
                table: "Class",
                column: "RaspisanieID",
                principalTable: "Raspisanie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Predmets_Raspisanie_RaspisanieID",
                table: "Predmets",
                column: "RaspisanieID",
                principalTable: "Raspisanie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Raspisanie_RaspisanieID",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Predmets_Raspisanie_RaspisanieID",
                table: "Predmets");

            migrationBuilder.DropTable(
                name: "Raspisanie");

            migrationBuilder.DropIndex(
                name: "IX_Predmets_RaspisanieID",
                table: "Predmets");

            migrationBuilder.DropIndex(
                name: "IX_Class_RaspisanieID",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "ID_type",
                table: "Vid");

            migrationBuilder.DropColumn(
                name: "ID_staff",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "ID_Predmets",
                table: "Predmets");

            migrationBuilder.DropColumn(
                name: "RaspisanieID",
                table: "Predmets");

            migrationBuilder.DropColumn(
                name: "ID_Dolznost",
                table: "Dolznost");

            migrationBuilder.DropColumn(
                name: "ID_class",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "RaspisanieID",
                table: "Class");
        }
    }
}
