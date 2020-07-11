using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using HospitalAppTask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

using HospitalAppTask.Data;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppTask.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<Employee> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private readonly ILogRepository _logRepository;
       
        private readonly ApplicationDbContext _context;

        public LogoutModel(SignInManager<Employee> signInManager, ILogger<LogoutModel> logger ,ILogRepository logRepository,
             ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _logRepository = logRepository;
            
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            //لتسجيل خروج في السجيل
            string userId = User.Identity.Name;
            
            await _logRepository.AddLog(new Dblog { UserNameLog = userId, LogOutDateLog = DateTime.Now, KindLog = "تسجيل خروج", CheckLog = "عملية ناجحة" });



            await _signInManager.SignOutAsync();
            
            _logger.LogInformation("الموظف خرج من النظام");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
