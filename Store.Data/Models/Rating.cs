using System;

namespace Store.Data.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
