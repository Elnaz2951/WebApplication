using Site.Model.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Model.layer
{
    //بستری
    public class Hospitalization
    {

        #region Constructor
        public Hospitalization() { }
        public Hospitalization(Patient patient)
        {
            PatientId = patient.Id;
            PatientName = patient.Name;
            DateOfAdmission = DateTime.Now;
            IsDischarge = false;
            IsPay = false;
        }
        #endregion

        #region Property
        [Key]
        public int Id { get; set; }

        [Display(Name ="نام بیمار")]
        [Required(ErrorMessage ="{0} یک فیلد اجباری است")]
        public string PatientName { get; set; }

        [Display(Name = "آیدی بیمار")]
        [Required(ErrorMessage = "{0} یک فیلد اجباری است")]
        public int PatientId { get; set; }

        [Display(Name = "تاریخ بستری")]        
        public DateTime DateOfAdmission { get; set; }

        [Display(Name = "تاریخ ترخیص")]
        public DateTime? ReleaseDate { get; set; }
        public bool IsDischarge { get; set; }
        public bool IsPay { get; set; }
        #endregion

        #region Navigation Property
        public virtual Patient Patient { get; set; }
        #endregion
    }
}
