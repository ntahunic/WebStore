namespace Store.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Fname { get; set; }
        public string Lname{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string PasswordHash{ get; set; }
        public bool Status { get; set; }
    }
}
