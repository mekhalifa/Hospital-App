using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class Employee : IdentityUser
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="يجب ادخال اسم الموظف كامل")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "يجب ادخال رقم سري للموظف ")]
        [DataType(DataType.Password,ErrorMessage ="يجب ادخال باسورد اخر ")]
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public int? KindOfEmployeeId { get; set; }
        public virtual KindOfEmployee KindOfEmployee { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }


        public Employee(): base()
        {
            
            Patients = new HashSet<Patient>();

        }


    }
}
