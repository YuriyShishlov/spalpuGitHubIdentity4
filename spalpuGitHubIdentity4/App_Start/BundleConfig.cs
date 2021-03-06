﻿using System.Web.Optimization;

namespace IdentitySample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        //"~/Scripts/jwplayer.js",
                        //"~/Scripts/videoplayer.js",
                        //"~/Scripts/metisMenu.js",
                        "~/Scripts/up.js",
                        "~/Scripts/startMenu.js",
                        "~/Scripts/history.js/history.js",
                        "~/Scripts/urlState.js",
                        "~/Scripts/close_modal.js"
                        ));
            //"~/Scripts/metisMenu.js"

            bundles.Add(new ScriptBundle("~/bundles/mobilejquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/up.js",
                        "~/Scripts/startMenu.js",
                        "~/Scripts/history.js/history.js",
                        "~/Scripts/urlState.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/less/bootstrap.css",
                      "~/Content/fonts-awesome/css/font-awesome.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/mobilecss").Include(
                      "~/Content/less/bootstrap.css",
                      //"~/Content/fonts-awesome/css/font-awesome.css",
                      "~/Content/SiteMobile.css"));
        }
    }
}
