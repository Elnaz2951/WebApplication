using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Site.Model.layer
{
    //public class ActionType
    //{

    //    [Key]

    //    [Display(Name = "نام بیمار")]
    //    public string PatientName { get; set; }



    //    [Required(ErrorMessage = "فیلد{0}اجباری است!")]
    //    [Display(Name = " نام پزشک")]
    //    public string TreatingDrName { get; set; }


    //    [Display(Name = "تاریخ")]
    //    public DateTime Date { get; set; } = DateTime.Now;



    //    [Display(Name = "درمان دارویی")]
    //    public string DrugTreatment { get; set; }



    //    [Column(TypeName = "Nvarchar")]
    //    [MaxLength(300)]
    //    [Display(Name = "سایر درمان دارویی")]
    //    public string etc { get; set; }

    //    [Display(Name = "اقدامات پاراکلینیکی")]
    //    public string ParaclinicalMeasures { get; set; }


    //    [Column(TypeName = "Nvarchar")]
    //    [MaxLength(300)]
    //    [Display(Name = "سایر اقدامات پاراکلینیکی ")]
    //    public string etc1 { get; set; }


    //    [Display(Name = "درخواست  نمونه برداری از مغز استخوان")]
    //    public string BoneMarrowSample { get; set; }


    //    [Display(Name = "درخواست ازمایش")]
    //    public string TestRequest { get; set; }


    //    [Column(TypeName = "Nvarchar")]
    //    [MaxLength(300)]
    //    [Display(Name = "سایر ازمایش ")]
    //    public string etc3 { get; set; }


    //    [Display(Name = "درخواست ازمایش در صورت شک به لوکمی")]
    //    public string TestLokmiRequest { get; set; }


    //    [Column(TypeName = "Nvarchar")]
    //    [MaxLength(300)]
    //    [Display(Name = " در صورت شک به لوکمی سایر ازمایش ")]
    //    public string etc4 { get; set; }



    //    [Display(Name = "درمان عوارض")]
    //    public string TreatmentOfComplications { get; set; }

    //    [Display(Name = "درخواست تصویر برداری")]
    //    public string ImagingRequest { get; set; }




    //    [Display(Name = "درخواست مشاور")]
    //    public string ConsultantRequest { get; set; }
    //    [Column(TypeName = "Nvarchar")]
    //    [MaxLength(200)]
    //    [Display(Name = "سایر مشاورها")]
    //    public string etc2 { get; set; }


    //    [Display(Name = "توصیه های تغذیه ای")]
    //    public string NutritionalRecommendations { get; set; }


    //    [Display(Name = "ترخیص با:")]
    //    public int discharge { get; set; }




    //    [Display(Name = "بستری با دستور دکتر:")]
    //    public int Hospitalization { get; set; }






    //    public virtual ICollection<Patients> Patients { get; set; }



    //    public ActionType()
    //    {

    //    }
    //    public ActionType(string PatientName, string TreatingDrName, string DrugTreatment, string etc, string ParaclinicalMeasures, string etc1, string BoneMarrowSample, string TestRequest, string etc3, string TestLokmiRequest, string etc4, string ConsultantRequest, string etc2, string NutritionalRecommendations, int discharge, int Hospitalization)
    //    {

    //        this.PatientName = PatientName;
    //        this.TreatingDrName = TreatingDrName;

    //        Date = DateTime.Now;
    //        Date.ToString();
    //        this.DrugTreatment = DrugTreatment;
    //        this.etc = etc;
    //        this.ParaclinicalMeasures = ParaclinicalMeasures;
    //        this.etc1 = etc1;
    //        this.BoneMarrowSample = BoneMarrowSample;

    //        this.TestRequest = TestRequest;

    //        this.etc3 = etc3;
    //        this.TestLokmiRequest = TestLokmiRequest;
    //        this.etc4 = etc4;
    //        this.ConsultantRequest = ConsultantRequest;
    //        this.etc2 = etc2;
    //        this.NutritionalRecommendations = NutritionalRecommendations;
    //        this.discharge = discharge;
    //        this.Hospitalization = Hospitalization;
    //        Patients = new List<Patients>();

    //    }
    //}
}
