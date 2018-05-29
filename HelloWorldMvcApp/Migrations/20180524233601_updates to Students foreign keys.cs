using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class updatestoStudentsforeignkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentGenderId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentGenders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_studentGenderId",
                table: "Students",
                column: "studentGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGenders_StudentId",
                table: "StudentGenders",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGenders_Students_StudentId",
                table: "StudentGenders",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGenders_studentGenderId",
                table: "Students",
                column: "studentGenderId",
                principalTable: "StudentGenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGenders_Students_StudentId",
                table: "StudentGenders");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGenders_studentGenderId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_studentGenderId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentGenders_StudentId",
                table: "StudentGenders");

            migrationBuilder.DropColumn(
                name: "studentGenderId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentGenders");
        }
    }
}
