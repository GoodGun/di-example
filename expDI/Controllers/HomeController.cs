using expDI.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace expDI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            DbOperations db = new DbOperations(new DI.WithCassandraDB());
            ViewBag.Sonuc = db.InsertEt();

            //asdjaskldjasd
            //asdasd
            //asdasdasd

            db = new DbOperations(new DI.WithPostgre());

            ViewBag.Sonuc2 = db.InsertEt();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}