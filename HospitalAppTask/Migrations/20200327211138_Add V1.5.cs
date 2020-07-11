using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Migrations
{
    public partial class AddV15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AspNetUsers_EmployeeId1",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_EmployeeId1",
                table: "Patients");

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

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Patients",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Id",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AspNetUsers_Id",
                table: "Patients",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AspNetUsers_Id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_Id",
                table: "Patients");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

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
                name: "IX_Patients_EmployeeId1",
                table: "Patients",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AspNetUsers_EmployeeId1",
                table: "Patients",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
