using System;
using System.Collections.Generic;
using System.Text;
using HospitalAppTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppTask.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee,EmployeeRole,string>
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<KindOfPatient> KindOfPatients { get; set; }
        public DbSet<KindOfEmployee> kindOfEmployees { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Dblog> Dblogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "الباطنة" },
                new Department { DepartmentId = 2, Name = "العظام" },
                 new Department { DepartmentId = 3, Name = "العيون" }
                );

            modelBuilder.Entity<Disease>().HasData(
                new Disease {DiseaseId=1,KindOfDisease="رمد ربيعي" ,CauseInfection=false,Legacy=false,Chronic=false},
                new Disease {DiseaseId = 2, KindOfDisease = "كسر بالساق", CauseInfection = false, Legacy = false, Chronic = false }
                );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId=1,Name="محمد احمد",Specialization="عظام", IsActive=true},
                 new Doctor { DoctorId = 2, Name = "علي مصطفي", Specialization = "عيون", IsActive = true }
                );


            modelBuilder.Entity<KindOfPatient>().HasData(
               new KindOfPatient { KindOfPatientId = 1, Kind= "مجاني" },
               new KindOfPatient { KindOfPatientId = 2, Kind = "علاج باجر" },
               new KindOfPatient { KindOfPatientId = 3, Kind = "علاج على نفقة التامين" },
               new KindOfPatient { KindOfPatientId = 4, Kind = "علاج على نفقة الدولة" }

               );

            modelBuilder.Entity<KindOfEmployee>().HasData(
                new KindOfEmployee { KindOfEmployeeId=100,Kind="أ" },
                new KindOfEmployee { KindOfEmployeeId = 200, Kind = "ب" },
                new KindOfEmployee { KindOfEmployeeId = 300, Kind = "ج"},
                new KindOfEmployee { KindOfEmployeeId = 400, Kind = "د" }
                    
                );
            


            

            modelBuilder.Entity<Nationality>().HasData(
                new Nationality { NationalityId = 1,Country="مصر",Name="مصري" },
                new Nationality { NationalityId = 2, Country = "السعودية", Name = "سعودي" },
                new Nationality { NationalityId = 3, Country = " الامارات العربية المتحدة", Name = "اماراتي" },
                new Nationality { NationalityId = 4, Country = "قطر", Name = "قطري" },
                new Nationality { NationalityId = 5, Country = "فرنسا", Name = "فرنسي" },
                new Nationality { NationalityId = 6, Country = "الولايات المتحدة الامريكية", Name = "امريكي" }
                );


            
        }


    }
}
