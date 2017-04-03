using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreWebApp.ProductServiceReference;
using ModelPoco;
using BookSaleWebsite;


namespace BookStoreWebApp.Controllers
{
    public class ProductController : Controller
    {
        
        RepositoryOf_ProductClient productClient;
        public ProductController()
        {
            productClient = new RepositoryOf_ProductClient();
        }
        // GET: Product
        public ActionResult Index()
        {
            List<Product> allProducts = productClient.GetAll().ToList();
            return View(allProducts);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product product = productClient.Find(id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                productClient.Add(product);                                             

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
        

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = productClient.Find(id);
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                // TODO: Add update logic here
                productClient.Update(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = productClient.Find(id);
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Product productToDelete = new Product() { ProductID = id };
                // TODO: Add delete logic here
                productClient.Delete(productToDelete);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


        }

        public ActionResult Buy(int id, Product product)
        {
            return View();
        }

      
    }
}
