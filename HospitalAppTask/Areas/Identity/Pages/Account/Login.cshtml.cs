using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using HospitalAppTask.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospitalAppTask.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<Employee> _userManager;
        private readonly ILogRepository _logRepository;
        private readonly SignInManager<Employee> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<Employee> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<Employee> userManager,
            ILogRepository logRepository)
        {
            _userManager = userManager;
            _logRepository = logRepository;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage ="يجي ادخال اسم المستخدم")]
            

            public string Username { get; set; }

            [Required(ErrorMessage ="يجيب ادخال الباسورد")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "ذكرني?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    await _logRepository.AddLog(new Dblog { UserNameLog=Input.Username, EntryDateLog = DateTime.Now, KindLog = "تسجيل دخول", CheckLog = "عملية ناجحة" });
                    _logger.LogInformation("المستخدم نجح في الدخول");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("الحساب مغلق");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    await _logRepository.AddLog(new Dblog { UserNameLog = Input.Username, EntryDateLog = DateTime.Now, KindLog = "تسجيل دخول", CheckLog = "عملية فاشلة" });

                    ModelState.AddModelError(string.Empty, "مشكل في الدخول");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
