using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class KindOfEmployee 
    {
        [Key]
        public int KindOfEmployeeId { get; set; }
        public string Kind { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<KindOfPatient> KindOfPatients { get; set; }

        
        
        public KindOfEmployee()
        {
            KindOfPatients = new HashSet<KindOfPatient>();
           
        }
    }
}
