using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class updateV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "601006a5-cbfb-4301-8482-dfd05c75b28a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8da39130-f98b-40f5-a341-5ccbe41977cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1d0b6cb-3e80-4652-9c1f-a0c8da4cc9f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42784e4-f230-415e-bae0-b7c9d37733d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef03540d-1afe-40e4-b5b2-3ea42ab5e565");

            migrationBuilder.AddColumn<int>(
                name: "KindOfEmployeeId",
                table: "AspNetUsers",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers",
                column: "KindOfEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_kindOfEmployees_KindOfEmployeeId",
                table: "AspNetUsers",
                column: "KindOfEmployeeId",
                principalTable: "kindOfEmployees",
                principalColumn: "KindOfEmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_kindOfEmployees_KindOfEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KindOfEmployeeId",
                table: "AspNetUsers");

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

            migrationBuilder.DropColumn(
                name: "KindOfEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d42784e4-f230-415e-bae0-b7c9d37733d5", 0, "97132789-a092-4cb1-80de-a78fba204f2e", "a1@a1.a1", false, 100, "محمد توفيق", true, false, null, null, null, "12345@Mm", null, null, false, "193d4162-a4f4-42ae-87bf-dec4e523f453", false, "username1" },
                    { "601006a5-cbfb-4301-8482-dfd05c75b28a", 0, "6b8993de-2558-472b-bccd-d85f79ddc07c", "a2@a2.a2", false, 200, "محمد علي", true, false, null, null, null, "12345@Mm", null, null, false, "c3c2e9f1-1683-42c8-af90-6a9deae58058", false, "username2" },
                    { "8da39130-f98b-40f5-a341-5ccbe41977cd", 0, "0cd36311-8886-4df8-8ac0-93d4c173c279", "a3@a3.a3", false, 300, " محمد حمد", true, false, null, null, null, "12345@Mm", null, null, false, "781dbb23-c171-46eb-a01d-dbe96118fdcc", false, "username3" },
                    { "ef03540d-1afe-40e4-b5b2-3ea42ab5e565", 0, "42b1a536-5c0b-495b-b30b-04d0896f0f39", "a4@a4.a4", false, 400, " محمد سمير", true, false, null, null, null, "12345@Mm", null, null, false, "d284eea5-216b-4415-96b5-2cf91c747a85", false, "username4" },
                    { "b1d0b6cb-3e80-4652-9c1f-a0c8da4cc9f4", 0, "f847aa2b-ef1b-479c-a37b-0ea30173de81", "a5@a5.a5", false, 500, "محمد كريم ", true, false, null, null, null, "12345@Mm", null, null, false, "46efbfad-9848-4749-a7cc-1ff53f2712af", false, "username5" }
                });
        }
    }
}
