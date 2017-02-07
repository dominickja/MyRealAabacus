using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAbacus.Models;

namespace MyAbacus.Controllers
{
    public class HomeController : Controller

    {
        [HttpPost]

        public ActionResult AabacusMath(MyAbacusViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Math = new MyAbacusDomainModel(model.Number1, model.Number2);

                model.Answer = Math.Answer;

                return View("Index", model);
            }
            else
            {
                return View("Index", model);
            }
        }


        [HttpGet]
        public ActionResult Index()
        {
            var model = new MyAbacusViewModel();
            return View(model);
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