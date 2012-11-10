using System.Web;
using System.Web.Optimization;

namespace JK.mvc4cookie
{
  public class BundleConfig
  {
    // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Content/js/libs/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Content/js/libs/jquery.unobtrusive*",
                  "~/Content/js/libs/jquery.validate*"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Content/js/libs/modernizr-*"));

      bundles.Add(new ScriptBundle("~/js/site").Include(
        "~/Content/js/libs/consolelog.js",  //-- Cross browser js console.log
        "~/Content/js/libs/placeholder.js",    //-- IE input placeholder text
        "~/Content/js/libs/underscore.js",  //-- 'like' linq for js (set algebra functions)
        "~/Content/js/libs/backbone.js",  //-- Client side 'mvc like' framework
        "~/Content/js/libs/bootstrap.js",   //-- twitter bootstrap js extensions (modals/alerts and more)
        "~/Content/js/JK.js")); //-- Our apps JS global namespace

      bundles.Add(new StyleBundle("~/css/site").Include(
        "~/Content/css/libs/bootstrap.css",
        "~/Content/css/libs/bootstrap-responsive.css",
        "~/Content/css/global.css"));
    }
  }
}