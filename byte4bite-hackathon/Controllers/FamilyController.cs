using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace byte4bite_hackathon.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFamilies()
        {
            //get families
            var families = new List<string>();
            return Json(families);
        }
    }
}