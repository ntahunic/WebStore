using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class InputDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public virtual Input Input { get; set; }
        public int InputId { get; set; }
    }
}
