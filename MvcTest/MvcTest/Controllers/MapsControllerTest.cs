using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MvcTest;
using MvcTest.Controllers;

namespace MvcBasicWalkthrough.Tests.Controllers
{
    [TestClass]
    public class MapsControllerTest
    {
        [TestMethod]
        public void ViewMaps()
        {
            // Arrange
            MapsController controller = new MapsController();

            // Act
            ViewResult result = controller.ViewMaps() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
