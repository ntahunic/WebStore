using System.Data.Entity;
using Store.Data.Models;

namespace Store.Data.DB
{
    public class MyContext: DbContext
    {
        public MyContext() : base("Server=localhost,1433;Database=StoreTest;Integrated Security=true;MultipleActiveResultSets=true")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Input> Input { get; set; }
        public DbSet<InputDetails> InputDetails { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Output> Outputs { get; set; }
        public DbSet<OutputDetails> OutputDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
