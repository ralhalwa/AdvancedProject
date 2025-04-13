using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "Available_ID", "CategoryID", "Condition_ID", "Description", "Image", "Name", "Price" },
                values: new object[] { 1, 1, 1, 1, "Sample equipment description", new byte[0], "Mariam", 100.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
