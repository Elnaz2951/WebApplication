using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Model.layer;
using Site.Model.layer.Context;

namespace Site.Service.layer
{
    public class ActionTypeService : EntityService<ActionType>, IActionTypeService
    {
        public ActionTypeService(SiteContext context) : base(context)
        {
        }
    }
}
