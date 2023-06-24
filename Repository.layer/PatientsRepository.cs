using Site.Model.layer;
using Site.Model.layer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Repository.layer
{
    public class PatientsRepository : GenericRepository<Patients>,IPatientsRepository
    {
        public PatientsRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
