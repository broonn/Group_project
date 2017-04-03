using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPoco;
using BookSaleWebsite;
using System.Data.Entity;
using Repository;


namespace UnitTest
{
    [TestFixture]
    public class EFTests
    {
        [Test]
        public void Test_GetAll_ReturnProductID_WhenCalled()
        {
            //Arrange

           
            var testData = new List<Product>
            {
                new Product {ProductID= 1},
                new Product {ProductID = 2}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<Product>>();
            mockSet.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(testData.Provider);
            mockSet.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(testData.Expression);
            mockSet.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            mockSet.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());



            var mockContext = new Mock<BookSaleEntities>();
            mockContext.Setup(m => m.Products).Returns(mockSet.Object);


            var testClass = new ProductRepository(mockContext.Object);


            //Act
            var actual = testClass.GetAll();


            //Assert
            CollectionAssert.AreEqual(testData, actual);


        }

        [Test]

        public void Test_Add_CheckAdditionOfNewProduct_WhenAdded()

        {
            //Arrange
            Product newProduct = new Product();
            var mockSet = new Mock<IDbSet<Product>>();

            var mockContext = new Mock<BookSaleEntities>();

            mockContext.Setup(m => m.Products).Returns(mockSet.Object);

            //Act
            var testClass = new ProductRepository(mockContext.Object);
            testClass.Add(newProduct);

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<Product>()), Times.Once());
            
        }

        [Test]

        public void Test_GetAll_ReturnProductInCart_WhenCalled()
        {
            //Arrange 
            Product Book = new Product();
            var expected = new List<ShoppingCart>
            {
                new ShoppingCart {Title = Book}
            };

            var testData = new List<ShoppingCart>
            {
                new ShoppingCart {Title = Book}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<ShoppingCart>>();
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.Provider).Returns(testData.Provider);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.Expression).Returns(testData.Expression);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.ElementType).Returns(testData.ElementType);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.GetEnumerator()).Returns(testData.GetEnumerator());

            var mockContext = new Mock<BookSaleEntities>();
            mockContext.Setup(m => m.ShoppingCart).Returns(mockSet.Object);

            var testClass = new ShoppingCartRepository(mockContext.Object);

            //Act
            var actual = testClass.GetAll();

            //Assert

            CollectionAssert.AreEqual(testData, actual);
            
        }

        [Test]
        public void Test_Add_CheckAdditionOfProducts_WhenAdded()
        {
            //Arrange
            ShoppingCart product = new ShoppingCart();
            var mockSet = new Mock<IDbSet<ShoppingCart>>();

            var mockContext = new Mock<BookSaleEntities>();
            mockContext.Setup(m => m.ShoppingCart).Returns(mockSet.Object);

            //Act
            var test = new ShoppingCartRepository(mockContext.Object);
            test.Add(product);

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<ShoppingCart>()), Times.Once());

        }

        [Test]
        public void Test_Add_ReturnAddedOrderDetail_WhenAdded()
        {
            //Arrange
            Orders firstOrder = new Orders();
            var mockSet = new Mock<IDbSet<Orders>>();
            var mockContext = new Mock<BookSaleEntities>();
            mockContext.Setup(m => m.Order).Returns(mockSet.Object);

            //Act
            var testClass = new OrdersRepository(mockContext.Object);
            testClass.Add(firstOrder);

            //Assert

            mockSet.Verify(m => m.Add(It.IsAny<Orders>()), Times.Once());

        }

        [Test]
        public void Test_GetAll_ReturnOrderDetail_WhenCalled()
        {
            var expected = new List<Orders>
            {
                new Orders {OrdersID = 1}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<Orders>>();
            mockSet.As<IQueryable<Orders>>().Setup(m => m.Provider).Returns(expected.Provider);
            mockSet.As<IQueryable<Orders>>().Setup(m => m.Expression).Returns(expected.Expression);
            mockSet.As<IQueryable<Orders>>().Setup(m => m.ElementType).Returns(expected.ElementType);
            mockSet.As<IQueryable<Orders>>().Setup(m => m.GetEnumerator()).Returns(expected.GetEnumerator());

            var mockContext = new Mock<BookSaleEntities>();
            mockContext.Setup(m => m.Order).Returns(mockSet.Object);

            var testClass = new OrdersRepository(mockContext.Object);

            //Act
            var actual = testClass.GetAll();

            //Assert

            CollectionAssert.AreEqual(expected, actual);


            
        }
    }
}

