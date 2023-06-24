using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Site.Views.ViewModels
{
    public abstract class User
    {



        [Column(TypeName = "Nvarchar")]
        [MaxLength(20)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        public string Name { get; set; }


        [Column(TypeName = "Nvarchar")]
        [MaxLength(30)]
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }


        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "Nvarchar")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست")]
        [Display(Name = "شماره موبایل")]
        public string Phonenumber { get; set; }


        [Required(ErrorMessage = "فیلد{0}اجباری است!")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }




        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        [Display(Name = "تاریخ تولد")]
        public DateTime Birthdate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }


        public bool IsActiv { get; set; }



        public User() { }

        public User(string Name, string Family, string Phonenumber, string Password, DateTime Birthdate)
        {
            this.Name = Name;
            this.Family = Family;
            this.Phonenumber = Phonenumber;
            this.Password = Password;
            DateTime dt = new DateTime();
            dt.ToString();
            this.Birthdate = dt;
            this.RegisterDate = DateTime.Now;
            RegisterDate.ToString();
            this.IsActiv = true;

        }
    }
}