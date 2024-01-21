using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class OrderDetails
    {
        public int Id { get; set; }

        // Relations

        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }

    }
}
