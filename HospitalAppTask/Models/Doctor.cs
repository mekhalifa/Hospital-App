using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppTask.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Patients = new HashSet<Patient>();
        }
    }
}