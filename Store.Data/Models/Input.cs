using System;

namespace Store.Data.Models
{
    public class Input
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string InputNumber { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public string Description { get; set; }

        public virtual Warehouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

    }
}
