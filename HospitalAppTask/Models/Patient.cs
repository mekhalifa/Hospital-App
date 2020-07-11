using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAppTask.Models
{
    public class Patient
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PatientId { get; set; }
        [Required(ErrorMessage = "يجب ادخال اسمك باللغة الانجليزية")]
        public string NameEnglish { get; set; }
        [Required(ErrorMessage = "يجب ادخال اسمك باللغة العربية")]
        public string NameArabic { get; set; }
        public Gender Gender { get; set; }
        public byte[] IdImgPath { get; set; }


        public int? NationalityId { get; set; }
        public virtual Nationality Nationality { get; set; }

        public int? KindOfPatientId { get; set; }
        public virtual KindOfPatient KindOfPatient { get; set; }


        public string PhoneHome { get; set; }
        [Required(ErrorMessage ="يجب ادخال رقم تلفون")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="يجب ادخال رقم تلفون صحيح")]
        public string Phone { get; set; }
        public bool? SickHistory { get; set; }

        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? EntryDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CheckOut { get; set; }
        public string Diagnostic { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [ForeignKey("Employee")]
        public string Id { get; set; }
        public virtual Employee Employee { get; set; }


        public bool IsActive { get; set; }

        public virtual ICollection<Disease> Diseases { get; set; }

        public Patient()
        {
            Diseases = new HashSet<Disease>();
        }


    }
}
