﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestMVC.Data;

#nullable disable

namespace TestMVC.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestMVC.Models.Classroom", b =>
                {
                    b.Property<int>("Classroom_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Classroom_Number")
                        .HasColumnType("int");

                    b.HasKey("Classroom_ID");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("TestMVC.Models.Group", b =>
                {
                    b.Property<int>("Group_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Group_Number")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Group_ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TestMVC.Models.Lesson", b =>
                {
                    b.Property<int>("Lesson_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Classroom_Number")
                        .HasColumnType("int");

                    b.Property<int>("Lesson_GroupNumber")
                        .HasColumnType("int");

                    b.Property<string>("Lesson_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Lesson_Number")
                        .HasColumnType("int");

                    b.Property<string>("Weekday")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Lesson_ID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("TestMVC.Models.Student", b =>
                {
                    b.Property<int>("Student_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Group_Number")
                        .HasColumnType("int");

                    b.Property<string>("Student_Fio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Student_ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TestMVC.Models.Teacher", b =>
                {
                    b.Property<int>("Teacher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Lesson_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Teacher_Fio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Teacher_ID");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
