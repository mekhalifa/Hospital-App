using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppTask.Data;
using HospitalAppTask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace HospitalAppTask.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        private readonly IGetDataRepostory getData;
        private readonly ApplicationDbContext dbContext;

        public IndexModel(
            UserManager<Employee> userManager,
            SignInManager<Employee> signInManager, IGetDataRepostory getData , ApplicationDbContext  dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.getData = getData;
            this.dbContext = dbContext;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            
            [Required(ErrorMessage ="يجب ادخال اسم الموظف كامل")]
            public string FullName { get; set; }

            [Required(ErrorMessage = "يجب ادخال الايميل")]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "يجب ادخال ايميل صحيح")]

            public string Email { get; set; }
           

            [Required(ErrorMessage = "يجب ادخال اسم المستخدم")]
            [RegularExpression(@"^([a-zA-Z0-9 \.\&\'\-]+)$", ErrorMessage= "يجب ادخال اسم مستخدم صحيح مع مراعاه ان يكون باللغه الانجليزيه")]
            public string UserName { get; set; }

            public  int KindOfEmployeeId { get; set; }
        }

        private async Task LoadAsync(Employee user)
        {

            
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var kindOfEmployeeId = user.KindOfEmployeeId;
            var fullName = user.FullName;
            var email = user.Email;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                KindOfEmployeeId = int.Parse(kindOfEmployeeId.ToString()),
                FullName = fullName,
                UserName = userName,
                Email = email       

        };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["KindOfEmployeeId"] = await getData.GetKindOfEmployees();
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"حدث خطأ في تسجيل التليفون '{userId}'.");
                }
            }

            var setEmail = await _userManager.GetEmailAsync(user);
            if (Input.Email != setEmail)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"حدث خطأ في تسجيل الايميل  '{userId}'.");
                }
            }

            var setUserName = await _userManager.GetUserNameAsync(user);
            if (Input.UserName != setUserName)
            {
                var setUserNameResult = await _userManager.SetUserNameAsync(user, Input.UserName);
                if (!setUserNameResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"حدث خطأ في تسجيل اسم المستخدم  '{userId}'.");
                }
            }
            var x = dbContext.Employees.FirstOrDefault(m => m.Id == user.Id);
            x.KindOfEmployeeId = Input.KindOfEmployeeId;
            x.FullName = Input.FullName;
            x.UserName = Input.UserName;
            dbContext.SaveChanges();
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "تم الحفظ بنجاح";
            return RedirectToPage();
        }
    }
}
