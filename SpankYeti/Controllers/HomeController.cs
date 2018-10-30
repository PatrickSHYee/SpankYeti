using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpankYeti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Spank the Yeti: The Party Game of Questionable Decisions";
            ViewBag.Goal = "Goal";
            ViewBag.GoalMessage = "Each round, one player pairs up three Actions with three Objects, and the other players try to correctly predict his or her answers.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "THE PARTY GAME OF QUESTIONABLE DECISIONS";

            return View();
        }

        public ActionResult Draw()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewGame()
        {
            return View();
        }
    }
}