using Site.Model.layer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Model.layer;

namespace Site.Repository.layer
{
    public class OutpatientVisit : GenericRepository<OutpatientVisit>, IOutpatientVisit
    {
        public OutpatientVisit(HospitalDbContext context) : base(context)
        {
        }
    }
}
