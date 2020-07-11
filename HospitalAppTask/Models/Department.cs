using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppTask.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

        public Department()
        {
            Patients = new HashSet<Patient>();
            Doctors = new HashSet<Doctor>();
        }

    }
}