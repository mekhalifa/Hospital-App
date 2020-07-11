using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppTask.Controllers
{
    [Authorize]
    public class LogController : Controller
    {
        public LogController(ILogRepository logRepository)
        {
            LogRepository = logRepository;
        }

        public ILogRepository LogRepository { get; }

        public async Task< IActionResult> Index()
        {
          
            return View(await LogRepository.GetAll());
        }
    }
}