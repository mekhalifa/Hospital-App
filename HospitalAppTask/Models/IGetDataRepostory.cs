using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public interface IGetDataRepostory
    {
        Task<SelectList> GetDoctors();
        Task<SelectList> GetDepartments();
        Task<SelectList> GetNationalities();
        Task<SelectList> Patients();
        Task<SelectList> GetDiseases();
        Task<SelectList> GetEmployees();
        Task<SelectList> GetKindOfEmployees();
        Task<SelectList> GetKindOfPatients();
    }
}
