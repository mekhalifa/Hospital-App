using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class AddLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fb50189-2253-4071-a798-92caf3399b31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f19bff-69b4-4a72-8aca-aeb509bd2fa0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68eb055c-008a-441a-935e-1a6b8c22e191");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4f271ad-2bb0-4b6f-a04b-1c7271ba945e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2bd4b66-891b-4bfd-bb96-ff6bdd8f99f0");

            migrationBuilder.CreateTable(
                name: "Dblogs",
                columns: table => new
                {
                    LogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindLog = table.Column<string>(nullable: true),
                    CheckLog = table.Column<string>(nullable: true),
                    UserNameLog = table.Column<string>(nullable: true),
                    UserIdLog = table.Column<string>(nullable: true),
                    LocalIP = table.Column<string>(nullable: true),
                    EntryDateLog = table.Column<DateTime>(nullable: true),
                    LogOutDateLog = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dblogs", x => x.LogId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FullName", "IsActive", "KindOfEmployeeId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a6eb3eeb-9893-428a-acb7-0c65b2913c9d", 0, "1ae381a8-78df-45cb-8a26-9e2c458324f3", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "2c2a92d6-7b0a-4f7f-90a1-48c3a92efea9", false, "username1" },
                    { "5b9d2bf5-31b0-426f-bdf7-f7eaad22b718", 0, "f1a52876-96b7-4cf4-9f91-d68f9994abe5", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "092b666d-8dd4-4c05-823e-6aaf304b2440", false, "username2" },
                    { "ac31a5e7-56a6-4ef3-bee6-45bcd17461d8", 0, "4015c417-7bde-4cd5-b50d-deffb1d3c7d4", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "bd8ecbad-1ad6-4452-9b1b-883ec44de687", false, "username3" },
                    { "a07a6f80-bd8a-4056-91a2-556d7db0e07c", 0, "80de21b4-fa7a-4ff1-bdee-6e818b431d97", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "8b1d4197-f7a1-45ca-966d-8098db525585", false, "username4" },
                    { "b2573086-4c46-4757-b291-6697a254f831", 0, "90070dff-5a88-4839-a1a8-8cd67f35de16", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "5f6cf524-0069-4a51-b298-b6c549133298", false, "username5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dblogs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b9d2bf5-31b0-426f-bdf7-f7eaad22b718");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a07a6f80-bd8a-4056-91a2-556d7db0e07c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6eb3eeb-9893-428a-acb7-0c65b2913c9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac31a5e7-56a6-4ef3-bee6-45bcd17461d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2573086-4c46-4757-b291-6697a254f831");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FullName", "IsActive", "KindOfEmployeeId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b4f271ad-2bb0-4b6f-a04b-1c7271ba945e", 0, "6f053928-0f90-41af-99c9-7f2193b83f20", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "703bbfc5-91d2-4265-ac87-4be90b7c2d7f", false, "username1" },
                    { "68eb055c-008a-441a-935e-1a6b8c22e191", 0, "ab440301-31cc-4b55-a2c9-e0972d89b8f6", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "d320bfea-e187-495c-84ea-e97641eed82a", false, "username2" },
                    { "59f19bff-69b4-4a72-8aca-aeb509bd2fa0", 0, "37579cf9-a359-4874-936a-04813a625cef", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "c6ec162e-02b5-4f9c-9262-4b439969950e", false, "username3" },
                    { "f2bd4b66-891b-4bfd-bb96-ff6bdd8f99f0", 0, "c63dac30-5d88-4945-8c95-51be7709ac31", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "b8e30d83-8ff1-4f96-8782-6a9608861f6f", false, "username4" },
                    { "4fb50189-2253-4071-a798-92caf3399b31", 0, "d53e3c9b-2bbd-4f73-9aeb-4796e88697bb", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "51ceb294-96f6-4459-8e43-95394a9b14ce", false, "username5" }
                });
        }
    }
}
