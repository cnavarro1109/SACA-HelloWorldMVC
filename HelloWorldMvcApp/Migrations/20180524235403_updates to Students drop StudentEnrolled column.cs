using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HelloWorldMvcApp.Migrations
{
    public partial class updatestoStudentsdropStudentEnrolledcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentEnrolled",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentEnrolled",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }
    }
}
