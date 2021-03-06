﻿// <auto-generated />
using System;
using FlagHunter.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlagHunter.Api.Migrations
{
    [DbContext(typeof(FlagHunterDbContext))]
    [Migration("20201203122352_december_03")]
    partial class december_03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlagHunter.Api.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"),
                            CourseId = "ib1111",
                            Name = "Programming I.",
                            TeacherId = new Guid("1a2dafce-1353-461f-9f19-cb27318e472c")
                        },
                        new
                        {
                            Id = new Guid("10eff2f6-d224-4882-ae8e-ebf051d36459"),
                            CourseId = "ib1112",
                            Name = "Programming II.",
                            TeacherId = new Guid("1a2dafce-1353-461f-9f19-cb27318e472c")
                        },
                        new
                        {
                            Id = new Guid("ee79fec4-0e07-4dfc-a449-1bdf820314d8"),
                            CourseId = "ib1113",
                            Name = "Linux basics",
                            TeacherId = new Guid("7fe9ef0f-2a5e-435d-b5af-b2641c3394c6")
                        });
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            Email = "alicet@stud.u-szeged.hu",
                            FirstName = "Alice",
                            LastName = "Thompson",
                            UserName = "alice"
                        },
                        new
                        {
                            Id = new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"),
                            Email = "bobr@stud.u-szeged.hu ",
                            FirstName = "Bob",
                            LastName = "Ross",
                            UserName = "bob"
                        },
                        new
                        {
                            Id = new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"),
                            Email = "carols@stud.u-szeged.hu",
                            FirstName = "Carol",
                            LastName = "Smith",
                            UserName = "carol"
                        });
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.StudentTest", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Solved")
                        .HasColumnType("bit");

                    b.HasKey("StudentId", "TestId");

                    b.HasIndex("TestId");

                    b.ToTable("StudentTests");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892"),
                            Active = true,
                            Id = new Guid("3f1e4b3f-1237-4fd9-a765-a1306efe2050"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff"),
                            Active = true,
                            Id = new Guid("a35f6530-e114-43dc-a8ce-7c41c00d2e17"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e"),
                            Active = true,
                            Id = new Guid("d7a78a22-a8f8-4471-881a-05a16caf5c29"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b"),
                            Active = true,
                            Id = new Guid("38d705db-86ce-4328-8dc3-0c82131154d9"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240"),
                            Active = true,
                            Id = new Guid("8cc64b47-a042-464d-8b03-d362c6eab8fb"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"),
                            TestId = new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"),
                            Active = true,
                            Id = new Guid("42b479e7-edce-4126-909c-6235696bbd8f"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"),
                            TestId = new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"),
                            Active = true,
                            Id = new Guid("9c7e1ac6-bcde-412f-bce4-ce79c47434d7"),
                            Solved = false
                        },
                        new
                        {
                            StudentId = new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"),
                            TestId = new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"),
                            Active = true,
                            Id = new Guid("6867f764-1ec2-4212-9270-6c60d6b97db8"),
                            Solved = false
                        });
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a2dafce-1353-461f-9f19-cb27318e472c"),
                            Email = "davids@inf.u-szeged.hu",
                            FirstName = "David",
                            LastName = "Sanders",
                            UserName = "david"
                        },
                        new
                        {
                            Id = new Guid("7fe9ef0f-2a5e-435d-b5af-b2641c3394c6"),
                            Email = "evam@inf.u-szeged.hu",
                            FirstName = "Eva",
                            LastName = "Morgan",
                            UserName = "eva"
                        });
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892"),
                            CourseId = new Guid("ee79fec4-0e07-4dfc-a449-1bdf820314d8"),
                            Description = "Write a command with pipes that lists all the files with 'txt' ending and concats the result into a new 'string'",
                            Name = "Bash commands basics I."
                        },
                        new
                        {
                            Id = new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"),
                            CourseId = new Guid("10eff2f6-d224-4882-ae8e-ebf051d36459"),
                            Description = "Create a class with the name of Human. The class must include 3 PRIVATE properties: name (string), age (int) and male (bool). You have to create a constructor where you set all of the properties, but you must ensure that the name is a non-empty string and the age is between the 1 and 60 values. You also have to give the male attribute a default value. Last, you have to create an overload for printing out theHuman's properties. (overloading ostream's << operator)",
                            ImageId = "theiaide/theia-cpp",
                            ImagePort = "3000",
                            Name = "C++ classes and encapsulation part I."
                        },
                        new
                        {
                            Id = new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff"),
                            CourseId = new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"),
                            Description = "Description 1",
                            Name = "Test 1"
                        },
                        new
                        {
                            Id = new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e"),
                            CourseId = new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"),
                            Description = "Description 2",
                            Name = "Test 2"
                        },
                        new
                        {
                            Id = new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b"),
                            CourseId = new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"),
                            Description = "Description 3",
                            Name = "Test 3"
                        },
                        new
                        {
                            Id = new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240"),
                            CourseId = new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"),
                            Description = "Description 4",
                            Name = "Test 4"
                        });
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.Course", b =>
                {
                    b.HasOne("FlagHunter.Api.Entities.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.StudentTest", b =>
                {
                    b.HasOne("FlagHunter.Api.Entities.Student", "Student")
                        .WithMany("StudentTests")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlagHunter.Api.Entities.Test", "Test")
                        .WithMany("StudentTests")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlagHunter.Api.Entities.Test", b =>
                {
                    b.HasOne("FlagHunter.Api.Entities.Course", "Course")
                        .WithMany("Tests")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
