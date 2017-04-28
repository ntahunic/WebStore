using System;

namespace Store.Data.Models
{
    public class Output
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string OutputNumber { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public double TotalWithTax { get; set; }
        public bool Confirmed { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
    }
}
