using project.Model.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Site.Model.layer
{
    //پرونده 
    public class Reception
    {

        #region Contructor
        public Reception()
        {

        }

        public Reception(string patientName, string treatingDoctor, bool hospitalization, bool outpatientVisit, List<Symptom> symptoms, string stabilizationOfTheSituation, string complicationsDuringHospitalization, List<Symptom> dangerSymptoms)
        {                       
            TreatingDoctor = treatingDoctor;            
            Hospitalization = hospitalization;
            OutpatientVisit = outpatientVisit;
            Symptoms = symptoms;
            StabilizationOfTheSituation = stabilizationOfTheSituation;
            ComplicationsDuringHospitalization = complicationsDuringHospitalization;
            DangerSymptoms = dangerSymptoms;
            RegisterDate = DateTime.Now;
        }

        #endregion

        #region Property
        [Key]
        public int Id { get; set; }


        [Display(Name = "نام بیمار")]
        public string PatientName { get; set; }

        [Display(Name = "پزشک معالج")]
        public string TreatingDoctor { get; set; }

        [Display(Name = "تاریخ تشکیل پرونده")]
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        [Display(Name ="نیازمند بستری است ؟ ")]
        public bool Hospitalization { get; set; }

        [Display(Name ="ویزیت سرپایی")]
        public bool OutpatientVisit { get; set; }

        [Display(Name = "علائم فعلی بیمار")]
        public virtual ICollection<Symptom> Symptoms { get; set; }


        [Display(Name = "پایدارسازی وضعیت بیمار ")]
        public string StabilizationOfTheSituation { get; set; }


        [Display(Name = "عوارض حین بستری ")]
        public string ComplicationsDuringHospitalization { get; set; }


        [Display(Name = "علائم خطر ")]
        public virtual ICollection<Symptom> DangerSymptoms { get; set; }

        #endregion

        #region Navigation Property        
        #endregion
    }
}

