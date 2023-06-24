using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;



namespace Site.App_Start
{
    public class BundleConfiguration
    {
        public static void RegisterBundle(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/Css").Include(
                    "~/Content/bootstrap-grid.min.css",
                    "~/Content/bootstrap-rtl.min.css",
                    "~/Content/bootstrap.min.css",
                                                         
                    "~/Content/bootstrap-rtl.css",
                     "~/Content/bootstrap-rtl.css.map",                   
                    "~/Content/bootstrap-rtl.min.css.map",
                       "~/ Content / bootstrap - datepicker.css",

                  "~/ Content / bootstrap - datepicker.fa.js",
                  "~/ Content / bootstrap - datepicker.fa.min.js",
                      "~/Content/bootstrap-datepicker.js" ,
                       "~/ Content / bootstrap - datepicker.min.css",
                       "~/ Content / bootstrap - datepicker.min.js",
                         "~/Content/site.css"







                ));


            bundles.Add(new Bundle("~/Scripts/js").Include(
                 "~/Scripts/modernizr-2.8.3.js",
                 "~/Scripts/modernizr-2.8.3.js",
                    "~/Scripts/bootstrap.bundle.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery.validate*"   ,

                  "~/ Content / bootstrap - datepicker.fa.js",
                  "~/ Content / bootstrap - datepicker.fa.min.js",
                      "~/Content/bootstrap-datepicker.js",
                       "~/ Content / bootstrap - datepicker.min.css",
                       "~/ Content / bootstrap - datepicker.min.js"








               ));
        }
    }
}