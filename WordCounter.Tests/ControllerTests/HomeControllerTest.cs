using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsHomeView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      IActionResult homeView = controller.Home();
      ViewResult result = homeView as ViewResult;

      //Assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
  }
}
