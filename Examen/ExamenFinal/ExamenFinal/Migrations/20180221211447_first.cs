using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ExamenFinal.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MultChoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerA = table.Column<string>(nullable: false),
                    AnswerB = table.Column<string>(nullable: true),
                    AnswerC = table.Column<string>(nullable: true),
                    AnswerD = table.Column<string>(nullable: true),
                    HasTickA = table.Column<bool>(nullable: false),
                    HasTickB = table.Column<bool>(nullable: false),
                    HasTickC = table.Column<bool>(nullable: false),
                    HasTickD = table.Column<bool>(nullable: false),
                    Question = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultChoice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MultChoice");
        }
    }
}
