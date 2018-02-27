using DemoPage.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoPage
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            using(var dtx= new DataContext())
            {
                if (dtx.Settings.Count() == 0)
                {
                    new DemoDataFromDb(dtx);
                }
            }
        }
    }
}
