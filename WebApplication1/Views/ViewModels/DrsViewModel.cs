using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Site.Model.layer;

namespace Site.Views.ViewModels
{
    public class DrsViewModel :User
    {
        [Key]
        public int DrsId { get; set; }



        [Display(Name = "تخصص")]
        [Column(TypeName = "Nvarchar")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string DrExpertise { get; set; }





        public Roles Role { get; set; }






        public DrsViewModel()
        {

        }
        public DrsViewModel(int DrsId, string DrExpertise, string Name, string Family, string Phonenumber, string Password, DateTime Birthdate, Roles RoleId) : base(Name, Family, Phonenumber, Password, Birthdate)

        {
            this.DrsId = DrsId;
            this.DrExpertise = DrExpertise;
            RoleId = 2;

        }


    }
}
