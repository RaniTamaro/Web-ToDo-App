using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace todo_domain_entities.Migrations
{
    public partial class ToDoApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    ListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.ListId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskStatus = table.Column<int>(type: "int", nullable: false),
                    TaskTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: true),
                    TaskCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskRemindDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ListId = table.Column<int>(type: "int", nullable: false),
                    TDListListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Lists_TDListListId",
                        column: x => x.TDListListId,
                        principalTable: "Lists",
                        principalColumn: "ListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TDListListId",
                table: "Tasks",
                column: "TDListListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Lists");
        }
    }
}
