﻿// <auto-generated />
using System;
using HospitalAppTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalAppTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200327232730_Add Log ")]
    partial class AddLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalAppTask.Models.Dblog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CheckLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EntryDateLog")
                        .HasColumnType("datetime2");

                    b.Property<string>("KindLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LogOutDateLog")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserIdLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameLog")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.ToTable("Dblogs");
                });

            modelBuilder.Entity("HospitalAppTask.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Name = "الباطنة"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Name = "العظام"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Name = "العيون"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.Disease", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CauseInfection")
                        .HasColumnType("bit");

                    b.Property<bool>("Chronic")
                        .HasColumnType("bit");

                    b.Property<string>("KindOfDisease")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Legacy")
                        .HasColumnType("bit");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DiseaseId");

                    b.HasIndex("PatientId");

                    b.ToTable("Diseases");

                    b.HasData(
                        new
                        {
                            DiseaseId = 1,
                            CauseInfection = false,
                            Chronic = false,
                            KindOfDisease = "رمد ربيعي",
                            Legacy = false
                        },
                        new
                        {
                            DiseaseId = 2,
                            CauseInfection = false,
                            Chronic = false,
                            KindOfDisease = "كسر بالساق",
                            Legacy = false
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            IsActive = true,
                            Name = "محمد احمد",
                            Specialization = "عظام"
                        },
                        new
                        {
                            DoctorId = 2,
                            IsActive = true,
                            Name = "علي مصطفي",
                            Specialization = "عيون"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("KindOfEmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("KindOfEmployeeId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a6eb3eeb-9893-428a-acb7-0c65b2913c9d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ae381a8-78df-45cb-8a26-9e2c458324f3",
                            Email = "a1@a1.a1",
                            EmailConfirmed = false,
                            EmployeeId = 100,
                            FullName = "محمد توفيق",
                            IsActive = true,
                            LockoutEnabled = false,
                            Password = "12345@Mm",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2c2a92d6-7b0a-4f7f-90a1-48c3a92efea9",
                            TwoFactorEnabled = false,
                            UserName = "username1"
                        },
                        new
                        {
                            Id = "5b9d2bf5-31b0-426f-bdf7-f7eaad22b718",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f1a52876-96b7-4cf4-9f91-d68f9994abe5",
                            Email = "a2@a2.a2",
                            EmailConfirmed = false,
                            EmployeeId = 200,
                            FullName = "محمد علي",
                            IsActive = true,
                            LockoutEnabled = false,
                            Password = "12345@Mm",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "092b666d-8dd4-4c05-823e-6aaf304b2440",
                            TwoFactorEnabled = false,
                            UserName = "username2"
                        },
                        new
                        {
                            Id = "ac31a5e7-56a6-4ef3-bee6-45bcd17461d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4015c417-7bde-4cd5-b50d-deffb1d3c7d4",
                            Email = "a3@a3.a3",
                            EmailConfirmed = false,
                            EmployeeId = 300,
                            FullName = " محمد حمد",
                            IsActive = true,
                            LockoutEnabled = false,
                            Password = "12345@Mm",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bd8ecbad-1ad6-4452-9b1b-883ec44de687",
                            TwoFactorEnabled = false,
                            UserName = "username3"
                        },
                        new
                        {
                            Id = "a07a6f80-bd8a-4056-91a2-556d7db0e07c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80de21b4-fa7a-4ff1-bdee-6e818b431d97",
                            Email = "a4@a4.a4",
                            EmailConfirmed = false,
                            EmployeeId = 400,
                            FullName = " محمد سمير",
                            IsActive = true,
                            LockoutEnabled = false,
                            Password = "12345@Mm",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b1d4197-f7a1-45ca-966d-8098db525585",
                            TwoFactorEnabled = false,
                            UserName = "username4"
                        },
                        new
                        {
                            Id = "b2573086-4c46-4757-b291-6697a254f831",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "90070dff-5a88-4839-a1a8-8cd67f35de16",
                            Email = "a5@a5.a5",
                            EmailConfirmed = false,
                            EmployeeId = 500,
                            FullName = "محمد كريم ",
                            IsActive = true,
                            LockoutEnabled = false,
                            Password = "12345@Mm",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5f6cf524-0069-4a51-b298-b6c549133298",
                            TwoFactorEnabled = false,
                            UserName = "username5"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.EmployeeRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HospitalAppTask.Models.KindOfEmployee", b =>
                {
                    b.Property<int>("KindOfEmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KindOfEmployeeId");

                    b.ToTable("kindOfEmployees");

                    b.HasData(
                        new
                        {
                            KindOfEmployeeId = 100,
                            Kind = "أ"
                        },
                        new
                        {
                            KindOfEmployeeId = 200,
                            Kind = "ب"
                        },
                        new
                        {
                            KindOfEmployeeId = 300,
                            Kind = "ج"
                        },
                        new
                        {
                            KindOfEmployeeId = 400,
                            Kind = "د"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.KindOfPatient", b =>
                {
                    b.Property<int>("KindOfPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KindOfEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("KindOfPatientId");

                    b.HasIndex("KindOfEmployeeId");

                    b.ToTable("KindOfPatients");

                    b.HasData(
                        new
                        {
                            KindOfPatientId = 1,
                            Id = 0,
                            IsActive = false,
                            Kind = "مجاني"
                        },
                        new
                        {
                            KindOfPatientId = 2,
                            Id = 0,
                            IsActive = false,
                            Kind = "علاج باجر"
                        },
                        new
                        {
                            KindOfPatientId = 3,
                            Id = 0,
                            IsActive = false,
                            Kind = "علاج على نفقة التامين"
                        },
                        new
                        {
                            KindOfPatientId = 4,
                            Id = 0,
                            IsActive = false,
                            Kind = "علاج على نفقة الدولة"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");

                    b.HasData(
                        new
                        {
                            NationalityId = 1,
                            Country = "مصر",
                            Name = "مصري"
                        },
                        new
                        {
                            NationalityId = 2,
                            Country = "السعودية",
                            Name = "سعودي"
                        },
                        new
                        {
                            NationalityId = 3,
                            Country = " الامارات العربية المتحدة",
                            Name = "اماراتي"
                        },
                        new
                        {
                            NationalityId = 4,
                            Country = "قطر",
                            Name = "قطري"
                        },
                        new
                        {
                            NationalityId = 5,
                            Country = "فرنسا",
                            Name = "فرنسي"
                        },
                        new
                        {
                            NationalityId = 6,
                            Country = "الولايات المتحدة الامريكية",
                            Name = "امريكي"
                        });
                });

            modelBuilder.Entity("HospitalAppTask.Models.Patient", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Diagnostic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("IdImgPath")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("KindOfPatientId")
                        .HasColumnType("int");

                    b.Property<string>("NameArabic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEnglish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SickHistory")
                        .HasColumnType("bit");

                    b.HasKey("PatientId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("Id");

                    b.HasIndex("KindOfPatientId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HospitalAppTask.Models.Disease", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Patient", null)
                        .WithMany("Diseases")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HospitalAppTask.Models.Doctor", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Department", null)
                        .WithMany("Doctors")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("HospitalAppTask.Models.Employee", b =>
                {
                    b.HasOne("HospitalAppTask.Models.KindOfEmployee", "KindOfEmployee")
                        .WithMany("Employees")
                        .HasForeignKey("KindOfEmployeeId");
                });

            modelBuilder.Entity("HospitalAppTask.Models.KindOfPatient", b =>
                {
                    b.HasOne("HospitalAppTask.Models.KindOfEmployee", "KindOfEmployee")
                        .WithMany("KindOfPatients")
                        .HasForeignKey("KindOfEmployeeId");
                });

            modelBuilder.Entity("HospitalAppTask.Models.Patient", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Department", "Department")
                        .WithMany("Patients")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("HospitalAppTask.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("HospitalAppTask.Models.Employee", "Employee")
                        .WithMany("Patients")
                        .HasForeignKey("Id");

                    b.HasOne("HospitalAppTask.Models.KindOfPatient", "KindOfPatient")
                        .WithMany("Patients")
                        .HasForeignKey("KindOfPatientId");

                    b.HasOne("HospitalAppTask.Models.Nationality", "Nationality")
                        .WithMany("Patients")
                        .HasForeignKey("NationalityId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("HospitalAppTask.Models.EmployeeRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("HospitalAppTask.Models.EmployeeRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAppTask.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HospitalAppTask.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
