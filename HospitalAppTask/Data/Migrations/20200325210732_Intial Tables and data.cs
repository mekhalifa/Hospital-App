using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalAppTask.Data.Migrations
{
    public partial class IntialTablesanddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "kindOfEmployees",
                columns: table => new
                {
                    KindOfEmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kind = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kindOfEmployees", x => x.KindOfEmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Specialization = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    KindOfEmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_kindOfEmployees_KindOfEmployeeId",
                        column: x => x.KindOfEmployeeId,
                        principalTable: "kindOfEmployees",
                        principalColumn: "KindOfEmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KindOfPatients",
                columns: table => new
                {
                    KindOfPatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kind = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    KindOfEmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KindOfPatients", x => x.KindOfPatientId);
                    table.ForeignKey(
                        name: "FK_KindOfPatients_kindOfEmployees_KindOfEmployeeId",
                        column: x => x.KindOfEmployeeId,
                        principalTable: "kindOfEmployees",
                        principalColumn: "KindOfEmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<string>(nullable: false),
                    NameEnglish = table.Column<string>(nullable: false),
                    NameArabic = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    IdImgPath = table.Column<string>(nullable: true),
                    NationalityId = table.Column<int>(nullable: false),
                    KindOfPatientId = table.Column<int>(nullable: true),
                    PhoneHome = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    SickHistory = table.Column<bool>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    Diagnostic = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_KindOfPatients_KindOfPatientId",
                        column: x => x.KindOfPatientId,
                        principalTable: "KindOfPatients",
                        principalColumn: "KindOfPatientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindOfDisease = table.Column<string>(nullable: false),
                    Chronic = table.Column<bool>(nullable: false),
                    Legacy = table.Column<bool>(nullable: false),
                    CauseInfection = table.Column<bool>(nullable: false),
                    PatientId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.DiseaseId);
                    table.ForeignKey(
                        name: "FK_Diseases_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "الباطنة" },
                    { 2, null, "العظام" },
                    { 3, null, "العيون" }
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "DiseaseId", "CauseInfection", "Chronic", "KindOfDisease", "Legacy", "PatientId" },
                values: new object[,]
                {
                    { 1, false, false, "رمد ربيعي", false, null },
                    { 2, false, false, "كسر بالساق", false, null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "DepartmentId", "IsActive", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, null, true, "محمد احمد", "عظام" },
                    { 2, null, true, "علي مصطفي", "عيون" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityId", "Country", "Name" },
                values: new object[,]
                {
                    { 4, "قطر", "قطري" },
                    { 3, " الامارات العربية المتحدة", "اماراتي" },
                    { 2, "السعودية", "سعودي" },
                    { 1, "مصر", "مصري" },
                    { 6, "الولايات المتحدة الامريكية", "امريكي" },
                    { 5, "فرنسا", "فرنسي" }
                });

            migrationBuilder.InsertData(
                table: "kindOfEmployees",
                columns: new[] { "KindOfEmployeeId", "Description", "Kind" },
                values: new object[,]
                {
                    { 3, null, "ج" },
                    { 1, null, "أ" },
                    { 4, null, "د" },
                    { 2, null, "ب" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FullName", "IsActive", "KindOfEmployeeId", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "1 محمد السيد", true, 1, "123456", "username1" },
                    { 2, "محمد السيد 2", true, 2, "123456", "username2" },
                    { 3, "3 محمد السيد", true, 3, "123456", "username3" },
                    { 4, "4 محمد السيد", true, 4, "123456", "username4" },
                    { 5, "محمد السيد 5", true, 4, "123456", "username5" }
                });

            migrationBuilder.InsertData(
                table: "KindOfPatients",
                columns: new[] { "KindOfPatientId", "Description", "IsActive", "Kind", "KindOfEmployeeId" },
                values: new object[,]
                {
                    { 3, null, false, "علاج على نفقة التامين", 1 },
                    { 4, null, false, "علاج على نفقة الدولة", 1 },
                    { 1, null, false, "مجاني", 2 },
                    { 2, null, false, "علاج باجر", 3 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "CheckOut", "DepartmentId", "Diagnostic", "DoctorId", "EmployeeId", "EntryDate", "Gender", "IdImgPath", "IsActive", "KindOfPatientId", "NameArabic", "NameEnglish", "NationalityId", "Phone", "PhoneHome", "SickHistory" },
                values: new object[] { "202001010001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, false, 1, "ابراهيم خالد", "Ebrahim Khaled", 1, "+201000000000", null, false });

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_PatientId",
                table: "Diseases",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmentId",
                table: "Doctors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_KindOfEmployeeId",
                table: "Employees",
                column: "KindOfEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_KindOfPatients_KindOfEmployeeId",
                table: "KindOfPatients",
                column: "KindOfEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_EmployeeId",
                table: "Patients",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_KindOfPatientId",
                table: "Patients",
                column: "KindOfPatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_NationalityId",
                table: "Patients",
                column: "NationalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "KindOfPatients");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "kindOfEmployees");
        }
    }
}
