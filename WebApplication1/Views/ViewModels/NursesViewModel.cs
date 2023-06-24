using Site.Model.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Site.Views.ViewModels
{
    public class NursesViewModel  :User
    {
         
            [Key]
        public int NursesId { get; set; }






        [Display(Name = "مدرک")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string NurseDegree { get; set; }






        public Model.layer.Roles Role { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }



        public NursesViewModel()
        {

        }
        public NursesViewModel(int NursesId, string NurseDegree, string Name, string Family, string Phonenumber, string Password, DateTime Birthdate, Model.layer.Roles RoleId) : base(Name, Family, Phonenumber, Password, Birthdate)

        {
            this.NursesId = NursesId;
            this.NurseDegree = NurseDegree;

            RoleId = 3;
        }
    }

}
