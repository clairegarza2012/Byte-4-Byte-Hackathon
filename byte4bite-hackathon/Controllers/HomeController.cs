using byte4bite_hackathon.Database;
using byte4bite_hackathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace byte4bite_hackathon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData(int id)
        {
            return Json($"This is some data from the server, you passed {id}");
        }

        public JsonResult CreatNewItem()
        {
            //edmx access example
            using (var context = new HackathonEntities())
            {
                //creates a new item
                var item = new Item()
                {
                    Name = "Green Beans",
                    Price = 1.00m
                };
                //adds the item to the database
                context.Items.Add(item);
                //executes the save of anything manipulated
                context.SaveChanges();
            }
            //json return to take actions on in the js
            return Json(false);
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

        public ActionResult Volunteer()
        {
            ViewBag.Message = "Your volunteer page.";

            return View();
        }
        [HttpPost]
        public ActionResult VolunteerForm()
        {
            VolunteerForm volunteer = new VolunteerForm()
            {
                FirstName = Request.Form.GetValues("fname").First(),
                LastName = Request.Form.GetValues("lname").First(),
                Email = Request.Form.GetValues("email").First(),
                PreferredSchool = Request.Form.GetValues("schools").First()
            };
            return View();
        }
    }
}