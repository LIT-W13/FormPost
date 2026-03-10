using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models; 

namespace WebApplication10.Controllers
{
    public class PostDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormPost(string value)
        {
            return View(new FormSubmissionViewModel
            {
                Value = value
            });
        }
    }
}