﻿// <auto-generated />
using HelloWorldMvcApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HelloWorldMvcApp.Migrations
{
    [DbContext(typeof(HelloWorldContext))]
    [Migration("20180524233226_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelloWorldMvcApp.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Enrolled");

                    b.Property<int>("StudentEnrolled");

                    b.Property<string>("StudentName")
                        .IsRequired();

                    b.Property<int>("studentGenderId");

                    b.HasKey("StudentId");

                    b.HasIndex("studentGenderId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("HelloWorldMvcApp.Models.StudentGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentGender");
                });

            modelBuilder.Entity("HelloWorldMvcApp.Models.Student", b =>
                {
                    b.HasOne("HelloWorldMvcApp.Models.StudentGender", "StudentGender")
                        .WithMany()
                        .HasForeignKey("studentGenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HelloWorldMvcApp.Models.StudentGender", b =>
                {
                    b.HasOne("HelloWorldMvcApp.Models.Student")
                        .WithMany("Genders")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
