using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class updatestoStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentGender_studentGenderId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "StudentGender");

            migrationBuilder.DropIndex(
                name: "IX_Student_studentGenderId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "studentGenderId",
                table: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentGenderId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGender_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_studentGenderId",
                table: "Student",
                column: "studentGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGender_StudentId",
                table: "StudentGender",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentGender_studentGenderId",
                table: "Student",
                column: "studentGenderId",
                principalTable: "StudentGender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
