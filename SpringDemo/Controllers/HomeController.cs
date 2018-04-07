using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpringDemo.Service;

namespace SpringDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Name { set; get; }

        public ITestService UseService { set; get; }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.Name = this.Name;
            return View();
        }
	}
}