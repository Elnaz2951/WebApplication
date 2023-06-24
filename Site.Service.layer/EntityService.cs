using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Model.layer;
using Site.Model.layer.Context;
using Site.Repository.layer;

namespace Site.Service.layer
{
    public class EntityService<T> : GenericRepository<T> where T : class
    {
        public EntityService(SiteContext context) : base(context)
        {
        }
    }
}
