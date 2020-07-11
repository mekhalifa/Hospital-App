using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppTask.Models
{
    public class KindOfPatient
    {
        // Free,WithSalary,ExpenseOfInsurance,ExpenseOfState
        [Key]
        public int  KindOfPatientId { get; set; }
      
        public string Kind { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }


        public int Id { get; set; }
        public virtual KindOfEmployee KindOfEmployee { get; set; }

        public KindOfPatient()
        {
            Patients = new HashSet<Patient>();
        }
    }
}
