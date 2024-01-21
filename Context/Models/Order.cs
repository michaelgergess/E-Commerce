using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public enum StateOrder
    {
        HHJJ,
        JJJJK

    }
    public class Order
    {
        public int Id { get; set; }
        public StateOrder StateOrder { get; set; }
        //Relations
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
        public virtual User User { get; set; }

    }
}
