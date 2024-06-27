using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenBuiQuocTan.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaNhacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaCD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NgheSi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaNhacs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaNhacs");
        }
    }
}
