using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalAppTask.Models
{
    public class Disease
    {
        [Key]
        public int DiseaseId { get; set; }
        [Required(ErrorMessage ="يجب ادخال نوع المرض")]
        public string KindOfDisease { get; set; }
        public bool Chronic { get; set; }
        public bool Legacy { get; set; }
        public bool CauseInfection { get; set; }


    }
}
