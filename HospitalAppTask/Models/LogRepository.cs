using HospitalAppTask.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HospitalAppTask.Models
{
    public class LogRepository : ILogRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IActionContextAccessor _accessor;

        public LogRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, IActionContextAccessor accessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _accessor = accessor;
        }
        public async Task<Dblog> AddLog(Dblog dblog)
        {
            //لمعرف IP الموظف الحالي 
            //ستظهر 1:: عشان LocalHost 
            var IpAddress = _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress;
           
            if (IpAddress != null)
                dblog.LocalIP = IpAddress.ToString();


            //لمعرف رقم الموظف الحالي
            //string userId =  _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //if (userId != null)
            //    dblog.UserIdLog = userId;

            //لمعرفه اسم المستخدم الحالي 
            //var username = _context.Employees.Where(m => m.Id == userId).Select(m => m.UserName);
            //if (userId != null && username != null)
            //    dblog.UserNameLog = username.ToString();

            
            await _context.Dblogs.AddAsync(dblog);

            await _context.SaveChangesAsync();
            return dblog;
        }

        public async Task<List<Dblog>> GetAll()
        {
            return await _context.Dblogs.OrderByDescending(m=>m.LogId).ToListAsync();
        }
    }
}
