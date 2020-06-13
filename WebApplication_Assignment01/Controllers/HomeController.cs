using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Assignment01.Models;

namespace WebApplication_Assignment01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            return View("HomePage");
        }
        public ViewResult Introduction()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Registration(VisitorResponse visitorResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(visitorResponse);
                return View("FinalPage", visitorResponse);
            }
            else
            {
                return View();
            }

            //}

        }
    }
}
