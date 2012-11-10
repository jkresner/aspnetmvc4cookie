using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JK.mvc4cookie.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.Message = ViewBag.Message = "WELCOME TO MVC4 COOKIE.";

      return View();
    }
  }
}
