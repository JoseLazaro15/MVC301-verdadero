using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using System.Web.Routing;

using System.Web.Optimization;
namespace MVC301
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        protected void Application_Start()

        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}