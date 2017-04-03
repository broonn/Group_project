using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using BookStoreWebApp.Controllers;
using ModelPoco;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Index_ReturnsIndexView_WhenCalled()
        {
            //Arrange
            var expected = "Index";
            ShoppingCartController TestController = new ShoppingCartController();

            //Act
            var actual = TestController.Index() as ViewResult; 
            //Assert
            Assert.AreEqual(expected, actual.ViewName);

        }

        [TestMethod]
        public void Test_Details_ReturnsProductDetailsView_WhenCalled()
        {
            Product product = new Product();
            //Arrange
            Product expected = product;
            ProductController TestController = new ProductController();

            //Act
            var actual = TestController.Details(7);
            //Assert
            Assert.AreEqual(expected, actual);

        }

       



    }
}
