using System;

namespace Store.Data.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
