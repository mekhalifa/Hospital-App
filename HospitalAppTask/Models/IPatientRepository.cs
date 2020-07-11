using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
   public interface IPatientRepository
    {
        Task<List<Patient>> GetAllPatient();
        Task<Patient> Create(Patient patientCreate);
        Task<Patient> Update(Patient patientUpdate);
        
    }
}
