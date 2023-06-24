using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Model.layer;

namespace Site.Model.layer
{
    public class Role
    {
        #region Constructor
        public Role() { }
        public Role(int RoleId, string RoleName)
        {
            this.RoleId = RoleId;

            this.Name = RoleName;
        }
        #endregion

        #region Property
        [Key]
        public int RoleId { get; set; }

        [Column("Name", TypeName = "Nvarchar")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [MaxLength(20)]
        public string Name { get; set; }

        public string Title { get; set; }
        #endregion

        #region Navigation Property
        public virtual List<UserPanel> UserPanels { get; set; }
        #endregion


    }






}

