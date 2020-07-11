using HospitalAppTask.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace HospitalAppTask.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly SignInManager<Employee> _signInManager;
        private readonly UserManager<Employee> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        
        public PatientRepository(ApplicationDbContext context, SignInManager<Employee> signInManager, UserManager<Employee> userManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public ApplicationDbContext Context { get; }

        public async Task<Patient> Create(Patient patientCreate)
        {
          patientCreate.PatientId = GeneratePatientID();
          patientCreate.EntryDate = DateTime.Now;

            //لمعرفة رقم الموظف الحالي 
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var employee =await Context.Employees.FirstOrDefaultAsync(m=>m.Id== userId);

            if (employee != null)
                patientCreate.Employee = employee;


            await Context.Patients.AddAsync(patientCreate);

          await  Context.SaveChangesAsync();
            return patientCreate;
        }

        //لتوليد  رقم للمريض علي شكل 110220200001
        private string GeneratePatientID()
        {
          var num=  Context.Patients.Count() +1;
          return  DateTime.Today.ToString("yyyMMdd") + string.Format("{0:0000}", num);
        }

        public async Task<List<Patient>> GetAllPatient()
        {
          var patients=  await Context.Patients.Include(m=>m.Nationality)
                .Include(m=>m.Department).Include(m=>m.Doctor).Include(m=>m.KindOfPatient).Include(m=>m.Employee).ToListAsync();
            return patients;
        }

        public async Task< Patient> Update(Patient patientUpdate)
        {
            //var patient =await Context.Patients.FirstOrDefaultAsync(m => m.PatientId == id);

            Context.Entry(patientUpdate).State = EntityState.Modified;

            await Context.SaveChangesAsync();

            return patientUpdate;
        }
    }
}
