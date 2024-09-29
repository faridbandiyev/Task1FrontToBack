﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskFrontToBack.DataAccessLayer;

#nullable disable

namespace TaskFrontToBack.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240929135248_NameProperty")]
    partial class NameProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.TeacherStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherStudent");
                });

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.TeacherStudent", b =>
                {
                    b.HasOne("TaskFrontToBack.DataAccessLayer.Entities.Student", "Student")
                        .WithMany("TeacherStudents")
                        .HasForeignKey("StudentId");

                    b.HasOne("TaskFrontToBack.DataAccessLayer.Entities.Teacher", "Teacher")
                        .WithMany("TeacherStudents")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.Student", b =>
                {
                    b.Navigation("TeacherStudents");
                });

            modelBuilder.Entity("TaskFrontToBack.DataAccessLayer.Entities.Teacher", b =>
                {
                    b.Navigation("TeacherStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
