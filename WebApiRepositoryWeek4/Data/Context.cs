using Microsoft.EntityFrameworkCore;
using WebApiRepositoryWeek4.Models;

namespace WebApiRepositoryWeek4.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions options): base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

        //public DbSet<Product1> Product1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasOne<Categories>(product => product.Categories)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId);

            modelBuilder.Entity<Orders>()
                .HasOne<Products>(order => order.Products)
                .WithMany(product => product.Orders)
                .HasForeignKey(order => order.ProductID);

            modelBuilder.Entity<Orders>()
                .HasOne<Users>(order => order.Users)
                .WithMany(user => user.Orders)
                .HasForeignKey(order => order.UserId);

            modelBuilder.Entity<Contacts>()
                .HasOne<Users>(contact => contact.Users)
                .WithMany(user => user.Contacts)
                .HasForeignKey(contact => contact.UserId);

            modelBuilder.Entity<Cart>()
                .HasOne<Products>(cart => cart.Products)
                .WithMany(categories => categories.Cart)
                .HasForeignKey(cart => cart.ProductId);

            modelBuilder.Entity<Cart>()
                .HasOne<Users>(cart => cart.Users)
                .WithMany(categories => categories.Cart)
                .HasForeignKey(cart => cart.UserId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
