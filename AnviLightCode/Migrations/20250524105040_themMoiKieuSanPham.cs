using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnviLightCode.Migrations
{
    /// <inheritdoc />
    public partial class themMoiKieuSanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KieuSanPham",
                table: "LoaiSanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KieuSanPham",
                table: "LoaiSanPhams");
        }
    }
}
