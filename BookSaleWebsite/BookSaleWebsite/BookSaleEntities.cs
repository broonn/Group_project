using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelPoco;


namespace BookSaleWebsite
{
   public  class BookSaleEntities : DbContext

    {
        public virtual IDbSet<Orders> Order { get; set; }
        public virtual IDbSet<Product> Products { get; set; }
        public virtual IDbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual IDbSet<Customer> Customer { get; set; }



        
    }
}
