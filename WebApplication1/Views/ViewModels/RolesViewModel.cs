using Site.Model.layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.Views.ViewModels
{
    public class RolesViewModel
    {

        

            [Key]
            [Required]
            public int RoleId { get; set; }

            [Required(ErrorMessage = "فیلد{0}اجباری است!")]
            [Column("Name", TypeName = "Nvarchar")]
            [MaxLength(20)]
            public string RoleName { get; set; }


            public IEnumerable<Drs> Drs { get; set; }
            public IEnumerable<Nurses> Nurses { get; set; }
            public IEnumerable<Patients> patients { get; set; }
            public IEnumerable<Admin> Admin { get; set; }






            public RolesViewModel() { }
            public RolesViewModel(int RoleId, string RoleName)
            {
                this.RoleId = RoleId;

                this.RoleName = RoleName;
            }

        public static implicit operator RolesViewModel(int v)
        {
            throw new NotImplementedException();
        }
    }
}