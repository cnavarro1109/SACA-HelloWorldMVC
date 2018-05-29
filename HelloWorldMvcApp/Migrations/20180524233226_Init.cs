using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Enrolled = table.Column<bool>(nullable: false),
                    StudentEnrolled = table.Column<int>(nullable: false),
                    StudentName = table.Column<string>(nullable: false),
                    studentGenderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_StudentGender_studentGenderId",
                        column: x => x.studentGenderId,
                        principalTable: "StudentGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "FK_StudentGender_Student_StudentId",
                table: "StudentGender",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentGender_studentGenderId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "StudentGender");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
