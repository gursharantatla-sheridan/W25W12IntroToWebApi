using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using W25W12IntroToWebApi.Models;

namespace W25W12IntroToWebApi.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;

        // data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "HTML", Price = 10 },
                new Book { Id = 2, Title = "Java", Price = 20 },
                new Book { Id = 3, Title = "C#", Price = 30 }
            );
        }
    }
}
