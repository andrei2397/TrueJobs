using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;


namespace TrueJobs.Controllers
{
    public class HomeController : Controller
    {

        private JobsEntities2 db = new JobsEntities2();
        public ActionResult Index()
        {

            var userCount = db.Users.Count();
            var companyCount = db.Companies.Count();
            var jobsCount = db.Jobs.Count();
            var interestsCount = db.Interests.Count();

            ViewBag.userCount = userCount;
            ViewBag.companyCount = companyCount;
            ViewBag.jobsCount = jobsCount;
            ViewBag.interestsCount = interestsCount;
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