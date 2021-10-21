using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Models
{
    public class BookStoresDBContext :DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=localhost;Initial Catalog=BookStoresDB;Integrated Security=True");

        }
    }
}
