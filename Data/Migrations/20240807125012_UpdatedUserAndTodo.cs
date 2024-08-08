using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserAndTodo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Todos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
