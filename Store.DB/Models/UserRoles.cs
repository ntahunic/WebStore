using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DB.Models
{
    public class UserRoles
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
