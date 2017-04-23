using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public bool Canceled { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
