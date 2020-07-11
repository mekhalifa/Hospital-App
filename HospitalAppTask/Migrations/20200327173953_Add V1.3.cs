using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class AddV13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02453b52-d523-456b-9e64-f37d98569aab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f3f0db0-176c-4343-99e2-69f2d81aaaef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d97457cc-fa9b-4f53-b4ef-783aababea45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9db0ea8-2811-4e85-a089-f9683c758554");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe04144a-b6ad-4764-acc0-0a8409683a9a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FullName", "IsActive", "KindOfEmployeeId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24545dd7-ec98-4084-8204-466b7acc180f", 0, "2ceab68d-61ad-4190-b80b-b5d7ee85b04b", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "6bbc4d41-67bc-4d43-984e-d0c21ac2a58b", false, "username1" },
                    { "12cb7eb2-eaa3-4a46-8052-03482e45ac10", 0, "211c40dc-e83c-4821-8f9d-a641bfec48d4", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "2558e650-8fc8-4e27-8e77-9ce23dbe6184", false, "username2" },
                    { "a36e811e-5bca-49d3-8713-395c388b3258", 0, "f62b2a64-435f-4d51-bbe7-674258a9f533", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "0985aab8-2982-421c-a5ad-f768f0fdcb0a", false, "username3" },
                    { "ab320ffe-c07b-4705-98b6-4536ed8101cd", 0, "8e23ba5e-9c65-45a1-a560-5d1af3f5b9e4", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "b9a0ab34-6249-4d55-8967-191997443e50", false, "username4" },
                    { "9206681a-07d0-46f9-9428-a2b297a73125", 0, "74a06f6e-a178-4fb0-9a14-60aba6dafa15", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "fb6e41d7-dd95-44e8-a54c-38ec326fe01f", false, "username5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers",
                column: "KindOfEmployeeId",
                unique: true,
                filter: "[KindOfEmployeeId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12cb7eb2-eaa3-4a46-8052-03482e45ac10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24545dd7-ec98-4084-8204-466b7acc180f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9206681a-07d0-46f9-9428-a2b297a73125");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a36e811e-5bca-49d3-8713-395c388b3258");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab320ffe-c07b-4705-98b6-4536ed8101cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FullName", "IsActive", "KindOfEmployeeId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fe04144a-b6ad-4764-acc0-0a8409683a9a", 0, "4ef71d37-b71b-4976-83f8-1a1d31aeb2b3", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "57afe6ab-6ed4-4692-9417-ca255ed8627d", false, "username1" },
                    { "f9db0ea8-2811-4e85-a089-f9683c758554", 0, "93a75052-2dfa-4670-a3ed-c082c8ba4785", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "ff56be7c-f045-475c-a64b-6163b6c0a034", false, "username2" },
                    { "02453b52-d523-456b-9e64-f37d98569aab", 0, "c13007e9-c5c1-4f71-923d-d25cf567edc9", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "9db6d9a7-7af4-428a-a0be-e03a7d0e0838", false, "username3" },
                    { "d97457cc-fa9b-4f53-b4ef-783aababea45", 0, "65bd074f-8d13-47b4-a052-6751d0067a8a", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "2c381d79-2c3f-4b80-aded-76832754bcd3", false, "username4" },
                    { "4f3f0db0-176c-4343-99e2-69f2d81aaaef", 0, "ac1a4906-5d16-40e4-bfda-c5b6f6aa22eb", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "09e461bc-b04c-479b-94db-efbfc3f282e1", false, "username5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers",
                column: "KindOfEmployeeId");
        }
    }
}
