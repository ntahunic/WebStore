﻿namespace Store.Data.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Web{ get; set; }
        public string Email { get; set; }
        public string BankAccount { get; set; }
        public bool Status { get; set; }
    }
}
