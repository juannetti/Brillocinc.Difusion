using System.Web;
using System.Web.Optimization;

namespace Brillocinc.Difusion
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
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
                      "~/Scripts/bootstrap.js"));
                    //"~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/scrollbar.css",
                      "~/Content/revolution-slider.css",
                      "~/Content/font-awesome.css",
                      "~/Content/responsive.css",
                      "~/Content/style.css"));

            ////  template scripts
            //bundles.Add(new ScriptBundle("~/bundles/templateScripts").Include(
            //         "~/Scripts/bxslider.js",
            //         "~/Scripts/isotope.js",
            //         "~/Scripts/jquery.bootstrap-touchspin.js",
            //         "~/Scripts/jquery.easing.min.js",
            //         "~/Scripts/jquery.js",
            //         "~/Scripts/revolution.min.js",
            //         "~/Scripts/jquery.fancybox.pack.js",
            //         "~/Scripts/jquery.fancybox-media.js",                    
            //         "~/Scripts/owl.js",
            //         "~/Scripts/wow.js",
            //         "~/Scripts/script.js",
            //         "~/Scripts/map-script.js",
            //         "~/Scripts/mixitup.js",
            //         "~/Scripts/nouislider.js",
            //         "~/Scripts/respond.js",
            //         "~/Scripts/validate.js",
            //         "~/Scripts/jquery.nav.js",
            //         "~/Scripts/jquery.scrollTo.js",
            //         "~/Scripts/scrollbar.js"
            //         ));
        }
    }
}
