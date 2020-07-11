using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class addV12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a26fc59-94a4-4173-af06-f7bb7a3a8fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9a2d7a-74f7-4d2b-90c6-1a16893be918");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e0161a9-31fd-4bba-90d9-141f83ef1fcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae8d791e-35a6-4ca3-94c3-b5fb3ae058a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7593ccc-ba30-4a44-8056-09ef6e274d05");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { "f7593ccc-ba30-4a44-8056-09ef6e274d05", 0, "ae908057-63ef-4e16-8be6-cd4afa59f0b5", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "dee513b6-001f-44bf-8f86-a16d0ecffe98", false, "username1" },
                    { "ae8d791e-35a6-4ca3-94c3-b5fb3ae058a8", 0, "a110256c-bcfd-4c2f-823a-90178bc4a5a3", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "02c1bc46-50f7-4caf-8791-0422f35366d1", false, "username2" },
                    { "7e0161a9-31fd-4bba-90d9-141f83ef1fcf", 0, "8f28800a-a31d-46dd-863b-b3cb2ffdf949", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "15f9b1af-688d-40cd-b336-ea1e488ae096", false, "username3" },
                    { "0a26fc59-94a4-4173-af06-f7bb7a3a8fea", 0, "7689f5b8-f108-42f1-8704-12ee50bc9712", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "2a0f641e-703b-4eff-a06d-15befd9d0c1d", false, "username4" },
                    { "7a9a2d7a-74f7-4d2b-90c6-1a16893be918", 0, "b3e57ceb-780e-4460-baaf-981c8cf26007", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "48d04a4a-3cdc-4f79-a66a-76fd29a85f2c", false, "username5" }
                });
        }
    }
}
