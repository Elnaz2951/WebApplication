using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Model.layer
{
    //علائم
    public class Symptom
    {
        #region Constructor
        public Symptom() { }
        public Symptom(int ParentId,bool Isdangerous,string SymptomName)
        {
            this.ParentId = ParentId;
            this.Isdangerous = Isdangerous;
            this.SymptomName = SymptomName;
            this.RegisterDate = DateTime.Now;
        }
        #endregion

        #region Property
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public bool Isdangerous { get; set; }
        public string SymptomName { get; set; }
        public DateTime RegisterDate { get; set; }
        #endregion

        #region Navigation Property
        public virtual Symptom ParentSymptom { get; set; }
        #endregion
    }
}
