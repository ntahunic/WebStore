namespace Store.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public string Picture { get; set; }
        public string PictureThumb { get; set; }

        public virtual ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public int UnitOfMeasureId { get; set; }
    }
}
