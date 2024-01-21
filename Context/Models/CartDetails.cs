using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class CartDetails
    {
        public int Id { get; set; }

        // Relations
       
        public Product Products { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
