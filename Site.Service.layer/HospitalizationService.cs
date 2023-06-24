using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Model.layer;
using Site.Model.layer.Context;

namespace Site.Service.layer
{
    public class HospitalizationService : EntityService<Hospitalization>, IHospitalizationService
    {
        public HospitalizationService(SiteContext context) : base(context)
        {
        }
    }
}
