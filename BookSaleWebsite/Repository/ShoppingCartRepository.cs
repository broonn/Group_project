using BookSaleWebsite;
using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository
{
    public class ShoppingCartRepository : IRepository<ShoppingCart>

    {
        BookSaleEntities shoppingCartContext;
       

        public ShoppingCartRepository()
        {
            shoppingCartContext = new BookSaleEntities();
        }

        public ShoppingCartRepository(BookSaleEntities entities)
        {
            
            this.shoppingCartContext = entities;
        }
        public List<ShoppingCart> GetAll()
        {
            List<ShoppingCart> allCart = shoppingCartContext.ShoppingCart.ToList();
            return allCart;
        }

        public ShoppingCart Find(int ID)
        {
            throw new NotImplementedException();
        }

        public int Add(ShoppingCart entity)
        {
            shoppingCartContext.ShoppingCart.Add(entity);
            shoppingCartContext.SaveChanges();

            return entity.ShoppingCartID;
        }

        public void Update(ShoppingCart entity)
        {
            var shoppingCart = shoppingCartContext.ShoppingCart.Find(entity.ShoppingCartID);

            if ( shoppingCart != null)
            {
                
                shoppingCart.Quantity = entity.Quantity;

                shoppingCartContext.SaveChanges();
            }
        }

        public void Delete(ShoppingCart entity)
        {
            var shoppingCart = shoppingCartContext.ShoppingCart.Find(entity.ShoppingCartID);

            if (shoppingCart != null)
            {
                shoppingCartContext.ShoppingCart.Remove(shoppingCart);

                shoppingCartContext.SaveChanges();
            }
        }
    }
}
