using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dependency_Injection.Services.Interfaces;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService, ITestService testService)
        {
            this._homeService = homeService;
            this._testService = testService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _homeService.GetMessage() + " " + _testService.MessageAgain();
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