using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreWebApp.ProductServiceReference;
using BookStoreWebApp.ShoppingServiceReference;
using ModelPoco;
using BookSaleWebsite;

namespace BookStoreWebApp.Controllers
{

    public class ShoppingCartController : Controller
    {
        private BookSaleEntities book = new BookSaleEntities();
        
        public ActionResult Index()
        {
            return View("Index");
        }

        private int Existing(int id) 
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Pr.ProductID == id)
                    return i;
            return -1;
        }

        public ActionResult Delete(int id)
        {
            int index = Existing(id);
            List<Item> cart = (List<Item>)Session["cart"];           


            if (cart[index].Quantity == 1)
            {
                cart.RemoveAt(index);
            }
           else if (cart[index].Quantity >= 1)
            {
                cart[index].Quantity--;
            }                   

          
            Session["cart"] = cart;

            Logger.WriteToLog("An Item Deleted");

            return View("Cart");
        }

        public ActionResult Cart(int id)
        {
            if (Session["cart"] == null)
            {

                List<Item> cart = new List<Item>();
                cart.Add(new Item(book.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                
                List<Item> cart = (List<Item>)Session["cart"];
                int index = Existing(id);
                if (index == -1)
                    cart.Add(new Item(book.Products.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }

            Logger.WriteToLog("An Item Bought");

            return View("Cart");
        }

    }
}



