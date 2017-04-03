using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookSaleWebsite;
using ModelPoco;


namespace Repository
{
    public class ProductRepository : IRepository<Product>
    {
        BookSaleEntities productContext;

        

        public ProductRepository()
        {
            productContext = new BookSaleEntities();

        }

        public ProductRepository(BookSaleEntities entities)
        {
         
            this.productContext = entities;
        }

        
         
    
        public List<Product> GetAll()
        {
            List<Product> allProducts = productContext.Products.ToList();

            return allProducts;
        }

        public  Product Find(int ID)
        {
            var product = productContext.Products.Find(ID);
            return product;
        }

        public int Add(Product entity)
        {
            productContext.Products.Add(entity);
            productContext.SaveChanges();
            return entity.ProductID;
        }

        public void Update(Product entity)
        {
            var product = productContext.Products.Find(entity.ProductID);

            if (product != null)
            {
                product.ISBN = entity.ISBN;
                product.Title = entity.Title;
                product.Author = entity.Author;
                product.Price = entity.Price;
                productContext.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            var product = productContext.Products.Find(entity.ProductID);

            if (product != null)
            {
                productContext.Products.Remove(product);

                productContext.SaveChanges();
            }

        }





        //public virtual object Products { get; set; }
    }
}
