using HospitalAppTask.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class GetDataRepository : IGetDataRepostory
    {
        public GetDataRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public async Task<SelectList> GetDepartments()
        {
            var data = await DbContext.Departments.ToListAsync();
            return new SelectList(data, "DepartmentId", "Name");
        }

        public async Task<SelectList> GetDiseases()
        {
            var data = await DbContext.Diseases.ToListAsync();
            return new SelectList(data, "DiseaseId", "KindOfDisease");
        }

        public async Task<SelectList> GetDoctors()
        {
            var data= await DbContext.Doctors.ToListAsync();

            return new SelectList(data, "DoctorId", "Name");
        }

        public async Task<SelectList> GetEmployees()
        {
            var data = await DbContext.Employees.ToListAsync();
            return new SelectList(data, "EmployeeId", "FullName");
        }

        public async Task<SelectList> GetKindOfEmployees()
        {
            var data = await DbContext.kindOfEmployees.ToListAsync();
            return new SelectList(data, "kindOfEmployeeId", "Kind");
        }

        public async Task<SelectList> GetKindOfPatients()
        {
            var data = await DbContext.KindOfPatients.ToListAsync();
            return new SelectList(data, "KindOfPatientId", "Kind");
        }

        public async Task<SelectList> GetNationalities()
        {
            var data = await DbContext.Nationalities.ToListAsync();
            return new SelectList(data, "NationalityId", "Name");
        }

        public async Task<SelectList> Patients()
        {
            var data = await DbContext.Patients.ToListAsync();
            return new SelectList(data, "PatientId", "NameArabic");
        }
    }
}
