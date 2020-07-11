using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
   public interface ILogRepository
    {
        Task<List<Dblog>> GetAll();
        Task<Dblog> AddLog(Dblog dblog);
    }
}
