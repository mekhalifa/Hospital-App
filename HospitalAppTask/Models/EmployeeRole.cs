using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class EmployeeRole : IdentityRole
    {
        public EmployeeRole():base()
        {

        }
        public EmployeeRole(string roleName) : base(roleName)
        {

        }
        public EmployeeRole(string roleName,string description,DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
