using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpringDemo
{
    public class MvcApplication : Spring.Web.Mvc.SpringMvcApplication
    {


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            ControllerBuilder.Current.SetControllerFactory(typeof(Controllers.SpringControllerFactory));
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
    }
}
