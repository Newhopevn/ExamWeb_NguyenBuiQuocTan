using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenBuiQuocTan.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "GiaBan", "NgheSi", "SoLuong", "TrongNuoc", "TuaCD" },
                values: new object[,]
                {
                    { 1, 105000.0, "Tuấn Vũ", 20, true, "CD Nỗi buồn gác trọ" },
                    { 2, 250000.0, "Chế Linh", 15, true, "CD Bài tình ca đêm" },
                    { 3, 230000.0, "BABYMONSTER", 10, false, "CD BABYMONSTER" },
                    { 4, 150000.0, "Mạnh Quỳnh", 30, true, "CD Chuyện chúng mình" },
                    { 5, 27000.0, "Taylor Swift", 10, false, "CD Today's US-UK Hit " },
                    { 6, 220000.0, "Văn Mai Hương", 40, true, "CD Đoá hồng nhạc việt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
