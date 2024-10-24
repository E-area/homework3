using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookManager.Models;

namespace BookManager.Data
{
    public class BookManagerContext : DbContext
    {
        public BookManagerContext (DbContextOptions<BookManagerContext> options)
            : base(options)
        {
        }

        public DbSet<BookManager.Models.Book> Book { get; set; } = default!;
    }
}
