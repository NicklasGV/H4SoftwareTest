using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace H4SoftwareTest.Migrations.Todo
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAsymmetric",
                table: "Todolist",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAsymmetric",
                table: "Todolist");
        }
    }
}
