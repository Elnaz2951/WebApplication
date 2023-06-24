using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Site.Model.layer;

namespace project.Model.layer
{
    //کاربر
    public class UserPanel
    {
        #region Constructor
        public UserPanel() { }
        public UserPanel(int RoleId, string Mobile, string Password)
        {
            this.RoleId = RoleId;
            this.Mobile = Mobile;
            this.Password = Password;
            RegisterDate = DateTime.Now;
            IsActive = true;
        }
        #endregion

        #region Property
        [Key]
        public int Id { get; set; }

        //ادمین - مسئول پذیرش
        [Display(Name = "نقش کاربری")]
        public int RoleId { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست")]
        public string Mobile { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegisterDate { get; set; }
        #endregion

        #region Navigation Property
        public virtual Role Role { get; set; }
        #endregion

    }
}
