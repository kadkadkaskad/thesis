using FlagHunter.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlagHunter.Api
{
    public static class SeedData
    {
        public static void FlagHunterDbSeed(this ModelBuilder builder)
        {
            var aliceId = Guid.NewGuid();
            var bobId = Guid.NewGuid();
            var carolId = Guid.NewGuid();
            var davidId = Guid.NewGuid();
            var evaId = Guid.NewGuid();

            builder.Entity<Student>().HasData(
                new Student { Id = aliceId, UserName = "alice", FirstName = "Alice", LastName = "Thompson", Email = "alicet@stud.u-szeged.hu" },
                new Student { Id = bobId, UserName = "bob", FirstName = "Bob", LastName = "Ross", Email = "bobr@stud.u-szeged.hu "},
                new Student { Id = carolId, UserName = "carol", FirstName = "Carol", LastName = "Smith", Email = "carols@stud.u-szeged.hu" }
            );

            builder.Entity<Teacher>().HasData(
                new Teacher { Id = davidId, UserName = "david", FirstName = "David", LastName = "Sanders",Email = "davids@inf.u-szeged.hu" },
                new Teacher { Id = evaId, UserName = "eva", FirstName = "Eva", LastName = "Morgan", Email = "evam@inf.u-szeged.hu" }
            );

            var course1Id = Guid.NewGuid();
            var course2Id = Guid.NewGuid();
            var course3Id = Guid.NewGuid();

            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = course1Id,
                    CourseId = "ib1111",
                    TeacherId = davidId,
                    Name = "Programming I."
                },
                new Course
                {
                    Id = course2Id,
                    CourseId = "ib1112",
                    TeacherId = davidId,
                    Name = "Programming II."
                },
                new Course
                {
                    Id = course3Id,
                    CourseId = "ib1113",
                    TeacherId = evaId,
                    Name = "Linux basics"
                }
            );

            var bashTest = Guid.NewGuid();
            var CPlusPlusTest = Guid.NewGuid();
            var test1 = Guid.NewGuid();
            var test2 = Guid.NewGuid();
            var test3 = Guid.NewGuid();
            var test4 = Guid.NewGuid();


            builder.Entity<Test>().HasData(
                new Test
                {
                    Id = bashTest,
                    Name = "Bash commands basics I.",
                    Description = "Write a command with pipes that lists all the files with 'txt' ending and concats the result into a new 'string'",
                    CourseId = course3Id
                },
                new Test
                {
                    Id = CPlusPlusTest,
                    Name = "C++ classes and encapsulation part I.",
                    Description = "Create a class with the name of Human. The class must include 3 PRIVATE properties: name (string), age (int) and male (bool)." +
                    " You have to create a constructor where you set all of the properties, but you must ensure that the name is a non-empty string and the age is " +
                    "between the 1 and 60 values. You also have to give the male attribute a default value. Last, you have to create an overload for printing out the" +
                    "Human's properties. (overloading ostream's << operator)",
                    CourseId = course2Id,
                    ImageId = "theiaide/theia-cpp",
                    ImagePort = "3000"
                },
                new Test
                {
                    Id = test1,
                    Name = "Test 1",
                    Description = "Description 1",
                    CourseId = course1Id
                },
                new Test
                {
                    Id = test2,
                    Name = "Test 2",
                    Description = "Description 2",
                    CourseId = course1Id
                },
                new Test
                {
                    Id = test3,
                    Name = "Test 3",
                    Description = "Description 3",
                    CourseId = course1Id
                },
                new Test
                {
                    Id = test4,
                    Name = "Test 4",
                    Description = "Description 4",
                    CourseId = course1Id
                }
            );

            builder.Entity<StudentTest>().HasData(
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = bashTest
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = test1
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = test2
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = test3
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = test4
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = aliceId,
                        TestId = CPlusPlusTest
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = bobId,
                        TestId = CPlusPlusTest
                    },
                    new StudentTest
                    {
                        Id = Guid.NewGuid(),
                        Solved = false,
                        Active = true,
                        StudentId = carolId,
                        TestId = CPlusPlusTest
                    }
                );


        }
    }
}
