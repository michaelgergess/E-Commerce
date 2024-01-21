using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Relations
        public ICollection<Product> Products { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
