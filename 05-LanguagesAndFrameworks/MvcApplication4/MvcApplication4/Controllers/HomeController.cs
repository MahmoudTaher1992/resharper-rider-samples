﻿using System;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      return View();
    }

    public ActionResult About()
    {
      String someJson = "{}";

      ViewBag.Message = "Your app description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

      public ActionResult NewMethod()
      {
          throw new NotImplementedException();
      }

    
  }
}
