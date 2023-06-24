using Site.Model.layer;
using Site.Model.layer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Repository.layer
{
    public class NursesRepository : GenericRepository<Nurses>, INursesRepository
    {
        public NursesRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
