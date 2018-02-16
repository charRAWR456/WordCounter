using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/home")]
    public ActionResult Home()
    {
      return View();
    }
  }
}
