namespace program1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderDB : DbContext
    {
        public OrderDB()
            : base("name=Model1")
        {
        }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
