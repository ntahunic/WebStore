namespace Store.Data.Models
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
