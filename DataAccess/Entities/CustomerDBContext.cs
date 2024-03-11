using Microsoft.EntityFrameworkCore;



namespace DataAccess.Entities
{
    public class CustomerDBContext : DbContext
    {
        //1- which connection string

        public CustomerDBContext(DbContextOptions options) : base(options) { }

        //2- which model
        public DbSet<Customer> Customers { get; set; }

       // 3- optional: initial value for table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Alex",
                    Age = 33,
                    Postcode = "SO14 5DH",
                    Height = 1.5
                },
                new Customer
                {
                    Id = 2,
                    Name = "Anna",
                    Age = 20,
                    Postcode = "NW10 7DD",
                    Height = 1
                },
                new Customer
                {
                    Id = 3,
                    Name = "Andrew",
                    Age = 15,
                    Postcode = "NN20 8HD",
                    Height = 2
                }
                );
        }
    }
}
