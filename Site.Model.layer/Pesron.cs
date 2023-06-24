using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Site.Model.layer
{
    //(User,patient,nurse,doctor) والد کلاس های
    public abstract class Pesron
    {
        #region Constructor
        public Pesron() { }

        public Pesron(string Name, string Family, string Phonenumber, DateTime Birthdate)
        {
            this.Name = Name;
            this.Family = Family;
            this.Phonenumber = Phonenumber;                                    
            this.Birthdate = Birthdate;
            this.RegisterDate = DateTime.Now;            
            this.IsActive = true;
        }

        #endregion

        #region Property
        [Key]
        public int Id { get; set; }


        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [MaxLength(20)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name { get; set; }


        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [MaxLength(30)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }


        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست")]
        public string Phonenumber { get; set; }


        [Display(Name = "تاریخ تولد")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }


        public bool IsActive { get; set; }
        #endregion
    }
}
