using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    private WordCount _myWordCount = new WordCount();

    [HttpGet("/home")]
    public ActionResult Home()
    {
      return View();
    }
    [HttpPost("/result")]
    public ActionResult SubmitResult()
    {
    if (_myWordCount.FieldCheck(Request.Form["user-word"], Request.Form["user-sentence"]) == "Please enter a word AND sentence")
    {
      string result = "Please enter a word AND sentence";
      return View("Result", result);
    }else{
      int result = _myWordCount.RepeatCounter(Request.Form["user-word"], Request.Form["user-sentence"]);
      return View("Result", result);
    }
    }
  }
}
