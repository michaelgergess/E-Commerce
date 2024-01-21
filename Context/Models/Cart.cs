using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Context
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        //Relations
        public virtual ICollection<CartDetails> CartDetail { get; set; }
        public virtual User User { get; set; }
    }
}
