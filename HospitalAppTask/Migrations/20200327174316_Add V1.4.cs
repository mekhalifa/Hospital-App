using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class AddV14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "ef389c6e-cf93-4583-a642-ab587a99c837", 0, "b1728cc1-9a18-44da-ac29-293277388ff2", "a1@a1.a1", false, 100, "محمد توفيق", true, null, false, null, null, null, "12345@Mm", null, null, false, "95672500-e667-4724-bc77-1b25855edd75", false, "username1" },
                    { "9376472b-cbb0-4d23-a3e1-319496424a25", 0, "b9f72500-1bac-4600-bb45-3ea3f680dfc0", "a2@a2.a2", false, 200, "محمد علي", true, null, false, null, null, null, "12345@Mm", null, null, false, "7ce8e50c-6f0a-4afe-adf6-b88ed2352771", false, "username2" },
                    { "5203fea8-2673-4df9-964f-30a552763957", 0, "f35410b8-9f92-435e-910f-ab5a087431f4", "a3@a3.a3", false, 300, " محمد حمد", true, null, false, null, null, null, "12345@Mm", null, null, false, "62c07e2f-6b13-494d-9d8a-34b20df6bd9d", false, "username3" },
                    { "cb4ffcb9-c597-4873-8e2e-53be2d94f63c", 0, "0ada2597-99a7-4f76-a5be-81a831229032", "a4@a4.a4", false, 400, " محمد سمير", true, null, false, null, null, null, "12345@Mm", null, null, false, "fac5c12a-5c1c-4ef0-9842-20fdb8add769", false, "username4" },
                    { "3bd0e125-b953-4398-86cb-7b86a5812b7c", 0, "3e5e93cb-a22b-4e17-9953-3693ebb3767a", "a5@a5.a5", false, 500, "محمد كريم ", true, null, false, null, null, null, "12345@Mm", null, null, false, "a2019ac2-1e4f-4f22-9b76-140f30232871", false, "username5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers",
                column: "KindOfEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd0e125-b953-4398-86cb-7b86a5812b7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5203fea8-2673-4df9-964f-30a552763957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9376472b-cbb0-4d23-a3e1-319496424a25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb4ffcb9-c597-4873-8e2e-53be2d94f63c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef389c6e-cf93-4583-a642-ab587a99c837");

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
    }
}
