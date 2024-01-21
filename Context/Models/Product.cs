using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        // Relationships
        public int ProductCategoryId { get; set; } // Foreign key

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

       
        public virtual ICollection<CartDetails> CartDetails { get; set; }

       
        public virtual Admin Admin { get; set; }
    }
}
