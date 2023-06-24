using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using project.Model.layer;

namespace Site.Model.layer
{
    public class Patient : Pesron
    {                

        [Display(Name ="کد بیمار")]
        public int PatientCode { get; set; }
       
                
        [Display(Name = "علت مراجعه بیمار")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string PatientMainComplaint { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [Display(Name = "بیماری فعلی بیمار")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string PatientPresentIllness { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [Display(Name = "تاریخچه بیماری گذشته")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string PastMedicalHistory { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [Display(Name = "تاریخچه استفاده از دارو")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string DrugeHistory { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [Display(Name = "تاریخچه سابقه خانوادگی")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string FamilyHistory { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(50)]
        [Display(Name = "سطح هوشیاری فعلی")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string LevelOfConsciousness { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(30)]
        [Display(Name = "نام پزشک معالج")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string DoctorName { get; set; }


        public static int Code { get; set; } = 0;


        public virtual ICollection<Hospitalization> Hospitalizations { get; set; }
    }
}
