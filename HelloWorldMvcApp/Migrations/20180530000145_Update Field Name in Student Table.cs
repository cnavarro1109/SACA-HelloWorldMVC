using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class UpdateFieldNameinStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGenders_studentGenderId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "studentGenderId",
                table: "Students",
                newName: "StudentGenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_studentGenderId",
                table: "Students",
                newName: "IX_Students_StudentGenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGenders_StudentGenderId",
                table: "Students",
                column: "StudentGenderId",
                principalTable: "StudentGenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentGenders_StudentGenderId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentGenderId",
                table: "Students",
                newName: "studentGenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentGenderId",
                table: "Students",
                newName: "IX_Students_studentGenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentGenders_studentGenderId",
                table: "Students",
                column: "studentGenderId",
                principalTable: "StudentGenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
