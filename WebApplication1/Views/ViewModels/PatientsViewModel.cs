using Site.Model.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Site.Views.ViewModels
{
    public class PatientsViewModel :User
    {

        [Key]


        public int PatientCode { get; set; }

        public static int Code { get; set; } = 0;





        [Column(TypeName = "Nvarchar")]
        [MaxLength(200)]
        [Display(Name = "شکایت اصلی بیمار")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
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
        public Drs drName { get; set; }




        public int DrsId { get; set; }
        public Hospitalization Hospitalization { get; set; }
        public IEnumerable<Nurses> nurses { get; set; }



        public Roles Role { get; set; }


        public PatientsViewModel() { }
        public PatientsViewModel(string PatientMainComplaint, string PatientPresentIllness, string PastMedicalHistory, string DrugeHistory, string FamilyHistory, string LevelOfConsciousness
           , Drs drName, string Name, string Family, string Phonenumber, string Password, DateTime Birtdate, Model.layer.Roles RoleId) : base(Name, Family, Phonenumber, Password, Birtdate)
        {
            Code++;
            PatientCode = Code;

            this.PatientMainComplaint = PatientMainComplaint;
            this.PatientPresentIllness = PatientPresentIllness;
            this.PastMedicalHistory = PastMedicalHistory;
            this.DrugeHistory = DrugeHistory;
            this.FamilyHistory = FamilyHistory;
            this.LevelOfConsciousness = LevelOfConsciousness;
            this.drName = drName;
            RoleId = 4;

        }


    }
}