using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomHtmlHelper1.Models;

namespace CustomHtmlHelper1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var model = new TestViewModel();
            model.Name = "Test";
            return View(model);
        }
    }
}