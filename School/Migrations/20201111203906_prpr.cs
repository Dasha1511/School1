using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class prpr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PredmetsID",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opisanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PredmetsID",
                table: "Staff",
                column: "PredmetsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Predmets_PredmetsID",
                table: "Staff",
                column: "PredmetsID",
                principalTable: "Predmets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Predmets_PredmetsID",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "Predmets");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PredmetsID",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PredmetsID",
                table: "Staff");
        }
    }
}
