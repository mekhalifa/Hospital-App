using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class Lastedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "11532094-745b-4d49-aeff-741eaf1cd6d5", 0, "a475370e-16f6-48ae-96d8-2e4a5b3e538c", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "a162dea6-fc60-4e18-a042-bc794e19f963", false, "username1" },
                    { "b9c97761-99f1-4f40-9543-824e5be06103", 0, "73c700ac-671c-4c84-95ca-c25b17a4a545", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "596b9e86-d5f2-4074-b48d-b0355886ced9", false, "username2" },
                    { "0b5859da-fe11-4ad6-9b13-30c3dff6c60d", 0, "14eb1885-32fd-408b-8585-a2cf650e2df9", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "3af89eb2-0d2f-4232-bb48-57af6cd7c1f2", false, "username3" },
                    { "f074dc12-b63e-400b-b520-cf39fcfe8780", 0, "0b3a3414-5b7f-4c30-8c33-f1dcc3092295", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "ab2e64e1-e8c7-4869-a1bf-d6b2283351e6", false, "username4" },
                    { "68de7151-40b9-4706-baa0-e5bb34cd369b", 0, "dd2dddef-a924-4cc5-adcc-61316f2b4625", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "b2f4d593-e5aa-45fc-b1a8-93cb3303337a", false, "username5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b5859da-fe11-4ad6-9b13-30c3dff6c60d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11532094-745b-4d49-aeff-741eaf1cd6d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68de7151-40b9-4706-baa0-e5bb34cd369b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9c97761-99f1-4f40-9543-824e5be06103");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f074dc12-b63e-400b-b520-cf39fcfe8780");

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
    }
}
