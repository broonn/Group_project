using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ModelPoco
{
    public class ShoppingCart
    {

        public int ShoppingCartID { get; set; }
        public Product ProductID { get; set; }
        public Product Title { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double SubTotal { get; set; }     
        

    }
}
