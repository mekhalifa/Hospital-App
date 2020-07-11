using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class Dblog
    {
        [Key]
        public int LogId { get; set; }
        public string KindLog { get; set; }
        public string CheckLog { get; set; }
        public string UserNameLog { get; set; }
        public string UserIdLog { get; set; }
        public string LocalIP { get; set; }
        public DateTime? EntryDateLog { get; set; }
        public DateTime? LogOutDateLog { get; set; }

    }
}
