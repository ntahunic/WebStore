using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
