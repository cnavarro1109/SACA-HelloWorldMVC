using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class updatestoStudentsforeignkeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGenders_Students_StudentId",
                table: "StudentGenders");

            migrationBuilder.DropIndex(
                name: "IX_StudentGenders_StudentId",
                table: "StudentGenders");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentGenders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentGenders",
                nullable: true);

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
        }
    }
}
