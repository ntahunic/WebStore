using System;

namespace Store.Data.Models
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
