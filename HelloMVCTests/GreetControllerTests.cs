using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HelloMVC.Controllers;
using HelloMVC.Models;

namespace HelloMVCTests
{
    public class GreetControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<ViewResult>(result);



        }
        [Fact]
        public void Index_Passes_GreetModel_To_View()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<GreetModel>(result.Model);
        }

        [Fact]
        public void Index_Sets_Name_On_Model()
        {
            var expectedName = "ExampleString";

            var controller = new GreetController();

            var result = controller.Index(expectedName);

            var model = (GreetModel)result.Model;

            Assert.Equal(expectedName, model.Name);

        }

    }
}
