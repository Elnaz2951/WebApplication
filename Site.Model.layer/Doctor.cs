using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Site.Model.layer.Context;
using project.Model.layer;

namespace Site.Model.layer
{
    public class Doctor:Pesron    
    {
        #region Constructor
        public Doctor()
        {

        }
        public Doctor(int DrsId, string DoctorExpertise, string Name, string Family, string Phonenumber, string Password, DateTime Birthdate) : base(Name, Family, Phonenumber, Birthdate)

        {
            this.DoctorExpertise = DoctorExpertise;


        }
        #endregion

        #region Property
        [Display(Name = "تخصص")]
        [Column(TypeName = "Nvarchar")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string DoctorExpertise { get; set; }
        #endregion

        #region Methods
        public void GetPanelForThisDoctor(HospitalDbContext db)
        {
            string DefaultPassword = Guid.NewGuid().ToString().ToLower().Replace("-", "").Take(6).ToString();
            db.UserPanels.Add(new UserPanel(db.Roles.First(t => t.Name == "Nurse").RoleId, Phonenumber, DefaultPassword));
            db.SaveChanges();
        }
        #endregion

    }

} 
