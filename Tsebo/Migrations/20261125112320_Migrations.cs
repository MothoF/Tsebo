using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tsebo.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleCode = table.Column<string>(type: "text", nullable: false),
                    ModuleName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleCode);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicCode = table.Column<string>(type: "text", nullable: false),
                    TopicName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicCode);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Concepts",
                columns: table => new
                {
                    ConceptCode = table.Column<string>(type: "text", nullable: false),
                    ConceptName = table.Column<string>(type: "text", nullable: false),
                    TopicCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepts", x => x.ConceptCode);
                    table.ForeignKey(
                        name: "FK_Concepts_Topics_TopicCode",
                        column: x => x.TopicCode,
                        principalTable: "Topics",
                        principalColumn: "TopicCode");
                });

            migrationBuilder.CreateTable(
                name: "ModuleTopics",
                columns: table => new
                {
                    ModuleCode = table.Column<string>(type: "text", nullable: false),
                    TopicCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleTopics", x => new { x.ModuleCode, x.TopicCode });
                    table.ForeignKey(
                        name: "FK_ModuleTopics_Modules_ModuleCode",
                        column: x => x.ModuleCode,
                        principalTable: "Modules",
                        principalColumn: "ModuleCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleTopics_Topics_TopicCode",
                        column: x => x.TopicCode,
                        principalTable: "Topics",
                        principalColumn: "TopicCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTasks",
                columns: table => new
                {
                    Username = table.Column<string>(type: "text", nullable: false),
                    ConceptCode = table.Column<string>(type: "text", nullable: false),
                    Deadline = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Priority = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTasks", x => new { x.Username, x.ConceptCode });
                    table.ForeignKey(
                        name: "FK_UserTasks_Concepts_ConceptCode",
                        column: x => x.ConceptCode,
                        principalTable: "Concepts",
                        principalColumn: "ConceptCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTasks_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concepts_TopicCode",
                table: "Concepts",
                column: "TopicCode");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleTopics_TopicCode",
                table: "ModuleTopics",
                column: "TopicCode");

            migrationBuilder.CreateIndex(
                name: "IX_UserTasks_ConceptCode",
                table: "UserTasks",
                column: "ConceptCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleTopics");

            migrationBuilder.DropTable(
                name: "UserTasks");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Concepts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
