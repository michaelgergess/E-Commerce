using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        
        //Relations
        public ICollection<Order> Orders { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
