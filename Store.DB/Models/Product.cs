using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class Product
    {
        public int Id { get; set; }
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
