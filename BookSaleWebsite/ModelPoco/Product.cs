using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPoco
{
    public class Product
    {
        
        public int ProductID { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
                
        public decimal Price { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<ShoppingCart> Cart { get; set; }
    }
}
