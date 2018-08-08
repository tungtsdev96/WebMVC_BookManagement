using Fa.WebMVC.Model.Models;
using System.Data.Entity;

namespace Fa.WebMVC.DataAccessLayer.AccessDatabases
{
    public class BookManagementContext: DbContext
    {
        public BookManagementContext() : base("name=BookConnectionString")
        {
            Database.SetInitializer<BookManagementContext>(new BookManagementInitializer());
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookInPublisher> BookInPublishers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
