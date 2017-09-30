using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/lib/jquery").Include(
                        "~/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/js/lib/bootstrap").Include(
                      "~/js/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/js/lib/datatables").Include(
                        "~/js/lib/jquery.dataTables.min.js",
                        "~/js/lib/dataTables.bootstrap.min.js",
                        "~/js/lib/dataTables.colReorder.min.js"));

            bundles.Add(new ScriptBundle("~/js/lib/jqueryui").Include(
                        "~/js/lib/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/jquery.dataTables.min.css",
                      "~/css/jquery.dataTables_themeroller.css",
                      "~/css/dataTables.bootstrap.min.css",
                      "~/css/colReorder.dataTables.min.css",
                      "~/css/jquery-ui.min.css",
                      "~/css/jquery-ui.structure.min.css",
                      "~/css/jquery-ui.theme.min.csss",
                      "~/css/site.css"
                      ));
        }
    }
}
