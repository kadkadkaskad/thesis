using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlagHunter.Api.Migrations
{
    public partial class november : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TeacherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageId = table.Column<string>(nullable: true),
                    CourseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTests",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    TestId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Solved = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTests", x => new { x.StudentId, x.TestId });
                    table.ForeignKey(
                        name: "FK_StudentTests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), "alicet@stud.u-szeged.hu", "Alice", "Thompson", "alice" },
                    { new Guid("edbf9650-1608-4306-8746-a806b9245609"), "bobr@stud.u-szeged.hu ", "Bob", "Ross", "bob" },
                    { new Guid("6a30e5fe-b3be-481a-83f6-f6cf110df128"), "carols@stud.u-szeged.hu", "Carol", "Smith", "carol" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("b9941aa8-a37e-4556-a370-b3d7e9928383"), "davids@inf.u-szeged.hu", "David", "Sanders", "david" },
                    { new Guid("9f93e652-b6f6-44d4-995f-d27a41ec67a8"), "evam@inf.u-szeged.hu", "Eva", "Morgan", "eva" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"), "ib1111", "Programming I.", new Guid("b9941aa8-a37e-4556-a370-b3d7e9928383") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("0f825d31-1f0b-47d5-85a1-f10c2798b81d"), "ib1112", "Programming II.", new Guid("b9941aa8-a37e-4556-a370-b3d7e9928383") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("ac829de8-276b-494f-b4ac-0027ff23c210"), "ib1113", "Linux basics", new Guid("9f93e652-b6f6-44d4-995f-d27a41ec67a8") });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "CourseId", "Description", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("3b6062df-e6c1-43b7-b71a-fe634eff8bab"), new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"), "Description 1", null, "Test 1" },
                    { new Guid("1729d331-e558-4e69-bdf3-a18998869764"), new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"), "Description 2", null, "Test 2" },
                    { new Guid("d3a1a54d-9968-4f36-a830-92d37c3af724"), new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"), "Description 3", null, "Test 3" },
                    { new Guid("d36fd7bc-ab7b-4bf0-af19-83da4f1c68cb"), new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"), "Description 4", null, "Test 4" },
                    { new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301"), new Guid("0f825d31-1f0b-47d5-85a1-f10c2798b81d"), "Create a class with the name of Human. The class must include 3 PRIVATE properties: name (string), age (int) and male (bool). You have to create a constructor where you set all of the properties, but you must ensure that the name is a non-empty string and the age is between the 1 and 60 values. You also have to give the male attribute a default value. Last, you have to create an overload for printing out theHuman's properties. (overloading ostream's << operator)", null, "C++ classes and encapsulation part I." },
                    { new Guid("917f3950-f008-4881-bf12-e917e128359c"), new Guid("ac829de8-276b-494f-b4ac-0027ff23c210"), "Write a command with pipes that lists all the files with 'txt' ending and concats the result into a new 'string'", null, "Bash commands basics I." }
                });

            migrationBuilder.InsertData(
                table: "StudentTests",
                columns: new[] { "StudentId", "TestId", "Active", "Id", "Solved" },
                values: new object[,]
                {
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("3b6062df-e6c1-43b7-b71a-fe634eff8bab"), true, new Guid("3055cf85-ee03-434d-8a57-0e5599fd169c"), false },
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("1729d331-e558-4e69-bdf3-a18998869764"), true, new Guid("20aa118c-1463-439b-af16-91819b1e3302"), false },
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("d3a1a54d-9968-4f36-a830-92d37c3af724"), true, new Guid("f4ff138d-a54e-4439-a24f-456bf967afde"), false },
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("d36fd7bc-ab7b-4bf0-af19-83da4f1c68cb"), true, new Guid("3dcf2f80-404e-4306-aa6c-266a2ae1e3f5"), false },
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301"), true, new Guid("1529e3bd-292c-4791-bc48-d2eaaf819b64"), false },
                    { new Guid("edbf9650-1608-4306-8746-a806b9245609"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301"), true, new Guid("63cae9a1-44df-449c-a1cd-2b36fb18a2b6"), false },
                    { new Guid("6a30e5fe-b3be-481a-83f6-f6cf110df128"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301"), true, new Guid("35caa14a-053a-4703-a6db-d6cfb50e790e"), false },
                    { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("917f3950-f008-4881-bf12-e917e128359c"), true, new Guid("90f76b05-849d-44e7-a021-1b68ec3037c5"), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTests_TestId",
                table: "StudentTests",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_CourseId",
                table: "Tests",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
