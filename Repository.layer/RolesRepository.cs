using Site.Model.layer;
using Site.Model.layer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Repository.layer 
{
    internal class RolesRepository : GenericRepository<Role>, IRolesRepository
    {
        public RolesRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
