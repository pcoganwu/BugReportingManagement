using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugReportingManagement.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BugPriorities",
                columns: new[] { "Id", "BugPriorityType" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Medium" },
                    { 3, "High" },
                    { 4, "High" }
                });

            migrationBuilder.InsertData(
                table: "BugStatuses",
                columns: new[] { "Id", "BugStatusType" },
                values: new object[,]
                {
                    { 5, "Completed" },
                    { 4, "Dropped" },
                    { 6, "Closed" },
                    { 2, "Assigned" },
                    { 1, "New" },
                    { 3, "Deferred" }
                });

            migrationBuilder.InsertData(
                table: "ProjectAdmins",
                columns: new[] { "Id", "ConfirmPassword", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "AAAAA", "Peter", "Oganwu", "AAAAA" },
                    { 2, "AAAAA", "John", "Doe", "AAAAA" },
                    { 3, "AAAAA", "Dennis", "Smith", "AAAAA" },
                    { 4, "AAAAA", "Peter", "Brian", "AAAAA" },
                    { 5, "AAAAA", "Brian", "Hale", "AAAAA" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 3, "Some description2", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian Natural Resources" },
                    { 1, "Some description", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reward Bank" },
                    { 2, "Some description1", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TC Energy" },
                    { 4, "Some description3", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "TransAlta" }
                });

            migrationBuilder.InsertData(
                table: "Bugs",
                columns: new[] { "Id", "Attachment", "BugClosedBy", "BugClosedOn", "BugCreatedBy", "BugCreatedOn", "BugPriorityId", "BugResolutionSummary", "BugStatusId", "ProjectId" },
                values: new object[,]
                {
                    { 1, "", "Scott Jackson", new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim Mozin", new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "show denied is including the other statuses - should be isolated to denied only", 1, 1 },
                    { 2, "", "Scott Jackson", new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Oganwu", new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "show denied is including the other statuses - should be isolated to denied only", 2, 1 },
                    { 3, "", "Scott Jackson", new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam Wattt", new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "show denied is including the other statuses - should be isolated to denied only", 2, 2 },
                    { 4, "", "Scott Jackson", new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim Mozin", new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "show denied is including the other statuses - should be isolated to denied only", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Testers",
                columns: new[] { "Id", "FirstName", "LastName", "ProjectId" },
                values: new object[,]
                {
                    { 1, "Peter", "Oganwu", 1 },
                    { 2, "John", "Doe", 2 },
                    { 3, "Dennis", "Smith", 2 },
                    { 4, "Peter", "Brian", 3 },
                    { 5, "Brian", "Hale", 4 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "Email", "FirstName", "LastName", "Password", "Phone", "ProjectId" },
                values: new object[,]
                {
                    { 1, "AAAAA", "abc@abc.com", "Peter", "Oganwu", "AAAAA", "403-123-1111", 1 },
                    { 2, "AAAAA", "abc@abc.com", "John", "Doe", "AAAAA", "403-123-2222", 2 },
                    { 3, "AAAAA", "abc@abc.com", "Dennis", "Smith", "AAAAA", "403-123-3333", 3 },
                    { 4, "AAAAA", "abc@abc.com", "Peter", "Brian", "AAAAA", "403-123-4444", 4 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "TesterId" },
                values: new object[,]
                {
                    { 1, "Test Server", 1 },
                    { 3, "Production Server", 2 },
                    { 2, "Production Server", 3 },
                    { 4, "Test Server", 4 },
                    { 5, "Test Server", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BugPriorities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BugPriorities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bugs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectAdmins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectAdmins",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectAdmins",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectAdmins",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectAdmins",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BugPriorities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BugPriorities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BugStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Testers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Testers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Testers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
