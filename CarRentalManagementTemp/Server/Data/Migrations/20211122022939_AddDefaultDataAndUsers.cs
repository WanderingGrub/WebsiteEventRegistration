using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagementTemp.Server.Data.Migrations
{
    public partial class AddDefaultDataAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "02098079-0eca-4663-9419-097b863db12d", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "eab3dd6d-8b76-47c7-8e7e-a87918da717a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "24973134-00ab-4659-9baf-4b73c022547d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKAsTObF1FaQM1whv12HufgFjsObhjh4LJE9nxNDPTYCIAApgeEVNxVGC0ExKAMNFQ==", null, false, "45c9e869-19b1-4a3d-a53f-041635602b7e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 10, 29, 38, 354, DateTimeKind.Local).AddTicks(5834), new DateTime(2021, 11, 22, 10, 29, 38, 356, DateTimeKind.Local).AddTicks(1584), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 10, 29, 38, 356, DateTimeKind.Local).AddTicks(3283), new DateTime(2021, 11, 22, 10, 29, 38, 356, DateTimeKind.Local).AddTicks(3291), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 10, 29, 38, 358, DateTimeKind.Local).AddTicks(5845), new DateTime(2021, 11, 22, 10, 29, 38, 358, DateTimeKind.Local).AddTicks(5884), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 10, 29, 38, 358, DateTimeKind.Local).AddTicks(5891), new DateTime(2021, 11, 22, 10, 29, 38, 358, DateTimeKind.Local).AddTicks(5894), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2872), new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2888), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2894), new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2895), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2898), new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2900), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2903), new DateTime(2021, 11, 22, 10, 29, 38, 359, DateTimeKind.Local).AddTicks(2904), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
