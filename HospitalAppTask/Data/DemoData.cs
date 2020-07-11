using HospitalAppTask.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Data
{
    public class DemoData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<Employee> userManager,
                              RoleManager<EmployeeRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Emplyee";
            string desc2 = "This is the Employee role";

            string role3 = "other";
            string desc3 = "This is the other role";

            string password = "12345@Mm";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new EmployeeRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new EmployeeRole(role2, desc2, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new EmployeeRole(role3, desc3, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("aa@aa.aa") == null)
            {
                var user = new Employee
                {
                    UserName = "khalifa",
                    Email = "aa@aa.aa",
                    FullName = "Mohamed Emad",
                    PhoneNumber = "6902341234",
                    KindOfEmployeeId=100,
                    IsActive=true,
                    Password=password
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("bb@bb.bb") == null)
            {
                var user = new Employee
                {
                    UserName = "bb@bb.bb",
                    Email = "bb@bb.bb",
                    FullName = "Emad Mohamed",
                    PhoneNumber = "7788951456",
                    KindOfEmployeeId = 200,
                    IsActive = true,
                    Password = password
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
               
            }

            if (await userManager.FindByNameAsync("cc@cc.cc") == null)
            {
                var user = new Employee
                {
                    UserName = "cc@cc.cc",
                    Email = "cc@cc.cc",
                    FullName = "Aya Emad",
                    PhoneNumber = "6572136821",
                    IsActive = true,
                    KindOfEmployeeId = 300,
                    Password = password
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
            }

           
        }
    }

}
