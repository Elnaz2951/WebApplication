using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Model.layer;
using Site.Model.layer.Context;

namespace Site.Repository.layer
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(HospitalDbContext context) : base(context)
        {
        }
    }
}
