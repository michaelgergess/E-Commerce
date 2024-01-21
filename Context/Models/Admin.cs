using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Admin
    {

        public int Id { get; set; }
        public string Name { get; set; }

        // Self-referencing relationship
        [ForeignKey("admin")]
        public int? AdmanId { get; set; }  // Change the property name for clarity
        public Admin admin { get; set; }

        public ICollection<ProductCategory> Category { get; set; }
        public ICollection<Product> Product { get; set; }

    }
}
