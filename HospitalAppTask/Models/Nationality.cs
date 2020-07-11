using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppTask.Models
{
    public class Nationality
    {
       
        [Key]
        public int NationalityId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }


        public Nationality()
        {
            Patients = new HashSet<Patient>();
        }
    }
}