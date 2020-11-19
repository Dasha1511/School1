using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class stst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Old = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pasport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DolznostID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dolznost",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NaimenovanieDolznosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oklad = table.Column<int>(type: "int", nullable: false),
                    Obyazannosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trebovaniya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dolznost", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dolznost_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dolznost_StaffID",
                table: "Dolznost",
                column: "StaffID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dolznost");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
