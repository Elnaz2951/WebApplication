using System;
using System.IO;

namespace Site.Model.layer
{
    public class HttpPostedFileBase
    {
        public static implicit operator FileStream(HttpPostedFileBase v)
        {
            throw new NotImplementedException();
        }
    }
}