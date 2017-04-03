using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelPoco
{
    public class Orders
    {
        [Required]
        public int OrdersID { get; set; }

        
        public int PaymentID { get; set; }

        public ICollection<ShoppingCart> Cart { get; set; }
       
                
    }
}
