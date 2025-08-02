using LibraryHubAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryHubAPI.Data
{
    public class LibraryHubDbContext : DbContext
    {
        public LibraryHubDbContext(DbContextOptions<LibraryHubDbContext> options) : base(options){}

        public DbSet<Book> Books => Set<Book>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
                new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
                new Book { Id = 4, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", YearPublished = 1954 },
                new Book { Id = 5, Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937 }
            );
        }
    }
}
