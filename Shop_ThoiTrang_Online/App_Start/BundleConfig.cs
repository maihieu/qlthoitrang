using System.Web;
using System.Web.Optimization;

namespace Shop_ThoiTrang_Online
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/html5shiv.js",
                      "~/Scripts/jquery.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/main.js",
                      "~/Scripts/price-range.js",
                      "~/Scripts/contact.js"));

           

            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/bootstrap.css",
               "~/Content/responsive.css",
               "~/Content/animate.css",
                "~/Content/font-awesome.min.css",
                "~/Content/main.css",
                "~/Content/prettyPhoto.css",
                "~/Content/price-range.css"));


            //admin
            bundles.Add(new ScriptBundle("~/bundles/admin/script").Include(
                    "~/Areas/Admin/script/metisMenu/metisMenu.min.js",
                    "~/Areas/Admin/script/sb-admin-2.js",
                    "~/Areas/Admin/script/jquery/jquery.js",
                    "~/Areas/Admin/script/bootstrap/bootstrap.min.js",
                    "~/Areas/Admin/vendor/datatables/js/jquery.dataTables.min.js",
                    "~/Areas/Admin/vendor/datatables/js/dataTables.bootstrap.min.js",
                    "~/Areas/Admin/vendor/datatables-responsive/dataTables.responsive.js"
                  ));
             

               bundles.Add(new StyleBundle("~/Content/admin-css").Include(
                      "~/Areas/Admin/content/bootstrap.css",
                      "~/Areas/Admin/content/metisMenu.min.css",
                      "~/Areas/Admin/content/sb-admin-2.css",
                       "~/Content/font-awesome.min.css",
                       "~/Areas/Admin/vendor/datatables-plugins/dataTables.bootstrap.css",
                       "~/Areas/Admin/vendor/datatables-responsive/dataTables.responsive.css"
                      ));
        }
    }
}
