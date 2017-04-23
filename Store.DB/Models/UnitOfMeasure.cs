using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class UnitOfMeasure
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
    }
}
