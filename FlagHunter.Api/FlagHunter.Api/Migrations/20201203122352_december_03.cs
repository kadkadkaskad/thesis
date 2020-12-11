using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlagHunter.Api.Migrations
{
    public partial class december_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("1729d331-e558-4e69-bdf3-a18998869764") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("3b6062df-e6c1-43b7-b71a-fe634eff8bab") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("917f3950-f008-4881-bf12-e917e128359c") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("d36fd7bc-ab7b-4bf0-af19-83da4f1c68cb") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"), new Guid("d3a1a54d-9968-4f36-a830-92d37c3af724") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("6a30e5fe-b3be-481a-83f6-f6cf110df128"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("edbf9650-1608-4306-8746-a806b9245609"), new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1e0621b5-1715-4981-9c57-3851d7ed88e3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6a30e5fe-b3be-481a-83f6-f6cf110df128"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("edbf9650-1608-4306-8746-a806b9245609"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("1729d331-e558-4e69-bdf3-a18998869764"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("3b6062df-e6c1-43b7-b71a-fe634eff8bab"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("7dc5d6af-d49e-408b-834a-1d7989d7c301"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("917f3950-f008-4881-bf12-e917e128359c"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("d36fd7bc-ab7b-4bf0-af19-83da4f1c68cb"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("d3a1a54d-9968-4f36-a830-92d37c3af724"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0d394e4a-a9d4-4c30-b7a4-7583a760b402"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0f825d31-1f0b-47d5-85a1-f10c2798b81d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ac829de8-276b-494f-b4ac-0027ff23c210"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9f93e652-b6f6-44d4-995f-d27a41ec67a8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b9941aa8-a37e-4556-a370-b3d7e9928383"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePort",
                table: "Tests",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), "alicet@stud.u-szeged.hu", "Alice", "Thompson", "alice" },
                    { new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"), "bobr@stud.u-szeged.hu ", "Bob", "Ross", "bob" },
                    { new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"), "carols@stud.u-szeged.hu", "Carol", "Smith", "carol" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("1a2dafce-1353-461f-9f19-cb27318e472c"), "davids@inf.u-szeged.hu", "David", "Sanders", "david" },
                    { new Guid("7fe9ef0f-2a5e-435d-b5af-b2641c3394c6"), "evam@inf.u-szeged.hu", "Eva", "Morgan", "eva" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"), "ib1111", "Programming I.", new Guid("1a2dafce-1353-461f-9f19-cb27318e472c") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("10eff2f6-d224-4882-ae8e-ebf051d36459"), "ib1112", "Programming II.", new Guid("1a2dafce-1353-461f-9f19-cb27318e472c") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseId", "Name", "TeacherId" },
                values: new object[] { new Guid("ee79fec4-0e07-4dfc-a449-1bdf820314d8"), "ib1113", "Linux basics", new Guid("7fe9ef0f-2a5e-435d-b5af-b2641c3394c6") });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "CourseId", "Description", "ImageId", "ImagePort", "Name" },
                values: new object[,]
                {
                    { new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff"), new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"), "Description 1", null, null, "Test 1" },
                    { new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e"), new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"), "Description 2", null, null, "Test 2" },
                    { new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b"), new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"), "Description 3", null, null, "Test 3" },
                    { new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240"), new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"), "Description 4", null, null, "Test 4" },
                    { new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"), new Guid("10eff2f6-d224-4882-ae8e-ebf051d36459"), "Create a class with the name of Human. The class must include 3 PRIVATE properties: name (string), age (int) and male (bool). You have to create a constructor where you set all of the properties, but you must ensure that the name is a non-empty string and the age is between the 1 and 60 values. You also have to give the male attribute a default value. Last, you have to create an overload for printing out theHuman's properties. (overloading ostream's << operator)", "theiaide/theia-cpp", "3000", "C++ classes and encapsulation part I." },
                    { new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892"), new Guid("ee79fec4-0e07-4dfc-a449-1bdf820314d8"), "Write a command with pipes that lists all the files with 'txt' ending and concats the result into a new 'string'", null, null, "Bash commands basics I." }
                });

            migrationBuilder.InsertData(
                table: "StudentTests",
                columns: new[] { "StudentId", "TestId", "Active", "Id", "Solved" },
                values: new object[,]
                {
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff"), true, new Guid("a35f6530-e114-43dc-a8ce-7c41c00d2e17"), false },
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e"), true, new Guid("d7a78a22-a8f8-4471-881a-05a16caf5c29"), false },
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b"), true, new Guid("38d705db-86ce-4328-8dc3-0c82131154d9"), false },
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240"), true, new Guid("8cc64b47-a042-464d-8b03-d362c6eab8fb"), false },
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"), true, new Guid("42b479e7-edce-4126-909c-6235696bbd8f"), false },
                    { new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"), true, new Guid("9c7e1ac6-bcde-412f-bce4-ce79c47434d7"), false },
                    { new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"), true, new Guid("6867f764-1ec2-4212-9270-6c60d6b97db8"), false },
                    { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892"), true, new Guid("3f1e4b3f-1237-4fd9-a765-a1306efe2050"), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"), new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240") });

            migrationBuilder.DeleteData(
                table: "StudentTests",
                keyColumns: new[] { "StudentId", "TestId" },
                keyValues: new object[] { new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"), new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8") });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6ff16b9e-f5be-4141-875c-82b8f94bcf0e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("93f570f8-5ccb-40b5-b4b9-3fabc2d1c1b9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a7bcfb5e-0ab1-4705-8f01-ac59f9e6ce4a"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("1286f6ba-de1d-48bf-a4a3-876e133b492b"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("73a99e36-9605-4500-90c7-26f3d4d28ed8"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("9eb460c4-e362-4fa0-89c4-ec5fa3a6c18e"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("cea9b38a-85e1-4cb2-9279-9ea527100892"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("e9030726-6ae4-4f94-b624-3fcdaab87aff"));

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: new Guid("fa67d54f-1858-4b88-89ad-cec3a5df7240"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("10eff2f6-d224-4882-ae8e-ebf051d36459"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e87e9356-7398-4398-a03f-67353bc0af7c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ee79fec4-0e07-4dfc-a449-1bdf820314d8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1a2dafce-1353-461f-9f19-cb27318e472c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7fe9ef0f-2a5e-435d-b5af-b2641c3394c6"));

            migrationBuilder.DropColumn(
                name: "ImagePort",
                table: "Tests");

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
        }
    }
}
