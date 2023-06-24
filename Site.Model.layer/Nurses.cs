using project.Model.layer;
using Site.Model.layer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Site.Model.layer
{


    public class Nurses : Pesron
    {
        private readonly HospitalDbContext db;
        #region Constructor
        public Nurses() { }

        public Nurses(string Name, string Family, string Phonenumber,DateTime Birthdate,string NurseDegree,string Department,HospitalDbContext db) : base(Name, Family, Phonenumber, Birthdate)
        {
            
            this.Department = Department;
            this.db = db;
            this.NurseDegree = NurseDegree;           
        }
        #endregion

        #region Property
        [Display(Name = "مدرک")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string NurseDegree { get; set; }

        [Display(Name = "دپارتمان فعالیت")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string Department { get; set; }
        #endregion

        #region Navigation Property
        public virtual UserPanel UserPanel { get; set; }
        #endregion

        #region Method

        public void GetPanelForThisNurse(HospitalDbContext db)
        {
            string DefaultPassword = Guid.NewGuid().ToString().ToLower().Replace("-", "").Take(6).ToString();
            db.UserPanels.Add(new UserPanel(db.Roles.First(t => t.Name == "Nurse").RoleId, Phonenumber, DefaultPassword));
            db.SaveChanges();
        }

        #endregion
    }
}

